using System;

namespace FFmpeg.AutoGen.Bindings.DynamicallyLoaded;

public static unsafe partial class ffmpeg
{
    /// <summary>Clip a signed integer value into the amin-amax range.</summary>
    /// <param name="a">value to clip</param>
    /// <param name="amin">minimum value of the clip range</param>
    /// <param name="amax">maximum value of the clip range</param>
    /// <returns>clipped value</returns>
    public static int av_clip_c(int @a, int @amin, int @amax)
{
    {
    if (a < amin) return amin;
    else if (a > amax) return amax;
    else return a;
    }
}
    // original body hash: FGSX8EvLhMgYqP9+0z1+Clej4HxjpENDPDX7uAYLx6k=
    
    /// <summary>Clip a signed 64bit integer value into the amin-amax range.</summary>
    /// <param name="a">value to clip</param>
    /// <param name="amin">minimum value of the clip range</param>
    /// <param name="amax">maximum value of the clip range</param>
    /// <returns>clipped value</returns>
    public static long av_clip64_c(long @a, long @amin, long @amax)
{
    {
    if (a < amin) return amin;
    else if (a > amax) return amax;
    else return a;
    }
}
    // original body hash: FGSX8EvLhMgYqP9+0z1+Clej4HxjpENDPDX7uAYLx6k=
    
    /// <summary>Reinterpret a double as a 64-bit integer.</summary>
    public static ulong av_double2int(double @f)
{
    {
    return *(ulong*)&f;
    }
}
    // original body hash: 2HuHK8WLchm3u+cK6H4QWhflx2JqfewtaSpj2Cwfi8M=
    
    /// <summary>Reinterpret a float as a 32-bit integer.</summary>
    public static uint av_float2int(float @f)
{
    {
    return *(uint*)&f;
    }
}
    // original body hash: uBvsHd8EeFnxDvSdDE1+k5Um29kCuf0aEJhAvDy0wZk=
    
    /// <summary>Reinterpret a 64-bit integer as a double.</summary>
    public static double av_int2double(ulong @i)
{
    {
    return *(double*)&i;
    }
}
    // original body hash: iFt3hVHTpF9jjqIGAAf/c7FrGfenOXGxdsyMjmrbwvw=
    
    /// <summary>Reinterpret a 32-bit integer as a float.</summary>
    public static float av_int2float(uint @i)
{
    {
    return *(float*)&i;
    }
}
    // original body hash: wLGFPpW+aIvxW79y6BVY1LKz/j7yc3BdiaJ7mD4oQmw=
    
    /// <summary>Invert a rational.</summary>
    /// <param name="q">value</param>
    /// <returns>1 / q</returns>
    public static AVRational av_inv_q(AVRational @q)
{
    {
    var r = new AVRational {
    num = q.den, den = q.num
};
    return r;
    }
}
    // original body hash: sXbO4D7vmayAx56EFqz9C0kakcSPSryJHdk0hr0MOFY=
    
    /// <summary>Fill the provided buffer with a string containing an error string corresponding to the AVERROR code errnum.</summary>
    /// <param name="errbuf">a buffer</param>
    /// <param name="errbuf_size">size in bytes of errbuf</param>
    /// <param name="errnum">error code to describe</param>
    /// <returns>the buffer in input, filled with the error description</returns>
    public static byte* av_make_error_string(byte* @errbuf, ulong @errbuf_size, int @errnum)
{
    {
    av_strerror(errnum, errbuf, errbuf_size);
    return errbuf;
    }
}
    // original body hash: DRHQHyLQNo9pTxA+wRw4zVDrC7Md1u3JWawQX0BVkqE=
    
    /// <summary>Create an AVRational.</summary>
    public static AVRational av_make_q(int @num, int @den)
{
    {
    var r = new AVRational {
    num = num, den = den
};
    return r;
    }
}
    // original body hash: IAPYNNcg3GX0PGxINeLQhb41dH921lPVKcnqxCk7ERA=
    
    /// <summary>Convert an AVRational to a `double`.</summary>
    /// <param name="a">AVRational to convert</param>
    /// <returns>`a` in floating-point form</returns>
    public static double av_q2d(AVRational @a)
{
    {
    return a.num / (double)a.den;
    }
}
    // original body hash: j4R2BS8nF6czcUDVk5kKi9nLEdlTI/NRDYtnc1KFeyE=
    
}
