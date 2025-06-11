using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Generation;

/// <summary>
/// Translates C inline function bodies to valid C# code
/// </summary>
internal static class CInlineFunctionBodyTranslator
{
    private static readonly Dictionary<string, string> TypeMappings = new()
    {
        { "int8_t", "sbyte" },
        { "int16_t", "short" },
        { "int32_t", "int" },
        { "int64_t", "long" },
        { "uint8_t", "byte" },
        { "uint16_t", "ushort" },
        { "uint32_t", "uint" },
        { "uint64_t", "ulong" },
        { "size_t", "nuint" },
        { "ssize_t", "nint" }
    };

    private static readonly Dictionary<string, string> ConstantMappings = new()
    {
        { "9223372036854775807LL", "long.MaxValue" },
        { "-9223372036854775807LL - 1", "long.MinValue" },
        { "2147483647", "int.MaxValue" },
        { "-2147483647 - 1", "int.MinValue" },
        { "INT_MIN", "int.MinValue" },
        { "INT_MAX", "int.MaxValue" },
        { "LLONG_MIN", "long.MinValue" },
        { "LLONG_MAX", "long.MaxValue" }
    };

    /// <summary>
    /// Translates a C inline function body to C# syntax
    /// </summary>
    public static string TranslateToCs(string cBody)
    {
        if (string.IsNullOrWhiteSpace(cBody))
            return cBody;

        var result = cBody;

        // Step 1: Handle C variable declarations
        result = TranslateCVariableDeclarations(result);

        // Step 2: Handle C struct initialization
        result = TranslateCStructInitialization(result);

        // Step 3: Handle C union usage
        result = TranslateCUnionUsage(result);

        // Step 4: Replace C types with C# equivalents
        result = TranslateCTypes(result);

        // Step 5: Handle C cast syntax
        result = TranslateCCasts(result);

        // Step 6: Handle C constants and literals
        result = TranslateCConstants(result);

        // Step 7: Handle C builtin functions
        result = TranslateCBuiltins(result);

        // Step 8: Handle pointer arithmetic
        result = TranslatePointerArithmetic(result);

        // Step 9: Clean up formatting
        result = CleanUpFormatting(result);

        // Step 10: Final validation - check for obvious syntax errors
        result = ValidateAndFixSyntax(result);

        return result;
    }

    private static string TranslateCVariableDeclarations(string code)
    {
        // Replace "const type var = value;" with "var var = (type)value;"
        // Example: const int64_t tmp = ... becomes var tmp = (long)...
        var regex = new Regex(@"const\s+(\w+)\s+(\w+)\s*=", RegexOptions.Multiline);
        code = regex.Replace(code, match =>
        {
            var type = match.Groups[1].Value;
            var varName = match.Groups[2].Value;
            var csType = TypeMappings.TryGetValue(type, out var mapped) ? mapped : type;
            return $"var {varName} =";
        });

        // Replace "type var;" with "var var;" but exclude return statements
        // Look for type declarations at line start but exclude "return" statements
        regex = new Regex(@"^\s*(?!return\s)(\w+)\s+(\w+);", RegexOptions.Multiline);
        code = regex.Replace(code, "var $2;");

        return code;
    }

    private static string TranslateCStructInitialization(string code)
    {
        // Replace "StructType var = {field1, field2};" with "var var = new StructType { FieldName = field1, ... };"
        // For AVRational specifically: AVRational r = {val1, val2}; -> var r = new AVRational { num = val1, den = val2 };
        var regex = new Regex(@"AVRational\s+(\w+)\s*=\s*\{([^}]+)\};?", RegexOptions.Multiline);
        code = regex.Replace(code, match =>
        {
            var varName = match.Groups[1].Value;
            var values = match.Groups[2].Value.Split(',');
            if (values.Length == 2)
            {
                var val1 = values[0].Trim();
                var val2 = values[1].Trim();
                // For AVRational in C: {num, den} is the typical order
                return $"var {varName} = new AVRational {{ num = {val1}, den = {val2} }};";
            }
            return match.Value; // Fallback to original if we can't parse
        });

        // Handle the pattern without explicit type (just variable assignment)
        // Pattern: "r = {val1, val2};" where r is already declared  
        regex = new Regex(@"(\w+)\s*=\s*\{([^}]+)\};?", RegexOptions.Multiline);
        code = regex.Replace(code, match =>
        {
            var varName = match.Groups[1].Value;
            var values = match.Groups[2].Value.Split(',');
            if (values.Length == 2)
            {
                var val1 = values[0].Trim();
                var val2 = values[1].Trim();
                // Assume this is AVRational based on context
                return $"{varName} = new AVRational {{ num = {val1}, den = {val2} }};";
            }
            return match.Value; // Fallback to original if we can't parse
        });

        return code;
    }

    private static string TranslateCUnionUsage(string code)
    {
        // Replace C union usage with unsafe pointer casting
        // union av_intfloat32 v; v.f = f; return v.i; 
        // becomes: return *(uint*)&f;
        
        // Handle av_intfloat32 (float <-> uint) - allow multiline and various spacing
        var regex = new Regex(@"union\s+av_intfloat32\s+(\w+);\s*\1\.f\s*=\s*(\w+);\s*return\s+\1\.i;", 
            RegexOptions.Multiline | RegexOptions.Singleline);
        code = regex.Replace(code, "return *(uint*)&$2;");

        // Handle av_intfloat64 (double <-> ulong)
        regex = new Regex(@"union\s+av_intfloat64\s+(\w+);\s*\1\.f\s*=\s*(\w+);\s*return\s+\1\.i;", 
            RegexOptions.Multiline | RegexOptions.Singleline);
        code = regex.Replace(code, "return *(ulong*)&$2;");

        // Handle reverse: union av_intfloat32 v; v.i = i; return v.f;
        regex = new Regex(@"union\s+av_intfloat32\s+(\w+);\s*\1\.i\s*=\s*(\w+);\s*return\s+\1\.f;", 
            RegexOptions.Multiline | RegexOptions.Singleline);
        code = regex.Replace(code, "return *(float*)&$2;");

        regex = new Regex(@"union\s+av_intfloat64\s+(\w+);\s*\1\.i\s*=\s*(\w+);\s*return\s+\1\.f;", 
            RegexOptions.Multiline | RegexOptions.Singleline);
        code = regex.Replace(code, "return *(double*)&$2;");

        // Handle more flexible union patterns with line breaks
        regex = new Regex(@"union\s+av_intfloat32\s+(\w+);\r?\n\s*\1\.f\s*=\s*(\w+);\r?\n\s*return\s+\1\.i;", 
            RegexOptions.Multiline);
        code = regex.Replace(code, "return *(uint*)&$2;");

        regex = new Regex(@"union\s+av_intfloat64\s+(\w+);\r?\n\s*\1\.f\s*=\s*(\w+);\r?\n\s*return\s+\1\.i;", 
            RegexOptions.Multiline);
        code = regex.Replace(code, "return *(ulong*)&$2;");

        regex = new Regex(@"union\s+av_intfloat32\s+(\w+);\r?\n\s*\1\.i\s*=\s*(\w+);\r?\n\s*return\s+\1\.f;", 
            RegexOptions.Multiline);
        code = regex.Replace(code, "return *(float*)&$2;");

        regex = new Regex(@"union\s+av_intfloat64\s+(\w+);\r?\n\s*\1\.i\s*=\s*(\w+);\r?\n\s*return\s+\1\.f;", 
            RegexOptions.Multiline);
        code = regex.Replace(code, "return *(double*)&$2;");

        return code;
    }

    private static string TranslateCTypes(string code)
    {
        // Replace C types with C# equivalents
        foreach (var mapping in TypeMappings)
        {
            // Use word boundaries to avoid partial matches
            var pattern = @"\b" + Regex.Escape(mapping.Key) + @"\b";
            code = Regex.Replace(code, pattern, mapping.Value);
        }

        return code;
    }

    private static string TranslateCCasts(string code)
    {
        // Replace C-style casts with C# casts
        // (type) becomes (type)
        // (const type *const *) becomes (type**)
        
        // Handle complex const pointer patterns: (const uint8_t *const *)
        var regex = new Regex(@"\(const\s+(\w+_t)\s*\*\s*const\s*\*\s*\)", RegexOptions.Multiline);
        code = regex.Replace(code, match =>
        {
            var cType = match.Groups[1].Value;
            var csType = TypeMappings.TryGetValue(cType, out var mapped) ? mapped : cType;
            return $"({csType}**)";
        });

        // Handle complex pointer casts like (const AVFrameSideData *const *)
        regex = new Regex(@"\(const\s+(\w+)\s*\*\s*const\s*\*\s*\)", RegexOptions.Multiline);
        code = regex.Replace(code, "($1**)");

        // Handle simple const pointer patterns: (const type *)
        regex = new Regex(@"\(const\s+(\w+_t|\w+)\s*\*\s*\)", RegexOptions.Multiline);
        code = regex.Replace(code, match =>
        {
            var cType = match.Groups[1].Value;
            var csType = TypeMappings.TryGetValue(cType, out var mapped) ? mapped : cType;
            return $"({csType}*)";
        });

        // Handle intptr_t casts and pointer conditional expressions
        code = Regex.Replace(code, @"\(void\s*\*\s*\)\s*\(intptr_t\s*\)", "(void*)");
        
        // Handle pattern: (void *)(intptr_t)(p ? p : x) -> (void*)(p != null ? p : x)
        code = Regex.Replace(code, @"\(void\s*\*\s*\)\s*\(intptr_t\s*\)\s*\(([^?]+)\?\s*([^:]+):\s*([^)]+)\)", 
            "(void*)($1 != null ? $2 : $3)");

        // Handle C unsigned int cast to C# uint
        code = Regex.Replace(code, @"\(unsigned\s+int\)", "(uint)");

        return code;
    }

    private static string TranslateCConstants(string code)
    {
        // Replace C constants with C# equivalents
        foreach (var mapping in ConstantMappings)
        {
            code = code.Replace(mapping.Key, mapping.Value);
        }

        // Remove C literal suffixes
        code = Regex.Replace(code, @"(\d+)ULL\b", "$1UL");
        code = Regex.Replace(code, @"(\d+)LL\b", "$1L");
        code = Regex.Replace(code, @"(\d+)U\b", "$1U");

        return code;
    }

    private static string TranslateCBuiltins(string code)
    {
        // For builtin functions, mark them for manual conversion and comment out the code
        var builtinPattern = @"__builtin_\w+";
        if (Regex.IsMatch(code, builtinPattern))
        {
            // Comment out the original code and add a placeholder
            var commentedCode = string.Join("\n", code.Split('\n').Select(line => "// " + line));
            return commentedCode + "\n" + 
                   "throw new NotImplementedException(\"Function contains __builtin functions that need manual C# implementation\");";
        }

        return code;
    }

    private static string TranslatePointerArithmetic(string code)
    {
        // Handle specific pointer arithmetic patterns
        // Most of these should already be handled by the C cast translation
        return code;
    }

    private static string CleanUpFormatting(string code)
    {
        // Clean up multiple spaces and normalize formatting
        code = Regex.Replace(code, @"\s+", " ");
        code = Regex.Replace(code, @"\s*{\s*", " {\n    ");
        code = Regex.Replace(code, @"\s*}\s*", "\n}");
        code = Regex.Replace(code, @";\s*", ";\n    ");
        code = code.Replace("    \n", "\n");
        
        return code.Trim();
    }

    private static string ValidateAndFixSyntax(string code)
    {
        // Check for common syntax errors that would prevent compilation
        var hasErrors = false;
        var errorMessages = new List<string>();

        // Check for missing parentheses
        if (Regex.IsMatch(code, @":\s*\([^)]*;"))
        {
            hasErrors = true;
            errorMessages.Add("Missing closing parenthesis");
        }

        // Check for unmatched braces
        var openBraces = code.Count(c => c == '{');
        var closeBraces = code.Count(c => c == '}');
        if (openBraces != closeBraces)
        {
            hasErrors = true;
            errorMessages.Add("Unmatched braces");
        }

        // Check for unmatched parentheses
        var openParens = code.Count(c => c == '(');
        var closeParens = code.Count(c => c == ')');
        if (openParens != closeParens)
        {
            hasErrors = true;
            errorMessages.Add("Unmatched parentheses");
        }

        // Check for incomplete statements (lines ending with semicolon but missing closing parenthesis)
        if (Regex.IsMatch(code, @"\([^)]*;\s*$", RegexOptions.Multiline))
        {
            hasErrors = true;
            errorMessages.Add("Incomplete statements");
        }

        // Check for complex expressions that likely need manual conversion
        // These patterns indicate complex logic that the automatic translator can't handle well
        var complexPatterns = new[]
        {
            @"\s+&\s+~",           // Bitwise operations like "& ~255"
            @"\?\s*[^:]+\s*:",     // Ternary operators with complex expressions
            @"\s+\|\s+\d+",        // Bitwise OR with numbers
            @"\s+\^\s+",           // XOR operations
            @"<<\s+\w+\)\s*-",     // Shift operations with arithmetic
            @"void\*.*\?",         // Complex pointer conditionals
            @"\(\w+\s+-\s+\d+U\)\s*<<",  // Expressions like (x - 1U) << that cause type issues
            @"return\s+\w+\(",     // Function calls in return statements likely need type casting
            @"\d+U\s*<<",          // Unsigned literals with shifts
            @">>\s*\d+\s*\&",      // Shift right with bitwise AND
            @"if\s*\(\s*\w+\s*&\s*\(",  // if (variable & (expression)) - int to bool conversion
            @"return\s+\(\s*~\w+\)\s*>>", // return (~variable) >> - likely type conversion issue
            @"return\s+\w+;.*byte", // return int where byte expected (check function signature)
            @"return\s+\w+;.*short", // return int where short expected
            @"\(\s*byte\*\*\s*\)\s*\w+",   // (byte**)variable - byte_ptr4 to byte** conversion issues
            @"\(\s*\w+\s*\+\s*\(\s*\w+\s*>>\s*\d+\)\s*\)", // Complex expressions with shifts in parentheses
        };

        foreach (var pattern in complexPatterns)
        {
            if (Regex.IsMatch(code, pattern))
            {
                hasErrors = true;
                errorMessages.Add("Complex expressions requiring manual conversion");
                break;
            }
        }

        // If there are syntax errors or complex patterns, comment out the code and provide a placeholder
        if (hasErrors)
        {
            var commentedCode = string.Join("\n", code.Split('\n').Select(line => "// " + line));
            return commentedCode + "\n" + 
                   $"throw new NotImplementedException(\"Function has syntax errors or complex patterns: {string.Join(", ", errorMessages)}. Manual conversion required.\");";
        }

        return code;
    }
}