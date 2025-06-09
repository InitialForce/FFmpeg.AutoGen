using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Bindings;

/// <summary>
/// Represents a long double value for FFmpeg interop.
/// This is a placeholder type to handle long double from C.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct LongDouble
{
    // Use 16 bytes to match most long double implementations
    private readonly ulong _low;
    private readonly ulong _high;

    public LongDouble(double value)
    {
        // Simple conversion - this is just for compatibility
        _low = BitConverter.ToUInt64(BitConverter.GetBytes(value), 0);
        _high = 0;
    }

    public static implicit operator LongDouble(double value) => new(value);

    public static implicit operator double(LongDouble longDouble)
    {
        return BitConverter.ToDouble(BitConverter.GetBytes(longDouble._low), 0);
    }

    public override string ToString() => ((double)this).ToString();
}