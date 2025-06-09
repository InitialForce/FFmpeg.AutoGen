using System.Collections.Generic;
using System.Linq;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal sealed class FunctionsGenerator : GeneratorBase<ExportFunctionDefinition>
{
    private const string SuppressUnmanagedCodeSecurityAttribute = "[SuppressUnmanagedCodeSecurity]";
    private const string UnmanagedFunctionPointerAttribute = "[UnmanagedFunctionPointer(CallingConvention.Cdecl)]";
    public FunctionsGenerator(string path, GenerationContext context) : base(path, context) => IsTypeGenerationOn = true;

    public bool IsFacadeGenerationOn { get; set; }
    public bool IsVectorsGenerationOn { get; set; }
    public bool IsStaticallyLinkedGenerationOn { get; set; }
    public bool IsDynamicallyLinkedGenerationOn { get; set; }
    public bool IsDynamicallyLoadedGenerationOn { get; set; }

    public static void GenerateFacade(string path, GenerationContext context)
    {
        using var g = new FunctionsGenerator(path, context);
        g.IsFacadeGenerationOn = true;
        g.Generate();
    }

    public static void GenerateVectors(string path, GenerationContext context)
    {
        using var g = new FunctionsGenerator(path, context);
        g.IsVectorsGenerationOn = true;
        g.Generate();
    }


    public static void GenerateStaticallyLinked(string path, GenerationContext context)
    {
        using var g = new FunctionsGenerator(path, context);
        g.IsStaticallyLinkedGenerationOn = true;
        g.Generate();
    }

    public static void GenerateDynamicallyLinked(string path, GenerationContext context)
    {
        using var g = new FunctionsGenerator(path, context);
        g.IsDynamicallyLinkedGenerationOn = true;
        g.Generate();
    }

    public static void GenerateDynamicallyLoaded(string path, GenerationContext context)
    {
        using var g = new FunctionsGenerator(path, context);
        g.IsDynamicallyLoadedGenerationOn = true;
        g.Generate();
    }

    public override IEnumerable<string> Usings()
    {
        yield return "System";
        yield return "System.Runtime.InteropServices";
        if (!Context.IsLegacyGenerationOn && (IsStaticallyLinkedGenerationOn || IsDynamicallyLinkedGenerationOn || IsDynamicallyLoadedGenerationOn))
            yield return "FFmpeg.AutoGen.Abstractions";
    }

    protected override void GenerateDefinitions(ExportFunctionDefinition[] functions)
    {
        if (IsDynamicallyLoadedGenerationOn)
        {
            WriteLine("public static bool ThrowErrorIfFunctionNotFound;");
            WriteLine("public static IFunctionResolver FunctionResolver;");
            WriteLine();
        }

        base.GenerateDefinitions(functions);

        if (IsStaticallyLinkedGenerationOn || IsDynamicallyLinkedGenerationOn || IsDynamicallyLoadedGenerationOn)
        {
            WriteLine("public unsafe static void Initialize()");

            using (BeginBlock())
                if (IsDynamicallyLoadedGenerationOn)
                {
                    WriteLine("if (FunctionResolver == null) FunctionResolver = FunctionResolverFactory.Create();");
                    WriteLine();
                    functions.ToList().ForEach(GenerateDynamicallyLoaded);
                }
                else
                    functions.ToList().ForEach(f => WriteLine($"vectors.{f.Name} = {f.Name};"));
        }
    }

    protected override void GenerateDefinition(ExportFunctionDefinition function)
    {
        if (IsFacadeGenerationOn) GenerateFacadeFunction(function);
        if (IsVectorsGenerationOn) GenerateVector(function);
        if (IsStaticallyLinkedGenerationOn) GenerateDllImport(function, "__Internal");
        if (IsDynamicallyLinkedGenerationOn) GenerateDllImport(function, $"{function.LibraryName}-{function.LibraryVersion}");
    }

    public void GenerateFacadeFunction(ExportFunctionDefinition function)
    {
        var parameterNames = ParametersHelper.GetParameterNames(function.Parameters);
        var parameters = ParametersHelper.GetParameters(function.Parameters, Context.IsLegacyGenerationOn, false);

        this.WriteSummary(function);
        function.Parameters.ToList().ForEach(p => this.WriteParam(p, p.Name));
        this.WriteReturnComment(function);
        this.WriteObsoletion(function);
        WriteLine($"public static {function.ReturnType.Name} {function.Name}({parameters}) => vectors.{function.Name}({parameterNames});");
        WriteLine();

        // Generate ref overloads for all functions with double pointer parameters
        GenerateRefOverloads(function);
    }

    private void GenerateRefOverloads(ExportFunctionDefinition function)
    {
        // Find parameters that are double pointers and could benefit from ref overloads
        var doublePointerParams = function.Parameters
            .Where(p => p.Type.Name.EndsWith("**") && !p.ByReference && !p.IsConstant)
            .ToList();


        if (!doublePointerParams.Any())
            return;

        // Generate overloads for each combination of ref parameters
        foreach (var param in doublePointerParams)
        {
            var modifiedParameters = function.Parameters.Select(p =>
            {
                if (p == param)
                {
                    // Convert double pointer to ref single pointer
                    var singlePointerType = p.Type.Name.Substring(0, p.Type.Name.Length - 1); // Remove one *
                    return new FunctionParameter
                    {
                        Name = p.Name,
                        Type = p.Type with { Name = singlePointerType },
                        ByReference = true,
                        IsConstant = p.IsConstant
                    };
                }
                return p;
            }).ToArray();

            var refParameters = ParametersHelper.GetParameters(modifiedParameters, Context.IsLegacyGenerationOn, false);

            this.WriteSummary(function);
            modifiedParameters.ToList().ForEach(p => this.WriteParam(p, p.Name));
            this.WriteReturnComment(function);
            this.WriteObsoletion(function);

            // Generate ref overload with proper method body instead of expression body
            WriteLine($"public static {function.ReturnType.Name} {function.Name}({refParameters})");
            WriteLine("{");

            // Create the call with proper pointer handling
            var callParams = string.Join(", ", function.Parameters.Select(p =>
            {
                if (p == param)
                {
                    return $"&@{p.Name}";
                }
                return $"@{p.Name}";
            }));

            WriteLine($"    fixed ({param.Type.Name.Substring(0, param.Type.Name.Length - 1)}* ptr = &@{param.Name})");
            WriteLine($"    {{");
            var returnKeyword = function.ReturnType.Name == "void" ? "" : "return ";
            WriteLine($"        {returnKeyword}vectors.{function.Name}({string.Join(", ", function.Parameters.Select(p => p == param ? "ptr" : $"@{p.Name}"))});");
            WriteLine($"    }}");
            WriteLine("}");
            WriteLine();

        }
    }

    private void GenerateRefOverloadsForDllImport(ExportFunctionDefinition function, string libraryName)
    {
        // Find parameters that are double pointers and could benefit from ref overloads
        var doublePointerParams = function.Parameters
            .Where(p => p.Type.Name.EndsWith("**") && !p.ByReference && !p.IsConstant)
            .ToList();

        if (!doublePointerParams.Any())
            return;

        // Generate overloads for each combination of ref parameters
        foreach (var param in doublePointerParams)
        {
            var modifiedParameters = function.Parameters.Select(p =>
            {
                if (p == param)
                {
                    // Convert double pointer to ref single pointer
                    var singlePointerType = p.Type.Name.Substring(0, p.Type.Name.Length - 1); // Remove one *
                    return new FunctionParameter
                    {
                        Name = p.Name,
                        Type = p.Type with { Name = singlePointerType },
                        ByReference = true,
                        IsConstant = p.IsConstant
                    };
                }
                return p;
            }).ToArray();

            var refParameters = ParametersHelper.GetParameters(modifiedParameters, Context.IsLegacyGenerationOn, false);

            this.WriteSummary(function);
            modifiedParameters.ToList().ForEach(p => this.WriteParam(p, p.Name));
            this.WriteReturnComment(function);
            this.WriteObsoletion(function);

            // Generate ref overload that calls the original DllImport function
            WriteLine($"public static {function.ReturnType.Name} {function.Name}({refParameters})");
            WriteLine("{");

            WriteLine($"    fixed ({param.Type.Name.Substring(0, param.Type.Name.Length - 1)}* ptr = &@{param.Name})");
            WriteLine($"    {{");
            var returnKeyword = function.ReturnType.Name == "void" ? "" : "return ";
            WriteLine($"        {returnKeyword}{function.Name}({string.Join(", ", function.Parameters.Select(p => p == param ? "ptr" : $"@{p.Name}"))});");
            WriteLine($"    }}");
            WriteLine("}");
            WriteLine();
        }
    }

    public void GenerateVector(ExportFunctionDefinition function)
    {
        GenerateDelegateType(function);
        var functionDelegateName = GetFunctionDelegateName(function);
        WriteLine($"public static {functionDelegateName} {function.Name};"); // todo => throw new NotSupportedException();");
        WriteLine();
    }

    private void GenerateDllImport(ExportFunctionDefinition function, string libraryName)
    {
        this.WriteSummary(function);
        function.Parameters.ToList().ForEach(x => this.WriteParam(x, x.Name));
        this.WriteReturnComment(function);

        this.WriteObsoletion(function);
        if (Context.SuppressUnmanagedCodeSecurity) WriteLine(SuppressUnmanagedCodeSecurityAttribute);

        WriteLine($"[DllImport(\"{libraryName}\", CallingConvention = CallingConvention.Cdecl)]");
        function.ReturnType.Attributes.ToList().ForEach(WriteLine);

        var parameters = ParametersHelper.GetParameters(function.Parameters, Context.IsLegacyGenerationOn);
        WriteLine($"public static extern {function.ReturnType.Name} {function.Name}({parameters});");
        WriteLine();

        // Generate ref overloads for DllImport functions too
        GenerateRefOverloadsForDllImport(function, libraryName);
    }

    private void GenerateDynamicallyLoaded(ExportFunctionDefinition function)
    {
        var delegateParameters = ParametersHelper.GetParameters(function.Parameters, Context.IsLegacyGenerationOn, false);

        var functionFieldName = $"vectors.{function.Name}";
        WriteLine($"{functionFieldName} = ({delegateParameters}) =>");

        using (BeginBlock(true))
        {
            var functionDelegateName = GetFunctionDelegateName(function);
            var getDelegate = $"FunctionResolver.GetFunctionDelegate<vectors.{functionDelegateName}>(\"{function.LibraryName}\", \"{function.Name}\", ThrowErrorIfFunctionNotFound)";
            WriteLine($"{functionFieldName} = {getDelegate} ?? delegate {{ throw new NotSupportedException(); }};");
            var returnCommand = function.ReturnType.Name == "void" ? string.Empty : "return ";
            var parameterNames = ParametersHelper.GetParameterNames(function.Parameters);
            WriteLine($"{returnCommand}{functionFieldName}({parameterNames});");
        }

        WriteLine(";");
        WriteLine();
    }


    private void GenerateDelegateType(ExportFunctionDefinition function)
    {
        var functionDelegateName = GetFunctionDelegateName(function);
        if (Context.SuppressUnmanagedCodeSecurity) WriteLine(SuppressUnmanagedCodeSecurityAttribute);
        WriteLine(UnmanagedFunctionPointerAttribute);
        function.ReturnType.Attributes.ToList().ForEach(WriteLine);
        var parameters = ParametersHelper.GetParameters(function.Parameters, Context.IsLegacyGenerationOn);
        WriteLine($"public delegate {function.ReturnType.Name} {functionDelegateName}({parameters});");
    }

    private static string GetFunctionDelegateName(ExportFunctionDefinition function) => $"{function.Name}_delegate";
}
