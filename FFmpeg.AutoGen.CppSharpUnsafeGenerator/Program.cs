using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CppSharp.AST;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processing;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator;

internal class Program
{
    internal static void Main(string[] args)
    {
        var options = CliOptions.ParseArgumentsStrict(args);

        if (options.Verbose)
        {
            Console.WriteLine($"Working path: {Environment.CurrentDirectory}");
            Console.WriteLine($"Solution path: {options.SolutionDir}");
            Console.WriteLine($"FFmpeg headers path: {options.FFmpegIncludesDir}");
            Console.WriteLine($"FFmpeg binaries path: {options.FFmpegBinDir}");
            Console.WriteLine($"Namespace name: {options.Namespace}");
            Console.WriteLine($"Type name: {options.TypeName}");
        }

        // parse headers
        var astContexts = Parse(options.FFmpegIncludesDir).ToList();

        // process
        var functionExports = FunctionExportHelper.LoadFunctionExports(options.FFmpegBinDir).ToArray();
        var processingContext = new ProcessingContext
        {
            IgnoreUnitNames = new HashSet<string> { "__NSConstantString_tag" },
            TypeAliases = { { "int64_t", typeof(long) } },
            WellKnownMacros =
            {
                { "FFERRTAG", typeof(int) }, 
                { "MKTAG", typeof(int) },
                { "UINT64_C", typeof(ulong) },
                { "AV_VERSION_INT", typeof(int) },
                { "AV_VERSION", typeof(string) },
                { "_DHUGE_EXP", typeof(int) }, 
                { "_DMAX", typeof(long) }, 
                { "_FMAX", typeof(long) }, 
                { "_LMAX", typeof(long) }
            },
            FunctionExportMap = functionExports
                .GroupBy(x => x.Name)
                .Select(x => x.First()) // Eliminate duplicated names
                .ToDictionary(x => x.Name),
            NoCustomStringMarshal = options.NoCustomStringMarshal,
        };
        var processor = new ASTProcessor(processingContext);
        astContexts.ForEach(processor.Process);

        // generate files
        var inlineFunctions = ExistingInlineFunctionsHelper.LoadInlineFunctions(Path.Combine(options.SolutionDir, "FFmpeg.AutoGen/generated/FFmpeg.functions.inline.g.cs"));
        var generationContext = new GenerationContext
        {
            Namespace = options.Namespace,
            TypeName = options.TypeName,
            SuppressUnmanagedCodeSecurity = options.SuppressUnmanagedCodeSecurity,
            LibraryVersionMap = functionExports
                .Select(x => new { x.LibraryName, x.LibraryVersion })
                .Distinct()
                .ToDictionary(x => x.LibraryName, x => x.LibraryVersion),
            Definitions = processingContext.Definitions.ToArray(),
            ExistingInlineFunctionMap = inlineFunctions.ToDictionary(f => f.Name),
            SolutionDir = options.SolutionDir,
            FileHeader = options.FileHeader,
        };

        GenerateLegacyFFmpegAutoGen(generationContext);
        GenerateAbstractions(generationContext);
        GenerateStaticallyLinkedBindings(generationContext);
        GenerateDynamicallyLinkedBindings(generationContext);
        GenerateDynamicallyLoadedBindings(generationContext);
        GenerateDllImportBindings(generationContext);
    }

    private static IEnumerable<ASTContext> Parse(string includesDir)
    {
        var p = new Parser
        {
            IncludeDirs = new[] { includesDir },
            Defines = new[] { "__STDC_CONSTANT_MACROS" }
        };

        // libavutil
        yield return p.Parse("libavutil/avutil.h");
        yield return p.Parse("libavutil/audio_fifo.h");
        yield return p.Parse("libavutil/channel_layout.h");
        yield return p.Parse("libavutil/cpu.h");
        yield return p.Parse("libavutil/display.h");
        yield return p.Parse("libavutil/file.h");
        yield return p.Parse("libavutil/frame.h");
        yield return p.Parse("libavutil/opt.h");
        yield return p.Parse("libavutil/imgutils.h");
        yield return p.Parse("libavutil/time.h");
        yield return p.Parse("libavutil/timecode.h");
        yield return p.Parse("libavutil/tree.h");
        yield return p.Parse("libavutil/hwcontext.h");
        yield return p.Parse("libavutil/hwcontext_dxva2.h");
        yield return p.Parse("libavutil/hwcontext_d3d11va.h");
        yield return p.Parse("libavutil/hdr_dynamic_metadata.h");
        yield return p.Parse("libavutil/mastering_display_metadata.h");

        // libswresample
        yield return p.Parse("libswresample/swresample.h");

        // libswscale
        yield return p.Parse("libswscale/swscale.h");

        // libavcodec
        yield return p.Parse("libavcodec/avcodec.h");
        yield return p.Parse("libavcodec/bsf.h");
        yield return p.Parse("libavcodec/dxva2.h");
        yield return p.Parse("libavcodec/d3d11va.h");

        // libavformat
        yield return p.Parse("libavformat/avformat.h");

        // libavfilter
        yield return p.Parse("libavfilter/avfilter.h");
        yield return p.Parse("libavfilter/buffersrc.h");
        yield return p.Parse("libavfilter/buffersink.h");

        // libavdevice
        yield return p.Parse("libavdevice/avdevice.h");
    }

    private static void GenerateLegacyFFmpegAutoGen(GenerationContext baseContext)
    {
        var context = baseContext with
        {
            IsLegacyGenerationOn = true,
            OutputDir = Path.Combine(baseContext.SolutionDir, @"FFmpeg.AutoGen\generated")
        };

        LibrariesGenerator.Generate($"{context.TypeName}.libraries.g.cs", context);
        MacrosGenerator.Generate($"{context.TypeName}.macros.g.cs", context);
        EnumsGenerator.Generate("Enums.g.cs", context);
        DelegatesGenerator.Generate("Delegates.g.cs", context);
        FixedArraysGenerator.Generate("Arrays.g.cs", context);
        StructuresGenerator.Generate("Structs.g.cs", context);
        FunctionsGenerator.GenerateFacade($"{context.TypeName}.functions.facade.g.cs", context);
        // InlineFunctionsGenerator.Generate($"{context.TypeName}.functions.inline.g.cs", context);
        FunctionsGenerator.GenerateVectors("vectors.g.cs", context with { TypeName = "vectors" });
        FunctionsGenerator.GenerateDynamicallyLoaded("DynamicallyLoadedBindings.g.cs", context with { TypeName = "DynamicallyLoadedBindings" });
    }

    private static void GenerateAbstractions(GenerationContext baseContext)
    {
        // Abstractions project now only contains hand-written utility code
        // All generated types are included in each binding project to avoid conflicts
        // No generated files needed here
    }

    private static void CopyAbstractionsFiles(string targetDirectory, string targetNamespace)
    {
        var abstractionsDir = Path.Combine(Directory.GetCurrentDirectory(), "FFmpeg.AutoGen.Abstractions");
        var abstractionsFiles = new[]
        {
            "ConstCharPtrMarshaler.cs",
            "FFmpeg.cs", 
            "IFixedArray.cs",
            "UTF8Marshaler.cs"
        };

        foreach (var fileName in abstractionsFiles)
        {
            var sourcePath = Path.Combine(abstractionsDir, fileName);
            var targetPath = Path.Combine(targetDirectory, fileName);
            
            if (File.Exists(sourcePath))
            {
                var content = File.ReadAllText(sourcePath);
                // Update namespace to match binding project
                content = content.Replace("namespace FFmpeg.AutoGen.Abstractions;", $"namespace {targetNamespace};");
                File.WriteAllText(targetPath, content);
            }
        }
    }

    private static void GenerateStaticallyLinkedBindings(GenerationContext baseContext)
    {
        var context = baseContext with
        {
            Namespace = $"{baseContext.Namespace}.Bindings.StaticallyLinked", TypeName = "ffmpeg",
            OutputDir = Path.Combine(baseContext.SolutionDir, @"FFmpeg.AutoGen.Bindings.StaticallyLinked\generated"),
            ExistingInlineFunctionMap = new Dictionary<string, InlineFunctionDefinition>() // Use empty map for binding projects
        };
        
        // Copy abstractions files to make project self-contained
        CopyAbstractionsFiles(context.OutputDir, context.Namespace);
        
        // Generate all common types
        MacrosGenerator.Generate($"{context.TypeName}.macros.g.cs", context);
        EnumsGenerator.Generate("Enums.g.cs", context);
        DelegatesGenerator.Generate("Delegates.g.cs", context);
        FixedArraysGenerator.Generate("Arrays.g.cs", context);
        StructuresGenerator.Generate("Structs.g.cs", context);
        
        // Generate inline functions
        InlineFunctionsGenerator.Generate($"{context.TypeName}.functions.inline.g.cs", context);
        
        // Generate functions
        FunctionsGenerator.GenerateStaticallyLinked("ffmpeg.g.cs", context);
    }

    private static void GenerateDynamicallyLinkedBindings(GenerationContext baseContext)
    {
        var context = baseContext with
        {
            Namespace = $"{baseContext.Namespace}.Bindings.DynamicallyLinked", TypeName = "ffmpeg",
            OutputDir = Path.Combine(baseContext.SolutionDir, @"FFmpeg.AutoGen.Bindings.DynamicallyLinked\generated"),
            ExistingInlineFunctionMap = new Dictionary<string, InlineFunctionDefinition>() // Use empty map for binding projects
        };

        // Copy abstractions files to make project self-contained
        CopyAbstractionsFiles(context.OutputDir, context.Namespace);

        // Generate all common types
        MacrosGenerator.Generate($"{context.TypeName}.macros.g.cs", context);
        EnumsGenerator.Generate("Enums.g.cs", context);
        DelegatesGenerator.Generate("Delegates.g.cs", context);
        FixedArraysGenerator.Generate("Arrays.g.cs", context);
        StructuresGenerator.Generate("Structs.g.cs", context);
        
        // Generate inline functions
        InlineFunctionsGenerator.Generate($"{context.TypeName}.functions.inline.g.cs", context);
        
        // Generate functions
        FunctionsGenerator.GenerateDynamicallyLinked("ffmpeg.g.cs", context);
    }

    private static void GenerateDynamicallyLoadedBindings(GenerationContext baseContext)
    {
        var context = baseContext with
        {
            Namespace = $"{baseContext.Namespace}.Bindings.DynamicallyLoaded", TypeName = "ffmpeg",
            OutputDir = Path.Combine(baseContext.SolutionDir, @"FFmpeg.AutoGen.Bindings.DynamicallyLoaded\generated"),
            ExistingInlineFunctionMap = new Dictionary<string, InlineFunctionDefinition>() // Use empty map for binding projects
        };

        // Copy abstractions files to make project self-contained
        CopyAbstractionsFiles(context.OutputDir, context.Namespace);

        // Generate all common types
        MacrosGenerator.Generate($"{context.TypeName}.macros.g.cs", context);
        EnumsGenerator.Generate("Enums.g.cs", context);
        DelegatesGenerator.Generate("Delegates.g.cs", context);
        FixedArraysGenerator.Generate("Arrays.g.cs", context);
        StructuresGenerator.Generate("Structs.g.cs", context);
        
        // Generate inline functions
        InlineFunctionsGenerator.Generate($"{context.TypeName}.functions.inline.g.cs", context);
        
        // Generate library info and functions
        LibrariesGenerator.Generate("ffmpeg.libraries.g.cs", context);
        FunctionsGenerator.GenerateDynamicallyLoaded("ffmpeg.g.cs", context);
    }

    private static void GenerateDllImportBindings(GenerationContext baseContext)
    {
        var context = baseContext with
        {
            Namespace = $"{baseContext.Namespace}.Bindings.DllImport", TypeName = "ffmpeg",
            OutputDir = Path.Combine(baseContext.SolutionDir, @"FFmpeg.AutoGen.Bindings.DllImport\generated"),
            ExistingInlineFunctionMap = new Dictionary<string, InlineFunctionDefinition>() // Use empty map for binding projects
        };

        // Copy abstractions files to make project self-contained
        CopyAbstractionsFiles(context.OutputDir, context.Namespace);

        // Generate all common types
        MacrosGenerator.Generate($"{context.TypeName}.macros.g.cs", context);
        EnumsGenerator.Generate("Enums.g.cs", context);
        DelegatesGenerator.Generate("Delegates.g.cs", context);
        FixedArraysGenerator.Generate("Arrays.g.cs", context);
        StructuresGenerator.Generate("Structs.g.cs", context);
        
        // Generate inline functions
        InlineFunctionsGenerator.Generate($"{context.TypeName}.functions.inline.g.cs", context);
        
        // Generate functions
        FunctionsGenerator.GenerateDllImport("ffmpeg.g.cs", context);
    }
}