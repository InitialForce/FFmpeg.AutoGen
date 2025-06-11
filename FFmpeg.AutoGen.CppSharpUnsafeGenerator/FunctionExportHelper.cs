using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator;

internal static class FunctionExportHelper
{
    public static IEnumerable<FunctionExport> LoadFunctionExports(string path)
    {
        var libraries = Directory.EnumerateFiles(path, "*.dll");

        foreach (var libraryPath in libraries)
        {
            var libraryFullName = Path.GetFileNameWithoutExtension(libraryPath);
            var libraryNameParts = libraryFullName.Split('-');

            string libraryName;
            int libraryVersion;

            // Handle different DLL naming conventions
            if (libraryNameParts.Length >= 3 && libraryNameParts[1] == "if" && int.TryParse(libraryNameParts[2], out libraryVersion))
            {
                // Format: avcodec-if-61.dll
                libraryName = libraryNameParts[0];
            }
            else if (libraryNameParts.Length >= 2 && int.TryParse(libraryNameParts[1], out libraryVersion))
            {
                // Format: libass-9.dll
                libraryName = libraryNameParts[0];
            }
            else
            {
                // Format: libaom.dll (no version) - use 0 as default version
                libraryName = libraryNameParts[0];
                libraryVersion = 0;
            }

            var exports = GetExports(libraryPath);
            foreach (var export in exports) yield return new FunctionExport
            {
                LibraryName = libraryName,
                LibraryVersion = libraryVersion,
                LibraryFileName = libraryFullName,
                Name = export
            };
        }
    }

    private static IEnumerable<string> GetExports(string library)
    {
        var hCurrentProcess = Process.GetCurrentProcess().Handle;

        if (!SymInitialize(hCurrentProcess, null, false)) throw new Exception("SymInitialize failed.");

        try
        {
            var baseOfDll = SymLoadModuleEx(hCurrentProcess, IntPtr.Zero, library, null, 0, 0, IntPtr.Zero, 0);
            if (baseOfDll == 0) throw new Exception($"SymLoadModuleEx failed for {library}.");

            var exports = new List<string>();

            bool EnumSyms(string name, ulong address, uint size, IntPtr context)
            {
                exports.Add(name);
                return true;
            }

            if (!SymEnumerateSymbols64(hCurrentProcess, baseOfDll, EnumSyms, IntPtr.Zero)) throw new Exception("SymEnumerateSymbols64 failed.");

            return exports;
        }
        finally
        {
            SymCleanup(hCurrentProcess);
        }
    }

    [DllImport("dbghelp", SetLastError = true, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SymInitialize(IntPtr hProcess, string userSearchPath, [MarshalAs(UnmanagedType.Bool)] bool fInvadeProcess);

    [DllImport("dbghelp", SetLastError = true, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SymCleanup(IntPtr hProcess);

    [DllImport("dbghelp", SetLastError = true, CharSet = CharSet.Unicode)]
    private static extern ulong SymLoadModuleEx(IntPtr hProcess, IntPtr hFile, string imageName, string moduleName, long baseOfDll, int dllSize, IntPtr data, int flags);

    [DllImport("dbghelp", SetLastError = true, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SymEnumerateSymbols64(IntPtr hProcess, ulong baseOfDll, SymEnumerateSymbolsProc64 enumSymbolsCallback, IntPtr userContext);

    private delegate bool SymEnumerateSymbolsProc64(string symbolName, ulong symbolAddress, uint symbolSize, IntPtr userContext);
}
