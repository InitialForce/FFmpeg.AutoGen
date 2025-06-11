using System;
using System.Collections.Generic;
using System.Linq;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

internal sealed class InlineFunctionsGenerator : GeneratorBase<InlineFunctionDefinition>
{
    public InlineFunctionsGenerator(string path, GenerationContext context) : base(path, context) => IsTypeGenerationOn = true;

    public static void Generate(string path, GenerationContext context)
    {
        using var g = new InlineFunctionsGenerator(path, context);
        g.Generate();
    }

    public override IEnumerable<string> Usings()
    {
        yield return "System";
    }

    protected override IEnumerable<InlineFunctionDefinition> Query(IEnumerable<InlineFunctionDefinition> functions) =>
        base.Query(functions).Select(RewriteFunctionBody);

    protected override void GenerateDefinition(InlineFunctionDefinition function)
    {
        function.ReturnType.Attributes.ToList().ForEach(WriteLine);
        var parameters = ParametersHelper.GetParameters(function.Parameters, Context.IsLegacyGenerationOn, false);

        this.WriteSummary(function);
        function.Parameters.ToList().ForEach(p => this.WriteParam(p, p.Name));
        this.WriteReturnComment(function);

        this.WriteObsoletion(function);
        WriteLine($"public static {function.ReturnType.Name} {function.Name}({parameters})");

        var lines = function.Body.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        lines.ForEach(WriteLineWithoutIntent);
        WriteLine($"// original body hash: {function.OriginalBodyHash}");
        WriteLine();
    }

    private InlineFunctionDefinition RewriteFunctionBody(InlineFunctionDefinition function)
    {
        // If we have an existing function with the same hash, use its manually crafted body
        if (Context.ExistingInlineFunctionMap.TryGetValue(function.Name, out var existing) &&
            function.OriginalBodyHash == existing.OriginalBodyHash)
        {
            return function with { Body = existing.Body };
        }

        // Attempt to translate the C body to C#
        var translatedBody = CInlineFunctionBodyTranslator.TranslateToCs(function.Body);

        // If translation failed or produced invalid code, generate a commented-out function
        if (string.IsNullOrWhiteSpace(translatedBody) ||
            translatedBody.Contains("MANUAL CONVERSION NEEDED") ||
            translatedBody.Contains("NotImplementedException"))
        {
            // Generate a commented-out function with the original C code for reference
            var lines = function.Body.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var commentedBody = "{\n    // TODO: Convert this C code to C#:\n" +
                               string.Join("\n", lines.Select(line => "    // " + line.Trim())) +
                               "\n    throw new NotImplementedException(\"Inline function not yet converted to C#\");\n}";
            return function with { Body = commentedBody };
        }

        return function with { Body = "{\n    " + translatedBody + "\n}" };
    }
}
