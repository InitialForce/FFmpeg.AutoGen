using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen;

public static unsafe partial class DynamicallyLoadedBindings
{
    public static bool ThrowErrorIfFunctionNotFound;
    public static IFunctionResolver FunctionResolver;
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_add_index_entry_delegate(AVStream* @st, long @pos, long @timestamp, int @size, int @distance, int @flags);
    private static av_add_index_entry_delegate? _av_add_index_entry_cache;
    
    /// <summary>Add an index entry into a sorted list. Update the entry if the list already contains it.</summary>
    /// <param name="timestamp">timestamp in the time base of the given stream</param>
    public static int av_add_index_entry(AVStream* @st, long @pos, long @timestamp, int @size, int @distance, int @flags)
    {
        _av_add_index_entry_cache ??= FunctionResolver.GetFunctionDelegate<av_add_index_entry_delegate>("avformat", "av_add_index_entry", ThrowErrorIfFunctionNotFound);
        if (_av_add_index_entry_cache == null)
            throw new NotSupportedException();
        return _av_add_index_entry_cache(@st, @pos, @timestamp, @size, @distance, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVRational av_add_q_delegate(AVRational @b, AVRational @c);
    private static av_add_q_delegate? _av_add_q_cache;
    
    /// <summary>Add two rationals.</summary>
    /// <param name="b">First rational</param>
    /// <param name="c">Second rational</param>
    /// <returns>b+c</returns>
    public static AVRational av_add_q(AVRational @b, AVRational @c)
    {
        _av_add_q_cache ??= FunctionResolver.GetFunctionDelegate<av_add_q_delegate>("avutil", "av_add_q", ThrowErrorIfFunctionNotFound);
        if (_av_add_q_cache == null)
            throw new NotSupportedException();
        return _av_add_q_cache(@b, @c);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate long av_add_stable_delegate(AVRational @ts_tb, long @ts, AVRational @inc_tb, long @inc);
    private static av_add_stable_delegate? _av_add_stable_cache;
    
    /// <summary>Add a value to a timestamp.</summary>
    /// <param name="ts_tb">Input timestamp time base</param>
    /// <param name="ts">Input timestamp</param>
    /// <param name="inc_tb">Time base of `inc`</param>
    /// <param name="inc">Value to be added</param>
    public static long av_add_stable(AVRational @ts_tb, long @ts, AVRational @inc_tb, long @inc)
    {
        _av_add_stable_cache ??= FunctionResolver.GetFunctionDelegate<av_add_stable_delegate>("avutil", "av_add_stable", ThrowErrorIfFunctionNotFound);
        if (_av_add_stable_cache == null)
            throw new NotSupportedException();
        return _av_add_stable_cache(@ts_tb, @ts, @inc_tb, @inc);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_append_packet_delegate(AVIOContext* @s, AVPacket* @pkt, int @size);
    private static av_append_packet_delegate? _av_append_packet_cache;
    
    /// <summary>Read data and append it to the current content of the AVPacket. If pkt-&gt;size is 0 this is identical to av_get_packet. Note that this uses av_grow_packet and thus involves a realloc which is inefficient. Thus this function should only be used when there is no reasonable way to know (an upper bound of) the final size.</summary>
    /// <param name="s">associated IO context</param>
    /// <param name="pkt">packet</param>
    /// <param name="size">amount of data to read</param>
    /// <returns>&gt;0 (read size) if OK, AVERROR_xxx otherwise, previous data will not be lost even if an error occurs.</returns>
    public static int av_append_packet(AVIOContext* @s, AVPacket* @pkt, int @size)
    {
        _av_append_packet_cache ??= FunctionResolver.GetFunctionDelegate<av_append_packet_delegate>("avformat", "av_append_packet", ThrowErrorIfFunctionNotFound);
        if (_av_append_packet_cache == null)
            throw new NotSupportedException();
        return _av_append_packet_cache(@s, @pkt, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVAudioFifo* av_audio_fifo_alloc_delegate(AVSampleFormat @sample_fmt, int @channels, int @nb_samples);
    private static av_audio_fifo_alloc_delegate? _av_audio_fifo_alloc_cache;
    
    /// <summary>Allocate an AVAudioFifo.</summary>
    /// <param name="sample_fmt">sample format</param>
    /// <param name="channels">number of channels</param>
    /// <param name="nb_samples">initial allocation size, in samples</param>
    /// <returns>newly allocated AVAudioFifo, or NULL on error</returns>
    public static AVAudioFifo* av_audio_fifo_alloc(AVSampleFormat @sample_fmt, int @channels, int @nb_samples)
    {
        _av_audio_fifo_alloc_cache ??= FunctionResolver.GetFunctionDelegate<av_audio_fifo_alloc_delegate>("avutil", "av_audio_fifo_alloc", ThrowErrorIfFunctionNotFound);
        if (_av_audio_fifo_alloc_cache == null)
            throw new NotSupportedException();
        return _av_audio_fifo_alloc_cache(@sample_fmt, @channels, @nb_samples);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_audio_fifo_drain_delegate(AVAudioFifo* @af, int @nb_samples);
    private static av_audio_fifo_drain_delegate? _av_audio_fifo_drain_cache;
    
    /// <summary>Drain data from an AVAudioFifo.</summary>
    /// <param name="af">AVAudioFifo to drain</param>
    /// <param name="nb_samples">number of samples to drain</param>
    /// <returns>0 if OK, or negative AVERROR code on failure</returns>
    public static int av_audio_fifo_drain(AVAudioFifo* @af, int @nb_samples)
    {
        _av_audio_fifo_drain_cache ??= FunctionResolver.GetFunctionDelegate<av_audio_fifo_drain_delegate>("avutil", "av_audio_fifo_drain", ThrowErrorIfFunctionNotFound);
        if (_av_audio_fifo_drain_cache == null)
            throw new NotSupportedException();
        return _av_audio_fifo_drain_cache(@af, @nb_samples);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_audio_fifo_free_delegate(AVAudioFifo* @af);
    private static av_audio_fifo_free_delegate? _av_audio_fifo_free_cache;
    
    /// <summary>Free an AVAudioFifo.</summary>
    /// <param name="af">AVAudioFifo to free</param>
    public static void av_audio_fifo_free(AVAudioFifo* @af)
    {
        _av_audio_fifo_free_cache ??= FunctionResolver.GetFunctionDelegate<av_audio_fifo_free_delegate>("avutil", "av_audio_fifo_free", ThrowErrorIfFunctionNotFound);
        if (_av_audio_fifo_free_cache == null)
            throw new NotSupportedException();
        _av_audio_fifo_free_cache(@af);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_audio_fifo_peek_delegate(AVAudioFifo* @af, void** @data, int @nb_samples);
    private static av_audio_fifo_peek_delegate? _av_audio_fifo_peek_cache;
    
    /// <summary>Peek data from an AVAudioFifo.</summary>
    /// <param name="af">AVAudioFifo to read from</param>
    /// <param name="data">audio data plane pointers</param>
    /// <param name="nb_samples">number of samples to peek</param>
    /// <returns>number of samples actually peek, or negative AVERROR code on failure. The number of samples actually peek will not be greater than nb_samples, and will only be less than nb_samples if av_audio_fifo_size is less than nb_samples.</returns>
    public static int av_audio_fifo_peek(AVAudioFifo* @af, void** @data, int @nb_samples)
    {
        _av_audio_fifo_peek_cache ??= FunctionResolver.GetFunctionDelegate<av_audio_fifo_peek_delegate>("avutil", "av_audio_fifo_peek", ThrowErrorIfFunctionNotFound);
        if (_av_audio_fifo_peek_cache == null)
            throw new NotSupportedException();
        return _av_audio_fifo_peek_cache(@af, @data, @nb_samples);
    }
    
    /// <summary>Peek data from an AVAudioFifo.</summary>
    /// <param name="af">AVAudioFifo to read from</param>
    /// <param name="nb_samples">number of samples to peek</param>
    /// <returns>number of samples actually peek, or negative AVERROR code on failure. The number of samples actually peek will not be greater than nb_samples, and will only be less than nb_samples if av_audio_fifo_size is less than nb_samples.</returns>
    public static int av_audio_fifo_peek(AVAudioFifo* @af, ref void* @data, int @nb_samples)
    {
        fixed (void** ptr = &@data)
        {
            return av_audio_fifo_peek(@af, ptr, @nb_samples);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_audio_fifo_peek_at_delegate(AVAudioFifo* @af, void** @data, int @nb_samples, int @offset);
    private static av_audio_fifo_peek_at_delegate? _av_audio_fifo_peek_at_cache;
    
    /// <summary>Peek data from an AVAudioFifo.</summary>
    /// <param name="af">AVAudioFifo to read from</param>
    /// <param name="data">audio data plane pointers</param>
    /// <param name="nb_samples">number of samples to peek</param>
    /// <param name="offset">offset from current read position</param>
    /// <returns>number of samples actually peek, or negative AVERROR code on failure. The number of samples actually peek will not be greater than nb_samples, and will only be less than nb_samples if av_audio_fifo_size is less than nb_samples.</returns>
    public static int av_audio_fifo_peek_at(AVAudioFifo* @af, void** @data, int @nb_samples, int @offset)
    {
        _av_audio_fifo_peek_at_cache ??= FunctionResolver.GetFunctionDelegate<av_audio_fifo_peek_at_delegate>("avutil", "av_audio_fifo_peek_at", ThrowErrorIfFunctionNotFound);
        if (_av_audio_fifo_peek_at_cache == null)
            throw new NotSupportedException();
        return _av_audio_fifo_peek_at_cache(@af, @data, @nb_samples, @offset);
    }
    
    /// <summary>Peek data from an AVAudioFifo.</summary>
    /// <param name="af">AVAudioFifo to read from</param>
    /// <param name="nb_samples">number of samples to peek</param>
    /// <param name="offset">offset from current read position</param>
    /// <returns>number of samples actually peek, or negative AVERROR code on failure. The number of samples actually peek will not be greater than nb_samples, and will only be less than nb_samples if av_audio_fifo_size is less than nb_samples.</returns>
    public static int av_audio_fifo_peek_at(AVAudioFifo* @af, ref void* @data, int @nb_samples, int @offset)
    {
        fixed (void** ptr = &@data)
        {
            return av_audio_fifo_peek_at(@af, ptr, @nb_samples, @offset);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_audio_fifo_read_delegate(AVAudioFifo* @af, void** @data, int @nb_samples);
    private static av_audio_fifo_read_delegate? _av_audio_fifo_read_cache;
    
    /// <summary>Read data from an AVAudioFifo.</summary>
    /// <param name="af">AVAudioFifo to read from</param>
    /// <param name="data">audio data plane pointers</param>
    /// <param name="nb_samples">number of samples to read</param>
    /// <returns>number of samples actually read, or negative AVERROR code on failure. The number of samples actually read will not be greater than nb_samples, and will only be less than nb_samples if av_audio_fifo_size is less than nb_samples.</returns>
    public static int av_audio_fifo_read(AVAudioFifo* @af, void** @data, int @nb_samples)
    {
        _av_audio_fifo_read_cache ??= FunctionResolver.GetFunctionDelegate<av_audio_fifo_read_delegate>("avutil", "av_audio_fifo_read", ThrowErrorIfFunctionNotFound);
        if (_av_audio_fifo_read_cache == null)
            throw new NotSupportedException();
        return _av_audio_fifo_read_cache(@af, @data, @nb_samples);
    }
    
    /// <summary>Read data from an AVAudioFifo.</summary>
    /// <param name="af">AVAudioFifo to read from</param>
    /// <param name="nb_samples">number of samples to read</param>
    /// <returns>number of samples actually read, or negative AVERROR code on failure. The number of samples actually read will not be greater than nb_samples, and will only be less than nb_samples if av_audio_fifo_size is less than nb_samples.</returns>
    public static int av_audio_fifo_read(AVAudioFifo* @af, ref void* @data, int @nb_samples)
    {
        fixed (void** ptr = &@data)
        {
            return av_audio_fifo_read(@af, ptr, @nb_samples);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_audio_fifo_realloc_delegate(AVAudioFifo* @af, int @nb_samples);
    private static av_audio_fifo_realloc_delegate? _av_audio_fifo_realloc_cache;
    
    /// <summary>Reallocate an AVAudioFifo.</summary>
    /// <param name="af">AVAudioFifo to reallocate</param>
    /// <param name="nb_samples">new allocation size, in samples</param>
    /// <returns>0 if OK, or negative AVERROR code on failure</returns>
    public static int av_audio_fifo_realloc(AVAudioFifo* @af, int @nb_samples)
    {
        _av_audio_fifo_realloc_cache ??= FunctionResolver.GetFunctionDelegate<av_audio_fifo_realloc_delegate>("avutil", "av_audio_fifo_realloc", ThrowErrorIfFunctionNotFound);
        if (_av_audio_fifo_realloc_cache == null)
            throw new NotSupportedException();
        return _av_audio_fifo_realloc_cache(@af, @nb_samples);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_audio_fifo_reset_delegate(AVAudioFifo* @af);
    private static av_audio_fifo_reset_delegate? _av_audio_fifo_reset_cache;
    
    /// <summary>Reset the AVAudioFifo buffer.</summary>
    /// <param name="af">AVAudioFifo to reset</param>
    public static void av_audio_fifo_reset(AVAudioFifo* @af)
    {
        _av_audio_fifo_reset_cache ??= FunctionResolver.GetFunctionDelegate<av_audio_fifo_reset_delegate>("avutil", "av_audio_fifo_reset", ThrowErrorIfFunctionNotFound);
        if (_av_audio_fifo_reset_cache == null)
            throw new NotSupportedException();
        _av_audio_fifo_reset_cache(@af);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_audio_fifo_size_delegate(AVAudioFifo* @af);
    private static av_audio_fifo_size_delegate? _av_audio_fifo_size_cache;
    
    /// <summary>Get the current number of samples in the AVAudioFifo available for reading.</summary>
    /// <param name="af">the AVAudioFifo to query</param>
    /// <returns>number of samples available for reading</returns>
    public static int av_audio_fifo_size(AVAudioFifo* @af)
    {
        _av_audio_fifo_size_cache ??= FunctionResolver.GetFunctionDelegate<av_audio_fifo_size_delegate>("avutil", "av_audio_fifo_size", ThrowErrorIfFunctionNotFound);
        if (_av_audio_fifo_size_cache == null)
            throw new NotSupportedException();
        return _av_audio_fifo_size_cache(@af);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_audio_fifo_space_delegate(AVAudioFifo* @af);
    private static av_audio_fifo_space_delegate? _av_audio_fifo_space_cache;
    
    /// <summary>Get the current number of samples in the AVAudioFifo available for writing.</summary>
    /// <param name="af">the AVAudioFifo to query</param>
    /// <returns>number of samples available for writing</returns>
    public static int av_audio_fifo_space(AVAudioFifo* @af)
    {
        _av_audio_fifo_space_cache ??= FunctionResolver.GetFunctionDelegate<av_audio_fifo_space_delegate>("avutil", "av_audio_fifo_space", ThrowErrorIfFunctionNotFound);
        if (_av_audio_fifo_space_cache == null)
            throw new NotSupportedException();
        return _av_audio_fifo_space_cache(@af);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_audio_fifo_write_delegate(AVAudioFifo* @af, void** @data, int @nb_samples);
    private static av_audio_fifo_write_delegate? _av_audio_fifo_write_cache;
    
    /// <summary>Write data to an AVAudioFifo.</summary>
    /// <param name="af">AVAudioFifo to write to</param>
    /// <param name="data">audio data plane pointers</param>
    /// <param name="nb_samples">number of samples to write</param>
    /// <returns>number of samples actually written, or negative AVERROR code on failure. If successful, the number of samples actually written will always be nb_samples.</returns>
    public static int av_audio_fifo_write(AVAudioFifo* @af, void** @data, int @nb_samples)
    {
        _av_audio_fifo_write_cache ??= FunctionResolver.GetFunctionDelegate<av_audio_fifo_write_delegate>("avutil", "av_audio_fifo_write", ThrowErrorIfFunctionNotFound);
        if (_av_audio_fifo_write_cache == null)
            throw new NotSupportedException();
        return _av_audio_fifo_write_cache(@af, @data, @nb_samples);
    }
    
    /// <summary>Write data to an AVAudioFifo.</summary>
    /// <param name="af">AVAudioFifo to write to</param>
    /// <param name="nb_samples">number of samples to write</param>
    /// <returns>number of samples actually written, or negative AVERROR code on failure. If successful, the number of samples actually written will always be nb_samples.</returns>
    public static int av_audio_fifo_write(AVAudioFifo* @af, ref void* @data, int @nb_samples)
    {
        fixed (void** ptr = &@data)
        {
            return av_audio_fifo_write(@af, ptr, @nb_samples);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate double av_bessel_i0_delegate(double @x);
    private static av_bessel_i0_delegate? _av_bessel_i0_cache;
    
    /// <summary>0th order modified bessel function of the first kind.</summary>
    public static double av_bessel_i0(double @x)
    {
        _av_bessel_i0_cache ??= FunctionResolver.GetFunctionDelegate<av_bessel_i0_delegate>("avutil", "av_bessel_i0", ThrowErrorIfFunctionNotFound);
        if (_av_bessel_i0_cache == null)
            throw new NotSupportedException();
        return _av_bessel_i0_cache(@x);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_bsf_alloc_delegate(AVBitStreamFilter* @filter, AVBSFContext** @ctx);
    private static av_bsf_alloc_delegate? _av_bsf_alloc_cache;
    
    /// <summary>Allocate a context for a given bitstream filter. The caller must fill in the context parameters as described in the documentation and then call av_bsf_init() before sending any data to the filter.</summary>
    /// <param name="filter">the filter for which to allocate an instance.</param>
    /// <param name="ctx">a pointer into which the pointer to the newly-allocated context will be written. It must be freed with av_bsf_free() after the filtering is done.</param>
    /// <returns>0 on success, a negative AVERROR code on failure</returns>
    public static int av_bsf_alloc(AVBitStreamFilter* @filter, AVBSFContext** @ctx)
    {
        _av_bsf_alloc_cache ??= FunctionResolver.GetFunctionDelegate<av_bsf_alloc_delegate>("avcodec", "av_bsf_alloc", ThrowErrorIfFunctionNotFound);
        if (_av_bsf_alloc_cache == null)
            throw new NotSupportedException();
        return _av_bsf_alloc_cache(@filter, @ctx);
    }
    
    /// <summary>Allocate a context for a given bitstream filter. The caller must fill in the context parameters as described in the documentation and then call av_bsf_init() before sending any data to the filter.</summary>
    /// <param name="filter">the filter for which to allocate an instance.</param>
    /// <returns>0 on success, a negative AVERROR code on failure</returns>
    public static int av_bsf_alloc(AVBitStreamFilter* @filter, ref AVBSFContext* @ctx)
    {
        fixed (AVBSFContext** ptr = &@ctx)
        {
            return av_bsf_alloc(@filter, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_bsf_flush_delegate(AVBSFContext* @ctx);
    private static av_bsf_flush_delegate? _av_bsf_flush_cache;
    
    /// <summary>Reset the internal bitstream filter state. Should be called e.g. when seeking.</summary>
    public static void av_bsf_flush(AVBSFContext* @ctx)
    {
        _av_bsf_flush_cache ??= FunctionResolver.GetFunctionDelegate<av_bsf_flush_delegate>("avcodec", "av_bsf_flush", ThrowErrorIfFunctionNotFound);
        if (_av_bsf_flush_cache == null)
            throw new NotSupportedException();
        _av_bsf_flush_cache(@ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_bsf_free_delegate(AVBSFContext** @ctx);
    private static av_bsf_free_delegate? _av_bsf_free_cache;
    
    /// <summary>Free a bitstream filter context and everything associated with it; write NULL into the supplied pointer.</summary>
    public static void av_bsf_free(AVBSFContext** @ctx)
    {
        _av_bsf_free_cache ??= FunctionResolver.GetFunctionDelegate<av_bsf_free_delegate>("avcodec", "av_bsf_free", ThrowErrorIfFunctionNotFound);
        if (_av_bsf_free_cache == null)
            throw new NotSupportedException();
        _av_bsf_free_cache(@ctx);
    }
    
    /// <summary>Free a bitstream filter context and everything associated with it; write NULL into the supplied pointer.</summary>
    public static void av_bsf_free(ref AVBSFContext* @ctx)
    {
        fixed (AVBSFContext** ptr = &@ctx)
        {
            av_bsf_free(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVBitStreamFilter* av_bsf_get_by_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static av_bsf_get_by_name_delegate? _av_bsf_get_by_name_cache;
    
    /// <summary>Returns a bitstream filter with the specified name or NULL if no such bitstream filter exists.</summary>
    /// <returns>a bitstream filter with the specified name or NULL if no such bitstream filter exists.</returns>
    public static AVBitStreamFilter* av_bsf_get_by_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _av_bsf_get_by_name_cache ??= FunctionResolver.GetFunctionDelegate<av_bsf_get_by_name_delegate>("avcodec", "av_bsf_get_by_name", ThrowErrorIfFunctionNotFound);
        if (_av_bsf_get_by_name_cache == null)
            throw new NotSupportedException();
        return _av_bsf_get_by_name_cache(@name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVClass* av_bsf_get_class_delegate();
    private static av_bsf_get_class_delegate? _av_bsf_get_class_cache;
    
    /// <summary>Get the AVClass for AVBSFContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
    public static AVClass* av_bsf_get_class()
    {
        _av_bsf_get_class_cache ??= FunctionResolver.GetFunctionDelegate<av_bsf_get_class_delegate>("avcodec", "av_bsf_get_class", ThrowErrorIfFunctionNotFound);
        if (_av_bsf_get_class_cache == null)
            throw new NotSupportedException();
        return _av_bsf_get_class_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_bsf_get_null_filter_delegate(AVBSFContext** @bsf);
    private static av_bsf_get_null_filter_delegate? _av_bsf_get_null_filter_cache;
    
    /// <summary>Get null/pass-through bitstream filter.</summary>
    /// <param name="bsf">Pointer to be set to new instance of pass-through bitstream filter</param>
    public static int av_bsf_get_null_filter(AVBSFContext** @bsf)
    {
        _av_bsf_get_null_filter_cache ??= FunctionResolver.GetFunctionDelegate<av_bsf_get_null_filter_delegate>("avcodec", "av_bsf_get_null_filter", ThrowErrorIfFunctionNotFound);
        if (_av_bsf_get_null_filter_cache == null)
            throw new NotSupportedException();
        return _av_bsf_get_null_filter_cache(@bsf);
    }
    
    /// <summary>Get null/pass-through bitstream filter.</summary>
    public static int av_bsf_get_null_filter(ref AVBSFContext* @bsf)
    {
        fixed (AVBSFContext** ptr = &@bsf)
        {
            return av_bsf_get_null_filter(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_bsf_init_delegate(AVBSFContext* @ctx);
    private static av_bsf_init_delegate? _av_bsf_init_cache;
    
    /// <summary>Prepare the filter for use, after all the parameters and options have been set.</summary>
    /// <param name="ctx">a AVBSFContext previously allocated with av_bsf_alloc()</param>
    public static int av_bsf_init(AVBSFContext* @ctx)
    {
        _av_bsf_init_cache ??= FunctionResolver.GetFunctionDelegate<av_bsf_init_delegate>("avcodec", "av_bsf_init", ThrowErrorIfFunctionNotFound);
        if (_av_bsf_init_cache == null)
            throw new NotSupportedException();
        return _av_bsf_init_cache(@ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVBitStreamFilter* av_bsf_iterate_delegate(void** @opaque);
    private static av_bsf_iterate_delegate? _av_bsf_iterate_cache;
    
    /// <summary>Iterate over all registered bitstream filters.</summary>
    /// <param name="opaque">a pointer where libavcodec will store the iteration state. Must point to NULL to start the iteration.</param>
    /// <returns>the next registered bitstream filter or NULL when the iteration is finished</returns>
    public static AVBitStreamFilter* av_bsf_iterate(void** @opaque)
    {
        _av_bsf_iterate_cache ??= FunctionResolver.GetFunctionDelegate<av_bsf_iterate_delegate>("avcodec", "av_bsf_iterate", ThrowErrorIfFunctionNotFound);
        if (_av_bsf_iterate_cache == null)
            throw new NotSupportedException();
        return _av_bsf_iterate_cache(@opaque);
    }
    
    /// <summary>Iterate over all registered bitstream filters.</summary>
    /// <returns>the next registered bitstream filter or NULL when the iteration is finished</returns>
    public static AVBitStreamFilter* av_bsf_iterate(ref void* @opaque)
    {
        fixed (void** ptr = &@opaque)
        {
            return av_bsf_iterate(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVBSFList* av_bsf_list_alloc_delegate();
    private static av_bsf_list_alloc_delegate? _av_bsf_list_alloc_cache;
    
    /// <summary>Allocate empty list of bitstream filters. The list must be later freed by av_bsf_list_free() or finalized by av_bsf_list_finalize().</summary>
    /// <returns>Pointer to on success, NULL in case of failure</returns>
    public static AVBSFList* av_bsf_list_alloc()
    {
        _av_bsf_list_alloc_cache ??= FunctionResolver.GetFunctionDelegate<av_bsf_list_alloc_delegate>("avcodec", "av_bsf_list_alloc", ThrowErrorIfFunctionNotFound);
        if (_av_bsf_list_alloc_cache == null)
            throw new NotSupportedException();
        return _av_bsf_list_alloc_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_bsf_list_append_delegate(AVBSFList* @lst, AVBSFContext* @bsf);
    private static av_bsf_list_append_delegate? _av_bsf_list_append_cache;
    
    /// <summary>Append bitstream filter to the list of bitstream filters.</summary>
    /// <param name="lst">List to append to</param>
    /// <param name="bsf">Filter context to be appended</param>
    /// <returns>&gt;=0 on success, negative AVERROR in case of failure</returns>
    public static int av_bsf_list_append(AVBSFList* @lst, AVBSFContext* @bsf)
    {
        _av_bsf_list_append_cache ??= FunctionResolver.GetFunctionDelegate<av_bsf_list_append_delegate>("avcodec", "av_bsf_list_append", ThrowErrorIfFunctionNotFound);
        if (_av_bsf_list_append_cache == null)
            throw new NotSupportedException();
        return _av_bsf_list_append_cache(@lst, @bsf);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_bsf_list_append2_delegate(AVBSFList* @lst,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @bsf_name, AVDictionary** @options);
    private static av_bsf_list_append2_delegate? _av_bsf_list_append2_cache;
    
    /// <summary>Construct new bitstream filter context given it&apos;s name and options and append it to the list of bitstream filters.</summary>
    /// <param name="lst">List to append to</param>
    /// <param name="bsf_name">Name of the bitstream filter</param>
    /// <param name="options">Options for the bitstream filter, can be set to NULL</param>
    /// <returns>&gt;=0 on success, negative AVERROR in case of failure</returns>
    public static int av_bsf_list_append2(AVBSFList* @lst,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @bsf_name, AVDictionary** @options)
    {
        _av_bsf_list_append2_cache ??= FunctionResolver.GetFunctionDelegate<av_bsf_list_append2_delegate>("avcodec", "av_bsf_list_append2", ThrowErrorIfFunctionNotFound);
        if (_av_bsf_list_append2_cache == null)
            throw new NotSupportedException();
        return _av_bsf_list_append2_cache(@lst, @bsf_name, @options);
    }
    
    /// <summary>Construct new bitstream filter context given it&apos;s name and options and append it to the list of bitstream filters.</summary>
    /// <param name="lst">List to append to</param>
    /// <param name="bsf_name">Name of the bitstream filter</param>
    /// <returns>&gt;=0 on success, negative AVERROR in case of failure</returns>
    public static int av_bsf_list_append2(AVBSFList* @lst, string @bsf_name, ref AVDictionary* @options)
    {
        fixed (AVDictionary** ptr = &@options)
        {
            return av_bsf_list_append2(@lst, @bsf_name, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_bsf_list_finalize_delegate(AVBSFList** @lst, AVBSFContext** @bsf);
    private static av_bsf_list_finalize_delegate? _av_bsf_list_finalize_cache;
    
    /// <summary>Finalize list of bitstream filters.</summary>
    /// <param name="lst">Filter list structure to be transformed</param>
    /// <param name="bsf">Pointer to be set to newly created structure representing the chain of bitstream filters</param>
    /// <returns>&gt;=0 on success, negative AVERROR in case of failure</returns>
    public static int av_bsf_list_finalize(AVBSFList** @lst, AVBSFContext** @bsf)
    {
        _av_bsf_list_finalize_cache ??= FunctionResolver.GetFunctionDelegate<av_bsf_list_finalize_delegate>("avcodec", "av_bsf_list_finalize", ThrowErrorIfFunctionNotFound);
        if (_av_bsf_list_finalize_cache == null)
            throw new NotSupportedException();
        return _av_bsf_list_finalize_cache(@lst, @bsf);
    }
    
    /// <summary>Finalize list of bitstream filters.</summary>
    /// <param name="bsf">Pointer to be set to newly created structure representing the chain of bitstream filters</param>
    /// <returns>&gt;=0 on success, negative AVERROR in case of failure</returns>
    public static int av_bsf_list_finalize(ref AVBSFList* @lst, AVBSFContext** @bsf)
    {
        fixed (AVBSFList** ptr = &@lst)
        {
            return av_bsf_list_finalize(ptr, @bsf);
        }
    }
    
    /// <summary>Finalize list of bitstream filters.</summary>
    /// <param name="lst">Filter list structure to be transformed</param>
    /// <returns>&gt;=0 on success, negative AVERROR in case of failure</returns>
    public static int av_bsf_list_finalize(AVBSFList** @lst, ref AVBSFContext* @bsf)
    {
        fixed (AVBSFContext** ptr = &@bsf)
        {
            return av_bsf_list_finalize(@lst, ptr);
        }
    }
    
    /// <summary>Finalize list of bitstream filters.</summary>
    /// <returns>&gt;=0 on success, negative AVERROR in case of failure</returns>
    public static int av_bsf_list_finalize(ref AVBSFList* @lst, ref AVBSFContext* @bsf)
    {
        fixed (AVBSFList** ptr1 = &@lst)
        {
        fixed (AVBSFContext** ptr2 = &@bsf)
        {
                return av_bsf_list_finalize(ptr1, ptr2);
        }
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_bsf_list_free_delegate(AVBSFList** @lst);
    private static av_bsf_list_free_delegate? _av_bsf_list_free_cache;
    
    /// <summary>Free list of bitstream filters.</summary>
    /// <param name="lst">Pointer to pointer returned by av_bsf_list_alloc()</param>
    public static void av_bsf_list_free(AVBSFList** @lst)
    {
        _av_bsf_list_free_cache ??= FunctionResolver.GetFunctionDelegate<av_bsf_list_free_delegate>("avcodec", "av_bsf_list_free", ThrowErrorIfFunctionNotFound);
        if (_av_bsf_list_free_cache == null)
            throw new NotSupportedException();
        _av_bsf_list_free_cache(@lst);
    }
    
    /// <summary>Free list of bitstream filters.</summary>
    public static void av_bsf_list_free(ref AVBSFList* @lst)
    {
        fixed (AVBSFList** ptr = &@lst)
        {
            av_bsf_list_free(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_bsf_list_parse_str_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str, AVBSFContext** @bsf);
    private static av_bsf_list_parse_str_delegate? _av_bsf_list_parse_str_cache;
    
    /// <summary>Parse string describing list of bitstream filters and create single AVBSFContext describing the whole chain of bitstream filters. Resulting AVBSFContext can be treated as any other AVBSFContext freshly allocated by av_bsf_alloc().</summary>
    /// <param name="str">String describing chain of bitstream filters in format `bsf1[=opt1=val1:opt2=val2][,bsf2]`</param>
    /// <param name="bsf">Pointer to be set to newly created structure representing the chain of bitstream filters</param>
    /// <returns>&gt;=0 on success, negative AVERROR in case of failure</returns>
    public static int av_bsf_list_parse_str(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str, AVBSFContext** @bsf)
    {
        _av_bsf_list_parse_str_cache ??= FunctionResolver.GetFunctionDelegate<av_bsf_list_parse_str_delegate>("avcodec", "av_bsf_list_parse_str", ThrowErrorIfFunctionNotFound);
        if (_av_bsf_list_parse_str_cache == null)
            throw new NotSupportedException();
        return _av_bsf_list_parse_str_cache(@str, @bsf);
    }
    
    /// <summary>Parse string describing list of bitstream filters and create single AVBSFContext describing the whole chain of bitstream filters. Resulting AVBSFContext can be treated as any other AVBSFContext freshly allocated by av_bsf_alloc().</summary>
    /// <param name="str">String describing chain of bitstream filters in format `bsf1[=opt1=val1:opt2=val2][,bsf2]`</param>
    /// <returns>&gt;=0 on success, negative AVERROR in case of failure</returns>
    public static int av_bsf_list_parse_str(string @str, ref AVBSFContext* @bsf)
    {
        fixed (AVBSFContext** ptr = &@bsf)
        {
            return av_bsf_list_parse_str(@str, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_bsf_receive_packet_delegate(AVBSFContext* @ctx, AVPacket* @pkt);
    private static av_bsf_receive_packet_delegate? _av_bsf_receive_packet_cache;
    
    /// <summary>Retrieve a filtered packet.</summary>
    /// <param name="ctx">an initialized AVBSFContext</param>
    /// <param name="pkt">this struct will be filled with the contents of the filtered packet. It is owned by the caller and must be freed using av_packet_unref() when it is no longer needed. This parameter should be &quot;clean&quot; (i.e. freshly allocated with av_packet_alloc() or unreffed with av_packet_unref()) when this function is called. If this function returns successfully, the contents of pkt will be completely overwritten by the returned data. On failure, pkt is not touched.</param>
    /// <returns>- 0 on success. - AVERROR(EAGAIN) if more packets need to be sent to the filter (using av_bsf_send_packet()) to get more output. - AVERROR_EOF if there will be no further output from the filter. - Another negative AVERROR value if an error occurs.</returns>
    public static int av_bsf_receive_packet(AVBSFContext* @ctx, AVPacket* @pkt)
    {
        _av_bsf_receive_packet_cache ??= FunctionResolver.GetFunctionDelegate<av_bsf_receive_packet_delegate>("avcodec", "av_bsf_receive_packet", ThrowErrorIfFunctionNotFound);
        if (_av_bsf_receive_packet_cache == null)
            throw new NotSupportedException();
        return _av_bsf_receive_packet_cache(@ctx, @pkt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_bsf_send_packet_delegate(AVBSFContext* @ctx, AVPacket* @pkt);
    private static av_bsf_send_packet_delegate? _av_bsf_send_packet_cache;
    
    /// <summary>Submit a packet for filtering.</summary>
    /// <param name="ctx">an initialized AVBSFContext</param>
    /// <param name="pkt">the packet to filter. The bitstream filter will take ownership of the packet and reset the contents of pkt. pkt is not touched if an error occurs. If pkt is empty (i.e. NULL, or pkt-&gt;data is NULL and pkt-&gt;side_data_elems zero), it signals the end of the stream (i.e. no more non-empty packets will be sent; sending more empty packets does nothing) and will cause the filter to output any packets it may have buffered internally.</param>
    /// <returns>- 0 on success. - AVERROR(EAGAIN) if packets need to be retrieved from the filter (using av_bsf_receive_packet()) before new input can be consumed. - Another negative AVERROR value if an error occurs.</returns>
    public static int av_bsf_send_packet(AVBSFContext* @ctx, AVPacket* @pkt)
    {
        _av_bsf_send_packet_cache ??= FunctionResolver.GetFunctionDelegate<av_bsf_send_packet_delegate>("avcodec", "av_bsf_send_packet", ThrowErrorIfFunctionNotFound);
        if (_av_bsf_send_packet_cache == null)
            throw new NotSupportedException();
        return _av_bsf_send_packet_cache(@ctx, @pkt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVBufferRef* av_buffer_alloc_delegate(ulong @size);
    private static av_buffer_alloc_delegate? _av_buffer_alloc_cache;
    
    /// <summary>Allocate an AVBuffer of the given size using av_malloc().</summary>
    /// <returns>an AVBufferRef of given size or NULL when out of memory</returns>
    public static AVBufferRef* av_buffer_alloc(ulong @size)
    {
        _av_buffer_alloc_cache ??= FunctionResolver.GetFunctionDelegate<av_buffer_alloc_delegate>("avutil", "av_buffer_alloc", ThrowErrorIfFunctionNotFound);
        if (_av_buffer_alloc_cache == null)
            throw new NotSupportedException();
        return _av_buffer_alloc_cache(@size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVBufferRef* av_buffer_allocz_delegate(ulong @size);
    private static av_buffer_allocz_delegate? _av_buffer_allocz_cache;
    
    /// <summary>Same as av_buffer_alloc(), except the returned buffer will be initialized to zero.</summary>
    public static AVBufferRef* av_buffer_allocz(ulong @size)
    {
        _av_buffer_allocz_cache ??= FunctionResolver.GetFunctionDelegate<av_buffer_allocz_delegate>("avutil", "av_buffer_allocz", ThrowErrorIfFunctionNotFound);
        if (_av_buffer_allocz_cache == null)
            throw new NotSupportedException();
        return _av_buffer_allocz_cache(@size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVBufferRef* av_buffer_create_delegate(byte* @data, ulong @size, av_buffer_create_free_func @free, void* @opaque, int @flags);
    private static av_buffer_create_delegate? _av_buffer_create_cache;
    
    /// <summary>Create an AVBuffer from an existing array.</summary>
    /// <param name="data">data array</param>
    /// <param name="size">size of data in bytes</param>
    /// <param name="free">a callback for freeing this buffer&apos;s data</param>
    /// <param name="opaque">parameter to be got for processing or passed to free</param>
    /// <param name="flags">a combination of AV_BUFFER_FLAG_*</param>
    /// <returns>an AVBufferRef referring to data on success, NULL on failure.</returns>
    public static AVBufferRef* av_buffer_create(byte* @data, ulong @size, av_buffer_create_free_func @free, void* @opaque, int @flags)
    {
        _av_buffer_create_cache ??= FunctionResolver.GetFunctionDelegate<av_buffer_create_delegate>("avutil", "av_buffer_create", ThrowErrorIfFunctionNotFound);
        if (_av_buffer_create_cache == null)
            throw new NotSupportedException();
        return _av_buffer_create_cache(@data, @size, @free, @opaque, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_buffer_default_free_delegate(void* @opaque, byte* @data);
    private static av_buffer_default_free_delegate? _av_buffer_default_free_cache;
    
    /// <summary>Default free callback, which calls av_free() on the buffer data. This function is meant to be passed to av_buffer_create(), not called directly.</summary>
    public static void av_buffer_default_free(void* @opaque, byte* @data)
    {
        _av_buffer_default_free_cache ??= FunctionResolver.GetFunctionDelegate<av_buffer_default_free_delegate>("avutil", "av_buffer_default_free", ThrowErrorIfFunctionNotFound);
        if (_av_buffer_default_free_cache == null)
            throw new NotSupportedException();
        _av_buffer_default_free_cache(@opaque, @data);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* av_buffer_get_opaque_delegate(AVBufferRef* @buf);
    private static av_buffer_get_opaque_delegate? _av_buffer_get_opaque_cache;
    
    /// <summary>Returns the opaque parameter set by av_buffer_create.</summary>
    /// <returns>the opaque parameter set by av_buffer_create.</returns>
    public static void* av_buffer_get_opaque(AVBufferRef* @buf)
    {
        _av_buffer_get_opaque_cache ??= FunctionResolver.GetFunctionDelegate<av_buffer_get_opaque_delegate>("avutil", "av_buffer_get_opaque", ThrowErrorIfFunctionNotFound);
        if (_av_buffer_get_opaque_cache == null)
            throw new NotSupportedException();
        return _av_buffer_get_opaque_cache(@buf);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffer_get_ref_count_delegate(AVBufferRef* @buf);
    private static av_buffer_get_ref_count_delegate? _av_buffer_get_ref_count_cache;
    
    public static int av_buffer_get_ref_count(AVBufferRef* @buf)
    {
        _av_buffer_get_ref_count_cache ??= FunctionResolver.GetFunctionDelegate<av_buffer_get_ref_count_delegate>("avutil", "av_buffer_get_ref_count", ThrowErrorIfFunctionNotFound);
        if (_av_buffer_get_ref_count_cache == null)
            throw new NotSupportedException();
        return _av_buffer_get_ref_count_cache(@buf);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffer_is_writable_delegate(AVBufferRef* @buf);
    private static av_buffer_is_writable_delegate? _av_buffer_is_writable_cache;
    
    /// <summary>Returns 1 if the caller may write to the data referred to by buf (which is true if and only if buf is the only reference to the underlying AVBuffer). Return 0 otherwise. A positive answer is valid until av_buffer_ref() is called on buf.</summary>
    /// <returns>1 if the caller may write to the data referred to by buf (which is true if and only if buf is the only reference to the underlying AVBuffer). Return 0 otherwise. A positive answer is valid until av_buffer_ref() is called on buf.</returns>
    public static int av_buffer_is_writable(AVBufferRef* @buf)
    {
        _av_buffer_is_writable_cache ??= FunctionResolver.GetFunctionDelegate<av_buffer_is_writable_delegate>("avutil", "av_buffer_is_writable", ThrowErrorIfFunctionNotFound);
        if (_av_buffer_is_writable_cache == null)
            throw new NotSupportedException();
        return _av_buffer_is_writable_cache(@buf);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffer_make_writable_delegate(AVBufferRef** @buf);
    private static av_buffer_make_writable_delegate? _av_buffer_make_writable_cache;
    
    /// <summary>Create a writable reference from a given buffer reference, avoiding data copy if possible.</summary>
    /// <param name="buf">buffer reference to make writable. On success, buf is either left untouched, or it is unreferenced and a new writable AVBufferRef is written in its place. On failure, buf is left untouched.</param>
    /// <returns>0 on success, a negative AVERROR on failure.</returns>
    public static int av_buffer_make_writable(AVBufferRef** @buf)
    {
        _av_buffer_make_writable_cache ??= FunctionResolver.GetFunctionDelegate<av_buffer_make_writable_delegate>("avutil", "av_buffer_make_writable", ThrowErrorIfFunctionNotFound);
        if (_av_buffer_make_writable_cache == null)
            throw new NotSupportedException();
        return _av_buffer_make_writable_cache(@buf);
    }
    
    /// <summary>Create a writable reference from a given buffer reference, avoiding data copy if possible.</summary>
    /// <returns>0 on success, a negative AVERROR on failure.</returns>
    public static int av_buffer_make_writable(ref AVBufferRef* @buf)
    {
        fixed (AVBufferRef** ptr = &@buf)
        {
            return av_buffer_make_writable(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* av_buffer_pool_buffer_get_opaque_delegate(AVBufferRef* @ref);
    private static av_buffer_pool_buffer_get_opaque_delegate? _av_buffer_pool_buffer_get_opaque_cache;
    
    /// <summary>Query the original opaque parameter of an allocated buffer in the pool.</summary>
    /// <param name="ref">a buffer reference to a buffer returned by av_buffer_pool_get.</param>
    /// <returns>the opaque parameter set by the buffer allocator function of the buffer pool.</returns>
    public static void* av_buffer_pool_buffer_get_opaque(AVBufferRef* @ref)
    {
        _av_buffer_pool_buffer_get_opaque_cache ??= FunctionResolver.GetFunctionDelegate<av_buffer_pool_buffer_get_opaque_delegate>("avutil", "av_buffer_pool_buffer_get_opaque", ThrowErrorIfFunctionNotFound);
        if (_av_buffer_pool_buffer_get_opaque_cache == null)
            throw new NotSupportedException();
        return _av_buffer_pool_buffer_get_opaque_cache(@ref);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVBufferRef* av_buffer_pool_get_delegate(AVBufferPool* @pool);
    private static av_buffer_pool_get_delegate? _av_buffer_pool_get_cache;
    
    /// <summary>Allocate a new AVBuffer, reusing an old buffer from the pool when available. This function may be called simultaneously from multiple threads.</summary>
    /// <returns>a reference to the new buffer on success, NULL on error.</returns>
    public static AVBufferRef* av_buffer_pool_get(AVBufferPool* @pool)
    {
        _av_buffer_pool_get_cache ??= FunctionResolver.GetFunctionDelegate<av_buffer_pool_get_delegate>("avutil", "av_buffer_pool_get", ThrowErrorIfFunctionNotFound);
        if (_av_buffer_pool_get_cache == null)
            throw new NotSupportedException();
        return _av_buffer_pool_get_cache(@pool);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVBufferPool* av_buffer_pool_init_delegate(ulong @size, av_buffer_pool_init_alloc_func @alloc);
    private static av_buffer_pool_init_delegate? _av_buffer_pool_init_cache;
    
    /// <summary>Allocate and initialize a buffer pool.</summary>
    /// <param name="size">size of each buffer in this pool</param>
    /// <param name="alloc">a function that will be used to allocate new buffers when the pool is empty. May be NULL, then the default allocator will be used (av_buffer_alloc()).</param>
    /// <returns>newly created buffer pool on success, NULL on error.</returns>
    public static AVBufferPool* av_buffer_pool_init(ulong @size, av_buffer_pool_init_alloc_func @alloc)
    {
        _av_buffer_pool_init_cache ??= FunctionResolver.GetFunctionDelegate<av_buffer_pool_init_delegate>("avutil", "av_buffer_pool_init", ThrowErrorIfFunctionNotFound);
        if (_av_buffer_pool_init_cache == null)
            throw new NotSupportedException();
        return _av_buffer_pool_init_cache(@size, @alloc);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVBufferPool* av_buffer_pool_init2_delegate(ulong @size, void* @opaque, av_buffer_pool_init2_alloc_func @alloc, av_buffer_pool_init2_pool_free_func @pool_free);
    private static av_buffer_pool_init2_delegate? _av_buffer_pool_init2_cache;
    
    /// <summary>Allocate and initialize a buffer pool with a more complex allocator.</summary>
    /// <param name="size">size of each buffer in this pool</param>
    /// <param name="opaque">arbitrary user data used by the allocator</param>
    /// <param name="alloc">a function that will be used to allocate new buffers when the pool is empty. May be NULL, then the default allocator will be used (av_buffer_alloc()).</param>
    /// <param name="pool_free">a function that will be called immediately before the pool is freed. I.e. after av_buffer_pool_uninit() is called by the caller and all the frames are returned to the pool and freed. It is intended to uninitialize the user opaque data. May be NULL.</param>
    /// <returns>newly created buffer pool on success, NULL on error.</returns>
    public static AVBufferPool* av_buffer_pool_init2(ulong @size, void* @opaque, av_buffer_pool_init2_alloc_func @alloc, av_buffer_pool_init2_pool_free_func @pool_free)
    {
        _av_buffer_pool_init2_cache ??= FunctionResolver.GetFunctionDelegate<av_buffer_pool_init2_delegate>("avutil", "av_buffer_pool_init2", ThrowErrorIfFunctionNotFound);
        if (_av_buffer_pool_init2_cache == null)
            throw new NotSupportedException();
        return _av_buffer_pool_init2_cache(@size, @opaque, @alloc, @pool_free);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_buffer_pool_uninit_delegate(AVBufferPool** @pool);
    private static av_buffer_pool_uninit_delegate? _av_buffer_pool_uninit_cache;
    
    /// <summary>Mark the pool as being available for freeing. It will actually be freed only once all the allocated buffers associated with the pool are released. Thus it is safe to call this function while some of the allocated buffers are still in use.</summary>
    /// <param name="pool">pointer to the pool to be freed. It will be set to NULL.</param>
    public static void av_buffer_pool_uninit(AVBufferPool** @pool)
    {
        _av_buffer_pool_uninit_cache ??= FunctionResolver.GetFunctionDelegate<av_buffer_pool_uninit_delegate>("avutil", "av_buffer_pool_uninit", ThrowErrorIfFunctionNotFound);
        if (_av_buffer_pool_uninit_cache == null)
            throw new NotSupportedException();
        _av_buffer_pool_uninit_cache(@pool);
    }
    
    /// <summary>Mark the pool as being available for freeing. It will actually be freed only once all the allocated buffers associated with the pool are released. Thus it is safe to call this function while some of the allocated buffers are still in use.</summary>
    public static void av_buffer_pool_uninit(ref AVBufferPool* @pool)
    {
        fixed (AVBufferPool** ptr = &@pool)
        {
            av_buffer_pool_uninit(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffer_realloc_delegate(AVBufferRef** @buf, ulong @size);
    private static av_buffer_realloc_delegate? _av_buffer_realloc_cache;
    
    /// <summary>Reallocate a given buffer.</summary>
    /// <param name="buf">a buffer reference to reallocate. On success, buf will be unreferenced and a new reference with the required size will be written in its place. On failure buf will be left untouched. *buf may be NULL, then a new buffer is allocated.</param>
    /// <param name="size">required new buffer size.</param>
    /// <returns>0 on success, a negative AVERROR on failure.</returns>
    public static int av_buffer_realloc(AVBufferRef** @buf, ulong @size)
    {
        _av_buffer_realloc_cache ??= FunctionResolver.GetFunctionDelegate<av_buffer_realloc_delegate>("avutil", "av_buffer_realloc", ThrowErrorIfFunctionNotFound);
        if (_av_buffer_realloc_cache == null)
            throw new NotSupportedException();
        return _av_buffer_realloc_cache(@buf, @size);
    }
    
    /// <summary>Reallocate a given buffer.</summary>
    /// <param name="size">required new buffer size.</param>
    /// <returns>0 on success, a negative AVERROR on failure.</returns>
    public static int av_buffer_realloc(ref AVBufferRef* @buf, ulong @size)
    {
        fixed (AVBufferRef** ptr = &@buf)
        {
            return av_buffer_realloc(ptr, @size);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVBufferRef* av_buffer_ref_delegate(AVBufferRef* @buf);
    private static av_buffer_ref_delegate? _av_buffer_ref_cache;
    
    /// <summary>Create a new reference to an AVBuffer.</summary>
    /// <returns>a new AVBufferRef referring to the same AVBuffer as buf or NULL on failure.</returns>
    public static AVBufferRef* av_buffer_ref(AVBufferRef* @buf)
    {
        _av_buffer_ref_cache ??= FunctionResolver.GetFunctionDelegate<av_buffer_ref_delegate>("avutil", "av_buffer_ref", ThrowErrorIfFunctionNotFound);
        if (_av_buffer_ref_cache == null)
            throw new NotSupportedException();
        return _av_buffer_ref_cache(@buf);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffer_replace_delegate(AVBufferRef** @dst, AVBufferRef* @src);
    private static av_buffer_replace_delegate? _av_buffer_replace_cache;
    
    /// <summary>Ensure dst refers to the same data as src.</summary>
    /// <param name="dst">Pointer to either a valid buffer reference or NULL. On success, this will point to a buffer reference equivalent to src. On failure, dst will be left untouched.</param>
    /// <param name="src">A buffer reference to replace dst with. May be NULL, then this function is equivalent to av_buffer_unref(dst).</param>
    /// <returns>0 on success AVERROR(ENOMEM) on memory allocation failure.</returns>
    public static int av_buffer_replace(AVBufferRef** @dst, AVBufferRef* @src)
    {
        _av_buffer_replace_cache ??= FunctionResolver.GetFunctionDelegate<av_buffer_replace_delegate>("avutil", "av_buffer_replace", ThrowErrorIfFunctionNotFound);
        if (_av_buffer_replace_cache == null)
            throw new NotSupportedException();
        return _av_buffer_replace_cache(@dst, @src);
    }
    
    /// <summary>Ensure dst refers to the same data as src.</summary>
    /// <param name="src">A buffer reference to replace dst with. May be NULL, then this function is equivalent to av_buffer_unref(dst).</param>
    /// <returns>0 on success AVERROR(ENOMEM) on memory allocation failure.</returns>
    public static int av_buffer_replace(ref AVBufferRef* @dst, AVBufferRef* @src)
    {
        fixed (AVBufferRef** ptr = &@dst)
        {
            return av_buffer_replace(ptr, @src);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_buffer_unref_delegate(AVBufferRef** @buf);
    private static av_buffer_unref_delegate? _av_buffer_unref_cache;
    
    /// <summary>Free a given reference and automatically free the buffer if there are no more references to it.</summary>
    /// <param name="buf">the reference to be freed. The pointer is set to NULL on return.</param>
    public static void av_buffer_unref(AVBufferRef** @buf)
    {
        _av_buffer_unref_cache ??= FunctionResolver.GetFunctionDelegate<av_buffer_unref_delegate>("avutil", "av_buffer_unref", ThrowErrorIfFunctionNotFound);
        if (_av_buffer_unref_cache == null)
            throw new NotSupportedException();
        _av_buffer_unref_cache(@buf);
    }
    
    /// <summary>Free a given reference and automatically free the buffer if there are no more references to it.</summary>
    public static void av_buffer_unref(ref AVBufferRef* @buf)
    {
        fixed (AVBufferRef** ptr = &@buf)
        {
            av_buffer_unref(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffersink_get_ch_layout_delegate(AVFilterContext* @ctx, AVChannelLayout* @ch_layout);
    private static av_buffersink_get_ch_layout_delegate? _av_buffersink_get_ch_layout_cache;
    
    public static int av_buffersink_get_ch_layout(AVFilterContext* @ctx, AVChannelLayout* @ch_layout)
    {
        _av_buffersink_get_ch_layout_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersink_get_ch_layout_delegate>("avfilter", "av_buffersink_get_ch_layout", ThrowErrorIfFunctionNotFound);
        if (_av_buffersink_get_ch_layout_cache == null)
            throw new NotSupportedException();
        return _av_buffersink_get_ch_layout_cache(@ctx, @ch_layout);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffersink_get_channels_delegate(AVFilterContext* @ctx);
    private static av_buffersink_get_channels_delegate? _av_buffersink_get_channels_cache;
    
    public static int av_buffersink_get_channels(AVFilterContext* @ctx)
    {
        _av_buffersink_get_channels_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersink_get_channels_delegate>("avfilter", "av_buffersink_get_channels", ThrowErrorIfFunctionNotFound);
        if (_av_buffersink_get_channels_cache == null)
            throw new NotSupportedException();
        return _av_buffersink_get_channels_cache(@ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVColorRange av_buffersink_get_color_range_delegate(AVFilterContext* @ctx);
    private static av_buffersink_get_color_range_delegate? _av_buffersink_get_color_range_cache;
    
    public static AVColorRange av_buffersink_get_color_range(AVFilterContext* @ctx)
    {
        _av_buffersink_get_color_range_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersink_get_color_range_delegate>("avfilter", "av_buffersink_get_color_range", ThrowErrorIfFunctionNotFound);
        if (_av_buffersink_get_color_range_cache == null)
            throw new NotSupportedException();
        return _av_buffersink_get_color_range_cache(@ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVColorSpace av_buffersink_get_colorspace_delegate(AVFilterContext* @ctx);
    private static av_buffersink_get_colorspace_delegate? _av_buffersink_get_colorspace_cache;
    
    public static AVColorSpace av_buffersink_get_colorspace(AVFilterContext* @ctx)
    {
        _av_buffersink_get_colorspace_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersink_get_colorspace_delegate>("avfilter", "av_buffersink_get_colorspace", ThrowErrorIfFunctionNotFound);
        if (_av_buffersink_get_colorspace_cache == null)
            throw new NotSupportedException();
        return _av_buffersink_get_colorspace_cache(@ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffersink_get_format_delegate(AVFilterContext* @ctx);
    private static av_buffersink_get_format_delegate? _av_buffersink_get_format_cache;
    
    public static int av_buffersink_get_format(AVFilterContext* @ctx)
    {
        _av_buffersink_get_format_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersink_get_format_delegate>("avfilter", "av_buffersink_get_format", ThrowErrorIfFunctionNotFound);
        if (_av_buffersink_get_format_cache == null)
            throw new NotSupportedException();
        return _av_buffersink_get_format_cache(@ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffersink_get_frame_delegate(AVFilterContext* @ctx, AVFrame* @frame);
    private static av_buffersink_get_frame_delegate? _av_buffersink_get_frame_cache;
    
    /// <summary>Get a frame with filtered data from sink and put it in frame.</summary>
    /// <param name="ctx">pointer to a context of a buffersink or abuffersink AVFilter.</param>
    /// <param name="frame">pointer to an allocated frame that will be filled with data. The data must be freed using av_frame_unref() / av_frame_free()</param>
    /// <returns>- &gt;= 0 if a frame was successfully returned. - AVERROR(EAGAIN) if no frames are available at this point; more input frames must be added to the filtergraph to get more output. - AVERROR_EOF if there will be no more output frames on this sink. - A different negative AVERROR code in other failure cases.</returns>
    public static int av_buffersink_get_frame(AVFilterContext* @ctx, AVFrame* @frame)
    {
        _av_buffersink_get_frame_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersink_get_frame_delegate>("avfilter", "av_buffersink_get_frame", ThrowErrorIfFunctionNotFound);
        if (_av_buffersink_get_frame_cache == null)
            throw new NotSupportedException();
        return _av_buffersink_get_frame_cache(@ctx, @frame);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffersink_get_frame_flags_delegate(AVFilterContext* @ctx, AVFrame* @frame, int @flags);
    private static av_buffersink_get_frame_flags_delegate? _av_buffersink_get_frame_flags_cache;
    
    /// <summary>Get a frame with filtered data from sink and put it in frame.</summary>
    /// <param name="ctx">pointer to a buffersink or abuffersink filter context.</param>
    /// <param name="frame">pointer to an allocated frame that will be filled with data. The data must be freed using av_frame_unref() / av_frame_free()</param>
    /// <param name="flags">a combination of AV_BUFFERSINK_FLAG_* flags</param>
    /// <returns>&gt;= 0 in for success, a negative AVERROR code for failure.</returns>
    public static int av_buffersink_get_frame_flags(AVFilterContext* @ctx, AVFrame* @frame, int @flags)
    {
        _av_buffersink_get_frame_flags_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersink_get_frame_flags_delegate>("avfilter", "av_buffersink_get_frame_flags", ThrowErrorIfFunctionNotFound);
        if (_av_buffersink_get_frame_flags_cache == null)
            throw new NotSupportedException();
        return _av_buffersink_get_frame_flags_cache(@ctx, @frame, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVRational av_buffersink_get_frame_rate_delegate(AVFilterContext* @ctx);
    private static av_buffersink_get_frame_rate_delegate? _av_buffersink_get_frame_rate_cache;
    
    public static AVRational av_buffersink_get_frame_rate(AVFilterContext* @ctx)
    {
        _av_buffersink_get_frame_rate_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersink_get_frame_rate_delegate>("avfilter", "av_buffersink_get_frame_rate", ThrowErrorIfFunctionNotFound);
        if (_av_buffersink_get_frame_rate_cache == null)
            throw new NotSupportedException();
        return _av_buffersink_get_frame_rate_cache(@ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffersink_get_h_delegate(AVFilterContext* @ctx);
    private static av_buffersink_get_h_delegate? _av_buffersink_get_h_cache;
    
    public static int av_buffersink_get_h(AVFilterContext* @ctx)
    {
        _av_buffersink_get_h_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersink_get_h_delegate>("avfilter", "av_buffersink_get_h", ThrowErrorIfFunctionNotFound);
        if (_av_buffersink_get_h_cache == null)
            throw new NotSupportedException();
        return _av_buffersink_get_h_cache(@ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVBufferRef* av_buffersink_get_hw_frames_ctx_delegate(AVFilterContext* @ctx);
    private static av_buffersink_get_hw_frames_ctx_delegate? _av_buffersink_get_hw_frames_ctx_cache;
    
    public static AVBufferRef* av_buffersink_get_hw_frames_ctx(AVFilterContext* @ctx)
    {
        _av_buffersink_get_hw_frames_ctx_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersink_get_hw_frames_ctx_delegate>("avfilter", "av_buffersink_get_hw_frames_ctx", ThrowErrorIfFunctionNotFound);
        if (_av_buffersink_get_hw_frames_ctx_cache == null)
            throw new NotSupportedException();
        return _av_buffersink_get_hw_frames_ctx_cache(@ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVRational av_buffersink_get_sample_aspect_ratio_delegate(AVFilterContext* @ctx);
    private static av_buffersink_get_sample_aspect_ratio_delegate? _av_buffersink_get_sample_aspect_ratio_cache;
    
    public static AVRational av_buffersink_get_sample_aspect_ratio(AVFilterContext* @ctx)
    {
        _av_buffersink_get_sample_aspect_ratio_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersink_get_sample_aspect_ratio_delegate>("avfilter", "av_buffersink_get_sample_aspect_ratio", ThrowErrorIfFunctionNotFound);
        if (_av_buffersink_get_sample_aspect_ratio_cache == null)
            throw new NotSupportedException();
        return _av_buffersink_get_sample_aspect_ratio_cache(@ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffersink_get_sample_rate_delegate(AVFilterContext* @ctx);
    private static av_buffersink_get_sample_rate_delegate? _av_buffersink_get_sample_rate_cache;
    
    public static int av_buffersink_get_sample_rate(AVFilterContext* @ctx)
    {
        _av_buffersink_get_sample_rate_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersink_get_sample_rate_delegate>("avfilter", "av_buffersink_get_sample_rate", ThrowErrorIfFunctionNotFound);
        if (_av_buffersink_get_sample_rate_cache == null)
            throw new NotSupportedException();
        return _av_buffersink_get_sample_rate_cache(@ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffersink_get_samples_delegate(AVFilterContext* @ctx, AVFrame* @frame, int @nb_samples);
    private static av_buffersink_get_samples_delegate? _av_buffersink_get_samples_cache;
    
    /// <summary>Same as av_buffersink_get_frame(), but with the ability to specify the number of samples read. This function is less efficient than av_buffersink_get_frame(), because it copies the data around.</summary>
    /// <param name="ctx">pointer to a context of the abuffersink AVFilter.</param>
    /// <param name="frame">pointer to an allocated frame that will be filled with data. The data must be freed using av_frame_unref() / av_frame_free() frame will contain exactly nb_samples audio samples, except at the end of stream, when it can contain less than nb_samples.</param>
    /// <returns>The return codes have the same meaning as for av_buffersink_get_frame().</returns>
    public static int av_buffersink_get_samples(AVFilterContext* @ctx, AVFrame* @frame, int @nb_samples)
    {
        _av_buffersink_get_samples_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersink_get_samples_delegate>("avfilter", "av_buffersink_get_samples", ThrowErrorIfFunctionNotFound);
        if (_av_buffersink_get_samples_cache == null)
            throw new NotSupportedException();
        return _av_buffersink_get_samples_cache(@ctx, @frame, @nb_samples);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVRational av_buffersink_get_time_base_delegate(AVFilterContext* @ctx);
    private static av_buffersink_get_time_base_delegate? _av_buffersink_get_time_base_cache;
    
    public static AVRational av_buffersink_get_time_base(AVFilterContext* @ctx)
    {
        _av_buffersink_get_time_base_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersink_get_time_base_delegate>("avfilter", "av_buffersink_get_time_base", ThrowErrorIfFunctionNotFound);
        if (_av_buffersink_get_time_base_cache == null)
            throw new NotSupportedException();
        return _av_buffersink_get_time_base_cache(@ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVMediaType av_buffersink_get_type_delegate(AVFilterContext* @ctx);
    private static av_buffersink_get_type_delegate? _av_buffersink_get_type_cache;
    
    /// <summary>Get the properties of the stream @{</summary>
    public static AVMediaType av_buffersink_get_type(AVFilterContext* @ctx)
    {
        _av_buffersink_get_type_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersink_get_type_delegate>("avfilter", "av_buffersink_get_type", ThrowErrorIfFunctionNotFound);
        if (_av_buffersink_get_type_cache == null)
            throw new NotSupportedException();
        return _av_buffersink_get_type_cache(@ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffersink_get_w_delegate(AVFilterContext* @ctx);
    private static av_buffersink_get_w_delegate? _av_buffersink_get_w_cache;
    
    public static int av_buffersink_get_w(AVFilterContext* @ctx)
    {
        _av_buffersink_get_w_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersink_get_w_delegate>("avfilter", "av_buffersink_get_w", ThrowErrorIfFunctionNotFound);
        if (_av_buffersink_get_w_cache == null)
            throw new NotSupportedException();
        return _av_buffersink_get_w_cache(@ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_buffersink_set_frame_size_delegate(AVFilterContext* @ctx, uint @frame_size);
    private static av_buffersink_set_frame_size_delegate? _av_buffersink_set_frame_size_cache;
    
    /// <summary>Set the frame size for an audio buffer sink.</summary>
    public static void av_buffersink_set_frame_size(AVFilterContext* @ctx, uint @frame_size)
    {
        _av_buffersink_set_frame_size_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersink_set_frame_size_delegate>("avfilter", "av_buffersink_set_frame_size", ThrowErrorIfFunctionNotFound);
        if (_av_buffersink_set_frame_size_cache == null)
            throw new NotSupportedException();
        _av_buffersink_set_frame_size_cache(@ctx, @frame_size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffersrc_add_frame_delegate(AVFilterContext* @ctx, AVFrame* @frame);
    private static av_buffersrc_add_frame_delegate? _av_buffersrc_add_frame_cache;
    
    /// <summary>Add a frame to the buffer source.</summary>
    /// <param name="ctx">an instance of the buffersrc filter</param>
    /// <param name="frame">frame to be added. If the frame is reference counted, this function will take ownership of the reference(s) and reset the frame. Otherwise the frame data will be copied. If this function returns an error, the input frame is not touched.</param>
    /// <returns>0 on success, a negative AVERROR on error.</returns>
    public static int av_buffersrc_add_frame(AVFilterContext* @ctx, AVFrame* @frame)
    {
        _av_buffersrc_add_frame_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersrc_add_frame_delegate>("avfilter", "av_buffersrc_add_frame", ThrowErrorIfFunctionNotFound);
        if (_av_buffersrc_add_frame_cache == null)
            throw new NotSupportedException();
        return _av_buffersrc_add_frame_cache(@ctx, @frame);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffersrc_add_frame_flags_delegate(AVFilterContext* @buffer_src, AVFrame* @frame, int @flags);
    private static av_buffersrc_add_frame_flags_delegate? _av_buffersrc_add_frame_flags_cache;
    
    /// <summary>Add a frame to the buffer source.</summary>
    /// <param name="buffer_src">pointer to a buffer source context</param>
    /// <param name="frame">a frame, or NULL to mark EOF</param>
    /// <param name="flags">a combination of AV_BUFFERSRC_FLAG_*</param>
    /// <returns>&gt;= 0 in case of success, a negative AVERROR code in case of failure</returns>
    public static int av_buffersrc_add_frame_flags(AVFilterContext* @buffer_src, AVFrame* @frame, int @flags)
    {
        _av_buffersrc_add_frame_flags_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersrc_add_frame_flags_delegate>("avfilter", "av_buffersrc_add_frame_flags", ThrowErrorIfFunctionNotFound);
        if (_av_buffersrc_add_frame_flags_cache == null)
            throw new NotSupportedException();
        return _av_buffersrc_add_frame_flags_cache(@buffer_src, @frame, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffersrc_close_delegate(AVFilterContext* @ctx, long @pts, uint @flags);
    private static av_buffersrc_close_delegate? _av_buffersrc_close_cache;
    
    /// <summary>Close the buffer source after EOF.</summary>
    public static int av_buffersrc_close(AVFilterContext* @ctx, long @pts, uint @flags)
    {
        _av_buffersrc_close_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersrc_close_delegate>("avfilter", "av_buffersrc_close", ThrowErrorIfFunctionNotFound);
        if (_av_buffersrc_close_cache == null)
            throw new NotSupportedException();
        return _av_buffersrc_close_cache(@ctx, @pts, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint av_buffersrc_get_nb_failed_requests_delegate(AVFilterContext* @buffer_src);
    private static av_buffersrc_get_nb_failed_requests_delegate? _av_buffersrc_get_nb_failed_requests_cache;
    
    /// <summary>Get the number of failed requests.</summary>
    public static uint av_buffersrc_get_nb_failed_requests(AVFilterContext* @buffer_src)
    {
        _av_buffersrc_get_nb_failed_requests_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersrc_get_nb_failed_requests_delegate>("avfilter", "av_buffersrc_get_nb_failed_requests", ThrowErrorIfFunctionNotFound);
        if (_av_buffersrc_get_nb_failed_requests_cache == null)
            throw new NotSupportedException();
        return _av_buffersrc_get_nb_failed_requests_cache(@buffer_src);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVBufferSrcParameters* av_buffersrc_parameters_alloc_delegate();
    private static av_buffersrc_parameters_alloc_delegate? _av_buffersrc_parameters_alloc_cache;
    
    /// <summary>Allocate a new AVBufferSrcParameters instance. It should be freed by the caller with av_free().</summary>
    public static AVBufferSrcParameters* av_buffersrc_parameters_alloc()
    {
        _av_buffersrc_parameters_alloc_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersrc_parameters_alloc_delegate>("avfilter", "av_buffersrc_parameters_alloc", ThrowErrorIfFunctionNotFound);
        if (_av_buffersrc_parameters_alloc_cache == null)
            throw new NotSupportedException();
        return _av_buffersrc_parameters_alloc_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffersrc_parameters_set_delegate(AVFilterContext* @ctx, AVBufferSrcParameters* @param);
    private static av_buffersrc_parameters_set_delegate? _av_buffersrc_parameters_set_cache;
    
    /// <summary>Initialize the buffersrc or abuffersrc filter with the provided parameters. This function may be called multiple times, the later calls override the previous ones. Some of the parameters may also be set through AVOptions, then whatever method is used last takes precedence.</summary>
    /// <param name="ctx">an instance of the buffersrc or abuffersrc filter</param>
    /// <param name="param">the stream parameters. The frames later passed to this filter must conform to those parameters. All the allocated fields in param remain owned by the caller, libavfilter will make internal copies or references when necessary.</param>
    /// <returns>0 on success, a negative AVERROR code on failure.</returns>
    public static int av_buffersrc_parameters_set(AVFilterContext* @ctx, AVBufferSrcParameters* @param)
    {
        _av_buffersrc_parameters_set_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersrc_parameters_set_delegate>("avfilter", "av_buffersrc_parameters_set", ThrowErrorIfFunctionNotFound);
        if (_av_buffersrc_parameters_set_cache == null)
            throw new NotSupportedException();
        return _av_buffersrc_parameters_set_cache(@ctx, @param);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_buffersrc_write_frame_delegate(AVFilterContext* @ctx, AVFrame* @frame);
    private static av_buffersrc_write_frame_delegate? _av_buffersrc_write_frame_cache;
    
    /// <summary>Add a frame to the buffer source.</summary>
    /// <param name="ctx">an instance of the buffersrc filter</param>
    /// <param name="frame">frame to be added. If the frame is reference counted, this function will make a new reference to it. Otherwise the frame data will be copied.</param>
    /// <returns>0 on success, a negative AVERROR on error</returns>
    public static int av_buffersrc_write_frame(AVFilterContext* @ctx, AVFrame* @frame)
    {
        _av_buffersrc_write_frame_cache ??= FunctionResolver.GetFunctionDelegate<av_buffersrc_write_frame_delegate>("avfilter", "av_buffersrc_write_frame", ThrowErrorIfFunctionNotFound);
        if (_av_buffersrc_write_frame_cache == null)
            throw new NotSupportedException();
        return _av_buffersrc_write_frame_cache(@ctx, @frame);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* av_calloc_delegate(ulong @nmemb, ulong @size);
    private static av_calloc_delegate? _av_calloc_cache;
    
    /// <summary>Allocate a memory block for an array with av_mallocz().</summary>
    /// <param name="nmemb">Number of elements</param>
    /// <param name="size">Size of the single element</param>
    /// <returns>Pointer to the allocated block, or `NULL` if the block cannot be allocated</returns>
    public static void* av_calloc(ulong @nmemb, ulong @size)
    {
        _av_calloc_cache ??= FunctionResolver.GetFunctionDelegate<av_calloc_delegate>("avutil", "av_calloc", ThrowErrorIfFunctionNotFound);
        if (_av_calloc_cache == null)
            throw new NotSupportedException();
        return _av_calloc_cache(@nmemb, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_channel_description_delegate(byte* @buf, ulong @buf_size, AVChannel @channel);
    private static av_channel_description_delegate? _av_channel_description_cache;
    
    /// <summary>Get a human readable string describing a given channel.</summary>
    /// <param name="buf">pre-allocated buffer where to put the generated string</param>
    /// <param name="buf_size">size in bytes of the buffer.</param>
    /// <param name="channel">the AVChannel whose description to get</param>
    /// <returns>amount of bytes needed to hold the output string, or a negative AVERROR on failure. If the returned value is bigger than buf_size, then the string was truncated.</returns>
    public static int av_channel_description(byte* @buf, ulong @buf_size, AVChannel @channel)
    {
        _av_channel_description_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_description_delegate>("avutil", "av_channel_description", ThrowErrorIfFunctionNotFound);
        if (_av_channel_description_cache == null)
            throw new NotSupportedException();
        return _av_channel_description_cache(@buf, @buf_size, @channel);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_channel_description_bprint_delegate(AVBPrint* @bp, AVChannel @channel_id);
    private static av_channel_description_bprint_delegate? _av_channel_description_bprint_cache;
    
    /// <summary>bprint variant of av_channel_description().</summary>
    public static void av_channel_description_bprint(AVBPrint* @bp, AVChannel @channel_id)
    {
        _av_channel_description_bprint_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_description_bprint_delegate>("avutil", "av_channel_description_bprint", ThrowErrorIfFunctionNotFound);
        if (_av_channel_description_bprint_cache == null)
            throw new NotSupportedException();
        _av_channel_description_bprint_cache(@bp, @channel_id);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVChannel av_channel_from_string_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static av_channel_from_string_delegate? _av_channel_from_string_cache;
    
    /// <summary>This is the inverse function of av_channel_name().</summary>
    /// <returns>the channel with the given name AV_CHAN_NONE when name does not identify a known channel</returns>
    public static AVChannel av_channel_from_string(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _av_channel_from_string_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_from_string_delegate>("avutil", "av_channel_from_string", ThrowErrorIfFunctionNotFound);
        if (_av_channel_from_string_cache == null)
            throw new NotSupportedException();
        return _av_channel_from_string_cache(@name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_channel_layout_ambisonic_order_delegate(AVChannelLayout* @channel_layout);
    private static av_channel_layout_ambisonic_order_delegate? _av_channel_layout_ambisonic_order_cache;
    
    /// <summary>Return the order if the layout is n-th order standard-order ambisonic. The presence of optional extra non-diegetic channels at the end is not taken into account.</summary>
    /// <param name="channel_layout">input channel layout</param>
    /// <returns>the order of the layout, a negative error code otherwise.</returns>
    public static int av_channel_layout_ambisonic_order(AVChannelLayout* @channel_layout)
    {
        _av_channel_layout_ambisonic_order_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_layout_ambisonic_order_delegate>("avutil", "av_channel_layout_ambisonic_order", ThrowErrorIfFunctionNotFound);
        if (_av_channel_layout_ambisonic_order_cache == null)
            throw new NotSupportedException();
        return _av_channel_layout_ambisonic_order_cache(@channel_layout);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVChannel av_channel_layout_channel_from_index_delegate(AVChannelLayout* @channel_layout, uint @idx);
    private static av_channel_layout_channel_from_index_delegate? _av_channel_layout_channel_from_index_cache;
    
    /// <summary>Get the channel with the given index in a channel layout.</summary>
    /// <param name="channel_layout">input channel layout</param>
    /// <param name="idx">index of the channel</param>
    /// <returns>channel with the index idx in channel_layout on success or AV_CHAN_NONE on failure (if idx is not valid or the channel order is unspecified)</returns>
    public static AVChannel av_channel_layout_channel_from_index(AVChannelLayout* @channel_layout, uint @idx)
    {
        _av_channel_layout_channel_from_index_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_layout_channel_from_index_delegate>("avutil", "av_channel_layout_channel_from_index", ThrowErrorIfFunctionNotFound);
        if (_av_channel_layout_channel_from_index_cache == null)
            throw new NotSupportedException();
        return _av_channel_layout_channel_from_index_cache(@channel_layout, @idx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVChannel av_channel_layout_channel_from_string_delegate(AVChannelLayout* @channel_layout,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static av_channel_layout_channel_from_string_delegate? _av_channel_layout_channel_from_string_cache;
    
    /// <summary>Get a channel described by the given string.</summary>
    /// <param name="channel_layout">input channel layout</param>
    /// <param name="name">string describing the channel to obtain</param>
    /// <returns>a channel described by the given string in channel_layout on success or AV_CHAN_NONE on failure (if the string is not valid or the channel order is unspecified)</returns>
    public static AVChannel av_channel_layout_channel_from_string(AVChannelLayout* @channel_layout,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _av_channel_layout_channel_from_string_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_layout_channel_from_string_delegate>("avutil", "av_channel_layout_channel_from_string", ThrowErrorIfFunctionNotFound);
        if (_av_channel_layout_channel_from_string_cache == null)
            throw new NotSupportedException();
        return _av_channel_layout_channel_from_string_cache(@channel_layout, @name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_channel_layout_check_delegate(AVChannelLayout* @channel_layout);
    private static av_channel_layout_check_delegate? _av_channel_layout_check_cache;
    
    /// <summary>Check whether a channel layout is valid, i.e. can possibly describe audio data.</summary>
    /// <param name="channel_layout">input channel layout</param>
    /// <returns>1 if channel_layout is valid, 0 otherwise.</returns>
    public static int av_channel_layout_check(AVChannelLayout* @channel_layout)
    {
        _av_channel_layout_check_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_layout_check_delegate>("avutil", "av_channel_layout_check", ThrowErrorIfFunctionNotFound);
        if (_av_channel_layout_check_cache == null)
            throw new NotSupportedException();
        return _av_channel_layout_check_cache(@channel_layout);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_channel_layout_compare_delegate(AVChannelLayout* @chl, AVChannelLayout* @chl1);
    private static av_channel_layout_compare_delegate? _av_channel_layout_compare_cache;
    
    /// <summary>Check whether two channel layouts are semantically the same, i.e. the same channels are present on the same positions in both.</summary>
    /// <param name="chl">input channel layout</param>
    /// <param name="chl1">input channel layout</param>
    /// <returns>0 if chl and chl1 are equal, 1 if they are not equal. A negative AVERROR code if one or both are invalid.</returns>
    public static int av_channel_layout_compare(AVChannelLayout* @chl, AVChannelLayout* @chl1)
    {
        _av_channel_layout_compare_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_layout_compare_delegate>("avutil", "av_channel_layout_compare", ThrowErrorIfFunctionNotFound);
        if (_av_channel_layout_compare_cache == null)
            throw new NotSupportedException();
        return _av_channel_layout_compare_cache(@chl, @chl1);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_channel_layout_copy_delegate(AVChannelLayout* @dst, AVChannelLayout* @src);
    private static av_channel_layout_copy_delegate? _av_channel_layout_copy_cache;
    
    /// <summary>Make a copy of a channel layout. This differs from just assigning src to dst in that it allocates and copies the map for AV_CHANNEL_ORDER_CUSTOM.</summary>
    /// <param name="dst">destination channel layout</param>
    /// <param name="src">source channel layout</param>
    /// <returns>0 on success, a negative AVERROR on error.</returns>
    public static int av_channel_layout_copy(AVChannelLayout* @dst, AVChannelLayout* @src)
    {
        _av_channel_layout_copy_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_layout_copy_delegate>("avutil", "av_channel_layout_copy", ThrowErrorIfFunctionNotFound);
        if (_av_channel_layout_copy_cache == null)
            throw new NotSupportedException();
        return _av_channel_layout_copy_cache(@dst, @src);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_channel_layout_custom_init_delegate(AVChannelLayout* @channel_layout, int @nb_channels);
    private static av_channel_layout_custom_init_delegate? _av_channel_layout_custom_init_cache;
    
    /// <summary>Initialize a custom channel layout with the specified number of channels. The channel map will be allocated and the designation of all channels will be set to AV_CHAN_UNKNOWN.</summary>
    /// <param name="channel_layout">the layout structure to be initialized</param>
    /// <param name="nb_channels">the number of channels</param>
    /// <returns>0 on success AVERROR(EINVAL) if the number of channels &lt; = 0 AVERROR(ENOMEM) if the channel map could not be allocated</returns>
    public static int av_channel_layout_custom_init(AVChannelLayout* @channel_layout, int @nb_channels)
    {
        _av_channel_layout_custom_init_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_layout_custom_init_delegate>("avutil", "av_channel_layout_custom_init", ThrowErrorIfFunctionNotFound);
        if (_av_channel_layout_custom_init_cache == null)
            throw new NotSupportedException();
        return _av_channel_layout_custom_init_cache(@channel_layout, @nb_channels);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_channel_layout_default_delegate(AVChannelLayout* @ch_layout, int @nb_channels);
    private static av_channel_layout_default_delegate? _av_channel_layout_default_cache;
    
    /// <summary>Get the default channel layout for a given number of channels.</summary>
    /// <param name="ch_layout">the layout structure to be initialized</param>
    /// <param name="nb_channels">number of channels</param>
    public static void av_channel_layout_default(AVChannelLayout* @ch_layout, int @nb_channels)
    {
        _av_channel_layout_default_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_layout_default_delegate>("avutil", "av_channel_layout_default", ThrowErrorIfFunctionNotFound);
        if (_av_channel_layout_default_cache == null)
            throw new NotSupportedException();
        _av_channel_layout_default_cache(@ch_layout, @nb_channels);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_channel_layout_describe_delegate(AVChannelLayout* @channel_layout, byte* @buf, ulong @buf_size);
    private static av_channel_layout_describe_delegate? _av_channel_layout_describe_cache;
    
    /// <summary>Get a human-readable string describing the channel layout properties. The string will be in the same format that is accepted by av_channel_layout_from_string(), allowing to rebuild the same channel layout, except for opaque pointers.</summary>
    /// <param name="channel_layout">channel layout to be described</param>
    /// <param name="buf">pre-allocated buffer where to put the generated string</param>
    /// <param name="buf_size">size in bytes of the buffer.</param>
    /// <returns>amount of bytes needed to hold the output string, or a negative AVERROR on failure. If the returned value is bigger than buf_size, then the string was truncated.</returns>
    public static int av_channel_layout_describe(AVChannelLayout* @channel_layout, byte* @buf, ulong @buf_size)
    {
        _av_channel_layout_describe_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_layout_describe_delegate>("avutil", "av_channel_layout_describe", ThrowErrorIfFunctionNotFound);
        if (_av_channel_layout_describe_cache == null)
            throw new NotSupportedException();
        return _av_channel_layout_describe_cache(@channel_layout, @buf, @buf_size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_channel_layout_describe_bprint_delegate(AVChannelLayout* @channel_layout, AVBPrint* @bp);
    private static av_channel_layout_describe_bprint_delegate? _av_channel_layout_describe_bprint_cache;
    
    /// <summary>bprint variant of av_channel_layout_describe().</summary>
    /// <returns>0 on success, or a negative AVERROR value on failure.</returns>
    public static int av_channel_layout_describe_bprint(AVChannelLayout* @channel_layout, AVBPrint* @bp)
    {
        _av_channel_layout_describe_bprint_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_layout_describe_bprint_delegate>("avutil", "av_channel_layout_describe_bprint", ThrowErrorIfFunctionNotFound);
        if (_av_channel_layout_describe_bprint_cache == null)
            throw new NotSupportedException();
        return _av_channel_layout_describe_bprint_cache(@channel_layout, @bp);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_channel_layout_from_mask_delegate(AVChannelLayout* @channel_layout, ulong @mask);
    private static av_channel_layout_from_mask_delegate? _av_channel_layout_from_mask_cache;
    
    /// <summary>Initialize a native channel layout from a bitmask indicating which channels are present.</summary>
    /// <param name="channel_layout">the layout structure to be initialized</param>
    /// <param name="mask">bitmask describing the channel layout</param>
    /// <returns>0 on success AVERROR(EINVAL) for invalid mask values</returns>
    public static int av_channel_layout_from_mask(AVChannelLayout* @channel_layout, ulong @mask)
    {
        _av_channel_layout_from_mask_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_layout_from_mask_delegate>("avutil", "av_channel_layout_from_mask", ThrowErrorIfFunctionNotFound);
        if (_av_channel_layout_from_mask_cache == null)
            throw new NotSupportedException();
        return _av_channel_layout_from_mask_cache(@channel_layout, @mask);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_channel_layout_from_string_delegate(AVChannelLayout* @channel_layout,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str);
    private static av_channel_layout_from_string_delegate? _av_channel_layout_from_string_cache;
    
    /// <summary>Initialize a channel layout from a given string description. The input string can be represented by: - the formal channel layout name (returned by av_channel_layout_describe()) - single or multiple channel names (returned by av_channel_name(), eg. &quot;FL&quot;, or concatenated with &quot;+&quot;, each optionally containing a custom name after a &quot;&quot;, eg. &quot;FL+FR+LFE&quot;) - a decimal or hexadecimal value of a native channel layout (eg. &quot;4&quot; or &quot;0x4&quot;) - the number of channels with default layout (eg. &quot;4c&quot;) - the number of unordered channels (eg. &quot;4C&quot; or &quot;4 channels&quot;) - the ambisonic order followed by optional non-diegetic channels (eg. &quot;ambisonic 2+stereo&quot;) On error, the channel layout will remain uninitialized, but not necessarily untouched.</summary>
    /// <param name="channel_layout">uninitialized channel layout for the result</param>
    /// <param name="str">string describing the channel layout</param>
    /// <returns>0 on success parsing the channel layout AVERROR(EINVAL) if an invalid channel layout string was provided AVERROR(ENOMEM) if there was not enough memory</returns>
    public static int av_channel_layout_from_string(AVChannelLayout* @channel_layout,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str)
    {
        _av_channel_layout_from_string_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_layout_from_string_delegate>("avutil", "av_channel_layout_from_string", ThrowErrorIfFunctionNotFound);
        if (_av_channel_layout_from_string_cache == null)
            throw new NotSupportedException();
        return _av_channel_layout_from_string_cache(@channel_layout, @str);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_channel_layout_index_from_channel_delegate(AVChannelLayout* @channel_layout, AVChannel @channel);
    private static av_channel_layout_index_from_channel_delegate? _av_channel_layout_index_from_channel_cache;
    
    /// <summary>Get the index of a given channel in a channel layout. In case multiple channels are found, only the first match will be returned.</summary>
    /// <param name="channel_layout">input channel layout</param>
    /// <param name="channel">the channel whose index to obtain</param>
    /// <returns>index of channel in channel_layout on success or a negative number if channel is not present in channel_layout.</returns>
    public static int av_channel_layout_index_from_channel(AVChannelLayout* @channel_layout, AVChannel @channel)
    {
        _av_channel_layout_index_from_channel_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_layout_index_from_channel_delegate>("avutil", "av_channel_layout_index_from_channel", ThrowErrorIfFunctionNotFound);
        if (_av_channel_layout_index_from_channel_cache == null)
            throw new NotSupportedException();
        return _av_channel_layout_index_from_channel_cache(@channel_layout, @channel);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_channel_layout_index_from_string_delegate(AVChannelLayout* @channel_layout,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static av_channel_layout_index_from_string_delegate? _av_channel_layout_index_from_string_cache;
    
    /// <summary>Get the index in a channel layout of a channel described by the given string. In case multiple channels are found, only the first match will be returned.</summary>
    /// <param name="channel_layout">input channel layout</param>
    /// <param name="name">string describing the channel whose index to obtain</param>
    /// <returns>a channel index described by the given string, or a negative AVERROR value.</returns>
    public static int av_channel_layout_index_from_string(AVChannelLayout* @channel_layout,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _av_channel_layout_index_from_string_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_layout_index_from_string_delegate>("avutil", "av_channel_layout_index_from_string", ThrowErrorIfFunctionNotFound);
        if (_av_channel_layout_index_from_string_cache == null)
            throw new NotSupportedException();
        return _av_channel_layout_index_from_string_cache(@channel_layout, @name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_channel_layout_retype_delegate(AVChannelLayout* @channel_layout, AVChannelOrder @order, int @flags);
    private static av_channel_layout_retype_delegate? _av_channel_layout_retype_cache;
    
    /// <summary>Change the AVChannelOrder of a channel layout.</summary>
    /// <param name="channel_layout">channel layout which will be changed</param>
    /// <param name="order">the desired channel layout order</param>
    /// <param name="flags">a combination of AV_CHANNEL_LAYOUT_RETYPE_FLAG_* constants</param>
    /// <returns>0 if the conversion was successful and lossless or if the channel layout was already in the desired order &gt;0 if the conversion was successful but lossy AVERROR(ENOSYS) if the conversion was not possible (or would be lossy and AV_CHANNEL_LAYOUT_RETYPE_FLAG_LOSSLESS was specified) AVERROR(EINVAL), AVERROR(ENOMEM) on error</returns>
    public static int av_channel_layout_retype(AVChannelLayout* @channel_layout, AVChannelOrder @order, int @flags)
    {
        _av_channel_layout_retype_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_layout_retype_delegate>("avutil", "av_channel_layout_retype", ThrowErrorIfFunctionNotFound);
        if (_av_channel_layout_retype_cache == null)
            throw new NotSupportedException();
        return _av_channel_layout_retype_cache(@channel_layout, @order, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVChannelLayout* av_channel_layout_standard_delegate(void** @opaque);
    private static av_channel_layout_standard_delegate? _av_channel_layout_standard_cache;
    
    /// <summary>Iterate over all standard channel layouts.</summary>
    /// <param name="opaque">a pointer where libavutil will store the iteration state. Must point to NULL to start the iteration.</param>
    /// <returns>the standard channel layout or NULL when the iteration is finished</returns>
    public static AVChannelLayout* av_channel_layout_standard(void** @opaque)
    {
        _av_channel_layout_standard_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_layout_standard_delegate>("avutil", "av_channel_layout_standard", ThrowErrorIfFunctionNotFound);
        if (_av_channel_layout_standard_cache == null)
            throw new NotSupportedException();
        return _av_channel_layout_standard_cache(@opaque);
    }
    
    /// <summary>Iterate over all standard channel layouts.</summary>
    /// <returns>the standard channel layout or NULL when the iteration is finished</returns>
    public static AVChannelLayout* av_channel_layout_standard(ref void* @opaque)
    {
        fixed (void** ptr = &@opaque)
        {
            return av_channel_layout_standard(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate ulong av_channel_layout_subset_delegate(AVChannelLayout* @channel_layout, ulong @mask);
    private static av_channel_layout_subset_delegate? _av_channel_layout_subset_cache;
    
    /// <summary>Find out what channels from a given set are present in a channel layout, without regard for their positions.</summary>
    /// <param name="channel_layout">input channel layout</param>
    /// <param name="mask">a combination of AV_CH_* representing a set of channels</param>
    /// <returns>a bitfield representing all the channels from mask that are present in channel_layout</returns>
    public static ulong av_channel_layout_subset(AVChannelLayout* @channel_layout, ulong @mask)
    {
        _av_channel_layout_subset_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_layout_subset_delegate>("avutil", "av_channel_layout_subset", ThrowErrorIfFunctionNotFound);
        if (_av_channel_layout_subset_cache == null)
            throw new NotSupportedException();
        return _av_channel_layout_subset_cache(@channel_layout, @mask);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_channel_layout_uninit_delegate(AVChannelLayout* @channel_layout);
    private static av_channel_layout_uninit_delegate? _av_channel_layout_uninit_cache;
    
    /// <summary>Free any allocated data in the channel layout and reset the channel count to 0.</summary>
    /// <param name="channel_layout">the layout structure to be uninitialized</param>
    public static void av_channel_layout_uninit(AVChannelLayout* @channel_layout)
    {
        _av_channel_layout_uninit_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_layout_uninit_delegate>("avutil", "av_channel_layout_uninit", ThrowErrorIfFunctionNotFound);
        if (_av_channel_layout_uninit_cache == null)
            throw new NotSupportedException();
        _av_channel_layout_uninit_cache(@channel_layout);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_channel_name_delegate(byte* @buf, ulong @buf_size, AVChannel @channel);
    private static av_channel_name_delegate? _av_channel_name_cache;
    
    /// <summary>Get a human readable string in an abbreviated form describing a given channel. This is the inverse function of av_channel_from_string().</summary>
    /// <param name="buf">pre-allocated buffer where to put the generated string</param>
    /// <param name="buf_size">size in bytes of the buffer.</param>
    /// <param name="channel">the AVChannel whose name to get</param>
    /// <returns>amount of bytes needed to hold the output string, or a negative AVERROR on failure. If the returned value is bigger than buf_size, then the string was truncated.</returns>
    public static int av_channel_name(byte* @buf, ulong @buf_size, AVChannel @channel)
    {
        _av_channel_name_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_name_delegate>("avutil", "av_channel_name", ThrowErrorIfFunctionNotFound);
        if (_av_channel_name_cache == null)
            throw new NotSupportedException();
        return _av_channel_name_cache(@buf, @buf_size, @channel);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_channel_name_bprint_delegate(AVBPrint* @bp, AVChannel @channel_id);
    private static av_channel_name_bprint_delegate? _av_channel_name_bprint_cache;
    
    /// <summary>bprint variant of av_channel_name().</summary>
    public static void av_channel_name_bprint(AVBPrint* @bp, AVChannel @channel_id)
    {
        _av_channel_name_bprint_cache ??= FunctionResolver.GetFunctionDelegate<av_channel_name_bprint_delegate>("avutil", "av_channel_name_bprint", ThrowErrorIfFunctionNotFound);
        if (_av_channel_name_bprint_cache == null)
            throw new NotSupportedException();
        _av_channel_name_bprint_cache(@bp, @channel_id);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_chroma_location_enum_to_pos_delegate(int* @xpos, int* @ypos, AVChromaLocation @pos);
    private static av_chroma_location_enum_to_pos_delegate? _av_chroma_location_enum_to_pos_cache;
    
    /// <summary>Converts AVChromaLocation to swscale x/y chroma position.</summary>
    /// <param name="xpos">horizontal chroma sample position</param>
    /// <param name="ypos">vertical   chroma sample position</param>
    public static int av_chroma_location_enum_to_pos(int* @xpos, int* @ypos, AVChromaLocation @pos)
    {
        _av_chroma_location_enum_to_pos_cache ??= FunctionResolver.GetFunctionDelegate<av_chroma_location_enum_to_pos_delegate>("avutil", "av_chroma_location_enum_to_pos", ThrowErrorIfFunctionNotFound);
        if (_av_chroma_location_enum_to_pos_cache == null)
            throw new NotSupportedException();
        return _av_chroma_location_enum_to_pos_cache(@xpos, @ypos, @pos);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_chroma_location_from_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static av_chroma_location_from_name_delegate? _av_chroma_location_from_name_cache;
    
    /// <summary>Returns the AVChromaLocation value for name or an AVError if not found.</summary>
    /// <returns>the AVChromaLocation value for name or an AVError if not found.</returns>
    public static int av_chroma_location_from_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _av_chroma_location_from_name_cache ??= FunctionResolver.GetFunctionDelegate<av_chroma_location_from_name_delegate>("avutil", "av_chroma_location_from_name", ThrowErrorIfFunctionNotFound);
        if (_av_chroma_location_from_name_cache == null)
            throw new NotSupportedException();
        return _av_chroma_location_from_name_cache(@name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string av_chroma_location_name_delegate(AVChromaLocation @location);
    private static av_chroma_location_name_delegate? _av_chroma_location_name_cache;
    
    /// <summary>Returns the name for provided chroma location or NULL if unknown.</summary>
    /// <returns>the name for provided chroma location or NULL if unknown.</returns>
    public static string av_chroma_location_name(AVChromaLocation @location)
    {
        _av_chroma_location_name_cache ??= FunctionResolver.GetFunctionDelegate<av_chroma_location_name_delegate>("avutil", "av_chroma_location_name", ThrowErrorIfFunctionNotFound);
        if (_av_chroma_location_name_cache == null)
            throw new NotSupportedException();
        return _av_chroma_location_name_cache(@location);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVChromaLocation av_chroma_location_pos_to_enum_delegate(int @xpos, int @ypos);
    private static av_chroma_location_pos_to_enum_delegate? _av_chroma_location_pos_to_enum_cache;
    
    /// <summary>Converts swscale x/y chroma position to AVChromaLocation.</summary>
    /// <param name="xpos">horizontal chroma sample position</param>
    /// <param name="ypos">vertical   chroma sample position</param>
    public static AVChromaLocation av_chroma_location_pos_to_enum(int @xpos, int @ypos)
    {
        _av_chroma_location_pos_to_enum_cache ??= FunctionResolver.GetFunctionDelegate<av_chroma_location_pos_to_enum_delegate>("avutil", "av_chroma_location_pos_to_enum", ThrowErrorIfFunctionNotFound);
        if (_av_chroma_location_pos_to_enum_cache == null)
            throw new NotSupportedException();
        return _av_chroma_location_pos_to_enum_cache(@xpos, @ypos);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodecID av_codec_get_id_delegate(AVCodecTag** @tags, uint @tag);
    private static av_codec_get_id_delegate? _av_codec_get_id_cache;
    
    /// <summary>Get the AVCodecID for the given codec tag tag. If no codec id is found returns AV_CODEC_ID_NONE.</summary>
    /// <param name="tags">list of supported codec_id-codec_tag pairs, as stored in AVInputFormat.codec_tag and AVOutputFormat.codec_tag</param>
    /// <param name="tag">codec tag to match to a codec ID</param>
    public static AVCodecID av_codec_get_id(AVCodecTag** @tags, uint @tag)
    {
        _av_codec_get_id_cache ??= FunctionResolver.GetFunctionDelegate<av_codec_get_id_delegate>("avformat", "av_codec_get_id", ThrowErrorIfFunctionNotFound);
        if (_av_codec_get_id_cache == null)
            throw new NotSupportedException();
        return _av_codec_get_id_cache(@tags, @tag);
    }
    
    /// <summary>Get the AVCodecID for the given codec tag tag. If no codec id is found returns AV_CODEC_ID_NONE.</summary>
    /// <param name="tag">codec tag to match to a codec ID</param>
    public static AVCodecID av_codec_get_id(ref AVCodecTag* @tags, uint @tag)
    {
        fixed (AVCodecTag** ptr = &@tags)
        {
            return av_codec_get_id(ptr, @tag);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint av_codec_get_tag_delegate(AVCodecTag** @tags, AVCodecID @id);
    private static av_codec_get_tag_delegate? _av_codec_get_tag_cache;
    
    /// <summary>Get the codec tag for the given codec id id. If no codec tag is found returns 0.</summary>
    /// <param name="tags">list of supported codec_id-codec_tag pairs, as stored in AVInputFormat.codec_tag and AVOutputFormat.codec_tag</param>
    /// <param name="id">codec ID to match to a codec tag</param>
    public static uint av_codec_get_tag(AVCodecTag** @tags, AVCodecID @id)
    {
        _av_codec_get_tag_cache ??= FunctionResolver.GetFunctionDelegate<av_codec_get_tag_delegate>("avformat", "av_codec_get_tag", ThrowErrorIfFunctionNotFound);
        if (_av_codec_get_tag_cache == null)
            throw new NotSupportedException();
        return _av_codec_get_tag_cache(@tags, @id);
    }
    
    /// <summary>Get the codec tag for the given codec id id. If no codec tag is found returns 0.</summary>
    /// <param name="id">codec ID to match to a codec tag</param>
    public static uint av_codec_get_tag(ref AVCodecTag* @tags, AVCodecID @id)
    {
        fixed (AVCodecTag** ptr = &@tags)
        {
            return av_codec_get_tag(ptr, @id);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_codec_get_tag2_delegate(AVCodecTag** @tags, AVCodecID @id, uint* @tag);
    private static av_codec_get_tag2_delegate? _av_codec_get_tag2_cache;
    
    /// <summary>Get the codec tag for the given codec id.</summary>
    /// <param name="tags">list of supported codec_id - codec_tag pairs, as stored in AVInputFormat.codec_tag and AVOutputFormat.codec_tag</param>
    /// <param name="id">codec id that should be searched for in the list</param>
    /// <param name="tag">A pointer to the found tag</param>
    /// <returns>0 if id was not found in tags, &gt; 0 if it was found</returns>
    public static int av_codec_get_tag2(AVCodecTag** @tags, AVCodecID @id, uint* @tag)
    {
        _av_codec_get_tag2_cache ??= FunctionResolver.GetFunctionDelegate<av_codec_get_tag2_delegate>("avformat", "av_codec_get_tag2", ThrowErrorIfFunctionNotFound);
        if (_av_codec_get_tag2_cache == null)
            throw new NotSupportedException();
        return _av_codec_get_tag2_cache(@tags, @id, @tag);
    }
    
    /// <summary>Get the codec tag for the given codec id.</summary>
    /// <param name="id">codec id that should be searched for in the list</param>
    /// <param name="tag">A pointer to the found tag</param>
    /// <returns>0 if id was not found in tags, &gt; 0 if it was found</returns>
    public static int av_codec_get_tag2(ref AVCodecTag* @tags, AVCodecID @id, uint* @tag)
    {
        fixed (AVCodecTag** ptr = &@tags)
        {
            return av_codec_get_tag2(ptr, @id, @tag);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_codec_is_decoder_delegate(AVCodec* @codec);
    private static av_codec_is_decoder_delegate? _av_codec_is_decoder_cache;
    
    /// <summary>Returns a non-zero number if codec is a decoder, zero otherwise</summary>
    /// <returns>a non-zero number if codec is a decoder, zero otherwise</returns>
    public static int av_codec_is_decoder(AVCodec* @codec)
    {
        _av_codec_is_decoder_cache ??= FunctionResolver.GetFunctionDelegate<av_codec_is_decoder_delegate>("avcodec", "av_codec_is_decoder", ThrowErrorIfFunctionNotFound);
        if (_av_codec_is_decoder_cache == null)
            throw new NotSupportedException();
        return _av_codec_is_decoder_cache(@codec);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_codec_is_encoder_delegate(AVCodec* @codec);
    private static av_codec_is_encoder_delegate? _av_codec_is_encoder_cache;
    
    /// <summary>Returns a non-zero number if codec is an encoder, zero otherwise</summary>
    /// <returns>a non-zero number if codec is an encoder, zero otherwise</returns>
    public static int av_codec_is_encoder(AVCodec* @codec)
    {
        _av_codec_is_encoder_cache ??= FunctionResolver.GetFunctionDelegate<av_codec_is_encoder_delegate>("avcodec", "av_codec_is_encoder", ThrowErrorIfFunctionNotFound);
        if (_av_codec_is_encoder_cache == null)
            throw new NotSupportedException();
        return _av_codec_is_encoder_cache(@codec);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodec* av_codec_iterate_delegate(void** @opaque);
    private static av_codec_iterate_delegate? _av_codec_iterate_cache;
    
    /// <summary>Iterate over all registered codecs.</summary>
    /// <param name="opaque">a pointer where libavcodec will store the iteration state. Must point to NULL to start the iteration.</param>
    /// <returns>the next registered codec or NULL when the iteration is finished</returns>
    public static AVCodec* av_codec_iterate(void** @opaque)
    {
        _av_codec_iterate_cache ??= FunctionResolver.GetFunctionDelegate<av_codec_iterate_delegate>("avcodec", "av_codec_iterate", ThrowErrorIfFunctionNotFound);
        if (_av_codec_iterate_cache == null)
            throw new NotSupportedException();
        return _av_codec_iterate_cache(@opaque);
    }
    
    /// <summary>Iterate over all registered codecs.</summary>
    /// <returns>the next registered codec or NULL when the iteration is finished</returns>
    public static AVCodec* av_codec_iterate(ref void* @opaque)
    {
        fixed (void** ptr = &@opaque)
        {
            return av_codec_iterate(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_color_primaries_from_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static av_color_primaries_from_name_delegate? _av_color_primaries_from_name_cache;
    
    /// <summary>Returns the AVColorPrimaries value for name or an AVError if not found.</summary>
    /// <returns>the AVColorPrimaries value for name or an AVError if not found.</returns>
    public static int av_color_primaries_from_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _av_color_primaries_from_name_cache ??= FunctionResolver.GetFunctionDelegate<av_color_primaries_from_name_delegate>("avutil", "av_color_primaries_from_name", ThrowErrorIfFunctionNotFound);
        if (_av_color_primaries_from_name_cache == null)
            throw new NotSupportedException();
        return _av_color_primaries_from_name_cache(@name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string av_color_primaries_name_delegate(AVColorPrimaries @primaries);
    private static av_color_primaries_name_delegate? _av_color_primaries_name_cache;
    
    /// <summary>Returns the name for provided color primaries or NULL if unknown.</summary>
    /// <returns>the name for provided color primaries or NULL if unknown.</returns>
    public static string av_color_primaries_name(AVColorPrimaries @primaries)
    {
        _av_color_primaries_name_cache ??= FunctionResolver.GetFunctionDelegate<av_color_primaries_name_delegate>("avutil", "av_color_primaries_name", ThrowErrorIfFunctionNotFound);
        if (_av_color_primaries_name_cache == null)
            throw new NotSupportedException();
        return _av_color_primaries_name_cache(@primaries);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_color_range_from_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static av_color_range_from_name_delegate? _av_color_range_from_name_cache;
    
    /// <summary>Returns the AVColorRange value for name or an AVError if not found.</summary>
    /// <returns>the AVColorRange value for name or an AVError if not found.</returns>
    public static int av_color_range_from_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _av_color_range_from_name_cache ??= FunctionResolver.GetFunctionDelegate<av_color_range_from_name_delegate>("avutil", "av_color_range_from_name", ThrowErrorIfFunctionNotFound);
        if (_av_color_range_from_name_cache == null)
            throw new NotSupportedException();
        return _av_color_range_from_name_cache(@name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string av_color_range_name_delegate(AVColorRange @range);
    private static av_color_range_name_delegate? _av_color_range_name_cache;
    
    /// <summary>Returns the name for provided color range or NULL if unknown.</summary>
    /// <returns>the name for provided color range or NULL if unknown.</returns>
    public static string av_color_range_name(AVColorRange @range)
    {
        _av_color_range_name_cache ??= FunctionResolver.GetFunctionDelegate<av_color_range_name_delegate>("avutil", "av_color_range_name", ThrowErrorIfFunctionNotFound);
        if (_av_color_range_name_cache == null)
            throw new NotSupportedException();
        return _av_color_range_name_cache(@range);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_color_space_from_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static av_color_space_from_name_delegate? _av_color_space_from_name_cache;
    
    /// <summary>Returns the AVColorSpace value for name or an AVError if not found.</summary>
    /// <returns>the AVColorSpace value for name or an AVError if not found.</returns>
    public static int av_color_space_from_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _av_color_space_from_name_cache ??= FunctionResolver.GetFunctionDelegate<av_color_space_from_name_delegate>("avutil", "av_color_space_from_name", ThrowErrorIfFunctionNotFound);
        if (_av_color_space_from_name_cache == null)
            throw new NotSupportedException();
        return _av_color_space_from_name_cache(@name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string av_color_space_name_delegate(AVColorSpace @space);
    private static av_color_space_name_delegate? _av_color_space_name_cache;
    
    /// <summary>Returns the name for provided color space or NULL if unknown.</summary>
    /// <returns>the name for provided color space or NULL if unknown.</returns>
    public static string av_color_space_name(AVColorSpace @space)
    {
        _av_color_space_name_cache ??= FunctionResolver.GetFunctionDelegate<av_color_space_name_delegate>("avutil", "av_color_space_name", ThrowErrorIfFunctionNotFound);
        if (_av_color_space_name_cache == null)
            throw new NotSupportedException();
        return _av_color_space_name_cache(@space);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_color_transfer_from_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static av_color_transfer_from_name_delegate? _av_color_transfer_from_name_cache;
    
    /// <summary>Returns the AVColorTransferCharacteristic value for name or an AVError if not found.</summary>
    /// <returns>the AVColorTransferCharacteristic value for name or an AVError if not found.</returns>
    public static int av_color_transfer_from_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _av_color_transfer_from_name_cache ??= FunctionResolver.GetFunctionDelegate<av_color_transfer_from_name_delegate>("avutil", "av_color_transfer_from_name", ThrowErrorIfFunctionNotFound);
        if (_av_color_transfer_from_name_cache == null)
            throw new NotSupportedException();
        return _av_color_transfer_from_name_cache(@name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string av_color_transfer_name_delegate(AVColorTransferCharacteristic @transfer);
    private static av_color_transfer_name_delegate? _av_color_transfer_name_cache;
    
    /// <summary>Returns the name for provided color transfer or NULL if unknown.</summary>
    /// <returns>the name for provided color transfer or NULL if unknown.</returns>
    public static string av_color_transfer_name(AVColorTransferCharacteristic @transfer)
    {
        _av_color_transfer_name_cache ??= FunctionResolver.GetFunctionDelegate<av_color_transfer_name_delegate>("avutil", "av_color_transfer_name", ThrowErrorIfFunctionNotFound);
        if (_av_color_transfer_name_cache == null)
            throw new NotSupportedException();
        return _av_color_transfer_name_cache(@transfer);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate long av_compare_mod_delegate(ulong @a, ulong @b, ulong @mod);
    private static av_compare_mod_delegate? _av_compare_mod_cache;
    
    /// <summary>Compare the remainders of two integer operands divided by a common divisor.</summary>
    /// <param name="a">Operand</param>
    /// <param name="b">Operand</param>
    /// <param name="mod">Divisor; must be a power of 2</param>
    /// <returns>- a negative value if `a % mod &lt; b % mod` - a positive value if `a % mod &gt; b % mod` - zero             if `a % mod == b % mod`</returns>
    public static long av_compare_mod(ulong @a, ulong @b, ulong @mod)
    {
        _av_compare_mod_cache ??= FunctionResolver.GetFunctionDelegate<av_compare_mod_delegate>("avutil", "av_compare_mod", ThrowErrorIfFunctionNotFound);
        if (_av_compare_mod_cache == null)
            throw new NotSupportedException();
        return _av_compare_mod_cache(@a, @b, @mod);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_compare_ts_delegate(long @ts_a, AVRational @tb_a, long @ts_b, AVRational @tb_b);
    private static av_compare_ts_delegate? _av_compare_ts_cache;
    
    /// <summary>Compare two timestamps each in its own time base.</summary>
    /// <returns>One of the following values: - -1 if `ts_a` is before `ts_b` - 1 if `ts_a` is after `ts_b` - 0 if they represent the same position</returns>
    public static int av_compare_ts(long @ts_a, AVRational @tb_a, long @ts_b, AVRational @tb_b)
    {
        _av_compare_ts_cache ??= FunctionResolver.GetFunctionDelegate<av_compare_ts_delegate>("avutil", "av_compare_ts", ThrowErrorIfFunctionNotFound);
        if (_av_compare_ts_cache == null)
            throw new NotSupportedException();
        return _av_compare_ts_cache(@ts_a, @tb_a, @ts_b, @tb_b);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVContentLightMetadata* av_content_light_metadata_alloc_delegate(ulong* @size);
    private static av_content_light_metadata_alloc_delegate? _av_content_light_metadata_alloc_cache;
    
    /// <summary>Allocate an AVContentLightMetadata structure and set its fields to default values. The resulting struct can be freed using av_freep().</summary>
    /// <returns>An AVContentLightMetadata filled with default values or NULL on failure.</returns>
    public static AVContentLightMetadata* av_content_light_metadata_alloc(ulong* @size)
    {
        _av_content_light_metadata_alloc_cache ??= FunctionResolver.GetFunctionDelegate<av_content_light_metadata_alloc_delegate>("avutil", "av_content_light_metadata_alloc", ThrowErrorIfFunctionNotFound);
        if (_av_content_light_metadata_alloc_cache == null)
            throw new NotSupportedException();
        return _av_content_light_metadata_alloc_cache(@size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVContentLightMetadata* av_content_light_metadata_create_side_data_delegate(AVFrame* @frame);
    private static av_content_light_metadata_create_side_data_delegate? _av_content_light_metadata_create_side_data_cache;
    
    /// <summary>Allocate a complete AVContentLightMetadata and add it to the frame.</summary>
    /// <param name="frame">The frame which side data is added to.</param>
    /// <returns>The AVContentLightMetadata structure to be filled by caller.</returns>
    public static AVContentLightMetadata* av_content_light_metadata_create_side_data(AVFrame* @frame)
    {
        _av_content_light_metadata_create_side_data_cache ??= FunctionResolver.GetFunctionDelegate<av_content_light_metadata_create_side_data_delegate>("avutil", "av_content_light_metadata_create_side_data", ThrowErrorIfFunctionNotFound);
        if (_av_content_light_metadata_create_side_data_cache == null)
            throw new NotSupportedException();
        return _av_content_light_metadata_create_side_data_cache(@frame);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCPBProperties* av_cpb_properties_alloc_delegate(ulong* @size);
    private static av_cpb_properties_alloc_delegate? _av_cpb_properties_alloc_cache;
    
    /// <summary>Allocate a CPB properties structure and initialize its fields to default values.</summary>
    /// <param name="size">if non-NULL, the size of the allocated struct will be written here. This is useful for embedding it in side data.</param>
    /// <returns>the newly allocated struct or NULL on failure</returns>
    public static AVCPBProperties* av_cpb_properties_alloc(ulong* @size)
    {
        _av_cpb_properties_alloc_cache ??= FunctionResolver.GetFunctionDelegate<av_cpb_properties_alloc_delegate>("avcodec", "av_cpb_properties_alloc", ThrowErrorIfFunctionNotFound);
        if (_av_cpb_properties_alloc_cache == null)
            throw new NotSupportedException();
        return _av_cpb_properties_alloc_cache(@size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_cpu_count_delegate();
    private static av_cpu_count_delegate? _av_cpu_count_cache;
    
    /// <summary>Returns the number of logical CPU cores present.</summary>
    /// <returns>the number of logical CPU cores present.</returns>
    public static int av_cpu_count()
    {
        _av_cpu_count_cache ??= FunctionResolver.GetFunctionDelegate<av_cpu_count_delegate>("avutil", "av_cpu_count", ThrowErrorIfFunctionNotFound);
        if (_av_cpu_count_cache == null)
            throw new NotSupportedException();
        return _av_cpu_count_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_cpu_force_count_delegate(int @count);
    private static av_cpu_force_count_delegate? _av_cpu_force_count_cache;
    
    /// <summary>Overrides cpu count detection and forces the specified count. Count &lt; 1 disables forcing of specific count.</summary>
    public static void av_cpu_force_count(int @count)
    {
        _av_cpu_force_count_cache ??= FunctionResolver.GetFunctionDelegate<av_cpu_force_count_delegate>("avutil", "av_cpu_force_count", ThrowErrorIfFunctionNotFound);
        if (_av_cpu_force_count_cache == null)
            throw new NotSupportedException();
        _av_cpu_force_count_cache(@count);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate ulong av_cpu_max_align_delegate();
    private static av_cpu_max_align_delegate? _av_cpu_max_align_cache;
    
    /// <summary>Get the maximum data alignment that may be required by FFmpeg.</summary>
    public static ulong av_cpu_max_align()
    {
        _av_cpu_max_align_cache ??= FunctionResolver.GetFunctionDelegate<av_cpu_max_align_delegate>("avutil", "av_cpu_max_align", ThrowErrorIfFunctionNotFound);
        if (_av_cpu_max_align_cache == null)
            throw new NotSupportedException();
        return _av_cpu_max_align_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVRational av_d2q_delegate(double @d, int @max);
    private static av_d2q_delegate? _av_d2q_cache;
    
    /// <summary>Convert a double precision floating point number to a rational.</summary>
    /// <param name="d">`double` to convert</param>
    /// <param name="max">Maximum allowed numerator and denominator</param>
    /// <returns>`d` in AVRational form</returns>
    public static AVRational av_d2q(double @d, int @max)
    {
        _av_d2q_cache ??= FunctionResolver.GetFunctionDelegate<av_d2q_delegate>("avutil", "av_d2q", ThrowErrorIfFunctionNotFound);
        if (_av_d2q_cache == null)
            throw new NotSupportedException();
        return _av_d2q_cache(@d, @max);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVD3D11VAContext* av_d3d11va_alloc_context_delegate();
    private static av_d3d11va_alloc_context_delegate? _av_d3d11va_alloc_context_cache;
    
    /// <summary>Allocate an AVD3D11VAContext.</summary>
    /// <returns>Newly-allocated AVD3D11VAContext or NULL on failure.</returns>
    public static AVD3D11VAContext* av_d3d11va_alloc_context()
    {
        _av_d3d11va_alloc_context_cache ??= FunctionResolver.GetFunctionDelegate<av_d3d11va_alloc_context_delegate>("avcodec", "av_d3d11va_alloc_context", ThrowErrorIfFunctionNotFound);
        if (_av_d3d11va_alloc_context_cache == null)
            throw new NotSupportedException();
        return _av_d3d11va_alloc_context_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVClassCategory av_default_get_category_delegate(void* @ptr);
    private static av_default_get_category_delegate? _av_default_get_category_cache;
    
    public static AVClassCategory av_default_get_category(void* @ptr)
    {
        _av_default_get_category_cache ??= FunctionResolver.GetFunctionDelegate<av_default_get_category_delegate>("avutil", "av_default_get_category", ThrowErrorIfFunctionNotFound);
        if (_av_default_get_category_cache == null)
            throw new NotSupportedException();
        return _av_default_get_category_cache(@ptr);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string av_default_item_name_delegate(void* @ctx);
    private static av_default_item_name_delegate? _av_default_item_name_cache;
    
    /// <summary>Return the context name</summary>
    /// <param name="ctx">The AVClass context</param>
    /// <returns>The AVClass class_name</returns>
    public static string av_default_item_name(void* @ctx)
    {
        _av_default_item_name_cache ??= FunctionResolver.GetFunctionDelegate<av_default_item_name_delegate>("avutil", "av_default_item_name", ThrowErrorIfFunctionNotFound);
        if (_av_default_item_name_cache == null)
            throw new NotSupportedException();
        return _av_default_item_name_cache(@ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVInputFormat* av_demuxer_iterate_delegate(void** @opaque);
    private static av_demuxer_iterate_delegate? _av_demuxer_iterate_cache;
    
    /// <summary>Iterate over all registered demuxers.</summary>
    /// <param name="opaque">a pointer where libavformat will store the iteration state. Must point to NULL to start the iteration.</param>
    /// <returns>the next registered demuxer or NULL when the iteration is finished</returns>
    public static AVInputFormat* av_demuxer_iterate(void** @opaque)
    {
        _av_demuxer_iterate_cache ??= FunctionResolver.GetFunctionDelegate<av_demuxer_iterate_delegate>("avformat", "av_demuxer_iterate", ThrowErrorIfFunctionNotFound);
        if (_av_demuxer_iterate_cache == null)
            throw new NotSupportedException();
        return _av_demuxer_iterate_cache(@opaque);
    }
    
    /// <summary>Iterate over all registered demuxers.</summary>
    /// <returns>the next registered demuxer or NULL when the iteration is finished</returns>
    public static AVInputFormat* av_demuxer_iterate(ref void* @opaque)
    {
        fixed (void** ptr = &@opaque)
        {
            return av_demuxer_iterate(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_dict_copy_delegate(AVDictionary** @dst, AVDictionary* @src, int @flags);
    private static av_dict_copy_delegate? _av_dict_copy_cache;
    
    /// <summary>Copy entries from one AVDictionary struct into another.</summary>
    /// <param name="dst">Pointer to a pointer to a AVDictionary struct to copy into. If *dst is NULL, this function will allocate a struct for you and put it in *dst</param>
    /// <param name="src">Pointer to the source AVDictionary struct to copy items from.</param>
    /// <param name="flags">Flags to use when setting entries in *dst</param>
    /// <returns>0 on success, negative AVERROR code on failure. If dst was allocated by this function, callers should free the associated memory.</returns>
    public static int av_dict_copy(AVDictionary** @dst, AVDictionary* @src, int @flags)
    {
        _av_dict_copy_cache ??= FunctionResolver.GetFunctionDelegate<av_dict_copy_delegate>("avutil", "av_dict_copy", ThrowErrorIfFunctionNotFound);
        if (_av_dict_copy_cache == null)
            throw new NotSupportedException();
        return _av_dict_copy_cache(@dst, @src, @flags);
    }
    
    /// <summary>Copy entries from one AVDictionary struct into another.</summary>
    /// <param name="src">Pointer to the source AVDictionary struct to copy items from.</param>
    /// <param name="flags">Flags to use when setting entries in *dst</param>
    /// <returns>0 on success, negative AVERROR code on failure. If dst was allocated by this function, callers should free the associated memory.</returns>
    public static int av_dict_copy(ref AVDictionary* @dst, AVDictionary* @src, int @flags)
    {
        fixed (AVDictionary** ptr = &@dst)
        {
            return av_dict_copy(ptr, @src, @flags);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_dict_count_delegate(AVDictionary* @m);
    private static av_dict_count_delegate? _av_dict_count_cache;
    
    /// <summary>Get number of entries in dictionary.</summary>
    /// <param name="m">dictionary</param>
    /// <returns>number of entries in dictionary</returns>
    public static int av_dict_count(AVDictionary* @m)
    {
        _av_dict_count_cache ??= FunctionResolver.GetFunctionDelegate<av_dict_count_delegate>("avutil", "av_dict_count", ThrowErrorIfFunctionNotFound);
        if (_av_dict_count_cache == null)
            throw new NotSupportedException();
        return _av_dict_count_cache(@m);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_dict_free_delegate(AVDictionary** @m);
    private static av_dict_free_delegate? _av_dict_free_cache;
    
    /// <summary>Free all the memory allocated for an AVDictionary struct and all keys and values.</summary>
    public static void av_dict_free(AVDictionary** @m)
    {
        _av_dict_free_cache ??= FunctionResolver.GetFunctionDelegate<av_dict_free_delegate>("avutil", "av_dict_free", ThrowErrorIfFunctionNotFound);
        if (_av_dict_free_cache == null)
            throw new NotSupportedException();
        _av_dict_free_cache(@m);
    }
    
    /// <summary>Free all the memory allocated for an AVDictionary struct and all keys and values.</summary>
    public static void av_dict_free(ref AVDictionary* @m)
    {
        fixed (AVDictionary** ptr = &@m)
        {
            av_dict_free(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVDictionaryEntry* av_dict_get_delegate(AVDictionary* @m,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key, AVDictionaryEntry* @prev, int @flags);
    private static av_dict_get_delegate? _av_dict_get_cache;
    
    /// <summary>Get a dictionary entry with matching key.</summary>
    /// <param name="key">Matching key</param>
    /// <param name="prev">Set to the previous matching element to find the next. If set to NULL the first matching element is returned.</param>
    /// <param name="flags">A collection of AV_DICT_* flags controlling how the entry is retrieved</param>
    /// <returns>Found entry or NULL in case no matching entry was found in the dictionary</returns>
    public static AVDictionaryEntry* av_dict_get(AVDictionary* @m,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key, AVDictionaryEntry* @prev, int @flags)
    {
        _av_dict_get_cache ??= FunctionResolver.GetFunctionDelegate<av_dict_get_delegate>("avutil", "av_dict_get", ThrowErrorIfFunctionNotFound);
        if (_av_dict_get_cache == null)
            throw new NotSupportedException();
        return _av_dict_get_cache(@m, @key, @prev, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_dict_get_string_delegate(AVDictionary* @m, byte** @buffer, byte @key_val_sep, byte @pairs_sep);
    private static av_dict_get_string_delegate? _av_dict_get_string_cache;
    
    /// <summary>Get dictionary entries as a string.</summary>
    /// <param name="m">The dictionary</param>
    /// <param name="buffer">Pointer to buffer that will be allocated with string containg entries. Buffer must be freed by the caller when is no longer needed.</param>
    /// <param name="key_val_sep">Character used to separate key from value</param>
    /// <param name="pairs_sep">Character used to separate two pairs from each other</param>
    /// <returns>&gt;= 0 on success, negative on error</returns>
    public static int av_dict_get_string(AVDictionary* @m, byte** @buffer, byte @key_val_sep, byte @pairs_sep)
    {
        _av_dict_get_string_cache ??= FunctionResolver.GetFunctionDelegate<av_dict_get_string_delegate>("avutil", "av_dict_get_string", ThrowErrorIfFunctionNotFound);
        if (_av_dict_get_string_cache == null)
            throw new NotSupportedException();
        return _av_dict_get_string_cache(@m, @buffer, @key_val_sep, @pairs_sep);
    }
    
    /// <summary>Get dictionary entries as a string.</summary>
    /// <param name="m">The dictionary</param>
    /// <param name="key_val_sep">Character used to separate key from value</param>
    /// <param name="pairs_sep">Character used to separate two pairs from each other</param>
    /// <returns>&gt;= 0 on success, negative on error</returns>
    public static int av_dict_get_string(AVDictionary* @m, ref byte* @buffer, byte @key_val_sep, byte @pairs_sep)
    {
        fixed (byte** ptr = &@buffer)
        {
            return av_dict_get_string(@m, ptr, @key_val_sep, @pairs_sep);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVDictionaryEntry* av_dict_iterate_delegate(AVDictionary* @m, AVDictionaryEntry* @prev);
    private static av_dict_iterate_delegate? _av_dict_iterate_cache;
    
    /// <summary>Iterate over a dictionary</summary>
    /// <param name="m">The dictionary to iterate over</param>
    /// <param name="prev">Pointer to the previous AVDictionaryEntry, NULL initially</param>
    public static AVDictionaryEntry* av_dict_iterate(AVDictionary* @m, AVDictionaryEntry* @prev)
    {
        _av_dict_iterate_cache ??= FunctionResolver.GetFunctionDelegate<av_dict_iterate_delegate>("avutil", "av_dict_iterate", ThrowErrorIfFunctionNotFound);
        if (_av_dict_iterate_cache == null)
            throw new NotSupportedException();
        return _av_dict_iterate_cache(@m, @prev);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_dict_parse_string_delegate(AVDictionary** @pm,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key_val_sep,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @pairs_sep, int @flags);
    private static av_dict_parse_string_delegate? _av_dict_parse_string_cache;
    
    /// <summary>Parse the key/value pairs list and add the parsed entries to a dictionary.</summary>
    /// <param name="key_val_sep">A 0-terminated list of characters used to separate key from value</param>
    /// <param name="pairs_sep">A 0-terminated list of characters used to separate two pairs from each other</param>
    /// <param name="flags">Flags to use when adding to the dictionary. ::AV_DICT_DONT_STRDUP_KEY and ::AV_DICT_DONT_STRDUP_VAL are ignored since the key/value tokens will always be duplicated.</param>
    /// <returns>0 on success, negative AVERROR code on failure</returns>
    public static int av_dict_parse_string(AVDictionary** @pm,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key_val_sep,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @pairs_sep, int @flags)
    {
        _av_dict_parse_string_cache ??= FunctionResolver.GetFunctionDelegate<av_dict_parse_string_delegate>("avutil", "av_dict_parse_string", ThrowErrorIfFunctionNotFound);
        if (_av_dict_parse_string_cache == null)
            throw new NotSupportedException();
        return _av_dict_parse_string_cache(@pm, @str, @key_val_sep, @pairs_sep, @flags);
    }
    
    /// <summary>Parse the key/value pairs list and add the parsed entries to a dictionary.</summary>
    /// <param name="key_val_sep">A 0-terminated list of characters used to separate key from value</param>
    /// <param name="pairs_sep">A 0-terminated list of characters used to separate two pairs from each other</param>
    /// <param name="flags">Flags to use when adding to the dictionary. ::AV_DICT_DONT_STRDUP_KEY and ::AV_DICT_DONT_STRDUP_VAL are ignored since the key/value tokens will always be duplicated.</param>
    /// <returns>0 on success, negative AVERROR code on failure</returns>
    public static int av_dict_parse_string(ref AVDictionary* @pm, string @str, string @key_val_sep, string @pairs_sep, int @flags)
    {
        fixed (AVDictionary** ptr = &@pm)
        {
            return av_dict_parse_string(ptr, @str, @key_val_sep, @pairs_sep, @flags);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_dict_set_delegate(AVDictionary** @pm,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @value, int @flags);
    private static av_dict_set_delegate? _av_dict_set_cache;
    
    /// <summary>Set the given entry in *pm, overwriting an existing entry.</summary>
    /// <param name="pm">Pointer to a pointer to a dictionary struct. If *pm is NULL a dictionary struct is allocated and put in *pm.</param>
    /// <param name="key">Entry key to add to *pm (will either be av_strduped or added as a new key depending on flags)</param>
    /// <param name="value">Entry value to add to *pm (will be av_strduped or added as a new key depending on flags). Passing a NULL value will cause an existing entry to be deleted.</param>
    /// <returns>&gt;= 0 on success otherwise an error code &lt; 0</returns>
    public static int av_dict_set(AVDictionary** @pm,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @value, int @flags)
    {
        _av_dict_set_cache ??= FunctionResolver.GetFunctionDelegate<av_dict_set_delegate>("avutil", "av_dict_set", ThrowErrorIfFunctionNotFound);
        if (_av_dict_set_cache == null)
            throw new NotSupportedException();
        return _av_dict_set_cache(@pm, @key, @value, @flags);
    }
    
    /// <summary>Set the given entry in *pm, overwriting an existing entry.</summary>
    /// <param name="key">Entry key to add to *pm (will either be av_strduped or added as a new key depending on flags)</param>
    /// <param name="value">Entry value to add to *pm (will be av_strduped or added as a new key depending on flags). Passing a NULL value will cause an existing entry to be deleted.</param>
    /// <returns>&gt;= 0 on success otherwise an error code &lt; 0</returns>
    public static int av_dict_set(ref AVDictionary* @pm, string @key, string @value, int @flags)
    {
        fixed (AVDictionary** ptr = &@pm)
        {
            return av_dict_set(ptr, @key, @value, @flags);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_dict_set_int_delegate(AVDictionary** @pm,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key, long @value, int @flags);
    private static av_dict_set_int_delegate? _av_dict_set_int_cache;
    
    /// <summary>Convenience wrapper for av_dict_set() that converts the value to a string and stores it.</summary>
    public static int av_dict_set_int(AVDictionary** @pm,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key, long @value, int @flags)
    {
        _av_dict_set_int_cache ??= FunctionResolver.GetFunctionDelegate<av_dict_set_int_delegate>("avutil", "av_dict_set_int", ThrowErrorIfFunctionNotFound);
        if (_av_dict_set_int_cache == null)
            throw new NotSupportedException();
        return _av_dict_set_int_cache(@pm, @key, @value, @flags);
    }
    
    /// <summary>Convenience wrapper for av_dict_set() that converts the value to a string and stores it.</summary>
    public static int av_dict_set_int(ref AVDictionary* @pm, string @key, long @value, int @flags)
    {
        fixed (AVDictionary** ptr = &@pm)
        {
            return av_dict_set_int(ptr, @key, @value, @flags);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_display_matrix_flip_delegate(ref int_array9 @matrix, int @hflip, int @vflip);
    private static av_display_matrix_flip_delegate? _av_display_matrix_flip_cache;
    
    /// <summary>Flip the input matrix horizontally and/or vertically.</summary>
    /// <param name="matrix">a transformation matrix</param>
    /// <param name="hflip">whether the matrix should be flipped horizontally</param>
    /// <param name="vflip">whether the matrix should be flipped vertically</param>
    public static void av_display_matrix_flip(ref int_array9 @matrix, int @hflip, int @vflip)
    {
        _av_display_matrix_flip_cache ??= FunctionResolver.GetFunctionDelegate<av_display_matrix_flip_delegate>("avutil", "av_display_matrix_flip", ThrowErrorIfFunctionNotFound);
        if (_av_display_matrix_flip_cache == null)
            throw new NotSupportedException();
        _av_display_matrix_flip_cache(ref @matrix, @hflip, @vflip);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate double av_display_rotation_get_delegate(in int_array9 @matrix);
    private static av_display_rotation_get_delegate? _av_display_rotation_get_cache;
    
    /// <summary>Extract the rotation component of the transformation matrix.</summary>
    /// <param name="matrix">the transformation matrix</param>
    /// <returns>the angle (in degrees) by which the transformation rotates the frame counterclockwise. The angle will be in range [-180.0, 180.0], or NaN if the matrix is singular.</returns>
    public static double av_display_rotation_get(in int_array9 @matrix)
    {
        _av_display_rotation_get_cache ??= FunctionResolver.GetFunctionDelegate<av_display_rotation_get_delegate>("avutil", "av_display_rotation_get", ThrowErrorIfFunctionNotFound);
        if (_av_display_rotation_get_cache == null)
            throw new NotSupportedException();
        return _av_display_rotation_get_cache(@matrix);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_display_rotation_set_delegate(ref int_array9 @matrix, double @angle);
    private static av_display_rotation_set_delegate? _av_display_rotation_set_cache;
    
    /// <summary>Initialize a transformation matrix describing a pure clockwise rotation by the specified angle (in degrees).</summary>
    /// <param name="matrix">a transformation matrix (will be fully overwritten by this function)</param>
    /// <param name="angle">rotation angle in degrees.</param>
    public static void av_display_rotation_set(ref int_array9 @matrix, double @angle)
    {
        _av_display_rotation_set_cache ??= FunctionResolver.GetFunctionDelegate<av_display_rotation_set_delegate>("avutil", "av_display_rotation_set", ThrowErrorIfFunctionNotFound);
        if (_av_display_rotation_set_cache == null)
            throw new NotSupportedException();
        _av_display_rotation_set_cache(ref @matrix, @angle);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_disposition_from_string_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @disp);
    private static av_disposition_from_string_delegate? _av_disposition_from_string_cache;
    
    /// <summary>Returns The AV_DISPOSITION_* flag corresponding to disp or a negative error code if disp does not correspond to a known stream disposition.</summary>
    /// <returns>The AV_DISPOSITION_* flag corresponding to disp or a negative error code if disp does not correspond to a known stream disposition.</returns>
    public static int av_disposition_from_string(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @disp)
    {
        _av_disposition_from_string_cache ??= FunctionResolver.GetFunctionDelegate<av_disposition_from_string_delegate>("avformat", "av_disposition_from_string", ThrowErrorIfFunctionNotFound);
        if (_av_disposition_from_string_cache == null)
            throw new NotSupportedException();
        return _av_disposition_from_string_cache(@disp);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string av_disposition_to_string_delegate(int @disposition);
    private static av_disposition_to_string_delegate? _av_disposition_to_string_cache;
    
    /// <summary>Returns The string description corresponding to the lowest set bit in disposition. NULL when the lowest set bit does not correspond to a known disposition or when disposition is 0.</summary>
    /// <param name="disposition">a combination of AV_DISPOSITION_* values</param>
    /// <returns>The string description corresponding to the lowest set bit in disposition. NULL when the lowest set bit does not correspond to a known disposition or when disposition is 0.</returns>
    public static string av_disposition_to_string(int @disposition)
    {
        _av_disposition_to_string_cache ??= FunctionResolver.GetFunctionDelegate<av_disposition_to_string_delegate>("avformat", "av_disposition_to_string", ThrowErrorIfFunctionNotFound);
        if (_av_disposition_to_string_cache == null)
            throw new NotSupportedException();
        return _av_disposition_to_string_cache(@disposition);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVRational av_div_q_delegate(AVRational @b, AVRational @c);
    private static av_div_q_delegate? _av_div_q_cache;
    
    /// <summary>Divide one rational by another.</summary>
    /// <param name="b">First rational</param>
    /// <param name="c">Second rational</param>
    /// <returns>b/c</returns>
    public static AVRational av_div_q(AVRational @b, AVRational @c)
    {
        _av_div_q_cache ??= FunctionResolver.GetFunctionDelegate<av_div_q_delegate>("avutil", "av_div_q", ThrowErrorIfFunctionNotFound);
        if (_av_div_q_cache == null)
            throw new NotSupportedException();
        return _av_div_q_cache(@b, @c);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_dump_format_delegate(AVFormatContext* @ic, int @index,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, int @is_output);
    private static av_dump_format_delegate? _av_dump_format_cache;
    
    /// <summary>Print detailed information about the input or output format, such as duration, bitrate, streams, container, programs, metadata, side data, codec and time base.</summary>
    /// <param name="ic">the context to analyze</param>
    /// <param name="index">index of the stream to dump information about</param>
    /// <param name="url">the URL to print, such as source or destination file</param>
    /// <param name="is_output">Select whether the specified context is an input(0) or output(1)</param>
    public static void av_dump_format(AVFormatContext* @ic, int @index,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, int @is_output)
    {
        _av_dump_format_cache ??= FunctionResolver.GetFunctionDelegate<av_dump_format_delegate>("avformat", "av_dump_format", ThrowErrorIfFunctionNotFound);
        if (_av_dump_format_cache == null)
            throw new NotSupportedException();
        _av_dump_format_cache(@ic, @index, @url, @is_output);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVDynamicHDRPlus* av_dynamic_hdr_plus_alloc_delegate(ulong* @size);
    private static av_dynamic_hdr_plus_alloc_delegate? _av_dynamic_hdr_plus_alloc_cache;
    
    /// <summary>Allocate an AVDynamicHDRPlus structure and set its fields to default values. The resulting struct can be freed using av_freep().</summary>
    /// <returns>An AVDynamicHDRPlus filled with default values or NULL on failure.</returns>
    public static AVDynamicHDRPlus* av_dynamic_hdr_plus_alloc(ulong* @size)
    {
        _av_dynamic_hdr_plus_alloc_cache ??= FunctionResolver.GetFunctionDelegate<av_dynamic_hdr_plus_alloc_delegate>("avutil", "av_dynamic_hdr_plus_alloc", ThrowErrorIfFunctionNotFound);
        if (_av_dynamic_hdr_plus_alloc_cache == null)
            throw new NotSupportedException();
        return _av_dynamic_hdr_plus_alloc_cache(@size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVDynamicHDRPlus* av_dynamic_hdr_plus_create_side_data_delegate(AVFrame* @frame);
    private static av_dynamic_hdr_plus_create_side_data_delegate? _av_dynamic_hdr_plus_create_side_data_cache;
    
    /// <summary>Allocate a complete AVDynamicHDRPlus and add it to the frame.</summary>
    /// <param name="frame">The frame which side data is added to.</param>
    /// <returns>The AVDynamicHDRPlus structure to be filled by caller or NULL on failure.</returns>
    public static AVDynamicHDRPlus* av_dynamic_hdr_plus_create_side_data(AVFrame* @frame)
    {
        _av_dynamic_hdr_plus_create_side_data_cache ??= FunctionResolver.GetFunctionDelegate<av_dynamic_hdr_plus_create_side_data_delegate>("avutil", "av_dynamic_hdr_plus_create_side_data", ThrowErrorIfFunctionNotFound);
        if (_av_dynamic_hdr_plus_create_side_data_cache == null)
            throw new NotSupportedException();
        return _av_dynamic_hdr_plus_create_side_data_cache(@frame);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_dynamic_hdr_plus_from_t35_delegate(AVDynamicHDRPlus* @s, byte* @data, ulong @size);
    private static av_dynamic_hdr_plus_from_t35_delegate? _av_dynamic_hdr_plus_from_t35_cache;
    
    /// <summary>Parse the user data registered ITU-T T.35 to AVbuffer (AVDynamicHDRPlus). The T.35 buffer must begin with the application mode, skipping the country code, terminal provider codes, and application identifier.</summary>
    /// <param name="s">A pointer containing the decoded AVDynamicHDRPlus structure.</param>
    /// <param name="data">The byte array containing the raw ITU-T T.35 data.</param>
    /// <param name="size">Size of the data array in bytes.</param>
    /// <returns>&gt;= 0 on success. Otherwise, returns the appropriate AVERROR.</returns>
    public static int av_dynamic_hdr_plus_from_t35(AVDynamicHDRPlus* @s, byte* @data, ulong @size)
    {
        _av_dynamic_hdr_plus_from_t35_cache ??= FunctionResolver.GetFunctionDelegate<av_dynamic_hdr_plus_from_t35_delegate>("avutil", "av_dynamic_hdr_plus_from_t35", ThrowErrorIfFunctionNotFound);
        if (_av_dynamic_hdr_plus_from_t35_cache == null)
            throw new NotSupportedException();
        return _av_dynamic_hdr_plus_from_t35_cache(@s, @data, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_dynamic_hdr_plus_to_t35_delegate(AVDynamicHDRPlus* @s, byte** @data, ulong* @size);
    private static av_dynamic_hdr_plus_to_t35_delegate? _av_dynamic_hdr_plus_to_t35_cache;
    
    /// <summary>Serialize dynamic HDR10+ metadata to a user data registered ITU-T T.35 buffer, excluding the first 48 bytes of the header, and beginning with the application mode.</summary>
    /// <param name="s">A pointer containing the decoded AVDynamicHDRPlus structure.</param>
    /// <param name="data">A pointer to pointer to a byte buffer to be filled with the serialized metadata. If *data is NULL, a buffer be will be allocated and a pointer to it stored in its place. The caller assumes ownership of the buffer. May be NULL, in which case the function will only store the required buffer size in *size.</param>
    /// <param name="size">A pointer to a size to be set to the returned buffer&apos;s size. If *data is not NULL, *size must contain the size of the input buffer. May be NULL only if *data is NULL.</param>
    /// <returns>&gt;= 0 on success. Otherwise, returns the appropriate AVERROR.</returns>
    public static int av_dynamic_hdr_plus_to_t35(AVDynamicHDRPlus* @s, byte** @data, ulong* @size)
    {
        _av_dynamic_hdr_plus_to_t35_cache ??= FunctionResolver.GetFunctionDelegate<av_dynamic_hdr_plus_to_t35_delegate>("avutil", "av_dynamic_hdr_plus_to_t35", ThrowErrorIfFunctionNotFound);
        if (_av_dynamic_hdr_plus_to_t35_cache == null)
            throw new NotSupportedException();
        return _av_dynamic_hdr_plus_to_t35_cache(@s, @data, @size);
    }
    
    /// <summary>Serialize dynamic HDR10+ metadata to a user data registered ITU-T T.35 buffer, excluding the first 48 bytes of the header, and beginning with the application mode.</summary>
    /// <param name="s">A pointer containing the decoded AVDynamicHDRPlus structure.</param>
    /// <param name="size">A pointer to a size to be set to the returned buffer&apos;s size. If *data is not NULL, *size must contain the size of the input buffer. May be NULL only if *data is NULL.</param>
    /// <returns>&gt;= 0 on success. Otherwise, returns the appropriate AVERROR.</returns>
    public static int av_dynamic_hdr_plus_to_t35(AVDynamicHDRPlus* @s, ref byte* @data, ulong* @size)
    {
        fixed (byte** ptr = &@data)
        {
            return av_dynamic_hdr_plus_to_t35(@s, ptr, @size);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_dynarray_add_delegate(void* @tab_ptr, int* @nb_ptr, void* @elem);
    private static av_dynarray_add_delegate? _av_dynarray_add_cache;
    
    /// <summary>Add the pointer to an element to a dynamic array.</summary>
    /// <param name="tab_ptr">Pointer to the array to grow</param>
    /// <param name="nb_ptr">Pointer to the number of elements in the array</param>
    /// <param name="elem">Element to add</param>
    public static void av_dynarray_add(void* @tab_ptr, int* @nb_ptr, void* @elem)
    {
        _av_dynarray_add_cache ??= FunctionResolver.GetFunctionDelegate<av_dynarray_add_delegate>("avutil", "av_dynarray_add", ThrowErrorIfFunctionNotFound);
        if (_av_dynarray_add_cache == null)
            throw new NotSupportedException();
        _av_dynarray_add_cache(@tab_ptr, @nb_ptr, @elem);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_dynarray_add_nofree_delegate(void* @tab_ptr, int* @nb_ptr, void* @elem);
    private static av_dynarray_add_nofree_delegate? _av_dynarray_add_nofree_cache;
    
    /// <summary>Add an element to a dynamic array.</summary>
    /// <returns>&gt;=0 on success, negative otherwise</returns>
    public static int av_dynarray_add_nofree(void* @tab_ptr, int* @nb_ptr, void* @elem)
    {
        _av_dynarray_add_nofree_cache ??= FunctionResolver.GetFunctionDelegate<av_dynarray_add_nofree_delegate>("avutil", "av_dynarray_add_nofree", ThrowErrorIfFunctionNotFound);
        if (_av_dynarray_add_nofree_cache == null)
            throw new NotSupportedException();
        return _av_dynarray_add_nofree_cache(@tab_ptr, @nb_ptr, @elem);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* av_dynarray2_add_delegate(void** @tab_ptr, int* @nb_ptr, ulong @elem_size, byte* @elem_data);
    private static av_dynarray2_add_delegate? _av_dynarray2_add_cache;
    
    /// <summary>Add an element of size `elem_size` to a dynamic array.</summary>
    /// <param name="tab_ptr">Pointer to the array to grow</param>
    /// <param name="nb_ptr">Pointer to the number of elements in the array</param>
    /// <param name="elem_size">Size in bytes of an element in the array</param>
    /// <param name="elem_data">Pointer to the data of the element to add. If `NULL`, the space of the newly added element is allocated but left uninitialized.</param>
    /// <returns>Pointer to the data of the element to copy in the newly allocated space</returns>
    public static void* av_dynarray2_add(void** @tab_ptr, int* @nb_ptr, ulong @elem_size, byte* @elem_data)
    {
        _av_dynarray2_add_cache ??= FunctionResolver.GetFunctionDelegate<av_dynarray2_add_delegate>("avutil", "av_dynarray2_add", ThrowErrorIfFunctionNotFound);
        if (_av_dynarray2_add_cache == null)
            throw new NotSupportedException();
        return _av_dynarray2_add_cache(@tab_ptr, @nb_ptr, @elem_size, @elem_data);
    }
    
    /// <summary>Add an element of size `elem_size` to a dynamic array.</summary>
    /// <param name="nb_ptr">Pointer to the number of elements in the array</param>
    /// <param name="elem_size">Size in bytes of an element in the array</param>
    /// <param name="elem_data">Pointer to the data of the element to add. If `NULL`, the space of the newly added element is allocated but left uninitialized.</param>
    /// <returns>Pointer to the data of the element to copy in the newly allocated space</returns>
    public static void* av_dynarray2_add(ref void* @tab_ptr, int* @nb_ptr, ulong @elem_size, byte* @elem_data)
    {
        fixed (void** ptr = &@tab_ptr)
        {
            return av_dynarray2_add(ptr, @nb_ptr, @elem_size, @elem_data);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_fast_malloc_delegate(void* @ptr, uint* @size, ulong @min_size);
    private static av_fast_malloc_delegate? _av_fast_malloc_cache;
    
    /// <summary>Allocate a buffer, reusing the given one if large enough.</summary>
    /// <param name="ptr">Pointer to pointer to an already allocated buffer. `*ptr` will be overwritten with pointer to new buffer on success or `NULL` on failure</param>
    /// <param name="size">Pointer to the size of buffer `*ptr`. `*size` is updated to the new allocated size, in particular 0 in case of failure.</param>
    /// <param name="min_size">Desired minimal size of buffer `*ptr`</param>
    public static void av_fast_malloc(void* @ptr, uint* @size, ulong @min_size)
    {
        _av_fast_malloc_cache ??= FunctionResolver.GetFunctionDelegate<av_fast_malloc_delegate>("avutil", "av_fast_malloc", ThrowErrorIfFunctionNotFound);
        if (_av_fast_malloc_cache == null)
            throw new NotSupportedException();
        _av_fast_malloc_cache(@ptr, @size, @min_size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_fast_mallocz_delegate(void* @ptr, uint* @size, ulong @min_size);
    private static av_fast_mallocz_delegate? _av_fast_mallocz_cache;
    
    /// <summary>Allocate and clear a buffer, reusing the given one if large enough.</summary>
    /// <param name="ptr">Pointer to pointer to an already allocated buffer. `*ptr` will be overwritten with pointer to new buffer on success or `NULL` on failure</param>
    /// <param name="size">Pointer to the size of buffer `*ptr`. `*size` is updated to the new allocated size, in particular 0 in case of failure.</param>
    /// <param name="min_size">Desired minimal size of buffer `*ptr`</param>
    public static void av_fast_mallocz(void* @ptr, uint* @size, ulong @min_size)
    {
        _av_fast_mallocz_cache ??= FunctionResolver.GetFunctionDelegate<av_fast_mallocz_delegate>("avutil", "av_fast_mallocz", ThrowErrorIfFunctionNotFound);
        if (_av_fast_mallocz_cache == null)
            throw new NotSupportedException();
        _av_fast_mallocz_cache(@ptr, @size, @min_size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_fast_padded_malloc_delegate(void* @ptr, uint* @size, ulong @min_size);
    private static av_fast_padded_malloc_delegate? _av_fast_padded_malloc_cache;
    
    /// <summary>Same behaviour av_fast_malloc but the buffer has additional AV_INPUT_BUFFER_PADDING_SIZE at the end which will always be 0.</summary>
    public static void av_fast_padded_malloc(void* @ptr, uint* @size, ulong @min_size)
    {
        _av_fast_padded_malloc_cache ??= FunctionResolver.GetFunctionDelegate<av_fast_padded_malloc_delegate>("avcodec", "av_fast_padded_malloc", ThrowErrorIfFunctionNotFound);
        if (_av_fast_padded_malloc_cache == null)
            throw new NotSupportedException();
        _av_fast_padded_malloc_cache(@ptr, @size, @min_size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_fast_padded_mallocz_delegate(void* @ptr, uint* @size, ulong @min_size);
    private static av_fast_padded_mallocz_delegate? _av_fast_padded_mallocz_cache;
    
    /// <summary>Same behaviour av_fast_padded_malloc except that buffer will always be 0-initialized after call.</summary>
    public static void av_fast_padded_mallocz(void* @ptr, uint* @size, ulong @min_size)
    {
        _av_fast_padded_mallocz_cache ??= FunctionResolver.GetFunctionDelegate<av_fast_padded_mallocz_delegate>("avcodec", "av_fast_padded_mallocz", ThrowErrorIfFunctionNotFound);
        if (_av_fast_padded_mallocz_cache == null)
            throw new NotSupportedException();
        _av_fast_padded_mallocz_cache(@ptr, @size, @min_size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* av_fast_realloc_delegate(void* @ptr, uint* @size, ulong @min_size);
    private static av_fast_realloc_delegate? _av_fast_realloc_cache;
    
    /// <summary>Reallocate the given buffer if it is not large enough, otherwise do nothing.</summary>
    /// <param name="ptr">Already allocated buffer, or `NULL`</param>
    /// <param name="size">Pointer to the size of buffer `ptr`. `*size` is updated to the new allocated size, in particular 0 in case of failure.</param>
    /// <param name="min_size">Desired minimal size of buffer `ptr`</param>
    /// <returns>`ptr` if the buffer is large enough, a pointer to newly reallocated buffer if the buffer was not large enough, or `NULL` in case of error</returns>
    public static void* av_fast_realloc(void* @ptr, uint* @size, ulong @min_size)
    {
        _av_fast_realloc_cache ??= FunctionResolver.GetFunctionDelegate<av_fast_realloc_delegate>("avutil", "av_fast_realloc", ThrowErrorIfFunctionNotFound);
        if (_av_fast_realloc_cache == null)
            throw new NotSupportedException();
        return _av_fast_realloc_cache(@ptr, @size, @min_size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_file_map_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename, byte** @bufptr, ulong* @size, int @log_offset, void* @log_ctx);
    private static av_file_map_delegate? _av_file_map_cache;
    
    /// <summary>Read the file with name filename, and put its content in a newly allocated buffer or map it with mmap() when available. In case of success set *bufptr to the read or mmapped buffer, and *size to the size in bytes of the buffer in *bufptr. Unlike mmap this function succeeds with zero sized files, in this case *bufptr will be set to NULL and *size will be set to 0. The returned buffer must be released with av_file_unmap().</summary>
    /// <param name="filename">path to the file</param>
    /// <param name="bufptr">pointee is set to the mapped or allocated buffer</param>
    /// <param name="size">pointee is set to the size in bytes of the buffer</param>
    /// <param name="log_offset">loglevel offset used for logging</param>
    /// <param name="log_ctx">context used for logging</param>
    /// <returns>a non negative number in case of success, a negative value corresponding to an AVERROR error code in case of failure</returns>
    public static int av_file_map(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename, byte** @bufptr, ulong* @size, int @log_offset, void* @log_ctx)
    {
        _av_file_map_cache ??= FunctionResolver.GetFunctionDelegate<av_file_map_delegate>("avutil", "av_file_map", ThrowErrorIfFunctionNotFound);
        if (_av_file_map_cache == null)
            throw new NotSupportedException();
        return _av_file_map_cache(@filename, @bufptr, @size, @log_offset, @log_ctx);
    }
    
    /// <summary>Read the file with name filename, and put its content in a newly allocated buffer or map it with mmap() when available. In case of success set *bufptr to the read or mmapped buffer, and *size to the size in bytes of the buffer in *bufptr. Unlike mmap this function succeeds with zero sized files, in this case *bufptr will be set to NULL and *size will be set to 0. The returned buffer must be released with av_file_unmap().</summary>
    /// <param name="filename">path to the file</param>
    /// <param name="size">pointee is set to the size in bytes of the buffer</param>
    /// <param name="log_offset">loglevel offset used for logging</param>
    /// <param name="log_ctx">context used for logging</param>
    /// <returns>a non negative number in case of success, a negative value corresponding to an AVERROR error code in case of failure</returns>
    public static int av_file_map(string @filename, ref byte* @bufptr, ulong* @size, int @log_offset, void* @log_ctx)
    {
        fixed (byte** ptr = &@bufptr)
        {
            return av_file_map(@filename, ptr, @size, @log_offset, @log_ctx);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_file_unmap_delegate(byte* @bufptr, ulong @size);
    private static av_file_unmap_delegate? _av_file_unmap_cache;
    
    /// <summary>Unmap or free the buffer bufptr created by av_file_map().</summary>
    /// <param name="bufptr">the buffer previously created with av_file_map()</param>
    /// <param name="size">size in bytes of bufptr, must be the same as returned by av_file_map()</param>
    public static void av_file_unmap(byte* @bufptr, ulong @size)
    {
        _av_file_unmap_cache ??= FunctionResolver.GetFunctionDelegate<av_file_unmap_delegate>("avutil", "av_file_unmap", ThrowErrorIfFunctionNotFound);
        if (_av_file_unmap_cache == null)
            throw new NotSupportedException();
        _av_file_unmap_cache(@bufptr, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_filename_number_test_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename);
    private static av_filename_number_test_delegate? _av_filename_number_test_cache;
    
    /// <summary>Check whether filename actually is a numbered sequence generator.</summary>
    /// <param name="filename">possible numbered sequence string</param>
    /// <returns>1 if a valid numbered sequence string, 0 otherwise</returns>
    public static int av_filename_number_test(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename)
    {
        _av_filename_number_test_cache ??= FunctionResolver.GetFunctionDelegate<av_filename_number_test_delegate>("avformat", "av_filename_number_test", ThrowErrorIfFunctionNotFound);
        if (_av_filename_number_test_cache == null)
            throw new NotSupportedException();
        return _av_filename_number_test_cache(@filename);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVFilter* av_filter_iterate_delegate(void** @opaque);
    private static av_filter_iterate_delegate? _av_filter_iterate_cache;
    
    /// <summary>Iterate over all registered filters.</summary>
    /// <param name="opaque">a pointer where libavfilter will store the iteration state. Must point to NULL to start the iteration.</param>
    /// <returns>the next registered filter or NULL when the iteration is finished</returns>
    public static AVFilter* av_filter_iterate(void** @opaque)
    {
        _av_filter_iterate_cache ??= FunctionResolver.GetFunctionDelegate<av_filter_iterate_delegate>("avfilter", "av_filter_iterate", ThrowErrorIfFunctionNotFound);
        if (_av_filter_iterate_cache == null)
            throw new NotSupportedException();
        return _av_filter_iterate_cache(@opaque);
    }
    
    /// <summary>Iterate over all registered filters.</summary>
    /// <returns>the next registered filter or NULL when the iteration is finished</returns>
    public static AVFilter* av_filter_iterate(ref void* @opaque)
    {
        fixed (void** ptr = &@opaque)
        {
            return av_filter_iterate(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVPixelFormat av_find_best_pix_fmt_of_2_delegate(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
    private static av_find_best_pix_fmt_of_2_delegate? _av_find_best_pix_fmt_of_2_cache;
    
    /// <summary>Compute what kind of losses will occur when converting from one specific pixel format to another. When converting from one pixel format to another, information loss may occur. For example, when converting from RGB24 to GRAY, the color information will be lost. Similarly, other losses occur when converting from some formats to other formats. These losses can involve loss of chroma, but also loss of resolution, loss of color depth, loss due to the color space conversion, loss of the alpha bits or loss due to color quantization. av_get_fix_fmt_loss() informs you about the various types of losses which will occur when converting from one pixel format to another.</summary>
    /// <param name="src_pix_fmt">source pixel format</param>
    /// <param name="has_alpha">Whether the source pixel format alpha channel is used.</param>
    /// <returns>Combination of flags informing you what kind of losses will occur (maximum loss for an invalid dst_pix_fmt).</returns>
    public static AVPixelFormat av_find_best_pix_fmt_of_2(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr)
    {
        _av_find_best_pix_fmt_of_2_cache ??= FunctionResolver.GetFunctionDelegate<av_find_best_pix_fmt_of_2_delegate>("avutil", "av_find_best_pix_fmt_of_2", ThrowErrorIfFunctionNotFound);
        if (_av_find_best_pix_fmt_of_2_cache == null)
            throw new NotSupportedException();
        return _av_find_best_pix_fmt_of_2_cache(@dst_pix_fmt1, @dst_pix_fmt2, @src_pix_fmt, @has_alpha, @loss_ptr);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_find_best_stream_delegate(AVFormatContext* @ic, AVMediaType @type, int @wanted_stream_nb, int @related_stream, AVCodec** @decoder_ret, int @flags);
    private static av_find_best_stream_delegate? _av_find_best_stream_cache;
    
    /// <summary>Find the &quot;best&quot; stream in the file. The best stream is determined according to various heuristics as the most likely to be what the user expects. If the decoder parameter is non-NULL, av_find_best_stream will find the default decoder for the stream&apos;s codec; streams for which no decoder can be found are ignored.</summary>
    /// <param name="ic">media file handle</param>
    /// <param name="type">stream type: video, audio, subtitles, etc.</param>
    /// <param name="wanted_stream_nb">user-requested stream number, or -1 for automatic selection</param>
    /// <param name="related_stream">try to find a stream related (eg. in the same program) to this one, or -1 if none</param>
    /// <param name="decoder_ret">if non-NULL, returns the decoder for the selected stream</param>
    /// <param name="flags">flags; none are currently defined</param>
    /// <returns>the non-negative stream number in case of success, AVERROR_STREAM_NOT_FOUND if no stream with the requested type could be found, AVERROR_DECODER_NOT_FOUND if streams were found but no decoder</returns>
    public static int av_find_best_stream(AVFormatContext* @ic, AVMediaType @type, int @wanted_stream_nb, int @related_stream, AVCodec** @decoder_ret, int @flags)
    {
        _av_find_best_stream_cache ??= FunctionResolver.GetFunctionDelegate<av_find_best_stream_delegate>("avformat", "av_find_best_stream", ThrowErrorIfFunctionNotFound);
        if (_av_find_best_stream_cache == null)
            throw new NotSupportedException();
        return _av_find_best_stream_cache(@ic, @type, @wanted_stream_nb, @related_stream, @decoder_ret, @flags);
    }
    
    /// <summary>Find the &quot;best&quot; stream in the file. The best stream is determined according to various heuristics as the most likely to be what the user expects. If the decoder parameter is non-NULL, av_find_best_stream will find the default decoder for the stream&apos;s codec; streams for which no decoder can be found are ignored.</summary>
    /// <param name="ic">media file handle</param>
    /// <param name="type">stream type: video, audio, subtitles, etc.</param>
    /// <param name="wanted_stream_nb">user-requested stream number, or -1 for automatic selection</param>
    /// <param name="related_stream">try to find a stream related (eg. in the same program) to this one, or -1 if none</param>
    /// <param name="flags">flags; none are currently defined</param>
    /// <returns>the non-negative stream number in case of success, AVERROR_STREAM_NOT_FOUND if no stream with the requested type could be found, AVERROR_DECODER_NOT_FOUND if streams were found but no decoder</returns>
    public static int av_find_best_stream(AVFormatContext* @ic, AVMediaType @type, int @wanted_stream_nb, int @related_stream, ref AVCodec* @decoder_ret, int @flags)
    {
        fixed (AVCodec** ptr = &@decoder_ret)
        {
            return av_find_best_stream(@ic, @type, @wanted_stream_nb, @related_stream, ptr, @flags);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_find_default_stream_index_delegate(AVFormatContext* @s);
    private static av_find_default_stream_index_delegate? _av_find_default_stream_index_cache;
    
    public static int av_find_default_stream_index(AVFormatContext* @s)
    {
        _av_find_default_stream_index_cache ??= FunctionResolver.GetFunctionDelegate<av_find_default_stream_index_delegate>("avformat", "av_find_default_stream_index", ThrowErrorIfFunctionNotFound);
        if (_av_find_default_stream_index_cache == null)
            throw new NotSupportedException();
        return _av_find_default_stream_index_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVInputFormat* av_find_input_format_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @short_name);
    private static av_find_input_format_delegate? _av_find_input_format_cache;
    
    /// <summary>Find AVInputFormat based on the short name of the input format.</summary>
    public static AVInputFormat* av_find_input_format(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @short_name)
    {
        _av_find_input_format_cache ??= FunctionResolver.GetFunctionDelegate<av_find_input_format_delegate>("avformat", "av_find_input_format", ThrowErrorIfFunctionNotFound);
        if (_av_find_input_format_cache == null)
            throw new NotSupportedException();
        return _av_find_input_format_cache(@short_name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_find_nearest_q_idx_delegate(AVRational @q, AVRational* @q_list);
    private static av_find_nearest_q_idx_delegate? _av_find_nearest_q_idx_cache;
    
    /// <summary>Find the value in a list of rationals nearest a given reference rational.</summary>
    /// <param name="q">Reference rational</param>
    /// <param name="q_list">Array of rationals terminated by `{0, 0}`</param>
    /// <returns>Index of the nearest value found in the array</returns>
    public static int av_find_nearest_q_idx(AVRational @q, AVRational* @q_list)
    {
        _av_find_nearest_q_idx_cache ??= FunctionResolver.GetFunctionDelegate<av_find_nearest_q_idx_delegate>("avutil", "av_find_nearest_q_idx", ThrowErrorIfFunctionNotFound);
        if (_av_find_nearest_q_idx_cache == null)
            throw new NotSupportedException();
        return _av_find_nearest_q_idx_cache(@q, @q_list);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVProgram* av_find_program_from_stream_delegate(AVFormatContext* @ic, AVProgram* @last, int @s);
    private static av_find_program_from_stream_delegate? _av_find_program_from_stream_cache;
    
    /// <summary>Find the programs which belong to a given stream.</summary>
    /// <param name="ic">media file handle</param>
    /// <param name="last">the last found program, the search will start after this program, or from the beginning if it is NULL</param>
    /// <param name="s">stream index</param>
    /// <returns>the next program which belongs to s, NULL if no program is found or the last program is not among the programs of ic.</returns>
    public static AVProgram* av_find_program_from_stream(AVFormatContext* @ic, AVProgram* @last, int @s)
    {
        _av_find_program_from_stream_cache ??= FunctionResolver.GetFunctionDelegate<av_find_program_from_stream_delegate>("avformat", "av_find_program_from_stream", ThrowErrorIfFunctionNotFound);
        if (_av_find_program_from_stream_cache == null)
            throw new NotSupportedException();
        return _av_find_program_from_stream_cache(@ic, @last, @s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVDurationEstimationMethod av_fmt_ctx_get_duration_estimation_method_delegate(AVFormatContext* @ctx);
    private static av_fmt_ctx_get_duration_estimation_method_delegate? _av_fmt_ctx_get_duration_estimation_method_cache;
    
    /// <summary>Returns the method used to set ctx-&gt;duration.</summary>
    /// <returns>AVFMT_DURATION_FROM_PTS, AVFMT_DURATION_FROM_STREAM, or AVFMT_DURATION_FROM_BITRATE.</returns>
    [Obsolete("duration_estimation_method is public and can be read directly.")]
    public static AVDurationEstimationMethod av_fmt_ctx_get_duration_estimation_method(AVFormatContext* @ctx)
    {
        _av_fmt_ctx_get_duration_estimation_method_cache ??= FunctionResolver.GetFunctionDelegate<av_fmt_ctx_get_duration_estimation_method_delegate>("avformat", "av_fmt_ctx_get_duration_estimation_method", ThrowErrorIfFunctionNotFound);
        if (_av_fmt_ctx_get_duration_estimation_method_cache == null)
            throw new NotSupportedException();
        return _av_fmt_ctx_get_duration_estimation_method_cache(@ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_force_cpu_flags_delegate(int @flags);
    private static av_force_cpu_flags_delegate? _av_force_cpu_flags_cache;
    
    /// <summary>Disables cpu detection and forces the specified flags. -1 is a special case that disables forcing of specific flags.</summary>
    public static void av_force_cpu_flags(int @flags)
    {
        _av_force_cpu_flags_cache ??= FunctionResolver.GetFunctionDelegate<av_force_cpu_flags_delegate>("avutil", "av_force_cpu_flags", ThrowErrorIfFunctionNotFound);
        if (_av_force_cpu_flags_cache == null)
            throw new NotSupportedException();
        _av_force_cpu_flags_cache(@flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_format_inject_global_side_data_delegate(AVFormatContext* @s);
    private static av_format_inject_global_side_data_delegate? _av_format_inject_global_side_data_cache;
    
    /// <summary>This function will cause global side data to be injected in the next packet of each stream as well as after any subsequent seek.</summary>
    public static void av_format_inject_global_side_data(AVFormatContext* @s)
    {
        _av_format_inject_global_side_data_cache ??= FunctionResolver.GetFunctionDelegate<av_format_inject_global_side_data_delegate>("avformat", "av_format_inject_global_side_data", ThrowErrorIfFunctionNotFound);
        if (_av_format_inject_global_side_data_cache == null)
            throw new NotSupportedException();
        _av_format_inject_global_side_data_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte* av_fourcc_make_string_delegate(byte* @buf, uint @fourcc);
    private static av_fourcc_make_string_delegate? _av_fourcc_make_string_cache;
    
    /// <summary>Fill the provided buffer with a string containing a FourCC (four-character code) representation.</summary>
    /// <param name="buf">a buffer with size in bytes of at least AV_FOURCC_MAX_STRING_SIZE</param>
    /// <param name="fourcc">the fourcc to represent</param>
    /// <returns>the buffer in input</returns>
    public static byte* av_fourcc_make_string(byte* @buf, uint @fourcc)
    {
        _av_fourcc_make_string_cache ??= FunctionResolver.GetFunctionDelegate<av_fourcc_make_string_delegate>("avutil", "av_fourcc_make_string", ThrowErrorIfFunctionNotFound);
        if (_av_fourcc_make_string_cache == null)
            throw new NotSupportedException();
        return _av_fourcc_make_string_cache(@buf, @fourcc);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVFrame* av_frame_alloc_delegate();
    private static av_frame_alloc_delegate? _av_frame_alloc_cache;
    
    /// <summary>Allocate an AVFrame and set its fields to default values. The resulting struct must be freed using av_frame_free().</summary>
    /// <returns>An AVFrame filled with default values or NULL on failure.</returns>
    public static AVFrame* av_frame_alloc()
    {
        _av_frame_alloc_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_alloc_delegate>("avutil", "av_frame_alloc", ThrowErrorIfFunctionNotFound);
        if (_av_frame_alloc_cache == null)
            throw new NotSupportedException();
        return _av_frame_alloc_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_frame_apply_cropping_delegate(AVFrame* @frame, int @flags);
    private static av_frame_apply_cropping_delegate? _av_frame_apply_cropping_cache;
    
    /// <summary>Crop the given video AVFrame according to its crop_left/crop_top/crop_right/ crop_bottom fields. If cropping is successful, the function will adjust the data pointers and the width/height fields, and set the crop fields to 0.</summary>
    /// <param name="frame">the frame which should be cropped</param>
    /// <param name="flags">Some combination of AV_FRAME_CROP_* flags, or 0.</param>
    /// <returns>&gt;= 0 on success, a negative AVERROR on error. If the cropping fields were invalid, AVERROR(ERANGE) is returned, and nothing is changed.</returns>
    public static int av_frame_apply_cropping(AVFrame* @frame, int @flags)
    {
        _av_frame_apply_cropping_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_apply_cropping_delegate>("avutil", "av_frame_apply_cropping", ThrowErrorIfFunctionNotFound);
        if (_av_frame_apply_cropping_cache == null)
            throw new NotSupportedException();
        return _av_frame_apply_cropping_cache(@frame, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVFrame* av_frame_clone_delegate(AVFrame* @src);
    private static av_frame_clone_delegate? _av_frame_clone_cache;
    
    /// <summary>Create a new frame that references the same data as src.</summary>
    /// <returns>newly created AVFrame on success, NULL on error.</returns>
    public static AVFrame* av_frame_clone(AVFrame* @src)
    {
        _av_frame_clone_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_clone_delegate>("avutil", "av_frame_clone", ThrowErrorIfFunctionNotFound);
        if (_av_frame_clone_cache == null)
            throw new NotSupportedException();
        return _av_frame_clone_cache(@src);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_frame_copy_delegate(AVFrame* @dst, AVFrame* @src);
    private static av_frame_copy_delegate? _av_frame_copy_cache;
    
    /// <summary>Copy the frame data from src to dst.</summary>
    /// <returns>&gt;= 0 on success, a negative AVERROR on error.</returns>
    public static int av_frame_copy(AVFrame* @dst, AVFrame* @src)
    {
        _av_frame_copy_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_copy_delegate>("avutil", "av_frame_copy", ThrowErrorIfFunctionNotFound);
        if (_av_frame_copy_cache == null)
            throw new NotSupportedException();
        return _av_frame_copy_cache(@dst, @src);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_frame_copy_props_delegate(AVFrame* @dst, AVFrame* @src);
    private static av_frame_copy_props_delegate? _av_frame_copy_props_cache;
    
    /// <summary>Copy only &quot;metadata&quot; fields from src to dst.</summary>
    public static int av_frame_copy_props(AVFrame* @dst, AVFrame* @src)
    {
        _av_frame_copy_props_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_copy_props_delegate>("avutil", "av_frame_copy_props", ThrowErrorIfFunctionNotFound);
        if (_av_frame_copy_props_cache == null)
            throw new NotSupportedException();
        return _av_frame_copy_props_cache(@dst, @src);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_frame_free_delegate(AVFrame** @frame);
    private static av_frame_free_delegate? _av_frame_free_cache;
    
    /// <summary>Free the frame and any dynamically allocated objects in it, e.g. extended_data. If the frame is reference counted, it will be unreferenced first.</summary>
    /// <param name="frame">frame to be freed. The pointer will be set to NULL.</param>
    public static void av_frame_free(AVFrame** @frame)
    {
        _av_frame_free_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_free_delegate>("avutil", "av_frame_free", ThrowErrorIfFunctionNotFound);
        if (_av_frame_free_cache == null)
            throw new NotSupportedException();
        _av_frame_free_cache(@frame);
    }
    
    /// <summary>Free the frame and any dynamically allocated objects in it, e.g. extended_data. If the frame is reference counted, it will be unreferenced first.</summary>
    public static void av_frame_free(ref AVFrame* @frame)
    {
        fixed (AVFrame** ptr = &@frame)
        {
            av_frame_free(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_frame_get_buffer_delegate(AVFrame* @frame, int @align);
    private static av_frame_get_buffer_delegate? _av_frame_get_buffer_cache;
    
    /// <summary>Allocate new buffer(s) for audio or video data.</summary>
    /// <param name="frame">frame in which to store the new buffers.</param>
    /// <param name="align">Required buffer size alignment. If equal to 0, alignment will be chosen automatically for the current CPU. It is highly recommended to pass 0 here unless you know what you are doing.</param>
    /// <returns>0 on success, a negative AVERROR on error.</returns>
    public static int av_frame_get_buffer(AVFrame* @frame, int @align)
    {
        _av_frame_get_buffer_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_get_buffer_delegate>("avutil", "av_frame_get_buffer", ThrowErrorIfFunctionNotFound);
        if (_av_frame_get_buffer_cache == null)
            throw new NotSupportedException();
        return _av_frame_get_buffer_cache(@frame, @align);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVBufferRef* av_frame_get_plane_buffer_delegate(AVFrame* @frame, int @plane);
    private static av_frame_get_plane_buffer_delegate? _av_frame_get_plane_buffer_cache;
    
    /// <summary>Get the buffer reference a given data plane is stored in.</summary>
    /// <param name="frame">the frame to get the plane&apos;s buffer from</param>
    /// <param name="plane">index of the data plane of interest in frame-&gt;extended_data.</param>
    /// <returns>the buffer reference that contains the plane or NULL if the input frame is not valid.</returns>
    public static AVBufferRef* av_frame_get_plane_buffer(AVFrame* @frame, int @plane)
    {
        _av_frame_get_plane_buffer_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_get_plane_buffer_delegate>("avutil", "av_frame_get_plane_buffer", ThrowErrorIfFunctionNotFound);
        if (_av_frame_get_plane_buffer_cache == null)
            throw new NotSupportedException();
        return _av_frame_get_plane_buffer_cache(@frame, @plane);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVFrameSideData* av_frame_get_side_data_delegate(AVFrame* @frame, AVFrameSideDataType @type);
    private static av_frame_get_side_data_delegate? _av_frame_get_side_data_cache;
    
    /// <summary>Returns a pointer to the side data of a given type on success, NULL if there is no side data with such type in this frame.</summary>
    /// <returns>a pointer to the side data of a given type on success, NULL if there is no side data with such type in this frame.</returns>
    public static AVFrameSideData* av_frame_get_side_data(AVFrame* @frame, AVFrameSideDataType @type)
    {
        _av_frame_get_side_data_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_get_side_data_delegate>("avutil", "av_frame_get_side_data", ThrowErrorIfFunctionNotFound);
        if (_av_frame_get_side_data_cache == null)
            throw new NotSupportedException();
        return _av_frame_get_side_data_cache(@frame, @type);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_frame_is_writable_delegate(AVFrame* @frame);
    private static av_frame_is_writable_delegate? _av_frame_is_writable_cache;
    
    /// <summary>Check if the frame data is writable.</summary>
    /// <returns>A positive value if the frame data is writable (which is true if and only if each of the underlying buffers has only one reference, namely the one stored in this frame). Return 0 otherwise.</returns>
    public static int av_frame_is_writable(AVFrame* @frame)
    {
        _av_frame_is_writable_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_is_writable_delegate>("avutil", "av_frame_is_writable", ThrowErrorIfFunctionNotFound);
        if (_av_frame_is_writable_cache == null)
            throw new NotSupportedException();
        return _av_frame_is_writable_cache(@frame);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_frame_make_writable_delegate(AVFrame* @frame);
    private static av_frame_make_writable_delegate? _av_frame_make_writable_cache;
    
    /// <summary>Ensure that the frame data is writable, avoiding data copy if possible.</summary>
    /// <returns>0 on success, a negative AVERROR on error.</returns>
    public static int av_frame_make_writable(AVFrame* @frame)
    {
        _av_frame_make_writable_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_make_writable_delegate>("avutil", "av_frame_make_writable", ThrowErrorIfFunctionNotFound);
        if (_av_frame_make_writable_cache == null)
            throw new NotSupportedException();
        return _av_frame_make_writable_cache(@frame);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_frame_move_ref_delegate(AVFrame* @dst, AVFrame* @src);
    private static av_frame_move_ref_delegate? _av_frame_move_ref_cache;
    
    /// <summary>Move everything contained in src to dst and reset src.</summary>
    public static void av_frame_move_ref(AVFrame* @dst, AVFrame* @src)
    {
        _av_frame_move_ref_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_move_ref_delegate>("avutil", "av_frame_move_ref", ThrowErrorIfFunctionNotFound);
        if (_av_frame_move_ref_cache == null)
            throw new NotSupportedException();
        _av_frame_move_ref_cache(@dst, @src);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVFrameSideData* av_frame_new_side_data_delegate(AVFrame* @frame, AVFrameSideDataType @type, ulong @size);
    private static av_frame_new_side_data_delegate? _av_frame_new_side_data_cache;
    
    /// <summary>Add a new side data to a frame.</summary>
    /// <param name="frame">a frame to which the side data should be added</param>
    /// <param name="type">type of the added side data</param>
    /// <param name="size">size of the side data</param>
    /// <returns>newly added side data on success, NULL on error</returns>
    public static AVFrameSideData* av_frame_new_side_data(AVFrame* @frame, AVFrameSideDataType @type, ulong @size)
    {
        _av_frame_new_side_data_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_new_side_data_delegate>("avutil", "av_frame_new_side_data", ThrowErrorIfFunctionNotFound);
        if (_av_frame_new_side_data_cache == null)
            throw new NotSupportedException();
        return _av_frame_new_side_data_cache(@frame, @type, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVFrameSideData* av_frame_new_side_data_from_buf_delegate(AVFrame* @frame, AVFrameSideDataType @type, AVBufferRef* @buf);
    private static av_frame_new_side_data_from_buf_delegate? _av_frame_new_side_data_from_buf_cache;
    
    /// <summary>Add a new side data to a frame from an existing AVBufferRef</summary>
    /// <param name="frame">a frame to which the side data should be added</param>
    /// <param name="type">the type of the added side data</param>
    /// <param name="buf">an AVBufferRef to add as side data. The ownership of the reference is transferred to the frame.</param>
    /// <returns>newly added side data on success, NULL on error. On failure the frame is unchanged and the AVBufferRef remains owned by the caller.</returns>
    public static AVFrameSideData* av_frame_new_side_data_from_buf(AVFrame* @frame, AVFrameSideDataType @type, AVBufferRef* @buf)
    {
        _av_frame_new_side_data_from_buf_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_new_side_data_from_buf_delegate>("avutil", "av_frame_new_side_data_from_buf", ThrowErrorIfFunctionNotFound);
        if (_av_frame_new_side_data_from_buf_cache == null)
            throw new NotSupportedException();
        return _av_frame_new_side_data_from_buf_cache(@frame, @type, @buf);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_frame_ref_delegate(AVFrame* @dst, AVFrame* @src);
    private static av_frame_ref_delegate? _av_frame_ref_cache;
    
    /// <summary>Set up a new reference to the data described by the source frame.</summary>
    /// <returns>0 on success, a negative AVERROR on error</returns>
    public static int av_frame_ref(AVFrame* @dst, AVFrame* @src)
    {
        _av_frame_ref_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_ref_delegate>("avutil", "av_frame_ref", ThrowErrorIfFunctionNotFound);
        if (_av_frame_ref_cache == null)
            throw new NotSupportedException();
        return _av_frame_ref_cache(@dst, @src);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_frame_remove_side_data_delegate(AVFrame* @frame, AVFrameSideDataType @type);
    private static av_frame_remove_side_data_delegate? _av_frame_remove_side_data_cache;
    
    /// <summary>Remove and free all side data instances of the given type.</summary>
    public static void av_frame_remove_side_data(AVFrame* @frame, AVFrameSideDataType @type)
    {
        _av_frame_remove_side_data_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_remove_side_data_delegate>("avutil", "av_frame_remove_side_data", ThrowErrorIfFunctionNotFound);
        if (_av_frame_remove_side_data_cache == null)
            throw new NotSupportedException();
        _av_frame_remove_side_data_cache(@frame, @type);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_frame_replace_delegate(AVFrame* @dst, AVFrame* @src);
    private static av_frame_replace_delegate? _av_frame_replace_cache;
    
    /// <summary>Ensure the destination frame refers to the same data described by the source frame, either by creating a new reference for each AVBufferRef from src if they differ from those in dst, by allocating new buffers and copying data if src is not reference counted, or by unrefencing it if src is empty.</summary>
    /// <returns>0 on success, a negative AVERROR on error. On error, dst is unreferenced.</returns>
    public static int av_frame_replace(AVFrame* @dst, AVFrame* @src)
    {
        _av_frame_replace_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_replace_delegate>("avutil", "av_frame_replace", ThrowErrorIfFunctionNotFound);
        if (_av_frame_replace_cache == null)
            throw new NotSupportedException();
        return _av_frame_replace_cache(@dst, @src);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVFrameSideData* av_frame_side_data_add_delegate(AVFrameSideData*** @sd, int* @nb_sd, AVFrameSideDataType @type, AVBufferRef** @buf, uint @flags);
    private static av_frame_side_data_add_delegate? _av_frame_side_data_add_cache;
    
    /// <summary>Add a new side data entry to an array from an existing AVBufferRef.</summary>
    /// <param name="sd">pointer to array of side data to which to add another entry, or to NULL in order to start a new array.</param>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array.</param>
    /// <param name="type">type of the added side data</param>
    /// <param name="buf">Pointer to AVBufferRef to add to the array. On success, the function takes ownership of the AVBufferRef and *buf is set to NULL, unless AV_FRAME_SIDE_DATA_FLAG_NEW_REF is set in which case the ownership will remain with the caller.</param>
    /// <param name="flags">Some combination of AV_FRAME_SIDE_DATA_FLAG_* flags, or 0.</param>
    /// <returns>newly added side data on success, NULL on error.</returns>
    public static AVFrameSideData* av_frame_side_data_add(AVFrameSideData*** @sd, int* @nb_sd, AVFrameSideDataType @type, AVBufferRef** @buf, uint @flags)
    {
        _av_frame_side_data_add_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_side_data_add_delegate>("avutil", "av_frame_side_data_add", ThrowErrorIfFunctionNotFound);
        if (_av_frame_side_data_add_cache == null)
            throw new NotSupportedException();
        return _av_frame_side_data_add_cache(@sd, @nb_sd, @type, @buf, @flags);
    }
    
    /// <summary>Add a new side data entry to an array from an existing AVBufferRef.</summary>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array.</param>
    /// <param name="type">type of the added side data</param>
    /// <param name="buf">Pointer to AVBufferRef to add to the array. On success, the function takes ownership of the AVBufferRef and *buf is set to NULL, unless AV_FRAME_SIDE_DATA_FLAG_NEW_REF is set in which case the ownership will remain with the caller.</param>
    /// <param name="flags">Some combination of AV_FRAME_SIDE_DATA_FLAG_* flags, or 0.</param>
    /// <returns>newly added side data on success, NULL on error.</returns>
    public static AVFrameSideData* av_frame_side_data_add(ref AVFrameSideData** @sd, int* @nb_sd, AVFrameSideDataType @type, AVBufferRef** @buf, uint @flags)
    {
        fixed (AVFrameSideData*** ptr = &@sd)
        {
            return av_frame_side_data_add(ptr, @nb_sd, @type, @buf, @flags);
        }
    }
    
    /// <summary>Add a new side data entry to an array from an existing AVBufferRef.</summary>
    /// <param name="sd">pointer to array of side data to which to add another entry, or to NULL in order to start a new array.</param>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array.</param>
    /// <param name="type">type of the added side data</param>
    /// <param name="flags">Some combination of AV_FRAME_SIDE_DATA_FLAG_* flags, or 0.</param>
    /// <returns>newly added side data on success, NULL on error.</returns>
    public static AVFrameSideData* av_frame_side_data_add(AVFrameSideData*** @sd, int* @nb_sd, AVFrameSideDataType @type, ref AVBufferRef* @buf, uint @flags)
    {
        fixed (AVBufferRef** ptr = &@buf)
        {
            return av_frame_side_data_add(@sd, @nb_sd, @type, ptr, @flags);
        }
    }
    
    /// <summary>Add a new side data entry to an array from an existing AVBufferRef.</summary>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array.</param>
    /// <param name="type">type of the added side data</param>
    /// <param name="flags">Some combination of AV_FRAME_SIDE_DATA_FLAG_* flags, or 0.</param>
    /// <returns>newly added side data on success, NULL on error.</returns>
    public static AVFrameSideData* av_frame_side_data_add(ref AVFrameSideData** @sd, int* @nb_sd, AVFrameSideDataType @type, ref AVBufferRef* @buf, uint @flags)
    {
        fixed (AVFrameSideData*** ptr1 = &@sd)
        {
        fixed (AVBufferRef** ptr2 = &@buf)
        {
                return av_frame_side_data_add(ptr1, @nb_sd, @type, ptr2, @flags);
        }
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_frame_side_data_clone_delegate(AVFrameSideData*** @sd, int* @nb_sd, AVFrameSideData* @src, uint @flags);
    private static av_frame_side_data_clone_delegate? _av_frame_side_data_clone_cache;
    
    /// <summary>Add a new side data entry to an array based on existing side data, taking a reference towards the contained AVBufferRef.</summary>
    /// <param name="sd">pointer to array of side data to which to add another entry, or to NULL in order to start a new array.</param>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array.</param>
    /// <param name="src">side data to be cloned, with a new reference utilized for the buffer.</param>
    /// <param name="flags">Some combination of AV_FRAME_SIDE_DATA_FLAG_* flags, or 0.</param>
    /// <returns>negative error code on failure, &gt;=0 on success.</returns>
    public static int av_frame_side_data_clone(AVFrameSideData*** @sd, int* @nb_sd, AVFrameSideData* @src, uint @flags)
    {
        _av_frame_side_data_clone_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_side_data_clone_delegate>("avutil", "av_frame_side_data_clone", ThrowErrorIfFunctionNotFound);
        if (_av_frame_side_data_clone_cache == null)
            throw new NotSupportedException();
        return _av_frame_side_data_clone_cache(@sd, @nb_sd, @src, @flags);
    }
    
    /// <summary>Add a new side data entry to an array based on existing side data, taking a reference towards the contained AVBufferRef.</summary>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array.</param>
    /// <param name="src">side data to be cloned, with a new reference utilized for the buffer.</param>
    /// <param name="flags">Some combination of AV_FRAME_SIDE_DATA_FLAG_* flags, or 0.</param>
    /// <returns>negative error code on failure, &gt;=0 on success.</returns>
    public static int av_frame_side_data_clone(ref AVFrameSideData** @sd, int* @nb_sd, AVFrameSideData* @src, uint @flags)
    {
        fixed (AVFrameSideData*** ptr = &@sd)
        {
            return av_frame_side_data_clone(ptr, @nb_sd, @src, @flags);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVSideDataDescriptor* av_frame_side_data_desc_delegate(AVFrameSideDataType @type);
    private static av_frame_side_data_desc_delegate? _av_frame_side_data_desc_cache;
    
    /// <summary>Returns side data descriptor corresponding to a given side data type, NULL when not available.</summary>
    /// <returns>side data descriptor corresponding to a given side data type, NULL when not available.</returns>
    public static AVSideDataDescriptor* av_frame_side_data_desc(AVFrameSideDataType @type)
    {
        _av_frame_side_data_desc_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_side_data_desc_delegate>("avutil", "av_frame_side_data_desc", ThrowErrorIfFunctionNotFound);
        if (_av_frame_side_data_desc_cache == null)
            throw new NotSupportedException();
        return _av_frame_side_data_desc_cache(@type);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_frame_side_data_free_delegate(AVFrameSideData*** @sd, int* @nb_sd);
    private static av_frame_side_data_free_delegate? _av_frame_side_data_free_cache;
    
    /// <summary>Free all side data entries and their contents, then zeroes out the values which the pointers are pointing to.</summary>
    /// <param name="sd">pointer to array of side data to free. Will be set to NULL upon return.</param>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array. Will be set to 0 upon return.</param>
    public static void av_frame_side_data_free(AVFrameSideData*** @sd, int* @nb_sd)
    {
        _av_frame_side_data_free_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_side_data_free_delegate>("avutil", "av_frame_side_data_free", ThrowErrorIfFunctionNotFound);
        if (_av_frame_side_data_free_cache == null)
            throw new NotSupportedException();
        _av_frame_side_data_free_cache(@sd, @nb_sd);
    }
    
    /// <summary>Free all side data entries and their contents, then zeroes out the values which the pointers are pointing to.</summary>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array. Will be set to 0 upon return.</param>
    public static void av_frame_side_data_free(ref AVFrameSideData** @sd, int* @nb_sd)
    {
        fixed (AVFrameSideData*** ptr = &@sd)
        {
            av_frame_side_data_free(ptr, @nb_sd);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVFrameSideData* av_frame_side_data_get_c_delegate(AVFrameSideData** @sd, int @nb_sd, AVFrameSideDataType @type);
    private static av_frame_side_data_get_c_delegate? _av_frame_side_data_get_c_cache;
    
    /// <summary>Get a side data entry of a specific type from an array.</summary>
    /// <param name="sd">array of side data.</param>
    /// <param name="nb_sd">integer containing the number of entries in the array.</param>
    /// <param name="type">type of side data to be queried</param>
    /// <returns>a pointer to the side data of a given type on success, NULL if there is no side data with such type in this set.</returns>
    public static AVFrameSideData* av_frame_side_data_get_c(AVFrameSideData** @sd, int @nb_sd, AVFrameSideDataType @type)
    {
        _av_frame_side_data_get_c_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_side_data_get_c_delegate>("avutil", "av_frame_side_data_get_c", ThrowErrorIfFunctionNotFound);
        if (_av_frame_side_data_get_c_cache == null)
            throw new NotSupportedException();
        return _av_frame_side_data_get_c_cache(@sd, @nb_sd, @type);
    }
    
    /// <summary>Get a side data entry of a specific type from an array.</summary>
    /// <param name="nb_sd">integer containing the number of entries in the array.</param>
    /// <param name="type">type of side data to be queried</param>
    /// <returns>a pointer to the side data of a given type on success, NULL if there is no side data with such type in this set.</returns>
    public static AVFrameSideData* av_frame_side_data_get_c(ref AVFrameSideData* @sd, int @nb_sd, AVFrameSideDataType @type)
    {
        fixed (AVFrameSideData** ptr = &@sd)
        {
            return av_frame_side_data_get_c(ptr, @nb_sd, @type);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string av_frame_side_data_name_delegate(AVFrameSideDataType @type);
    private static av_frame_side_data_name_delegate? _av_frame_side_data_name_cache;
    
    /// <summary>Returns a string identifying the side data type</summary>
    /// <returns>a string identifying the side data type</returns>
    public static string av_frame_side_data_name(AVFrameSideDataType @type)
    {
        _av_frame_side_data_name_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_side_data_name_delegate>("avutil", "av_frame_side_data_name", ThrowErrorIfFunctionNotFound);
        if (_av_frame_side_data_name_cache == null)
            throw new NotSupportedException();
        return _av_frame_side_data_name_cache(@type);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVFrameSideData* av_frame_side_data_new_delegate(AVFrameSideData*** @sd, int* @nb_sd, AVFrameSideDataType @type, ulong @size, uint @flags);
    private static av_frame_side_data_new_delegate? _av_frame_side_data_new_cache;
    
    /// <summary>Add new side data entry to an array.</summary>
    /// <param name="sd">pointer to array of side data to which to add another entry, or to NULL in order to start a new array.</param>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array.</param>
    /// <param name="type">type of the added side data</param>
    /// <param name="size">size of the side data</param>
    /// <param name="flags">Some combination of AV_FRAME_SIDE_DATA_FLAG_* flags, or 0.</param>
    /// <returns>newly added side data on success, NULL on error.</returns>
    public static AVFrameSideData* av_frame_side_data_new(AVFrameSideData*** @sd, int* @nb_sd, AVFrameSideDataType @type, ulong @size, uint @flags)
    {
        _av_frame_side_data_new_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_side_data_new_delegate>("avutil", "av_frame_side_data_new", ThrowErrorIfFunctionNotFound);
        if (_av_frame_side_data_new_cache == null)
            throw new NotSupportedException();
        return _av_frame_side_data_new_cache(@sd, @nb_sd, @type, @size, @flags);
    }
    
    /// <summary>Add new side data entry to an array.</summary>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array.</param>
    /// <param name="type">type of the added side data</param>
    /// <param name="size">size of the side data</param>
    /// <param name="flags">Some combination of AV_FRAME_SIDE_DATA_FLAG_* flags, or 0.</param>
    /// <returns>newly added side data on success, NULL on error.</returns>
    public static AVFrameSideData* av_frame_side_data_new(ref AVFrameSideData** @sd, int* @nb_sd, AVFrameSideDataType @type, ulong @size, uint @flags)
    {
        fixed (AVFrameSideData*** ptr = &@sd)
        {
            return av_frame_side_data_new(ptr, @nb_sd, @type, @size, @flags);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_frame_side_data_remove_delegate(AVFrameSideData*** @sd, int* @nb_sd, AVFrameSideDataType @type);
    private static av_frame_side_data_remove_delegate? _av_frame_side_data_remove_cache;
    
    /// <summary>Remove and free all side data instances of the given type from an array.</summary>
    public static void av_frame_side_data_remove(AVFrameSideData*** @sd, int* @nb_sd, AVFrameSideDataType @type)
    {
        _av_frame_side_data_remove_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_side_data_remove_delegate>("avutil", "av_frame_side_data_remove", ThrowErrorIfFunctionNotFound);
        if (_av_frame_side_data_remove_cache == null)
            throw new NotSupportedException();
        _av_frame_side_data_remove_cache(@sd, @nb_sd, @type);
    }
    
    /// <summary>Remove and free all side data instances of the given type from an array.</summary>
    public static void av_frame_side_data_remove(ref AVFrameSideData** @sd, int* @nb_sd, AVFrameSideDataType @type)
    {
        fixed (AVFrameSideData*** ptr = &@sd)
        {
            av_frame_side_data_remove(ptr, @nb_sd, @type);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_frame_unref_delegate(AVFrame* @frame);
    private static av_frame_unref_delegate? _av_frame_unref_cache;
    
    /// <summary>Unreference all the buffers referenced by frame and reset the frame fields.</summary>
    public static void av_frame_unref(AVFrame* @frame)
    {
        _av_frame_unref_cache ??= FunctionResolver.GetFunctionDelegate<av_frame_unref_delegate>("avutil", "av_frame_unref", ThrowErrorIfFunctionNotFound);
        if (_av_frame_unref_cache == null)
            throw new NotSupportedException();
        _av_frame_unref_cache(@frame);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_free_delegate(void* @ptr);
    private static av_free_delegate? _av_free_cache;
    
    /// <summary>Free a memory block which has been allocated with a function of av_malloc() or av_realloc() family.</summary>
    /// <param name="ptr">Pointer to the memory block which should be freed.</param>
    public static void av_free(void* @ptr)
    {
        _av_free_cache ??= FunctionResolver.GetFunctionDelegate<av_free_delegate>("avutil", "av_free", ThrowErrorIfFunctionNotFound);
        if (_av_free_cache == null)
            throw new NotSupportedException();
        _av_free_cache(@ptr);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_freep_delegate(void* @ptr);
    private static av_freep_delegate? _av_freep_cache;
    
    /// <summary>Free a memory block which has been allocated with a function of av_malloc() or av_realloc() family, and set the pointer pointing to it to `NULL`.</summary>
    /// <param name="ptr">Pointer to the pointer to the memory block which should be freed</param>
    public static void av_freep(void* @ptr)
    {
        _av_freep_cache ??= FunctionResolver.GetFunctionDelegate<av_freep_delegate>("avutil", "av_freep", ThrowErrorIfFunctionNotFound);
        if (_av_freep_cache == null)
            throw new NotSupportedException();
        _av_freep_cache(@ptr);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate long av_gcd_delegate(long @a, long @b);
    private static av_gcd_delegate? _av_gcd_cache;
    
    /// <summary>Compute the greatest common divisor of two integer operands.</summary>
    /// <param name="a">Operand</param>
    /// <param name="b">Operand</param>
    /// <returns>GCD of a and b up to sign; if a &gt;= 0 and b &gt;= 0, return value is &gt;= 0; if a == 0 and b == 0, returns 0.</returns>
    public static long av_gcd(long @a, long @b)
    {
        _av_gcd_cache ??= FunctionResolver.GetFunctionDelegate<av_gcd_delegate>("avutil", "av_gcd", ThrowErrorIfFunctionNotFound);
        if (_av_gcd_cache == null)
            throw new NotSupportedException();
        return _av_gcd_cache(@a, @b);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVRational av_gcd_q_delegate(AVRational @a, AVRational @b, int @max_den, AVRational @def);
    private static av_gcd_q_delegate? _av_gcd_q_cache;
    
    /// <summary>Return the best rational so that a and b are multiple of it. If the resulting denominator is larger than max_den, return def.</summary>
    public static AVRational av_gcd_q(AVRational @a, AVRational @b, int @max_den, AVRational @def)
    {
        _av_gcd_q_cache ??= FunctionResolver.GetFunctionDelegate<av_gcd_q_delegate>("avutil", "av_gcd_q", ThrowErrorIfFunctionNotFound);
        if (_av_gcd_q_cache == null)
            throw new NotSupportedException();
        return _av_gcd_q_cache(@a, @b, @max_den, @def);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVSampleFormat av_get_alt_sample_fmt_delegate(AVSampleFormat @sample_fmt, int @planar);
    private static av_get_alt_sample_fmt_delegate? _av_get_alt_sample_fmt_cache;
    
    /// <summary>Return the planar&lt;-&gt;packed alternative form of the given sample format, or AV_SAMPLE_FMT_NONE on error. If the passed sample_fmt is already in the requested planar/packed format, the format returned is the same as the input.</summary>
    public static AVSampleFormat av_get_alt_sample_fmt(AVSampleFormat @sample_fmt, int @planar)
    {
        _av_get_alt_sample_fmt_cache ??= FunctionResolver.GetFunctionDelegate<av_get_alt_sample_fmt_delegate>("avutil", "av_get_alt_sample_fmt", ThrowErrorIfFunctionNotFound);
        if (_av_get_alt_sample_fmt_cache == null)
            throw new NotSupportedException();
        return _av_get_alt_sample_fmt_cache(@sample_fmt, @planar);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_get_audio_frame_duration_delegate(AVCodecContext* @avctx, int @frame_bytes);
    private static av_get_audio_frame_duration_delegate? _av_get_audio_frame_duration_cache;
    
    /// <summary>Return audio frame duration.</summary>
    /// <param name="avctx">codec context</param>
    /// <param name="frame_bytes">size of the frame, or 0 if unknown</param>
    /// <returns>frame duration, in samples, if known. 0 if not able to determine.</returns>
    public static int av_get_audio_frame_duration(AVCodecContext* @avctx, int @frame_bytes)
    {
        _av_get_audio_frame_duration_cache ??= FunctionResolver.GetFunctionDelegate<av_get_audio_frame_duration_delegate>("avcodec", "av_get_audio_frame_duration", ThrowErrorIfFunctionNotFound);
        if (_av_get_audio_frame_duration_cache == null)
            throw new NotSupportedException();
        return _av_get_audio_frame_duration_cache(@avctx, @frame_bytes);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_get_audio_frame_duration2_delegate(AVCodecParameters* @par, int @frame_bytes);
    private static av_get_audio_frame_duration2_delegate? _av_get_audio_frame_duration2_cache;
    
    /// <summary>This function is the same as av_get_audio_frame_duration(), except it works with AVCodecParameters instead of an AVCodecContext.</summary>
    public static int av_get_audio_frame_duration2(AVCodecParameters* @par, int @frame_bytes)
    {
        _av_get_audio_frame_duration2_cache ??= FunctionResolver.GetFunctionDelegate<av_get_audio_frame_duration2_delegate>("avcodec", "av_get_audio_frame_duration2", ThrowErrorIfFunctionNotFound);
        if (_av_get_audio_frame_duration2_cache == null)
            throw new NotSupportedException();
        return _av_get_audio_frame_duration2_cache(@par, @frame_bytes);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_get_bits_per_pixel_delegate(AVPixFmtDescriptor* @pixdesc);
    private static av_get_bits_per_pixel_delegate? _av_get_bits_per_pixel_cache;
    
    /// <summary>Return the number of bits per pixel used by the pixel format described by pixdesc. Note that this is not the same as the number of bits per sample.</summary>
    public static int av_get_bits_per_pixel(AVPixFmtDescriptor* @pixdesc)
    {
        _av_get_bits_per_pixel_cache ??= FunctionResolver.GetFunctionDelegate<av_get_bits_per_pixel_delegate>("avutil", "av_get_bits_per_pixel", ThrowErrorIfFunctionNotFound);
        if (_av_get_bits_per_pixel_cache == null)
            throw new NotSupportedException();
        return _av_get_bits_per_pixel_cache(@pixdesc);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_get_bits_per_sample_delegate(AVCodecID @codec_id);
    private static av_get_bits_per_sample_delegate? _av_get_bits_per_sample_cache;
    
    /// <summary>Return codec bits per sample.</summary>
    /// <param name="codec_id">the codec</param>
    /// <returns>Number of bits per sample or zero if unknown for the given codec.</returns>
    public static int av_get_bits_per_sample(AVCodecID @codec_id)
    {
        _av_get_bits_per_sample_cache ??= FunctionResolver.GetFunctionDelegate<av_get_bits_per_sample_delegate>("avcodec", "av_get_bits_per_sample", ThrowErrorIfFunctionNotFound);
        if (_av_get_bits_per_sample_cache == null)
            throw new NotSupportedException();
        return _av_get_bits_per_sample_cache(@codec_id);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_get_bytes_per_sample_delegate(AVSampleFormat @sample_fmt);
    private static av_get_bytes_per_sample_delegate? _av_get_bytes_per_sample_cache;
    
    /// <summary>Return number of bytes per sample.</summary>
    /// <param name="sample_fmt">the sample format</param>
    /// <returns>number of bytes per sample or zero if unknown for the given sample format</returns>
    public static int av_get_bytes_per_sample(AVSampleFormat @sample_fmt)
    {
        _av_get_bytes_per_sample_cache ??= FunctionResolver.GetFunctionDelegate<av_get_bytes_per_sample_delegate>("avutil", "av_get_bytes_per_sample", ThrowErrorIfFunctionNotFound);
        if (_av_get_bytes_per_sample_cache == null)
            throw new NotSupportedException();
        return _av_get_bytes_per_sample_cache(@sample_fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_get_cpu_flags_delegate();
    private static av_get_cpu_flags_delegate? _av_get_cpu_flags_cache;
    
    /// <summary>Return the flags which specify extensions supported by the CPU. The returned value is affected by av_force_cpu_flags() if that was used before. So av_get_cpu_flags() can easily be used in an application to detect the enabled cpu flags.</summary>
    public static int av_get_cpu_flags()
    {
        _av_get_cpu_flags_cache ??= FunctionResolver.GetFunctionDelegate<av_get_cpu_flags_delegate>("avutil", "av_get_cpu_flags", ThrowErrorIfFunctionNotFound);
        if (_av_get_cpu_flags_cache == null)
            throw new NotSupportedException();
        return _av_get_cpu_flags_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_get_exact_bits_per_sample_delegate(AVCodecID @codec_id);
    private static av_get_exact_bits_per_sample_delegate? _av_get_exact_bits_per_sample_cache;
    
    /// <summary>Return codec bits per sample. Only return non-zero if the bits per sample is exactly correct, not an approximation.</summary>
    /// <param name="codec_id">the codec</param>
    /// <returns>Number of bits per sample or zero if unknown for the given codec.</returns>
    public static int av_get_exact_bits_per_sample(AVCodecID @codec_id)
    {
        _av_get_exact_bits_per_sample_cache ??= FunctionResolver.GetFunctionDelegate<av_get_exact_bits_per_sample_delegate>("avcodec", "av_get_exact_bits_per_sample", ThrowErrorIfFunctionNotFound);
        if (_av_get_exact_bits_per_sample_cache == null)
            throw new NotSupportedException();
        return _av_get_exact_bits_per_sample_cache(@codec_id);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_get_frame_filename_delegate(byte* @buf, int @buf_size,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @path, int @number);
    private static av_get_frame_filename_delegate? _av_get_frame_filename_cache;
    
    public static int av_get_frame_filename(byte* @buf, int @buf_size,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @path, int @number)
    {
        _av_get_frame_filename_cache ??= FunctionResolver.GetFunctionDelegate<av_get_frame_filename_delegate>("avformat", "av_get_frame_filename", ThrowErrorIfFunctionNotFound);
        if (_av_get_frame_filename_cache == null)
            throw new NotSupportedException();
        return _av_get_frame_filename_cache(@buf, @buf_size, @path, @number);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_get_frame_filename2_delegate(byte* @buf, int @buf_size,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @path, int @number, int @flags);
    private static av_get_frame_filename2_delegate? _av_get_frame_filename2_cache;
    
    /// <summary>Return in &apos;buf&apos; the path with &apos;%d&apos; replaced by a number.</summary>
    /// <param name="buf">destination buffer</param>
    /// <param name="buf_size">destination buffer size</param>
    /// <param name="path">numbered sequence string</param>
    /// <param name="number">frame number</param>
    /// <param name="flags">AV_FRAME_FILENAME_FLAGS_*</param>
    /// <returns>0 if OK, -1 on format error</returns>
    public static int av_get_frame_filename2(byte* @buf, int @buf_size,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @path, int @number, int @flags)
    {
        _av_get_frame_filename2_cache ??= FunctionResolver.GetFunctionDelegate<av_get_frame_filename2_delegate>("avformat", "av_get_frame_filename2", ThrowErrorIfFunctionNotFound);
        if (_av_get_frame_filename2_cache == null)
            throw new NotSupportedException();
        return _av_get_frame_filename2_cache(@buf, @buf_size, @path, @number, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string av_get_media_type_string_delegate(AVMediaType @media_type);
    private static av_get_media_type_string_delegate? _av_get_media_type_string_cache;
    
    /// <summary>Return a string describing the media_type enum, NULL if media_type is unknown.</summary>
    public static string av_get_media_type_string(AVMediaType @media_type)
    {
        _av_get_media_type_string_cache ??= FunctionResolver.GetFunctionDelegate<av_get_media_type_string_delegate>("avutil", "av_get_media_type_string", ThrowErrorIfFunctionNotFound);
        if (_av_get_media_type_string_cache == null)
            throw new NotSupportedException();
        return _av_get_media_type_string_cache(@media_type);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_get_output_timestamp_delegate(AVFormatContext* @s, int @stream, long* @dts, long* @wall);
    private static av_get_output_timestamp_delegate? _av_get_output_timestamp_cache;
    
    /// <summary>Get timing information for the data currently output. The exact meaning of &quot;currently output&quot; depends on the format. It is mostly relevant for devices that have an internal buffer and/or work in real time.</summary>
    /// <param name="s">media file handle</param>
    /// <param name="stream">stream in the media file</param>
    /// <param name="dts">DTS of the last packet output for the stream, in stream time_base units</param>
    /// <param name="wall">absolute time when that packet whas output, in microsecond</param>
    public static int av_get_output_timestamp(AVFormatContext* @s, int @stream, long* @dts, long* @wall)
    {
        _av_get_output_timestamp_cache ??= FunctionResolver.GetFunctionDelegate<av_get_output_timestamp_delegate>("avformat", "av_get_output_timestamp", ThrowErrorIfFunctionNotFound);
        if (_av_get_output_timestamp_cache == null)
            throw new NotSupportedException();
        return _av_get_output_timestamp_cache(@s, @stream, @dts, @wall);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVSampleFormat av_get_packed_sample_fmt_delegate(AVSampleFormat @sample_fmt);
    private static av_get_packed_sample_fmt_delegate? _av_get_packed_sample_fmt_cache;
    
    /// <summary>Get the packed alternative form of the given sample format.</summary>
    /// <returns>the packed alternative form of the given sample format or AV_SAMPLE_FMT_NONE on error.</returns>
    public static AVSampleFormat av_get_packed_sample_fmt(AVSampleFormat @sample_fmt)
    {
        _av_get_packed_sample_fmt_cache ??= FunctionResolver.GetFunctionDelegate<av_get_packed_sample_fmt_delegate>("avutil", "av_get_packed_sample_fmt", ThrowErrorIfFunctionNotFound);
        if (_av_get_packed_sample_fmt_cache == null)
            throw new NotSupportedException();
        return _av_get_packed_sample_fmt_cache(@sample_fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_get_packet_delegate(AVIOContext* @s, AVPacket* @pkt, int @size);
    private static av_get_packet_delegate? _av_get_packet_cache;
    
    /// <summary>Allocate and read the payload of a packet and initialize its fields with default values.</summary>
    /// <param name="s">associated IO context</param>
    /// <param name="pkt">packet</param>
    /// <param name="size">desired payload size</param>
    /// <returns>&gt;0 (read size) if OK, AVERROR_xxx otherwise</returns>
    public static int av_get_packet(AVIOContext* @s, AVPacket* @pkt, int @size)
    {
        _av_get_packet_cache ??= FunctionResolver.GetFunctionDelegate<av_get_packet_delegate>("avformat", "av_get_packet", ThrowErrorIfFunctionNotFound);
        if (_av_get_packet_cache == null)
            throw new NotSupportedException();
        return _av_get_packet_cache(@s, @pkt, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_get_padded_bits_per_pixel_delegate(AVPixFmtDescriptor* @pixdesc);
    private static av_get_padded_bits_per_pixel_delegate? _av_get_padded_bits_per_pixel_cache;
    
    /// <summary>Return the number of bits per pixel for the pixel format described by pixdesc, including any padding or unused bits.</summary>
    public static int av_get_padded_bits_per_pixel(AVPixFmtDescriptor* @pixdesc)
    {
        _av_get_padded_bits_per_pixel_cache ??= FunctionResolver.GetFunctionDelegate<av_get_padded_bits_per_pixel_delegate>("avutil", "av_get_padded_bits_per_pixel", ThrowErrorIfFunctionNotFound);
        if (_av_get_padded_bits_per_pixel_cache == null)
            throw new NotSupportedException();
        return _av_get_padded_bits_per_pixel_cache(@pixdesc);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodecID av_get_pcm_codec_delegate(AVSampleFormat @fmt, int @be);
    private static av_get_pcm_codec_delegate? _av_get_pcm_codec_cache;
    
    /// <summary>Return the PCM codec associated with a sample format.</summary>
    /// <param name="be">endianness, 0 for little, 1 for big, -1 (or anything else) for native</param>
    /// <returns>AV_CODEC_ID_PCM_* or AV_CODEC_ID_NONE</returns>
    public static AVCodecID av_get_pcm_codec(AVSampleFormat @fmt, int @be)
    {
        _av_get_pcm_codec_cache ??= FunctionResolver.GetFunctionDelegate<av_get_pcm_codec_delegate>("avcodec", "av_get_pcm_codec", ThrowErrorIfFunctionNotFound);
        if (_av_get_pcm_codec_cache == null)
            throw new NotSupportedException();
        return _av_get_pcm_codec_cache(@fmt, @be);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte av_get_picture_type_char_delegate(AVPictureType @pict_type);
    private static av_get_picture_type_char_delegate? _av_get_picture_type_char_cache;
    
    /// <summary>Return a single letter to describe the given picture type pict_type.</summary>
    /// <param name="pict_type">the picture type</param>
    /// <returns>a single character representing the picture type, &apos;?&apos; if pict_type is unknown</returns>
    public static byte av_get_picture_type_char(AVPictureType @pict_type)
    {
        _av_get_picture_type_char_cache ??= FunctionResolver.GetFunctionDelegate<av_get_picture_type_char_delegate>("avutil", "av_get_picture_type_char", ThrowErrorIfFunctionNotFound);
        if (_av_get_picture_type_char_cache == null)
            throw new NotSupportedException();
        return _av_get_picture_type_char_cache(@pict_type);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVPixelFormat av_get_pix_fmt_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static av_get_pix_fmt_delegate? _av_get_pix_fmt_cache;
    
    /// <summary>Return the pixel format corresponding to name.</summary>
    public static AVPixelFormat av_get_pix_fmt(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _av_get_pix_fmt_cache ??= FunctionResolver.GetFunctionDelegate<av_get_pix_fmt_delegate>("avutil", "av_get_pix_fmt", ThrowErrorIfFunctionNotFound);
        if (_av_get_pix_fmt_cache == null)
            throw new NotSupportedException();
        return _av_get_pix_fmt_cache(@name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_get_pix_fmt_loss_delegate(AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha);
    private static av_get_pix_fmt_loss_delegate? _av_get_pix_fmt_loss_cache;
    
    /// <summary>Compute what kind of losses will occur when converting from one specific pixel format to another. When converting from one pixel format to another, information loss may occur. For example, when converting from RGB24 to GRAY, the color information will be lost. Similarly, other losses occur when converting from some formats to other formats. These losses can involve loss of chroma, but also loss of resolution, loss of color depth, loss due to the color space conversion, loss of the alpha bits or loss due to color quantization. av_get_fix_fmt_loss() informs you about the various types of losses which will occur when converting from one pixel format to another.</summary>
    /// <param name="dst_pix_fmt">destination pixel format</param>
    /// <param name="src_pix_fmt">source pixel format</param>
    /// <param name="has_alpha">Whether the source pixel format alpha channel is used.</param>
    /// <returns>Combination of flags informing you what kind of losses will occur (maximum loss for an invalid dst_pix_fmt).</returns>
    public static int av_get_pix_fmt_loss(AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha)
    {
        _av_get_pix_fmt_loss_cache ??= FunctionResolver.GetFunctionDelegate<av_get_pix_fmt_loss_delegate>("avutil", "av_get_pix_fmt_loss", ThrowErrorIfFunctionNotFound);
        if (_av_get_pix_fmt_loss_cache == null)
            throw new NotSupportedException();
        return _av_get_pix_fmt_loss_cache(@dst_pix_fmt, @src_pix_fmt, @has_alpha);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string av_get_pix_fmt_name_delegate(AVPixelFormat @pix_fmt);
    private static av_get_pix_fmt_name_delegate? _av_get_pix_fmt_name_cache;
    
    /// <summary>Return the short name for a pixel format, NULL in case pix_fmt is unknown.</summary>
    public static string av_get_pix_fmt_name(AVPixelFormat @pix_fmt)
    {
        _av_get_pix_fmt_name_cache ??= FunctionResolver.GetFunctionDelegate<av_get_pix_fmt_name_delegate>("avutil", "av_get_pix_fmt_name", ThrowErrorIfFunctionNotFound);
        if (_av_get_pix_fmt_name_cache == null)
            throw new NotSupportedException();
        return _av_get_pix_fmt_name_cache(@pix_fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte* av_get_pix_fmt_string_delegate(byte* @buf, int @buf_size, AVPixelFormat @pix_fmt);
    private static av_get_pix_fmt_string_delegate? _av_get_pix_fmt_string_cache;
    
    /// <summary>Print in buf the string corresponding to the pixel format with number pix_fmt, or a header if pix_fmt is negative.</summary>
    /// <param name="buf">the buffer where to write the string</param>
    /// <param name="buf_size">the size of buf</param>
    /// <param name="pix_fmt">the number of the pixel format to print the corresponding info string, or a negative value to print the corresponding header.</param>
    public static byte* av_get_pix_fmt_string(byte* @buf, int @buf_size, AVPixelFormat @pix_fmt)
    {
        _av_get_pix_fmt_string_cache ??= FunctionResolver.GetFunctionDelegate<av_get_pix_fmt_string_delegate>("avutil", "av_get_pix_fmt_string", ThrowErrorIfFunctionNotFound);
        if (_av_get_pix_fmt_string_cache == null)
            throw new NotSupportedException();
        return _av_get_pix_fmt_string_cache(@buf, @buf_size, @pix_fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVSampleFormat av_get_planar_sample_fmt_delegate(AVSampleFormat @sample_fmt);
    private static av_get_planar_sample_fmt_delegate? _av_get_planar_sample_fmt_cache;
    
    /// <summary>Get the planar alternative form of the given sample format.</summary>
    /// <returns>the planar alternative form of the given sample format or AV_SAMPLE_FMT_NONE on error.</returns>
    public static AVSampleFormat av_get_planar_sample_fmt(AVSampleFormat @sample_fmt)
    {
        _av_get_planar_sample_fmt_cache ??= FunctionResolver.GetFunctionDelegate<av_get_planar_sample_fmt_delegate>("avutil", "av_get_planar_sample_fmt", ThrowErrorIfFunctionNotFound);
        if (_av_get_planar_sample_fmt_cache == null)
            throw new NotSupportedException();
        return _av_get_planar_sample_fmt_cache(@sample_fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string av_get_profile_name_delegate(AVCodec* @codec, int @profile);
    private static av_get_profile_name_delegate? _av_get_profile_name_cache;
    
    /// <summary>Return a name for the specified profile, if available.</summary>
    /// <param name="codec">the codec that is searched for the given profile</param>
    /// <param name="profile">the profile value for which a name is requested</param>
    /// <returns>A name for the profile if found, NULL otherwise.</returns>
    public static string av_get_profile_name(AVCodec* @codec, int @profile)
    {
        _av_get_profile_name_cache ??= FunctionResolver.GetFunctionDelegate<av_get_profile_name_delegate>("avcodec", "av_get_profile_name", ThrowErrorIfFunctionNotFound);
        if (_av_get_profile_name_cache == null)
            throw new NotSupportedException();
        return _av_get_profile_name_cache(@codec, @profile);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVSampleFormat av_get_sample_fmt_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static av_get_sample_fmt_delegate? _av_get_sample_fmt_cache;
    
    /// <summary>Return a sample format corresponding to name, or AV_SAMPLE_FMT_NONE on error.</summary>
    public static AVSampleFormat av_get_sample_fmt(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _av_get_sample_fmt_cache ??= FunctionResolver.GetFunctionDelegate<av_get_sample_fmt_delegate>("avutil", "av_get_sample_fmt", ThrowErrorIfFunctionNotFound);
        if (_av_get_sample_fmt_cache == null)
            throw new NotSupportedException();
        return _av_get_sample_fmt_cache(@name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string av_get_sample_fmt_name_delegate(AVSampleFormat @sample_fmt);
    private static av_get_sample_fmt_name_delegate? _av_get_sample_fmt_name_cache;
    
    /// <summary>Return the name of sample_fmt, or NULL if sample_fmt is not recognized.</summary>
    public static string av_get_sample_fmt_name(AVSampleFormat @sample_fmt)
    {
        _av_get_sample_fmt_name_cache ??= FunctionResolver.GetFunctionDelegate<av_get_sample_fmt_name_delegate>("avutil", "av_get_sample_fmt_name", ThrowErrorIfFunctionNotFound);
        if (_av_get_sample_fmt_name_cache == null)
            throw new NotSupportedException();
        return _av_get_sample_fmt_name_cache(@sample_fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte* av_get_sample_fmt_string_delegate(byte* @buf, int @buf_size, AVSampleFormat @sample_fmt);
    private static av_get_sample_fmt_string_delegate? _av_get_sample_fmt_string_cache;
    
    /// <summary>Generate a string corresponding to the sample format with sample_fmt, or a header if sample_fmt is negative.</summary>
    /// <param name="buf">the buffer where to write the string</param>
    /// <param name="buf_size">the size of buf</param>
    /// <param name="sample_fmt">the number of the sample format to print the corresponding info string, or a negative value to print the corresponding header.</param>
    /// <returns>the pointer to the filled buffer or NULL if sample_fmt is unknown or in case of other errors</returns>
    public static byte* av_get_sample_fmt_string(byte* @buf, int @buf_size, AVSampleFormat @sample_fmt)
    {
        _av_get_sample_fmt_string_cache ??= FunctionResolver.GetFunctionDelegate<av_get_sample_fmt_string_delegate>("avutil", "av_get_sample_fmt_string", ThrowErrorIfFunctionNotFound);
        if (_av_get_sample_fmt_string_cache == null)
            throw new NotSupportedException();
        return _av_get_sample_fmt_string_cache(@buf, @buf_size, @sample_fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVRational av_get_time_base_q_delegate();
    private static av_get_time_base_q_delegate? _av_get_time_base_q_cache;
    
    /// <summary>Return the fractional representation of the internal time base.</summary>
    public static AVRational av_get_time_base_q()
    {
        _av_get_time_base_q_cache ??= FunctionResolver.GetFunctionDelegate<av_get_time_base_q_delegate>("avutil", "av_get_time_base_q", ThrowErrorIfFunctionNotFound);
        if (_av_get_time_base_q_cache == null)
            throw new NotSupportedException();
        return _av_get_time_base_q_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate long av_gettime_delegate();
    private static av_gettime_delegate? _av_gettime_cache;
    
    /// <summary>Get the current time in microseconds.</summary>
    public static long av_gettime()
    {
        _av_gettime_cache ??= FunctionResolver.GetFunctionDelegate<av_gettime_delegate>("avutil", "av_gettime", ThrowErrorIfFunctionNotFound);
        if (_av_gettime_cache == null)
            throw new NotSupportedException();
        return _av_gettime_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate long av_gettime_relative_delegate();
    private static av_gettime_relative_delegate? _av_gettime_relative_cache;
    
    /// <summary>Get the current time in microseconds since some unspecified starting point. On platforms that support it, the time comes from a monotonic clock This property makes this time source ideal for measuring relative time. The returned values may not be monotonic on platforms where a monotonic clock is not available.</summary>
    public static long av_gettime_relative()
    {
        _av_gettime_relative_cache ??= FunctionResolver.GetFunctionDelegate<av_gettime_relative_delegate>("avutil", "av_gettime_relative", ThrowErrorIfFunctionNotFound);
        if (_av_gettime_relative_cache == null)
            throw new NotSupportedException();
        return _av_gettime_relative_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_gettime_relative_is_monotonic_delegate();
    private static av_gettime_relative_is_monotonic_delegate? _av_gettime_relative_is_monotonic_cache;
    
    /// <summary>Indicates with a boolean result if the av_gettime_relative() time source is monotonic.</summary>
    public static int av_gettime_relative_is_monotonic()
    {
        _av_gettime_relative_is_monotonic_cache ??= FunctionResolver.GetFunctionDelegate<av_gettime_relative_is_monotonic_delegate>("avutil", "av_gettime_relative_is_monotonic", ThrowErrorIfFunctionNotFound);
        if (_av_gettime_relative_is_monotonic_cache == null)
            throw new NotSupportedException();
        return _av_gettime_relative_is_monotonic_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_grow_packet_delegate(AVPacket* @pkt, int @grow_by);
    private static av_grow_packet_delegate? _av_grow_packet_cache;
    
    /// <summary>Increase packet size, correctly zeroing padding</summary>
    /// <param name="pkt">packet</param>
    /// <param name="grow_by">number of bytes by which to increase the size of the packet</param>
    public static int av_grow_packet(AVPacket* @pkt, int @grow_by)
    {
        _av_grow_packet_cache ??= FunctionResolver.GetFunctionDelegate<av_grow_packet_delegate>("avcodec", "av_grow_packet", ThrowErrorIfFunctionNotFound);
        if (_av_grow_packet_cache == null)
            throw new NotSupportedException();
        return _av_grow_packet_cache(@pkt, @grow_by);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodecID av_guess_codec_delegate(AVOutputFormat* @fmt,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @short_name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @mime_type, AVMediaType @type);
    private static av_guess_codec_delegate? _av_guess_codec_cache;
    
    /// <summary>Guess the codec ID based upon muxer and filename.</summary>
    public static AVCodecID av_guess_codec(AVOutputFormat* @fmt,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @short_name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @mime_type, AVMediaType @type)
    {
        _av_guess_codec_cache ??= FunctionResolver.GetFunctionDelegate<av_guess_codec_delegate>("avformat", "av_guess_codec", ThrowErrorIfFunctionNotFound);
        if (_av_guess_codec_cache == null)
            throw new NotSupportedException();
        return _av_guess_codec_cache(@fmt, @short_name, @filename, @mime_type, @type);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVOutputFormat* av_guess_format_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @short_name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @mime_type);
    private static av_guess_format_delegate? _av_guess_format_cache;
    
    /// <summary>Return the output format in the list of registered output formats which best matches the provided parameters, or return NULL if there is no match.</summary>
    /// <param name="short_name">if non-NULL checks if short_name matches with the names of the registered formats</param>
    /// <param name="filename">if non-NULL checks if filename terminates with the extensions of the registered formats</param>
    /// <param name="mime_type">if non-NULL checks if mime_type matches with the MIME type of the registered formats</param>
    public static AVOutputFormat* av_guess_format(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @short_name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @mime_type)
    {
        _av_guess_format_cache ??= FunctionResolver.GetFunctionDelegate<av_guess_format_delegate>("avformat", "av_guess_format", ThrowErrorIfFunctionNotFound);
        if (_av_guess_format_cache == null)
            throw new NotSupportedException();
        return _av_guess_format_cache(@short_name, @filename, @mime_type);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVRational av_guess_frame_rate_delegate(AVFormatContext* @ctx, AVStream* @stream, AVFrame* @frame);
    private static av_guess_frame_rate_delegate? _av_guess_frame_rate_cache;
    
    /// <summary>Guess the frame rate, based on both the container and codec information.</summary>
    /// <param name="ctx">the format context which the stream is part of</param>
    /// <param name="stream">the stream which the frame is part of</param>
    /// <param name="frame">the frame for which the frame rate should be determined, may be NULL</param>
    /// <returns>the guessed (valid) frame rate, 0/1 if no idea</returns>
    public static AVRational av_guess_frame_rate(AVFormatContext* @ctx, AVStream* @stream, AVFrame* @frame)
    {
        _av_guess_frame_rate_cache ??= FunctionResolver.GetFunctionDelegate<av_guess_frame_rate_delegate>("avformat", "av_guess_frame_rate", ThrowErrorIfFunctionNotFound);
        if (_av_guess_frame_rate_cache == null)
            throw new NotSupportedException();
        return _av_guess_frame_rate_cache(@ctx, @stream, @frame);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVRational av_guess_sample_aspect_ratio_delegate(AVFormatContext* @format, AVStream* @stream, AVFrame* @frame);
    private static av_guess_sample_aspect_ratio_delegate? _av_guess_sample_aspect_ratio_cache;
    
    /// <summary>Guess the sample aspect ratio of a frame, based on both the stream and the frame aspect ratio.</summary>
    /// <param name="format">the format context which the stream is part of</param>
    /// <param name="stream">the stream which the frame is part of</param>
    /// <param name="frame">the frame with the aspect ratio to be determined</param>
    /// <returns>the guessed (valid) sample_aspect_ratio, 0/1 if no idea</returns>
    public static AVRational av_guess_sample_aspect_ratio(AVFormatContext* @format, AVStream* @stream, AVFrame* @frame)
    {
        _av_guess_sample_aspect_ratio_cache ??= FunctionResolver.GetFunctionDelegate<av_guess_sample_aspect_ratio_delegate>("avformat", "av_guess_sample_aspect_ratio", ThrowErrorIfFunctionNotFound);
        if (_av_guess_sample_aspect_ratio_cache == null)
            throw new NotSupportedException();
        return _av_guess_sample_aspect_ratio_cache(@format, @stream, @frame);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_hex_dump_delegate(_iobuf* @f, byte* @buf, int @size);
    private static av_hex_dump_delegate? _av_hex_dump_cache;
    
    /// <summary>Send a nice hexadecimal dump of a buffer to the specified file stream.</summary>
    /// <param name="f">The file stream pointer where the dump should be sent to.</param>
    /// <param name="buf">buffer</param>
    /// <param name="size">buffer size</param>
    public static void av_hex_dump(_iobuf* @f, byte* @buf, int @size)
    {
        _av_hex_dump_cache ??= FunctionResolver.GetFunctionDelegate<av_hex_dump_delegate>("avformat", "av_hex_dump", ThrowErrorIfFunctionNotFound);
        if (_av_hex_dump_cache == null)
            throw new NotSupportedException();
        _av_hex_dump_cache(@f, @buf, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_hex_dump_log_delegate(void* @avcl, int @level, byte* @buf, int @size);
    private static av_hex_dump_log_delegate? _av_hex_dump_log_cache;
    
    /// <summary>Send a nice hexadecimal dump of a buffer to the log.</summary>
    /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
    /// <param name="level">The importance level of the message, lower values signifying higher importance.</param>
    /// <param name="buf">buffer</param>
    /// <param name="size">buffer size</param>
    public static void av_hex_dump_log(void* @avcl, int @level, byte* @buf, int @size)
    {
        _av_hex_dump_log_cache ??= FunctionResolver.GetFunctionDelegate<av_hex_dump_log_delegate>("avformat", "av_hex_dump_log", ThrowErrorIfFunctionNotFound);
        if (_av_hex_dump_log_cache == null)
            throw new NotSupportedException();
        _av_hex_dump_log_cache(@avcl, @level, @buf, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVBufferRef* av_hwdevice_ctx_alloc_delegate(AVHWDeviceType @type);
    private static av_hwdevice_ctx_alloc_delegate? _av_hwdevice_ctx_alloc_cache;
    
    /// <summary>Allocate an AVHWDeviceContext for a given hardware type.</summary>
    /// <param name="type">the type of the hardware device to allocate.</param>
    /// <returns>a reference to the newly created AVHWDeviceContext on success or NULL on failure.</returns>
    public static AVBufferRef* av_hwdevice_ctx_alloc(AVHWDeviceType @type)
    {
        _av_hwdevice_ctx_alloc_cache ??= FunctionResolver.GetFunctionDelegate<av_hwdevice_ctx_alloc_delegate>("avutil", "av_hwdevice_ctx_alloc", ThrowErrorIfFunctionNotFound);
        if (_av_hwdevice_ctx_alloc_cache == null)
            throw new NotSupportedException();
        return _av_hwdevice_ctx_alloc_cache(@type);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_hwdevice_ctx_create_delegate(AVBufferRef** @device_ctx, AVHWDeviceType @type,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @device, AVDictionary* @opts, int @flags);
    private static av_hwdevice_ctx_create_delegate? _av_hwdevice_ctx_create_cache;
    
    /// <summary>Open a device of the specified type and create an AVHWDeviceContext for it.</summary>
    /// <param name="device_ctx">On success, a reference to the newly-created device context will be written here. The reference is owned by the caller and must be released with av_buffer_unref() when no longer needed. On failure, NULL will be written to this pointer.</param>
    /// <param name="type">The type of the device to create.</param>
    /// <param name="device">A type-specific string identifying the device to open.</param>
    /// <param name="opts">A dictionary of additional (type-specific) options to use in opening the device. The dictionary remains owned by the caller.</param>
    /// <param name="flags">currently unused</param>
    /// <returns>0 on success, a negative AVERROR code on failure.</returns>
    public static int av_hwdevice_ctx_create(AVBufferRef** @device_ctx, AVHWDeviceType @type,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @device, AVDictionary* @opts, int @flags)
    {
        _av_hwdevice_ctx_create_cache ??= FunctionResolver.GetFunctionDelegate<av_hwdevice_ctx_create_delegate>("avutil", "av_hwdevice_ctx_create", ThrowErrorIfFunctionNotFound);
        if (_av_hwdevice_ctx_create_cache == null)
            throw new NotSupportedException();
        return _av_hwdevice_ctx_create_cache(@device_ctx, @type, @device, @opts, @flags);
    }
    
    /// <summary>Open a device of the specified type and create an AVHWDeviceContext for it.</summary>
    /// <param name="type">The type of the device to create.</param>
    /// <param name="device">A type-specific string identifying the device to open.</param>
    /// <param name="opts">A dictionary of additional (type-specific) options to use in opening the device. The dictionary remains owned by the caller.</param>
    /// <param name="flags">currently unused</param>
    /// <returns>0 on success, a negative AVERROR code on failure.</returns>
    public static int av_hwdevice_ctx_create(ref AVBufferRef* @device_ctx, AVHWDeviceType @type, string @device, AVDictionary* @opts, int @flags)
    {
        fixed (AVBufferRef** ptr = &@device_ctx)
        {
            return av_hwdevice_ctx_create(ptr, @type, @device, @opts, @flags);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_hwdevice_ctx_create_derived_delegate(AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, int @flags);
    private static av_hwdevice_ctx_create_derived_delegate? _av_hwdevice_ctx_create_derived_cache;
    
    /// <summary>Create a new device of the specified type from an existing device.</summary>
    /// <param name="dst_ctx">On success, a reference to the newly-created AVHWDeviceContext.</param>
    /// <param name="type">The type of the new device to create.</param>
    /// <param name="src_ctx">A reference to an existing AVHWDeviceContext which will be used to create the new device.</param>
    /// <param name="flags">Currently unused; should be set to zero.</param>
    /// <returns>Zero on success, a negative AVERROR code on failure.</returns>
    public static int av_hwdevice_ctx_create_derived(AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, int @flags)
    {
        _av_hwdevice_ctx_create_derived_cache ??= FunctionResolver.GetFunctionDelegate<av_hwdevice_ctx_create_derived_delegate>("avutil", "av_hwdevice_ctx_create_derived", ThrowErrorIfFunctionNotFound);
        if (_av_hwdevice_ctx_create_derived_cache == null)
            throw new NotSupportedException();
        return _av_hwdevice_ctx_create_derived_cache(@dst_ctx, @type, @src_ctx, @flags);
    }
    
    /// <summary>Create a new device of the specified type from an existing device.</summary>
    /// <param name="type">The type of the new device to create.</param>
    /// <param name="src_ctx">A reference to an existing AVHWDeviceContext which will be used to create the new device.</param>
    /// <param name="flags">Currently unused; should be set to zero.</param>
    /// <returns>Zero on success, a negative AVERROR code on failure.</returns>
    public static int av_hwdevice_ctx_create_derived(ref AVBufferRef* @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, int @flags)
    {
        fixed (AVBufferRef** ptr = &@dst_ctx)
        {
            return av_hwdevice_ctx_create_derived(ptr, @type, @src_ctx, @flags);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_hwdevice_ctx_create_derived_opts_delegate(AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, AVDictionary* @options, int @flags);
    private static av_hwdevice_ctx_create_derived_opts_delegate? _av_hwdevice_ctx_create_derived_opts_cache;
    
    /// <summary>Create a new device of the specified type from an existing device.</summary>
    /// <param name="dst_ctx">On success, a reference to the newly-created AVHWDeviceContext.</param>
    /// <param name="type">The type of the new device to create.</param>
    /// <param name="src_ctx">A reference to an existing AVHWDeviceContext which will be used to create the new device.</param>
    /// <param name="options">Options for the new device to create, same format as in av_hwdevice_ctx_create.</param>
    /// <param name="flags">Currently unused; should be set to zero.</param>
    /// <returns>Zero on success, a negative AVERROR code on failure.</returns>
    public static int av_hwdevice_ctx_create_derived_opts(AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, AVDictionary* @options, int @flags)
    {
        _av_hwdevice_ctx_create_derived_opts_cache ??= FunctionResolver.GetFunctionDelegate<av_hwdevice_ctx_create_derived_opts_delegate>("avutil", "av_hwdevice_ctx_create_derived_opts", ThrowErrorIfFunctionNotFound);
        if (_av_hwdevice_ctx_create_derived_opts_cache == null)
            throw new NotSupportedException();
        return _av_hwdevice_ctx_create_derived_opts_cache(@dst_ctx, @type, @src_ctx, @options, @flags);
    }
    
    /// <summary>Create a new device of the specified type from an existing device.</summary>
    /// <param name="type">The type of the new device to create.</param>
    /// <param name="src_ctx">A reference to an existing AVHWDeviceContext which will be used to create the new device.</param>
    /// <param name="options">Options for the new device to create, same format as in av_hwdevice_ctx_create.</param>
    /// <param name="flags">Currently unused; should be set to zero.</param>
    /// <returns>Zero on success, a negative AVERROR code on failure.</returns>
    public static int av_hwdevice_ctx_create_derived_opts(ref AVBufferRef* @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, AVDictionary* @options, int @flags)
    {
        fixed (AVBufferRef** ptr = &@dst_ctx)
        {
            return av_hwdevice_ctx_create_derived_opts(ptr, @type, @src_ctx, @options, @flags);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_hwdevice_ctx_init_delegate(AVBufferRef* @ref);
    private static av_hwdevice_ctx_init_delegate? _av_hwdevice_ctx_init_cache;
    
    /// <summary>Finalize the device context before use. This function must be called after the context is filled with all the required information and before it is used in any way.</summary>
    /// <param name="ref">a reference to the AVHWDeviceContext</param>
    /// <returns>0 on success, a negative AVERROR code on failure</returns>
    public static int av_hwdevice_ctx_init(AVBufferRef* @ref)
    {
        _av_hwdevice_ctx_init_cache ??= FunctionResolver.GetFunctionDelegate<av_hwdevice_ctx_init_delegate>("avutil", "av_hwdevice_ctx_init", ThrowErrorIfFunctionNotFound);
        if (_av_hwdevice_ctx_init_cache == null)
            throw new NotSupportedException();
        return _av_hwdevice_ctx_init_cache(@ref);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVHWDeviceType av_hwdevice_find_type_by_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static av_hwdevice_find_type_by_name_delegate? _av_hwdevice_find_type_by_name_cache;
    
    /// <summary>Look up an AVHWDeviceType by name.</summary>
    /// <param name="name">String name of the device type (case-insensitive).</param>
    /// <returns>The type from enum AVHWDeviceType, or AV_HWDEVICE_TYPE_NONE if not found.</returns>
    public static AVHWDeviceType av_hwdevice_find_type_by_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _av_hwdevice_find_type_by_name_cache ??= FunctionResolver.GetFunctionDelegate<av_hwdevice_find_type_by_name_delegate>("avutil", "av_hwdevice_find_type_by_name", ThrowErrorIfFunctionNotFound);
        if (_av_hwdevice_find_type_by_name_cache == null)
            throw new NotSupportedException();
        return _av_hwdevice_find_type_by_name_cache(@name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVHWFramesConstraints* av_hwdevice_get_hwframe_constraints_delegate(AVBufferRef* @ref, void* @hwconfig);
    private static av_hwdevice_get_hwframe_constraints_delegate? _av_hwdevice_get_hwframe_constraints_cache;
    
    /// <summary>Get the constraints on HW frames given a device and the HW-specific configuration to be used with that device. If no HW-specific configuration is provided, returns the maximum possible capabilities of the device.</summary>
    /// <param name="ref">a reference to the associated AVHWDeviceContext.</param>
    /// <param name="hwconfig">a filled HW-specific configuration structure, or NULL to return the maximum possible capabilities of the device.</param>
    /// <returns>AVHWFramesConstraints structure describing the constraints on the device, or NULL if not available.</returns>
    public static AVHWFramesConstraints* av_hwdevice_get_hwframe_constraints(AVBufferRef* @ref, void* @hwconfig)
    {
        _av_hwdevice_get_hwframe_constraints_cache ??= FunctionResolver.GetFunctionDelegate<av_hwdevice_get_hwframe_constraints_delegate>("avutil", "av_hwdevice_get_hwframe_constraints", ThrowErrorIfFunctionNotFound);
        if (_av_hwdevice_get_hwframe_constraints_cache == null)
            throw new NotSupportedException();
        return _av_hwdevice_get_hwframe_constraints_cache(@ref, @hwconfig);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string av_hwdevice_get_type_name_delegate(AVHWDeviceType @type);
    private static av_hwdevice_get_type_name_delegate? _av_hwdevice_get_type_name_cache;
    
    /// <summary>Get the string name of an AVHWDeviceType.</summary>
    /// <param name="type">Type from enum AVHWDeviceType.</param>
    /// <returns>Pointer to a static string containing the name, or NULL if the type is not valid.</returns>
    public static string av_hwdevice_get_type_name(AVHWDeviceType @type)
    {
        _av_hwdevice_get_type_name_cache ??= FunctionResolver.GetFunctionDelegate<av_hwdevice_get_type_name_delegate>("avutil", "av_hwdevice_get_type_name", ThrowErrorIfFunctionNotFound);
        if (_av_hwdevice_get_type_name_cache == null)
            throw new NotSupportedException();
        return _av_hwdevice_get_type_name_cache(@type);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* av_hwdevice_hwconfig_alloc_delegate(AVBufferRef* @device_ctx);
    private static av_hwdevice_hwconfig_alloc_delegate? _av_hwdevice_hwconfig_alloc_cache;
    
    /// <summary>Allocate a HW-specific configuration structure for a given HW device. After use, the user must free all members as required by the specific hardware structure being used, then free the structure itself with av_free().</summary>
    /// <param name="device_ctx">a reference to the associated AVHWDeviceContext.</param>
    /// <returns>The newly created HW-specific configuration structure on success or NULL on failure.</returns>
    public static void* av_hwdevice_hwconfig_alloc(AVBufferRef* @device_ctx)
    {
        _av_hwdevice_hwconfig_alloc_cache ??= FunctionResolver.GetFunctionDelegate<av_hwdevice_hwconfig_alloc_delegate>("avutil", "av_hwdevice_hwconfig_alloc", ThrowErrorIfFunctionNotFound);
        if (_av_hwdevice_hwconfig_alloc_cache == null)
            throw new NotSupportedException();
        return _av_hwdevice_hwconfig_alloc_cache(@device_ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVHWDeviceType av_hwdevice_iterate_types_delegate(AVHWDeviceType @prev);
    private static av_hwdevice_iterate_types_delegate? _av_hwdevice_iterate_types_cache;
    
    /// <summary>Iterate over supported device types.</summary>
    /// <param name="prev">AV_HWDEVICE_TYPE_NONE initially, then the previous type returned by this function in subsequent iterations.</param>
    /// <returns>The next usable device type from enum AVHWDeviceType, or AV_HWDEVICE_TYPE_NONE if there are no more.</returns>
    public static AVHWDeviceType av_hwdevice_iterate_types(AVHWDeviceType @prev)
    {
        _av_hwdevice_iterate_types_cache ??= FunctionResolver.GetFunctionDelegate<av_hwdevice_iterate_types_delegate>("avutil", "av_hwdevice_iterate_types", ThrowErrorIfFunctionNotFound);
        if (_av_hwdevice_iterate_types_cache == null)
            throw new NotSupportedException();
        return _av_hwdevice_iterate_types_cache(@prev);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_hwframe_constraints_free_delegate(AVHWFramesConstraints** @constraints);
    private static av_hwframe_constraints_free_delegate? _av_hwframe_constraints_free_cache;
    
    /// <summary>Free an AVHWFrameConstraints structure.</summary>
    /// <param name="constraints">The (filled or unfilled) AVHWFrameConstraints structure.</param>
    public static void av_hwframe_constraints_free(AVHWFramesConstraints** @constraints)
    {
        _av_hwframe_constraints_free_cache ??= FunctionResolver.GetFunctionDelegate<av_hwframe_constraints_free_delegate>("avutil", "av_hwframe_constraints_free", ThrowErrorIfFunctionNotFound);
        if (_av_hwframe_constraints_free_cache == null)
            throw new NotSupportedException();
        _av_hwframe_constraints_free_cache(@constraints);
    }
    
    /// <summary>Free an AVHWFrameConstraints structure.</summary>
    public static void av_hwframe_constraints_free(ref AVHWFramesConstraints* @constraints)
    {
        fixed (AVHWFramesConstraints** ptr = &@constraints)
        {
            av_hwframe_constraints_free(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVBufferRef* av_hwframe_ctx_alloc_delegate(AVBufferRef* @device_ctx);
    private static av_hwframe_ctx_alloc_delegate? _av_hwframe_ctx_alloc_cache;
    
    /// <summary>Allocate an AVHWFramesContext tied to a given device context.</summary>
    /// <param name="device_ctx">a reference to a AVHWDeviceContext. This function will make a new reference for internal use, the one passed to the function remains owned by the caller.</param>
    /// <returns>a reference to the newly created AVHWFramesContext on success or NULL on failure.</returns>
    public static AVBufferRef* av_hwframe_ctx_alloc(AVBufferRef* @device_ctx)
    {
        _av_hwframe_ctx_alloc_cache ??= FunctionResolver.GetFunctionDelegate<av_hwframe_ctx_alloc_delegate>("avutil", "av_hwframe_ctx_alloc", ThrowErrorIfFunctionNotFound);
        if (_av_hwframe_ctx_alloc_cache == null)
            throw new NotSupportedException();
        return _av_hwframe_ctx_alloc_cache(@device_ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_hwframe_ctx_create_derived_delegate(AVBufferRef** @derived_frame_ctx, AVPixelFormat @format, AVBufferRef* @derived_device_ctx, AVBufferRef* @source_frame_ctx, int @flags);
    private static av_hwframe_ctx_create_derived_delegate? _av_hwframe_ctx_create_derived_cache;
    
    /// <summary>Create and initialise an AVHWFramesContext as a mapping of another existing AVHWFramesContext on a different device.</summary>
    /// <param name="derived_frame_ctx">On success, a reference to the newly created AVHWFramesContext.</param>
    /// <param name="format">The AVPixelFormat for the derived context.</param>
    /// <param name="derived_device_ctx">A reference to the device to create the new AVHWFramesContext on.</param>
    /// <param name="source_frame_ctx">A reference to an existing AVHWFramesContext which will be mapped to the derived context.</param>
    /// <param name="flags">Some combination of AV_HWFRAME_MAP_* flags, defining the mapping parameters to apply to frames which are allocated in the derived device.</param>
    /// <returns>Zero on success, negative AVERROR code on failure.</returns>
    public static int av_hwframe_ctx_create_derived(AVBufferRef** @derived_frame_ctx, AVPixelFormat @format, AVBufferRef* @derived_device_ctx, AVBufferRef* @source_frame_ctx, int @flags)
    {
        _av_hwframe_ctx_create_derived_cache ??= FunctionResolver.GetFunctionDelegate<av_hwframe_ctx_create_derived_delegate>("avutil", "av_hwframe_ctx_create_derived", ThrowErrorIfFunctionNotFound);
        if (_av_hwframe_ctx_create_derived_cache == null)
            throw new NotSupportedException();
        return _av_hwframe_ctx_create_derived_cache(@derived_frame_ctx, @format, @derived_device_ctx, @source_frame_ctx, @flags);
    }
    
    /// <summary>Create and initialise an AVHWFramesContext as a mapping of another existing AVHWFramesContext on a different device.</summary>
    /// <param name="format">The AVPixelFormat for the derived context.</param>
    /// <param name="derived_device_ctx">A reference to the device to create the new AVHWFramesContext on.</param>
    /// <param name="source_frame_ctx">A reference to an existing AVHWFramesContext which will be mapped to the derived context.</param>
    /// <param name="flags">Some combination of AV_HWFRAME_MAP_* flags, defining the mapping parameters to apply to frames which are allocated in the derived device.</param>
    /// <returns>Zero on success, negative AVERROR code on failure.</returns>
    public static int av_hwframe_ctx_create_derived(ref AVBufferRef* @derived_frame_ctx, AVPixelFormat @format, AVBufferRef* @derived_device_ctx, AVBufferRef* @source_frame_ctx, int @flags)
    {
        fixed (AVBufferRef** ptr = &@derived_frame_ctx)
        {
            return av_hwframe_ctx_create_derived(ptr, @format, @derived_device_ctx, @source_frame_ctx, @flags);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_hwframe_ctx_init_delegate(AVBufferRef* @ref);
    private static av_hwframe_ctx_init_delegate? _av_hwframe_ctx_init_cache;
    
    /// <summary>Finalize the context before use. This function must be called after the context is filled with all the required information and before it is attached to any frames.</summary>
    /// <param name="ref">a reference to the AVHWFramesContext</param>
    /// <returns>0 on success, a negative AVERROR code on failure</returns>
    public static int av_hwframe_ctx_init(AVBufferRef* @ref)
    {
        _av_hwframe_ctx_init_cache ??= FunctionResolver.GetFunctionDelegate<av_hwframe_ctx_init_delegate>("avutil", "av_hwframe_ctx_init", ThrowErrorIfFunctionNotFound);
        if (_av_hwframe_ctx_init_cache == null)
            throw new NotSupportedException();
        return _av_hwframe_ctx_init_cache(@ref);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_hwframe_get_buffer_delegate(AVBufferRef* @hwframe_ctx, AVFrame* @frame, int @flags);
    private static av_hwframe_get_buffer_delegate? _av_hwframe_get_buffer_cache;
    
    /// <summary>Allocate a new frame attached to the given AVHWFramesContext.</summary>
    /// <param name="hwframe_ctx">a reference to an AVHWFramesContext</param>
    /// <param name="frame">an empty (freshly allocated or unreffed) frame to be filled with newly allocated buffers.</param>
    /// <param name="flags">currently unused, should be set to zero</param>
    /// <returns>0 on success, a negative AVERROR code on failure</returns>
    public static int av_hwframe_get_buffer(AVBufferRef* @hwframe_ctx, AVFrame* @frame, int @flags)
    {
        _av_hwframe_get_buffer_cache ??= FunctionResolver.GetFunctionDelegate<av_hwframe_get_buffer_delegate>("avutil", "av_hwframe_get_buffer", ThrowErrorIfFunctionNotFound);
        if (_av_hwframe_get_buffer_cache == null)
            throw new NotSupportedException();
        return _av_hwframe_get_buffer_cache(@hwframe_ctx, @frame, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_hwframe_map_delegate(AVFrame* @dst, AVFrame* @src, int @flags);
    private static av_hwframe_map_delegate? _av_hwframe_map_cache;
    
    /// <summary>Map a hardware frame.</summary>
    /// <param name="dst">Destination frame, to contain the mapping.</param>
    /// <param name="src">Source frame, to be mapped.</param>
    /// <param name="flags">Some combination of AV_HWFRAME_MAP_* flags.</param>
    /// <returns>Zero on success, negative AVERROR code on failure.</returns>
    public static int av_hwframe_map(AVFrame* @dst, AVFrame* @src, int @flags)
    {
        _av_hwframe_map_cache ??= FunctionResolver.GetFunctionDelegate<av_hwframe_map_delegate>("avutil", "av_hwframe_map", ThrowErrorIfFunctionNotFound);
        if (_av_hwframe_map_cache == null)
            throw new NotSupportedException();
        return _av_hwframe_map_cache(@dst, @src, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_hwframe_transfer_data_delegate(AVFrame* @dst, AVFrame* @src, int @flags);
    private static av_hwframe_transfer_data_delegate? _av_hwframe_transfer_data_cache;
    
    /// <summary>Copy data to or from a hw surface. At least one of dst/src must have an AVHWFramesContext attached.</summary>
    /// <param name="dst">the destination frame. dst is not touched on failure.</param>
    /// <param name="src">the source frame.</param>
    /// <param name="flags">currently unused, should be set to zero</param>
    /// <returns>0 on success, a negative AVERROR error code on failure.</returns>
    public static int av_hwframe_transfer_data(AVFrame* @dst, AVFrame* @src, int @flags)
    {
        _av_hwframe_transfer_data_cache ??= FunctionResolver.GetFunctionDelegate<av_hwframe_transfer_data_delegate>("avutil", "av_hwframe_transfer_data", ThrowErrorIfFunctionNotFound);
        if (_av_hwframe_transfer_data_cache == null)
            throw new NotSupportedException();
        return _av_hwframe_transfer_data_cache(@dst, @src, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_hwframe_transfer_get_formats_delegate(AVBufferRef* @hwframe_ctx, AVHWFrameTransferDirection @dir, AVPixelFormat** @formats, int @flags);
    private static av_hwframe_transfer_get_formats_delegate? _av_hwframe_transfer_get_formats_cache;
    
    /// <summary>Get a list of possible source or target formats usable in av_hwframe_transfer_data().</summary>
    /// <param name="hwframe_ctx">the frame context to obtain the information for</param>
    /// <param name="dir">the direction of the transfer</param>
    /// <param name="formats">the pointer to the output format list will be written here. The list is terminated with AV_PIX_FMT_NONE and must be freed by the caller when no longer needed using av_free(). If this function returns successfully, the format list will have at least one item (not counting the terminator). On failure, the contents of this pointer are unspecified.</param>
    /// <param name="flags">currently unused, should be set to zero</param>
    /// <returns>0 on success, a negative AVERROR code on failure.</returns>
    public static int av_hwframe_transfer_get_formats(AVBufferRef* @hwframe_ctx, AVHWFrameTransferDirection @dir, AVPixelFormat** @formats, int @flags)
    {
        _av_hwframe_transfer_get_formats_cache ??= FunctionResolver.GetFunctionDelegate<av_hwframe_transfer_get_formats_delegate>("avutil", "av_hwframe_transfer_get_formats", ThrowErrorIfFunctionNotFound);
        if (_av_hwframe_transfer_get_formats_cache == null)
            throw new NotSupportedException();
        return _av_hwframe_transfer_get_formats_cache(@hwframe_ctx, @dir, @formats, @flags);
    }
    
    /// <summary>Get a list of possible source or target formats usable in av_hwframe_transfer_data().</summary>
    /// <param name="hwframe_ctx">the frame context to obtain the information for</param>
    /// <param name="dir">the direction of the transfer</param>
    /// <param name="flags">currently unused, should be set to zero</param>
    /// <returns>0 on success, a negative AVERROR code on failure.</returns>
    public static int av_hwframe_transfer_get_formats(AVBufferRef* @hwframe_ctx, AVHWFrameTransferDirection @dir, ref AVPixelFormat* @formats, int @flags)
    {
        fixed (AVPixelFormat** ptr = &@formats)
        {
            return av_hwframe_transfer_get_formats(@hwframe_ctx, @dir, ptr, @flags);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_image_alloc_delegate(ref byte_ptrArray4 @pointers, ref int_array4 @linesizes, int @w, int @h, AVPixelFormat @pix_fmt, int @align);
    private static av_image_alloc_delegate? _av_image_alloc_cache;
    
    /// <summary>Allocate an image with size w and h and pixel format pix_fmt, and fill pointers and linesizes accordingly. The allocated image buffer has to be freed by using av_freep(&amp;pointers[0]).</summary>
    /// <param name="pointers">array to be filled with the pointer for each image plane</param>
    /// <param name="linesizes">the array filled with the linesize for each plane</param>
    /// <param name="w">width of the image in pixels</param>
    /// <param name="h">height of the image in pixels</param>
    /// <param name="pix_fmt">the AVPixelFormat of the image</param>
    /// <param name="align">the value to use for buffer size alignment</param>
    /// <returns>the size in bytes required for the image buffer, a negative error code in case of failure</returns>
    public static int av_image_alloc(ref byte_ptrArray4 @pointers, ref int_array4 @linesizes, int @w, int @h, AVPixelFormat @pix_fmt, int @align)
    {
        _av_image_alloc_cache ??= FunctionResolver.GetFunctionDelegate<av_image_alloc_delegate>("avutil", "av_image_alloc", ThrowErrorIfFunctionNotFound);
        if (_av_image_alloc_cache == null)
            throw new NotSupportedException();
        return _av_image_alloc_cache(ref @pointers, ref @linesizes, @w, @h, @pix_fmt, @align);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_image_check_sar_delegate(uint @w, uint @h, AVRational @sar);
    private static av_image_check_sar_delegate? _av_image_check_sar_cache;
    
    /// <summary>Check if the given sample aspect ratio of an image is valid.</summary>
    /// <param name="w">width of the image</param>
    /// <param name="h">height of the image</param>
    /// <param name="sar">sample aspect ratio of the image</param>
    /// <returns>0 if valid, a negative AVERROR code otherwise</returns>
    public static int av_image_check_sar(uint @w, uint @h, AVRational @sar)
    {
        _av_image_check_sar_cache ??= FunctionResolver.GetFunctionDelegate<av_image_check_sar_delegate>("avutil", "av_image_check_sar", ThrowErrorIfFunctionNotFound);
        if (_av_image_check_sar_cache == null)
            throw new NotSupportedException();
        return _av_image_check_sar_cache(@w, @h, @sar);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_image_check_size_delegate(uint @w, uint @h, int @log_offset, void* @log_ctx);
    private static av_image_check_size_delegate? _av_image_check_size_cache;
    
    /// <summary>Check if the given dimension of an image is valid, meaning that all bytes of the image can be addressed with a signed int.</summary>
    /// <param name="w">the width of the picture</param>
    /// <param name="h">the height of the picture</param>
    /// <param name="log_offset">the offset to sum to the log level for logging with log_ctx</param>
    /// <param name="log_ctx">the parent logging context, it may be NULL</param>
    /// <returns>&gt;= 0 if valid, a negative error code otherwise</returns>
    public static int av_image_check_size(uint @w, uint @h, int @log_offset, void* @log_ctx)
    {
        _av_image_check_size_cache ??= FunctionResolver.GetFunctionDelegate<av_image_check_size_delegate>("avutil", "av_image_check_size", ThrowErrorIfFunctionNotFound);
        if (_av_image_check_size_cache == null)
            throw new NotSupportedException();
        return _av_image_check_size_cache(@w, @h, @log_offset, @log_ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_image_check_size2_delegate(uint @w, uint @h, long @max_pixels, AVPixelFormat @pix_fmt, int @log_offset, void* @log_ctx);
    private static av_image_check_size2_delegate? _av_image_check_size2_cache;
    
    /// <summary>Check if the given dimension of an image is valid, meaning that all bytes of a plane of an image with the specified pix_fmt can be addressed with a signed int.</summary>
    /// <param name="w">the width of the picture</param>
    /// <param name="h">the height of the picture</param>
    /// <param name="max_pixels">the maximum number of pixels the user wants to accept</param>
    /// <param name="pix_fmt">the pixel format, can be AV_PIX_FMT_NONE if unknown.</param>
    /// <param name="log_offset">the offset to sum to the log level for logging with log_ctx</param>
    /// <param name="log_ctx">the parent logging context, it may be NULL</param>
    /// <returns>&gt;= 0 if valid, a negative error code otherwise</returns>
    public static int av_image_check_size2(uint @w, uint @h, long @max_pixels, AVPixelFormat @pix_fmt, int @log_offset, void* @log_ctx)
    {
        _av_image_check_size2_cache ??= FunctionResolver.GetFunctionDelegate<av_image_check_size2_delegate>("avutil", "av_image_check_size2", ThrowErrorIfFunctionNotFound);
        if (_av_image_check_size2_cache == null)
            throw new NotSupportedException();
        return _av_image_check_size2_cache(@w, @h, @max_pixels, @pix_fmt, @log_offset, @log_ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_image_copy_delegate(ref byte_ptrArray4 @dst_data, in int_array4 @dst_linesizes, in byte_ptrArray4 @src_data, in int_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height);
    private static av_image_copy_delegate? _av_image_copy_cache;
    
    /// <summary>Copy image in src_data to dst_data.</summary>
    /// <param name="dst_data">destination image data buffer to copy to</param>
    /// <param name="dst_linesizes">linesizes for the image in dst_data</param>
    /// <param name="src_data">source image data buffer to copy from</param>
    /// <param name="src_linesizes">linesizes for the image in src_data</param>
    /// <param name="pix_fmt">the AVPixelFormat of the image</param>
    /// <param name="width">width of the image in pixels</param>
    /// <param name="height">height of the image in pixels</param>
    public static void av_image_copy(ref byte_ptrArray4 @dst_data, in int_array4 @dst_linesizes, in byte_ptrArray4 @src_data, in int_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height)
    {
        _av_image_copy_cache ??= FunctionResolver.GetFunctionDelegate<av_image_copy_delegate>("avutil", "av_image_copy", ThrowErrorIfFunctionNotFound);
        if (_av_image_copy_cache == null)
            throw new NotSupportedException();
        _av_image_copy_cache(ref @dst_data, @dst_linesizes, @src_data, @src_linesizes, @pix_fmt, @width, @height);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_image_copy_plane_delegate(byte* @dst, int @dst_linesize, byte* @src, int @src_linesize, int @bytewidth, int @height);
    private static av_image_copy_plane_delegate? _av_image_copy_plane_cache;
    
    /// <summary>Copy image plane from src to dst. That is, copy &quot;height&quot; number of lines of &quot;bytewidth&quot; bytes each. The first byte of each successive line is separated by *_linesize bytes.</summary>
    /// <param name="dst">destination plane to copy to</param>
    /// <param name="dst_linesize">linesize for the image plane in dst</param>
    /// <param name="src">source plane to copy from</param>
    /// <param name="src_linesize">linesize for the image plane in src</param>
    /// <param name="height">height (number of lines) of the plane</param>
    public static void av_image_copy_plane(byte* @dst, int @dst_linesize, byte* @src, int @src_linesize, int @bytewidth, int @height)
    {
        _av_image_copy_plane_cache ??= FunctionResolver.GetFunctionDelegate<av_image_copy_plane_delegate>("avutil", "av_image_copy_plane", ThrowErrorIfFunctionNotFound);
        if (_av_image_copy_plane_cache == null)
            throw new NotSupportedException();
        _av_image_copy_plane_cache(@dst, @dst_linesize, @src, @src_linesize, @bytewidth, @height);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_image_copy_plane_uc_from_delegate(byte* @dst, long @dst_linesize, byte* @src, long @src_linesize, long @bytewidth, int @height);
    private static av_image_copy_plane_uc_from_delegate? _av_image_copy_plane_uc_from_cache;
    
    /// <summary>Copy image data located in uncacheable (e.g. GPU mapped) memory. Where available, this function will use special functionality for reading from such memory, which may result in greatly improved performance compared to plain av_image_copy_plane().</summary>
    public static void av_image_copy_plane_uc_from(byte* @dst, long @dst_linesize, byte* @src, long @src_linesize, long @bytewidth, int @height)
    {
        _av_image_copy_plane_uc_from_cache ??= FunctionResolver.GetFunctionDelegate<av_image_copy_plane_uc_from_delegate>("avutil", "av_image_copy_plane_uc_from", ThrowErrorIfFunctionNotFound);
        if (_av_image_copy_plane_uc_from_cache == null)
            throw new NotSupportedException();
        _av_image_copy_plane_uc_from_cache(@dst, @dst_linesize, @src, @src_linesize, @bytewidth, @height);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_image_copy_to_buffer_delegate(byte* @dst, int @dst_size, in byte_ptrArray4 @src_data, in int_array4 @src_linesize, AVPixelFormat @pix_fmt, int @width, int @height, int @align);
    private static av_image_copy_to_buffer_delegate? _av_image_copy_to_buffer_cache;
    
    /// <summary>Copy image data from an image into a buffer.</summary>
    /// <param name="dst">a buffer into which picture data will be copied</param>
    /// <param name="dst_size">the size in bytes of dst</param>
    /// <param name="src_data">pointers containing the source image data</param>
    /// <param name="src_linesize">linesizes for the image in src_data</param>
    /// <param name="pix_fmt">the pixel format of the source image</param>
    /// <param name="width">the width of the source image in pixels</param>
    /// <param name="height">the height of the source image in pixels</param>
    /// <param name="align">the assumed linesize alignment for dst</param>
    /// <returns>the number of bytes written to dst, or a negative value (error code) on error</returns>
    public static int av_image_copy_to_buffer(byte* @dst, int @dst_size, in byte_ptrArray4 @src_data, in int_array4 @src_linesize, AVPixelFormat @pix_fmt, int @width, int @height, int @align)
    {
        _av_image_copy_to_buffer_cache ??= FunctionResolver.GetFunctionDelegate<av_image_copy_to_buffer_delegate>("avutil", "av_image_copy_to_buffer", ThrowErrorIfFunctionNotFound);
        if (_av_image_copy_to_buffer_cache == null)
            throw new NotSupportedException();
        return _av_image_copy_to_buffer_cache(@dst, @dst_size, @src_data, @src_linesize, @pix_fmt, @width, @height, @align);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_image_copy_uc_from_delegate(ref byte_ptrArray4 @dst_data, in long_array4 @dst_linesizes, in byte_ptrArray4 @src_data, in long_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height);
    private static av_image_copy_uc_from_delegate? _av_image_copy_uc_from_cache;
    
    /// <summary>Copy image data located in uncacheable (e.g. GPU mapped) memory. Where available, this function will use special functionality for reading from such memory, which may result in greatly improved performance compared to plain av_image_copy().</summary>
    public static void av_image_copy_uc_from(ref byte_ptrArray4 @dst_data, in long_array4 @dst_linesizes, in byte_ptrArray4 @src_data, in long_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height)
    {
        _av_image_copy_uc_from_cache ??= FunctionResolver.GetFunctionDelegate<av_image_copy_uc_from_delegate>("avutil", "av_image_copy_uc_from", ThrowErrorIfFunctionNotFound);
        if (_av_image_copy_uc_from_cache == null)
            throw new NotSupportedException();
        _av_image_copy_uc_from_cache(ref @dst_data, @dst_linesizes, @src_data, @src_linesizes, @pix_fmt, @width, @height);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_image_fill_arrays_delegate(ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesize, byte* @src, AVPixelFormat @pix_fmt, int @width, int @height, int @align);
    private static av_image_fill_arrays_delegate? _av_image_fill_arrays_cache;
    
    /// <summary>Setup the data pointers and linesizes based on the specified image parameters and the provided array.</summary>
    /// <param name="dst_data">data pointers to be filled in</param>
    /// <param name="dst_linesize">linesizes for the image in dst_data to be filled in</param>
    /// <param name="src">buffer which will contain or contains the actual image data, can be NULL</param>
    /// <param name="pix_fmt">the pixel format of the image</param>
    /// <param name="width">the width of the image in pixels</param>
    /// <param name="height">the height of the image in pixels</param>
    /// <param name="align">the value used in src for linesize alignment</param>
    /// <returns>the size in bytes required for src, a negative error code in case of failure</returns>
    public static int av_image_fill_arrays(ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesize, byte* @src, AVPixelFormat @pix_fmt, int @width, int @height, int @align)
    {
        _av_image_fill_arrays_cache ??= FunctionResolver.GetFunctionDelegate<av_image_fill_arrays_delegate>("avutil", "av_image_fill_arrays", ThrowErrorIfFunctionNotFound);
        if (_av_image_fill_arrays_cache == null)
            throw new NotSupportedException();
        return _av_image_fill_arrays_cache(ref @dst_data, ref @dst_linesize, @src, @pix_fmt, @width, @height, @align);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_image_fill_black_delegate(ref byte_ptrArray4 @dst_data, in long_array4 @dst_linesize, AVPixelFormat @pix_fmt, AVColorRange @range, int @width, int @height);
    private static av_image_fill_black_delegate? _av_image_fill_black_cache;
    
    /// <summary>Overwrite the image data with black. This is suitable for filling a sub-rectangle of an image, meaning the padding between the right most pixel and the left most pixel on the next line will not be overwritten. For some formats, the image size might be rounded up due to inherent alignment.</summary>
    /// <param name="dst_data">data pointers to destination image</param>
    /// <param name="dst_linesize">linesizes for the destination image</param>
    /// <param name="pix_fmt">the pixel format of the image</param>
    /// <param name="range">the color range of the image (important for colorspaces such as YUV)</param>
    /// <param name="width">the width of the image in pixels</param>
    /// <param name="height">the height of the image in pixels</param>
    /// <returns>0 if the image data was cleared, a negative AVERROR code otherwise</returns>
    public static int av_image_fill_black(ref byte_ptrArray4 @dst_data, in long_array4 @dst_linesize, AVPixelFormat @pix_fmt, AVColorRange @range, int @width, int @height)
    {
        _av_image_fill_black_cache ??= FunctionResolver.GetFunctionDelegate<av_image_fill_black_delegate>("avutil", "av_image_fill_black", ThrowErrorIfFunctionNotFound);
        if (_av_image_fill_black_cache == null)
            throw new NotSupportedException();
        return _av_image_fill_black_cache(ref @dst_data, @dst_linesize, @pix_fmt, @range, @width, @height);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_image_fill_color_delegate(ref byte_ptrArray4 @dst_data, in long_array4 @dst_linesize, AVPixelFormat @pix_fmt, in uint_array4 @color, int @width, int @height, int @flags);
    private static av_image_fill_color_delegate? _av_image_fill_color_cache;
    
    /// <summary>Overwrite the image data with a color. This is suitable for filling a sub-rectangle of an image, meaning the padding between the right most pixel and the left most pixel on the next line will not be overwritten. For some formats, the image size might be rounded up due to inherent alignment.</summary>
    /// <param name="dst_data">data pointers to destination image</param>
    /// <param name="dst_linesize">linesizes for the destination image</param>
    /// <param name="pix_fmt">the pixel format of the image</param>
    /// <param name="color">the color components to be used for the fill</param>
    /// <param name="width">the width of the image in pixels</param>
    /// <param name="height">the height of the image in pixels</param>
    /// <param name="flags">currently unused</param>
    /// <returns>0 if the image data was filled, a negative AVERROR code otherwise</returns>
    public static int av_image_fill_color(ref byte_ptrArray4 @dst_data, in long_array4 @dst_linesize, AVPixelFormat @pix_fmt, in uint_array4 @color, int @width, int @height, int @flags)
    {
        _av_image_fill_color_cache ??= FunctionResolver.GetFunctionDelegate<av_image_fill_color_delegate>("avutil", "av_image_fill_color", ThrowErrorIfFunctionNotFound);
        if (_av_image_fill_color_cache == null)
            throw new NotSupportedException();
        return _av_image_fill_color_cache(ref @dst_data, @dst_linesize, @pix_fmt, @color, @width, @height, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_image_fill_linesizes_delegate(ref int_array4 @linesizes, AVPixelFormat @pix_fmt, int @width);
    private static av_image_fill_linesizes_delegate? _av_image_fill_linesizes_cache;
    
    /// <summary>Fill plane linesizes for an image with pixel format pix_fmt and width width.</summary>
    /// <param name="linesizes">array to be filled with the linesize for each plane</param>
    /// <param name="pix_fmt">the AVPixelFormat of the image</param>
    /// <param name="width">width of the image in pixels</param>
    /// <returns>&gt;= 0 in case of success, a negative error code otherwise</returns>
    public static int av_image_fill_linesizes(ref int_array4 @linesizes, AVPixelFormat @pix_fmt, int @width)
    {
        _av_image_fill_linesizes_cache ??= FunctionResolver.GetFunctionDelegate<av_image_fill_linesizes_delegate>("avutil", "av_image_fill_linesizes", ThrowErrorIfFunctionNotFound);
        if (_av_image_fill_linesizes_cache == null)
            throw new NotSupportedException();
        return _av_image_fill_linesizes_cache(ref @linesizes, @pix_fmt, @width);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_image_fill_max_pixsteps_delegate(ref int_array4 @max_pixsteps, ref int_array4 @max_pixstep_comps, AVPixFmtDescriptor* @pixdesc);
    private static av_image_fill_max_pixsteps_delegate? _av_image_fill_max_pixsteps_cache;
    
    /// <summary>Compute the max pixel step for each plane of an image with a format described by pixdesc.</summary>
    /// <param name="max_pixsteps">an array which is filled with the max pixel step for each plane. Since a plane may contain different pixel components, the computed max_pixsteps[plane] is relative to the component in the plane with the max pixel step.</param>
    /// <param name="max_pixstep_comps">an array which is filled with the component for each plane which has the max pixel step. May be NULL.</param>
    /// <param name="pixdesc">the AVPixFmtDescriptor for the image, describing its format</param>
    public static void av_image_fill_max_pixsteps(ref int_array4 @max_pixsteps, ref int_array4 @max_pixstep_comps, AVPixFmtDescriptor* @pixdesc)
    {
        _av_image_fill_max_pixsteps_cache ??= FunctionResolver.GetFunctionDelegate<av_image_fill_max_pixsteps_delegate>("avutil", "av_image_fill_max_pixsteps", ThrowErrorIfFunctionNotFound);
        if (_av_image_fill_max_pixsteps_cache == null)
            throw new NotSupportedException();
        _av_image_fill_max_pixsteps_cache(ref @max_pixsteps, ref @max_pixstep_comps, @pixdesc);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_image_fill_plane_sizes_delegate(ref ulong_array4 @size, AVPixelFormat @pix_fmt, int @height, in long_array4 @linesizes);
    private static av_image_fill_plane_sizes_delegate? _av_image_fill_plane_sizes_cache;
    
    /// <summary>Fill plane sizes for an image with pixel format pix_fmt and height height.</summary>
    /// <param name="size">the array to be filled with the size of each image plane</param>
    /// <param name="pix_fmt">the AVPixelFormat of the image</param>
    /// <param name="height">height of the image in pixels</param>
    /// <param name="linesizes">the array containing the linesize for each plane, should be filled by av_image_fill_linesizes()</param>
    /// <returns>&gt;= 0 in case of success, a negative error code otherwise</returns>
    public static int av_image_fill_plane_sizes(ref ulong_array4 @size, AVPixelFormat @pix_fmt, int @height, in long_array4 @linesizes)
    {
        _av_image_fill_plane_sizes_cache ??= FunctionResolver.GetFunctionDelegate<av_image_fill_plane_sizes_delegate>("avutil", "av_image_fill_plane_sizes", ThrowErrorIfFunctionNotFound);
        if (_av_image_fill_plane_sizes_cache == null)
            throw new NotSupportedException();
        return _av_image_fill_plane_sizes_cache(ref @size, @pix_fmt, @height, @linesizes);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_image_fill_pointers_delegate(ref byte_ptrArray4 @data, AVPixelFormat @pix_fmt, int @height, byte* @ptr, in int_array4 @linesizes);
    private static av_image_fill_pointers_delegate? _av_image_fill_pointers_cache;
    
    /// <summary>Fill plane data pointers for an image with pixel format pix_fmt and height height.</summary>
    /// <param name="data">pointers array to be filled with the pointer for each image plane</param>
    /// <param name="pix_fmt">the AVPixelFormat of the image</param>
    /// <param name="height">height of the image in pixels</param>
    /// <param name="ptr">the pointer to a buffer which will contain the image</param>
    /// <param name="linesizes">the array containing the linesize for each plane, should be filled by av_image_fill_linesizes()</param>
    /// <returns>the size in bytes required for the image buffer, a negative error code in case of failure</returns>
    public static int av_image_fill_pointers(ref byte_ptrArray4 @data, AVPixelFormat @pix_fmt, int @height, byte* @ptr, in int_array4 @linesizes)
    {
        _av_image_fill_pointers_cache ??= FunctionResolver.GetFunctionDelegate<av_image_fill_pointers_delegate>("avutil", "av_image_fill_pointers", ThrowErrorIfFunctionNotFound);
        if (_av_image_fill_pointers_cache == null)
            throw new NotSupportedException();
        return _av_image_fill_pointers_cache(ref @data, @pix_fmt, @height, @ptr, @linesizes);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_image_get_buffer_size_delegate(AVPixelFormat @pix_fmt, int @width, int @height, int @align);
    private static av_image_get_buffer_size_delegate? _av_image_get_buffer_size_cache;
    
    /// <summary>Return the size in bytes of the amount of data required to store an image with the given parameters.</summary>
    /// <param name="pix_fmt">the pixel format of the image</param>
    /// <param name="width">the width of the image in pixels</param>
    /// <param name="height">the height of the image in pixels</param>
    /// <param name="align">the assumed linesize alignment</param>
    /// <returns>the buffer size in bytes, a negative error code in case of failure</returns>
    public static int av_image_get_buffer_size(AVPixelFormat @pix_fmt, int @width, int @height, int @align)
    {
        _av_image_get_buffer_size_cache ??= FunctionResolver.GetFunctionDelegate<av_image_get_buffer_size_delegate>("avutil", "av_image_get_buffer_size", ThrowErrorIfFunctionNotFound);
        if (_av_image_get_buffer_size_cache == null)
            throw new NotSupportedException();
        return _av_image_get_buffer_size_cache(@pix_fmt, @width, @height, @align);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_image_get_linesize_delegate(AVPixelFormat @pix_fmt, int @width, int @plane);
    private static av_image_get_linesize_delegate? _av_image_get_linesize_cache;
    
    /// <summary>Compute the size of an image line with format pix_fmt and width width for the plane plane.</summary>
    /// <returns>the computed size in bytes</returns>
    public static int av_image_get_linesize(AVPixelFormat @pix_fmt, int @width, int @plane)
    {
        _av_image_get_linesize_cache ??= FunctionResolver.GetFunctionDelegate<av_image_get_linesize_delegate>("avutil", "av_image_get_linesize", ThrowErrorIfFunctionNotFound);
        if (_av_image_get_linesize_cache == null)
            throw new NotSupportedException();
        return _av_image_get_linesize_cache(@pix_fmt, @width, @plane);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_index_search_timestamp_delegate(AVStream* @st, long @timestamp, int @flags);
    private static av_index_search_timestamp_delegate? _av_index_search_timestamp_cache;
    
    /// <summary>Get the index for a specific timestamp.</summary>
    /// <param name="st">stream that the timestamp belongs to</param>
    /// <param name="timestamp">timestamp to retrieve the index for</param>
    /// <param name="flags">if AVSEEK_FLAG_BACKWARD then the returned index will correspond to the timestamp which is &lt; = the requested one, if backward is 0, then it will be &gt;= if AVSEEK_FLAG_ANY seek to any frame, only keyframes otherwise</param>
    /// <returns>&lt; 0 if no such timestamp could be found</returns>
    public static int av_index_search_timestamp(AVStream* @st, long @timestamp, int @flags)
    {
        _av_index_search_timestamp_cache ??= FunctionResolver.GetFunctionDelegate<av_index_search_timestamp_delegate>("avformat", "av_index_search_timestamp", ThrowErrorIfFunctionNotFound);
        if (_av_index_search_timestamp_cache == null)
            throw new NotSupportedException();
        return _av_index_search_timestamp_cache(@st, @timestamp, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_init_packet_delegate(AVPacket* @pkt);
    private static av_init_packet_delegate? _av_init_packet_cache;
    
    /// <summary>Initialize optional fields of a packet with default values.</summary>
    /// <param name="pkt">packet</param>
    [Obsolete("This function is deprecated. Once it's removed, sizeof(AVPacket) will not be a part of the ABI anymore.")]
    public static void av_init_packet(AVPacket* @pkt)
    {
        _av_init_packet_cache ??= FunctionResolver.GetFunctionDelegate<av_init_packet_delegate>("avcodec", "av_init_packet", ThrowErrorIfFunctionNotFound);
        if (_av_init_packet_cache == null)
            throw new NotSupportedException();
        _av_init_packet_cache(@pkt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVInputFormat* av_input_audio_device_next_delegate(AVInputFormat* @d);
    private static av_input_audio_device_next_delegate? _av_input_audio_device_next_cache;
    
    /// <summary>Audio input devices iterator.</summary>
    public static AVInputFormat* av_input_audio_device_next(AVInputFormat* @d)
    {
        _av_input_audio_device_next_cache ??= FunctionResolver.GetFunctionDelegate<av_input_audio_device_next_delegate>("avdevice", "av_input_audio_device_next", ThrowErrorIfFunctionNotFound);
        if (_av_input_audio_device_next_cache == null)
            throw new NotSupportedException();
        return _av_input_audio_device_next_cache(@d);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVInputFormat* av_input_video_device_next_delegate(AVInputFormat* @d);
    private static av_input_video_device_next_delegate? _av_input_video_device_next_cache;
    
    /// <summary>Video input devices iterator.</summary>
    public static AVInputFormat* av_input_video_device_next(AVInputFormat* @d)
    {
        _av_input_video_device_next_cache ??= FunctionResolver.GetFunctionDelegate<av_input_video_device_next_delegate>("avdevice", "av_input_video_device_next", ThrowErrorIfFunctionNotFound);
        if (_av_input_video_device_next_cache == null)
            throw new NotSupportedException();
        return _av_input_video_device_next_cache(@d);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint av_int_list_length_for_size_delegate(uint @elsize, void* @list, ulong @term);
    private static av_int_list_length_for_size_delegate? _av_int_list_length_for_size_cache;
    
    /// <summary>Compute the length of an integer list.</summary>
    /// <param name="elsize">size in bytes of each list element (only 1, 2, 4 or 8)</param>
    /// <param name="list">pointer to the list</param>
    /// <param name="term">list terminator (usually 0 or -1)</param>
    /// <returns>length of the list, in elements, not counting the terminator</returns>
    public static uint av_int_list_length_for_size(uint @elsize, void* @list, ulong @term)
    {
        _av_int_list_length_for_size_cache ??= FunctionResolver.GetFunctionDelegate<av_int_list_length_for_size_delegate>("avutil", "av_int_list_length_for_size", ThrowErrorIfFunctionNotFound);
        if (_av_int_list_length_for_size_cache == null)
            throw new NotSupportedException();
        return _av_int_list_length_for_size_cache(@elsize, @list, @term);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_interleaved_write_frame_delegate(AVFormatContext* @s, AVPacket* @pkt);
    private static av_interleaved_write_frame_delegate? _av_interleaved_write_frame_cache;
    
    /// <summary>Write a packet to an output media file ensuring correct interleaving.</summary>
    /// <param name="s">media file handle</param>
    /// <param name="pkt">The packet containing the data to be written. If the packet is reference-counted, this function will take ownership of this reference and unreference it later when it sees fit. If the packet is not reference-counted, libavformat will make a copy. The returned packet will be blank (as if returned from av_packet_alloc()), even on error. This parameter can be NULL (at any time, not just at the end), to flush the interleaving queues. Packet&apos;s &quot;stream_index&quot; field must be set to the index of the corresponding stream in &quot;s-&gt;streams&quot;. The timestamps ( &quot;pts&quot;, &quot;dts&quot;) must be set to correct values in the stream&apos;s timebase (unless the output format is flagged with the AVFMT_NOTIMESTAMPS flag, then they can be set to AV_NOPTS_VALUE). The dts for subsequent packets in one stream must be strictly increasing (unless the output format is flagged with the AVFMT_TS_NONSTRICT, then they merely have to be nondecreasing). &quot;duration&quot; should also be set if known.</param>
    /// <returns>0 on success, a negative AVERROR on error.</returns>
    public static int av_interleaved_write_frame(AVFormatContext* @s, AVPacket* @pkt)
    {
        _av_interleaved_write_frame_cache ??= FunctionResolver.GetFunctionDelegate<av_interleaved_write_frame_delegate>("avformat", "av_interleaved_write_frame", ThrowErrorIfFunctionNotFound);
        if (_av_interleaved_write_frame_cache == null)
            throw new NotSupportedException();
        return _av_interleaved_write_frame_cache(@s, @pkt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_interleaved_write_uncoded_frame_delegate(AVFormatContext* @s, int @stream_index, AVFrame* @frame);
    private static av_interleaved_write_uncoded_frame_delegate? _av_interleaved_write_uncoded_frame_cache;
    
    /// <summary>Write an uncoded frame to an output media file.</summary>
    /// <returns>&gt;=0 for success, a negative code on error</returns>
    public static int av_interleaved_write_uncoded_frame(AVFormatContext* @s, int @stream_index, AVFrame* @frame)
    {
        _av_interleaved_write_uncoded_frame_cache ??= FunctionResolver.GetFunctionDelegate<av_interleaved_write_uncoded_frame_delegate>("avformat", "av_interleaved_write_uncoded_frame", ThrowErrorIfFunctionNotFound);
        if (_av_interleaved_write_uncoded_frame_cache == null)
            throw new NotSupportedException();
        return _av_interleaved_write_uncoded_frame_cache(@s, @stream_index, @frame);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_log_delegate(void* @avcl, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt);
    private static av_log_delegate? _av_log_cache;
    
    /// <summary>Send the specified message to the log if the level is less than or equal to the current av_log_level. By default, all logging messages are sent to stderr. This behavior can be altered by setting a different logging callback function.</summary>
    /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct or NULL if general log.</param>
    /// <param name="level">The importance level of the message expressed using a &quot;Logging Constant&quot;.</param>
    /// <param name="fmt">The format string (printf-compatible) that specifies how subsequent arguments are converted to output.</param>
    public static void av_log(void* @avcl, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt)
    {
        _av_log_cache ??= FunctionResolver.GetFunctionDelegate<av_log_delegate>("avutil", "av_log", ThrowErrorIfFunctionNotFound);
        if (_av_log_cache == null)
            throw new NotSupportedException();
        _av_log_cache(@avcl, @level, @fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_log_default_callback_delegate(void* @avcl, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @vl);
    private static av_log_default_callback_delegate? _av_log_default_callback_cache;
    
    /// <summary>Default logging callback</summary>
    /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
    /// <param name="level">The importance level of the message expressed using a &quot;Logging Constant&quot;.</param>
    /// <param name="fmt">The format string (printf-compatible) that specifies how subsequent arguments are converted to output.</param>
    /// <param name="vl">The arguments referenced by the format string.</param>
    public static void av_log_default_callback(void* @avcl, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @vl)
    {
        _av_log_default_callback_cache ??= FunctionResolver.GetFunctionDelegate<av_log_default_callback_delegate>("avutil", "av_log_default_callback", ThrowErrorIfFunctionNotFound);
        if (_av_log_default_callback_cache == null)
            throw new NotSupportedException();
        _av_log_default_callback_cache(@avcl, @level, @fmt, @vl);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_log_format_line_delegate(void* @ptr, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix);
    private static av_log_format_line_delegate? _av_log_format_line_cache;
    
    /// <summary>Format a line of log the same way as the default callback.</summary>
    /// <param name="line">buffer to receive the formatted line</param>
    /// <param name="line_size">size of the buffer</param>
    /// <param name="print_prefix">used to store whether the prefix must be printed; must point to a persistent integer initially set to 1</param>
    public static void av_log_format_line(void* @ptr, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix)
    {
        _av_log_format_line_cache ??= FunctionResolver.GetFunctionDelegate<av_log_format_line_delegate>("avutil", "av_log_format_line", ThrowErrorIfFunctionNotFound);
        if (_av_log_format_line_cache == null)
            throw new NotSupportedException();
        _av_log_format_line_cache(@ptr, @level, @fmt, @vl, @line, @line_size, @print_prefix);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_log_format_line2_delegate(void* @ptr, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix);
    private static av_log_format_line2_delegate? _av_log_format_line2_cache;
    
    /// <summary>Format a line of log the same way as the default callback.</summary>
    /// <param name="line">buffer to receive the formatted line; may be NULL if line_size is 0</param>
    /// <param name="line_size">size of the buffer; at most line_size-1 characters will be written to the buffer, plus one null terminator</param>
    /// <param name="print_prefix">used to store whether the prefix must be printed; must point to a persistent integer initially set to 1</param>
    /// <returns>Returns a negative value if an error occurred, otherwise returns the number of characters that would have been written for a sufficiently large buffer, not including the terminating null character. If the return value is not less than line_size, it means that the log message was truncated to fit the buffer.</returns>
    public static int av_log_format_line2(void* @ptr, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix)
    {
        _av_log_format_line2_cache ??= FunctionResolver.GetFunctionDelegate<av_log_format_line2_delegate>("avutil", "av_log_format_line2", ThrowErrorIfFunctionNotFound);
        if (_av_log_format_line2_cache == null)
            throw new NotSupportedException();
        return _av_log_format_line2_cache(@ptr, @level, @fmt, @vl, @line, @line_size, @print_prefix);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_log_get_flags_delegate();
    private static av_log_get_flags_delegate? _av_log_get_flags_cache;
    
    public static int av_log_get_flags()
    {
        _av_log_get_flags_cache ??= FunctionResolver.GetFunctionDelegate<av_log_get_flags_delegate>("avutil", "av_log_get_flags", ThrowErrorIfFunctionNotFound);
        if (_av_log_get_flags_cache == null)
            throw new NotSupportedException();
        return _av_log_get_flags_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_log_get_level_delegate();
    private static av_log_get_level_delegate? _av_log_get_level_cache;
    
    /// <summary>Get the current log level</summary>
    /// <returns>Current log level</returns>
    public static int av_log_get_level()
    {
        _av_log_get_level_cache ??= FunctionResolver.GetFunctionDelegate<av_log_get_level_delegate>("avutil", "av_log_get_level", ThrowErrorIfFunctionNotFound);
        if (_av_log_get_level_cache == null)
            throw new NotSupportedException();
        return _av_log_get_level_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_log_once_delegate(void* @avcl, int @initial_level, int @subsequent_level, int* @state,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt);
    private static av_log_once_delegate? _av_log_once_cache;
    
    /// <summary>Send the specified message to the log once with the initial_level and then with the subsequent_level. By default, all logging messages are sent to stderr. This behavior can be altered by setting a different logging callback function.</summary>
    /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct or NULL if general log.</param>
    /// <param name="initial_level">importance level of the message expressed using a &quot;Logging Constant&quot; for the first occurance.</param>
    /// <param name="subsequent_level">importance level of the message expressed using a &quot;Logging Constant&quot; after the first occurance.</param>
    /// <param name="state">a variable to keep trak of if a message has already been printed this must be initialized to 0 before the first use. The same state must not be accessed by 2 Threads simultaneously.</param>
    /// <param name="fmt">The format string (printf-compatible) that specifies how subsequent arguments are converted to output.</param>
    public static void av_log_once(void* @avcl, int @initial_level, int @subsequent_level, int* @state,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt)
    {
        _av_log_once_cache ??= FunctionResolver.GetFunctionDelegate<av_log_once_delegate>("avutil", "av_log_once", ThrowErrorIfFunctionNotFound);
        if (_av_log_once_cache == null)
            throw new NotSupportedException();
        _av_log_once_cache(@avcl, @initial_level, @subsequent_level, @state, @fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_log_set_callback_delegate(av_log_set_callback_callback_func @callback);
    private static av_log_set_callback_delegate? _av_log_set_callback_cache;
    
    /// <summary>Set the logging callback</summary>
    /// <param name="callback">A logging function with a compatible signature.</param>
    public static void av_log_set_callback(av_log_set_callback_callback_func @callback)
    {
        _av_log_set_callback_cache ??= FunctionResolver.GetFunctionDelegate<av_log_set_callback_delegate>("avutil", "av_log_set_callback", ThrowErrorIfFunctionNotFound);
        if (_av_log_set_callback_cache == null)
            throw new NotSupportedException();
        _av_log_set_callback_cache(@callback);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_log_set_flags_delegate(int @arg);
    private static av_log_set_flags_delegate? _av_log_set_flags_cache;
    
    public static void av_log_set_flags(int @arg)
    {
        _av_log_set_flags_cache ??= FunctionResolver.GetFunctionDelegate<av_log_set_flags_delegate>("avutil", "av_log_set_flags", ThrowErrorIfFunctionNotFound);
        if (_av_log_set_flags_cache == null)
            throw new NotSupportedException();
        _av_log_set_flags_cache(@arg);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_log_set_formatted_callback_delegate(av_log_set_formatted_callback_p0_func @p0);
    private static av_log_set_formatted_callback_delegate? _av_log_set_formatted_callback_cache;
    
    public static void av_log_set_formatted_callback(av_log_set_formatted_callback_p0_func @p0)
    {
        _av_log_set_formatted_callback_cache ??= FunctionResolver.GetFunctionDelegate<av_log_set_formatted_callback_delegate>("avutil", "av_log_set_formatted_callback", ThrowErrorIfFunctionNotFound);
        if (_av_log_set_formatted_callback_cache == null)
            throw new NotSupportedException();
        _av_log_set_formatted_callback_cache(@p0);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_log_set_formatted_filtered_callback_delegate(av_log_set_formatted_filtered_callback_p0_func @p0);
    private static av_log_set_formatted_filtered_callback_delegate? _av_log_set_formatted_filtered_callback_cache;
    
    public static void av_log_set_formatted_filtered_callback(av_log_set_formatted_filtered_callback_p0_func @p0)
    {
        _av_log_set_formatted_filtered_callback_cache ??= FunctionResolver.GetFunctionDelegate<av_log_set_formatted_filtered_callback_delegate>("avutil", "av_log_set_formatted_filtered_callback", ThrowErrorIfFunctionNotFound);
        if (_av_log_set_formatted_filtered_callback_cache == null)
            throw new NotSupportedException();
        _av_log_set_formatted_filtered_callback_cache(@p0);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_log_set_level_delegate(int @level);
    private static av_log_set_level_delegate? _av_log_set_level_cache;
    
    /// <summary>Set the log level</summary>
    /// <param name="level">Logging level</param>
    public static void av_log_set_level(int @level)
    {
        _av_log_set_level_cache ??= FunctionResolver.GetFunctionDelegate<av_log_set_level_delegate>("avutil", "av_log_set_level", ThrowErrorIfFunctionNotFound);
        if (_av_log_set_level_cache == null)
            throw new NotSupportedException();
        _av_log_set_level_cache(@level);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_log2_delegate(uint @v);
    private static av_log2_delegate? _av_log2_cache;
    
    public static int av_log2(uint @v)
    {
        _av_log2_cache ??= FunctionResolver.GetFunctionDelegate<av_log2_delegate>("avutil", "av_log2", ThrowErrorIfFunctionNotFound);
        if (_av_log2_cache == null)
            throw new NotSupportedException();
        return _av_log2_cache(@v);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_log2_16bit_delegate(uint @v);
    private static av_log2_16bit_delegate? _av_log2_16bit_cache;
    
    public static int av_log2_16bit(uint @v)
    {
        _av_log2_16bit_cache ??= FunctionResolver.GetFunctionDelegate<av_log2_16bit_delegate>("avutil", "av_log2_16bit", ThrowErrorIfFunctionNotFound);
        if (_av_log2_16bit_cache == null)
            throw new NotSupportedException();
        return _av_log2_16bit_cache(@v);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* av_malloc_delegate(ulong @size);
    private static av_malloc_delegate? _av_malloc_cache;
    
    /// <summary>Allocate a memory block with alignment suitable for all memory accesses (including vectors if available on the CPU).</summary>
    /// <param name="size">Size in bytes for the memory block to be allocated</param>
    /// <returns>Pointer to the allocated block, or `NULL` if the block cannot be allocated</returns>
    public static void* av_malloc(ulong @size)
    {
        _av_malloc_cache ??= FunctionResolver.GetFunctionDelegate<av_malloc_delegate>("avutil", "av_malloc", ThrowErrorIfFunctionNotFound);
        if (_av_malloc_cache == null)
            throw new NotSupportedException();
        return _av_malloc_cache(@size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* av_malloc_array_delegate(ulong @nmemb, ulong @size);
    private static av_malloc_array_delegate? _av_malloc_array_cache;
    
    /// <summary>Allocate a memory block for an array with av_malloc().</summary>
    /// <param name="nmemb">Number of element</param>
    /// <param name="size">Size of a single element</param>
    /// <returns>Pointer to the allocated block, or `NULL` if the block cannot be allocated</returns>
    public static void* av_malloc_array(ulong @nmemb, ulong @size)
    {
        _av_malloc_array_cache ??= FunctionResolver.GetFunctionDelegate<av_malloc_array_delegate>("avutil", "av_malloc_array", ThrowErrorIfFunctionNotFound);
        if (_av_malloc_array_cache == null)
            throw new NotSupportedException();
        return _av_malloc_array_cache(@nmemb, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* av_mallocz_delegate(ulong @size);
    private static av_mallocz_delegate? _av_mallocz_cache;
    
    /// <summary>Allocate a memory block with alignment suitable for all memory accesses (including vectors if available on the CPU) and zero all the bytes of the block.</summary>
    /// <param name="size">Size in bytes for the memory block to be allocated</param>
    /// <returns>Pointer to the allocated block, or `NULL` if it cannot be allocated</returns>
    public static void* av_mallocz(ulong @size)
    {
        _av_mallocz_cache ??= FunctionResolver.GetFunctionDelegate<av_mallocz_delegate>("avutil", "av_mallocz", ThrowErrorIfFunctionNotFound);
        if (_av_mallocz_cache == null)
            throw new NotSupportedException();
        return _av_mallocz_cache(@size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVMasteringDisplayMetadata* av_mastering_display_metadata_alloc_delegate();
    private static av_mastering_display_metadata_alloc_delegate? _av_mastering_display_metadata_alloc_cache;
    
    /// <summary>Allocate an AVMasteringDisplayMetadata structure and set its fields to default values. The resulting struct can be freed using av_freep().</summary>
    /// <returns>An AVMasteringDisplayMetadata filled with default values or NULL on failure.</returns>
    public static AVMasteringDisplayMetadata* av_mastering_display_metadata_alloc()
    {
        _av_mastering_display_metadata_alloc_cache ??= FunctionResolver.GetFunctionDelegate<av_mastering_display_metadata_alloc_delegate>("avutil", "av_mastering_display_metadata_alloc", ThrowErrorIfFunctionNotFound);
        if (_av_mastering_display_metadata_alloc_cache == null)
            throw new NotSupportedException();
        return _av_mastering_display_metadata_alloc_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVMasteringDisplayMetadata* av_mastering_display_metadata_alloc_size_delegate(ulong* @size);
    private static av_mastering_display_metadata_alloc_size_delegate? _av_mastering_display_metadata_alloc_size_cache;
    
    /// <summary>Allocate an AVMasteringDisplayMetadata structure and set its fields to default values. The resulting struct can be freed using av_freep().</summary>
    /// <returns>An AVMasteringDisplayMetadata filled with default values or NULL on failure.</returns>
    public static AVMasteringDisplayMetadata* av_mastering_display_metadata_alloc_size(ulong* @size)
    {
        _av_mastering_display_metadata_alloc_size_cache ??= FunctionResolver.GetFunctionDelegate<av_mastering_display_metadata_alloc_size_delegate>("avutil", "av_mastering_display_metadata_alloc_size", ThrowErrorIfFunctionNotFound);
        if (_av_mastering_display_metadata_alloc_size_cache == null)
            throw new NotSupportedException();
        return _av_mastering_display_metadata_alloc_size_cache(@size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVMasteringDisplayMetadata* av_mastering_display_metadata_create_side_data_delegate(AVFrame* @frame);
    private static av_mastering_display_metadata_create_side_data_delegate? _av_mastering_display_metadata_create_side_data_cache;
    
    /// <summary>Allocate a complete AVMasteringDisplayMetadata and add it to the frame.</summary>
    /// <param name="frame">The frame which side data is added to.</param>
    /// <returns>The AVMasteringDisplayMetadata structure to be filled by caller.</returns>
    public static AVMasteringDisplayMetadata* av_mastering_display_metadata_create_side_data(AVFrame* @frame)
    {
        _av_mastering_display_metadata_create_side_data_cache ??= FunctionResolver.GetFunctionDelegate<av_mastering_display_metadata_create_side_data_delegate>("avutil", "av_mastering_display_metadata_create_side_data", ThrowErrorIfFunctionNotFound);
        if (_av_mastering_display_metadata_create_side_data_cache == null)
            throw new NotSupportedException();
        return _av_mastering_display_metadata_create_side_data_cache(@frame);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_match_ext_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @extensions);
    private static av_match_ext_delegate? _av_match_ext_cache;
    
    /// <summary>Return a positive value if the given filename has one of the given extensions, 0 otherwise.</summary>
    /// <param name="filename">file name to check against the given extensions</param>
    /// <param name="extensions">a comma-separated list of filename extensions</param>
    public static int av_match_ext(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @extensions)
    {
        _av_match_ext_cache ??= FunctionResolver.GetFunctionDelegate<av_match_ext_delegate>("avformat", "av_match_ext", ThrowErrorIfFunctionNotFound);
        if (_av_match_ext_cache == null)
            throw new NotSupportedException();
        return _av_match_ext_cache(@filename, @extensions);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_max_alloc_delegate(ulong @max);
    private static av_max_alloc_delegate? _av_max_alloc_cache;
    
    /// <summary>Set the maximum size that may be allocated in one block.</summary>
    /// <param name="max">Value to be set as the new maximum size</param>
    public static void av_max_alloc(ulong @max)
    {
        _av_max_alloc_cache ??= FunctionResolver.GetFunctionDelegate<av_max_alloc_delegate>("avutil", "av_max_alloc", ThrowErrorIfFunctionNotFound);
        if (_av_max_alloc_cache == null)
            throw new NotSupportedException();
        _av_max_alloc_cache(@max);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_memcpy_backptr_delegate(byte* @dst, int @back, int @cnt);
    private static av_memcpy_backptr_delegate? _av_memcpy_backptr_cache;
    
    /// <summary>Overlapping memcpy() implementation.</summary>
    /// <param name="dst">Destination buffer</param>
    /// <param name="back">Number of bytes back to start copying (i.e. the initial size of the overlapping window); must be &gt; 0</param>
    /// <param name="cnt">Number of bytes to copy; must be &gt;= 0</param>
    public static void av_memcpy_backptr(byte* @dst, int @back, int @cnt)
    {
        _av_memcpy_backptr_cache ??= FunctionResolver.GetFunctionDelegate<av_memcpy_backptr_delegate>("avutil", "av_memcpy_backptr", ThrowErrorIfFunctionNotFound);
        if (_av_memcpy_backptr_cache == null)
            throw new NotSupportedException();
        _av_memcpy_backptr_cache(@dst, @back, @cnt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* av_memdup_delegate(void* @p, ulong @size);
    private static av_memdup_delegate? _av_memdup_cache;
    
    /// <summary>Duplicate a buffer with av_malloc().</summary>
    /// <param name="p">Buffer to be duplicated</param>
    /// <param name="size">Size in bytes of the buffer copied</param>
    /// <returns>Pointer to a newly allocated buffer containing a copy of `p` or `NULL` if the buffer cannot be allocated</returns>
    public static void* av_memdup(void* @p, ulong @size)
    {
        _av_memdup_cache ??= FunctionResolver.GetFunctionDelegate<av_memdup_delegate>("avutil", "av_memdup", ThrowErrorIfFunctionNotFound);
        if (_av_memdup_cache == null)
            throw new NotSupportedException();
        return _av_memdup_cache(@p, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVRational av_mul_q_delegate(AVRational @b, AVRational @c);
    private static av_mul_q_delegate? _av_mul_q_cache;
    
    /// <summary>Multiply two rationals.</summary>
    /// <param name="b">First rational</param>
    /// <param name="c">Second rational</param>
    /// <returns>b*c</returns>
    public static AVRational av_mul_q(AVRational @b, AVRational @c)
    {
        _av_mul_q_cache ??= FunctionResolver.GetFunctionDelegate<av_mul_q_delegate>("avutil", "av_mul_q", ThrowErrorIfFunctionNotFound);
        if (_av_mul_q_cache == null)
            throw new NotSupportedException();
        return _av_mul_q_cache(@b, @c);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVOutputFormat* av_muxer_iterate_delegate(void** @opaque);
    private static av_muxer_iterate_delegate? _av_muxer_iterate_cache;
    
    /// <summary>Iterate over all registered muxers.</summary>
    /// <param name="opaque">a pointer where libavformat will store the iteration state. Must point to NULL to start the iteration.</param>
    /// <returns>the next registered muxer or NULL when the iteration is finished</returns>
    public static AVOutputFormat* av_muxer_iterate(void** @opaque)
    {
        _av_muxer_iterate_cache ??= FunctionResolver.GetFunctionDelegate<av_muxer_iterate_delegate>("avformat", "av_muxer_iterate", ThrowErrorIfFunctionNotFound);
        if (_av_muxer_iterate_cache == null)
            throw new NotSupportedException();
        return _av_muxer_iterate_cache(@opaque);
    }
    
    /// <summary>Iterate over all registered muxers.</summary>
    /// <returns>the next registered muxer or NULL when the iteration is finished</returns>
    public static AVOutputFormat* av_muxer_iterate(ref void* @opaque)
    {
        fixed (void** ptr = &@opaque)
        {
            return av_muxer_iterate(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_nearer_q_delegate(AVRational @q, AVRational @q1, AVRational @q2);
    private static av_nearer_q_delegate? _av_nearer_q_cache;
    
    /// <summary>Find which of the two rationals is closer to another rational.</summary>
    /// <param name="q">Rational to be compared against</param>
    /// <param name="q1">Rational to be tested</param>
    /// <param name="q2">Rational to be tested</param>
    /// <returns>One of the following values: - 1 if `q1` is nearer to `q` than `q2` - -1 if `q2` is nearer to `q` than `q1` - 0 if they have the same distance</returns>
    public static int av_nearer_q(AVRational @q, AVRational @q1, AVRational @q2)
    {
        _av_nearer_q_cache ??= FunctionResolver.GetFunctionDelegate<av_nearer_q_delegate>("avutil", "av_nearer_q", ThrowErrorIfFunctionNotFound);
        if (_av_nearer_q_cache == null)
            throw new NotSupportedException();
        return _av_nearer_q_cache(@q, @q1, @q2);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_new_packet_delegate(AVPacket* @pkt, int @size);
    private static av_new_packet_delegate? _av_new_packet_cache;
    
    /// <summary>Allocate the payload of a packet and initialize its fields with default values.</summary>
    /// <param name="pkt">packet</param>
    /// <param name="size">wanted payload size</param>
    /// <returns>0 if OK, AVERROR_xxx otherwise</returns>
    public static int av_new_packet(AVPacket* @pkt, int @size)
    {
        _av_new_packet_cache ??= FunctionResolver.GetFunctionDelegate<av_new_packet_delegate>("avcodec", "av_new_packet", ThrowErrorIfFunctionNotFound);
        if (_av_new_packet_cache == null)
            throw new NotSupportedException();
        return _av_new_packet_cache(@pkt, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVProgram* av_new_program_delegate(AVFormatContext* @s, int @id);
    private static av_new_program_delegate? _av_new_program_cache;
    
    public static AVProgram* av_new_program(AVFormatContext* @s, int @id)
    {
        _av_new_program_cache ??= FunctionResolver.GetFunctionDelegate<av_new_program_delegate>("avformat", "av_new_program", ThrowErrorIfFunctionNotFound);
        if (_av_new_program_cache == null)
            throw new NotSupportedException();
        return _av_new_program_cache(@s, @id);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVClass* av_opt_child_class_iterate_delegate(AVClass* @parent, void** @iter);
    private static av_opt_child_class_iterate_delegate? _av_opt_child_class_iterate_cache;
    
    /// <summary>Iterate over potential AVOptions-enabled children of parent.</summary>
    /// <param name="iter">a pointer where iteration state is stored.</param>
    /// <returns>AVClass corresponding to next potential child or NULL</returns>
    public static AVClass* av_opt_child_class_iterate(AVClass* @parent, void** @iter)
    {
        _av_opt_child_class_iterate_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_child_class_iterate_delegate>("avutil", "av_opt_child_class_iterate", ThrowErrorIfFunctionNotFound);
        if (_av_opt_child_class_iterate_cache == null)
            throw new NotSupportedException();
        return _av_opt_child_class_iterate_cache(@parent, @iter);
    }
    
    /// <summary>Iterate over potential AVOptions-enabled children of parent.</summary>
    /// <returns>AVClass corresponding to next potential child or NULL</returns>
    public static AVClass* av_opt_child_class_iterate(AVClass* @parent, ref void* @iter)
    {
        fixed (void** ptr = &@iter)
        {
            return av_opt_child_class_iterate(@parent, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* av_opt_child_next_delegate(void* @obj, void* @prev);
    private static av_opt_child_next_delegate? _av_opt_child_next_cache;
    
    /// <summary>Iterate over AVOptions-enabled children of obj.</summary>
    /// <param name="prev">result of a previous call to this function or NULL</param>
    /// <returns>next AVOptions-enabled child or NULL</returns>
    public static void* av_opt_child_next(void* @obj, void* @prev)
    {
        _av_opt_child_next_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_child_next_delegate>("avutil", "av_opt_child_next", ThrowErrorIfFunctionNotFound);
        if (_av_opt_child_next_cache == null)
            throw new NotSupportedException();
        return _av_opt_child_next_cache(@obj, @prev);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_copy_delegate(void* @dest, void* @src);
    private static av_opt_copy_delegate? _av_opt_copy_cache;
    
    /// <summary>Copy options from src object into dest object.</summary>
    /// <param name="dest">Object to copy from</param>
    /// <param name="src">Object to copy into</param>
    /// <returns>0 on success, negative on error</returns>
    public static int av_opt_copy(void* @dest, void* @src)
    {
        _av_opt_copy_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_copy_delegate>("avutil", "av_opt_copy", ThrowErrorIfFunctionNotFound);
        if (_av_opt_copy_cache == null)
            throw new NotSupportedException();
        return _av_opt_copy_cache(@dest, @src);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_eval_double_delegate(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, double* @double_out);
    private static av_opt_eval_double_delegate? _av_opt_eval_double_cache;
    
    public static int av_opt_eval_double(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, double* @double_out)
    {
        _av_opt_eval_double_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_eval_double_delegate>("avutil", "av_opt_eval_double", ThrowErrorIfFunctionNotFound);
        if (_av_opt_eval_double_cache == null)
            throw new NotSupportedException();
        return _av_opt_eval_double_cache(@obj, @o, @val, @double_out);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_eval_flags_delegate(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, int* @flags_out);
    private static av_opt_eval_flags_delegate? _av_opt_eval_flags_cache;
    
    /// <summary>@{ This group of functions can be used to evaluate option strings and get numbers out of them. They do the same thing as av_opt_set(), except the result is written into the caller-supplied pointer.</summary>
    /// <param name="obj">a struct whose first element is a pointer to AVClass.</param>
    /// <param name="o">an option for which the string is to be evaluated.</param>
    /// <param name="val">string to be evaluated.</param>
    /// <returns>0 on success, a negative number on failure.</returns>
    public static int av_opt_eval_flags(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, int* @flags_out)
    {
        _av_opt_eval_flags_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_eval_flags_delegate>("avutil", "av_opt_eval_flags", ThrowErrorIfFunctionNotFound);
        if (_av_opt_eval_flags_cache == null)
            throw new NotSupportedException();
        return _av_opt_eval_flags_cache(@obj, @o, @val, @flags_out);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_eval_float_delegate(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, float* @float_out);
    private static av_opt_eval_float_delegate? _av_opt_eval_float_cache;
    
    public static int av_opt_eval_float(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, float* @float_out)
    {
        _av_opt_eval_float_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_eval_float_delegate>("avutil", "av_opt_eval_float", ThrowErrorIfFunctionNotFound);
        if (_av_opt_eval_float_cache == null)
            throw new NotSupportedException();
        return _av_opt_eval_float_cache(@obj, @o, @val, @float_out);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_eval_int_delegate(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, int* @int_out);
    private static av_opt_eval_int_delegate? _av_opt_eval_int_cache;
    
    public static int av_opt_eval_int(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, int* @int_out)
    {
        _av_opt_eval_int_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_eval_int_delegate>("avutil", "av_opt_eval_int", ThrowErrorIfFunctionNotFound);
        if (_av_opt_eval_int_cache == null)
            throw new NotSupportedException();
        return _av_opt_eval_int_cache(@obj, @o, @val, @int_out);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_eval_int64_delegate(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, long* @int64_out);
    private static av_opt_eval_int64_delegate? _av_opt_eval_int64_cache;
    
    public static int av_opt_eval_int64(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, long* @int64_out)
    {
        _av_opt_eval_int64_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_eval_int64_delegate>("avutil", "av_opt_eval_int64", ThrowErrorIfFunctionNotFound);
        if (_av_opt_eval_int64_cache == null)
            throw new NotSupportedException();
        return _av_opt_eval_int64_cache(@obj, @o, @val, @int64_out);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_eval_q_delegate(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, AVRational* @q_out);
    private static av_opt_eval_q_delegate? _av_opt_eval_q_cache;
    
    public static int av_opt_eval_q(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, AVRational* @q_out)
    {
        _av_opt_eval_q_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_eval_q_delegate>("avutil", "av_opt_eval_q", ThrowErrorIfFunctionNotFound);
        if (_av_opt_eval_q_cache == null)
            throw new NotSupportedException();
        return _av_opt_eval_q_cache(@obj, @o, @val, @q_out);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_eval_uint_delegate(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, uint* @uint_out);
    private static av_opt_eval_uint_delegate? _av_opt_eval_uint_cache;
    
    public static int av_opt_eval_uint(void* @obj, AVOption* @o,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, uint* @uint_out)
    {
        _av_opt_eval_uint_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_eval_uint_delegate>("avutil", "av_opt_eval_uint", ThrowErrorIfFunctionNotFound);
        if (_av_opt_eval_uint_cache == null)
            throw new NotSupportedException();
        return _av_opt_eval_uint_cache(@obj, @o, @val, @uint_out);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVOption* av_opt_find_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @unit, int @opt_flags, int @search_flags);
    private static av_opt_find_delegate? _av_opt_find_cache;
    
    /// <summary>Look for an option in an object. Consider only options which have all the specified flags set.</summary>
    /// <param name="obj">A pointer to a struct whose first element is a pointer to an AVClass. Alternatively a double pointer to an AVClass, if AV_OPT_SEARCH_FAKE_OBJ search flag is set.</param>
    /// <param name="name">The name of the option to look for.</param>
    /// <param name="unit">When searching for named constants, name of the unit it belongs to.</param>
    /// <param name="opt_flags">Find only options with all the specified flags set (AV_OPT_FLAG).</param>
    /// <param name="search_flags">A combination of AV_OPT_SEARCH_*.</param>
    /// <returns>A pointer to the option found, or NULL if no option was found.</returns>
    public static AVOption* av_opt_find(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @unit, int @opt_flags, int @search_flags)
    {
        _av_opt_find_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_find_delegate>("avutil", "av_opt_find", ThrowErrorIfFunctionNotFound);
        if (_av_opt_find_cache == null)
            throw new NotSupportedException();
        return _av_opt_find_cache(@obj, @name, @unit, @opt_flags, @search_flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVOption* av_opt_find2_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @unit, int @opt_flags, int @search_flags, void** @target_obj);
    private static av_opt_find2_delegate? _av_opt_find2_cache;
    
    /// <summary>Look for an option in an object. Consider only options which have all the specified flags set.</summary>
    /// <param name="obj">A pointer to a struct whose first element is a pointer to an AVClass. Alternatively a double pointer to an AVClass, if AV_OPT_SEARCH_FAKE_OBJ search flag is set.</param>
    /// <param name="name">The name of the option to look for.</param>
    /// <param name="unit">When searching for named constants, name of the unit it belongs to.</param>
    /// <param name="opt_flags">Find only options with all the specified flags set (AV_OPT_FLAG).</param>
    /// <param name="search_flags">A combination of AV_OPT_SEARCH_*.</param>
    /// <param name="target_obj">if non-NULL, an object to which the option belongs will be written here. It may be different from obj if AV_OPT_SEARCH_CHILDREN is present in search_flags. This parameter is ignored if search_flags contain AV_OPT_SEARCH_FAKE_OBJ.</param>
    /// <returns>A pointer to the option found, or NULL if no option was found.</returns>
    public static AVOption* av_opt_find2(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @unit, int @opt_flags, int @search_flags, void** @target_obj)
    {
        _av_opt_find2_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_find2_delegate>("avutil", "av_opt_find2", ThrowErrorIfFunctionNotFound);
        if (_av_opt_find2_cache == null)
            throw new NotSupportedException();
        return _av_opt_find2_cache(@obj, @name, @unit, @opt_flags, @search_flags, @target_obj);
    }
    
    /// <summary>Look for an option in an object. Consider only options which have all the specified flags set.</summary>
    /// <param name="obj">A pointer to a struct whose first element is a pointer to an AVClass. Alternatively a double pointer to an AVClass, if AV_OPT_SEARCH_FAKE_OBJ search flag is set.</param>
    /// <param name="name">The name of the option to look for.</param>
    /// <param name="unit">When searching for named constants, name of the unit it belongs to.</param>
    /// <param name="opt_flags">Find only options with all the specified flags set (AV_OPT_FLAG).</param>
    /// <param name="search_flags">A combination of AV_OPT_SEARCH_*.</param>
    /// <returns>A pointer to the option found, or NULL if no option was found.</returns>
    public static AVOption* av_opt_find2(void* @obj, string @name, string @unit, int @opt_flags, int @search_flags, ref void* @target_obj)
    {
        fixed (void** ptr = &@target_obj)
        {
            return av_opt_find2(@obj, @name, @unit, @opt_flags, @search_flags, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_flag_is_set_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @field_name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @flag_name);
    private static av_opt_flag_is_set_delegate? _av_opt_flag_is_set_cache;
    
    /// <summary>Check whether a particular flag is set in a flags field.</summary>
    /// <param name="field_name">the name of the flag field option</param>
    /// <param name="flag_name">the name of the flag to check</param>
    /// <returns>non-zero if the flag is set, zero if the flag isn&apos;t set, isn&apos;t of the right type, or the flags field doesn&apos;t exist.</returns>
    public static int av_opt_flag_is_set(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @field_name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @flag_name)
    {
        _av_opt_flag_is_set_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_flag_is_set_delegate>("avutil", "av_opt_flag_is_set", ThrowErrorIfFunctionNotFound);
        if (_av_opt_flag_is_set_cache == null)
            throw new NotSupportedException();
        return _av_opt_flag_is_set_cache(@obj, @field_name, @flag_name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_opt_free_delegate(void* @obj);
    private static av_opt_free_delegate? _av_opt_free_cache;
    
    /// <summary>Free all allocated objects in obj.</summary>
    public static void av_opt_free(void* @obj)
    {
        _av_opt_free_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_free_delegate>("avutil", "av_opt_free", ThrowErrorIfFunctionNotFound);
        if (_av_opt_free_cache == null)
            throw new NotSupportedException();
        _av_opt_free_cache(@obj);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_opt_freep_ranges_delegate(AVOptionRanges** @ranges);
    private static av_opt_freep_ranges_delegate? _av_opt_freep_ranges_cache;
    
    /// <summary>Free an AVOptionRanges struct and set it to NULL.</summary>
    public static void av_opt_freep_ranges(AVOptionRanges** @ranges)
    {
        _av_opt_freep_ranges_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_freep_ranges_delegate>("avutil", "av_opt_freep_ranges", ThrowErrorIfFunctionNotFound);
        if (_av_opt_freep_ranges_cache == null)
            throw new NotSupportedException();
        _av_opt_freep_ranges_cache(@ranges);
    }
    
    /// <summary>Free an AVOptionRanges struct and set it to NULL.</summary>
    public static void av_opt_freep_ranges(ref AVOptionRanges* @ranges)
    {
        fixed (AVOptionRanges** ptr = &@ranges)
        {
            av_opt_freep_ranges(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_get_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, byte** @out_val);
    private static av_opt_get_delegate? _av_opt_get_cache;
    
    /// <summary>@{ Those functions get a value of the option with the given name from an object.</summary>
    /// <param name="obj">a struct whose first element is a pointer to an AVClass.</param>
    /// <param name="name">name of the option to get.</param>
    /// <param name="search_flags">flags passed to av_opt_find2. I.e. if AV_OPT_SEARCH_CHILDREN is passed here, then the option may be found in a child of obj.</param>
    /// <param name="out_val">value of the option will be written here</param>
    /// <returns>&gt;=0 on success, a negative error code otherwise</returns>
    public static int av_opt_get(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, byte** @out_val)
    {
        _av_opt_get_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_get_delegate>("avutil", "av_opt_get", ThrowErrorIfFunctionNotFound);
        if (_av_opt_get_cache == null)
            throw new NotSupportedException();
        return _av_opt_get_cache(@obj, @name, @search_flags, @out_val);
    }
    
    /// <summary>@{ Those functions get a value of the option with the given name from an object.</summary>
    /// <param name="obj">a struct whose first element is a pointer to an AVClass.</param>
    /// <param name="name">name of the option to get.</param>
    /// <param name="search_flags">flags passed to av_opt_find2. I.e. if AV_OPT_SEARCH_CHILDREN is passed here, then the option may be found in a child of obj.</param>
    /// <returns>&gt;=0 on success, a negative error code otherwise</returns>
    public static int av_opt_get(void* @obj, string @name, int @search_flags, ref byte* @out_val)
    {
        fixed (byte** ptr = &@out_val)
        {
            return av_opt_get(@obj, @name, @search_flags, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_get_array_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, uint @start_elem, uint @nb_elems, AVOptionType @out_type, void* @out_val);
    private static av_opt_get_array_delegate? _av_opt_get_array_cache;
    
    /// <summary>For an array-type option, retrieve the values of one or more array elements.</summary>
    /// <param name="start_elem">index of the first array element to retrieve</param>
    /// <param name="nb_elems">number of array elements to retrieve; start_elem+nb_elems must not be larger than array size as returned by av_opt_get_array_size()</param>
    /// <param name="out_type">Option type corresponding to the desired output.</param>
    /// <param name="out_val">Array with nb_elems members into which the output will be written. The array type must match the underlying C type as documented for out_type, and be zeroed on entry to this function.</param>
    public static int av_opt_get_array(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, uint @start_elem, uint @nb_elems, AVOptionType @out_type, void* @out_val)
    {
        _av_opt_get_array_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_get_array_delegate>("avutil", "av_opt_get_array", ThrowErrorIfFunctionNotFound);
        if (_av_opt_get_array_cache == null)
            throw new NotSupportedException();
        return _av_opt_get_array_cache(@obj, @name, @search_flags, @start_elem, @nb_elems, @out_type, @out_val);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_get_array_size_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, uint* @out_val);
    private static av_opt_get_array_size_delegate? _av_opt_get_array_size_cache;
    
    /// <summary>For an array-type option, get the number of elements in the array.</summary>
    public static int av_opt_get_array_size(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, uint* @out_val)
    {
        _av_opt_get_array_size_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_get_array_size_delegate>("avutil", "av_opt_get_array_size", ThrowErrorIfFunctionNotFound);
        if (_av_opt_get_array_size_cache == null)
            throw new NotSupportedException();
        return _av_opt_get_array_size_cache(@obj, @name, @search_flags, @out_val);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_get_chlayout_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVChannelLayout* @layout);
    private static av_opt_get_chlayout_delegate? _av_opt_get_chlayout_cache;
    
    /// <param name="layout">The returned layout is a copy of the actual value and must be freed with av_channel_layout_uninit() by the caller</param>
    public static int av_opt_get_chlayout(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVChannelLayout* @layout)
    {
        _av_opt_get_chlayout_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_get_chlayout_delegate>("avutil", "av_opt_get_chlayout", ThrowErrorIfFunctionNotFound);
        if (_av_opt_get_chlayout_cache == null)
            throw new NotSupportedException();
        return _av_opt_get_chlayout_cache(@obj, @name, @search_flags, @layout);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_get_dict_val_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVDictionary** @out_val);
    private static av_opt_get_dict_val_delegate? _av_opt_get_dict_val_cache;
    
    /// <param name="out_val">The returned dictionary is a copy of the actual value and must be freed with av_dict_free() by the caller</param>
    public static int av_opt_get_dict_val(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVDictionary** @out_val)
    {
        _av_opt_get_dict_val_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_get_dict_val_delegate>("avutil", "av_opt_get_dict_val", ThrowErrorIfFunctionNotFound);
        if (_av_opt_get_dict_val_cache == null)
            throw new NotSupportedException();
        return _av_opt_get_dict_val_cache(@obj, @name, @search_flags, @out_val);
    }
    
    public static int av_opt_get_dict_val(void* @obj, string @name, int @search_flags, ref AVDictionary* @out_val)
    {
        fixed (AVDictionary** ptr = &@out_val)
        {
            return av_opt_get_dict_val(@obj, @name, @search_flags, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_get_double_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, double* @out_val);
    private static av_opt_get_double_delegate? _av_opt_get_double_cache;
    
    public static int av_opt_get_double(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, double* @out_val)
    {
        _av_opt_get_double_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_get_double_delegate>("avutil", "av_opt_get_double", ThrowErrorIfFunctionNotFound);
        if (_av_opt_get_double_cache == null)
            throw new NotSupportedException();
        return _av_opt_get_double_cache(@obj, @name, @search_flags, @out_val);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_get_image_size_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, int* @w_out, int* @h_out);
    private static av_opt_get_image_size_delegate? _av_opt_get_image_size_cache;
    
    public static int av_opt_get_image_size(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, int* @w_out, int* @h_out)
    {
        _av_opt_get_image_size_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_get_image_size_delegate>("avutil", "av_opt_get_image_size", ThrowErrorIfFunctionNotFound);
        if (_av_opt_get_image_size_cache == null)
            throw new NotSupportedException();
        return _av_opt_get_image_size_cache(@obj, @name, @search_flags, @w_out, @h_out);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_get_int_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, long* @out_val);
    private static av_opt_get_int_delegate? _av_opt_get_int_cache;
    
    public static int av_opt_get_int(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, long* @out_val)
    {
        _av_opt_get_int_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_get_int_delegate>("avutil", "av_opt_get_int", ThrowErrorIfFunctionNotFound);
        if (_av_opt_get_int_cache == null)
            throw new NotSupportedException();
        return _av_opt_get_int_cache(@obj, @name, @search_flags, @out_val);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_get_key_value_delegate(byte** @ropts,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key_val_sep,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @pairs_sep, uint @flags, byte** @rkey, byte** @rval);
    private static av_opt_get_key_value_delegate? _av_opt_get_key_value_cache;
    
    /// <summary>Extract a key-value pair from the beginning of a string.</summary>
    /// <param name="ropts">pointer to the options string, will be updated to point to the rest of the string (one of the pairs_sep or the final NUL)</param>
    /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value, for example &apos;=&apos;</param>
    /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other, for example &apos;:&apos; or &apos;,&apos;</param>
    /// <param name="flags">flags; see the AV_OPT_FLAG_* values below</param>
    /// <param name="rkey">parsed key; must be freed using av_free()</param>
    /// <param name="rval">parsed value; must be freed using av_free()</param>
    /// <returns>&gt;=0 for success, or a negative value corresponding to an AVERROR code in case of error; in particular: AVERROR(EINVAL) if no key is present</returns>
    public static int av_opt_get_key_value(byte** @ropts,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key_val_sep,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @pairs_sep, uint @flags, byte** @rkey, byte** @rval)
    {
        _av_opt_get_key_value_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_get_key_value_delegate>("avutil", "av_opt_get_key_value", ThrowErrorIfFunctionNotFound);
        if (_av_opt_get_key_value_cache == null)
            throw new NotSupportedException();
        return _av_opt_get_key_value_cache(@ropts, @key_val_sep, @pairs_sep, @flags, @rkey, @rval);
    }
    
    /// <summary>Extract a key-value pair from the beginning of a string.</summary>
    /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value, for example &apos;=&apos;</param>
    /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other, for example &apos;:&apos; or &apos;,&apos;</param>
    /// <param name="flags">flags; see the AV_OPT_FLAG_* values below</param>
    /// <param name="rkey">parsed key; must be freed using av_free()</param>
    /// <param name="rval">parsed value; must be freed using av_free()</param>
    /// <returns>&gt;=0 for success, or a negative value corresponding to an AVERROR code in case of error; in particular: AVERROR(EINVAL) if no key is present</returns>
    public static int av_opt_get_key_value(ref byte* @ropts, string @key_val_sep, string @pairs_sep, uint @flags, byte** @rkey, byte** @rval)
    {
        fixed (byte** ptr = &@ropts)
        {
            return av_opt_get_key_value(ptr, @key_val_sep, @pairs_sep, @flags, @rkey, @rval);
        }
    }
    
    /// <summary>Extract a key-value pair from the beginning of a string.</summary>
    /// <param name="ropts">pointer to the options string, will be updated to point to the rest of the string (one of the pairs_sep or the final NUL)</param>
    /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value, for example &apos;=&apos;</param>
    /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other, for example &apos;:&apos; or &apos;,&apos;</param>
    /// <param name="flags">flags; see the AV_OPT_FLAG_* values below</param>
    /// <param name="rval">parsed value; must be freed using av_free()</param>
    /// <returns>&gt;=0 for success, or a negative value corresponding to an AVERROR code in case of error; in particular: AVERROR(EINVAL) if no key is present</returns>
    public static int av_opt_get_key_value(byte** @ropts, string @key_val_sep, string @pairs_sep, uint @flags, ref byte* @rkey, byte** @rval)
    {
        fixed (byte** ptr = &@rkey)
        {
            return av_opt_get_key_value(@ropts, @key_val_sep, @pairs_sep, @flags, ptr, @rval);
        }
    }
    
    /// <summary>Extract a key-value pair from the beginning of a string.</summary>
    /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value, for example &apos;=&apos;</param>
    /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other, for example &apos;:&apos; or &apos;,&apos;</param>
    /// <param name="flags">flags; see the AV_OPT_FLAG_* values below</param>
    /// <param name="rval">parsed value; must be freed using av_free()</param>
    /// <returns>&gt;=0 for success, or a negative value corresponding to an AVERROR code in case of error; in particular: AVERROR(EINVAL) if no key is present</returns>
    public static int av_opt_get_key_value(ref byte* @ropts, string @key_val_sep, string @pairs_sep, uint @flags, ref byte* @rkey, byte** @rval)
    {
        fixed (byte** ptr1 = &@ropts)
        {
        fixed (byte** ptr2 = &@rkey)
        {
                return av_opt_get_key_value(ptr1, @key_val_sep, @pairs_sep, @flags, ptr2, @rval);
        }
        }
    }
    
    /// <summary>Extract a key-value pair from the beginning of a string.</summary>
    /// <param name="ropts">pointer to the options string, will be updated to point to the rest of the string (one of the pairs_sep or the final NUL)</param>
    /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value, for example &apos;=&apos;</param>
    /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other, for example &apos;:&apos; or &apos;,&apos;</param>
    /// <param name="flags">flags; see the AV_OPT_FLAG_* values below</param>
    /// <param name="rkey">parsed key; must be freed using av_free()</param>
    /// <returns>&gt;=0 for success, or a negative value corresponding to an AVERROR code in case of error; in particular: AVERROR(EINVAL) if no key is present</returns>
    public static int av_opt_get_key_value(byte** @ropts, string @key_val_sep, string @pairs_sep, uint @flags, byte** @rkey, ref byte* @rval)
    {
        fixed (byte** ptr = &@rval)
        {
            return av_opt_get_key_value(@ropts, @key_val_sep, @pairs_sep, @flags, @rkey, ptr);
        }
    }
    
    /// <summary>Extract a key-value pair from the beginning of a string.</summary>
    /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value, for example &apos;=&apos;</param>
    /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other, for example &apos;:&apos; or &apos;,&apos;</param>
    /// <param name="flags">flags; see the AV_OPT_FLAG_* values below</param>
    /// <param name="rkey">parsed key; must be freed using av_free()</param>
    /// <returns>&gt;=0 for success, or a negative value corresponding to an AVERROR code in case of error; in particular: AVERROR(EINVAL) if no key is present</returns>
    public static int av_opt_get_key_value(ref byte* @ropts, string @key_val_sep, string @pairs_sep, uint @flags, byte** @rkey, ref byte* @rval)
    {
        fixed (byte** ptr1 = &@ropts)
        {
        fixed (byte** ptr2 = &@rval)
        {
                return av_opt_get_key_value(ptr1, @key_val_sep, @pairs_sep, @flags, @rkey, ptr2);
        }
        }
    }
    
    /// <summary>Extract a key-value pair from the beginning of a string.</summary>
    /// <param name="ropts">pointer to the options string, will be updated to point to the rest of the string (one of the pairs_sep or the final NUL)</param>
    /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value, for example &apos;=&apos;</param>
    /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other, for example &apos;:&apos; or &apos;,&apos;</param>
    /// <param name="flags">flags; see the AV_OPT_FLAG_* values below</param>
    /// <returns>&gt;=0 for success, or a negative value corresponding to an AVERROR code in case of error; in particular: AVERROR(EINVAL) if no key is present</returns>
    public static int av_opt_get_key_value(byte** @ropts, string @key_val_sep, string @pairs_sep, uint @flags, ref byte* @rkey, ref byte* @rval)
    {
        fixed (byte** ptr1 = &@rkey)
        {
        fixed (byte** ptr2 = &@rval)
        {
                return av_opt_get_key_value(@ropts, @key_val_sep, @pairs_sep, @flags, ptr1, ptr2);
        }
        }
    }
    
    /// <summary>Extract a key-value pair from the beginning of a string.</summary>
    /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value, for example &apos;=&apos;</param>
    /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other, for example &apos;:&apos; or &apos;,&apos;</param>
    /// <param name="flags">flags; see the AV_OPT_FLAG_* values below</param>
    /// <returns>&gt;=0 for success, or a negative value corresponding to an AVERROR code in case of error; in particular: AVERROR(EINVAL) if no key is present</returns>
    public static int av_opt_get_key_value(ref byte* @ropts, string @key_val_sep, string @pairs_sep, uint @flags, ref byte* @rkey, ref byte* @rval)
    {
        fixed (byte** ptr1 = &@ropts)
        {
        fixed (byte** ptr2 = &@rkey)
        {
        fixed (byte** ptr3 = &@rval)
        {
                    return av_opt_get_key_value(ptr1, @key_val_sep, @pairs_sep, @flags, ptr2, ptr3);
        }
        }
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_get_pixel_fmt_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVPixelFormat* @out_fmt);
    private static av_opt_get_pixel_fmt_delegate? _av_opt_get_pixel_fmt_cache;
    
    public static int av_opt_get_pixel_fmt(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVPixelFormat* @out_fmt)
    {
        _av_opt_get_pixel_fmt_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_get_pixel_fmt_delegate>("avutil", "av_opt_get_pixel_fmt", ThrowErrorIfFunctionNotFound);
        if (_av_opt_get_pixel_fmt_cache == null)
            throw new NotSupportedException();
        return _av_opt_get_pixel_fmt_cache(@obj, @name, @search_flags, @out_fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_get_q_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVRational* @out_val);
    private static av_opt_get_q_delegate? _av_opt_get_q_cache;
    
    public static int av_opt_get_q(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVRational* @out_val)
    {
        _av_opt_get_q_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_get_q_delegate>("avutil", "av_opt_get_q", ThrowErrorIfFunctionNotFound);
        if (_av_opt_get_q_cache == null)
            throw new NotSupportedException();
        return _av_opt_get_q_cache(@obj, @name, @search_flags, @out_val);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_get_sample_fmt_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVSampleFormat* @out_fmt);
    private static av_opt_get_sample_fmt_delegate? _av_opt_get_sample_fmt_cache;
    
    public static int av_opt_get_sample_fmt(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVSampleFormat* @out_fmt)
    {
        _av_opt_get_sample_fmt_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_get_sample_fmt_delegate>("avutil", "av_opt_get_sample_fmt", ThrowErrorIfFunctionNotFound);
        if (_av_opt_get_sample_fmt_cache == null)
            throw new NotSupportedException();
        return _av_opt_get_sample_fmt_cache(@obj, @name, @search_flags, @out_fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_get_video_rate_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVRational* @out_val);
    private static av_opt_get_video_rate_delegate? _av_opt_get_video_rate_cache;
    
    public static int av_opt_get_video_rate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, AVRational* @out_val)
    {
        _av_opt_get_video_rate_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_get_video_rate_delegate>("avutil", "av_opt_get_video_rate", ThrowErrorIfFunctionNotFound);
        if (_av_opt_get_video_rate_cache == null)
            throw new NotSupportedException();
        return _av_opt_get_video_rate_cache(@obj, @name, @search_flags, @out_val);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_is_set_to_default_delegate(void* @obj, AVOption* @o);
    private static av_opt_is_set_to_default_delegate? _av_opt_is_set_to_default_cache;
    
    /// <summary>Check if given option is set to its default value.</summary>
    /// <param name="obj">AVClass object to check option on</param>
    /// <param name="o">option to be checked</param>
    /// <returns>&gt;0 when option is set to its default, 0 when option is not set its default, &lt; 0 on error</returns>
    public static int av_opt_is_set_to_default(void* @obj, AVOption* @o)
    {
        _av_opt_is_set_to_default_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_is_set_to_default_delegate>("avutil", "av_opt_is_set_to_default", ThrowErrorIfFunctionNotFound);
        if (_av_opt_is_set_to_default_cache == null)
            throw new NotSupportedException();
        return _av_opt_is_set_to_default_cache(@obj, @o);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_is_set_to_default_by_name_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags);
    private static av_opt_is_set_to_default_by_name_delegate? _av_opt_is_set_to_default_by_name_cache;
    
    /// <summary>Check if given option is set to its default value.</summary>
    /// <param name="obj">AVClass object to check option on</param>
    /// <param name="name">option name</param>
    /// <param name="search_flags">combination of AV_OPT_SEARCH_*</param>
    /// <returns>&gt;0 when option is set to its default, 0 when option is not set its default, &lt; 0 on error</returns>
    public static int av_opt_is_set_to_default_by_name(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags)
    {
        _av_opt_is_set_to_default_by_name_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_is_set_to_default_by_name_delegate>("avutil", "av_opt_is_set_to_default_by_name", ThrowErrorIfFunctionNotFound);
        if (_av_opt_is_set_to_default_by_name_cache == null)
            throw new NotSupportedException();
        return _av_opt_is_set_to_default_by_name_cache(@obj, @name, @search_flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVOption* av_opt_next_delegate(void* @obj, AVOption* @prev);
    private static av_opt_next_delegate? _av_opt_next_cache;
    
    /// <summary>Iterate over all AVOptions belonging to obj.</summary>
    /// <param name="obj">an AVOptions-enabled struct or a double pointer to an AVClass describing it.</param>
    /// <param name="prev">result of the previous call to av_opt_next() on this object or NULL</param>
    /// <returns>next AVOption or NULL</returns>
    public static AVOption* av_opt_next(void* @obj, AVOption* @prev)
    {
        _av_opt_next_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_next_delegate>("avutil", "av_opt_next", ThrowErrorIfFunctionNotFound);
        if (_av_opt_next_cache == null)
            throw new NotSupportedException();
        return _av_opt_next_cache(@obj, @prev);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* av_opt_ptr_delegate(AVClass* @avclass, void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static av_opt_ptr_delegate? _av_opt_ptr_cache;
    
    /// <summary>Gets a pointer to the requested field in a struct. This function allows accessing a struct even when its fields are moved or renamed since the application making the access has been compiled,</summary>
    public static void* av_opt_ptr(AVClass* @avclass, void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _av_opt_ptr_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_ptr_delegate>("avutil", "av_opt_ptr", ThrowErrorIfFunctionNotFound);
        if (_av_opt_ptr_cache == null)
            throw new NotSupportedException();
        return _av_opt_ptr_cache(@avclass, @obj, @name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_query_ranges_delegate(AVOptionRanges** @p0, void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key, int @flags);
    private static av_opt_query_ranges_delegate? _av_opt_query_ranges_cache;
    
    /// <summary>Get a list of allowed ranges for the given option.</summary>
    /// <param name="flags">is a bitmask of flags, undefined flags should not be set and should be ignored AV_OPT_SEARCH_FAKE_OBJ indicates that the obj is a double pointer to a AVClass instead of a full instance AV_OPT_MULTI_COMPONENT_RANGE indicates that function may return more than one component,</param>
    /// <returns>number of compontents returned on success, a negative errro code otherwise</returns>
    public static int av_opt_query_ranges(AVOptionRanges** @p0, void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key, int @flags)
    {
        _av_opt_query_ranges_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_query_ranges_delegate>("avutil", "av_opt_query_ranges", ThrowErrorIfFunctionNotFound);
        if (_av_opt_query_ranges_cache == null)
            throw new NotSupportedException();
        return _av_opt_query_ranges_cache(@p0, @obj, @key, @flags);
    }
    
    /// <summary>Get a list of allowed ranges for the given option.</summary>
    /// <param name="flags">is a bitmask of flags, undefined flags should not be set and should be ignored AV_OPT_SEARCH_FAKE_OBJ indicates that the obj is a double pointer to a AVClass instead of a full instance AV_OPT_MULTI_COMPONENT_RANGE indicates that function may return more than one component,</param>
    /// <returns>number of compontents returned on success, a negative errro code otherwise</returns>
    public static int av_opt_query_ranges(ref AVOptionRanges* @p0, void* @obj, string @key, int @flags)
    {
        fixed (AVOptionRanges** ptr = &@p0)
        {
            return av_opt_query_ranges(ptr, @obj, @key, @flags);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_query_ranges_default_delegate(AVOptionRanges** @p0, void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key, int @flags);
    private static av_opt_query_ranges_default_delegate? _av_opt_query_ranges_default_cache;
    
    /// <summary>Get a default list of allowed ranges for the given option.</summary>
    /// <param name="flags">is a bitmask of flags, undefined flags should not be set and should be ignored AV_OPT_SEARCH_FAKE_OBJ indicates that the obj is a double pointer to a AVClass instead of a full instance AV_OPT_MULTI_COMPONENT_RANGE indicates that function may return more than one component,</param>
    /// <returns>number of compontents returned on success, a negative errro code otherwise</returns>
    public static int av_opt_query_ranges_default(AVOptionRanges** @p0, void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key, int @flags)
    {
        _av_opt_query_ranges_default_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_query_ranges_default_delegate>("avutil", "av_opt_query_ranges_default", ThrowErrorIfFunctionNotFound);
        if (_av_opt_query_ranges_default_cache == null)
            throw new NotSupportedException();
        return _av_opt_query_ranges_default_cache(@p0, @obj, @key, @flags);
    }
    
    /// <summary>Get a default list of allowed ranges for the given option.</summary>
    /// <param name="flags">is a bitmask of flags, undefined flags should not be set and should be ignored AV_OPT_SEARCH_FAKE_OBJ indicates that the obj is a double pointer to a AVClass instead of a full instance AV_OPT_MULTI_COMPONENT_RANGE indicates that function may return more than one component,</param>
    /// <returns>number of compontents returned on success, a negative errro code otherwise</returns>
    public static int av_opt_query_ranges_default(ref AVOptionRanges* @p0, void* @obj, string @key, int @flags)
    {
        fixed (AVOptionRanges** ptr = &@p0)
        {
            return av_opt_query_ranges_default(ptr, @obj, @key, @flags);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_serialize_delegate(void* @obj, int @opt_flags, int @flags, byte** @buffer, byte @key_val_sep, byte @pairs_sep);
    private static av_opt_serialize_delegate? _av_opt_serialize_cache;
    
    /// <summary>Serialize object&apos;s options.</summary>
    /// <param name="obj">AVClass object to serialize</param>
    /// <param name="opt_flags">serialize options with all the specified flags set (AV_OPT_FLAG)</param>
    /// <param name="flags">combination of AV_OPT_SERIALIZE_* flags</param>
    /// <param name="buffer">Pointer to buffer that will be allocated with string containg serialized options. Buffer must be freed by the caller when is no longer needed.</param>
    /// <param name="key_val_sep">character used to separate key from value</param>
    /// <param name="pairs_sep">character used to separate two pairs from each other</param>
    /// <returns>&gt;= 0 on success, negative on error</returns>
    public static int av_opt_serialize(void* @obj, int @opt_flags, int @flags, byte** @buffer, byte @key_val_sep, byte @pairs_sep)
    {
        _av_opt_serialize_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_serialize_delegate>("avutil", "av_opt_serialize", ThrowErrorIfFunctionNotFound);
        if (_av_opt_serialize_cache == null)
            throw new NotSupportedException();
        return _av_opt_serialize_cache(@obj, @opt_flags, @flags, @buffer, @key_val_sep, @pairs_sep);
    }
    
    /// <summary>Serialize object&apos;s options.</summary>
    /// <param name="obj">AVClass object to serialize</param>
    /// <param name="opt_flags">serialize options with all the specified flags set (AV_OPT_FLAG)</param>
    /// <param name="flags">combination of AV_OPT_SERIALIZE_* flags</param>
    /// <param name="key_val_sep">character used to separate key from value</param>
    /// <param name="pairs_sep">character used to separate two pairs from each other</param>
    /// <returns>&gt;= 0 on success, negative on error</returns>
    public static int av_opt_serialize(void* @obj, int @opt_flags, int @flags, ref byte* @buffer, byte @key_val_sep, byte @pairs_sep)
    {
        fixed (byte** ptr = &@buffer)
        {
            return av_opt_serialize(@obj, @opt_flags, @flags, ptr, @key_val_sep, @pairs_sep);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_set_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, int @search_flags);
    private static av_opt_set_delegate? _av_opt_set_cache;
    
    /// <summary>@{ Those functions set the field of obj with the given name to value.</summary>
    /// <param name="obj">A struct whose first element is a pointer to an AVClass.</param>
    /// <param name="name">the name of the field to set</param>
    /// <param name="val">The value to set. In case of av_opt_set() if the field is not of a string type, then the given string is parsed. SI postfixes and some named scalars are supported. If the field is of a numeric type, it has to be a numeric or named scalar. Behavior with more than one scalar and +- infix operators is undefined. If the field is of a flags type, it has to be a sequence of numeric scalars or named flags separated by &apos;+&apos; or &apos;-&apos;. Prefixing a flag with &apos;+&apos; causes it to be set without affecting the other flags; similarly, &apos;-&apos; unsets a flag. If the field is of a dictionary type, it has to be a &apos;:&apos; separated list of key=value parameters. Values containing &apos;:&apos; special characters must be escaped.</param>
    /// <param name="search_flags">flags passed to av_opt_find2. I.e. if AV_OPT_SEARCH_CHILDREN is passed here, then the option may be set on a child of obj.</param>
    /// <returns>0 if the value has been set, or an AVERROR code in case of error: AVERROR_OPTION_NOT_FOUND if no matching option exists AVERROR(ERANGE) if the value is out of range AVERROR(EINVAL) if the value is not valid</returns>
    public static int av_opt_set(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @val, int @search_flags)
    {
        _av_opt_set_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_set_delegate>("avutil", "av_opt_set", ThrowErrorIfFunctionNotFound);
        if (_av_opt_set_cache == null)
            throw new NotSupportedException();
        return _av_opt_set_cache(@obj, @name, @val, @search_flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_set_array_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, uint @start_elem, uint @nb_elems, AVOptionType @val_type, void* @val);
    private static av_opt_set_array_delegate? _av_opt_set_array_cache;
    
    /// <summary>Add, replace, or remove elements for an array option. Which of these operations is performed depends on the values of val and search_flags.</summary>
    /// <param name="start_elem">Index of the first array element to modify; must not be larger than array size as returned by av_opt_get_array_size().</param>
    /// <param name="nb_elems">number of array elements to modify; when val is NULL, start_elem+nb_elems must not be larger than array size as returned by av_opt_get_array_size()</param>
    /// <param name="val_type">Option type corresponding to the type of val, ignored when val is NULL.</param>
    /// <param name="val">Array with nb_elems elements or NULL.</param>
    public static int av_opt_set_array(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @search_flags, uint @start_elem, uint @nb_elems, AVOptionType @val_type, void* @val)
    {
        _av_opt_set_array_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_set_array_delegate>("avutil", "av_opt_set_array", ThrowErrorIfFunctionNotFound);
        if (_av_opt_set_array_cache == null)
            throw new NotSupportedException();
        return _av_opt_set_array_cache(@obj, @name, @search_flags, @start_elem, @nb_elems, @val_type, @val);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_set_bin_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, byte* @val, int @size, int @search_flags);
    private static av_opt_set_bin_delegate? _av_opt_set_bin_cache;
    
    public static int av_opt_set_bin(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, byte* @val, int @size, int @search_flags)
    {
        _av_opt_set_bin_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_set_bin_delegate>("avutil", "av_opt_set_bin", ThrowErrorIfFunctionNotFound);
        if (_av_opt_set_bin_cache == null)
            throw new NotSupportedException();
        return _av_opt_set_bin_cache(@obj, @name, @val, @size, @search_flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_set_chlayout_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVChannelLayout* @layout, int @search_flags);
    private static av_opt_set_chlayout_delegate? _av_opt_set_chlayout_cache;
    
    public static int av_opt_set_chlayout(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVChannelLayout* @layout, int @search_flags)
    {
        _av_opt_set_chlayout_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_set_chlayout_delegate>("avutil", "av_opt_set_chlayout", ThrowErrorIfFunctionNotFound);
        if (_av_opt_set_chlayout_cache == null)
            throw new NotSupportedException();
        return _av_opt_set_chlayout_cache(@obj, @name, @layout, @search_flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_opt_set_defaults_delegate(void* @s);
    private static av_opt_set_defaults_delegate? _av_opt_set_defaults_cache;
    
    /// <summary>Set the values of all AVOption fields to their default values.</summary>
    /// <param name="s">an AVOption-enabled struct (its first member must be a pointer to AVClass)</param>
    public static void av_opt_set_defaults(void* @s)
    {
        _av_opt_set_defaults_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_set_defaults_delegate>("avutil", "av_opt_set_defaults", ThrowErrorIfFunctionNotFound);
        if (_av_opt_set_defaults_cache == null)
            throw new NotSupportedException();
        _av_opt_set_defaults_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_opt_set_defaults2_delegate(void* @s, int @mask, int @flags);
    private static av_opt_set_defaults2_delegate? _av_opt_set_defaults2_cache;
    
    /// <summary>Set the values of all AVOption fields to their default values. Only these AVOption fields for which (opt-&gt;flags &amp; mask) == flags will have their default applied to s.</summary>
    /// <param name="s">an AVOption-enabled struct (its first member must be a pointer to AVClass)</param>
    /// <param name="mask">combination of AV_OPT_FLAG_*</param>
    /// <param name="flags">combination of AV_OPT_FLAG_*</param>
    public static void av_opt_set_defaults2(void* @s, int @mask, int @flags)
    {
        _av_opt_set_defaults2_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_set_defaults2_delegate>("avutil", "av_opt_set_defaults2", ThrowErrorIfFunctionNotFound);
        if (_av_opt_set_defaults2_cache == null)
            throw new NotSupportedException();
        _av_opt_set_defaults2_cache(@s, @mask, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_set_dict_delegate(void* @obj, AVDictionary** @options);
    private static av_opt_set_dict_delegate? _av_opt_set_dict_cache;
    
    /// <summary>Set all the options from a given dictionary on an object.</summary>
    /// <param name="obj">a struct whose first element is a pointer to AVClass</param>
    /// <param name="options">options to process. This dictionary will be freed and replaced by a new one containing all options not found in obj. Of course this new dictionary needs to be freed by caller with av_dict_free().</param>
    /// <returns>0 on success, a negative AVERROR if some option was found in obj, but could not be set.</returns>
    public static int av_opt_set_dict(void* @obj, AVDictionary** @options)
    {
        _av_opt_set_dict_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_set_dict_delegate>("avutil", "av_opt_set_dict", ThrowErrorIfFunctionNotFound);
        if (_av_opt_set_dict_cache == null)
            throw new NotSupportedException();
        return _av_opt_set_dict_cache(@obj, @options);
    }
    
    /// <summary>Set all the options from a given dictionary on an object.</summary>
    /// <param name="obj">a struct whose first element is a pointer to AVClass</param>
    /// <returns>0 on success, a negative AVERROR if some option was found in obj, but could not be set.</returns>
    public static int av_opt_set_dict(void* @obj, ref AVDictionary* @options)
    {
        fixed (AVDictionary** ptr = &@options)
        {
            return av_opt_set_dict(@obj, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_set_dict_val_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVDictionary* @val, int @search_flags);
    private static av_opt_set_dict_val_delegate? _av_opt_set_dict_val_cache;
    
    public static int av_opt_set_dict_val(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVDictionary* @val, int @search_flags)
    {
        _av_opt_set_dict_val_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_set_dict_val_delegate>("avutil", "av_opt_set_dict_val", ThrowErrorIfFunctionNotFound);
        if (_av_opt_set_dict_val_cache == null)
            throw new NotSupportedException();
        return _av_opt_set_dict_val_cache(@obj, @name, @val, @search_flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_set_dict2_delegate(void* @obj, AVDictionary** @options, int @search_flags);
    private static av_opt_set_dict2_delegate? _av_opt_set_dict2_cache;
    
    /// <summary>Set all the options from a given dictionary on an object.</summary>
    /// <param name="obj">a struct whose first element is a pointer to AVClass</param>
    /// <param name="options">options to process. This dictionary will be freed and replaced by a new one containing all options not found in obj. Of course this new dictionary needs to be freed by caller with av_dict_free().</param>
    /// <param name="search_flags">A combination of AV_OPT_SEARCH_*.</param>
    /// <returns>0 on success, a negative AVERROR if some option was found in obj, but could not be set.</returns>
    public static int av_opt_set_dict2(void* @obj, AVDictionary** @options, int @search_flags)
    {
        _av_opt_set_dict2_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_set_dict2_delegate>("avutil", "av_opt_set_dict2", ThrowErrorIfFunctionNotFound);
        if (_av_opt_set_dict2_cache == null)
            throw new NotSupportedException();
        return _av_opt_set_dict2_cache(@obj, @options, @search_flags);
    }
    
    /// <summary>Set all the options from a given dictionary on an object.</summary>
    /// <param name="obj">a struct whose first element is a pointer to AVClass</param>
    /// <param name="search_flags">A combination of AV_OPT_SEARCH_*.</param>
    /// <returns>0 on success, a negative AVERROR if some option was found in obj, but could not be set.</returns>
    public static int av_opt_set_dict2(void* @obj, ref AVDictionary* @options, int @search_flags)
    {
        fixed (AVDictionary** ptr = &@options)
        {
            return av_opt_set_dict2(@obj, ptr, @search_flags);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_set_double_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, double @val, int @search_flags);
    private static av_opt_set_double_delegate? _av_opt_set_double_cache;
    
    public static int av_opt_set_double(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, double @val, int @search_flags)
    {
        _av_opt_set_double_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_set_double_delegate>("avutil", "av_opt_set_double", ThrowErrorIfFunctionNotFound);
        if (_av_opt_set_double_cache == null)
            throw new NotSupportedException();
        return _av_opt_set_double_cache(@obj, @name, @val, @search_flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_set_from_string_delegate(void* @ctx,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @opts, byte** @shorthand,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key_val_sep,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @pairs_sep);
    private static av_opt_set_from_string_delegate? _av_opt_set_from_string_cache;
    
    /// <summary>Parse the key-value pairs list in opts. For each key=value pair found, set the value of the corresponding option in ctx.</summary>
    /// <param name="ctx">the AVClass object to set options on</param>
    /// <param name="opts">the options string, key-value pairs separated by a delimiter</param>
    /// <param name="shorthand">a NULL-terminated array of options names for shorthand notation: if the first field in opts has no key part, the key is taken from the first element of shorthand; then again for the second, etc., until either opts is finished, shorthand is finished or a named option is found; after that, all options must be named</param>
    /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value, for example &apos;=&apos;</param>
    /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other, for example &apos;:&apos; or &apos;,&apos;</param>
    /// <returns>the number of successfully set key=value pairs, or a negative value corresponding to an AVERROR code in case of error: AVERROR(EINVAL) if opts cannot be parsed, the error code issued by av_set_string3() if a key/value pair cannot be set</returns>
    public static int av_opt_set_from_string(void* @ctx,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @opts, byte** @shorthand,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key_val_sep,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @pairs_sep)
    {
        _av_opt_set_from_string_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_set_from_string_delegate>("avutil", "av_opt_set_from_string", ThrowErrorIfFunctionNotFound);
        if (_av_opt_set_from_string_cache == null)
            throw new NotSupportedException();
        return _av_opt_set_from_string_cache(@ctx, @opts, @shorthand, @key_val_sep, @pairs_sep);
    }
    
    /// <summary>Parse the key-value pairs list in opts. For each key=value pair found, set the value of the corresponding option in ctx.</summary>
    /// <param name="ctx">the AVClass object to set options on</param>
    /// <param name="opts">the options string, key-value pairs separated by a delimiter</param>
    /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value, for example &apos;=&apos;</param>
    /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other, for example &apos;:&apos; or &apos;,&apos;</param>
    /// <returns>the number of successfully set key=value pairs, or a negative value corresponding to an AVERROR code in case of error: AVERROR(EINVAL) if opts cannot be parsed, the error code issued by av_set_string3() if a key/value pair cannot be set</returns>
    public static int av_opt_set_from_string(void* @ctx, string @opts, ref byte* @shorthand, string @key_val_sep, string @pairs_sep)
    {
        fixed (byte** ptr = &@shorthand)
        {
            return av_opt_set_from_string(@ctx, @opts, ptr, @key_val_sep, @pairs_sep);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_set_image_size_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @w, int @h, int @search_flags);
    private static av_opt_set_image_size_delegate? _av_opt_set_image_size_cache;
    
    public static int av_opt_set_image_size(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, int @w, int @h, int @search_flags)
    {
        _av_opt_set_image_size_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_set_image_size_delegate>("avutil", "av_opt_set_image_size", ThrowErrorIfFunctionNotFound);
        if (_av_opt_set_image_size_cache == null)
            throw new NotSupportedException();
        return _av_opt_set_image_size_cache(@obj, @name, @w, @h, @search_flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_set_int_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, long @val, int @search_flags);
    private static av_opt_set_int_delegate? _av_opt_set_int_cache;
    
    public static int av_opt_set_int(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, long @val, int @search_flags)
    {
        _av_opt_set_int_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_set_int_delegate>("avutil", "av_opt_set_int", ThrowErrorIfFunctionNotFound);
        if (_av_opt_set_int_cache == null)
            throw new NotSupportedException();
        return _av_opt_set_int_cache(@obj, @name, @val, @search_flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_set_pixel_fmt_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVPixelFormat @fmt, int @search_flags);
    private static av_opt_set_pixel_fmt_delegate? _av_opt_set_pixel_fmt_cache;
    
    public static int av_opt_set_pixel_fmt(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVPixelFormat @fmt, int @search_flags)
    {
        _av_opt_set_pixel_fmt_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_set_pixel_fmt_delegate>("avutil", "av_opt_set_pixel_fmt", ThrowErrorIfFunctionNotFound);
        if (_av_opt_set_pixel_fmt_cache == null)
            throw new NotSupportedException();
        return _av_opt_set_pixel_fmt_cache(@obj, @name, @fmt, @search_flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_set_q_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVRational @val, int @search_flags);
    private static av_opt_set_q_delegate? _av_opt_set_q_cache;
    
    public static int av_opt_set_q(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVRational @val, int @search_flags)
    {
        _av_opt_set_q_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_set_q_delegate>("avutil", "av_opt_set_q", ThrowErrorIfFunctionNotFound);
        if (_av_opt_set_q_cache == null)
            throw new NotSupportedException();
        return _av_opt_set_q_cache(@obj, @name, @val, @search_flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_set_sample_fmt_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVSampleFormat @fmt, int @search_flags);
    private static av_opt_set_sample_fmt_delegate? _av_opt_set_sample_fmt_cache;
    
    public static int av_opt_set_sample_fmt(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVSampleFormat @fmt, int @search_flags)
    {
        _av_opt_set_sample_fmt_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_set_sample_fmt_delegate>("avutil", "av_opt_set_sample_fmt", ThrowErrorIfFunctionNotFound);
        if (_av_opt_set_sample_fmt_cache == null)
            throw new NotSupportedException();
        return _av_opt_set_sample_fmt_cache(@obj, @name, @fmt, @search_flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_set_video_rate_delegate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVRational @val, int @search_flags);
    private static av_opt_set_video_rate_delegate? _av_opt_set_video_rate_cache;
    
    public static int av_opt_set_video_rate(void* @obj,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name, AVRational @val, int @search_flags)
    {
        _av_opt_set_video_rate_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_set_video_rate_delegate>("avutil", "av_opt_set_video_rate", ThrowErrorIfFunctionNotFound);
        if (_av_opt_set_video_rate_cache == null)
            throw new NotSupportedException();
        return _av_opt_set_video_rate_cache(@obj, @name, @val, @search_flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_opt_show2_delegate(void* @obj, void* @av_log_obj, int @req_flags, int @rej_flags);
    private static av_opt_show2_delegate? _av_opt_show2_cache;
    
    /// <summary>Show the obj options.</summary>
    /// <param name="av_log_obj">log context to use for showing the options</param>
    /// <param name="req_flags">requested flags for the options to show. Show only the options for which it is opt-&gt;flags &amp; req_flags.</param>
    /// <param name="rej_flags">rejected flags for the options to show. Show only the options for which it is !(opt-&gt;flags &amp; req_flags).</param>
    public static int av_opt_show2(void* @obj, void* @av_log_obj, int @req_flags, int @rej_flags)
    {
        _av_opt_show2_cache ??= FunctionResolver.GetFunctionDelegate<av_opt_show2_delegate>("avutil", "av_opt_show2", ThrowErrorIfFunctionNotFound);
        if (_av_opt_show2_cache == null)
            throw new NotSupportedException();
        return _av_opt_show2_cache(@obj, @av_log_obj, @req_flags, @rej_flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVOutputFormat* av_output_audio_device_next_delegate(AVOutputFormat* @d);
    private static av_output_audio_device_next_delegate? _av_output_audio_device_next_cache;
    
    /// <summary>Audio output devices iterator.</summary>
    public static AVOutputFormat* av_output_audio_device_next(AVOutputFormat* @d)
    {
        _av_output_audio_device_next_cache ??= FunctionResolver.GetFunctionDelegate<av_output_audio_device_next_delegate>("avdevice", "av_output_audio_device_next", ThrowErrorIfFunctionNotFound);
        if (_av_output_audio_device_next_cache == null)
            throw new NotSupportedException();
        return _av_output_audio_device_next_cache(@d);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVOutputFormat* av_output_video_device_next_delegate(AVOutputFormat* @d);
    private static av_output_video_device_next_delegate? _av_output_video_device_next_cache;
    
    /// <summary>Video output devices iterator.</summary>
    public static AVOutputFormat* av_output_video_device_next(AVOutputFormat* @d)
    {
        _av_output_video_device_next_cache ??= FunctionResolver.GetFunctionDelegate<av_output_video_device_next_delegate>("avdevice", "av_output_video_device_next", ThrowErrorIfFunctionNotFound);
        if (_av_output_video_device_next_cache == null)
            throw new NotSupportedException();
        return _av_output_video_device_next_cache(@d);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_packet_add_side_data_delegate(AVPacket* @pkt, AVPacketSideDataType @type, byte* @data, ulong @size);
    private static av_packet_add_side_data_delegate? _av_packet_add_side_data_cache;
    
    /// <summary>Wrap an existing array as a packet side data.</summary>
    /// <param name="pkt">packet</param>
    /// <param name="type">side information type</param>
    /// <param name="data">the side data array. It must be allocated with the av_malloc() family of functions. The ownership of the data is transferred to pkt.</param>
    /// <param name="size">side information size</param>
    /// <returns>a non-negative number on success, a negative AVERROR code on failure. On failure, the packet is unchanged and the data remains owned by the caller.</returns>
    public static int av_packet_add_side_data(AVPacket* @pkt, AVPacketSideDataType @type, byte* @data, ulong @size)
    {
        _av_packet_add_side_data_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_add_side_data_delegate>("avcodec", "av_packet_add_side_data", ThrowErrorIfFunctionNotFound);
        if (_av_packet_add_side_data_cache == null)
            throw new NotSupportedException();
        return _av_packet_add_side_data_cache(@pkt, @type, @data, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVPacket* av_packet_alloc_delegate();
    private static av_packet_alloc_delegate? _av_packet_alloc_cache;
    
    /// <summary>Allocate an AVPacket and set its fields to default values. The resulting struct must be freed using av_packet_free().</summary>
    /// <returns>An AVPacket filled with default values or NULL on failure.</returns>
    public static AVPacket* av_packet_alloc()
    {
        _av_packet_alloc_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_alloc_delegate>("avcodec", "av_packet_alloc", ThrowErrorIfFunctionNotFound);
        if (_av_packet_alloc_cache == null)
            throw new NotSupportedException();
        return _av_packet_alloc_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVPacket* av_packet_clone_delegate(AVPacket* @src);
    private static av_packet_clone_delegate? _av_packet_clone_cache;
    
    /// <summary>Create a new packet that references the same data as src.</summary>
    /// <returns>newly created AVPacket on success, NULL on error.</returns>
    public static AVPacket* av_packet_clone(AVPacket* @src)
    {
        _av_packet_clone_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_clone_delegate>("avcodec", "av_packet_clone", ThrowErrorIfFunctionNotFound);
        if (_av_packet_clone_cache == null)
            throw new NotSupportedException();
        return _av_packet_clone_cache(@src);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_packet_copy_props_delegate(AVPacket* @dst, AVPacket* @src);
    private static av_packet_copy_props_delegate? _av_packet_copy_props_cache;
    
    /// <summary>Copy only &quot;properties&quot; fields from src to dst.</summary>
    /// <param name="dst">Destination packet</param>
    /// <param name="src">Source packet</param>
    /// <returns>0 on success AVERROR on failure.</returns>
    public static int av_packet_copy_props(AVPacket* @dst, AVPacket* @src)
    {
        _av_packet_copy_props_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_copy_props_delegate>("avcodec", "av_packet_copy_props", ThrowErrorIfFunctionNotFound);
        if (_av_packet_copy_props_cache == null)
            throw new NotSupportedException();
        return _av_packet_copy_props_cache(@dst, @src);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_packet_free_delegate(AVPacket** @pkt);
    private static av_packet_free_delegate? _av_packet_free_cache;
    
    /// <summary>Free the packet, if the packet is reference counted, it will be unreferenced first.</summary>
    /// <param name="pkt">packet to be freed. The pointer will be set to NULL.</param>
    public static void av_packet_free(AVPacket** @pkt)
    {
        _av_packet_free_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_free_delegate>("avcodec", "av_packet_free", ThrowErrorIfFunctionNotFound);
        if (_av_packet_free_cache == null)
            throw new NotSupportedException();
        _av_packet_free_cache(@pkt);
    }
    
    /// <summary>Free the packet, if the packet is reference counted, it will be unreferenced first.</summary>
    public static void av_packet_free(ref AVPacket* @pkt)
    {
        fixed (AVPacket** ptr = &@pkt)
        {
            av_packet_free(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_packet_free_side_data_delegate(AVPacket* @pkt);
    private static av_packet_free_side_data_delegate? _av_packet_free_side_data_cache;
    
    /// <summary>Convenience function to free all the side data stored. All the other fields stay untouched.</summary>
    /// <param name="pkt">packet</param>
    public static void av_packet_free_side_data(AVPacket* @pkt)
    {
        _av_packet_free_side_data_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_free_side_data_delegate>("avcodec", "av_packet_free_side_data", ThrowErrorIfFunctionNotFound);
        if (_av_packet_free_side_data_cache == null)
            throw new NotSupportedException();
        _av_packet_free_side_data_cache(@pkt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_packet_from_data_delegate(AVPacket* @pkt, byte* @data, int @size);
    private static av_packet_from_data_delegate? _av_packet_from_data_cache;
    
    /// <summary>Initialize a reference-counted packet from av_malloc()ed data.</summary>
    /// <param name="pkt">packet to be initialized. This function will set the data, size, and buf fields, all others are left untouched.</param>
    /// <param name="data">Data allocated by av_malloc() to be used as packet data. If this function returns successfully, the data is owned by the underlying AVBuffer. The caller may not access the data through other means.</param>
    /// <param name="size">size of data in bytes, without the padding. I.e. the full buffer size is assumed to be size + AV_INPUT_BUFFER_PADDING_SIZE.</param>
    /// <returns>0 on success, a negative AVERROR on error</returns>
    public static int av_packet_from_data(AVPacket* @pkt, byte* @data, int @size)
    {
        _av_packet_from_data_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_from_data_delegate>("avcodec", "av_packet_from_data", ThrowErrorIfFunctionNotFound);
        if (_av_packet_from_data_cache == null)
            throw new NotSupportedException();
        return _av_packet_from_data_cache(@pkt, @data, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte* av_packet_get_side_data_delegate(AVPacket* @pkt, AVPacketSideDataType @type, ulong* @size);
    private static av_packet_get_side_data_delegate? _av_packet_get_side_data_cache;
    
    /// <summary>Get side information from packet.</summary>
    /// <param name="pkt">packet</param>
    /// <param name="type">desired side information type</param>
    /// <param name="size">If supplied, *size will be set to the size of the side data or to zero if the desired side data is not present.</param>
    /// <returns>pointer to data if present or NULL otherwise</returns>
    public static byte* av_packet_get_side_data(AVPacket* @pkt, AVPacketSideDataType @type, ulong* @size)
    {
        _av_packet_get_side_data_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_get_side_data_delegate>("avcodec", "av_packet_get_side_data", ThrowErrorIfFunctionNotFound);
        if (_av_packet_get_side_data_cache == null)
            throw new NotSupportedException();
        return _av_packet_get_side_data_cache(@pkt, @type, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_packet_make_refcounted_delegate(AVPacket* @pkt);
    private static av_packet_make_refcounted_delegate? _av_packet_make_refcounted_cache;
    
    /// <summary>Ensure the data described by a given packet is reference counted.</summary>
    /// <param name="pkt">packet whose data should be made reference counted.</param>
    /// <returns>0 on success, a negative AVERROR on error. On failure, the packet is unchanged.</returns>
    public static int av_packet_make_refcounted(AVPacket* @pkt)
    {
        _av_packet_make_refcounted_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_make_refcounted_delegate>("avcodec", "av_packet_make_refcounted", ThrowErrorIfFunctionNotFound);
        if (_av_packet_make_refcounted_cache == null)
            throw new NotSupportedException();
        return _av_packet_make_refcounted_cache(@pkt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_packet_make_writable_delegate(AVPacket* @pkt);
    private static av_packet_make_writable_delegate? _av_packet_make_writable_cache;
    
    /// <summary>Create a writable reference for the data described by a given packet, avoiding data copy if possible.</summary>
    /// <param name="pkt">Packet whose data should be made writable.</param>
    /// <returns>0 on success, a negative AVERROR on failure. On failure, the packet is unchanged.</returns>
    public static int av_packet_make_writable(AVPacket* @pkt)
    {
        _av_packet_make_writable_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_make_writable_delegate>("avcodec", "av_packet_make_writable", ThrowErrorIfFunctionNotFound);
        if (_av_packet_make_writable_cache == null)
            throw new NotSupportedException();
        return _av_packet_make_writable_cache(@pkt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_packet_move_ref_delegate(AVPacket* @dst, AVPacket* @src);
    private static av_packet_move_ref_delegate? _av_packet_move_ref_cache;
    
    /// <summary>Move every field in src to dst and reset src.</summary>
    /// <param name="dst">Destination packet</param>
    /// <param name="src">Source packet, will be reset</param>
    public static void av_packet_move_ref(AVPacket* @dst, AVPacket* @src)
    {
        _av_packet_move_ref_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_move_ref_delegate>("avcodec", "av_packet_move_ref", ThrowErrorIfFunctionNotFound);
        if (_av_packet_move_ref_cache == null)
            throw new NotSupportedException();
        _av_packet_move_ref_cache(@dst, @src);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte* av_packet_new_side_data_delegate(AVPacket* @pkt, AVPacketSideDataType @type, ulong @size);
    private static av_packet_new_side_data_delegate? _av_packet_new_side_data_cache;
    
    /// <summary>Allocate new information of a packet.</summary>
    /// <param name="pkt">packet</param>
    /// <param name="type">side information type</param>
    /// <param name="size">side information size</param>
    /// <returns>pointer to fresh allocated data or NULL otherwise</returns>
    public static byte* av_packet_new_side_data(AVPacket* @pkt, AVPacketSideDataType @type, ulong @size)
    {
        _av_packet_new_side_data_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_new_side_data_delegate>("avcodec", "av_packet_new_side_data", ThrowErrorIfFunctionNotFound);
        if (_av_packet_new_side_data_cache == null)
            throw new NotSupportedException();
        return _av_packet_new_side_data_cache(@pkt, @type, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte* av_packet_pack_dictionary_delegate(AVDictionary* @dict, ulong* @size);
    private static av_packet_pack_dictionary_delegate? _av_packet_pack_dictionary_cache;
    
    /// <summary>Pack a dictionary for use in side_data.</summary>
    /// <param name="dict">The dictionary to pack.</param>
    /// <param name="size">pointer to store the size of the returned data</param>
    /// <returns>pointer to data if successful, NULL otherwise</returns>
    public static byte* av_packet_pack_dictionary(AVDictionary* @dict, ulong* @size)
    {
        _av_packet_pack_dictionary_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_pack_dictionary_delegate>("avcodec", "av_packet_pack_dictionary", ThrowErrorIfFunctionNotFound);
        if (_av_packet_pack_dictionary_cache == null)
            throw new NotSupportedException();
        return _av_packet_pack_dictionary_cache(@dict, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_packet_ref_delegate(AVPacket* @dst, AVPacket* @src);
    private static av_packet_ref_delegate? _av_packet_ref_cache;
    
    /// <summary>Setup a new reference to the data described by a given packet</summary>
    /// <param name="dst">Destination packet. Will be completely overwritten.</param>
    /// <param name="src">Source packet</param>
    /// <returns>0 on success, a negative AVERROR on error. On error, dst will be blank (as if returned by av_packet_alloc()).</returns>
    public static int av_packet_ref(AVPacket* @dst, AVPacket* @src)
    {
        _av_packet_ref_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_ref_delegate>("avcodec", "av_packet_ref", ThrowErrorIfFunctionNotFound);
        if (_av_packet_ref_cache == null)
            throw new NotSupportedException();
        return _av_packet_ref_cache(@dst, @src);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_packet_rescale_ts_delegate(AVPacket* @pkt, AVRational @tb_src, AVRational @tb_dst);
    private static av_packet_rescale_ts_delegate? _av_packet_rescale_ts_cache;
    
    /// <summary>Convert valid timing fields (timestamps / durations) in a packet from one timebase to another. Timestamps with unknown values (AV_NOPTS_VALUE) will be ignored.</summary>
    /// <param name="pkt">packet on which the conversion will be performed</param>
    /// <param name="tb_src">source timebase, in which the timing fields in pkt are expressed</param>
    /// <param name="tb_dst">destination timebase, to which the timing fields will be converted</param>
    public static void av_packet_rescale_ts(AVPacket* @pkt, AVRational @tb_src, AVRational @tb_dst)
    {
        _av_packet_rescale_ts_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_rescale_ts_delegate>("avcodec", "av_packet_rescale_ts", ThrowErrorIfFunctionNotFound);
        if (_av_packet_rescale_ts_cache == null)
            throw new NotSupportedException();
        _av_packet_rescale_ts_cache(@pkt, @tb_src, @tb_dst);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_packet_shrink_side_data_delegate(AVPacket* @pkt, AVPacketSideDataType @type, ulong @size);
    private static av_packet_shrink_side_data_delegate? _av_packet_shrink_side_data_cache;
    
    /// <summary>Shrink the already allocated side data buffer</summary>
    /// <param name="pkt">packet</param>
    /// <param name="type">side information type</param>
    /// <param name="size">new side information size</param>
    /// <returns>0 on success, &lt; 0 on failure</returns>
    public static int av_packet_shrink_side_data(AVPacket* @pkt, AVPacketSideDataType @type, ulong @size)
    {
        _av_packet_shrink_side_data_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_shrink_side_data_delegate>("avcodec", "av_packet_shrink_side_data", ThrowErrorIfFunctionNotFound);
        if (_av_packet_shrink_side_data_cache == null)
            throw new NotSupportedException();
        return _av_packet_shrink_side_data_cache(@pkt, @type, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVPacketSideData* av_packet_side_data_add_delegate(AVPacketSideData** @sd, int* @nb_sd, AVPacketSideDataType @type, void* @data, ulong @size, int @flags);
    private static av_packet_side_data_add_delegate? _av_packet_side_data_add_cache;
    
    /// <summary>Wrap existing data as packet side data.</summary>
    /// <param name="sd">pointer to an array of side data to which the side data should be added. *sd may be NULL, in which case the array will be initialized</param>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array. The integer value will be increased by 1 on success.</param>
    /// <param name="type">side data type</param>
    /// <param name="data">a data array. It must be allocated with the av_malloc() family of functions. The ownership of the data is transferred to the side data array on success</param>
    /// <param name="size">size of the data array</param>
    /// <param name="flags">currently unused. Must be zero</param>
    /// <returns>pointer to freshly allocated side data on success, or NULL otherwise On failure, the side data array is unchanged and the data remains owned by the caller.</returns>
    public static AVPacketSideData* av_packet_side_data_add(AVPacketSideData** @sd, int* @nb_sd, AVPacketSideDataType @type, void* @data, ulong @size, int @flags)
    {
        _av_packet_side_data_add_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_side_data_add_delegate>("avcodec", "av_packet_side_data_add", ThrowErrorIfFunctionNotFound);
        if (_av_packet_side_data_add_cache == null)
            throw new NotSupportedException();
        return _av_packet_side_data_add_cache(@sd, @nb_sd, @type, @data, @size, @flags);
    }
    
    /// <summary>Wrap existing data as packet side data.</summary>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array. The integer value will be increased by 1 on success.</param>
    /// <param name="type">side data type</param>
    /// <param name="data">a data array. It must be allocated with the av_malloc() family of functions. The ownership of the data is transferred to the side data array on success</param>
    /// <param name="size">size of the data array</param>
    /// <param name="flags">currently unused. Must be zero</param>
    /// <returns>pointer to freshly allocated side data on success, or NULL otherwise On failure, the side data array is unchanged and the data remains owned by the caller.</returns>
    public static AVPacketSideData* av_packet_side_data_add(ref AVPacketSideData* @sd, int* @nb_sd, AVPacketSideDataType @type, void* @data, ulong @size, int @flags)
    {
        fixed (AVPacketSideData** ptr = &@sd)
        {
            return av_packet_side_data_add(ptr, @nb_sd, @type, @data, @size, @flags);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_packet_side_data_free_delegate(AVPacketSideData** @sd, int* @nb_sd);
    private static av_packet_side_data_free_delegate? _av_packet_side_data_free_cache;
    
    /// <summary>Convenience function to free all the side data stored in an array, and the array itself.</summary>
    /// <param name="sd">pointer to array of side data to free. Will be set to NULL upon return.</param>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array. Will be set to 0 upon return.</param>
    public static void av_packet_side_data_free(AVPacketSideData** @sd, int* @nb_sd)
    {
        _av_packet_side_data_free_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_side_data_free_delegate>("avcodec", "av_packet_side_data_free", ThrowErrorIfFunctionNotFound);
        if (_av_packet_side_data_free_cache == null)
            throw new NotSupportedException();
        _av_packet_side_data_free_cache(@sd, @nb_sd);
    }
    
    /// <summary>Convenience function to free all the side data stored in an array, and the array itself.</summary>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array. Will be set to 0 upon return.</param>
    public static void av_packet_side_data_free(ref AVPacketSideData* @sd, int* @nb_sd)
    {
        fixed (AVPacketSideData** ptr = &@sd)
        {
            av_packet_side_data_free(ptr, @nb_sd);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVPacketSideData* av_packet_side_data_get_delegate(AVPacketSideData* @sd, int @nb_sd, AVPacketSideDataType @type);
    private static av_packet_side_data_get_delegate? _av_packet_side_data_get_cache;
    
    /// <summary>Get side information from a side data array.</summary>
    /// <param name="sd">the array from which the side data should be fetched</param>
    /// <param name="nb_sd">value containing the number of entries in the array.</param>
    /// <param name="type">desired side information type</param>
    /// <returns>pointer to side data if present or NULL otherwise</returns>
    public static AVPacketSideData* av_packet_side_data_get(AVPacketSideData* @sd, int @nb_sd, AVPacketSideDataType @type)
    {
        _av_packet_side_data_get_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_side_data_get_delegate>("avcodec", "av_packet_side_data_get", ThrowErrorIfFunctionNotFound);
        if (_av_packet_side_data_get_cache == null)
            throw new NotSupportedException();
        return _av_packet_side_data_get_cache(@sd, @nb_sd, @type);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string av_packet_side_data_name_delegate(AVPacketSideDataType @type);
    private static av_packet_side_data_name_delegate? _av_packet_side_data_name_cache;
    
    public static string av_packet_side_data_name(AVPacketSideDataType @type)
    {
        _av_packet_side_data_name_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_side_data_name_delegate>("avcodec", "av_packet_side_data_name", ThrowErrorIfFunctionNotFound);
        if (_av_packet_side_data_name_cache == null)
            throw new NotSupportedException();
        return _av_packet_side_data_name_cache(@type);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVPacketSideData* av_packet_side_data_new_delegate(AVPacketSideData** @psd, int* @pnb_sd, AVPacketSideDataType @type, ulong @size, int @flags);
    private static av_packet_side_data_new_delegate? _av_packet_side_data_new_cache;
    
    /// <summary>Allocate a new packet side data.</summary>
    /// <param name="type">side data type</param>
    /// <param name="size">desired side data size</param>
    /// <param name="flags">currently unused. Must be zero</param>
    /// <returns>pointer to freshly allocated side data on success, or NULL otherwise.</returns>
    public static AVPacketSideData* av_packet_side_data_new(AVPacketSideData** @psd, int* @pnb_sd, AVPacketSideDataType @type, ulong @size, int @flags)
    {
        _av_packet_side_data_new_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_side_data_new_delegate>("avcodec", "av_packet_side_data_new", ThrowErrorIfFunctionNotFound);
        if (_av_packet_side_data_new_cache == null)
            throw new NotSupportedException();
        return _av_packet_side_data_new_cache(@psd, @pnb_sd, @type, @size, @flags);
    }
    
    /// <summary>Allocate a new packet side data.</summary>
    /// <param name="type">side data type</param>
    /// <param name="size">desired side data size</param>
    /// <param name="flags">currently unused. Must be zero</param>
    /// <returns>pointer to freshly allocated side data on success, or NULL otherwise.</returns>
    public static AVPacketSideData* av_packet_side_data_new(ref AVPacketSideData* @psd, int* @pnb_sd, AVPacketSideDataType @type, ulong @size, int @flags)
    {
        fixed (AVPacketSideData** ptr = &@psd)
        {
            return av_packet_side_data_new(ptr, @pnb_sd, @type, @size, @flags);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_packet_side_data_remove_delegate(AVPacketSideData* @sd, int* @nb_sd, AVPacketSideDataType @type);
    private static av_packet_side_data_remove_delegate? _av_packet_side_data_remove_cache;
    
    /// <summary>Remove side data of the given type from a side data array.</summary>
    /// <param name="sd">the array from which the side data should be removed</param>
    /// <param name="nb_sd">pointer to an integer containing the number of entries in the array. Will be reduced by the amount of entries removed upon return</param>
    /// <param name="type">side information type</param>
    public static void av_packet_side_data_remove(AVPacketSideData* @sd, int* @nb_sd, AVPacketSideDataType @type)
    {
        _av_packet_side_data_remove_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_side_data_remove_delegate>("avcodec", "av_packet_side_data_remove", ThrowErrorIfFunctionNotFound);
        if (_av_packet_side_data_remove_cache == null)
            throw new NotSupportedException();
        _av_packet_side_data_remove_cache(@sd, @nb_sd, @type);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_packet_unpack_dictionary_delegate(byte* @data, ulong @size, AVDictionary** @dict);
    private static av_packet_unpack_dictionary_delegate? _av_packet_unpack_dictionary_cache;
    
    /// <summary>Unpack a dictionary from side_data.</summary>
    /// <param name="data">data from side_data</param>
    /// <param name="size">size of the data</param>
    /// <param name="dict">the metadata storage dictionary</param>
    /// <returns>0 on success, &lt; 0 on failure</returns>
    public static int av_packet_unpack_dictionary(byte* @data, ulong @size, AVDictionary** @dict)
    {
        _av_packet_unpack_dictionary_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_unpack_dictionary_delegate>("avcodec", "av_packet_unpack_dictionary", ThrowErrorIfFunctionNotFound);
        if (_av_packet_unpack_dictionary_cache == null)
            throw new NotSupportedException();
        return _av_packet_unpack_dictionary_cache(@data, @size, @dict);
    }
    
    /// <summary>Unpack a dictionary from side_data.</summary>
    /// <param name="data">data from side_data</param>
    /// <param name="size">size of the data</param>
    /// <returns>0 on success, &lt; 0 on failure</returns>
    public static int av_packet_unpack_dictionary(byte* @data, ulong @size, ref AVDictionary* @dict)
    {
        fixed (AVDictionary** ptr = &@dict)
        {
            return av_packet_unpack_dictionary(@data, @size, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_packet_unref_delegate(AVPacket* @pkt);
    private static av_packet_unref_delegate? _av_packet_unref_cache;
    
    /// <summary>Wipe the packet.</summary>
    /// <param name="pkt">The packet to be unreferenced.</param>
    public static void av_packet_unref(AVPacket* @pkt)
    {
        _av_packet_unref_cache ??= FunctionResolver.GetFunctionDelegate<av_packet_unref_delegate>("avcodec", "av_packet_unref", ThrowErrorIfFunctionNotFound);
        if (_av_packet_unref_cache == null)
            throw new NotSupportedException();
        _av_packet_unref_cache(@pkt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_parse_cpu_caps_delegate(uint* @flags,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @s);
    private static av_parse_cpu_caps_delegate? _av_parse_cpu_caps_cache;
    
    /// <summary>Parse CPU caps from a string and update the given AV_CPU_* flags based on that.</summary>
    /// <returns>negative on error.</returns>
    public static int av_parse_cpu_caps(uint* @flags,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @s)
    {
        _av_parse_cpu_caps_cache ??= FunctionResolver.GetFunctionDelegate<av_parse_cpu_caps_delegate>("avutil", "av_parse_cpu_caps", ThrowErrorIfFunctionNotFound);
        if (_av_parse_cpu_caps_cache == null)
            throw new NotSupportedException();
        return _av_parse_cpu_caps_cache(@flags, @s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_parser_close_delegate(AVCodecParserContext* @s);
    private static av_parser_close_delegate? _av_parser_close_cache;
    
    public static void av_parser_close(AVCodecParserContext* @s)
    {
        _av_parser_close_cache ??= FunctionResolver.GetFunctionDelegate<av_parser_close_delegate>("avcodec", "av_parser_close", ThrowErrorIfFunctionNotFound);
        if (_av_parser_close_cache == null)
            throw new NotSupportedException();
        _av_parser_close_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodecParserContext* av_parser_init_delegate(int @codec_id);
    private static av_parser_init_delegate? _av_parser_init_cache;
    
    public static AVCodecParserContext* av_parser_init(int @codec_id)
    {
        _av_parser_init_cache ??= FunctionResolver.GetFunctionDelegate<av_parser_init_delegate>("avcodec", "av_parser_init", ThrowErrorIfFunctionNotFound);
        if (_av_parser_init_cache == null)
            throw new NotSupportedException();
        return _av_parser_init_cache(@codec_id);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodecParser* av_parser_iterate_delegate(void** @opaque);
    private static av_parser_iterate_delegate? _av_parser_iterate_cache;
    
    /// <summary>Iterate over all registered codec parsers.</summary>
    /// <param name="opaque">a pointer where libavcodec will store the iteration state. Must point to NULL to start the iteration.</param>
    /// <returns>the next registered codec parser or NULL when the iteration is finished</returns>
    public static AVCodecParser* av_parser_iterate(void** @opaque)
    {
        _av_parser_iterate_cache ??= FunctionResolver.GetFunctionDelegate<av_parser_iterate_delegate>("avcodec", "av_parser_iterate", ThrowErrorIfFunctionNotFound);
        if (_av_parser_iterate_cache == null)
            throw new NotSupportedException();
        return _av_parser_iterate_cache(@opaque);
    }
    
    /// <summary>Iterate over all registered codec parsers.</summary>
    /// <returns>the next registered codec parser or NULL when the iteration is finished</returns>
    public static AVCodecParser* av_parser_iterate(ref void* @opaque)
    {
        fixed (void** ptr = &@opaque)
        {
            return av_parser_iterate(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_parser_parse2_delegate(AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, long @pts, long @dts, long @pos);
    private static av_parser_parse2_delegate? _av_parser_parse2_cache;
    
    /// <summary>Parse a packet.</summary>
    /// <param name="s">parser context.</param>
    /// <param name="avctx">codec context.</param>
    /// <param name="poutbuf">set to pointer to parsed buffer or NULL if not yet finished.</param>
    /// <param name="poutbuf_size">set to size of parsed buffer or zero if not yet finished.</param>
    /// <param name="buf">input buffer.</param>
    /// <param name="buf_size">buffer size in bytes without the padding. I.e. the full buffer size is assumed to be buf_size + AV_INPUT_BUFFER_PADDING_SIZE. To signal EOF, this should be 0 (so that the last frame can be output).</param>
    /// <param name="pts">input presentation timestamp.</param>
    /// <param name="dts">input decoding timestamp.</param>
    /// <param name="pos">input byte position in stream.</param>
    /// <returns>the number of bytes of the input bitstream used.</returns>
    public static int av_parser_parse2(AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, long @pts, long @dts, long @pos)
    {
        _av_parser_parse2_cache ??= FunctionResolver.GetFunctionDelegate<av_parser_parse2_delegate>("avcodec", "av_parser_parse2", ThrowErrorIfFunctionNotFound);
        if (_av_parser_parse2_cache == null)
            throw new NotSupportedException();
        return _av_parser_parse2_cache(@s, @avctx, @poutbuf, @poutbuf_size, @buf, @buf_size, @pts, @dts, @pos);
    }
    
    /// <summary>Parse a packet.</summary>
    /// <param name="s">parser context.</param>
    /// <param name="avctx">codec context.</param>
    /// <param name="poutbuf_size">set to size of parsed buffer or zero if not yet finished.</param>
    /// <param name="buf">input buffer.</param>
    /// <param name="buf_size">buffer size in bytes without the padding. I.e. the full buffer size is assumed to be buf_size + AV_INPUT_BUFFER_PADDING_SIZE. To signal EOF, this should be 0 (so that the last frame can be output).</param>
    /// <param name="pts">input presentation timestamp.</param>
    /// <param name="dts">input decoding timestamp.</param>
    /// <param name="pos">input byte position in stream.</param>
    /// <returns>the number of bytes of the input bitstream used.</returns>
    public static int av_parser_parse2(AVCodecParserContext* @s, AVCodecContext* @avctx, ref byte* @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, long @pts, long @dts, long @pos)
    {
        fixed (byte** ptr = &@poutbuf)
        {
            return av_parser_parse2(@s, @avctx, ptr, @poutbuf_size, @buf, @buf_size, @pts, @dts, @pos);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_pix_fmt_count_planes_delegate(AVPixelFormat @pix_fmt);
    private static av_pix_fmt_count_planes_delegate? _av_pix_fmt_count_planes_cache;
    
    /// <summary>Returns number of planes in pix_fmt, a negative AVERROR if pix_fmt is not a valid pixel format.</summary>
    /// <returns>number of planes in pix_fmt, a negative AVERROR if pix_fmt is not a valid pixel format.</returns>
    public static int av_pix_fmt_count_planes(AVPixelFormat @pix_fmt)
    {
        _av_pix_fmt_count_planes_cache ??= FunctionResolver.GetFunctionDelegate<av_pix_fmt_count_planes_delegate>("avutil", "av_pix_fmt_count_planes", ThrowErrorIfFunctionNotFound);
        if (_av_pix_fmt_count_planes_cache == null)
            throw new NotSupportedException();
        return _av_pix_fmt_count_planes_cache(@pix_fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVPixFmtDescriptor* av_pix_fmt_desc_get_delegate(AVPixelFormat @pix_fmt);
    private static av_pix_fmt_desc_get_delegate? _av_pix_fmt_desc_get_cache;
    
    /// <summary>Returns a pixel format descriptor for provided pixel format or NULL if this pixel format is unknown.</summary>
    /// <returns>a pixel format descriptor for provided pixel format or NULL if this pixel format is unknown.</returns>
    public static AVPixFmtDescriptor* av_pix_fmt_desc_get(AVPixelFormat @pix_fmt)
    {
        _av_pix_fmt_desc_get_cache ??= FunctionResolver.GetFunctionDelegate<av_pix_fmt_desc_get_delegate>("avutil", "av_pix_fmt_desc_get", ThrowErrorIfFunctionNotFound);
        if (_av_pix_fmt_desc_get_cache == null)
            throw new NotSupportedException();
        return _av_pix_fmt_desc_get_cache(@pix_fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVPixelFormat av_pix_fmt_desc_get_id_delegate(AVPixFmtDescriptor* @desc);
    private static av_pix_fmt_desc_get_id_delegate? _av_pix_fmt_desc_get_id_cache;
    
    /// <summary>Returns an AVPixelFormat id described by desc, or AV_PIX_FMT_NONE if desc is not a valid pointer to a pixel format descriptor.</summary>
    /// <returns>an AVPixelFormat id described by desc, or AV_PIX_FMT_NONE if desc is not a valid pointer to a pixel format descriptor.</returns>
    public static AVPixelFormat av_pix_fmt_desc_get_id(AVPixFmtDescriptor* @desc)
    {
        _av_pix_fmt_desc_get_id_cache ??= FunctionResolver.GetFunctionDelegate<av_pix_fmt_desc_get_id_delegate>("avutil", "av_pix_fmt_desc_get_id", ThrowErrorIfFunctionNotFound);
        if (_av_pix_fmt_desc_get_id_cache == null)
            throw new NotSupportedException();
        return _av_pix_fmt_desc_get_id_cache(@desc);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVPixFmtDescriptor* av_pix_fmt_desc_next_delegate(AVPixFmtDescriptor* @prev);
    private static av_pix_fmt_desc_next_delegate? _av_pix_fmt_desc_next_cache;
    
    /// <summary>Iterate over all pixel format descriptors known to libavutil.</summary>
    /// <param name="prev">previous descriptor. NULL to get the first descriptor.</param>
    /// <returns>next descriptor or NULL after the last descriptor</returns>
    public static AVPixFmtDescriptor* av_pix_fmt_desc_next(AVPixFmtDescriptor* @prev)
    {
        _av_pix_fmt_desc_next_cache ??= FunctionResolver.GetFunctionDelegate<av_pix_fmt_desc_next_delegate>("avutil", "av_pix_fmt_desc_next", ThrowErrorIfFunctionNotFound);
        if (_av_pix_fmt_desc_next_cache == null)
            throw new NotSupportedException();
        return _av_pix_fmt_desc_next_cache(@prev);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_pix_fmt_get_chroma_sub_sample_delegate(AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift);
    private static av_pix_fmt_get_chroma_sub_sample_delegate? _av_pix_fmt_get_chroma_sub_sample_cache;
    
    /// <summary>Utility function to access log2_chroma_w log2_chroma_h from the pixel format AVPixFmtDescriptor.</summary>
    /// <param name="pix_fmt">the pixel format</param>
    /// <param name="h_shift">store log2_chroma_w (horizontal/width shift)</param>
    /// <param name="v_shift">store log2_chroma_h (vertical/height shift)</param>
    /// <returns>0 on success, AVERROR(ENOSYS) on invalid or unknown pixel format</returns>
    public static int av_pix_fmt_get_chroma_sub_sample(AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift)
    {
        _av_pix_fmt_get_chroma_sub_sample_cache ??= FunctionResolver.GetFunctionDelegate<av_pix_fmt_get_chroma_sub_sample_delegate>("avutil", "av_pix_fmt_get_chroma_sub_sample", ThrowErrorIfFunctionNotFound);
        if (_av_pix_fmt_get_chroma_sub_sample_cache == null)
            throw new NotSupportedException();
        return _av_pix_fmt_get_chroma_sub_sample_cache(@pix_fmt, @h_shift, @v_shift);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVPixelFormat av_pix_fmt_swap_endianness_delegate(AVPixelFormat @pix_fmt);
    private static av_pix_fmt_swap_endianness_delegate? _av_pix_fmt_swap_endianness_cache;
    
    /// <summary>Utility function to swap the endianness of a pixel format.</summary>
    /// <param name="pix_fmt">the pixel format</param>
    /// <returns>pixel format with swapped endianness if it exists, otherwise AV_PIX_FMT_NONE</returns>
    public static AVPixelFormat av_pix_fmt_swap_endianness(AVPixelFormat @pix_fmt)
    {
        _av_pix_fmt_swap_endianness_cache ??= FunctionResolver.GetFunctionDelegate<av_pix_fmt_swap_endianness_delegate>("avutil", "av_pix_fmt_swap_endianness", ThrowErrorIfFunctionNotFound);
        if (_av_pix_fmt_swap_endianness_cache == null)
            throw new NotSupportedException();
        return _av_pix_fmt_swap_endianness_cache(@pix_fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_pkt_dump_log2_delegate(void* @avcl, int @level, AVPacket* @pkt, int @dump_payload, AVStream* @st);
    private static av_pkt_dump_log2_delegate? _av_pkt_dump_log2_cache;
    
    /// <summary>Send a nice dump of a packet to the log.</summary>
    /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
    /// <param name="level">The importance level of the message, lower values signifying higher importance.</param>
    /// <param name="pkt">packet to dump</param>
    /// <param name="dump_payload">True if the payload must be displayed, too.</param>
    /// <param name="st">AVStream that the packet belongs to</param>
    public static void av_pkt_dump_log2(void* @avcl, int @level, AVPacket* @pkt, int @dump_payload, AVStream* @st)
    {
        _av_pkt_dump_log2_cache ??= FunctionResolver.GetFunctionDelegate<av_pkt_dump_log2_delegate>("avformat", "av_pkt_dump_log2", ThrowErrorIfFunctionNotFound);
        if (_av_pkt_dump_log2_cache == null)
            throw new NotSupportedException();
        _av_pkt_dump_log2_cache(@avcl, @level, @pkt, @dump_payload, @st);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_pkt_dump2_delegate(_iobuf* @f, AVPacket* @pkt, int @dump_payload, AVStream* @st);
    private static av_pkt_dump2_delegate? _av_pkt_dump2_cache;
    
    /// <summary>Send a nice dump of a packet to the specified file stream.</summary>
    /// <param name="f">The file stream pointer where the dump should be sent to.</param>
    /// <param name="pkt">packet to dump</param>
    /// <param name="dump_payload">True if the payload must be displayed, too.</param>
    /// <param name="st">AVStream that the packet belongs to</param>
    public static void av_pkt_dump2(_iobuf* @f, AVPacket* @pkt, int @dump_payload, AVStream* @st)
    {
        _av_pkt_dump2_cache ??= FunctionResolver.GetFunctionDelegate<av_pkt_dump2_delegate>("avformat", "av_pkt_dump2", ThrowErrorIfFunctionNotFound);
        if (_av_pkt_dump2_cache == null)
            throw new NotSupportedException();
        _av_pkt_dump2_cache(@f, @pkt, @dump_payload, @st);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_probe_input_buffer_delegate(AVIOContext* @pb, AVInputFormat** @fmt,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, void* @logctx, uint @offset, uint @max_probe_size);
    private static av_probe_input_buffer_delegate? _av_probe_input_buffer_cache;
    
    /// <summary>Like av_probe_input_buffer2() but returns 0 on success</summary>
    public static int av_probe_input_buffer(AVIOContext* @pb, AVInputFormat** @fmt,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, void* @logctx, uint @offset, uint @max_probe_size)
    {
        _av_probe_input_buffer_cache ??= FunctionResolver.GetFunctionDelegate<av_probe_input_buffer_delegate>("avformat", "av_probe_input_buffer", ThrowErrorIfFunctionNotFound);
        if (_av_probe_input_buffer_cache == null)
            throw new NotSupportedException();
        return _av_probe_input_buffer_cache(@pb, @fmt, @url, @logctx, @offset, @max_probe_size);
    }
    
    /// <summary>Like av_probe_input_buffer2() but returns 0 on success</summary>
    public static int av_probe_input_buffer(AVIOContext* @pb, ref AVInputFormat* @fmt, string @url, void* @logctx, uint @offset, uint @max_probe_size)
    {
        fixed (AVInputFormat** ptr = &@fmt)
        {
            return av_probe_input_buffer(@pb, ptr, @url, @logctx, @offset, @max_probe_size);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_probe_input_buffer2_delegate(AVIOContext* @pb, AVInputFormat** @fmt,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, void* @logctx, uint @offset, uint @max_probe_size);
    private static av_probe_input_buffer2_delegate? _av_probe_input_buffer2_cache;
    
    /// <summary>Probe a bytestream to determine the input format. Each time a probe returns with a score that is too low, the probe buffer size is increased and another attempt is made. When the maximum probe size is reached, the input format with the highest score is returned.</summary>
    /// <param name="pb">the bytestream to probe</param>
    /// <param name="fmt">the input format is put here</param>
    /// <param name="url">the url of the stream</param>
    /// <param name="logctx">the log context</param>
    /// <param name="offset">the offset within the bytestream to probe from</param>
    /// <param name="max_probe_size">the maximum probe buffer size (zero for default)</param>
    /// <returns>the score in case of success, a negative value corresponding to an the maximal score is AVPROBE_SCORE_MAX AVERROR code otherwise</returns>
    public static int av_probe_input_buffer2(AVIOContext* @pb, AVInputFormat** @fmt,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, void* @logctx, uint @offset, uint @max_probe_size)
    {
        _av_probe_input_buffer2_cache ??= FunctionResolver.GetFunctionDelegate<av_probe_input_buffer2_delegate>("avformat", "av_probe_input_buffer2", ThrowErrorIfFunctionNotFound);
        if (_av_probe_input_buffer2_cache == null)
            throw new NotSupportedException();
        return _av_probe_input_buffer2_cache(@pb, @fmt, @url, @logctx, @offset, @max_probe_size);
    }
    
    /// <summary>Probe a bytestream to determine the input format. Each time a probe returns with a score that is too low, the probe buffer size is increased and another attempt is made. When the maximum probe size is reached, the input format with the highest score is returned.</summary>
    /// <param name="pb">the bytestream to probe</param>
    /// <param name="url">the url of the stream</param>
    /// <param name="logctx">the log context</param>
    /// <param name="offset">the offset within the bytestream to probe from</param>
    /// <param name="max_probe_size">the maximum probe buffer size (zero for default)</param>
    /// <returns>the score in case of success, a negative value corresponding to an the maximal score is AVPROBE_SCORE_MAX AVERROR code otherwise</returns>
    public static int av_probe_input_buffer2(AVIOContext* @pb, ref AVInputFormat* @fmt, string @url, void* @logctx, uint @offset, uint @max_probe_size)
    {
        fixed (AVInputFormat** ptr = &@fmt)
        {
            return av_probe_input_buffer2(@pb, ptr, @url, @logctx, @offset, @max_probe_size);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVInputFormat* av_probe_input_format_delegate(AVProbeData* @pd, int @is_opened);
    private static av_probe_input_format_delegate? _av_probe_input_format_cache;
    
    /// <summary>Guess the file format.</summary>
    /// <param name="pd">data to be probed</param>
    /// <param name="is_opened">Whether the file is already opened; determines whether demuxers with or without AVFMT_NOFILE are probed.</param>
    public static AVInputFormat* av_probe_input_format(AVProbeData* @pd, int @is_opened)
    {
        _av_probe_input_format_cache ??= FunctionResolver.GetFunctionDelegate<av_probe_input_format_delegate>("avformat", "av_probe_input_format", ThrowErrorIfFunctionNotFound);
        if (_av_probe_input_format_cache == null)
            throw new NotSupportedException();
        return _av_probe_input_format_cache(@pd, @is_opened);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVInputFormat* av_probe_input_format2_delegate(AVProbeData* @pd, int @is_opened, int* @score_max);
    private static av_probe_input_format2_delegate? _av_probe_input_format2_cache;
    
    /// <summary>Guess the file format.</summary>
    /// <param name="pd">data to be probed</param>
    /// <param name="is_opened">Whether the file is already opened; determines whether demuxers with or without AVFMT_NOFILE are probed.</param>
    /// <param name="score_max">A probe score larger that this is required to accept a detection, the variable is set to the actual detection score afterwards. If the score is &lt; = AVPROBE_SCORE_MAX / 4 it is recommended to retry with a larger probe buffer.</param>
    public static AVInputFormat* av_probe_input_format2(AVProbeData* @pd, int @is_opened, int* @score_max)
    {
        _av_probe_input_format2_cache ??= FunctionResolver.GetFunctionDelegate<av_probe_input_format2_delegate>("avformat", "av_probe_input_format2", ThrowErrorIfFunctionNotFound);
        if (_av_probe_input_format2_cache == null)
            throw new NotSupportedException();
        return _av_probe_input_format2_cache(@pd, @is_opened, @score_max);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVInputFormat* av_probe_input_format3_delegate(AVProbeData* @pd, int @is_opened, int* @score_ret);
    private static av_probe_input_format3_delegate? _av_probe_input_format3_cache;
    
    /// <summary>Guess the file format.</summary>
    /// <param name="is_opened">Whether the file is already opened; determines whether demuxers with or without AVFMT_NOFILE are probed.</param>
    /// <param name="score_ret">The score of the best detection.</param>
    public static AVInputFormat* av_probe_input_format3(AVProbeData* @pd, int @is_opened, int* @score_ret)
    {
        _av_probe_input_format3_cache ??= FunctionResolver.GetFunctionDelegate<av_probe_input_format3_delegate>("avformat", "av_probe_input_format3", ThrowErrorIfFunctionNotFound);
        if (_av_probe_input_format3_cache == null)
            throw new NotSupportedException();
        return _av_probe_input_format3_cache(@pd, @is_opened, @score_ret);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_program_add_stream_index_delegate(AVFormatContext* @ac, int @progid, uint @idx);
    private static av_program_add_stream_index_delegate? _av_program_add_stream_index_cache;
    
    public static void av_program_add_stream_index(AVFormatContext* @ac, int @progid, uint @idx)
    {
        _av_program_add_stream_index_cache ??= FunctionResolver.GetFunctionDelegate<av_program_add_stream_index_delegate>("avformat", "av_program_add_stream_index", ThrowErrorIfFunctionNotFound);
        if (_av_program_add_stream_index_cache == null)
            throw new NotSupportedException();
        _av_program_add_stream_index_cache(@ac, @progid, @idx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint av_q2intfloat_delegate(AVRational @q);
    private static av_q2intfloat_delegate? _av_q2intfloat_cache;
    
    /// <summary>Convert an AVRational to a IEEE 32-bit `float` expressed in fixed-point format.</summary>
    /// <param name="q">Rational to be converted</param>
    /// <returns>Equivalent floating-point value, expressed as an unsigned 32-bit integer.</returns>
    public static uint av_q2intfloat(AVRational @q)
    {
        _av_q2intfloat_cache ??= FunctionResolver.GetFunctionDelegate<av_q2intfloat_delegate>("avutil", "av_q2intfloat", ThrowErrorIfFunctionNotFound);
        if (_av_q2intfloat_cache == null)
            throw new NotSupportedException();
        return _av_q2intfloat_cache(@q);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_read_frame_delegate(AVFormatContext* @s, AVPacket* @pkt);
    private static av_read_frame_delegate? _av_read_frame_cache;
    
    /// <summary>Return the next frame of a stream. This function returns what is stored in the file, and does not validate that what is there are valid frames for the decoder. It will split what is stored in the file into frames and return one for each call. It will not omit invalid data between valid frames so as to give the decoder the maximum information possible for decoding.</summary>
    /// <returns>0 if OK, &lt; 0 on error or end of file. On error, pkt will be blank (as if it came from av_packet_alloc()).</returns>
    public static int av_read_frame(AVFormatContext* @s, AVPacket* @pkt)
    {
        _av_read_frame_cache ??= FunctionResolver.GetFunctionDelegate<av_read_frame_delegate>("avformat", "av_read_frame", ThrowErrorIfFunctionNotFound);
        if (_av_read_frame_cache == null)
            throw new NotSupportedException();
        return _av_read_frame_cache(@s, @pkt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_read_image_line_delegate(ushort* @dst, in byte_ptrArray4 @data, in int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component);
    private static av_read_image_line_delegate? _av_read_image_line_cache;
    
    public static void av_read_image_line(ushort* @dst, in byte_ptrArray4 @data, in int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component)
    {
        _av_read_image_line_cache ??= FunctionResolver.GetFunctionDelegate<av_read_image_line_delegate>("avutil", "av_read_image_line", ThrowErrorIfFunctionNotFound);
        if (_av_read_image_line_cache == null)
            throw new NotSupportedException();
        _av_read_image_line_cache(@dst, @data, @linesize, @desc, @x, @y, @c, @w, @read_pal_component);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_read_image_line2_delegate(void* @dst, in byte_ptrArray4 @data, in int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component, int @dst_element_size);
    private static av_read_image_line2_delegate? _av_read_image_line2_cache;
    
    /// <summary>Read a line from an image, and write the values of the pixel format component c to dst.</summary>
    /// <param name="data">the array containing the pointers to the planes of the image</param>
    /// <param name="linesize">the array containing the linesizes of the image</param>
    /// <param name="desc">the pixel format descriptor for the image</param>
    /// <param name="x">the horizontal coordinate of the first pixel to read</param>
    /// <param name="y">the vertical coordinate of the first pixel to read</param>
    /// <param name="w">the width of the line to read, that is the number of values to write to dst</param>
    /// <param name="read_pal_component">if not zero and the format is a paletted format writes the values corresponding to the palette component c in data[1] to dst, rather than the palette indexes in data[0]. The behavior is undefined if the format is not paletted.</param>
    /// <param name="dst_element_size">size of elements in dst array (2 or 4 byte)</param>
    public static void av_read_image_line2(void* @dst, in byte_ptrArray4 @data, in int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component, int @dst_element_size)
    {
        _av_read_image_line2_cache ??= FunctionResolver.GetFunctionDelegate<av_read_image_line2_delegate>("avutil", "av_read_image_line2", ThrowErrorIfFunctionNotFound);
        if (_av_read_image_line2_cache == null)
            throw new NotSupportedException();
        _av_read_image_line2_cache(@dst, @data, @linesize, @desc, @x, @y, @c, @w, @read_pal_component, @dst_element_size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_read_pause_delegate(AVFormatContext* @s);
    private static av_read_pause_delegate? _av_read_pause_cache;
    
    /// <summary>Pause a network-based stream (e.g. RTSP stream).</summary>
    public static int av_read_pause(AVFormatContext* @s)
    {
        _av_read_pause_cache ??= FunctionResolver.GetFunctionDelegate<av_read_pause_delegate>("avformat", "av_read_pause", ThrowErrorIfFunctionNotFound);
        if (_av_read_pause_cache == null)
            throw new NotSupportedException();
        return _av_read_pause_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_read_play_delegate(AVFormatContext* @s);
    private static av_read_play_delegate? _av_read_play_cache;
    
    /// <summary>Start playing a network-based stream (e.g. RTSP stream) at the current position.</summary>
    public static int av_read_play(AVFormatContext* @s)
    {
        _av_read_play_cache ??= FunctionResolver.GetFunctionDelegate<av_read_play_delegate>("avformat", "av_read_play", ThrowErrorIfFunctionNotFound);
        if (_av_read_play_cache == null)
            throw new NotSupportedException();
        return _av_read_play_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* av_realloc_delegate(void* @ptr, ulong @size);
    private static av_realloc_delegate? _av_realloc_cache;
    
    /// <summary>Allocate, reallocate, or free a block of memory.</summary>
    /// <param name="ptr">Pointer to a memory block already allocated with av_realloc() or `NULL`</param>
    /// <param name="size">Size in bytes of the memory block to be allocated or reallocated</param>
    /// <returns>Pointer to a newly-reallocated block or `NULL` if the block cannot be reallocated</returns>
    public static void* av_realloc(void* @ptr, ulong @size)
    {
        _av_realloc_cache ??= FunctionResolver.GetFunctionDelegate<av_realloc_delegate>("avutil", "av_realloc", ThrowErrorIfFunctionNotFound);
        if (_av_realloc_cache == null)
            throw new NotSupportedException();
        return _av_realloc_cache(@ptr, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* av_realloc_array_delegate(void* @ptr, ulong @nmemb, ulong @size);
    private static av_realloc_array_delegate? _av_realloc_array_cache;
    
    /// <summary>Allocate, reallocate, or free an array.</summary>
    /// <param name="ptr">Pointer to a memory block already allocated with av_realloc() or `NULL`</param>
    /// <param name="nmemb">Number of elements in the array</param>
    /// <param name="size">Size of the single element of the array</param>
    /// <returns>Pointer to a newly-reallocated block or NULL if the block cannot be reallocated</returns>
    public static void* av_realloc_array(void* @ptr, ulong @nmemb, ulong @size)
    {
        _av_realloc_array_cache ??= FunctionResolver.GetFunctionDelegate<av_realloc_array_delegate>("avutil", "av_realloc_array", ThrowErrorIfFunctionNotFound);
        if (_av_realloc_array_cache == null)
            throw new NotSupportedException();
        return _av_realloc_array_cache(@ptr, @nmemb, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* av_realloc_f_delegate(void* @ptr, ulong @nelem, ulong @elsize);
    private static av_realloc_f_delegate? _av_realloc_f_cache;
    
    /// <summary>Allocate, reallocate, or free a block of memory.</summary>
    public static void* av_realloc_f(void* @ptr, ulong @nelem, ulong @elsize)
    {
        _av_realloc_f_cache ??= FunctionResolver.GetFunctionDelegate<av_realloc_f_delegate>("avutil", "av_realloc_f", ThrowErrorIfFunctionNotFound);
        if (_av_realloc_f_cache == null)
            throw new NotSupportedException();
        return _av_realloc_f_cache(@ptr, @nelem, @elsize);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_reallocp_delegate(void* @ptr, ulong @size);
    private static av_reallocp_delegate? _av_reallocp_cache;
    
    /// <summary>Allocate, reallocate, or free a block of memory through a pointer to a pointer.</summary>
    /// <param name="ptr">Pointer to a pointer to a memory block already allocated with av_realloc(), or a pointer to `NULL`. The pointer is updated on success, or freed on failure.</param>
    /// <param name="size">Size in bytes for the memory block to be allocated or reallocated</param>
    /// <returns>Zero on success, an AVERROR error code on failure</returns>
    public static int av_reallocp(void* @ptr, ulong @size)
    {
        _av_reallocp_cache ??= FunctionResolver.GetFunctionDelegate<av_reallocp_delegate>("avutil", "av_reallocp", ThrowErrorIfFunctionNotFound);
        if (_av_reallocp_cache == null)
            throw new NotSupportedException();
        return _av_reallocp_cache(@ptr, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_reallocp_array_delegate(void* @ptr, ulong @nmemb, ulong @size);
    private static av_reallocp_array_delegate? _av_reallocp_array_cache;
    
    /// <summary>Allocate, reallocate an array through a pointer to a pointer.</summary>
    /// <param name="ptr">Pointer to a pointer to a memory block already allocated with av_realloc(), or a pointer to `NULL`. The pointer is updated on success, or freed on failure.</param>
    /// <param name="nmemb">Number of elements</param>
    /// <param name="size">Size of the single element</param>
    /// <returns>Zero on success, an AVERROR error code on failure</returns>
    public static int av_reallocp_array(void* @ptr, ulong @nmemb, ulong @size)
    {
        _av_reallocp_array_cache ??= FunctionResolver.GetFunctionDelegate<av_reallocp_array_delegate>("avutil", "av_reallocp_array", ThrowErrorIfFunctionNotFound);
        if (_av_reallocp_array_cache == null)
            throw new NotSupportedException();
        return _av_reallocp_array_cache(@ptr, @nmemb, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_reduce_delegate(int* @dst_num, int* @dst_den, long @num, long @den, long @max);
    private static av_reduce_delegate? _av_reduce_cache;
    
    /// <summary>Reduce a fraction.</summary>
    /// <param name="dst_num">Destination numerator</param>
    /// <param name="dst_den">Destination denominator</param>
    /// <param name="num">Source numerator</param>
    /// <param name="den">Source denominator</param>
    /// <param name="max">Maximum allowed values for `dst_num` &amp; `dst_den`</param>
    /// <returns>1 if the operation is exact, 0 otherwise</returns>
    public static int av_reduce(int* @dst_num, int* @dst_den, long @num, long @den, long @max)
    {
        _av_reduce_cache ??= FunctionResolver.GetFunctionDelegate<av_reduce_delegate>("avutil", "av_reduce", ThrowErrorIfFunctionNotFound);
        if (_av_reduce_cache == null)
            throw new NotSupportedException();
        return _av_reduce_cache(@dst_num, @dst_den, @num, @den, @max);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate long av_rescale_delegate(long @a, long @b, long @c);
    private static av_rescale_delegate? _av_rescale_cache;
    
    /// <summary>Rescale a 64-bit integer with rounding to nearest.</summary>
    public static long av_rescale(long @a, long @b, long @c)
    {
        _av_rescale_cache ??= FunctionResolver.GetFunctionDelegate<av_rescale_delegate>("avutil", "av_rescale", ThrowErrorIfFunctionNotFound);
        if (_av_rescale_cache == null)
            throw new NotSupportedException();
        return _av_rescale_cache(@a, @b, @c);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate long av_rescale_delta_delegate(AVRational @in_tb, long @in_ts, AVRational @fs_tb, int @duration, long* @last, AVRational @out_tb);
    private static av_rescale_delta_delegate? _av_rescale_delta_cache;
    
    /// <summary>Rescale a timestamp while preserving known durations.</summary>
    /// <param name="in_tb">Input time base</param>
    /// <param name="in_ts">Input timestamp</param>
    /// <param name="fs_tb">Duration time base; typically this is finer-grained (greater) than `in_tb` and `out_tb`</param>
    /// <param name="duration">Duration till the next call to this function (i.e. duration of the current packet/frame)</param>
    /// <param name="last">Pointer to a timestamp expressed in terms of `fs_tb`, acting as a state variable</param>
    /// <param name="out_tb">Output timebase</param>
    /// <returns>Timestamp expressed in terms of `out_tb`</returns>
    public static long av_rescale_delta(AVRational @in_tb, long @in_ts, AVRational @fs_tb, int @duration, long* @last, AVRational @out_tb)
    {
        _av_rescale_delta_cache ??= FunctionResolver.GetFunctionDelegate<av_rescale_delta_delegate>("avutil", "av_rescale_delta", ThrowErrorIfFunctionNotFound);
        if (_av_rescale_delta_cache == null)
            throw new NotSupportedException();
        return _av_rescale_delta_cache(@in_tb, @in_ts, @fs_tb, @duration, @last, @out_tb);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate long av_rescale_q_delegate(long @a, AVRational @bq, AVRational @cq);
    private static av_rescale_q_delegate? _av_rescale_q_cache;
    
    /// <summary>Rescale a 64-bit integer by 2 rational numbers.</summary>
    public static long av_rescale_q(long @a, AVRational @bq, AVRational @cq)
    {
        _av_rescale_q_cache ??= FunctionResolver.GetFunctionDelegate<av_rescale_q_delegate>("avutil", "av_rescale_q", ThrowErrorIfFunctionNotFound);
        if (_av_rescale_q_cache == null)
            throw new NotSupportedException();
        return _av_rescale_q_cache(@a, @bq, @cq);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate long av_rescale_q_rnd_delegate(long @a, AVRational @bq, AVRational @cq, AVRounding @rnd);
    private static av_rescale_q_rnd_delegate? _av_rescale_q_rnd_cache;
    
    /// <summary>Rescale a 64-bit integer by 2 rational numbers with specified rounding.</summary>
    public static long av_rescale_q_rnd(long @a, AVRational @bq, AVRational @cq, AVRounding @rnd)
    {
        _av_rescale_q_rnd_cache ??= FunctionResolver.GetFunctionDelegate<av_rescale_q_rnd_delegate>("avutil", "av_rescale_q_rnd", ThrowErrorIfFunctionNotFound);
        if (_av_rescale_q_rnd_cache == null)
            throw new NotSupportedException();
        return _av_rescale_q_rnd_cache(@a, @bq, @cq, @rnd);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate long av_rescale_rnd_delegate(long @a, long @b, long @c, AVRounding @rnd);
    private static av_rescale_rnd_delegate? _av_rescale_rnd_cache;
    
    /// <summary>Rescale a 64-bit integer with specified rounding.</summary>
    public static long av_rescale_rnd(long @a, long @b, long @c, AVRounding @rnd)
    {
        _av_rescale_rnd_cache ??= FunctionResolver.GetFunctionDelegate<av_rescale_rnd_delegate>("avutil", "av_rescale_rnd", ThrowErrorIfFunctionNotFound);
        if (_av_rescale_rnd_cache == null)
            throw new NotSupportedException();
        return _av_rescale_rnd_cache(@a, @b, @c, @rnd);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_sample_fmt_is_planar_delegate(AVSampleFormat @sample_fmt);
    private static av_sample_fmt_is_planar_delegate? _av_sample_fmt_is_planar_cache;
    
    /// <summary>Check if the sample format is planar.</summary>
    /// <param name="sample_fmt">the sample format to inspect</param>
    /// <returns>1 if the sample format is planar, 0 if it is interleaved</returns>
    public static int av_sample_fmt_is_planar(AVSampleFormat @sample_fmt)
    {
        _av_sample_fmt_is_planar_cache ??= FunctionResolver.GetFunctionDelegate<av_sample_fmt_is_planar_delegate>("avutil", "av_sample_fmt_is_planar", ThrowErrorIfFunctionNotFound);
        if (_av_sample_fmt_is_planar_cache == null)
            throw new NotSupportedException();
        return _av_sample_fmt_is_planar_cache(@sample_fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_samples_alloc_delegate(byte** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
    private static av_samples_alloc_delegate? _av_samples_alloc_cache;
    
    /// <summary>Allocate a samples buffer for nb_samples samples, and fill data pointers and linesize accordingly. The allocated samples buffer can be freed by using av_freep(&amp;audio_data[0]) Allocated data will be initialized to silence.</summary>
    /// <param name="audio_data">array to be filled with the pointer for each channel</param>
    /// <param name="linesize">aligned size for audio buffer(s), may be NULL</param>
    /// <param name="nb_channels">number of audio channels</param>
    /// <param name="nb_samples">number of samples per channel</param>
    /// <param name="sample_fmt">the sample format</param>
    /// <param name="align">buffer size alignment (0 = default, 1 = no alignment)</param>
    /// <returns>&gt;=0 on success or a negative error code on failure</returns>
    public static int av_samples_alloc(byte** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align)
    {
        _av_samples_alloc_cache ??= FunctionResolver.GetFunctionDelegate<av_samples_alloc_delegate>("avutil", "av_samples_alloc", ThrowErrorIfFunctionNotFound);
        if (_av_samples_alloc_cache == null)
            throw new NotSupportedException();
        return _av_samples_alloc_cache(@audio_data, @linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
    }
    
    /// <summary>Allocate a samples buffer for nb_samples samples, and fill data pointers and linesize accordingly. The allocated samples buffer can be freed by using av_freep(&amp;audio_data[0]) Allocated data will be initialized to silence.</summary>
    /// <param name="linesize">aligned size for audio buffer(s), may be NULL</param>
    /// <param name="nb_channels">number of audio channels</param>
    /// <param name="nb_samples">number of samples per channel</param>
    /// <param name="sample_fmt">the sample format</param>
    /// <param name="align">buffer size alignment (0 = default, 1 = no alignment)</param>
    /// <returns>&gt;=0 on success or a negative error code on failure</returns>
    public static int av_samples_alloc(ref byte* @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align)
    {
        fixed (byte** ptr = &@audio_data)
        {
            return av_samples_alloc(ptr, @linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_samples_alloc_array_and_samples_delegate(byte*** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
    private static av_samples_alloc_array_and_samples_delegate? _av_samples_alloc_array_and_samples_cache;
    
    /// <summary>Allocate a data pointers array, samples buffer for nb_samples samples, and fill data pointers and linesize accordingly.</summary>
    public static int av_samples_alloc_array_and_samples(byte*** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align)
    {
        _av_samples_alloc_array_and_samples_cache ??= FunctionResolver.GetFunctionDelegate<av_samples_alloc_array_and_samples_delegate>("avutil", "av_samples_alloc_array_and_samples", ThrowErrorIfFunctionNotFound);
        if (_av_samples_alloc_array_and_samples_cache == null)
            throw new NotSupportedException();
        return _av_samples_alloc_array_and_samples_cache(@audio_data, @linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
    }
    
    /// <summary>Allocate a data pointers array, samples buffer for nb_samples samples, and fill data pointers and linesize accordingly.</summary>
    public static int av_samples_alloc_array_and_samples(ref byte** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align)
    {
        fixed (byte*** ptr = &@audio_data)
        {
            return av_samples_alloc_array_and_samples(ptr, @linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_samples_copy_delegate(byte** @dst, byte** @src, int @dst_offset, int @src_offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt);
    private static av_samples_copy_delegate? _av_samples_copy_cache;
    
    /// <summary>Copy samples from src to dst.</summary>
    /// <param name="dst">destination array of pointers to data planes</param>
    /// <param name="src">source array of pointers to data planes</param>
    /// <param name="dst_offset">offset in samples at which the data will be written to dst</param>
    /// <param name="src_offset">offset in samples at which the data will be read from src</param>
    /// <param name="nb_samples">number of samples to be copied</param>
    /// <param name="nb_channels">number of audio channels</param>
    /// <param name="sample_fmt">audio sample format</param>
    public static int av_samples_copy(byte** @dst, byte** @src, int @dst_offset, int @src_offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt)
    {
        _av_samples_copy_cache ??= FunctionResolver.GetFunctionDelegate<av_samples_copy_delegate>("avutil", "av_samples_copy", ThrowErrorIfFunctionNotFound);
        if (_av_samples_copy_cache == null)
            throw new NotSupportedException();
        return _av_samples_copy_cache(@dst, @src, @dst_offset, @src_offset, @nb_samples, @nb_channels, @sample_fmt);
    }
    
    /// <summary>Copy samples from src to dst.</summary>
    /// <param name="src">source array of pointers to data planes</param>
    /// <param name="dst_offset">offset in samples at which the data will be written to dst</param>
    /// <param name="src_offset">offset in samples at which the data will be read from src</param>
    /// <param name="nb_samples">number of samples to be copied</param>
    /// <param name="nb_channels">number of audio channels</param>
    /// <param name="sample_fmt">audio sample format</param>
    public static int av_samples_copy(ref byte* @dst, byte** @src, int @dst_offset, int @src_offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt)
    {
        fixed (byte** ptr = &@dst)
        {
            return av_samples_copy(ptr, @src, @dst_offset, @src_offset, @nb_samples, @nb_channels, @sample_fmt);
        }
    }
    
    /// <summary>Copy samples from src to dst.</summary>
    /// <param name="dst">destination array of pointers to data planes</param>
    /// <param name="dst_offset">offset in samples at which the data will be written to dst</param>
    /// <param name="src_offset">offset in samples at which the data will be read from src</param>
    /// <param name="nb_samples">number of samples to be copied</param>
    /// <param name="nb_channels">number of audio channels</param>
    /// <param name="sample_fmt">audio sample format</param>
    public static int av_samples_copy(byte** @dst, ref byte* @src, int @dst_offset, int @src_offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt)
    {
        fixed (byte** ptr = &@src)
        {
            return av_samples_copy(@dst, ptr, @dst_offset, @src_offset, @nb_samples, @nb_channels, @sample_fmt);
        }
    }
    
    /// <summary>Copy samples from src to dst.</summary>
    /// <param name="dst_offset">offset in samples at which the data will be written to dst</param>
    /// <param name="src_offset">offset in samples at which the data will be read from src</param>
    /// <param name="nb_samples">number of samples to be copied</param>
    /// <param name="nb_channels">number of audio channels</param>
    /// <param name="sample_fmt">audio sample format</param>
    public static int av_samples_copy(ref byte* @dst, ref byte* @src, int @dst_offset, int @src_offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt)
    {
        fixed (byte** ptr1 = &@dst)
        {
        fixed (byte** ptr2 = &@src)
        {
                return av_samples_copy(ptr1, ptr2, @dst_offset, @src_offset, @nb_samples, @nb_channels, @sample_fmt);
        }
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_samples_fill_arrays_delegate(byte** @audio_data, int* @linesize, byte* @buf, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
    private static av_samples_fill_arrays_delegate? _av_samples_fill_arrays_cache;
    
    /// <summary>Fill plane data pointers and linesize for samples with sample format sample_fmt.</summary>
    /// <param name="audio_data">array to be filled with the pointer for each channel</param>
    /// <param name="linesize">calculated linesize, may be NULL</param>
    /// <param name="buf">the pointer to a buffer containing the samples</param>
    /// <param name="nb_channels">the number of channels</param>
    /// <param name="nb_samples">the number of samples in a single channel</param>
    /// <param name="sample_fmt">the sample format</param>
    /// <param name="align">buffer size alignment (0 = default, 1 = no alignment)</param>
    /// <returns>minimum size in bytes required for the buffer on success, or a negative error code on failure</returns>
    public static int av_samples_fill_arrays(byte** @audio_data, int* @linesize, byte* @buf, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align)
    {
        _av_samples_fill_arrays_cache ??= FunctionResolver.GetFunctionDelegate<av_samples_fill_arrays_delegate>("avutil", "av_samples_fill_arrays", ThrowErrorIfFunctionNotFound);
        if (_av_samples_fill_arrays_cache == null)
            throw new NotSupportedException();
        return _av_samples_fill_arrays_cache(@audio_data, @linesize, @buf, @nb_channels, @nb_samples, @sample_fmt, @align);
    }
    
    /// <summary>Fill plane data pointers and linesize for samples with sample format sample_fmt.</summary>
    /// <param name="linesize">calculated linesize, may be NULL</param>
    /// <param name="buf">the pointer to a buffer containing the samples</param>
    /// <param name="nb_channels">the number of channels</param>
    /// <param name="nb_samples">the number of samples in a single channel</param>
    /// <param name="sample_fmt">the sample format</param>
    /// <param name="align">buffer size alignment (0 = default, 1 = no alignment)</param>
    /// <returns>minimum size in bytes required for the buffer on success, or a negative error code on failure</returns>
    public static int av_samples_fill_arrays(ref byte* @audio_data, int* @linesize, byte* @buf, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align)
    {
        fixed (byte** ptr = &@audio_data)
        {
            return av_samples_fill_arrays(ptr, @linesize, @buf, @nb_channels, @nb_samples, @sample_fmt, @align);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_samples_get_buffer_size_delegate(int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
    private static av_samples_get_buffer_size_delegate? _av_samples_get_buffer_size_cache;
    
    /// <summary>Get the required buffer size for the given audio parameters.</summary>
    /// <param name="linesize">calculated linesize, may be NULL</param>
    /// <param name="nb_channels">the number of channels</param>
    /// <param name="nb_samples">the number of samples in a single channel</param>
    /// <param name="sample_fmt">the sample format</param>
    /// <param name="align">buffer size alignment (0 = default, 1 = no alignment)</param>
    /// <returns>required buffer size, or negative error code on failure</returns>
    public static int av_samples_get_buffer_size(int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align)
    {
        _av_samples_get_buffer_size_cache ??= FunctionResolver.GetFunctionDelegate<av_samples_get_buffer_size_delegate>("avutil", "av_samples_get_buffer_size", ThrowErrorIfFunctionNotFound);
        if (_av_samples_get_buffer_size_cache == null)
            throw new NotSupportedException();
        return _av_samples_get_buffer_size_cache(@linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_samples_set_silence_delegate(byte** @audio_data, int @offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt);
    private static av_samples_set_silence_delegate? _av_samples_set_silence_cache;
    
    /// <summary>Fill an audio buffer with silence.</summary>
    /// <param name="audio_data">array of pointers to data planes</param>
    /// <param name="offset">offset in samples at which to start filling</param>
    /// <param name="nb_samples">number of samples to fill</param>
    /// <param name="nb_channels">number of audio channels</param>
    /// <param name="sample_fmt">audio sample format</param>
    public static int av_samples_set_silence(byte** @audio_data, int @offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt)
    {
        _av_samples_set_silence_cache ??= FunctionResolver.GetFunctionDelegate<av_samples_set_silence_delegate>("avutil", "av_samples_set_silence", ThrowErrorIfFunctionNotFound);
        if (_av_samples_set_silence_cache == null)
            throw new NotSupportedException();
        return _av_samples_set_silence_cache(@audio_data, @offset, @nb_samples, @nb_channels, @sample_fmt);
    }
    
    /// <summary>Fill an audio buffer with silence.</summary>
    /// <param name="offset">offset in samples at which to start filling</param>
    /// <param name="nb_samples">number of samples to fill</param>
    /// <param name="nb_channels">number of audio channels</param>
    /// <param name="sample_fmt">audio sample format</param>
    public static int av_samples_set_silence(ref byte* @audio_data, int @offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt)
    {
        fixed (byte** ptr = &@audio_data)
        {
            return av_samples_set_silence(ptr, @offset, @nb_samples, @nb_channels, @sample_fmt);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_sdp_create_delegate(AVFormatContext** @ac, int @n_files, byte* @buf, int @size);
    private static av_sdp_create_delegate? _av_sdp_create_cache;
    
    /// <summary>Generate an SDP for an RTP session.</summary>
    /// <param name="ac">array of AVFormatContexts describing the RTP streams. If the array is composed by only one context, such context can contain multiple AVStreams (one AVStream per RTP stream). Otherwise, all the contexts in the array (an AVCodecContext per RTP stream) must contain only one AVStream.</param>
    /// <param name="n_files">number of AVCodecContexts contained in ac</param>
    /// <param name="buf">buffer where the SDP will be stored (must be allocated by the caller)</param>
    /// <param name="size">the size of the buffer</param>
    /// <returns>0 if OK, AVERROR_xxx on error</returns>
    public static int av_sdp_create(AVFormatContext** @ac, int @n_files, byte* @buf, int @size)
    {
        _av_sdp_create_cache ??= FunctionResolver.GetFunctionDelegate<av_sdp_create_delegate>("avformat", "av_sdp_create", ThrowErrorIfFunctionNotFound);
        if (_av_sdp_create_cache == null)
            throw new NotSupportedException();
        return _av_sdp_create_cache(@ac, @n_files, @buf, @size);
    }
    
    /// <summary>Generate an SDP for an RTP session.</summary>
    /// <param name="n_files">number of AVCodecContexts contained in ac</param>
    /// <param name="buf">buffer where the SDP will be stored (must be allocated by the caller)</param>
    /// <param name="size">the size of the buffer</param>
    /// <returns>0 if OK, AVERROR_xxx on error</returns>
    public static int av_sdp_create(ref AVFormatContext* @ac, int @n_files, byte* @buf, int @size)
    {
        fixed (AVFormatContext** ptr = &@ac)
        {
            return av_sdp_create(ptr, @n_files, @buf, @size);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_seek_frame_delegate(AVFormatContext* @s, int @stream_index, long @timestamp, int @flags);
    private static av_seek_frame_delegate? _av_seek_frame_cache;
    
    /// <summary>Seek to the keyframe at timestamp. &apos;timestamp&apos; in &apos;stream_index&apos;.</summary>
    /// <param name="s">media file handle</param>
    /// <param name="stream_index">If stream_index is (-1), a default stream is selected, and timestamp is automatically converted from AV_TIME_BASE units to the stream specific time_base.</param>
    /// <param name="timestamp">Timestamp in AVStream.time_base units or, if no stream is specified, in AV_TIME_BASE units.</param>
    /// <param name="flags">flags which select direction and seeking mode</param>
    /// <returns>&gt;= 0 on success</returns>
    public static int av_seek_frame(AVFormatContext* @s, int @stream_index, long @timestamp, int @flags)
    {
        _av_seek_frame_cache ??= FunctionResolver.GetFunctionDelegate<av_seek_frame_delegate>("avformat", "av_seek_frame", ThrowErrorIfFunctionNotFound);
        if (_av_seek_frame_cache == null)
            throw new NotSupportedException();
        return _av_seek_frame_cache(@s, @stream_index, @timestamp, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_set_options_string_delegate(void* @ctx,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @opts,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key_val_sep,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @pairs_sep);
    private static av_set_options_string_delegate? _av_set_options_string_cache;
    
    /// <summary>Parse the key/value pairs list in opts. For each key/value pair found, stores the value in the field in ctx that is named like the key. ctx must be an AVClass context, storing is done using AVOptions.</summary>
    /// <param name="opts">options string to parse, may be NULL</param>
    /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value</param>
    /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other</param>
    /// <returns>the number of successfully set key/value pairs, or a negative value corresponding to an AVERROR code in case of error: AVERROR(EINVAL) if opts cannot be parsed, the error code issued by av_opt_set() if a key/value pair cannot be set</returns>
    public static int av_set_options_string(void* @ctx,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @opts,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @key_val_sep,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @pairs_sep)
    {
        _av_set_options_string_cache ??= FunctionResolver.GetFunctionDelegate<av_set_options_string_delegate>("avutil", "av_set_options_string", ThrowErrorIfFunctionNotFound);
        if (_av_set_options_string_cache == null)
            throw new NotSupportedException();
        return _av_set_options_string_cache(@ctx, @opts, @key_val_sep, @pairs_sep);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_shrink_packet_delegate(AVPacket* @pkt, int @size);
    private static av_shrink_packet_delegate? _av_shrink_packet_cache;
    
    /// <summary>Reduce packet size, correctly zeroing padding</summary>
    /// <param name="pkt">packet</param>
    /// <param name="size">new size</param>
    public static void av_shrink_packet(AVPacket* @pkt, int @size)
    {
        _av_shrink_packet_cache ??= FunctionResolver.GetFunctionDelegate<av_shrink_packet_delegate>("avcodec", "av_shrink_packet", ThrowErrorIfFunctionNotFound);
        if (_av_shrink_packet_cache == null)
            throw new NotSupportedException();
        _av_shrink_packet_cache(@pkt, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_size_mult_delegate(ulong @a, ulong @b, ulong* @r);
    private static av_size_mult_delegate? _av_size_mult_cache;
    
    /// <summary>Multiply two `size_t` values checking for overflow.</summary>
    /// <param name="a">Operand of multiplication</param>
    /// <param name="b">Operand of multiplication</param>
    /// <param name="r">Pointer to the result of the operation</param>
    /// <returns>0 on success, AVERROR(EINVAL) on overflow</returns>
    public static int av_size_mult(ulong @a, ulong @b, ulong* @r)
    {
        _av_size_mult_cache ??= FunctionResolver.GetFunctionDelegate<av_size_mult_delegate>("avutil", "av_size_mult", ThrowErrorIfFunctionNotFound);
        if (_av_size_mult_cache == null)
            throw new NotSupportedException();
        return _av_size_mult_cache(@a, @b, @r);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte* av_strdup_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @s);
    private static av_strdup_delegate? _av_strdup_cache;
    
    /// <summary>Duplicate a string.</summary>
    /// <param name="s">String to be duplicated</param>
    /// <returns>Pointer to a newly-allocated string containing a copy of `s` or `NULL` if the string cannot be allocated</returns>
    public static byte* av_strdup(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @s)
    {
        _av_strdup_cache ??= FunctionResolver.GetFunctionDelegate<av_strdup_delegate>("avutil", "av_strdup", ThrowErrorIfFunctionNotFound);
        if (_av_strdup_cache == null)
            throw new NotSupportedException();
        return _av_strdup_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_stream_add_side_data_delegate(AVStream* @st, AVPacketSideDataType @type, byte* @data, ulong @size);
    private static av_stream_add_side_data_delegate? _av_stream_add_side_data_cache;
    
    /// <summary>Wrap an existing array as stream side data.</summary>
    /// <param name="st">stream</param>
    /// <param name="type">side information type</param>
    /// <param name="data">the side data array. It must be allocated with the av_malloc() family of functions. The ownership of the data is transferred to st.</param>
    /// <param name="size">side information size</param>
    /// <returns>zero on success, a negative AVERROR code on failure. On failure, the stream is unchanged and the data remains owned by the caller.</returns>
    [Obsolete("use av_packet_side_data_add() with the stream's  \"codecpar side data\"")]
    public static int av_stream_add_side_data(AVStream* @st, AVPacketSideDataType @type, byte* @data, ulong @size)
    {
        _av_stream_add_side_data_cache ??= FunctionResolver.GetFunctionDelegate<av_stream_add_side_data_delegate>("avformat", "av_stream_add_side_data", ThrowErrorIfFunctionNotFound);
        if (_av_stream_add_side_data_cache == null)
            throw new NotSupportedException();
        return _av_stream_add_side_data_cache(@st, @type, @data, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVClass* av_stream_get_class_delegate();
    private static av_stream_get_class_delegate? _av_stream_get_class_cache;
    
    /// <summary>Get the AVClass for AVStream. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
    public static AVClass* av_stream_get_class()
    {
        _av_stream_get_class_cache ??= FunctionResolver.GetFunctionDelegate<av_stream_get_class_delegate>("avformat", "av_stream_get_class", ThrowErrorIfFunctionNotFound);
        if (_av_stream_get_class_cache == null)
            throw new NotSupportedException();
        return _av_stream_get_class_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVRational av_stream_get_codec_timebase_delegate(AVStream* @st);
    private static av_stream_get_codec_timebase_delegate? _av_stream_get_codec_timebase_cache;
    
    [Obsolete("do not call this function")]
    public static AVRational av_stream_get_codec_timebase(AVStream* @st)
    {
        _av_stream_get_codec_timebase_cache ??= FunctionResolver.GetFunctionDelegate<av_stream_get_codec_timebase_delegate>("avformat", "av_stream_get_codec_timebase", ThrowErrorIfFunctionNotFound);
        if (_av_stream_get_codec_timebase_cache == null)
            throw new NotSupportedException();
        return _av_stream_get_codec_timebase_cache(@st);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodecParserContext* av_stream_get_parser_delegate(AVStream* @s);
    private static av_stream_get_parser_delegate? _av_stream_get_parser_cache;
    
    public static AVCodecParserContext* av_stream_get_parser(AVStream* @s)
    {
        _av_stream_get_parser_cache ??= FunctionResolver.GetFunctionDelegate<av_stream_get_parser_delegate>("avformat", "av_stream_get_parser", ThrowErrorIfFunctionNotFound);
        if (_av_stream_get_parser_cache == null)
            throw new NotSupportedException();
        return _av_stream_get_parser_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte* av_stream_get_side_data_delegate(AVStream* @stream, AVPacketSideDataType @type, ulong* @size);
    private static av_stream_get_side_data_delegate? _av_stream_get_side_data_cache;
    
    /// <summary>Get side information from stream.</summary>
    /// <param name="stream">stream</param>
    /// <param name="type">desired side information type</param>
    /// <param name="size">If supplied, *size will be set to the size of the side data or to zero if the desired side data is not present.</param>
    /// <returns>pointer to data if present or NULL otherwise</returns>
    [Obsolete("use av_packet_side_data_get() with the stream's  \"codecpar side data\"")]
    public static byte* av_stream_get_side_data(AVStream* @stream, AVPacketSideDataType @type, ulong* @size)
    {
        _av_stream_get_side_data_cache ??= FunctionResolver.GetFunctionDelegate<av_stream_get_side_data_delegate>("avformat", "av_stream_get_side_data", ThrowErrorIfFunctionNotFound);
        if (_av_stream_get_side_data_cache == null)
            throw new NotSupportedException();
        return _av_stream_get_side_data_cache(@stream, @type, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVClass* av_stream_group_get_class_delegate();
    private static av_stream_group_get_class_delegate? _av_stream_group_get_class_cache;
    
    /// <summary>Get the AVClass for AVStreamGroup. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
    public static AVClass* av_stream_group_get_class()
    {
        _av_stream_group_get_class_cache ??= FunctionResolver.GetFunctionDelegate<av_stream_group_get_class_delegate>("avformat", "av_stream_group_get_class", ThrowErrorIfFunctionNotFound);
        if (_av_stream_group_get_class_cache == null)
            throw new NotSupportedException();
        return _av_stream_group_get_class_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte* av_stream_new_side_data_delegate(AVStream* @stream, AVPacketSideDataType @type, ulong @size);
    private static av_stream_new_side_data_delegate? _av_stream_new_side_data_cache;
    
    /// <summary>Allocate new information from stream.</summary>
    /// <param name="stream">stream</param>
    /// <param name="type">desired side information type</param>
    /// <param name="size">side information size</param>
    /// <returns>pointer to fresh allocated data or NULL otherwise</returns>
    [Obsolete("use av_packet_side_data_new() with the stream's  \"codecpar side data\"")]
    public static byte* av_stream_new_side_data(AVStream* @stream, AVPacketSideDataType @type, ulong @size)
    {
        _av_stream_new_side_data_cache ??= FunctionResolver.GetFunctionDelegate<av_stream_new_side_data_delegate>("avformat", "av_stream_new_side_data", ThrowErrorIfFunctionNotFound);
        if (_av_stream_new_side_data_cache == null)
            throw new NotSupportedException();
        return _av_stream_new_side_data_cache(@stream, @type, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_strerror_delegate(int @errnum, byte* @errbuf, ulong @errbuf_size);
    private static av_strerror_delegate? _av_strerror_cache;
    
    /// <summary>Put a description of the AVERROR code errnum in errbuf. In case of failure the global variable errno is set to indicate the error. Even in case of failure av_strerror() will print a generic error message indicating the errnum provided to errbuf.</summary>
    /// <param name="errnum">error code to describe</param>
    /// <param name="errbuf">buffer to which description is written</param>
    /// <param name="errbuf_size">the size in bytes of errbuf</param>
    /// <returns>0 on success, a negative value if a description for errnum cannot be found</returns>
    public static int av_strerror(int @errnum, byte* @errbuf, ulong @errbuf_size)
    {
        _av_strerror_cache ??= FunctionResolver.GetFunctionDelegate<av_strerror_delegate>("avutil", "av_strerror", ThrowErrorIfFunctionNotFound);
        if (_av_strerror_cache == null)
            throw new NotSupportedException();
        return _av_strerror_cache(@errnum, @errbuf, @errbuf_size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte* av_strndup_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @s, ulong @len);
    private static av_strndup_delegate? _av_strndup_cache;
    
    /// <summary>Duplicate a substring of a string.</summary>
    /// <param name="s">String to be duplicated</param>
    /// <param name="len">Maximum length of the resulting string (not counting the terminating byte)</param>
    /// <returns>Pointer to a newly-allocated string containing a substring of `s` or `NULL` if the string cannot be allocated</returns>
    public static byte* av_strndup(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @s, ulong @len)
    {
        _av_strndup_cache ??= FunctionResolver.GetFunctionDelegate<av_strndup_delegate>("avutil", "av_strndup", ThrowErrorIfFunctionNotFound);
        if (_av_strndup_cache == null)
            throw new NotSupportedException();
        return _av_strndup_cache(@s, @len);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVRational av_sub_q_delegate(AVRational @b, AVRational @c);
    private static av_sub_q_delegate? _av_sub_q_cache;
    
    /// <summary>Subtract one rational from another.</summary>
    /// <param name="b">First rational</param>
    /// <param name="c">Second rational</param>
    /// <returns>b-c</returns>
    public static AVRational av_sub_q(AVRational @b, AVRational @c)
    {
        _av_sub_q_cache ??= FunctionResolver.GetFunctionDelegate<av_sub_q_delegate>("avutil", "av_sub_q", ThrowErrorIfFunctionNotFound);
        if (_av_sub_q_cache == null)
            throw new NotSupportedException();
        return _av_sub_q_cache(@b, @c);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_timecode_adjust_ntsc_framenum2_delegate(int @framenum, int @fps);
    private static av_timecode_adjust_ntsc_framenum2_delegate? _av_timecode_adjust_ntsc_framenum2_cache;
    
    /// <summary>Adjust frame number for NTSC drop frame time code.</summary>
    /// <param name="framenum">frame number to adjust</param>
    /// <param name="fps">frame per second, multiples of 30</param>
    /// <returns>adjusted frame number</returns>
    public static int av_timecode_adjust_ntsc_framenum2(int @framenum, int @fps)
    {
        _av_timecode_adjust_ntsc_framenum2_cache ??= FunctionResolver.GetFunctionDelegate<av_timecode_adjust_ntsc_framenum2_delegate>("avutil", "av_timecode_adjust_ntsc_framenum2", ThrowErrorIfFunctionNotFound);
        if (_av_timecode_adjust_ntsc_framenum2_cache == null)
            throw new NotSupportedException();
        return _av_timecode_adjust_ntsc_framenum2_cache(@framenum, @fps);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_timecode_check_frame_rate_delegate(AVRational @rate);
    private static av_timecode_check_frame_rate_delegate? _av_timecode_check_frame_rate_cache;
    
    /// <summary>Check if the timecode feature is available for the given frame rate</summary>
    /// <returns>0 if supported, &lt; 0 otherwise</returns>
    public static int av_timecode_check_frame_rate(AVRational @rate)
    {
        _av_timecode_check_frame_rate_cache ??= FunctionResolver.GetFunctionDelegate<av_timecode_check_frame_rate_delegate>("avutil", "av_timecode_check_frame_rate", ThrowErrorIfFunctionNotFound);
        if (_av_timecode_check_frame_rate_cache == null)
            throw new NotSupportedException();
        return _av_timecode_check_frame_rate_cache(@rate);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint av_timecode_get_smpte_delegate(AVRational @rate, int @drop, int @hh, int @mm, int @ss, int @ff);
    private static av_timecode_get_smpte_delegate? _av_timecode_get_smpte_cache;
    
    /// <summary>Convert sei info to SMPTE 12M binary representation.</summary>
    /// <param name="rate">frame rate in rational form</param>
    /// <param name="drop">drop flag</param>
    /// <param name="hh">hour</param>
    /// <param name="mm">minute</param>
    /// <param name="ss">second</param>
    /// <param name="ff">frame number</param>
    /// <returns>the SMPTE binary representation</returns>
    public static uint av_timecode_get_smpte(AVRational @rate, int @drop, int @hh, int @mm, int @ss, int @ff)
    {
        _av_timecode_get_smpte_cache ??= FunctionResolver.GetFunctionDelegate<av_timecode_get_smpte_delegate>("avutil", "av_timecode_get_smpte", ThrowErrorIfFunctionNotFound);
        if (_av_timecode_get_smpte_cache == null)
            throw new NotSupportedException();
        return _av_timecode_get_smpte_cache(@rate, @drop, @hh, @mm, @ss, @ff);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint av_timecode_get_smpte_from_framenum_delegate(AVTimecode* @tc, int @framenum);
    private static av_timecode_get_smpte_from_framenum_delegate? _av_timecode_get_smpte_from_framenum_cache;
    
    /// <summary>Convert frame number to SMPTE 12M binary representation.</summary>
    /// <param name="tc">timecode data correctly initialized</param>
    /// <param name="framenum">frame number</param>
    /// <returns>the SMPTE binary representation</returns>
    public static uint av_timecode_get_smpte_from_framenum(AVTimecode* @tc, int @framenum)
    {
        _av_timecode_get_smpte_from_framenum_cache ??= FunctionResolver.GetFunctionDelegate<av_timecode_get_smpte_from_framenum_delegate>("avutil", "av_timecode_get_smpte_from_framenum", ThrowErrorIfFunctionNotFound);
        if (_av_timecode_get_smpte_from_framenum_cache == null)
            throw new NotSupportedException();
        return _av_timecode_get_smpte_from_framenum_cache(@tc, @framenum);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_timecode_init_delegate(AVTimecode* @tc, AVRational @rate, int @flags, int @frame_start, void* @log_ctx);
    private static av_timecode_init_delegate? _av_timecode_init_cache;
    
    /// <summary>Init a timecode struct with the passed parameters.</summary>
    /// <param name="tc">pointer to an allocated AVTimecode</param>
    /// <param name="rate">frame rate in rational form</param>
    /// <param name="flags">miscellaneous flags such as drop frame, +24 hours, ... (see AVTimecodeFlag)</param>
    /// <param name="frame_start">the first frame number</param>
    /// <param name="log_ctx">a pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct (used for av_log)</param>
    /// <returns>0 on success, AVERROR otherwise</returns>
    public static int av_timecode_init(AVTimecode* @tc, AVRational @rate, int @flags, int @frame_start, void* @log_ctx)
    {
        _av_timecode_init_cache ??= FunctionResolver.GetFunctionDelegate<av_timecode_init_delegate>("avutil", "av_timecode_init", ThrowErrorIfFunctionNotFound);
        if (_av_timecode_init_cache == null)
            throw new NotSupportedException();
        return _av_timecode_init_cache(@tc, @rate, @flags, @frame_start, @log_ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_timecode_init_from_components_delegate(AVTimecode* @tc, AVRational @rate, int @flags, int @hh, int @mm, int @ss, int @ff, void* @log_ctx);
    private static av_timecode_init_from_components_delegate? _av_timecode_init_from_components_cache;
    
    /// <summary>Init a timecode struct from the passed timecode components.</summary>
    /// <param name="tc">pointer to an allocated AVTimecode</param>
    /// <param name="rate">frame rate in rational form</param>
    /// <param name="flags">miscellaneous flags such as drop frame, +24 hours, ... (see AVTimecodeFlag)</param>
    /// <param name="hh">hours</param>
    /// <param name="mm">minutes</param>
    /// <param name="ss">seconds</param>
    /// <param name="ff">frames</param>
    /// <param name="log_ctx">a pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct (used for av_log)</param>
    /// <returns>0 on success, AVERROR otherwise</returns>
    public static int av_timecode_init_from_components(AVTimecode* @tc, AVRational @rate, int @flags, int @hh, int @mm, int @ss, int @ff, void* @log_ctx)
    {
        _av_timecode_init_from_components_cache ??= FunctionResolver.GetFunctionDelegate<av_timecode_init_from_components_delegate>("avutil", "av_timecode_init_from_components", ThrowErrorIfFunctionNotFound);
        if (_av_timecode_init_from_components_cache == null)
            throw new NotSupportedException();
        return _av_timecode_init_from_components_cache(@tc, @rate, @flags, @hh, @mm, @ss, @ff, @log_ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_timecode_init_from_string_delegate(AVTimecode* @tc, AVRational @rate,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str, void* @log_ctx);
    private static av_timecode_init_from_string_delegate? _av_timecode_init_from_string_cache;
    
    /// <summary>Parse timecode representation (hh:mm:ss[:;.]ff).</summary>
    /// <param name="tc">pointer to an allocated AVTimecode</param>
    /// <param name="rate">frame rate in rational form</param>
    /// <param name="str">timecode string which will determine the frame start</param>
    /// <param name="log_ctx">a pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct (used for av_log).</param>
    /// <returns>0 on success, AVERROR otherwise</returns>
    public static int av_timecode_init_from_string(AVTimecode* @tc, AVRational @rate,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str, void* @log_ctx)
    {
        _av_timecode_init_from_string_cache ??= FunctionResolver.GetFunctionDelegate<av_timecode_init_from_string_delegate>("avutil", "av_timecode_init_from_string", ThrowErrorIfFunctionNotFound);
        if (_av_timecode_init_from_string_cache == null)
            throw new NotSupportedException();
        return _av_timecode_init_from_string_cache(@tc, @rate, @str, @log_ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte* av_timecode_make_mpeg_tc_string_delegate(byte* @buf, uint @tc25bit);
    private static av_timecode_make_mpeg_tc_string_delegate? _av_timecode_make_mpeg_tc_string_cache;
    
    /// <summary>Get the timecode string from the 25-bit timecode format (MPEG GOP format).</summary>
    /// <param name="buf">destination buffer, must be at least AV_TIMECODE_STR_SIZE long</param>
    /// <param name="tc25bit">the 25-bits timecode</param>
    /// <returns>the buf parameter</returns>
    public static byte* av_timecode_make_mpeg_tc_string(byte* @buf, uint @tc25bit)
    {
        _av_timecode_make_mpeg_tc_string_cache ??= FunctionResolver.GetFunctionDelegate<av_timecode_make_mpeg_tc_string_delegate>("avutil", "av_timecode_make_mpeg_tc_string", ThrowErrorIfFunctionNotFound);
        if (_av_timecode_make_mpeg_tc_string_cache == null)
            throw new NotSupportedException();
        return _av_timecode_make_mpeg_tc_string_cache(@buf, @tc25bit);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte* av_timecode_make_smpte_tc_string_delegate(byte* @buf, uint @tcsmpte, int @prevent_df);
    private static av_timecode_make_smpte_tc_string_delegate? _av_timecode_make_smpte_tc_string_cache;
    
    /// <summary>Get the timecode string from the SMPTE timecode format.</summary>
    /// <param name="buf">destination buffer, must be at least AV_TIMECODE_STR_SIZE long</param>
    /// <param name="tcsmpte">the 32-bit SMPTE timecode</param>
    /// <param name="prevent_df">prevent the use of a drop flag when it is known the DF bit is arbitrary</param>
    /// <returns>the buf parameter</returns>
    public static byte* av_timecode_make_smpte_tc_string(byte* @buf, uint @tcsmpte, int @prevent_df)
    {
        _av_timecode_make_smpte_tc_string_cache ??= FunctionResolver.GetFunctionDelegate<av_timecode_make_smpte_tc_string_delegate>("avutil", "av_timecode_make_smpte_tc_string", ThrowErrorIfFunctionNotFound);
        if (_av_timecode_make_smpte_tc_string_cache == null)
            throw new NotSupportedException();
        return _av_timecode_make_smpte_tc_string_cache(@buf, @tcsmpte, @prevent_df);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte* av_timecode_make_smpte_tc_string2_delegate(byte* @buf, AVRational @rate, uint @tcsmpte, int @prevent_df, int @skip_field);
    private static av_timecode_make_smpte_tc_string2_delegate? _av_timecode_make_smpte_tc_string2_cache;
    
    /// <summary>Get the timecode string from the SMPTE timecode format.</summary>
    /// <param name="buf">destination buffer, must be at least AV_TIMECODE_STR_SIZE long</param>
    /// <param name="rate">frame rate of the timecode</param>
    /// <param name="tcsmpte">the 32-bit SMPTE timecode</param>
    /// <param name="prevent_df">prevent the use of a drop flag when it is known the DF bit is arbitrary</param>
    /// <param name="skip_field">prevent the use of a field flag when it is known the field bit is arbitrary (e.g. because it is used as PC flag)</param>
    /// <returns>the buf parameter</returns>
    public static byte* av_timecode_make_smpte_tc_string2(byte* @buf, AVRational @rate, uint @tcsmpte, int @prevent_df, int @skip_field)
    {
        _av_timecode_make_smpte_tc_string2_cache ??= FunctionResolver.GetFunctionDelegate<av_timecode_make_smpte_tc_string2_delegate>("avutil", "av_timecode_make_smpte_tc_string2", ThrowErrorIfFunctionNotFound);
        if (_av_timecode_make_smpte_tc_string2_cache == null)
            throw new NotSupportedException();
        return _av_timecode_make_smpte_tc_string2_cache(@buf, @rate, @tcsmpte, @prevent_df, @skip_field);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte* av_timecode_make_string_delegate(AVTimecode* @tc, byte* @buf, int @framenum);
    private static av_timecode_make_string_delegate? _av_timecode_make_string_cache;
    
    /// <summary>Load timecode string in buf.</summary>
    /// <param name="tc">timecode data correctly initialized</param>
    /// <param name="buf">destination buffer, must be at least AV_TIMECODE_STR_SIZE long</param>
    /// <param name="framenum">frame number</param>
    /// <returns>the buf parameter</returns>
    public static byte* av_timecode_make_string(AVTimecode* @tc, byte* @buf, int @framenum)
    {
        _av_timecode_make_string_cache ??= FunctionResolver.GetFunctionDelegate<av_timecode_make_string_delegate>("avutil", "av_timecode_make_string", ThrowErrorIfFunctionNotFound);
        if (_av_timecode_make_string_cache == null)
            throw new NotSupportedException();
        return _av_timecode_make_string_cache(@tc, @buf, @framenum);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_tree_destroy_delegate(AVTreeNode* @t);
    private static av_tree_destroy_delegate? _av_tree_destroy_cache;
    
    public static void av_tree_destroy(AVTreeNode* @t)
    {
        _av_tree_destroy_cache ??= FunctionResolver.GetFunctionDelegate<av_tree_destroy_delegate>("avutil", "av_tree_destroy", ThrowErrorIfFunctionNotFound);
        if (_av_tree_destroy_cache == null)
            throw new NotSupportedException();
        _av_tree_destroy_cache(@t);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_tree_enumerate_delegate(AVTreeNode* @t, void* @opaque, av_tree_enumerate_cmp_func @cmp, av_tree_enumerate_enu_func @enu);
    private static av_tree_enumerate_delegate? _av_tree_enumerate_cache;
    
    /// <summary>Apply enu(opaque, &amp;elem) to all the elements in the tree in a given range.</summary>
    /// <param name="cmp">a comparison function that returns &lt; 0 for an element below the range, &gt; 0 for an element above the range and == 0 for an element inside the range</param>
    public static void av_tree_enumerate(AVTreeNode* @t, void* @opaque, av_tree_enumerate_cmp_func @cmp, av_tree_enumerate_enu_func @enu)
    {
        _av_tree_enumerate_cache ??= FunctionResolver.GetFunctionDelegate<av_tree_enumerate_delegate>("avutil", "av_tree_enumerate", ThrowErrorIfFunctionNotFound);
        if (_av_tree_enumerate_cache == null)
            throw new NotSupportedException();
        _av_tree_enumerate_cache(@t, @opaque, @cmp, @enu);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* av_tree_find_delegate(AVTreeNode* @root, void* @key, av_tree_find_cmp_func @cmp, ref void_ptrArray2 @next);
    private static av_tree_find_delegate? _av_tree_find_cache;
    
    /// <summary>Find an element.</summary>
    /// <param name="root">a pointer to the root node of the tree</param>
    /// <param name="cmp">compare function used to compare elements in the tree, API identical to that of Standard C&apos;s qsort It is guaranteed that the first and only the first argument to cmp() will be the key parameter to av_tree_find(), thus it could if the user wants, be a different type (like an opaque context).</param>
    /// <param name="next">If next is not NULL, then next[0] will contain the previous element and next[1] the next element. If either does not exist, then the corresponding entry in next is unchanged.</param>
    /// <returns>An element with cmp(key, elem) == 0 or NULL if no such element exists in the tree.</returns>
    public static void* av_tree_find(AVTreeNode* @root, void* @key, av_tree_find_cmp_func @cmp, ref void_ptrArray2 @next)
    {
        _av_tree_find_cache ??= FunctionResolver.GetFunctionDelegate<av_tree_find_delegate>("avutil", "av_tree_find", ThrowErrorIfFunctionNotFound);
        if (_av_tree_find_cache == null)
            throw new NotSupportedException();
        return _av_tree_find_cache(@root, @key, @cmp, ref @next);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* av_tree_insert_delegate(AVTreeNode** @rootp, void* @key, av_tree_insert_cmp_func @cmp, AVTreeNode** @next);
    private static av_tree_insert_delegate? _av_tree_insert_cache;
    
    /// <summary>Insert or remove an element.</summary>
    /// <param name="rootp">A pointer to a pointer to the root node of the tree; note that the root node can change during insertions, this is required to keep the tree balanced.</param>
    /// <param name="key">pointer to the element key to insert in the tree</param>
    /// <param name="cmp">compare function used to compare elements in the tree, API identical to that of Standard C&apos;s qsort</param>
    /// <param name="next">Used to allocate and free AVTreeNodes. For insertion the user must set it to an allocated and zeroed object of at least av_tree_node_size bytes size. av_tree_insert() will set it to NULL if it has been consumed. For deleting elements *next is set to NULL by the user and av_tree_insert() will set it to the AVTreeNode which was used for the removed element. This allows the use of flat arrays, which have lower overhead compared to many malloced elements. You might want to define a function like:</param>
    /// <returns>If no insertion happened, the found element; if an insertion or removal happened, then either key or NULL will be returned. Which one it is depends on the tree state and the implementation. You should make no assumptions that it&apos;s one or the other in the code.</returns>
    public static void* av_tree_insert(AVTreeNode** @rootp, void* @key, av_tree_insert_cmp_func @cmp, AVTreeNode** @next)
    {
        _av_tree_insert_cache ??= FunctionResolver.GetFunctionDelegate<av_tree_insert_delegate>("avutil", "av_tree_insert", ThrowErrorIfFunctionNotFound);
        if (_av_tree_insert_cache == null)
            throw new NotSupportedException();
        return _av_tree_insert_cache(@rootp, @key, @cmp, @next);
    }
    
    /// <summary>Insert or remove an element.</summary>
    /// <param name="key">pointer to the element key to insert in the tree</param>
    /// <param name="cmp">compare function used to compare elements in the tree, API identical to that of Standard C&apos;s qsort</param>
    /// <param name="next">Used to allocate and free AVTreeNodes. For insertion the user must set it to an allocated and zeroed object of at least av_tree_node_size bytes size. av_tree_insert() will set it to NULL if it has been consumed. For deleting elements *next is set to NULL by the user and av_tree_insert() will set it to the AVTreeNode which was used for the removed element. This allows the use of flat arrays, which have lower overhead compared to many malloced elements. You might want to define a function like:</param>
    /// <returns>If no insertion happened, the found element; if an insertion or removal happened, then either key or NULL will be returned. Which one it is depends on the tree state and the implementation. You should make no assumptions that it&apos;s one or the other in the code.</returns>
    public static void* av_tree_insert(ref AVTreeNode* @rootp, void* @key, av_tree_insert_cmp_func @cmp, AVTreeNode** @next)
    {
        fixed (AVTreeNode** ptr = &@rootp)
        {
            return av_tree_insert(ptr, @key, @cmp, @next);
        }
    }
    
    /// <summary>Insert or remove an element.</summary>
    /// <param name="rootp">A pointer to a pointer to the root node of the tree; note that the root node can change during insertions, this is required to keep the tree balanced.</param>
    /// <param name="key">pointer to the element key to insert in the tree</param>
    /// <param name="cmp">compare function used to compare elements in the tree, API identical to that of Standard C&apos;s qsort</param>
    /// <returns>If no insertion happened, the found element; if an insertion or removal happened, then either key or NULL will be returned. Which one it is depends on the tree state and the implementation. You should make no assumptions that it&apos;s one or the other in the code.</returns>
    public static void* av_tree_insert(AVTreeNode** @rootp, void* @key, av_tree_insert_cmp_func @cmp, ref AVTreeNode* @next)
    {
        fixed (AVTreeNode** ptr = &@next)
        {
            return av_tree_insert(@rootp, @key, @cmp, ptr);
        }
    }
    
    /// <summary>Insert or remove an element.</summary>
    /// <param name="key">pointer to the element key to insert in the tree</param>
    /// <param name="cmp">compare function used to compare elements in the tree, API identical to that of Standard C&apos;s qsort</param>
    /// <returns>If no insertion happened, the found element; if an insertion or removal happened, then either key or NULL will be returned. Which one it is depends on the tree state and the implementation. You should make no assumptions that it&apos;s one or the other in the code.</returns>
    public static void* av_tree_insert(ref AVTreeNode* @rootp, void* @key, av_tree_insert_cmp_func @cmp, ref AVTreeNode* @next)
    {
        fixed (AVTreeNode** ptr1 = &@rootp)
        {
        fixed (AVTreeNode** ptr2 = &@next)
        {
                return av_tree_insert(ptr1, @key, @cmp, ptr2);
        }
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVTreeNode* av_tree_node_alloc_delegate();
    private static av_tree_node_alloc_delegate? _av_tree_node_alloc_cache;
    
    /// <summary>Allocate an AVTreeNode.</summary>
    public static AVTreeNode* av_tree_node_alloc()
    {
        _av_tree_node_alloc_cache ??= FunctionResolver.GetFunctionDelegate<av_tree_node_alloc_delegate>("avutil", "av_tree_node_alloc", ThrowErrorIfFunctionNotFound);
        if (_av_tree_node_alloc_cache == null)
            throw new NotSupportedException();
        return _av_tree_node_alloc_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_url_split_delegate(byte* @proto, int @proto_size, byte* @authorization, int @authorization_size, byte* @hostname, int @hostname_size, int* @port_ptr, byte* @path, int @path_size,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url);
    private static av_url_split_delegate? _av_url_split_cache;
    
    /// <summary>Split a URL string into components.</summary>
    /// <param name="proto">the buffer for the protocol</param>
    /// <param name="proto_size">the size of the proto buffer</param>
    /// <param name="authorization">the buffer for the authorization</param>
    /// <param name="authorization_size">the size of the authorization buffer</param>
    /// <param name="hostname">the buffer for the host name</param>
    /// <param name="hostname_size">the size of the hostname buffer</param>
    /// <param name="port_ptr">a pointer to store the port number in</param>
    /// <param name="path">the buffer for the path</param>
    /// <param name="path_size">the size of the path buffer</param>
    /// <param name="url">the URL to split</param>
    public static void av_url_split(byte* @proto, int @proto_size, byte* @authorization, int @authorization_size, byte* @hostname, int @hostname_size, int* @port_ptr, byte* @path, int @path_size,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url)
    {
        _av_url_split_cache ??= FunctionResolver.GetFunctionDelegate<av_url_split_delegate>("avformat", "av_url_split", ThrowErrorIfFunctionNotFound);
        if (_av_url_split_cache == null)
            throw new NotSupportedException();
        _av_url_split_cache(@proto, @proto_size, @authorization, @authorization_size, @hostname, @hostname_size, @port_ptr, @path, @path_size, @url);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_usleep_delegate(uint @usec);
    private static av_usleep_delegate? _av_usleep_cache;
    
    /// <summary>Sleep for a period of time. Although the duration is expressed in microseconds, the actual delay may be rounded to the precision of the system timer.</summary>
    /// <param name="usec">Number of microseconds to sleep.</param>
    /// <returns>zero on success or (negative) error code.</returns>
    public static int av_usleep(uint @usec)
    {
        _av_usleep_cache ??= FunctionResolver.GetFunctionDelegate<av_usleep_delegate>("avutil", "av_usleep", ThrowErrorIfFunctionNotFound);
        if (_av_usleep_cache == null)
            throw new NotSupportedException();
        return _av_usleep_cache(@usec);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string av_version_info_delegate();
    private static av_version_info_delegate? _av_version_info_cache;
    
    /// <summary>Return an informative version string. This usually is the actual release version number or a git commit description. This string has no fixed format and can change any time. It should never be parsed by code.</summary>
    public static string av_version_info()
    {
        _av_version_info_cache ??= FunctionResolver.GetFunctionDelegate<av_version_info_delegate>("avutil", "av_version_info", ThrowErrorIfFunctionNotFound);
        if (_av_version_info_cache == null)
            throw new NotSupportedException();
        return _av_version_info_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_vlog_delegate(void* @avcl, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @vl);
    private static av_vlog_delegate? _av_vlog_cache;
    
    /// <summary>Send the specified message to the log if the level is less than or equal to the current av_log_level. By default, all logging messages are sent to stderr. This behavior can be altered by setting a different logging callback function.</summary>
    /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
    /// <param name="level">The importance level of the message expressed using a &quot;Logging Constant&quot;.</param>
    /// <param name="fmt">The format string (printf-compatible) that specifies how subsequent arguments are converted to output.</param>
    /// <param name="vl">The arguments referenced by the format string.</param>
    public static void av_vlog(void* @avcl, int @level,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @vl)
    {
        _av_vlog_cache ??= FunctionResolver.GetFunctionDelegate<av_vlog_delegate>("avutil", "av_vlog", ThrowErrorIfFunctionNotFound);
        if (_av_vlog_cache == null)
            throw new NotSupportedException();
        _av_vlog_cache(@avcl, @level, @fmt, @vl);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_write_frame_delegate(AVFormatContext* @s, AVPacket* @pkt);
    private static av_write_frame_delegate? _av_write_frame_cache;
    
    /// <summary>Write a packet to an output media file.</summary>
    /// <param name="s">media file handle</param>
    /// <param name="pkt">The packet containing the data to be written. Note that unlike av_interleaved_write_frame(), this function does not take ownership of the packet passed to it (though some muxers may make an internal reference to the input packet). This parameter can be NULL (at any time, not just at the end), in order to immediately flush data buffered within the muxer, for muxers that buffer up data internally before writing it to the output. Packet&apos;s &quot;stream_index&quot; field must be set to the index of the corresponding stream in &quot;s-&gt;streams&quot;. The timestamps ( &quot;pts&quot;, &quot;dts&quot;) must be set to correct values in the stream&apos;s timebase (unless the output format is flagged with the AVFMT_NOTIMESTAMPS flag, then they can be set to AV_NOPTS_VALUE). The dts for subsequent packets passed to this function must be strictly increasing when compared in their respective timebases (unless the output format is flagged with the AVFMT_TS_NONSTRICT, then they merely have to be nondecreasing). &quot;duration&quot;) should also be set if known.</param>
    /// <returns>&lt; 0 on error, = 0 if OK, 1 if flushed and there is no more data to flush</returns>
    public static int av_write_frame(AVFormatContext* @s, AVPacket* @pkt)
    {
        _av_write_frame_cache ??= FunctionResolver.GetFunctionDelegate<av_write_frame_delegate>("avformat", "av_write_frame", ThrowErrorIfFunctionNotFound);
        if (_av_write_frame_cache == null)
            throw new NotSupportedException();
        return _av_write_frame_cache(@s, @pkt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_write_image_line_delegate(ushort* @src, ref byte_ptrArray4 @data, in int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w);
    private static av_write_image_line_delegate? _av_write_image_line_cache;
    
    public static void av_write_image_line(ushort* @src, ref byte_ptrArray4 @data, in int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w)
    {
        _av_write_image_line_cache ??= FunctionResolver.GetFunctionDelegate<av_write_image_line_delegate>("avutil", "av_write_image_line", ThrowErrorIfFunctionNotFound);
        if (_av_write_image_line_cache == null)
            throw new NotSupportedException();
        _av_write_image_line_cache(@src, ref @data, @linesize, @desc, @x, @y, @c, @w);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void av_write_image_line2_delegate(void* @src, ref byte_ptrArray4 @data, in int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @src_element_size);
    private static av_write_image_line2_delegate? _av_write_image_line2_cache;
    
    /// <summary>Write the values from src to the pixel format component c of an image line.</summary>
    /// <param name="src">array containing the values to write</param>
    /// <param name="data">the array containing the pointers to the planes of the image to write into. It is supposed to be zeroed.</param>
    /// <param name="linesize">the array containing the linesizes of the image</param>
    /// <param name="desc">the pixel format descriptor for the image</param>
    /// <param name="x">the horizontal coordinate of the first pixel to write</param>
    /// <param name="y">the vertical coordinate of the first pixel to write</param>
    /// <param name="w">the width of the line to write, that is the number of values to write to the image line</param>
    /// <param name="src_element_size">size of elements in src array (2 or 4 byte)</param>
    public static void av_write_image_line2(void* @src, ref byte_ptrArray4 @data, in int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @src_element_size)
    {
        _av_write_image_line2_cache ??= FunctionResolver.GetFunctionDelegate<av_write_image_line2_delegate>("avutil", "av_write_image_line2", ThrowErrorIfFunctionNotFound);
        if (_av_write_image_line2_cache == null)
            throw new NotSupportedException();
        _av_write_image_line2_cache(@src, ref @data, @linesize, @desc, @x, @y, @c, @w, @src_element_size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_write_trailer_delegate(AVFormatContext* @s);
    private static av_write_trailer_delegate? _av_write_trailer_cache;
    
    /// <summary>Write the stream trailer to an output media file and free the file private data.</summary>
    /// <param name="s">media file handle</param>
    /// <returns>0 if OK, AVERROR_xxx on error</returns>
    public static int av_write_trailer(AVFormatContext* @s)
    {
        _av_write_trailer_cache ??= FunctionResolver.GetFunctionDelegate<av_write_trailer_delegate>("avformat", "av_write_trailer", ThrowErrorIfFunctionNotFound);
        if (_av_write_trailer_cache == null)
            throw new NotSupportedException();
        return _av_write_trailer_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_write_uncoded_frame_delegate(AVFormatContext* @s, int @stream_index, AVFrame* @frame);
    private static av_write_uncoded_frame_delegate? _av_write_uncoded_frame_cache;
    
    /// <summary>Write an uncoded frame to an output media file.</summary>
    public static int av_write_uncoded_frame(AVFormatContext* @s, int @stream_index, AVFrame* @frame)
    {
        _av_write_uncoded_frame_cache ??= FunctionResolver.GetFunctionDelegate<av_write_uncoded_frame_delegate>("avformat", "av_write_uncoded_frame", ThrowErrorIfFunctionNotFound);
        if (_av_write_uncoded_frame_cache == null)
            throw new NotSupportedException();
        return _av_write_uncoded_frame_cache(@s, @stream_index, @frame);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int av_write_uncoded_frame_query_delegate(AVFormatContext* @s, int @stream_index);
    private static av_write_uncoded_frame_query_delegate? _av_write_uncoded_frame_query_cache;
    
    /// <summary>Test whether a muxer supports uncoded frame.</summary>
    /// <returns>&gt;=0 if an uncoded frame can be written to that muxer and stream, &lt; 0 if not</returns>
    public static int av_write_uncoded_frame_query(AVFormatContext* @s, int @stream_index)
    {
        _av_write_uncoded_frame_query_cache ??= FunctionResolver.GetFunctionDelegate<av_write_uncoded_frame_query_delegate>("avformat", "av_write_uncoded_frame_query", ThrowErrorIfFunctionNotFound);
        if (_av_write_uncoded_frame_query_cache == null)
            throw new NotSupportedException();
        return _av_write_uncoded_frame_query_cache(@s, @stream_index);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint av_xiphlacing_delegate(byte* @s, uint @v);
    private static av_xiphlacing_delegate? _av_xiphlacing_cache;
    
    /// <summary>Encode extradata length to a buffer. Used by xiph codecs.</summary>
    /// <param name="s">buffer to write to; must be at least (v/255+1) bytes long</param>
    /// <param name="v">size of extradata in bytes</param>
    /// <returns>number of bytes written to the buffer.</returns>
    public static uint av_xiphlacing(byte* @s, uint @v)
    {
        _av_xiphlacing_cache ??= FunctionResolver.GetFunctionDelegate<av_xiphlacing_delegate>("avcodec", "av_xiphlacing", ThrowErrorIfFunctionNotFound);
        if (_av_xiphlacing_cache == null)
            throw new NotSupportedException();
        return _av_xiphlacing_cache(@s, @v);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avcodec_align_dimensions_delegate(AVCodecContext* @s, int* @width, int* @height);
    private static avcodec_align_dimensions_delegate? _avcodec_align_dimensions_cache;
    
    /// <summary>Modify width and height values so that they will result in a memory buffer that is acceptable for the codec if you do not use any horizontal padding.</summary>
    public static void avcodec_align_dimensions(AVCodecContext* @s, int* @width, int* @height)
    {
        _avcodec_align_dimensions_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_align_dimensions_delegate>("avcodec", "avcodec_align_dimensions", ThrowErrorIfFunctionNotFound);
        if (_avcodec_align_dimensions_cache == null)
            throw new NotSupportedException();
        _avcodec_align_dimensions_cache(@s, @width, @height);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avcodec_align_dimensions2_delegate(AVCodecContext* @s, int* @width, int* @height, ref int_array8 @linesize_align);
    private static avcodec_align_dimensions2_delegate? _avcodec_align_dimensions2_cache;
    
    /// <summary>Modify width and height values so that they will result in a memory buffer that is acceptable for the codec if you also ensure that all line sizes are a multiple of the respective linesize_align[i].</summary>
    public static void avcodec_align_dimensions2(AVCodecContext* @s, int* @width, int* @height, ref int_array8 @linesize_align)
    {
        _avcodec_align_dimensions2_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_align_dimensions2_delegate>("avcodec", "avcodec_align_dimensions2", ThrowErrorIfFunctionNotFound);
        if (_avcodec_align_dimensions2_cache == null)
            throw new NotSupportedException();
        _avcodec_align_dimensions2_cache(@s, @width, @height, ref @linesize_align);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodecContext* avcodec_alloc_context3_delegate(AVCodec* @codec);
    private static avcodec_alloc_context3_delegate? _avcodec_alloc_context3_cache;
    
    /// <summary>Allocate an AVCodecContext and set its fields to default values. The resulting struct should be freed with avcodec_free_context().</summary>
    /// <param name="codec">if non-NULL, allocate private data and initialize defaults for the given codec. It is illegal to then call avcodec_open2() with a different codec. If NULL, then the codec-specific defaults won&apos;t be initialized, which may result in suboptimal default settings (this is important mainly for encoders, e.g. libx264).</param>
    /// <returns>An AVCodecContext filled with default values or NULL on failure.</returns>
    public static AVCodecContext* avcodec_alloc_context3(AVCodec* @codec)
    {
        _avcodec_alloc_context3_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_alloc_context3_delegate>("avcodec", "avcodec_alloc_context3", ThrowErrorIfFunctionNotFound);
        if (_avcodec_alloc_context3_cache == null)
            throw new NotSupportedException();
        return _avcodec_alloc_context3_cache(@codec);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_close_delegate(AVCodecContext* @avctx);
    private static avcodec_close_delegate? _avcodec_close_cache;
    
    /// <summary>Close a given AVCodecContext and free all the data associated with it (but not the AVCodecContext itself).</summary>
    [Obsolete("Do not use this function. Use avcodec_free_context() to destroy a codec context (either open or closed). Opening and closing a codec context multiple times is not supported anymore -- use multiple codec contexts instead.")]
    public static int avcodec_close(AVCodecContext* @avctx)
    {
        _avcodec_close_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_close_delegate>("avcodec", "avcodec_close", ThrowErrorIfFunctionNotFound);
        if (_avcodec_close_cache == null)
            throw new NotSupportedException();
        return _avcodec_close_cache(@avctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string avcodec_configuration_delegate();
    private static avcodec_configuration_delegate? _avcodec_configuration_cache;
    
    /// <summary>Return the libavcodec build-time configuration.</summary>
    public static string avcodec_configuration()
    {
        _avcodec_configuration_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_configuration_delegate>("avcodec", "avcodec_configuration", ThrowErrorIfFunctionNotFound);
        if (_avcodec_configuration_cache == null)
            throw new NotSupportedException();
        return _avcodec_configuration_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_decode_subtitle2_delegate(AVCodecContext* @avctx, AVSubtitle* @sub, int* @got_sub_ptr, AVPacket* @avpkt);
    private static avcodec_decode_subtitle2_delegate? _avcodec_decode_subtitle2_cache;
    
    /// <summary>Decode a subtitle message. Return a negative value on error, otherwise return the number of bytes used. If no subtitle could be decompressed, got_sub_ptr is zero. Otherwise, the subtitle is stored in *sub. Note that AV_CODEC_CAP_DR1 is not available for subtitle codecs. This is for simplicity, because the performance difference is expected to be negligible and reusing a get_buffer written for video codecs would probably perform badly due to a potentially very different allocation pattern.</summary>
    /// <param name="avctx">the codec context</param>
    /// <param name="sub">The preallocated AVSubtitle in which the decoded subtitle will be stored, must be freed with avsubtitle_free if *got_sub_ptr is set.</param>
    /// <param name="got_sub_ptr">Zero if no subtitle could be decompressed, otherwise, it is nonzero.</param>
    /// <param name="avpkt">The input AVPacket containing the input buffer.</param>
    public static int avcodec_decode_subtitle2(AVCodecContext* @avctx, AVSubtitle* @sub, int* @got_sub_ptr, AVPacket* @avpkt)
    {
        _avcodec_decode_subtitle2_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_decode_subtitle2_delegate>("avcodec", "avcodec_decode_subtitle2", ThrowErrorIfFunctionNotFound);
        if (_avcodec_decode_subtitle2_cache == null)
            throw new NotSupportedException();
        return _avcodec_decode_subtitle2_cache(@avctx, @sub, @got_sub_ptr, @avpkt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_default_execute_delegate(AVCodecContext* @c, avcodec_default_execute_func_func @func, void* @arg, int* @ret, int @count, int @size);
    private static avcodec_default_execute_delegate? _avcodec_default_execute_cache;
    
    public static int avcodec_default_execute(AVCodecContext* @c, avcodec_default_execute_func_func @func, void* @arg, int* @ret, int @count, int @size)
    {
        _avcodec_default_execute_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_default_execute_delegate>("avcodec", "avcodec_default_execute", ThrowErrorIfFunctionNotFound);
        if (_avcodec_default_execute_cache == null)
            throw new NotSupportedException();
        return _avcodec_default_execute_cache(@c, @func, @arg, @ret, @count, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_default_execute2_delegate(AVCodecContext* @c, avcodec_default_execute2_func_func @func, void* @arg, int* @ret, int @count);
    private static avcodec_default_execute2_delegate? _avcodec_default_execute2_cache;
    
    public static int avcodec_default_execute2(AVCodecContext* @c, avcodec_default_execute2_func_func @func, void* @arg, int* @ret, int @count)
    {
        _avcodec_default_execute2_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_default_execute2_delegate>("avcodec", "avcodec_default_execute2", ThrowErrorIfFunctionNotFound);
        if (_avcodec_default_execute2_cache == null)
            throw new NotSupportedException();
        return _avcodec_default_execute2_cache(@c, @func, @arg, @ret, @count);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_default_get_buffer2_delegate(AVCodecContext* @s, AVFrame* @frame, int @flags);
    private static avcodec_default_get_buffer2_delegate? _avcodec_default_get_buffer2_cache;
    
    /// <summary>The default callback for AVCodecContext.get_buffer2(). It is made public so it can be called by custom get_buffer2() implementations for decoders without AV_CODEC_CAP_DR1 set.</summary>
    public static int avcodec_default_get_buffer2(AVCodecContext* @s, AVFrame* @frame, int @flags)
    {
        _avcodec_default_get_buffer2_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_default_get_buffer2_delegate>("avcodec", "avcodec_default_get_buffer2", ThrowErrorIfFunctionNotFound);
        if (_avcodec_default_get_buffer2_cache == null)
            throw new NotSupportedException();
        return _avcodec_default_get_buffer2_cache(@s, @frame, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_default_get_encode_buffer_delegate(AVCodecContext* @s, AVPacket* @pkt, int @flags);
    private static avcodec_default_get_encode_buffer_delegate? _avcodec_default_get_encode_buffer_cache;
    
    /// <summary>The default callback for AVCodecContext.get_encode_buffer(). It is made public so it can be called by custom get_encode_buffer() implementations for encoders without AV_CODEC_CAP_DR1 set.</summary>
    public static int avcodec_default_get_encode_buffer(AVCodecContext* @s, AVPacket* @pkt, int @flags)
    {
        _avcodec_default_get_encode_buffer_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_default_get_encode_buffer_delegate>("avcodec", "avcodec_default_get_encode_buffer", ThrowErrorIfFunctionNotFound);
        if (_avcodec_default_get_encode_buffer_cache == null)
            throw new NotSupportedException();
        return _avcodec_default_get_encode_buffer_cache(@s, @pkt, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVPixelFormat avcodec_default_get_format_delegate(AVCodecContext* @s, AVPixelFormat* @fmt);
    private static avcodec_default_get_format_delegate? _avcodec_default_get_format_cache;
    
    public static AVPixelFormat avcodec_default_get_format(AVCodecContext* @s, AVPixelFormat* @fmt)
    {
        _avcodec_default_get_format_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_default_get_format_delegate>("avcodec", "avcodec_default_get_format", ThrowErrorIfFunctionNotFound);
        if (_avcodec_default_get_format_cache == null)
            throw new NotSupportedException();
        return _avcodec_default_get_format_cache(@s, @fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodecDescriptor* avcodec_descriptor_get_delegate(AVCodecID @id);
    private static avcodec_descriptor_get_delegate? _avcodec_descriptor_get_cache;
    
    /// <summary>Returns descriptor for given codec ID or NULL if no descriptor exists.</summary>
    /// <returns>descriptor for given codec ID or NULL if no descriptor exists.</returns>
    public static AVCodecDescriptor* avcodec_descriptor_get(AVCodecID @id)
    {
        _avcodec_descriptor_get_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_descriptor_get_delegate>("avcodec", "avcodec_descriptor_get", ThrowErrorIfFunctionNotFound);
        if (_avcodec_descriptor_get_cache == null)
            throw new NotSupportedException();
        return _avcodec_descriptor_get_cache(@id);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodecDescriptor* avcodec_descriptor_get_by_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static avcodec_descriptor_get_by_name_delegate? _avcodec_descriptor_get_by_name_cache;
    
    /// <summary>Returns codec descriptor with the given name or NULL if no such descriptor exists.</summary>
    /// <returns>codec descriptor with the given name or NULL if no such descriptor exists.</returns>
    public static AVCodecDescriptor* avcodec_descriptor_get_by_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _avcodec_descriptor_get_by_name_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_descriptor_get_by_name_delegate>("avcodec", "avcodec_descriptor_get_by_name", ThrowErrorIfFunctionNotFound);
        if (_avcodec_descriptor_get_by_name_cache == null)
            throw new NotSupportedException();
        return _avcodec_descriptor_get_by_name_cache(@name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodecDescriptor* avcodec_descriptor_next_delegate(AVCodecDescriptor* @prev);
    private static avcodec_descriptor_next_delegate? _avcodec_descriptor_next_cache;
    
    /// <summary>Iterate over all codec descriptors known to libavcodec.</summary>
    /// <param name="prev">previous descriptor. NULL to get the first descriptor.</param>
    /// <returns>next descriptor or NULL after the last descriptor</returns>
    public static AVCodecDescriptor* avcodec_descriptor_next(AVCodecDescriptor* @prev)
    {
        _avcodec_descriptor_next_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_descriptor_next_delegate>("avcodec", "avcodec_descriptor_next", ThrowErrorIfFunctionNotFound);
        if (_avcodec_descriptor_next_cache == null)
            throw new NotSupportedException();
        return _avcodec_descriptor_next_cache(@prev);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_encode_subtitle_delegate(AVCodecContext* @avctx, byte* @buf, int @buf_size, AVSubtitle* @sub);
    private static avcodec_encode_subtitle_delegate? _avcodec_encode_subtitle_cache;
    
    /// <summary>@{</summary>
    public static int avcodec_encode_subtitle(AVCodecContext* @avctx, byte* @buf, int @buf_size, AVSubtitle* @sub)
    {
        _avcodec_encode_subtitle_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_encode_subtitle_delegate>("avcodec", "avcodec_encode_subtitle", ThrowErrorIfFunctionNotFound);
        if (_avcodec_encode_subtitle_cache == null)
            throw new NotSupportedException();
        return _avcodec_encode_subtitle_cache(@avctx, @buf, @buf_size, @sub);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_fill_audio_frame_delegate(AVFrame* @frame, int @nb_channels, AVSampleFormat @sample_fmt, byte* @buf, int @buf_size, int @align);
    private static avcodec_fill_audio_frame_delegate? _avcodec_fill_audio_frame_cache;
    
    /// <summary>Fill AVFrame audio data and linesize pointers.</summary>
    /// <param name="frame">the AVFrame frame-&gt;nb_samples must be set prior to calling the function. This function fills in frame-&gt;data, frame-&gt;extended_data, frame-&gt;linesize[0].</param>
    /// <param name="nb_channels">channel count</param>
    /// <param name="sample_fmt">sample format</param>
    /// <param name="buf">buffer to use for frame data</param>
    /// <param name="buf_size">size of buffer</param>
    /// <param name="align">plane size sample alignment (0 = default)</param>
    /// <returns>&gt;=0 on success, negative error code on failure</returns>
    public static int avcodec_fill_audio_frame(AVFrame* @frame, int @nb_channels, AVSampleFormat @sample_fmt, byte* @buf, int @buf_size, int @align)
    {
        _avcodec_fill_audio_frame_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_fill_audio_frame_delegate>("avcodec", "avcodec_fill_audio_frame", ThrowErrorIfFunctionNotFound);
        if (_avcodec_fill_audio_frame_cache == null)
            throw new NotSupportedException();
        return _avcodec_fill_audio_frame_cache(@frame, @nb_channels, @sample_fmt, @buf, @buf_size, @align);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVPixelFormat avcodec_find_best_pix_fmt_of_list_delegate(AVPixelFormat* @pix_fmt_list, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
    private static avcodec_find_best_pix_fmt_of_list_delegate? _avcodec_find_best_pix_fmt_of_list_cache;
    
    /// <summary>Find the best pixel format to convert to given a certain source pixel format. When converting from one pixel format to another, information loss may occur. For example, when converting from RGB24 to GRAY, the color information will be lost. Similarly, other losses occur when converting from some formats to other formats. avcodec_find_best_pix_fmt_of_2() searches which of the given pixel formats should be used to suffer the least amount of loss. The pixel formats from which it chooses one, are determined by the pix_fmt_list parameter.</summary>
    /// <param name="pix_fmt_list">AV_PIX_FMT_NONE terminated array of pixel formats to choose from</param>
    /// <param name="src_pix_fmt">source pixel format</param>
    /// <param name="has_alpha">Whether the source pixel format alpha channel is used.</param>
    /// <param name="loss_ptr">Combination of flags informing you what kind of losses will occur.</param>
    /// <returns>The best pixel format to convert to or -1 if none was found.</returns>
    public static AVPixelFormat avcodec_find_best_pix_fmt_of_list(AVPixelFormat* @pix_fmt_list, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr)
    {
        _avcodec_find_best_pix_fmt_of_list_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_find_best_pix_fmt_of_list_delegate>("avcodec", "avcodec_find_best_pix_fmt_of_list", ThrowErrorIfFunctionNotFound);
        if (_avcodec_find_best_pix_fmt_of_list_cache == null)
            throw new NotSupportedException();
        return _avcodec_find_best_pix_fmt_of_list_cache(@pix_fmt_list, @src_pix_fmt, @has_alpha, @loss_ptr);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodec* avcodec_find_decoder_delegate(AVCodecID @id);
    private static avcodec_find_decoder_delegate? _avcodec_find_decoder_cache;
    
    /// <summary>Find a registered decoder with a matching codec ID.</summary>
    /// <param name="id">AVCodecID of the requested decoder</param>
    /// <returns>A decoder if one was found, NULL otherwise.</returns>
    public static AVCodec* avcodec_find_decoder(AVCodecID @id)
    {
        _avcodec_find_decoder_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_find_decoder_delegate>("avcodec", "avcodec_find_decoder", ThrowErrorIfFunctionNotFound);
        if (_avcodec_find_decoder_cache == null)
            throw new NotSupportedException();
        return _avcodec_find_decoder_cache(@id);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodec* avcodec_find_decoder_by_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static avcodec_find_decoder_by_name_delegate? _avcodec_find_decoder_by_name_cache;
    
    /// <summary>Find a registered decoder with the specified name.</summary>
    /// <param name="name">name of the requested decoder</param>
    /// <returns>A decoder if one was found, NULL otherwise.</returns>
    public static AVCodec* avcodec_find_decoder_by_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _avcodec_find_decoder_by_name_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_find_decoder_by_name_delegate>("avcodec", "avcodec_find_decoder_by_name", ThrowErrorIfFunctionNotFound);
        if (_avcodec_find_decoder_by_name_cache == null)
            throw new NotSupportedException();
        return _avcodec_find_decoder_by_name_cache(@name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodec* avcodec_find_encoder_delegate(AVCodecID @id);
    private static avcodec_find_encoder_delegate? _avcodec_find_encoder_cache;
    
    /// <summary>Find a registered encoder with a matching codec ID.</summary>
    /// <param name="id">AVCodecID of the requested encoder</param>
    /// <returns>An encoder if one was found, NULL otherwise.</returns>
    public static AVCodec* avcodec_find_encoder(AVCodecID @id)
    {
        _avcodec_find_encoder_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_find_encoder_delegate>("avcodec", "avcodec_find_encoder", ThrowErrorIfFunctionNotFound);
        if (_avcodec_find_encoder_cache == null)
            throw new NotSupportedException();
        return _avcodec_find_encoder_cache(@id);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodec* avcodec_find_encoder_by_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static avcodec_find_encoder_by_name_delegate? _avcodec_find_encoder_by_name_cache;
    
    /// <summary>Find a registered encoder with the specified name.</summary>
    /// <param name="name">name of the requested encoder</param>
    /// <returns>An encoder if one was found, NULL otherwise.</returns>
    public static AVCodec* avcodec_find_encoder_by_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _avcodec_find_encoder_by_name_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_find_encoder_by_name_delegate>("avcodec", "avcodec_find_encoder_by_name", ThrowErrorIfFunctionNotFound);
        if (_avcodec_find_encoder_by_name_cache == null)
            throw new NotSupportedException();
        return _avcodec_find_encoder_by_name_cache(@name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avcodec_flush_buffers_delegate(AVCodecContext* @avctx);
    private static avcodec_flush_buffers_delegate? _avcodec_flush_buffers_cache;
    
    /// <summary>Reset the internal codec state / flush internal buffers. Should be called e.g. when seeking or when switching to a different stream.</summary>
    public static void avcodec_flush_buffers(AVCodecContext* @avctx)
    {
        _avcodec_flush_buffers_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_flush_buffers_delegate>("avcodec", "avcodec_flush_buffers", ThrowErrorIfFunctionNotFound);
        if (_avcodec_flush_buffers_cache == null)
            throw new NotSupportedException();
        _avcodec_flush_buffers_cache(@avctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avcodec_free_context_delegate(AVCodecContext** @avctx);
    private static avcodec_free_context_delegate? _avcodec_free_context_cache;
    
    /// <summary>Free the codec context and everything associated with it and write NULL to the provided pointer.</summary>
    public static void avcodec_free_context(AVCodecContext** @avctx)
    {
        _avcodec_free_context_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_free_context_delegate>("avcodec", "avcodec_free_context", ThrowErrorIfFunctionNotFound);
        if (_avcodec_free_context_cache == null)
            throw new NotSupportedException();
        _avcodec_free_context_cache(@avctx);
    }
    
    /// <summary>Free the codec context and everything associated with it and write NULL to the provided pointer.</summary>
    public static void avcodec_free_context(ref AVCodecContext* @avctx)
    {
        fixed (AVCodecContext** ptr = &@avctx)
        {
            avcodec_free_context(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVClass* avcodec_get_class_delegate();
    private static avcodec_get_class_delegate? _avcodec_get_class_cache;
    
    /// <summary>Get the AVClass for AVCodecContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
    public static AVClass* avcodec_get_class()
    {
        _avcodec_get_class_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_get_class_delegate>("avcodec", "avcodec_get_class", ThrowErrorIfFunctionNotFound);
        if (_avcodec_get_class_cache == null)
            throw new NotSupportedException();
        return _avcodec_get_class_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodecHWConfig* avcodec_get_hw_config_delegate(AVCodec* @codec, int @index);
    private static avcodec_get_hw_config_delegate? _avcodec_get_hw_config_cache;
    
    /// <summary>Retrieve supported hardware configurations for a codec.</summary>
    public static AVCodecHWConfig* avcodec_get_hw_config(AVCodec* @codec, int @index)
    {
        _avcodec_get_hw_config_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_get_hw_config_delegate>("avcodec", "avcodec_get_hw_config", ThrowErrorIfFunctionNotFound);
        if (_avcodec_get_hw_config_cache == null)
            throw new NotSupportedException();
        return _avcodec_get_hw_config_cache(@codec, @index);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_get_hw_frames_parameters_delegate(AVCodecContext* @avctx, AVBufferRef* @device_ref, AVPixelFormat @hw_pix_fmt, AVBufferRef** @out_frames_ref);
    private static avcodec_get_hw_frames_parameters_delegate? _avcodec_get_hw_frames_parameters_cache;
    
    /// <summary>Create and return a AVHWFramesContext with values adequate for hardware decoding. This is meant to get called from the get_format callback, and is a helper for preparing a AVHWFramesContext for AVCodecContext.hw_frames_ctx. This API is for decoding with certain hardware acceleration modes/APIs only.</summary>
    /// <param name="avctx">The context which is currently calling get_format, and which implicitly contains all state needed for filling the returned AVHWFramesContext properly.</param>
    /// <param name="device_ref">A reference to the AVHWDeviceContext describing the device which will be used by the hardware decoder.</param>
    /// <param name="hw_pix_fmt">The hwaccel format you are going to return from get_format.</param>
    /// <param name="out_frames_ref">On success, set to a reference to an _uninitialized_ AVHWFramesContext, created from the given device_ref. Fields will be set to values required for decoding. Not changed if an error is returned.</param>
    /// <returns>zero on success, a negative value on error. The following error codes have special semantics: AVERROR(ENOENT): the decoder does not support this functionality. Setup is always manual, or it is a decoder which does not support setting AVCodecContext.hw_frames_ctx at all, or it is a software format. AVERROR(EINVAL): it is known that hardware decoding is not supported for this configuration, or the device_ref is not supported for the hwaccel referenced by hw_pix_fmt.</returns>
    public static int avcodec_get_hw_frames_parameters(AVCodecContext* @avctx, AVBufferRef* @device_ref, AVPixelFormat @hw_pix_fmt, AVBufferRef** @out_frames_ref)
    {
        _avcodec_get_hw_frames_parameters_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_get_hw_frames_parameters_delegate>("avcodec", "avcodec_get_hw_frames_parameters", ThrowErrorIfFunctionNotFound);
        if (_avcodec_get_hw_frames_parameters_cache == null)
            throw new NotSupportedException();
        return _avcodec_get_hw_frames_parameters_cache(@avctx, @device_ref, @hw_pix_fmt, @out_frames_ref);
    }
    
    /// <summary>Create and return a AVHWFramesContext with values adequate for hardware decoding. This is meant to get called from the get_format callback, and is a helper for preparing a AVHWFramesContext for AVCodecContext.hw_frames_ctx. This API is for decoding with certain hardware acceleration modes/APIs only.</summary>
    /// <param name="avctx">The context which is currently calling get_format, and which implicitly contains all state needed for filling the returned AVHWFramesContext properly.</param>
    /// <param name="device_ref">A reference to the AVHWDeviceContext describing the device which will be used by the hardware decoder.</param>
    /// <param name="hw_pix_fmt">The hwaccel format you are going to return from get_format.</param>
    /// <returns>zero on success, a negative value on error. The following error codes have special semantics: AVERROR(ENOENT): the decoder does not support this functionality. Setup is always manual, or it is a decoder which does not support setting AVCodecContext.hw_frames_ctx at all, or it is a software format. AVERROR(EINVAL): it is known that hardware decoding is not supported for this configuration, or the device_ref is not supported for the hwaccel referenced by hw_pix_fmt.</returns>
    public static int avcodec_get_hw_frames_parameters(AVCodecContext* @avctx, AVBufferRef* @device_ref, AVPixelFormat @hw_pix_fmt, ref AVBufferRef* @out_frames_ref)
    {
        fixed (AVBufferRef** ptr = &@out_frames_ref)
        {
            return avcodec_get_hw_frames_parameters(@avctx, @device_ref, @hw_pix_fmt, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string avcodec_get_name_delegate(AVCodecID @id);
    private static avcodec_get_name_delegate? _avcodec_get_name_cache;
    
    /// <summary>Get the name of a codec.</summary>
    /// <returns>a static string identifying the codec; never NULL</returns>
    public static string avcodec_get_name(AVCodecID @id)
    {
        _avcodec_get_name_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_get_name_delegate>("avcodec", "avcodec_get_name", ThrowErrorIfFunctionNotFound);
        if (_avcodec_get_name_cache == null)
            throw new NotSupportedException();
        return _avcodec_get_name_cache(@id);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVClass* avcodec_get_subtitle_rect_class_delegate();
    private static avcodec_get_subtitle_rect_class_delegate? _avcodec_get_subtitle_rect_class_cache;
    
    /// <summary>Get the AVClass for AVSubtitleRect. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
    public static AVClass* avcodec_get_subtitle_rect_class()
    {
        _avcodec_get_subtitle_rect_class_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_get_subtitle_rect_class_delegate>("avcodec", "avcodec_get_subtitle_rect_class", ThrowErrorIfFunctionNotFound);
        if (_avcodec_get_subtitle_rect_class_cache == null)
            throw new NotSupportedException();
        return _avcodec_get_subtitle_rect_class_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_get_supported_config_delegate(AVCodecContext* @avctx, AVCodec* @codec, AVCodecConfig @config, uint @flags, void** @out_configs, int* @out_num_configs);
    private static avcodec_get_supported_config_delegate? _avcodec_get_supported_config_cache;
    
    /// <summary>Retrieve a list of all supported values for a given configuration type.</summary>
    /// <param name="avctx">An optional context to use. Values such as `strict_std_compliance` may affect the result. If NULL, default values are used.</param>
    /// <param name="codec">The codec to query, or NULL to use avctx-&gt;codec.</param>
    /// <param name="config">The configuration to query.</param>
    /// <param name="flags">Currently unused; should be set to zero.</param>
    /// <param name="out_configs">On success, set to a list of configurations, terminated by a config-specific terminator, or NULL if all possible values are supported.</param>
    /// <param name="out_num_configs">On success, set to the number of elements in out_configs, excluding the terminator. Optional.</param>
    public static int avcodec_get_supported_config(AVCodecContext* @avctx, AVCodec* @codec, AVCodecConfig @config, uint @flags, void** @out_configs, int* @out_num_configs)
    {
        _avcodec_get_supported_config_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_get_supported_config_delegate>("avcodec", "avcodec_get_supported_config", ThrowErrorIfFunctionNotFound);
        if (_avcodec_get_supported_config_cache == null)
            throw new NotSupportedException();
        return _avcodec_get_supported_config_cache(@avctx, @codec, @config, @flags, @out_configs, @out_num_configs);
    }
    
    /// <summary>Retrieve a list of all supported values for a given configuration type.</summary>
    /// <param name="avctx">An optional context to use. Values such as `strict_std_compliance` may affect the result. If NULL, default values are used.</param>
    /// <param name="codec">The codec to query, or NULL to use avctx-&gt;codec.</param>
    /// <param name="config">The configuration to query.</param>
    /// <param name="flags">Currently unused; should be set to zero.</param>
    /// <param name="out_num_configs">On success, set to the number of elements in out_configs, excluding the terminator. Optional.</param>
    public static int avcodec_get_supported_config(AVCodecContext* @avctx, AVCodec* @codec, AVCodecConfig @config, uint @flags, ref void* @out_configs, int* @out_num_configs)
    {
        fixed (void** ptr = &@out_configs)
        {
            return avcodec_get_supported_config(@avctx, @codec, @config, @flags, ptr, @out_num_configs);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVMediaType avcodec_get_type_delegate(AVCodecID @codec_id);
    private static avcodec_get_type_delegate? _avcodec_get_type_cache;
    
    /// <summary>Get the type of the given codec.</summary>
    public static AVMediaType avcodec_get_type(AVCodecID @codec_id)
    {
        _avcodec_get_type_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_get_type_delegate>("avcodec", "avcodec_get_type", ThrowErrorIfFunctionNotFound);
        if (_avcodec_get_type_cache == null)
            throw new NotSupportedException();
        return _avcodec_get_type_cache(@codec_id);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_is_open_delegate(AVCodecContext* @s);
    private static avcodec_is_open_delegate? _avcodec_is_open_cache;
    
    /// <summary>Returns a positive value if s is open (i.e. avcodec_open2() was called on it with no corresponding avcodec_close()), 0 otherwise.</summary>
    /// <returns>a positive value if s is open (i.e. avcodec_open2() was called on it with no corresponding avcodec_close()), 0 otherwise.</returns>
    public static int avcodec_is_open(AVCodecContext* @s)
    {
        _avcodec_is_open_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_is_open_delegate>("avcodec", "avcodec_is_open", ThrowErrorIfFunctionNotFound);
        if (_avcodec_is_open_cache == null)
            throw new NotSupportedException();
        return _avcodec_is_open_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string avcodec_license_delegate();
    private static avcodec_license_delegate? _avcodec_license_cache;
    
    /// <summary>Return the libavcodec license.</summary>
    public static string avcodec_license()
    {
        _avcodec_license_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_license_delegate>("avcodec", "avcodec_license", ThrowErrorIfFunctionNotFound);
        if (_avcodec_license_cache == null)
            throw new NotSupportedException();
        return _avcodec_license_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_open2_delegate(AVCodecContext* @avctx, AVCodec* @codec, AVDictionary** @options);
    private static avcodec_open2_delegate? _avcodec_open2_cache;
    
    /// <summary>Initialize the AVCodecContext to use the given AVCodec. Prior to using this function the context has to be allocated with avcodec_alloc_context3().</summary>
    /// <param name="avctx">The context to initialize.</param>
    /// <param name="codec">The codec to open this context for. If a non-NULL codec has been previously passed to avcodec_alloc_context3() or for this context, then this parameter MUST be either NULL or equal to the previously passed codec.</param>
    /// <param name="options">A dictionary filled with AVCodecContext and codec-private options, which are set on top of the options already set in avctx, can be NULL. On return this object will be filled with options that were not found in the avctx codec context.</param>
    /// <returns>zero on success, a negative value on error</returns>
    public static int avcodec_open2(AVCodecContext* @avctx, AVCodec* @codec, AVDictionary** @options)
    {
        _avcodec_open2_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_open2_delegate>("avcodec", "avcodec_open2", ThrowErrorIfFunctionNotFound);
        if (_avcodec_open2_cache == null)
            throw new NotSupportedException();
        return _avcodec_open2_cache(@avctx, @codec, @options);
    }
    
    /// <summary>Initialize the AVCodecContext to use the given AVCodec. Prior to using this function the context has to be allocated with avcodec_alloc_context3().</summary>
    /// <param name="avctx">The context to initialize.</param>
    /// <param name="codec">The codec to open this context for. If a non-NULL codec has been previously passed to avcodec_alloc_context3() or for this context, then this parameter MUST be either NULL or equal to the previously passed codec.</param>
    /// <returns>zero on success, a negative value on error</returns>
    public static int avcodec_open2(AVCodecContext* @avctx, AVCodec* @codec, ref AVDictionary* @options)
    {
        fixed (AVDictionary** ptr = &@options)
        {
            return avcodec_open2(@avctx, @codec, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodecParameters* avcodec_parameters_alloc_delegate();
    private static avcodec_parameters_alloc_delegate? _avcodec_parameters_alloc_cache;
    
    /// <summary>Allocate a new AVCodecParameters and set its fields to default values (unknown/invalid/0). The returned struct must be freed with avcodec_parameters_free().</summary>
    public static AVCodecParameters* avcodec_parameters_alloc()
    {
        _avcodec_parameters_alloc_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_parameters_alloc_delegate>("avcodec", "avcodec_parameters_alloc", ThrowErrorIfFunctionNotFound);
        if (_avcodec_parameters_alloc_cache == null)
            throw new NotSupportedException();
        return _avcodec_parameters_alloc_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_parameters_copy_delegate(AVCodecParameters* @dst, AVCodecParameters* @src);
    private static avcodec_parameters_copy_delegate? _avcodec_parameters_copy_cache;
    
    /// <summary>Copy the contents of src to dst. Any allocated fields in dst are freed and replaced with newly allocated duplicates of the corresponding fields in src.</summary>
    /// <returns>&gt;= 0 on success, a negative AVERROR code on failure.</returns>
    public static int avcodec_parameters_copy(AVCodecParameters* @dst, AVCodecParameters* @src)
    {
        _avcodec_parameters_copy_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_parameters_copy_delegate>("avcodec", "avcodec_parameters_copy", ThrowErrorIfFunctionNotFound);
        if (_avcodec_parameters_copy_cache == null)
            throw new NotSupportedException();
        return _avcodec_parameters_copy_cache(@dst, @src);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avcodec_parameters_free_delegate(AVCodecParameters** @par);
    private static avcodec_parameters_free_delegate? _avcodec_parameters_free_cache;
    
    /// <summary>Free an AVCodecParameters instance and everything associated with it and write NULL to the supplied pointer.</summary>
    public static void avcodec_parameters_free(AVCodecParameters** @par)
    {
        _avcodec_parameters_free_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_parameters_free_delegate>("avcodec", "avcodec_parameters_free", ThrowErrorIfFunctionNotFound);
        if (_avcodec_parameters_free_cache == null)
            throw new NotSupportedException();
        _avcodec_parameters_free_cache(@par);
    }
    
    /// <summary>Free an AVCodecParameters instance and everything associated with it and write NULL to the supplied pointer.</summary>
    public static void avcodec_parameters_free(ref AVCodecParameters* @par)
    {
        fixed (AVCodecParameters** ptr = &@par)
        {
            avcodec_parameters_free(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_parameters_from_context_delegate(AVCodecParameters* @par, AVCodecContext* @codec);
    private static avcodec_parameters_from_context_delegate? _avcodec_parameters_from_context_cache;
    
    /// <summary>Fill the parameters struct based on the values from the supplied codec context. Any allocated fields in par are freed and replaced with duplicates of the corresponding fields in codec.</summary>
    /// <returns>&gt;= 0 on success, a negative AVERROR code on failure</returns>
    public static int avcodec_parameters_from_context(AVCodecParameters* @par, AVCodecContext* @codec)
    {
        _avcodec_parameters_from_context_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_parameters_from_context_delegate>("avcodec", "avcodec_parameters_from_context", ThrowErrorIfFunctionNotFound);
        if (_avcodec_parameters_from_context_cache == null)
            throw new NotSupportedException();
        return _avcodec_parameters_from_context_cache(@par, @codec);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_parameters_to_context_delegate(AVCodecContext* @codec, AVCodecParameters* @par);
    private static avcodec_parameters_to_context_delegate? _avcodec_parameters_to_context_cache;
    
    /// <summary>Fill the codec context based on the values from the supplied codec parameters. Any allocated fields in codec that have a corresponding field in par are freed and replaced with duplicates of the corresponding field in par. Fields in codec that do not have a counterpart in par are not touched.</summary>
    /// <returns>&gt;= 0 on success, a negative AVERROR code on failure.</returns>
    public static int avcodec_parameters_to_context(AVCodecContext* @codec, AVCodecParameters* @par)
    {
        _avcodec_parameters_to_context_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_parameters_to_context_delegate>("avcodec", "avcodec_parameters_to_context", ThrowErrorIfFunctionNotFound);
        if (_avcodec_parameters_to_context_cache == null)
            throw new NotSupportedException();
        return _avcodec_parameters_to_context_cache(@codec, @par);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint avcodec_pix_fmt_to_codec_tag_delegate(AVPixelFormat @pix_fmt);
    private static avcodec_pix_fmt_to_codec_tag_delegate? _avcodec_pix_fmt_to_codec_tag_cache;
    
    /// <summary>Return a value representing the fourCC code associated to the pixel format pix_fmt, or 0 if no associated fourCC code can be found.</summary>
    public static uint avcodec_pix_fmt_to_codec_tag(AVPixelFormat @pix_fmt)
    {
        _avcodec_pix_fmt_to_codec_tag_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_pix_fmt_to_codec_tag_delegate>("avcodec", "avcodec_pix_fmt_to_codec_tag", ThrowErrorIfFunctionNotFound);
        if (_avcodec_pix_fmt_to_codec_tag_cache == null)
            throw new NotSupportedException();
        return _avcodec_pix_fmt_to_codec_tag_cache(@pix_fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string avcodec_profile_name_delegate(AVCodecID @codec_id, int @profile);
    private static avcodec_profile_name_delegate? _avcodec_profile_name_cache;
    
    /// <summary>Return a name for the specified profile, if available.</summary>
    /// <param name="codec_id">the ID of the codec to which the requested profile belongs</param>
    /// <param name="profile">the profile value for which a name is requested</param>
    /// <returns>A name for the profile if found, NULL otherwise.</returns>
    public static string avcodec_profile_name(AVCodecID @codec_id, int @profile)
    {
        _avcodec_profile_name_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_profile_name_delegate>("avcodec", "avcodec_profile_name", ThrowErrorIfFunctionNotFound);
        if (_avcodec_profile_name_cache == null)
            throw new NotSupportedException();
        return _avcodec_profile_name_cache(@codec_id, @profile);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_receive_frame_delegate(AVCodecContext* @avctx, AVFrame* @frame);
    private static avcodec_receive_frame_delegate? _avcodec_receive_frame_cache;
    
    /// <summary>Return decoded output data from a decoder or encoder (when the AV_CODEC_FLAG_RECON_FRAME flag is used).</summary>
    /// <param name="avctx">codec context</param>
    /// <param name="frame">This will be set to a reference-counted video or audio frame (depending on the decoder type) allocated by the codec. Note that the function will always call av_frame_unref(frame) before doing anything else.</param>
    public static int avcodec_receive_frame(AVCodecContext* @avctx, AVFrame* @frame)
    {
        _avcodec_receive_frame_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_receive_frame_delegate>("avcodec", "avcodec_receive_frame", ThrowErrorIfFunctionNotFound);
        if (_avcodec_receive_frame_cache == null)
            throw new NotSupportedException();
        return _avcodec_receive_frame_cache(@avctx, @frame);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_receive_packet_delegate(AVCodecContext* @avctx, AVPacket* @avpkt);
    private static avcodec_receive_packet_delegate? _avcodec_receive_packet_cache;
    
    /// <summary>Read encoded data from the encoder.</summary>
    /// <param name="avctx">codec context</param>
    /// <param name="avpkt">This will be set to a reference-counted packet allocated by the encoder. Note that the function will always call av_packet_unref(avpkt) before doing anything else.</param>
    public static int avcodec_receive_packet(AVCodecContext* @avctx, AVPacket* @avpkt)
    {
        _avcodec_receive_packet_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_receive_packet_delegate>("avcodec", "avcodec_receive_packet", ThrowErrorIfFunctionNotFound);
        if (_avcodec_receive_packet_cache == null)
            throw new NotSupportedException();
        return _avcodec_receive_packet_cache(@avctx, @avpkt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_send_frame_delegate(AVCodecContext* @avctx, AVFrame* @frame);
    private static avcodec_send_frame_delegate? _avcodec_send_frame_cache;
    
    /// <summary>Supply a raw video or audio frame to the encoder. Use avcodec_receive_packet() to retrieve buffered output packets.</summary>
    /// <param name="avctx">codec context</param>
    /// <param name="frame">AVFrame containing the raw audio or video frame to be encoded. Ownership of the frame remains with the caller, and the encoder will not write to the frame. The encoder may create a reference to the frame data (or copy it if the frame is not reference-counted). It can be NULL, in which case it is considered a flush packet.  This signals the end of the stream. If the encoder still has packets buffered, it will return them after this call. Once flushing mode has been entered, additional flush packets are ignored, and sending frames will return AVERROR_EOF.</param>
    public static int avcodec_send_frame(AVCodecContext* @avctx, AVFrame* @frame)
    {
        _avcodec_send_frame_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_send_frame_delegate>("avcodec", "avcodec_send_frame", ThrowErrorIfFunctionNotFound);
        if (_avcodec_send_frame_cache == null)
            throw new NotSupportedException();
        return _avcodec_send_frame_cache(@avctx, @frame);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avcodec_send_packet_delegate(AVCodecContext* @avctx, AVPacket* @avpkt);
    private static avcodec_send_packet_delegate? _avcodec_send_packet_cache;
    
    /// <summary>Supply raw packet data as input to a decoder.</summary>
    /// <param name="avctx">codec context</param>
    /// <param name="avpkt">The input AVPacket. Usually, this will be a single video frame, or several complete audio frames. Ownership of the packet remains with the caller, and the decoder will not write to the packet. The decoder may create a reference to the packet data (or copy it if the packet is not reference-counted). Unlike with older APIs, the packet is always fully consumed, and if it contains multiple frames (e.g. some audio codecs), will require you to call avcodec_receive_frame() multiple times afterwards before you can send a new packet. It can be NULL (or an AVPacket with data set to NULL and size set to 0); in this case, it is considered a flush packet, which signals the end of the stream. Sending the first flush packet will return success. Subsequent ones are unnecessary and will return AVERROR_EOF. If the decoder still has frames buffered, it will return them after sending a flush packet.</param>
    public static int avcodec_send_packet(AVCodecContext* @avctx, AVPacket* @avpkt)
    {
        _avcodec_send_packet_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_send_packet_delegate>("avcodec", "avcodec_send_packet", ThrowErrorIfFunctionNotFound);
        if (_avcodec_send_packet_cache == null)
            throw new NotSupportedException();
        return _avcodec_send_packet_cache(@avctx, @avpkt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avcodec_string_delegate(byte* @buf, int @buf_size, AVCodecContext* @enc, int @encode);
    private static avcodec_string_delegate? _avcodec_string_cache;
    
    /// <summary>@}</summary>
    public static void avcodec_string(byte* @buf, int @buf_size, AVCodecContext* @enc, int @encode)
    {
        _avcodec_string_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_string_delegate>("avcodec", "avcodec_string", ThrowErrorIfFunctionNotFound);
        if (_avcodec_string_cache == null)
            throw new NotSupportedException();
        _avcodec_string_cache(@buf, @buf_size, @enc, @encode);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint avcodec_version_delegate();
    private static avcodec_version_delegate? _avcodec_version_cache;
    
    /// <summary>Return the LIBAVCODEC_VERSION_INT constant.</summary>
    public static uint avcodec_version()
    {
        _avcodec_version_cache ??= FunctionResolver.GetFunctionDelegate<avcodec_version_delegate>("avcodec", "avcodec_version", ThrowErrorIfFunctionNotFound);
        if (_avcodec_version_cache == null)
            throw new NotSupportedException();
        return _avcodec_version_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avdevice_app_to_dev_control_message_delegate(AVFormatContext* @s, AVAppToDevMessageType @type, void* @data, ulong @data_size);
    private static avdevice_app_to_dev_control_message_delegate? _avdevice_app_to_dev_control_message_cache;
    
    /// <summary>Send control message from application to device.</summary>
    /// <param name="s">device context.</param>
    /// <param name="type">message type.</param>
    /// <param name="data">message data. Exact type depends on message type.</param>
    /// <param name="data_size">size of message data.</param>
    /// <returns>&gt;= 0 on success, negative on error. AVERROR(ENOSYS) when device doesn&apos;t implement handler of the message.</returns>
    public static int avdevice_app_to_dev_control_message(AVFormatContext* @s, AVAppToDevMessageType @type, void* @data, ulong @data_size)
    {
        _avdevice_app_to_dev_control_message_cache ??= FunctionResolver.GetFunctionDelegate<avdevice_app_to_dev_control_message_delegate>("avdevice", "avdevice_app_to_dev_control_message", ThrowErrorIfFunctionNotFound);
        if (_avdevice_app_to_dev_control_message_cache == null)
            throw new NotSupportedException();
        return _avdevice_app_to_dev_control_message_cache(@s, @type, @data, @data_size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string avdevice_configuration_delegate();
    private static avdevice_configuration_delegate? _avdevice_configuration_cache;
    
    /// <summary>Return the libavdevice build-time configuration.</summary>
    public static string avdevice_configuration()
    {
        _avdevice_configuration_cache ??= FunctionResolver.GetFunctionDelegate<avdevice_configuration_delegate>("avdevice", "avdevice_configuration", ThrowErrorIfFunctionNotFound);
        if (_avdevice_configuration_cache == null)
            throw new NotSupportedException();
        return _avdevice_configuration_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avdevice_dev_to_app_control_message_delegate(AVFormatContext* @s, AVDevToAppMessageType @type, void* @data, ulong @data_size);
    private static avdevice_dev_to_app_control_message_delegate? _avdevice_dev_to_app_control_message_cache;
    
    /// <summary>Send control message from device to application.</summary>
    /// <param name="s">device context.</param>
    /// <param name="type">message type.</param>
    /// <param name="data">message data. Can be NULL.</param>
    /// <param name="data_size">size of message data.</param>
    /// <returns>&gt;= 0 on success, negative on error. AVERROR(ENOSYS) when application doesn&apos;t implement handler of the message.</returns>
    public static int avdevice_dev_to_app_control_message(AVFormatContext* @s, AVDevToAppMessageType @type, void* @data, ulong @data_size)
    {
        _avdevice_dev_to_app_control_message_cache ??= FunctionResolver.GetFunctionDelegate<avdevice_dev_to_app_control_message_delegate>("avdevice", "avdevice_dev_to_app_control_message", ThrowErrorIfFunctionNotFound);
        if (_avdevice_dev_to_app_control_message_cache == null)
            throw new NotSupportedException();
        return _avdevice_dev_to_app_control_message_cache(@s, @type, @data, @data_size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avdevice_free_list_devices_delegate(AVDeviceInfoList** @device_list);
    private static avdevice_free_list_devices_delegate? _avdevice_free_list_devices_cache;
    
    /// <summary>Convenient function to free result of avdevice_list_devices().</summary>
    /// <param name="device_list">device list to be freed.</param>
    public static void avdevice_free_list_devices(AVDeviceInfoList** @device_list)
    {
        _avdevice_free_list_devices_cache ??= FunctionResolver.GetFunctionDelegate<avdevice_free_list_devices_delegate>("avdevice", "avdevice_free_list_devices", ThrowErrorIfFunctionNotFound);
        if (_avdevice_free_list_devices_cache == null)
            throw new NotSupportedException();
        _avdevice_free_list_devices_cache(@device_list);
    }
    
    /// <summary>Convenient function to free result of avdevice_list_devices().</summary>
    public static void avdevice_free_list_devices(ref AVDeviceInfoList* @device_list)
    {
        fixed (AVDeviceInfoList** ptr = &@device_list)
        {
            avdevice_free_list_devices(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string avdevice_license_delegate();
    private static avdevice_license_delegate? _avdevice_license_cache;
    
    /// <summary>Return the libavdevice license.</summary>
    public static string avdevice_license()
    {
        _avdevice_license_cache ??= FunctionResolver.GetFunctionDelegate<avdevice_license_delegate>("avdevice", "avdevice_license", ThrowErrorIfFunctionNotFound);
        if (_avdevice_license_cache == null)
            throw new NotSupportedException();
        return _avdevice_license_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avdevice_list_devices_delegate(AVFormatContext* @s, AVDeviceInfoList** @device_list);
    private static avdevice_list_devices_delegate? _avdevice_list_devices_cache;
    
    /// <summary>List devices.</summary>
    /// <param name="s">device context.</param>
    /// <param name="device_list">list of autodetected devices.</param>
    /// <returns>count of autodetected devices, negative on error.</returns>
    public static int avdevice_list_devices(AVFormatContext* @s, AVDeviceInfoList** @device_list)
    {
        _avdevice_list_devices_cache ??= FunctionResolver.GetFunctionDelegate<avdevice_list_devices_delegate>("avdevice", "avdevice_list_devices", ThrowErrorIfFunctionNotFound);
        if (_avdevice_list_devices_cache == null)
            throw new NotSupportedException();
        return _avdevice_list_devices_cache(@s, @device_list);
    }
    
    /// <summary>List devices.</summary>
    /// <param name="s">device context.</param>
    /// <returns>count of autodetected devices, negative on error.</returns>
    public static int avdevice_list_devices(AVFormatContext* @s, ref AVDeviceInfoList* @device_list)
    {
        fixed (AVDeviceInfoList** ptr = &@device_list)
        {
            return avdevice_list_devices(@s, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avdevice_list_input_sources_delegate(AVInputFormat* @device,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list);
    private static avdevice_list_input_sources_delegate? _avdevice_list_input_sources_cache;
    
    /// <summary>List devices.</summary>
    /// <param name="device">device format. May be NULL if device name is set.</param>
    /// <param name="device_name">device name. May be NULL if device format is set.</param>
    /// <param name="device_options">An AVDictionary filled with device-private options. May be NULL. The same options must be passed later to avformat_write_header() for output devices or avformat_open_input() for input devices, or at any other place that affects device-private options.</param>
    /// <param name="device_list">list of autodetected devices</param>
    /// <returns>count of autodetected devices, negative on error.</returns>
    public static int avdevice_list_input_sources(AVInputFormat* @device,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list)
    {
        _avdevice_list_input_sources_cache ??= FunctionResolver.GetFunctionDelegate<avdevice_list_input_sources_delegate>("avdevice", "avdevice_list_input_sources", ThrowErrorIfFunctionNotFound);
        if (_avdevice_list_input_sources_cache == null)
            throw new NotSupportedException();
        return _avdevice_list_input_sources_cache(@device, @device_name, @device_options, @device_list);
    }
    
    /// <summary>List devices.</summary>
    /// <param name="device">device format. May be NULL if device name is set.</param>
    /// <param name="device_name">device name. May be NULL if device format is set.</param>
    /// <param name="device_options">An AVDictionary filled with device-private options. May be NULL. The same options must be passed later to avformat_write_header() for output devices or avformat_open_input() for input devices, or at any other place that affects device-private options.</param>
    /// <returns>count of autodetected devices, negative on error.</returns>
    public static int avdevice_list_input_sources(AVInputFormat* @device, string @device_name, AVDictionary* @device_options, ref AVDeviceInfoList* @device_list)
    {
        fixed (AVDeviceInfoList** ptr = &@device_list)
        {
            return avdevice_list_input_sources(@device, @device_name, @device_options, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avdevice_list_output_sinks_delegate(AVOutputFormat* @device,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list);
    private static avdevice_list_output_sinks_delegate? _avdevice_list_output_sinks_cache;
    
    public static int avdevice_list_output_sinks(AVOutputFormat* @device,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list)
    {
        _avdevice_list_output_sinks_cache ??= FunctionResolver.GetFunctionDelegate<avdevice_list_output_sinks_delegate>("avdevice", "avdevice_list_output_sinks", ThrowErrorIfFunctionNotFound);
        if (_avdevice_list_output_sinks_cache == null)
            throw new NotSupportedException();
        return _avdevice_list_output_sinks_cache(@device, @device_name, @device_options, @device_list);
    }
    
    public static int avdevice_list_output_sinks(AVOutputFormat* @device, string @device_name, AVDictionary* @device_options, ref AVDeviceInfoList* @device_list)
    {
        fixed (AVDeviceInfoList** ptr = &@device_list)
        {
            return avdevice_list_output_sinks(@device, @device_name, @device_options, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avdevice_register_all_delegate();
    private static avdevice_register_all_delegate? _avdevice_register_all_cache;
    
    /// <summary>Initialize libavdevice and register all the input and output devices.</summary>
    public static void avdevice_register_all()
    {
        _avdevice_register_all_cache ??= FunctionResolver.GetFunctionDelegate<avdevice_register_all_delegate>("avdevice", "avdevice_register_all", ThrowErrorIfFunctionNotFound);
        if (_avdevice_register_all_cache == null)
            throw new NotSupportedException();
        _avdevice_register_all_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint avdevice_version_delegate();
    private static avdevice_version_delegate? _avdevice_version_cache;
    
    /// <summary>Return the LIBAVDEVICE_VERSION_INT constant.</summary>
    public static uint avdevice_version()
    {
        _avdevice_version_cache ??= FunctionResolver.GetFunctionDelegate<avdevice_version_delegate>("avdevice", "avdevice_version", ThrowErrorIfFunctionNotFound);
        if (_avdevice_version_cache == null)
            throw new NotSupportedException();
        return _avdevice_version_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_config_links_delegate(AVFilterContext* @filter);
    private static avfilter_config_links_delegate? _avfilter_config_links_cache;
    
    [Obsolete("this function should never be called by users")]
    public static int avfilter_config_links(AVFilterContext* @filter)
    {
        _avfilter_config_links_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_config_links_delegate>("avfilter", "avfilter_config_links", ThrowErrorIfFunctionNotFound);
        if (_avfilter_config_links_cache == null)
            throw new NotSupportedException();
        return _avfilter_config_links_cache(@filter);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string avfilter_configuration_delegate();
    private static avfilter_configuration_delegate? _avfilter_configuration_cache;
    
    /// <summary>Return the libavfilter build-time configuration.</summary>
    public static string avfilter_configuration()
    {
        _avfilter_configuration_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_configuration_delegate>("avfilter", "avfilter_configuration", ThrowErrorIfFunctionNotFound);
        if (_avfilter_configuration_cache == null)
            throw new NotSupportedException();
        return _avfilter_configuration_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint avfilter_filter_pad_count_delegate(AVFilter* @filter, int @is_output);
    private static avfilter_filter_pad_count_delegate? _avfilter_filter_pad_count_cache;
    
    /// <summary>Get the number of elements in an AVFilter&apos;s inputs or outputs array.</summary>
    public static uint avfilter_filter_pad_count(AVFilter* @filter, int @is_output)
    {
        _avfilter_filter_pad_count_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_filter_pad_count_delegate>("avfilter", "avfilter_filter_pad_count", ThrowErrorIfFunctionNotFound);
        if (_avfilter_filter_pad_count_cache == null)
            throw new NotSupportedException();
        return _avfilter_filter_pad_count_cache(@filter, @is_output);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avfilter_free_delegate(AVFilterContext* @filter);
    private static avfilter_free_delegate? _avfilter_free_cache;
    
    /// <summary>Free a filter context. This will also remove the filter from its filtergraph&apos;s list of filters.</summary>
    /// <param name="filter">the filter to free</param>
    public static void avfilter_free(AVFilterContext* @filter)
    {
        _avfilter_free_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_free_delegate>("avfilter", "avfilter_free", ThrowErrorIfFunctionNotFound);
        if (_avfilter_free_cache == null)
            throw new NotSupportedException();
        _avfilter_free_cache(@filter);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVFilter* avfilter_get_by_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static avfilter_get_by_name_delegate? _avfilter_get_by_name_cache;
    
    /// <summary>Get a filter definition matching the given name.</summary>
    /// <param name="name">the filter name to find</param>
    /// <returns>the filter definition, if any matching one is registered. NULL if none found.</returns>
    public static AVFilter* avfilter_get_by_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _avfilter_get_by_name_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_get_by_name_delegate>("avfilter", "avfilter_get_by_name", ThrowErrorIfFunctionNotFound);
        if (_avfilter_get_by_name_cache == null)
            throw new NotSupportedException();
        return _avfilter_get_by_name_cache(@name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVClass* avfilter_get_class_delegate();
    private static avfilter_get_class_delegate? _avfilter_get_class_cache;
    
    /// <summary>Returns AVClass for AVFilterContext.</summary>
    /// <returns>AVClass for AVFilterContext.</returns>
    public static AVClass* avfilter_get_class()
    {
        _avfilter_get_class_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_get_class_delegate>("avfilter", "avfilter_get_class", ThrowErrorIfFunctionNotFound);
        if (_avfilter_get_class_cache == null)
            throw new NotSupportedException();
        return _avfilter_get_class_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVFilterGraph* avfilter_graph_alloc_delegate();
    private static avfilter_graph_alloc_delegate? _avfilter_graph_alloc_cache;
    
    /// <summary>Allocate a filter graph.</summary>
    /// <returns>the allocated filter graph on success or NULL.</returns>
    public static AVFilterGraph* avfilter_graph_alloc()
    {
        _avfilter_graph_alloc_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_alloc_delegate>("avfilter", "avfilter_graph_alloc", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_alloc_cache == null)
            throw new NotSupportedException();
        return _avfilter_graph_alloc_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVFilterContext* avfilter_graph_alloc_filter_delegate(AVFilterGraph* @graph, AVFilter* @filter,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static avfilter_graph_alloc_filter_delegate? _avfilter_graph_alloc_filter_cache;
    
    /// <summary>Create a new filter instance in a filter graph.</summary>
    /// <param name="graph">graph in which the new filter will be used</param>
    /// <param name="filter">the filter to create an instance of</param>
    /// <param name="name">Name to give to the new instance (will be copied to AVFilterContext.name). This may be used by the caller to identify different filters, libavfilter itself assigns no semantics to this parameter. May be NULL.</param>
    /// <returns>the context of the newly created filter instance (note that it is also retrievable directly through AVFilterGraph.filters or with avfilter_graph_get_filter()) on success or NULL on failure.</returns>
    public static AVFilterContext* avfilter_graph_alloc_filter(AVFilterGraph* @graph, AVFilter* @filter,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _avfilter_graph_alloc_filter_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_alloc_filter_delegate>("avfilter", "avfilter_graph_alloc_filter", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_alloc_filter_cache == null)
            throw new NotSupportedException();
        return _avfilter_graph_alloc_filter_cache(@graph, @filter, @name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_graph_config_delegate(AVFilterGraph* @graphctx, void* @log_ctx);
    private static avfilter_graph_config_delegate? _avfilter_graph_config_cache;
    
    /// <summary>Check validity and configure all the links and formats in the graph.</summary>
    /// <param name="graphctx">the filter graph</param>
    /// <param name="log_ctx">context used for logging</param>
    /// <returns>&gt;= 0 in case of success, a negative AVERROR code otherwise</returns>
    public static int avfilter_graph_config(AVFilterGraph* @graphctx, void* @log_ctx)
    {
        _avfilter_graph_config_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_config_delegate>("avfilter", "avfilter_graph_config", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_config_cache == null)
            throw new NotSupportedException();
        return _avfilter_graph_config_cache(@graphctx, @log_ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_graph_create_filter_delegate(AVFilterContext** @filt_ctx, AVFilter* @filt,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @args, void* @opaque, AVFilterGraph* @graph_ctx);
    private static avfilter_graph_create_filter_delegate? _avfilter_graph_create_filter_cache;
    
    /// <summary>Create and add a filter instance into an existing graph. The filter instance is created from the filter filt and inited with the parameter args. opaque is currently ignored.</summary>
    /// <param name="name">the instance name to give to the created filter instance</param>
    /// <param name="graph_ctx">the filter graph</param>
    /// <returns>a negative AVERROR error code in case of failure, a non negative value otherwise</returns>
    public static int avfilter_graph_create_filter(AVFilterContext** @filt_ctx, AVFilter* @filt,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @args, void* @opaque, AVFilterGraph* @graph_ctx)
    {
        _avfilter_graph_create_filter_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_create_filter_delegate>("avfilter", "avfilter_graph_create_filter", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_create_filter_cache == null)
            throw new NotSupportedException();
        return _avfilter_graph_create_filter_cache(@filt_ctx, @filt, @name, @args, @opaque, @graph_ctx);
    }
    
    /// <summary>Create and add a filter instance into an existing graph. The filter instance is created from the filter filt and inited with the parameter args. opaque is currently ignored.</summary>
    /// <param name="name">the instance name to give to the created filter instance</param>
    /// <param name="graph_ctx">the filter graph</param>
    /// <returns>a negative AVERROR error code in case of failure, a non negative value otherwise</returns>
    public static int avfilter_graph_create_filter(ref AVFilterContext* @filt_ctx, AVFilter* @filt, string @name, string @args, void* @opaque, AVFilterGraph* @graph_ctx)
    {
        fixed (AVFilterContext** ptr = &@filt_ctx)
        {
            return avfilter_graph_create_filter(ptr, @filt, @name, @args, @opaque, @graph_ctx);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate byte* avfilter_graph_dump_delegate(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @options);
    private static avfilter_graph_dump_delegate? _avfilter_graph_dump_cache;
    
    /// <summary>Dump a graph into a human-readable string representation.</summary>
    /// <param name="graph">the graph to dump</param>
    /// <param name="options">formatting options; currently ignored</param>
    /// <returns>a string, or NULL in case of memory allocation failure; the string must be freed using av_free</returns>
    public static byte* avfilter_graph_dump(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @options)
    {
        _avfilter_graph_dump_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_dump_delegate>("avfilter", "avfilter_graph_dump", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_dump_cache == null)
            throw new NotSupportedException();
        return _avfilter_graph_dump_cache(@graph, @options);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avfilter_graph_free_delegate(AVFilterGraph** @graph);
    private static avfilter_graph_free_delegate? _avfilter_graph_free_cache;
    
    /// <summary>Free a graph, destroy its links, and set *graph to NULL. If *graph is NULL, do nothing.</summary>
    public static void avfilter_graph_free(AVFilterGraph** @graph)
    {
        _avfilter_graph_free_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_free_delegate>("avfilter", "avfilter_graph_free", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_free_cache == null)
            throw new NotSupportedException();
        _avfilter_graph_free_cache(@graph);
    }
    
    /// <summary>Free a graph, destroy its links, and set *graph to NULL. If *graph is NULL, do nothing.</summary>
    public static void avfilter_graph_free(ref AVFilterGraph* @graph)
    {
        fixed (AVFilterGraph** ptr = &@graph)
        {
            avfilter_graph_free(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVFilterContext* avfilter_graph_get_filter_delegate(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static avfilter_graph_get_filter_delegate? _avfilter_graph_get_filter_cache;
    
    /// <summary>Get a filter instance identified by instance name from graph.</summary>
    /// <param name="graph">filter graph to search through.</param>
    /// <param name="name">filter instance name (should be unique in the graph).</param>
    /// <returns>the pointer to the found filter instance or NULL if it cannot be found.</returns>
    public static AVFilterContext* avfilter_graph_get_filter(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _avfilter_graph_get_filter_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_get_filter_delegate>("avfilter", "avfilter_graph_get_filter", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_get_filter_cache == null)
            throw new NotSupportedException();
        return _avfilter_graph_get_filter_cache(@graph, @name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_graph_parse_delegate(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filters, AVFilterInOut* @inputs, AVFilterInOut* @outputs, void* @log_ctx);
    private static avfilter_graph_parse_delegate? _avfilter_graph_parse_cache;
    
    /// <summary>Add a graph described by a string to a graph.</summary>
    /// <param name="graph">the filter graph where to link the parsed graph context</param>
    /// <param name="filters">string to be parsed</param>
    /// <param name="inputs">linked list to the inputs of the graph</param>
    /// <param name="outputs">linked list to the outputs of the graph</param>
    /// <returns>zero on success, a negative AVERROR code on error</returns>
    public static int avfilter_graph_parse(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filters, AVFilterInOut* @inputs, AVFilterInOut* @outputs, void* @log_ctx)
    {
        _avfilter_graph_parse_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_parse_delegate>("avfilter", "avfilter_graph_parse", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_parse_cache == null)
            throw new NotSupportedException();
        return _avfilter_graph_parse_cache(@graph, @filters, @inputs, @outputs, @log_ctx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_graph_parse_ptr_delegate(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs, void* @log_ctx);
    private static avfilter_graph_parse_ptr_delegate? _avfilter_graph_parse_ptr_cache;
    
    /// <summary>Add a graph described by a string to a graph.</summary>
    /// <param name="graph">the filter graph where to link the parsed graph context</param>
    /// <param name="filters">string to be parsed</param>
    /// <param name="inputs">pointer to a linked list to the inputs of the graph, may be NULL. If non-NULL, *inputs is updated to contain the list of open inputs after the parsing, should be freed with avfilter_inout_free().</param>
    /// <param name="outputs">pointer to a linked list to the outputs of the graph, may be NULL. If non-NULL, *outputs is updated to contain the list of open outputs after the parsing, should be freed with avfilter_inout_free().</param>
    /// <returns>non negative on success, a negative AVERROR code on error</returns>
    public static int avfilter_graph_parse_ptr(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs, void* @log_ctx)
    {
        _avfilter_graph_parse_ptr_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_parse_ptr_delegate>("avfilter", "avfilter_graph_parse_ptr", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_parse_ptr_cache == null)
            throw new NotSupportedException();
        return _avfilter_graph_parse_ptr_cache(@graph, @filters, @inputs, @outputs, @log_ctx);
    }
    
    /// <summary>Add a graph described by a string to a graph.</summary>
    /// <param name="graph">the filter graph where to link the parsed graph context</param>
    /// <param name="filters">string to be parsed</param>
    /// <param name="outputs">pointer to a linked list to the outputs of the graph, may be NULL. If non-NULL, *outputs is updated to contain the list of open outputs after the parsing, should be freed with avfilter_inout_free().</param>
    /// <returns>non negative on success, a negative AVERROR code on error</returns>
    public static int avfilter_graph_parse_ptr(AVFilterGraph* @graph, string @filters, ref AVFilterInOut* @inputs, AVFilterInOut** @outputs, void* @log_ctx)
    {
        fixed (AVFilterInOut** ptr = &@inputs)
        {
            return avfilter_graph_parse_ptr(@graph, @filters, ptr, @outputs, @log_ctx);
        }
    }
    
    /// <summary>Add a graph described by a string to a graph.</summary>
    /// <param name="graph">the filter graph where to link the parsed graph context</param>
    /// <param name="filters">string to be parsed</param>
    /// <param name="inputs">pointer to a linked list to the inputs of the graph, may be NULL. If non-NULL, *inputs is updated to contain the list of open inputs after the parsing, should be freed with avfilter_inout_free().</param>
    /// <returns>non negative on success, a negative AVERROR code on error</returns>
    public static int avfilter_graph_parse_ptr(AVFilterGraph* @graph, string @filters, AVFilterInOut** @inputs, ref AVFilterInOut* @outputs, void* @log_ctx)
    {
        fixed (AVFilterInOut** ptr = &@outputs)
        {
            return avfilter_graph_parse_ptr(@graph, @filters, @inputs, ptr, @log_ctx);
        }
    }
    
    /// <summary>Add a graph described by a string to a graph.</summary>
    /// <param name="graph">the filter graph where to link the parsed graph context</param>
    /// <param name="filters">string to be parsed</param>
    /// <returns>non negative on success, a negative AVERROR code on error</returns>
    public static int avfilter_graph_parse_ptr(AVFilterGraph* @graph, string @filters, ref AVFilterInOut* @inputs, ref AVFilterInOut* @outputs, void* @log_ctx)
    {
        fixed (AVFilterInOut** ptr1 = &@inputs)
        {
        fixed (AVFilterInOut** ptr2 = &@outputs)
        {
                return avfilter_graph_parse_ptr(@graph, @filters, ptr1, ptr2, @log_ctx);
        }
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_graph_parse2_delegate(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs);
    private static avfilter_graph_parse2_delegate? _avfilter_graph_parse2_cache;
    
    /// <summary>Add a graph described by a string to a graph.</summary>
    /// <param name="graph">the filter graph where to link the parsed graph context</param>
    /// <param name="filters">string to be parsed</param>
    /// <param name="inputs">a linked list of all free (unlinked) inputs of the parsed graph will be returned here. It is to be freed by the caller using avfilter_inout_free().</param>
    /// <param name="outputs">a linked list of all free (unlinked) outputs of the parsed graph will be returned here. It is to be freed by the caller using avfilter_inout_free().</param>
    /// <returns>zero on success, a negative AVERROR code on error</returns>
    public static int avfilter_graph_parse2(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs)
    {
        _avfilter_graph_parse2_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_parse2_delegate>("avfilter", "avfilter_graph_parse2", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_parse2_cache == null)
            throw new NotSupportedException();
        return _avfilter_graph_parse2_cache(@graph, @filters, @inputs, @outputs);
    }
    
    /// <summary>Add a graph described by a string to a graph.</summary>
    /// <param name="graph">the filter graph where to link the parsed graph context</param>
    /// <param name="filters">string to be parsed</param>
    /// <param name="outputs">a linked list of all free (unlinked) outputs of the parsed graph will be returned here. It is to be freed by the caller using avfilter_inout_free().</param>
    /// <returns>zero on success, a negative AVERROR code on error</returns>
    public static int avfilter_graph_parse2(AVFilterGraph* @graph, string @filters, ref AVFilterInOut* @inputs, AVFilterInOut** @outputs)
    {
        fixed (AVFilterInOut** ptr = &@inputs)
        {
            return avfilter_graph_parse2(@graph, @filters, ptr, @outputs);
        }
    }
    
    /// <summary>Add a graph described by a string to a graph.</summary>
    /// <param name="graph">the filter graph where to link the parsed graph context</param>
    /// <param name="filters">string to be parsed</param>
    /// <param name="inputs">a linked list of all free (unlinked) inputs of the parsed graph will be returned here. It is to be freed by the caller using avfilter_inout_free().</param>
    /// <returns>zero on success, a negative AVERROR code on error</returns>
    public static int avfilter_graph_parse2(AVFilterGraph* @graph, string @filters, AVFilterInOut** @inputs, ref AVFilterInOut* @outputs)
    {
        fixed (AVFilterInOut** ptr = &@outputs)
        {
            return avfilter_graph_parse2(@graph, @filters, @inputs, ptr);
        }
    }
    
    /// <summary>Add a graph described by a string to a graph.</summary>
    /// <param name="graph">the filter graph where to link the parsed graph context</param>
    /// <param name="filters">string to be parsed</param>
    /// <returns>zero on success, a negative AVERROR code on error</returns>
    public static int avfilter_graph_parse2(AVFilterGraph* @graph, string @filters, ref AVFilterInOut* @inputs, ref AVFilterInOut* @outputs)
    {
        fixed (AVFilterInOut** ptr1 = &@inputs)
        {
        fixed (AVFilterInOut** ptr2 = &@outputs)
        {
                return avfilter_graph_parse2(@graph, @filters, ptr1, ptr2);
        }
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_graph_queue_command_delegate(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @target,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @cmd,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @arg, int @flags, double @ts);
    private static avfilter_graph_queue_command_delegate? _avfilter_graph_queue_command_cache;
    
    /// <summary>Queue a command for one or more filter instances.</summary>
    /// <param name="graph">the filter graph</param>
    /// <param name="target">the filter(s) to which the command should be sent &quot;all&quot; sends to all filters otherwise it can be a filter or filter instance name which will send the command to all matching filters.</param>
    /// <param name="cmd">the command to sent, for handling simplicity all commands must be alphanumeric only</param>
    /// <param name="arg">the argument for the command</param>
    /// <param name="ts">time at which the command should be sent to the filter</param>
    public static int avfilter_graph_queue_command(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @target,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @cmd,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @arg, int @flags, double @ts)
    {
        _avfilter_graph_queue_command_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_queue_command_delegate>("avfilter", "avfilter_graph_queue_command", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_queue_command_cache == null)
            throw new NotSupportedException();
        return _avfilter_graph_queue_command_cache(@graph, @target, @cmd, @arg, @flags, @ts);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_graph_request_oldest_delegate(AVFilterGraph* @graph);
    private static avfilter_graph_request_oldest_delegate? _avfilter_graph_request_oldest_cache;
    
    /// <summary>Request a frame on the oldest sink link.</summary>
    /// <returns>the return value of ff_request_frame(), or AVERROR_EOF if all links returned AVERROR_EOF</returns>
    public static int avfilter_graph_request_oldest(AVFilterGraph* @graph)
    {
        _avfilter_graph_request_oldest_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_request_oldest_delegate>("avfilter", "avfilter_graph_request_oldest", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_request_oldest_cache == null)
            throw new NotSupportedException();
        return _avfilter_graph_request_oldest_cache(@graph);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_graph_segment_apply_delegate(AVFilterGraphSegment* @seg, int @flags, AVFilterInOut** @inputs, AVFilterInOut** @outputs);
    private static avfilter_graph_segment_apply_delegate? _avfilter_graph_segment_apply_cache;
    
    /// <summary>Apply all filter/link descriptions from a graph segment to the associated filtergraph.</summary>
    /// <param name="seg">the filtergraph segment to process</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    /// <param name="inputs">passed to avfilter_graph_segment_link()</param>
    /// <param name="outputs">passed to avfilter_graph_segment_link()</param>
    public static int avfilter_graph_segment_apply(AVFilterGraphSegment* @seg, int @flags, AVFilterInOut** @inputs, AVFilterInOut** @outputs)
    {
        _avfilter_graph_segment_apply_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_segment_apply_delegate>("avfilter", "avfilter_graph_segment_apply", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_segment_apply_cache == null)
            throw new NotSupportedException();
        return _avfilter_graph_segment_apply_cache(@seg, @flags, @inputs, @outputs);
    }
    
    /// <summary>Apply all filter/link descriptions from a graph segment to the associated filtergraph.</summary>
    /// <param name="seg">the filtergraph segment to process</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    /// <param name="outputs">passed to avfilter_graph_segment_link()</param>
    public static int avfilter_graph_segment_apply(AVFilterGraphSegment* @seg, int @flags, ref AVFilterInOut* @inputs, AVFilterInOut** @outputs)
    {
        fixed (AVFilterInOut** ptr = &@inputs)
        {
            return avfilter_graph_segment_apply(@seg, @flags, ptr, @outputs);
        }
    }
    
    /// <summary>Apply all filter/link descriptions from a graph segment to the associated filtergraph.</summary>
    /// <param name="seg">the filtergraph segment to process</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    /// <param name="inputs">passed to avfilter_graph_segment_link()</param>
    public static int avfilter_graph_segment_apply(AVFilterGraphSegment* @seg, int @flags, AVFilterInOut** @inputs, ref AVFilterInOut* @outputs)
    {
        fixed (AVFilterInOut** ptr = &@outputs)
        {
            return avfilter_graph_segment_apply(@seg, @flags, @inputs, ptr);
        }
    }
    
    /// <summary>Apply all filter/link descriptions from a graph segment to the associated filtergraph.</summary>
    /// <param name="seg">the filtergraph segment to process</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    public static int avfilter_graph_segment_apply(AVFilterGraphSegment* @seg, int @flags, ref AVFilterInOut* @inputs, ref AVFilterInOut* @outputs)
    {
        fixed (AVFilterInOut** ptr1 = &@inputs)
        {
        fixed (AVFilterInOut** ptr2 = &@outputs)
        {
                return avfilter_graph_segment_apply(@seg, @flags, ptr1, ptr2);
        }
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_graph_segment_apply_opts_delegate(AVFilterGraphSegment* @seg, int @flags);
    private static avfilter_graph_segment_apply_opts_delegate? _avfilter_graph_segment_apply_opts_cache;
    
    /// <summary>Apply parsed options to filter instances in a graph segment.</summary>
    /// <param name="seg">the filtergraph segment to process</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    public static int avfilter_graph_segment_apply_opts(AVFilterGraphSegment* @seg, int @flags)
    {
        _avfilter_graph_segment_apply_opts_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_segment_apply_opts_delegate>("avfilter", "avfilter_graph_segment_apply_opts", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_segment_apply_opts_cache == null)
            throw new NotSupportedException();
        return _avfilter_graph_segment_apply_opts_cache(@seg, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_graph_segment_create_filters_delegate(AVFilterGraphSegment* @seg, int @flags);
    private static avfilter_graph_segment_create_filters_delegate? _avfilter_graph_segment_create_filters_cache;
    
    /// <summary>Create filters specified in a graph segment.</summary>
    /// <param name="seg">the filtergraph segment to process</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    public static int avfilter_graph_segment_create_filters(AVFilterGraphSegment* @seg, int @flags)
    {
        _avfilter_graph_segment_create_filters_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_segment_create_filters_delegate>("avfilter", "avfilter_graph_segment_create_filters", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_segment_create_filters_cache == null)
            throw new NotSupportedException();
        return _avfilter_graph_segment_create_filters_cache(@seg, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avfilter_graph_segment_free_delegate(AVFilterGraphSegment** @seg);
    private static avfilter_graph_segment_free_delegate? _avfilter_graph_segment_free_cache;
    
    /// <summary>Free the provided AVFilterGraphSegment and everything associated with it.</summary>
    /// <param name="seg">double pointer to the AVFilterGraphSegment to be freed. NULL will be written to this pointer on exit from this function.</param>
    public static void avfilter_graph_segment_free(AVFilterGraphSegment** @seg)
    {
        _avfilter_graph_segment_free_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_segment_free_delegate>("avfilter", "avfilter_graph_segment_free", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_segment_free_cache == null)
            throw new NotSupportedException();
        _avfilter_graph_segment_free_cache(@seg);
    }
    
    /// <summary>Free the provided AVFilterGraphSegment and everything associated with it.</summary>
    public static void avfilter_graph_segment_free(ref AVFilterGraphSegment* @seg)
    {
        fixed (AVFilterGraphSegment** ptr = &@seg)
        {
            avfilter_graph_segment_free(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_graph_segment_init_delegate(AVFilterGraphSegment* @seg, int @flags);
    private static avfilter_graph_segment_init_delegate? _avfilter_graph_segment_init_cache;
    
    /// <summary>Initialize all filter instances in a graph segment.</summary>
    /// <param name="seg">the filtergraph segment to process</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    public static int avfilter_graph_segment_init(AVFilterGraphSegment* @seg, int @flags)
    {
        _avfilter_graph_segment_init_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_segment_init_delegate>("avfilter", "avfilter_graph_segment_init", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_segment_init_cache == null)
            throw new NotSupportedException();
        return _avfilter_graph_segment_init_cache(@seg, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_graph_segment_link_delegate(AVFilterGraphSegment* @seg, int @flags, AVFilterInOut** @inputs, AVFilterInOut** @outputs);
    private static avfilter_graph_segment_link_delegate? _avfilter_graph_segment_link_cache;
    
    /// <summary>Link filters in a graph segment.</summary>
    /// <param name="seg">the filtergraph segment to process</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    /// <param name="inputs">a linked list of all free (unlinked) inputs of the filters in this graph segment will be returned here. It is to be freed by the caller using avfilter_inout_free().</param>
    /// <param name="outputs">a linked list of all free (unlinked) outputs of the filters in this graph segment will be returned here. It is to be freed by the caller using avfilter_inout_free().</param>
    public static int avfilter_graph_segment_link(AVFilterGraphSegment* @seg, int @flags, AVFilterInOut** @inputs, AVFilterInOut** @outputs)
    {
        _avfilter_graph_segment_link_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_segment_link_delegate>("avfilter", "avfilter_graph_segment_link", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_segment_link_cache == null)
            throw new NotSupportedException();
        return _avfilter_graph_segment_link_cache(@seg, @flags, @inputs, @outputs);
    }
    
    /// <summary>Link filters in a graph segment.</summary>
    /// <param name="seg">the filtergraph segment to process</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    /// <param name="outputs">a linked list of all free (unlinked) outputs of the filters in this graph segment will be returned here. It is to be freed by the caller using avfilter_inout_free().</param>
    public static int avfilter_graph_segment_link(AVFilterGraphSegment* @seg, int @flags, ref AVFilterInOut* @inputs, AVFilterInOut** @outputs)
    {
        fixed (AVFilterInOut** ptr = &@inputs)
        {
            return avfilter_graph_segment_link(@seg, @flags, ptr, @outputs);
        }
    }
    
    /// <summary>Link filters in a graph segment.</summary>
    /// <param name="seg">the filtergraph segment to process</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    /// <param name="inputs">a linked list of all free (unlinked) inputs of the filters in this graph segment will be returned here. It is to be freed by the caller using avfilter_inout_free().</param>
    public static int avfilter_graph_segment_link(AVFilterGraphSegment* @seg, int @flags, AVFilterInOut** @inputs, ref AVFilterInOut* @outputs)
    {
        fixed (AVFilterInOut** ptr = &@outputs)
        {
            return avfilter_graph_segment_link(@seg, @flags, @inputs, ptr);
        }
    }
    
    /// <summary>Link filters in a graph segment.</summary>
    /// <param name="seg">the filtergraph segment to process</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    public static int avfilter_graph_segment_link(AVFilterGraphSegment* @seg, int @flags, ref AVFilterInOut* @inputs, ref AVFilterInOut* @outputs)
    {
        fixed (AVFilterInOut** ptr1 = &@inputs)
        {
        fixed (AVFilterInOut** ptr2 = &@outputs)
        {
                return avfilter_graph_segment_link(@seg, @flags, ptr1, ptr2);
        }
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_graph_segment_parse_delegate(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @graph_str, int @flags, AVFilterGraphSegment** @seg);
    private static avfilter_graph_segment_parse_delegate? _avfilter_graph_segment_parse_cache;
    
    /// <summary>Parse a textual filtergraph description into an intermediate form.</summary>
    /// <param name="graph">Filter graph the parsed segment is associated with. Will only be used for logging and similar auxiliary purposes. The graph will not be actually modified by this function - the parsing results are instead stored in seg for further processing.</param>
    /// <param name="graph_str">a string describing the filtergraph segment</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    /// <param name="seg">A pointer to the newly-created AVFilterGraphSegment is written here on success. The graph segment is owned by the caller and must be freed with avfilter_graph_segment_free() before graph itself is freed.</param>
    public static int avfilter_graph_segment_parse(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @graph_str, int @flags, AVFilterGraphSegment** @seg)
    {
        _avfilter_graph_segment_parse_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_segment_parse_delegate>("avfilter", "avfilter_graph_segment_parse", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_segment_parse_cache == null)
            throw new NotSupportedException();
        return _avfilter_graph_segment_parse_cache(@graph, @graph_str, @flags, @seg);
    }
    
    /// <summary>Parse a textual filtergraph description into an intermediate form.</summary>
    /// <param name="graph">Filter graph the parsed segment is associated with. Will only be used for logging and similar auxiliary purposes. The graph will not be actually modified by this function - the parsing results are instead stored in seg for further processing.</param>
    /// <param name="graph_str">a string describing the filtergraph segment</param>
    /// <param name="flags">reserved for future use, caller must set to 0 for now</param>
    public static int avfilter_graph_segment_parse(AVFilterGraph* @graph, string @graph_str, int @flags, ref AVFilterGraphSegment* @seg)
    {
        fixed (AVFilterGraphSegment** ptr = &@seg)
        {
            return avfilter_graph_segment_parse(@graph, @graph_str, @flags, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_graph_send_command_delegate(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @target,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @cmd,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @arg, byte* @res, int @res_len, int @flags);
    private static avfilter_graph_send_command_delegate? _avfilter_graph_send_command_cache;
    
    /// <summary>Send a command to one or more filter instances.</summary>
    /// <param name="graph">the filter graph</param>
    /// <param name="target">the filter(s) to which the command should be sent &quot;all&quot; sends to all filters otherwise it can be a filter or filter instance name which will send the command to all matching filters.</param>
    /// <param name="cmd">the command to send, for handling simplicity all commands must be alphanumeric only</param>
    /// <param name="arg">the argument for the command</param>
    /// <param name="res">a buffer with size res_size where the filter(s) can return a response.</param>
    public static int avfilter_graph_send_command(AVFilterGraph* @graph,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @target,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @cmd,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @arg, byte* @res, int @res_len, int @flags)
    {
        _avfilter_graph_send_command_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_send_command_delegate>("avfilter", "avfilter_graph_send_command", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_send_command_cache == null)
            throw new NotSupportedException();
        return _avfilter_graph_send_command_cache(@graph, @target, @cmd, @arg, @res, @res_len, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avfilter_graph_set_auto_convert_delegate(AVFilterGraph* @graph, uint @flags);
    private static avfilter_graph_set_auto_convert_delegate? _avfilter_graph_set_auto_convert_cache;
    
    /// <summary>Enable or disable automatic format conversion inside the graph.</summary>
    /// <param name="flags">any of the AVFILTER_AUTO_CONVERT_* constants</param>
    public static void avfilter_graph_set_auto_convert(AVFilterGraph* @graph, uint @flags)
    {
        _avfilter_graph_set_auto_convert_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_graph_set_auto_convert_delegate>("avfilter", "avfilter_graph_set_auto_convert", ThrowErrorIfFunctionNotFound);
        if (_avfilter_graph_set_auto_convert_cache == null)
            throw new NotSupportedException();
        _avfilter_graph_set_auto_convert_cache(@graph, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_init_dict_delegate(AVFilterContext* @ctx, AVDictionary** @options);
    private static avfilter_init_dict_delegate? _avfilter_init_dict_cache;
    
    /// <summary>Initialize a filter with the supplied dictionary of options.</summary>
    /// <param name="ctx">uninitialized filter context to initialize</param>
    /// <param name="options">An AVDictionary filled with options for this filter. On return this parameter will be destroyed and replaced with a dict containing options that were not found. This dictionary must be freed by the caller. May be NULL, then this function is equivalent to avfilter_init_str() with the second parameter set to NULL.</param>
    /// <returns>0 on success, a negative AVERROR on failure</returns>
    public static int avfilter_init_dict(AVFilterContext* @ctx, AVDictionary** @options)
    {
        _avfilter_init_dict_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_init_dict_delegate>("avfilter", "avfilter_init_dict", ThrowErrorIfFunctionNotFound);
        if (_avfilter_init_dict_cache == null)
            throw new NotSupportedException();
        return _avfilter_init_dict_cache(@ctx, @options);
    }
    
    /// <summary>Initialize a filter with the supplied dictionary of options.</summary>
    /// <param name="ctx">uninitialized filter context to initialize</param>
    /// <returns>0 on success, a negative AVERROR on failure</returns>
    public static int avfilter_init_dict(AVFilterContext* @ctx, ref AVDictionary* @options)
    {
        fixed (AVDictionary** ptr = &@options)
        {
            return avfilter_init_dict(@ctx, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_init_str_delegate(AVFilterContext* @ctx,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @args);
    private static avfilter_init_str_delegate? _avfilter_init_str_cache;
    
    /// <summary>Initialize a filter with the supplied parameters.</summary>
    /// <param name="ctx">uninitialized filter context to initialize</param>
    /// <param name="args">Options to initialize the filter with. This must be a &apos;:&apos;-separated list of options in the &apos;key=value&apos; form. May be NULL if the options have been set directly using the AVOptions API or there are no options that need to be set.</param>
    /// <returns>0 on success, a negative AVERROR on failure</returns>
    public static int avfilter_init_str(AVFilterContext* @ctx,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @args)
    {
        _avfilter_init_str_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_init_str_delegate>("avfilter", "avfilter_init_str", ThrowErrorIfFunctionNotFound);
        if (_avfilter_init_str_cache == null)
            throw new NotSupportedException();
        return _avfilter_init_str_cache(@ctx, @args);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVFilterInOut* avfilter_inout_alloc_delegate();
    private static avfilter_inout_alloc_delegate? _avfilter_inout_alloc_cache;
    
    /// <summary>Allocate a single AVFilterInOut entry. Must be freed with avfilter_inout_free().</summary>
    /// <returns>allocated AVFilterInOut on success, NULL on failure.</returns>
    public static AVFilterInOut* avfilter_inout_alloc()
    {
        _avfilter_inout_alloc_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_inout_alloc_delegate>("avfilter", "avfilter_inout_alloc", ThrowErrorIfFunctionNotFound);
        if (_avfilter_inout_alloc_cache == null)
            throw new NotSupportedException();
        return _avfilter_inout_alloc_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avfilter_inout_free_delegate(AVFilterInOut** @inout);
    private static avfilter_inout_free_delegate? _avfilter_inout_free_cache;
    
    /// <summary>Free the supplied list of AVFilterInOut and set *inout to NULL. If *inout is NULL, do nothing.</summary>
    public static void avfilter_inout_free(AVFilterInOut** @inout)
    {
        _avfilter_inout_free_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_inout_free_delegate>("avfilter", "avfilter_inout_free", ThrowErrorIfFunctionNotFound);
        if (_avfilter_inout_free_cache == null)
            throw new NotSupportedException();
        _avfilter_inout_free_cache(@inout);
    }
    
    /// <summary>Free the supplied list of AVFilterInOut and set *inout to NULL. If *inout is NULL, do nothing.</summary>
    public static void avfilter_inout_free(ref AVFilterInOut* @inout)
    {
        fixed (AVFilterInOut** ptr = &@inout)
        {
            avfilter_inout_free(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_insert_filter_delegate(AVFilterLink* @link, AVFilterContext* @filt, uint @filt_srcpad_idx, uint @filt_dstpad_idx);
    private static avfilter_insert_filter_delegate? _avfilter_insert_filter_cache;
    
    /// <summary>Insert a filter in the middle of an existing link.</summary>
    /// <param name="link">the link into which the filter should be inserted</param>
    /// <param name="filt">the filter to be inserted</param>
    /// <param name="filt_srcpad_idx">the input pad on the filter to connect</param>
    /// <param name="filt_dstpad_idx">the output pad on the filter to connect</param>
    /// <returns>zero on success</returns>
    public static int avfilter_insert_filter(AVFilterLink* @link, AVFilterContext* @filt, uint @filt_srcpad_idx, uint @filt_dstpad_idx)
    {
        _avfilter_insert_filter_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_insert_filter_delegate>("avfilter", "avfilter_insert_filter", ThrowErrorIfFunctionNotFound);
        if (_avfilter_insert_filter_cache == null)
            throw new NotSupportedException();
        return _avfilter_insert_filter_cache(@link, @filt, @filt_srcpad_idx, @filt_dstpad_idx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string avfilter_license_delegate();
    private static avfilter_license_delegate? _avfilter_license_cache;
    
    /// <summary>Return the libavfilter license.</summary>
    public static string avfilter_license()
    {
        _avfilter_license_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_license_delegate>("avfilter", "avfilter_license", ThrowErrorIfFunctionNotFound);
        if (_avfilter_license_cache == null)
            throw new NotSupportedException();
        return _avfilter_license_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_link_delegate(AVFilterContext* @src, uint @srcpad, AVFilterContext* @dst, uint @dstpad);
    private static avfilter_link_delegate? _avfilter_link_cache;
    
    /// <summary>Link two filters together.</summary>
    /// <param name="src">the source filter</param>
    /// <param name="srcpad">index of the output pad on the source filter</param>
    /// <param name="dst">the destination filter</param>
    /// <param name="dstpad">index of the input pad on the destination filter</param>
    /// <returns>zero on success</returns>
    public static int avfilter_link(AVFilterContext* @src, uint @srcpad, AVFilterContext* @dst, uint @dstpad)
    {
        _avfilter_link_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_link_delegate>("avfilter", "avfilter_link", ThrowErrorIfFunctionNotFound);
        if (_avfilter_link_cache == null)
            throw new NotSupportedException();
        return _avfilter_link_cache(@src, @srcpad, @dst, @dstpad);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avfilter_link_free_delegate(AVFilterLink** @link);
    private static avfilter_link_free_delegate? _avfilter_link_free_cache;
    
    [Obsolete("this function should never be called by users")]
    public static void avfilter_link_free(AVFilterLink** @link)
    {
        _avfilter_link_free_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_link_free_delegate>("avfilter", "avfilter_link_free", ThrowErrorIfFunctionNotFound);
        if (_avfilter_link_free_cache == null)
            throw new NotSupportedException();
        _avfilter_link_free_cache(@link);
    }
    
    [Obsolete("this function should never be called by users")]
    public static void avfilter_link_free(ref AVFilterLink* @link)
    {
        fixed (AVFilterLink** ptr = &@link)
        {
            avfilter_link_free(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string avfilter_pad_get_name_delegate(AVFilterPad* @pads, int @pad_idx);
    private static avfilter_pad_get_name_delegate? _avfilter_pad_get_name_cache;
    
    /// <summary>Get the name of an AVFilterPad.</summary>
    /// <param name="pads">an array of AVFilterPads</param>
    /// <param name="pad_idx">index of the pad in the array; it is the caller&apos;s responsibility to ensure the index is valid</param>
    /// <returns>name of the pad_idx&apos;th pad in pads</returns>
    public static string avfilter_pad_get_name(AVFilterPad* @pads, int @pad_idx)
    {
        _avfilter_pad_get_name_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_pad_get_name_delegate>("avfilter", "avfilter_pad_get_name", ThrowErrorIfFunctionNotFound);
        if (_avfilter_pad_get_name_cache == null)
            throw new NotSupportedException();
        return _avfilter_pad_get_name_cache(@pads, @pad_idx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVMediaType avfilter_pad_get_type_delegate(AVFilterPad* @pads, int @pad_idx);
    private static avfilter_pad_get_type_delegate? _avfilter_pad_get_type_cache;
    
    /// <summary>Get the type of an AVFilterPad.</summary>
    /// <param name="pads">an array of AVFilterPads</param>
    /// <param name="pad_idx">index of the pad in the array; it is the caller&apos;s responsibility to ensure the index is valid</param>
    /// <returns>type of the pad_idx&apos;th pad in pads</returns>
    public static AVMediaType avfilter_pad_get_type(AVFilterPad* @pads, int @pad_idx)
    {
        _avfilter_pad_get_type_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_pad_get_type_delegate>("avfilter", "avfilter_pad_get_type", ThrowErrorIfFunctionNotFound);
        if (_avfilter_pad_get_type_cache == null)
            throw new NotSupportedException();
        return _avfilter_pad_get_type_cache(@pads, @pad_idx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avfilter_process_command_delegate(AVFilterContext* @filter,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @cmd,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @arg, byte* @res, int @res_len, int @flags);
    private static avfilter_process_command_delegate? _avfilter_process_command_cache;
    
    /// <summary>Make the filter instance process a command. It is recommended to use avfilter_graph_send_command().</summary>
    public static int avfilter_process_command(AVFilterContext* @filter,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @cmd,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @arg, byte* @res, int @res_len, int @flags)
    {
        _avfilter_process_command_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_process_command_delegate>("avfilter", "avfilter_process_command", ThrowErrorIfFunctionNotFound);
        if (_avfilter_process_command_cache == null)
            throw new NotSupportedException();
        return _avfilter_process_command_cache(@filter, @cmd, @arg, @res, @res_len, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint avfilter_version_delegate();
    private static avfilter_version_delegate? _avfilter_version_cache;
    
    /// <summary>Return the LIBAVFILTER_VERSION_INT constant.</summary>
    public static uint avfilter_version()
    {
        _avfilter_version_cache ??= FunctionResolver.GetFunctionDelegate<avfilter_version_delegate>("avfilter", "avfilter_version", ThrowErrorIfFunctionNotFound);
        if (_avfilter_version_cache == null)
            throw new NotSupportedException();
        return _avfilter_version_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVFormatContext* avformat_alloc_context_delegate();
    private static avformat_alloc_context_delegate? _avformat_alloc_context_cache;
    
    /// <summary>Allocate an AVFormatContext. avformat_free_context() can be used to free the context and everything allocated by the framework within it.</summary>
    public static AVFormatContext* avformat_alloc_context()
    {
        _avformat_alloc_context_cache ??= FunctionResolver.GetFunctionDelegate<avformat_alloc_context_delegate>("avformat", "avformat_alloc_context", ThrowErrorIfFunctionNotFound);
        if (_avformat_alloc_context_cache == null)
            throw new NotSupportedException();
        return _avformat_alloc_context_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avformat_alloc_output_context2_delegate(AVFormatContext** @ctx, AVOutputFormat* @oformat,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @format_name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename);
    private static avformat_alloc_output_context2_delegate? _avformat_alloc_output_context2_cache;
    
    /// <summary>Allocate an AVFormatContext for an output format. avformat_free_context() can be used to free the context and everything allocated by the framework within it.</summary>
    /// <param name="ctx">pointee is set to the created format context, or to NULL in case of failure</param>
    /// <param name="oformat">format to use for allocating the context, if NULL format_name and filename are used instead</param>
    /// <param name="format_name">the name of output format to use for allocating the context, if NULL filename is used instead</param>
    /// <param name="filename">the name of the filename to use for allocating the context, may be NULL</param>
    /// <returns>&gt;= 0 in case of success, a negative AVERROR code in case of failure</returns>
    public static int avformat_alloc_output_context2(AVFormatContext** @ctx, AVOutputFormat* @oformat,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @format_name,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @filename)
    {
        _avformat_alloc_output_context2_cache ??= FunctionResolver.GetFunctionDelegate<avformat_alloc_output_context2_delegate>("avformat", "avformat_alloc_output_context2", ThrowErrorIfFunctionNotFound);
        if (_avformat_alloc_output_context2_cache == null)
            throw new NotSupportedException();
        return _avformat_alloc_output_context2_cache(@ctx, @oformat, @format_name, @filename);
    }
    
    /// <summary>Allocate an AVFormatContext for an output format. avformat_free_context() can be used to free the context and everything allocated by the framework within it.</summary>
    /// <param name="oformat">format to use for allocating the context, if NULL format_name and filename are used instead</param>
    /// <param name="format_name">the name of output format to use for allocating the context, if NULL filename is used instead</param>
    /// <param name="filename">the name of the filename to use for allocating the context, may be NULL</param>
    /// <returns>&gt;= 0 in case of success, a negative AVERROR code in case of failure</returns>
    public static int avformat_alloc_output_context2(ref AVFormatContext* @ctx, AVOutputFormat* @oformat, string @format_name, string @filename)
    {
        fixed (AVFormatContext** ptr = &@ctx)
        {
            return avformat_alloc_output_context2(ptr, @oformat, @format_name, @filename);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avformat_close_input_delegate(AVFormatContext** @s);
    private static avformat_close_input_delegate? _avformat_close_input_cache;
    
    /// <summary>Close an opened input AVFormatContext. Free it and all its contents and set *s to NULL.</summary>
    public static void avformat_close_input(AVFormatContext** @s)
    {
        _avformat_close_input_cache ??= FunctionResolver.GetFunctionDelegate<avformat_close_input_delegate>("avformat", "avformat_close_input", ThrowErrorIfFunctionNotFound);
        if (_avformat_close_input_cache == null)
            throw new NotSupportedException();
        _avformat_close_input_cache(@s);
    }
    
    /// <summary>Close an opened input AVFormatContext. Free it and all its contents and set *s to NULL.</summary>
    public static void avformat_close_input(ref AVFormatContext* @s)
    {
        fixed (AVFormatContext** ptr = &@s)
        {
            avformat_close_input(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string avformat_configuration_delegate();
    private static avformat_configuration_delegate? _avformat_configuration_cache;
    
    /// <summary>Return the libavformat build-time configuration.</summary>
    public static string avformat_configuration()
    {
        _avformat_configuration_cache ??= FunctionResolver.GetFunctionDelegate<avformat_configuration_delegate>("avformat", "avformat_configuration", ThrowErrorIfFunctionNotFound);
        if (_avformat_configuration_cache == null)
            throw new NotSupportedException();
        return _avformat_configuration_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avformat_find_stream_info_delegate(AVFormatContext* @ic, AVDictionary** @options);
    private static avformat_find_stream_info_delegate? _avformat_find_stream_info_cache;
    
    /// <summary>Read packets of a media file to get stream information. This is useful for file formats with no headers such as MPEG. This function also computes the real framerate in case of MPEG-2 repeat frame mode. The logical file position is not changed by this function; examined packets may be buffered for later processing.</summary>
    /// <param name="ic">media file handle</param>
    /// <param name="options">If non-NULL, an ic.nb_streams long array of pointers to dictionaries, where i-th member contains options for codec corresponding to i-th stream. On return each dictionary will be filled with options that were not found.</param>
    /// <returns>&gt;=0 if OK, AVERROR_xxx on error</returns>
    public static int avformat_find_stream_info(AVFormatContext* @ic, AVDictionary** @options)
    {
        _avformat_find_stream_info_cache ??= FunctionResolver.GetFunctionDelegate<avformat_find_stream_info_delegate>("avformat", "avformat_find_stream_info", ThrowErrorIfFunctionNotFound);
        if (_avformat_find_stream_info_cache == null)
            throw new NotSupportedException();
        return _avformat_find_stream_info_cache(@ic, @options);
    }
    
    /// <summary>Read packets of a media file to get stream information. This is useful for file formats with no headers such as MPEG. This function also computes the real framerate in case of MPEG-2 repeat frame mode. The logical file position is not changed by this function; examined packets may be buffered for later processing.</summary>
    /// <param name="ic">media file handle</param>
    /// <returns>&gt;=0 if OK, AVERROR_xxx on error</returns>
    public static int avformat_find_stream_info(AVFormatContext* @ic, ref AVDictionary* @options)
    {
        fixed (AVDictionary** ptr = &@options)
        {
            return avformat_find_stream_info(@ic, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avformat_flush_delegate(AVFormatContext* @s);
    private static avformat_flush_delegate? _avformat_flush_cache;
    
    /// <summary>Discard all internally buffered data. This can be useful when dealing with discontinuities in the byte stream. Generally works only with formats that can resync. This includes headerless formats like MPEG-TS/TS but should also work with NUT, Ogg and in a limited way AVI for example.</summary>
    /// <param name="s">media file handle</param>
    /// <returns>&gt;=0 on success, error code otherwise</returns>
    public static int avformat_flush(AVFormatContext* @s)
    {
        _avformat_flush_cache ??= FunctionResolver.GetFunctionDelegate<avformat_flush_delegate>("avformat", "avformat_flush", ThrowErrorIfFunctionNotFound);
        if (_avformat_flush_cache == null)
            throw new NotSupportedException();
        return _avformat_flush_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avformat_free_context_delegate(AVFormatContext* @s);
    private static avformat_free_context_delegate? _avformat_free_context_cache;
    
    /// <summary>Free an AVFormatContext and all its streams.</summary>
    /// <param name="s">context to free</param>
    public static void avformat_free_context(AVFormatContext* @s)
    {
        _avformat_free_context_cache ??= FunctionResolver.GetFunctionDelegate<avformat_free_context_delegate>("avformat", "avformat_free_context", ThrowErrorIfFunctionNotFound);
        if (_avformat_free_context_cache == null)
            throw new NotSupportedException();
        _avformat_free_context_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVClass* avformat_get_class_delegate();
    private static avformat_get_class_delegate? _avformat_get_class_cache;
    
    /// <summary>Get the AVClass for AVFormatContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
    public static AVClass* avformat_get_class()
    {
        _avformat_get_class_cache ??= FunctionResolver.GetFunctionDelegate<avformat_get_class_delegate>("avformat", "avformat_get_class", ThrowErrorIfFunctionNotFound);
        if (_avformat_get_class_cache == null)
            throw new NotSupportedException();
        return _avformat_get_class_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodecTag* avformat_get_mov_audio_tags_delegate();
    private static avformat_get_mov_audio_tags_delegate? _avformat_get_mov_audio_tags_cache;
    
    /// <summary>Returns the table mapping MOV FourCCs for audio to AVCodecID.</summary>
    /// <returns>the table mapping MOV FourCCs for audio to AVCodecID.</returns>
    public static AVCodecTag* avformat_get_mov_audio_tags()
    {
        _avformat_get_mov_audio_tags_cache ??= FunctionResolver.GetFunctionDelegate<avformat_get_mov_audio_tags_delegate>("avformat", "avformat_get_mov_audio_tags", ThrowErrorIfFunctionNotFound);
        if (_avformat_get_mov_audio_tags_cache == null)
            throw new NotSupportedException();
        return _avformat_get_mov_audio_tags_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodecTag* avformat_get_mov_video_tags_delegate();
    private static avformat_get_mov_video_tags_delegate? _avformat_get_mov_video_tags_cache;
    
    /// <summary>Returns the table mapping MOV FourCCs for video to libavcodec AVCodecID.</summary>
    /// <returns>the table mapping MOV FourCCs for video to libavcodec AVCodecID.</returns>
    public static AVCodecTag* avformat_get_mov_video_tags()
    {
        _avformat_get_mov_video_tags_cache ??= FunctionResolver.GetFunctionDelegate<avformat_get_mov_video_tags_delegate>("avformat", "avformat_get_mov_video_tags", ThrowErrorIfFunctionNotFound);
        if (_avformat_get_mov_video_tags_cache == null)
            throw new NotSupportedException();
        return _avformat_get_mov_video_tags_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodecTag* avformat_get_riff_audio_tags_delegate();
    private static avformat_get_riff_audio_tags_delegate? _avformat_get_riff_audio_tags_cache;
    
    /// <summary>Returns the table mapping RIFF FourCCs for audio to AVCodecID.</summary>
    /// <returns>the table mapping RIFF FourCCs for audio to AVCodecID.</returns>
    public static AVCodecTag* avformat_get_riff_audio_tags()
    {
        _avformat_get_riff_audio_tags_cache ??= FunctionResolver.GetFunctionDelegate<avformat_get_riff_audio_tags_delegate>("avformat", "avformat_get_riff_audio_tags", ThrowErrorIfFunctionNotFound);
        if (_avformat_get_riff_audio_tags_cache == null)
            throw new NotSupportedException();
        return _avformat_get_riff_audio_tags_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVCodecTag* avformat_get_riff_video_tags_delegate();
    private static avformat_get_riff_video_tags_delegate? _avformat_get_riff_video_tags_cache;
    
    /// <summary>@{ Get the tables mapping RIFF FourCCs to libavcodec AVCodecIDs. The tables are meant to be passed to av_codec_get_id()/av_codec_get_tag() as in the following code:</summary>
    /// <returns>the table mapping RIFF FourCCs for video to libavcodec AVCodecID.</returns>
    public static AVCodecTag* avformat_get_riff_video_tags()
    {
        _avformat_get_riff_video_tags_cache ??= FunctionResolver.GetFunctionDelegate<avformat_get_riff_video_tags_delegate>("avformat", "avformat_get_riff_video_tags", ThrowErrorIfFunctionNotFound);
        if (_avformat_get_riff_video_tags_cache == null)
            throw new NotSupportedException();
        return _avformat_get_riff_video_tags_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avformat_index_get_entries_count_delegate(AVStream* @st);
    private static avformat_index_get_entries_count_delegate? _avformat_index_get_entries_count_cache;
    
    /// <summary>Get the index entry count for the given AVStream.</summary>
    /// <param name="st">stream</param>
    /// <returns>the number of index entries in the stream</returns>
    public static int avformat_index_get_entries_count(AVStream* @st)
    {
        _avformat_index_get_entries_count_cache ??= FunctionResolver.GetFunctionDelegate<avformat_index_get_entries_count_delegate>("avformat", "avformat_index_get_entries_count", ThrowErrorIfFunctionNotFound);
        if (_avformat_index_get_entries_count_cache == null)
            throw new NotSupportedException();
        return _avformat_index_get_entries_count_cache(@st);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVIndexEntry* avformat_index_get_entry_delegate(AVStream* @st, int @idx);
    private static avformat_index_get_entry_delegate? _avformat_index_get_entry_cache;
    
    /// <summary>Get the AVIndexEntry corresponding to the given index.</summary>
    /// <param name="st">Stream containing the requested AVIndexEntry.</param>
    /// <param name="idx">The desired index.</param>
    /// <returns>A pointer to the requested AVIndexEntry if it exists, NULL otherwise.</returns>
    public static AVIndexEntry* avformat_index_get_entry(AVStream* @st, int @idx)
    {
        _avformat_index_get_entry_cache ??= FunctionResolver.GetFunctionDelegate<avformat_index_get_entry_delegate>("avformat", "avformat_index_get_entry", ThrowErrorIfFunctionNotFound);
        if (_avformat_index_get_entry_cache == null)
            throw new NotSupportedException();
        return _avformat_index_get_entry_cache(@st, @idx);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVIndexEntry* avformat_index_get_entry_from_timestamp_delegate(AVStream* @st, long @wanted_timestamp, int @flags);
    private static avformat_index_get_entry_from_timestamp_delegate? _avformat_index_get_entry_from_timestamp_cache;
    
    /// <summary>Get the AVIndexEntry corresponding to the given timestamp.</summary>
    /// <param name="st">Stream containing the requested AVIndexEntry.</param>
    /// <param name="wanted_timestamp">Timestamp to retrieve the index entry for.</param>
    /// <param name="flags">If AVSEEK_FLAG_BACKWARD then the returned entry will correspond to the timestamp which is &lt; = the requested one, if backward is 0, then it will be &gt;= if AVSEEK_FLAG_ANY seek to any frame, only keyframes otherwise.</param>
    /// <returns>A pointer to the requested AVIndexEntry if it exists, NULL otherwise.</returns>
    public static AVIndexEntry* avformat_index_get_entry_from_timestamp(AVStream* @st, long @wanted_timestamp, int @flags)
    {
        _avformat_index_get_entry_from_timestamp_cache ??= FunctionResolver.GetFunctionDelegate<avformat_index_get_entry_from_timestamp_delegate>("avformat", "avformat_index_get_entry_from_timestamp", ThrowErrorIfFunctionNotFound);
        if (_avformat_index_get_entry_from_timestamp_cache == null)
            throw new NotSupportedException();
        return _avformat_index_get_entry_from_timestamp_cache(@st, @wanted_timestamp, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avformat_init_output_delegate(AVFormatContext* @s, AVDictionary** @options);
    private static avformat_init_output_delegate? _avformat_init_output_cache;
    
    /// <summary>Allocate the stream private data and initialize the codec, but do not write the header. May optionally be used before avformat_write_header() to initialize stream parameters before actually writing the header. If using this function, do not pass the same options to avformat_write_header().</summary>
    /// <param name="s">Media file handle, must be allocated with avformat_alloc_context(). Its &quot;oformat&quot; field must be set to the desired output format; Its &quot;pb&quot; field must be set to an already opened ::AVIOContext.</param>
    /// <param name="options">An ::AVDictionary filled with AVFormatContext and muxer-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
    public static int avformat_init_output(AVFormatContext* @s, AVDictionary** @options)
    {
        _avformat_init_output_cache ??= FunctionResolver.GetFunctionDelegate<avformat_init_output_delegate>("avformat", "avformat_init_output", ThrowErrorIfFunctionNotFound);
        if (_avformat_init_output_cache == null)
            throw new NotSupportedException();
        return _avformat_init_output_cache(@s, @options);
    }
    
    /// <summary>Allocate the stream private data and initialize the codec, but do not write the header. May optionally be used before avformat_write_header() to initialize stream parameters before actually writing the header. If using this function, do not pass the same options to avformat_write_header().</summary>
    /// <param name="s">Media file handle, must be allocated with avformat_alloc_context(). Its &quot;oformat&quot; field must be set to the desired output format; Its &quot;pb&quot; field must be set to an already opened ::AVIOContext.</param>
    public static int avformat_init_output(AVFormatContext* @s, ref AVDictionary* @options)
    {
        fixed (AVDictionary** ptr = &@options)
        {
            return avformat_init_output(@s, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string avformat_license_delegate();
    private static avformat_license_delegate? _avformat_license_cache;
    
    /// <summary>Return the libavformat license.</summary>
    public static string avformat_license()
    {
        _avformat_license_cache ??= FunctionResolver.GetFunctionDelegate<avformat_license_delegate>("avformat", "avformat_license", ThrowErrorIfFunctionNotFound);
        if (_avformat_license_cache == null)
            throw new NotSupportedException();
        return _avformat_license_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avformat_match_stream_specifier_delegate(AVFormatContext* @s, AVStream* @st,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @spec);
    private static avformat_match_stream_specifier_delegate? _avformat_match_stream_specifier_cache;
    
    /// <summary>Check if the stream st contained in s is matched by the stream specifier spec.</summary>
    /// <returns>&gt;0 if st is matched by spec; 0  if st is not matched by spec; AVERROR code if spec is invalid</returns>
    public static int avformat_match_stream_specifier(AVFormatContext* @s, AVStream* @st,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @spec)
    {
        _avformat_match_stream_specifier_cache ??= FunctionResolver.GetFunctionDelegate<avformat_match_stream_specifier_delegate>("avformat", "avformat_match_stream_specifier", ThrowErrorIfFunctionNotFound);
        if (_avformat_match_stream_specifier_cache == null)
            throw new NotSupportedException();
        return _avformat_match_stream_specifier_cache(@s, @st, @spec);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avformat_network_deinit_delegate();
    private static avformat_network_deinit_delegate? _avformat_network_deinit_cache;
    
    /// <summary>Undo the initialization done by avformat_network_init. Call it only once for each time you called avformat_network_init.</summary>
    public static int avformat_network_deinit()
    {
        _avformat_network_deinit_cache ??= FunctionResolver.GetFunctionDelegate<avformat_network_deinit_delegate>("avformat", "avformat_network_deinit", ThrowErrorIfFunctionNotFound);
        if (_avformat_network_deinit_cache == null)
            throw new NotSupportedException();
        return _avformat_network_deinit_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avformat_network_init_delegate();
    private static avformat_network_init_delegate? _avformat_network_init_cache;
    
    /// <summary>Do global initialization of network libraries. This is optional, and not recommended anymore.</summary>
    public static int avformat_network_init()
    {
        _avformat_network_init_cache ??= FunctionResolver.GetFunctionDelegate<avformat_network_init_delegate>("avformat", "avformat_network_init", ThrowErrorIfFunctionNotFound);
        if (_avformat_network_init_cache == null)
            throw new NotSupportedException();
        return _avformat_network_init_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVStream* avformat_new_stream_delegate(AVFormatContext* @s, AVCodec* @c);
    private static avformat_new_stream_delegate? _avformat_new_stream_cache;
    
    /// <summary>Add a new stream to a media file.</summary>
    /// <param name="s">media file handle</param>
    /// <param name="c">unused, does nothing</param>
    /// <returns>newly created stream or NULL on error.</returns>
    public static AVStream* avformat_new_stream(AVFormatContext* @s, AVCodec* @c)
    {
        _avformat_new_stream_cache ??= FunctionResolver.GetFunctionDelegate<avformat_new_stream_delegate>("avformat", "avformat_new_stream", ThrowErrorIfFunctionNotFound);
        if (_avformat_new_stream_cache == null)
            throw new NotSupportedException();
        return _avformat_new_stream_cache(@s, @c);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avformat_open_input_delegate(AVFormatContext** @ps,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, AVInputFormat* @fmt, AVDictionary** @options);
    private static avformat_open_input_delegate? _avformat_open_input_cache;
    
    /// <summary>Open an input stream and read the header. The codecs are not opened. The stream must be closed with avformat_close_input().</summary>
    /// <param name="ps">Pointer to user-supplied AVFormatContext (allocated by avformat_alloc_context). May be a pointer to NULL, in which case an AVFormatContext is allocated by this function and written into ps. Note that a user-supplied AVFormatContext will be freed on failure.</param>
    /// <param name="url">URL of the stream to open.</param>
    /// <param name="fmt">If non-NULL, this parameter forces a specific input format. Otherwise the format is autodetected.</param>
    /// <param name="options">A dictionary filled with AVFormatContext and demuxer-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
    /// <returns>0 on success, a negative AVERROR on failure.</returns>
    public static int avformat_open_input(AVFormatContext** @ps,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, AVInputFormat* @fmt, AVDictionary** @options)
    {
        _avformat_open_input_cache ??= FunctionResolver.GetFunctionDelegate<avformat_open_input_delegate>("avformat", "avformat_open_input", ThrowErrorIfFunctionNotFound);
        if (_avformat_open_input_cache == null)
            throw new NotSupportedException();
        return _avformat_open_input_cache(@ps, @url, @fmt, @options);
    }
    
    /// <summary>Open an input stream and read the header. The codecs are not opened. The stream must be closed with avformat_close_input().</summary>
    /// <param name="url">URL of the stream to open.</param>
    /// <param name="fmt">If non-NULL, this parameter forces a specific input format. Otherwise the format is autodetected.</param>
    /// <param name="options">A dictionary filled with AVFormatContext and demuxer-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
    /// <returns>0 on success, a negative AVERROR on failure.</returns>
    public static int avformat_open_input(ref AVFormatContext* @ps, string @url, AVInputFormat* @fmt, AVDictionary** @options)
    {
        fixed (AVFormatContext** ptr = &@ps)
        {
            return avformat_open_input(ptr, @url, @fmt, @options);
        }
    }
    
    /// <summary>Open an input stream and read the header. The codecs are not opened. The stream must be closed with avformat_close_input().</summary>
    /// <param name="ps">Pointer to user-supplied AVFormatContext (allocated by avformat_alloc_context). May be a pointer to NULL, in which case an AVFormatContext is allocated by this function and written into ps. Note that a user-supplied AVFormatContext will be freed on failure.</param>
    /// <param name="url">URL of the stream to open.</param>
    /// <param name="fmt">If non-NULL, this parameter forces a specific input format. Otherwise the format is autodetected.</param>
    /// <returns>0 on success, a negative AVERROR on failure.</returns>
    public static int avformat_open_input(AVFormatContext** @ps, string @url, AVInputFormat* @fmt, ref AVDictionary* @options)
    {
        fixed (AVDictionary** ptr = &@options)
        {
            return avformat_open_input(@ps, @url, @fmt, ptr);
        }
    }
    
    /// <summary>Open an input stream and read the header. The codecs are not opened. The stream must be closed with avformat_close_input().</summary>
    /// <param name="url">URL of the stream to open.</param>
    /// <param name="fmt">If non-NULL, this parameter forces a specific input format. Otherwise the format is autodetected.</param>
    /// <returns>0 on success, a negative AVERROR on failure.</returns>
    public static int avformat_open_input(ref AVFormatContext* @ps, string @url, AVInputFormat* @fmt, ref AVDictionary* @options)
    {
        fixed (AVFormatContext** ptr1 = &@ps)
        {
        fixed (AVDictionary** ptr2 = &@options)
        {
                return avformat_open_input(ptr1, @url, @fmt, ptr2);
        }
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avformat_query_codec_delegate(AVOutputFormat* @ofmt, AVCodecID @codec_id, int @std_compliance);
    private static avformat_query_codec_delegate? _avformat_query_codec_cache;
    
    /// <summary>Test if the given container can store a codec.</summary>
    /// <param name="ofmt">container to check for compatibility</param>
    /// <param name="codec_id">codec to potentially store in container</param>
    /// <param name="std_compliance">standards compliance level, one of FF_COMPLIANCE_*</param>
    /// <returns>1 if codec with ID codec_id can be stored in ofmt, 0 if it cannot. A negative number if this information is not available.</returns>
    public static int avformat_query_codec(AVOutputFormat* @ofmt, AVCodecID @codec_id, int @std_compliance)
    {
        _avformat_query_codec_cache ??= FunctionResolver.GetFunctionDelegate<avformat_query_codec_delegate>("avformat", "avformat_query_codec", ThrowErrorIfFunctionNotFound);
        if (_avformat_query_codec_cache == null)
            throw new NotSupportedException();
        return _avformat_query_codec_cache(@ofmt, @codec_id, @std_compliance);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avformat_queue_attached_pictures_delegate(AVFormatContext* @s);
    private static avformat_queue_attached_pictures_delegate? _avformat_queue_attached_pictures_cache;
    
    public static int avformat_queue_attached_pictures(AVFormatContext* @s)
    {
        _avformat_queue_attached_pictures_cache ??= FunctionResolver.GetFunctionDelegate<avformat_queue_attached_pictures_delegate>("avformat", "avformat_queue_attached_pictures", ThrowErrorIfFunctionNotFound);
        if (_avformat_queue_attached_pictures_cache == null)
            throw new NotSupportedException();
        return _avformat_queue_attached_pictures_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avformat_seek_file_delegate(AVFormatContext* @s, int @stream_index, long @min_ts, long @ts, long @max_ts, int @flags);
    private static avformat_seek_file_delegate? _avformat_seek_file_cache;
    
    /// <summary>Seek to timestamp ts. Seeking will be done so that the point from which all active streams can be presented successfully will be closest to ts and within min/max_ts. Active streams are all streams that have AVStream.discard &lt; AVDISCARD_ALL.</summary>
    /// <param name="s">media file handle</param>
    /// <param name="stream_index">index of the stream which is used as time base reference</param>
    /// <param name="min_ts">smallest acceptable timestamp</param>
    /// <param name="ts">target timestamp</param>
    /// <param name="max_ts">largest acceptable timestamp</param>
    /// <param name="flags">flags</param>
    /// <returns>&gt;=0 on success, error code otherwise</returns>
    public static int avformat_seek_file(AVFormatContext* @s, int @stream_index, long @min_ts, long @ts, long @max_ts, int @flags)
    {
        _avformat_seek_file_cache ??= FunctionResolver.GetFunctionDelegate<avformat_seek_file_delegate>("avformat", "avformat_seek_file", ThrowErrorIfFunctionNotFound);
        if (_avformat_seek_file_cache == null)
            throw new NotSupportedException();
        return _avformat_seek_file_cache(@s, @stream_index, @min_ts, @ts, @max_ts, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avformat_stream_group_add_stream_delegate(AVStreamGroup* @stg, AVStream* @st);
    private static avformat_stream_group_add_stream_delegate? _avformat_stream_group_add_stream_cache;
    
    /// <summary>Add an already allocated stream to a stream group.</summary>
    /// <param name="stg">stream group belonging to a media file.</param>
    /// <param name="st">stream in the media file to add to the group.</param>
    public static int avformat_stream_group_add_stream(AVStreamGroup* @stg, AVStream* @st)
    {
        _avformat_stream_group_add_stream_cache ??= FunctionResolver.GetFunctionDelegate<avformat_stream_group_add_stream_delegate>("avformat", "avformat_stream_group_add_stream", ThrowErrorIfFunctionNotFound);
        if (_avformat_stream_group_add_stream_cache == null)
            throw new NotSupportedException();
        return _avformat_stream_group_add_stream_cache(@stg, @st);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVStreamGroup* avformat_stream_group_create_delegate(AVFormatContext* @s, AVStreamGroupParamsType @type, AVDictionary** @options);
    private static avformat_stream_group_create_delegate? _avformat_stream_group_create_cache;
    
    /// <summary>Add a new empty stream group to a media file.</summary>
    /// <param name="s">media file handle</param>
    /// <returns>newly created group or NULL on error.</returns>
    public static AVStreamGroup* avformat_stream_group_create(AVFormatContext* @s, AVStreamGroupParamsType @type, AVDictionary** @options)
    {
        _avformat_stream_group_create_cache ??= FunctionResolver.GetFunctionDelegate<avformat_stream_group_create_delegate>("avformat", "avformat_stream_group_create", ThrowErrorIfFunctionNotFound);
        if (_avformat_stream_group_create_cache == null)
            throw new NotSupportedException();
        return _avformat_stream_group_create_cache(@s, @type, @options);
    }
    
    /// <summary>Add a new empty stream group to a media file.</summary>
    /// <param name="s">media file handle</param>
    /// <returns>newly created group or NULL on error.</returns>
    public static AVStreamGroup* avformat_stream_group_create(AVFormatContext* @s, AVStreamGroupParamsType @type, ref AVDictionary* @options)
    {
        fixed (AVDictionary** ptr = &@options)
        {
            return avformat_stream_group_create(@s, @type, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string avformat_stream_group_name_delegate(AVStreamGroupParamsType @type);
    private static avformat_stream_group_name_delegate? _avformat_stream_group_name_cache;
    
    /// <summary>Returns a string identifying the stream group type, or NULL if unknown</summary>
    /// <returns>a string identifying the stream group type, or NULL if unknown</returns>
    public static string avformat_stream_group_name(AVStreamGroupParamsType @type)
    {
        _avformat_stream_group_name_cache ??= FunctionResolver.GetFunctionDelegate<avformat_stream_group_name_delegate>("avformat", "avformat_stream_group_name", ThrowErrorIfFunctionNotFound);
        if (_avformat_stream_group_name_cache == null)
            throw new NotSupportedException();
        return _avformat_stream_group_name_cache(@type);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avformat_transfer_internal_stream_timing_info_delegate(AVOutputFormat* @ofmt, AVStream* @ost, AVStream* @ist, AVTimebaseSource @copy_tb);
    private static avformat_transfer_internal_stream_timing_info_delegate? _avformat_transfer_internal_stream_timing_info_cache;
    
    [Obsolete("do not call this function")]
    public static int avformat_transfer_internal_stream_timing_info(AVOutputFormat* @ofmt, AVStream* @ost, AVStream* @ist, AVTimebaseSource @copy_tb)
    {
        _avformat_transfer_internal_stream_timing_info_cache ??= FunctionResolver.GetFunctionDelegate<avformat_transfer_internal_stream_timing_info_delegate>("avformat", "avformat_transfer_internal_stream_timing_info", ThrowErrorIfFunctionNotFound);
        if (_avformat_transfer_internal_stream_timing_info_cache == null)
            throw new NotSupportedException();
        return _avformat_transfer_internal_stream_timing_info_cache(@ofmt, @ost, @ist, @copy_tb);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint avformat_version_delegate();
    private static avformat_version_delegate? _avformat_version_cache;
    
    /// <summary>Return the LIBAVFORMAT_VERSION_INT constant.</summary>
    public static uint avformat_version()
    {
        _avformat_version_cache ??= FunctionResolver.GetFunctionDelegate<avformat_version_delegate>("avformat", "avformat_version", ThrowErrorIfFunctionNotFound);
        if (_avformat_version_cache == null)
            throw new NotSupportedException();
        return _avformat_version_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avformat_write_header_delegate(AVFormatContext* @s, AVDictionary** @options);
    private static avformat_write_header_delegate? _avformat_write_header_cache;
    
    /// <summary>Allocate the stream private data and write the stream header to an output media file.</summary>
    /// <param name="s">Media file handle, must be allocated with avformat_alloc_context(). Its &quot;oformat&quot; field must be set to the desired output format; Its &quot;pb&quot; field must be set to an already opened ::AVIOContext.</param>
    /// <param name="options">An ::AVDictionary filled with AVFormatContext and muxer-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
    public static int avformat_write_header(AVFormatContext* @s, AVDictionary** @options)
    {
        _avformat_write_header_cache ??= FunctionResolver.GetFunctionDelegate<avformat_write_header_delegate>("avformat", "avformat_write_header", ThrowErrorIfFunctionNotFound);
        if (_avformat_write_header_cache == null)
            throw new NotSupportedException();
        return _avformat_write_header_cache(@s, @options);
    }
    
    /// <summary>Allocate the stream private data and write the stream header to an output media file.</summary>
    /// <param name="s">Media file handle, must be allocated with avformat_alloc_context(). Its &quot;oformat&quot; field must be set to the desired output format; Its &quot;pb&quot; field must be set to an already opened ::AVIOContext.</param>
    public static int avformat_write_header(AVFormatContext* @s, ref AVDictionary* @options)
    {
        fixed (AVDictionary** ptr = &@options)
        {
            return avformat_write_header(@s, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_accept_delegate(AVIOContext* @s, AVIOContext** @c);
    private static avio_accept_delegate? _avio_accept_cache;
    
    /// <summary>Accept and allocate a client context on a server context.</summary>
    /// <param name="s">the server context</param>
    /// <param name="c">the client context, must be unallocated</param>
    /// <returns>&gt;= 0 on success or a negative value corresponding to an AVERROR on failure</returns>
    public static int avio_accept(AVIOContext* @s, AVIOContext** @c)
    {
        _avio_accept_cache ??= FunctionResolver.GetFunctionDelegate<avio_accept_delegate>("avformat", "avio_accept", ThrowErrorIfFunctionNotFound);
        if (_avio_accept_cache == null)
            throw new NotSupportedException();
        return _avio_accept_cache(@s, @c);
    }
    
    /// <summary>Accept and allocate a client context on a server context.</summary>
    /// <param name="s">the server context</param>
    /// <returns>&gt;= 0 on success or a negative value corresponding to an AVERROR on failure</returns>
    public static int avio_accept(AVIOContext* @s, ref AVIOContext* @c)
    {
        fixed (AVIOContext** ptr = &@c)
        {
            return avio_accept(@s, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVIOContext* avio_alloc_context_delegate(byte* @buffer, int @buffer_size, int @write_flag, void* @opaque, avio_alloc_context_read_packet_func @read_packet, avio_alloc_context_write_packet_func @write_packet, avio_alloc_context_seek_func @seek);
    private static avio_alloc_context_delegate? _avio_alloc_context_cache;
    
    /// <summary>Allocate and initialize an AVIOContext for buffered I/O. It must be later freed with avio_context_free().</summary>
    /// <param name="buffer">Memory block for input/output operations via AVIOContext. The buffer must be allocated with av_malloc() and friends. It may be freed and replaced with a new buffer by libavformat. AVIOContext.buffer holds the buffer currently in use, which must be later freed with av_free().</param>
    /// <param name="buffer_size">The buffer size is very important for performance. For protocols with fixed blocksize it should be set to this blocksize. For others a typical size is a cache page, e.g. 4kb.</param>
    /// <param name="write_flag">Set to 1 if the buffer should be writable, 0 otherwise.</param>
    /// <param name="opaque">An opaque pointer to user-specific data.</param>
    /// <param name="read_packet">A function for refilling the buffer, may be NULL. For stream protocols, must never return 0 but rather a proper AVERROR code.</param>
    /// <param name="write_packet">A function for writing the buffer contents, may be NULL. The function may not change the input buffers content.</param>
    /// <param name="seek">A function for seeking to specified byte position, may be NULL.</param>
    /// <returns>Allocated AVIOContext or NULL on failure.</returns>
    public static AVIOContext* avio_alloc_context(byte* @buffer, int @buffer_size, int @write_flag, void* @opaque, avio_alloc_context_read_packet_func @read_packet, avio_alloc_context_write_packet_func @write_packet, avio_alloc_context_seek_func @seek)
    {
        _avio_alloc_context_cache ??= FunctionResolver.GetFunctionDelegate<avio_alloc_context_delegate>("avformat", "avio_alloc_context", ThrowErrorIfFunctionNotFound);
        if (_avio_alloc_context_cache == null)
            throw new NotSupportedException();
        return _avio_alloc_context_cache(@buffer, @buffer_size, @write_flag, @opaque, @read_packet, @write_packet, @seek);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_check_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, int @flags);
    private static avio_check_delegate? _avio_check_cache;
    
    /// <summary>Return AVIO_FLAG_* access flags corresponding to the access permissions of the resource in url, or a negative value corresponding to an AVERROR code in case of failure. The returned access flags are masked by the value in flags.</summary>
    public static int avio_check(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, int @flags)
    {
        _avio_check_cache ??= FunctionResolver.GetFunctionDelegate<avio_check_delegate>("avformat", "avio_check", ThrowErrorIfFunctionNotFound);
        if (_avio_check_cache == null)
            throw new NotSupportedException();
        return _avio_check_cache(@url, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_close_delegate(AVIOContext* @s);
    private static avio_close_delegate? _avio_close_cache;
    
    /// <summary>Close the resource accessed by the AVIOContext s and free it. This function can only be used if s was opened by avio_open().</summary>
    /// <returns>0 on success, an AVERROR &lt; 0 on error.</returns>
    public static int avio_close(AVIOContext* @s)
    {
        _avio_close_cache ??= FunctionResolver.GetFunctionDelegate<avio_close_delegate>("avformat", "avio_close", ThrowErrorIfFunctionNotFound);
        if (_avio_close_cache == null)
            throw new NotSupportedException();
        return _avio_close_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_close_dir_delegate(AVIODirContext** @s);
    private static avio_close_dir_delegate? _avio_close_dir_cache;
    
    /// <summary>Close directory.</summary>
    /// <param name="s">directory read context.</param>
    /// <returns>&gt;=0 on success or negative on error.</returns>
    public static int avio_close_dir(AVIODirContext** @s)
    {
        _avio_close_dir_cache ??= FunctionResolver.GetFunctionDelegate<avio_close_dir_delegate>("avformat", "avio_close_dir", ThrowErrorIfFunctionNotFound);
        if (_avio_close_dir_cache == null)
            throw new NotSupportedException();
        return _avio_close_dir_cache(@s);
    }
    
    /// <summary>Close directory.</summary>
    /// <returns>&gt;=0 on success or negative on error.</returns>
    public static int avio_close_dir(ref AVIODirContext* @s)
    {
        fixed (AVIODirContext** ptr = &@s)
        {
            return avio_close_dir(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_close_dyn_buf_delegate(AVIOContext* @s, byte** @pbuffer);
    private static avio_close_dyn_buf_delegate? _avio_close_dyn_buf_cache;
    
    /// <summary>Return the written size and a pointer to the buffer. The buffer must be freed with av_free(). Padding of AV_INPUT_BUFFER_PADDING_SIZE is added to the buffer.</summary>
    /// <param name="s">IO context</param>
    /// <param name="pbuffer">pointer to a byte buffer</param>
    /// <returns>the length of the byte buffer</returns>
    public static int avio_close_dyn_buf(AVIOContext* @s, byte** @pbuffer)
    {
        _avio_close_dyn_buf_cache ??= FunctionResolver.GetFunctionDelegate<avio_close_dyn_buf_delegate>("avformat", "avio_close_dyn_buf", ThrowErrorIfFunctionNotFound);
        if (_avio_close_dyn_buf_cache == null)
            throw new NotSupportedException();
        return _avio_close_dyn_buf_cache(@s, @pbuffer);
    }
    
    /// <summary>Return the written size and a pointer to the buffer. The buffer must be freed with av_free(). Padding of AV_INPUT_BUFFER_PADDING_SIZE is added to the buffer.</summary>
    /// <param name="s">IO context</param>
    /// <returns>the length of the byte buffer</returns>
    public static int avio_close_dyn_buf(AVIOContext* @s, ref byte* @pbuffer)
    {
        fixed (byte** ptr = &@pbuffer)
        {
            return avio_close_dyn_buf(@s, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_closep_delegate(AVIOContext** @s);
    private static avio_closep_delegate? _avio_closep_cache;
    
    /// <summary>Close the resource accessed by the AVIOContext *s, free it and set the pointer pointing to it to NULL. This function can only be used if s was opened by avio_open().</summary>
    /// <returns>0 on success, an AVERROR &lt; 0 on error.</returns>
    public static int avio_closep(AVIOContext** @s)
    {
        _avio_closep_cache ??= FunctionResolver.GetFunctionDelegate<avio_closep_delegate>("avformat", "avio_closep", ThrowErrorIfFunctionNotFound);
        if (_avio_closep_cache == null)
            throw new NotSupportedException();
        return _avio_closep_cache(@s);
    }
    
    /// <summary>Close the resource accessed by the AVIOContext *s, free it and set the pointer pointing to it to NULL. This function can only be used if s was opened by avio_open().</summary>
    /// <returns>0 on success, an AVERROR &lt; 0 on error.</returns>
    public static int avio_closep(ref AVIOContext* @s)
    {
        fixed (AVIOContext** ptr = &@s)
        {
            return avio_closep(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avio_context_free_delegate(AVIOContext** @s);
    private static avio_context_free_delegate? _avio_context_free_cache;
    
    /// <summary>Free the supplied IO context and everything associated with it.</summary>
    /// <param name="s">Double pointer to the IO context. This function will write NULL into s.</param>
    public static void avio_context_free(AVIOContext** @s)
    {
        _avio_context_free_cache ??= FunctionResolver.GetFunctionDelegate<avio_context_free_delegate>("avformat", "avio_context_free", ThrowErrorIfFunctionNotFound);
        if (_avio_context_free_cache == null)
            throw new NotSupportedException();
        _avio_context_free_cache(@s);
    }
    
    /// <summary>Free the supplied IO context and everything associated with it.</summary>
    public static void avio_context_free(ref AVIOContext* @s)
    {
        fixed (AVIOContext** ptr = &@s)
        {
            avio_context_free(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string avio_enum_protocols_delegate(void** @opaque, int @output);
    private static avio_enum_protocols_delegate? _avio_enum_protocols_cache;
    
    /// <summary>Iterate through names of available protocols.</summary>
    /// <param name="opaque">A private pointer representing current protocol. It must be a pointer to NULL on first iteration and will be updated by successive calls to avio_enum_protocols.</param>
    /// <param name="output">If set to 1, iterate over output protocols, otherwise over input protocols.</param>
    /// <returns>A static string containing the name of current protocol or NULL</returns>
    public static string avio_enum_protocols(void** @opaque, int @output)
    {
        _avio_enum_protocols_cache ??= FunctionResolver.GetFunctionDelegate<avio_enum_protocols_delegate>("avformat", "avio_enum_protocols", ThrowErrorIfFunctionNotFound);
        if (_avio_enum_protocols_cache == null)
            throw new NotSupportedException();
        return _avio_enum_protocols_cache(@opaque, @output);
    }
    
    /// <summary>Iterate through names of available protocols.</summary>
    /// <param name="output">If set to 1, iterate over output protocols, otherwise over input protocols.</param>
    /// <returns>A static string containing the name of current protocol or NULL</returns>
    public static string avio_enum_protocols(ref void* @opaque, int @output)
    {
        fixed (void** ptr = &@opaque)
        {
            return avio_enum_protocols(ptr, @output);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_feof_delegate(AVIOContext* @s);
    private static avio_feof_delegate? _avio_feof_cache;
    
    /// <summary>Similar to feof() but also returns nonzero on read errors.</summary>
    /// <returns>non zero if and only if at end of file or a read error happened when reading.</returns>
    public static int avio_feof(AVIOContext* @s)
    {
        _avio_feof_cache ??= FunctionResolver.GetFunctionDelegate<avio_feof_delegate>("avformat", "avio_feof", ThrowErrorIfFunctionNotFound);
        if (_avio_feof_cache == null)
            throw new NotSupportedException();
        return _avio_feof_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string avio_find_protocol_name_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url);
    private static avio_find_protocol_name_delegate? _avio_find_protocol_name_cache;
    
    /// <summary>Return the name of the protocol that will handle the passed URL.</summary>
    /// <returns>Name of the protocol or NULL.</returns>
    public static string avio_find_protocol_name(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url)
    {
        _avio_find_protocol_name_cache ??= FunctionResolver.GetFunctionDelegate<avio_find_protocol_name_delegate>("avformat", "avio_find_protocol_name", ThrowErrorIfFunctionNotFound);
        if (_avio_find_protocol_name_cache == null)
            throw new NotSupportedException();
        return _avio_find_protocol_name_cache(@url);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avio_flush_delegate(AVIOContext* @s);
    private static avio_flush_delegate? _avio_flush_cache;
    
    /// <summary>Force flushing of buffered data.</summary>
    public static void avio_flush(AVIOContext* @s)
    {
        _avio_flush_cache ??= FunctionResolver.GetFunctionDelegate<avio_flush_delegate>("avformat", "avio_flush", ThrowErrorIfFunctionNotFound);
        if (_avio_flush_cache == null)
            throw new NotSupportedException();
        _avio_flush_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avio_free_directory_entry_delegate(AVIODirEntry** @entry);
    private static avio_free_directory_entry_delegate? _avio_free_directory_entry_cache;
    
    /// <summary>Free entry allocated by avio_read_dir().</summary>
    /// <param name="entry">entry to be freed.</param>
    public static void avio_free_directory_entry(AVIODirEntry** @entry)
    {
        _avio_free_directory_entry_cache ??= FunctionResolver.GetFunctionDelegate<avio_free_directory_entry_delegate>("avformat", "avio_free_directory_entry", ThrowErrorIfFunctionNotFound);
        if (_avio_free_directory_entry_cache == null)
            throw new NotSupportedException();
        _avio_free_directory_entry_cache(@entry);
    }
    
    /// <summary>Free entry allocated by avio_read_dir().</summary>
    public static void avio_free_directory_entry(ref AVIODirEntry* @entry)
    {
        fixed (AVIODirEntry** ptr = &@entry)
        {
            avio_free_directory_entry(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_get_dyn_buf_delegate(AVIOContext* @s, byte** @pbuffer);
    private static avio_get_dyn_buf_delegate? _avio_get_dyn_buf_cache;
    
    /// <summary>Return the written size and a pointer to the buffer. The AVIOContext stream is left intact. The buffer must NOT be freed. No padding is added to the buffer.</summary>
    /// <param name="s">IO context</param>
    /// <param name="pbuffer">pointer to a byte buffer</param>
    /// <returns>the length of the byte buffer</returns>
    public static int avio_get_dyn_buf(AVIOContext* @s, byte** @pbuffer)
    {
        _avio_get_dyn_buf_cache ??= FunctionResolver.GetFunctionDelegate<avio_get_dyn_buf_delegate>("avformat", "avio_get_dyn_buf", ThrowErrorIfFunctionNotFound);
        if (_avio_get_dyn_buf_cache == null)
            throw new NotSupportedException();
        return _avio_get_dyn_buf_cache(@s, @pbuffer);
    }
    
    /// <summary>Return the written size and a pointer to the buffer. The AVIOContext stream is left intact. The buffer must NOT be freed. No padding is added to the buffer.</summary>
    /// <param name="s">IO context</param>
    /// <returns>the length of the byte buffer</returns>
    public static int avio_get_dyn_buf(AVIOContext* @s, ref byte* @pbuffer)
    {
        fixed (byte** ptr = &@pbuffer)
        {
            return avio_get_dyn_buf(@s, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_get_str_delegate(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);
    private static avio_get_str_delegate? _avio_get_str_cache;
    
    /// <summary>Read a string from pb into buf. The reading will terminate when either a NULL character was encountered, maxlen bytes have been read, or nothing more can be read from pb. The result is guaranteed to be NULL-terminated, it will be truncated if buf is too small. Note that the string is not interpreted or validated in any way, it might get truncated in the middle of a sequence for multi-byte encodings.</summary>
    /// <returns>number of bytes read (is always &lt; = maxlen). If reading ends on EOF or error, the return value will be one more than bytes actually read.</returns>
    public static int avio_get_str(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen)
    {
        _avio_get_str_cache ??= FunctionResolver.GetFunctionDelegate<avio_get_str_delegate>("avformat", "avio_get_str", ThrowErrorIfFunctionNotFound);
        if (_avio_get_str_cache == null)
            throw new NotSupportedException();
        return _avio_get_str_cache(@pb, @maxlen, @buf, @buflen);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_get_str16be_delegate(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);
    private static avio_get_str16be_delegate? _avio_get_str16be_cache;
    
    public static int avio_get_str16be(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen)
    {
        _avio_get_str16be_cache ??= FunctionResolver.GetFunctionDelegate<avio_get_str16be_delegate>("avformat", "avio_get_str16be", ThrowErrorIfFunctionNotFound);
        if (_avio_get_str16be_cache == null)
            throw new NotSupportedException();
        return _avio_get_str16be_cache(@pb, @maxlen, @buf, @buflen);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_get_str16le_delegate(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);
    private static avio_get_str16le_delegate? _avio_get_str16le_cache;
    
    /// <summary>Read a UTF-16 string from pb and convert it to UTF-8. The reading will terminate when either a null or invalid character was encountered or maxlen bytes have been read.</summary>
    /// <returns>number of bytes read (is always &lt; = maxlen)</returns>
    public static int avio_get_str16le(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen)
    {
        _avio_get_str16le_cache ??= FunctionResolver.GetFunctionDelegate<avio_get_str16le_delegate>("avformat", "avio_get_str16le", ThrowErrorIfFunctionNotFound);
        if (_avio_get_str16le_cache == null)
            throw new NotSupportedException();
        return _avio_get_str16le_cache(@pb, @maxlen, @buf, @buflen);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_handshake_delegate(AVIOContext* @c);
    private static avio_handshake_delegate? _avio_handshake_cache;
    
    /// <summary>Perform one step of the protocol handshake to accept a new client. This function must be called on a client returned by avio_accept() before using it as a read/write context. It is separate from avio_accept() because it may block. A step of the handshake is defined by places where the application may decide to change the proceedings. For example, on a protocol with a request header and a reply header, each one can constitute a step because the application may use the parameters from the request to change parameters in the reply; or each individual chunk of the request can constitute a step. If the handshake is already finished, avio_handshake() does nothing and returns 0 immediately.</summary>
    /// <param name="c">the client context to perform the handshake on</param>
    /// <returns>0   on a complete and successful handshake &gt; 0 if the handshake progressed, but is not complete &lt; 0 for an AVERROR code</returns>
    public static int avio_handshake(AVIOContext* @c)
    {
        _avio_handshake_cache ??= FunctionResolver.GetFunctionDelegate<avio_handshake_delegate>("avformat", "avio_handshake", ThrowErrorIfFunctionNotFound);
        if (_avio_handshake_cache == null)
            throw new NotSupportedException();
        return _avio_handshake_cache(@c);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_open_delegate(AVIOContext** @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, int @flags);
    private static avio_open_delegate? _avio_open_cache;
    
    /// <summary>Create and initialize a AVIOContext for accessing the resource indicated by url.</summary>
    /// <param name="s">Used to return the pointer to the created AVIOContext. In case of failure the pointed to value is set to NULL.</param>
    /// <param name="url">resource to access</param>
    /// <param name="flags">flags which control how the resource indicated by url is to be opened</param>
    /// <returns>&gt;= 0 in case of success, a negative value corresponding to an AVERROR code in case of failure</returns>
    public static int avio_open(AVIOContext** @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, int @flags)
    {
        _avio_open_cache ??= FunctionResolver.GetFunctionDelegate<avio_open_delegate>("avformat", "avio_open", ThrowErrorIfFunctionNotFound);
        if (_avio_open_cache == null)
            throw new NotSupportedException();
        return _avio_open_cache(@s, @url, @flags);
    }
    
    /// <summary>Create and initialize a AVIOContext for accessing the resource indicated by url.</summary>
    /// <param name="url">resource to access</param>
    /// <param name="flags">flags which control how the resource indicated by url is to be opened</param>
    /// <returns>&gt;= 0 in case of success, a negative value corresponding to an AVERROR code in case of failure</returns>
    public static int avio_open(ref AVIOContext* @s, string @url, int @flags)
    {
        fixed (AVIOContext** ptr = &@s)
        {
            return avio_open(ptr, @url, @flags);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_open_dir_delegate(AVIODirContext** @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, AVDictionary** @options);
    private static avio_open_dir_delegate? _avio_open_dir_cache;
    
    /// <summary>Open directory for reading.</summary>
    /// <param name="s">directory read context. Pointer to a NULL pointer must be passed.</param>
    /// <param name="url">directory to be listed.</param>
    /// <param name="options">A dictionary filled with protocol-private options. On return this parameter will be destroyed and replaced with a dictionary containing options that were not found. May be NULL.</param>
    /// <returns>&gt;=0 on success or negative on error.</returns>
    public static int avio_open_dir(AVIODirContext** @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, AVDictionary** @options)
    {
        _avio_open_dir_cache ??= FunctionResolver.GetFunctionDelegate<avio_open_dir_delegate>("avformat", "avio_open_dir", ThrowErrorIfFunctionNotFound);
        if (_avio_open_dir_cache == null)
            throw new NotSupportedException();
        return _avio_open_dir_cache(@s, @url, @options);
    }
    
    /// <summary>Open directory for reading.</summary>
    /// <param name="url">directory to be listed.</param>
    /// <param name="options">A dictionary filled with protocol-private options. On return this parameter will be destroyed and replaced with a dictionary containing options that were not found. May be NULL.</param>
    /// <returns>&gt;=0 on success or negative on error.</returns>
    public static int avio_open_dir(ref AVIODirContext* @s, string @url, AVDictionary** @options)
    {
        fixed (AVIODirContext** ptr = &@s)
        {
            return avio_open_dir(ptr, @url, @options);
        }
    }
    
    /// <summary>Open directory for reading.</summary>
    /// <param name="s">directory read context. Pointer to a NULL pointer must be passed.</param>
    /// <param name="url">directory to be listed.</param>
    /// <returns>&gt;=0 on success or negative on error.</returns>
    public static int avio_open_dir(AVIODirContext** @s, string @url, ref AVDictionary* @options)
    {
        fixed (AVDictionary** ptr = &@options)
        {
            return avio_open_dir(@s, @url, ptr);
        }
    }
    
    /// <summary>Open directory for reading.</summary>
    /// <param name="url">directory to be listed.</param>
    /// <returns>&gt;=0 on success or negative on error.</returns>
    public static int avio_open_dir(ref AVIODirContext* @s, string @url, ref AVDictionary* @options)
    {
        fixed (AVIODirContext** ptr1 = &@s)
        {
        fixed (AVDictionary** ptr2 = &@options)
        {
                return avio_open_dir(ptr1, @url, ptr2);
        }
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_open_dyn_buf_delegate(AVIOContext** @s);
    private static avio_open_dyn_buf_delegate? _avio_open_dyn_buf_cache;
    
    /// <summary>Open a write only memory stream.</summary>
    /// <param name="s">new IO context</param>
    /// <returns>zero if no error.</returns>
    public static int avio_open_dyn_buf(AVIOContext** @s)
    {
        _avio_open_dyn_buf_cache ??= FunctionResolver.GetFunctionDelegate<avio_open_dyn_buf_delegate>("avformat", "avio_open_dyn_buf", ThrowErrorIfFunctionNotFound);
        if (_avio_open_dyn_buf_cache == null)
            throw new NotSupportedException();
        return _avio_open_dyn_buf_cache(@s);
    }
    
    /// <summary>Open a write only memory stream.</summary>
    /// <returns>zero if no error.</returns>
    public static int avio_open_dyn_buf(ref AVIOContext* @s)
    {
        fixed (AVIOContext** ptr = &@s)
        {
            return avio_open_dyn_buf(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_open2_delegate(AVIOContext** @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, int @flags, AVIOInterruptCB* @int_cb, AVDictionary** @options);
    private static avio_open2_delegate? _avio_open2_cache;
    
    /// <summary>Create and initialize a AVIOContext for accessing the resource indicated by url.</summary>
    /// <param name="s">Used to return the pointer to the created AVIOContext. In case of failure the pointed to value is set to NULL.</param>
    /// <param name="url">resource to access</param>
    /// <param name="flags">flags which control how the resource indicated by url is to be opened</param>
    /// <param name="int_cb">an interrupt callback to be used at the protocols level</param>
    /// <param name="options">A dictionary filled with protocol-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
    /// <returns>&gt;= 0 in case of success, a negative value corresponding to an AVERROR code in case of failure</returns>
    public static int avio_open2(AVIOContext** @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @url, int @flags, AVIOInterruptCB* @int_cb, AVDictionary** @options)
    {
        _avio_open2_cache ??= FunctionResolver.GetFunctionDelegate<avio_open2_delegate>("avformat", "avio_open2", ThrowErrorIfFunctionNotFound);
        if (_avio_open2_cache == null)
            throw new NotSupportedException();
        return _avio_open2_cache(@s, @url, @flags, @int_cb, @options);
    }
    
    /// <summary>Create and initialize a AVIOContext for accessing the resource indicated by url.</summary>
    /// <param name="url">resource to access</param>
    /// <param name="flags">flags which control how the resource indicated by url is to be opened</param>
    /// <param name="int_cb">an interrupt callback to be used at the protocols level</param>
    /// <param name="options">A dictionary filled with protocol-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
    /// <returns>&gt;= 0 in case of success, a negative value corresponding to an AVERROR code in case of failure</returns>
    public static int avio_open2(ref AVIOContext* @s, string @url, int @flags, AVIOInterruptCB* @int_cb, AVDictionary** @options)
    {
        fixed (AVIOContext** ptr = &@s)
        {
            return avio_open2(ptr, @url, @flags, @int_cb, @options);
        }
    }
    
    /// <summary>Create and initialize a AVIOContext for accessing the resource indicated by url.</summary>
    /// <param name="s">Used to return the pointer to the created AVIOContext. In case of failure the pointed to value is set to NULL.</param>
    /// <param name="url">resource to access</param>
    /// <param name="flags">flags which control how the resource indicated by url is to be opened</param>
    /// <param name="int_cb">an interrupt callback to be used at the protocols level</param>
    /// <returns>&gt;= 0 in case of success, a negative value corresponding to an AVERROR code in case of failure</returns>
    public static int avio_open2(AVIOContext** @s, string @url, int @flags, AVIOInterruptCB* @int_cb, ref AVDictionary* @options)
    {
        fixed (AVDictionary** ptr = &@options)
        {
            return avio_open2(@s, @url, @flags, @int_cb, ptr);
        }
    }
    
    /// <summary>Create and initialize a AVIOContext for accessing the resource indicated by url.</summary>
    /// <param name="url">resource to access</param>
    /// <param name="flags">flags which control how the resource indicated by url is to be opened</param>
    /// <param name="int_cb">an interrupt callback to be used at the protocols level</param>
    /// <returns>&gt;= 0 in case of success, a negative value corresponding to an AVERROR code in case of failure</returns>
    public static int avio_open2(ref AVIOContext* @s, string @url, int @flags, AVIOInterruptCB* @int_cb, ref AVDictionary* @options)
    {
        fixed (AVIOContext** ptr1 = &@s)
        {
        fixed (AVDictionary** ptr2 = &@options)
        {
                return avio_open2(ptr1, @url, @flags, @int_cb, ptr2);
        }
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_pause_delegate(AVIOContext* @h, int @pause);
    private static avio_pause_delegate? _avio_pause_cache;
    
    /// <summary>Pause and resume playing - only meaningful if using a network streaming protocol (e.g. MMS).</summary>
    /// <param name="h">IO context from which to call the read_pause function pointer</param>
    /// <param name="pause">1 for pause, 0 for resume</param>
    public static int avio_pause(AVIOContext* @h, int @pause)
    {
        _avio_pause_cache ??= FunctionResolver.GetFunctionDelegate<avio_pause_delegate>("avformat", "avio_pause", ThrowErrorIfFunctionNotFound);
        if (_avio_pause_cache == null)
            throw new NotSupportedException();
        return _avio_pause_cache(@h, @pause);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avio_print_string_array_delegate(AVIOContext* @s, byte*[] @strings);
    private static avio_print_string_array_delegate? _avio_print_string_array_cache;
    
    /// <summary>Write a NULL terminated array of strings to the context. Usually you don&apos;t need to use this function directly but its macro wrapper, avio_print.</summary>
    public static void avio_print_string_array(AVIOContext* @s, byte*[] @strings)
    {
        _avio_print_string_array_cache ??= FunctionResolver.GetFunctionDelegate<avio_print_string_array_delegate>("avformat", "avio_print_string_array", ThrowErrorIfFunctionNotFound);
        if (_avio_print_string_array_cache == null)
            throw new NotSupportedException();
        _avio_print_string_array_cache(@s, @strings);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_printf_delegate(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt);
    private static avio_printf_delegate? _avio_printf_cache;
    
    /// <summary>Writes a formatted string to the context.</summary>
    /// <returns>number of bytes written, &lt; 0 on error.</returns>
    public static int avio_printf(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt)
    {
        _avio_printf_cache ??= FunctionResolver.GetFunctionDelegate<avio_printf_delegate>("avformat", "avio_printf", ThrowErrorIfFunctionNotFound);
        if (_avio_printf_cache == null)
            throw new NotSupportedException();
        return _avio_printf_cache(@s, @fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVClass* avio_protocol_get_class_delegate(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name);
    private static avio_protocol_get_class_delegate? _avio_protocol_get_class_cache;
    
    /// <summary>Get AVClass by names of available protocols.</summary>
    /// <returns>A AVClass of input protocol name or NULL</returns>
    public static AVClass* avio_protocol_get_class(    
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @name)
    {
        _avio_protocol_get_class_cache ??= FunctionResolver.GetFunctionDelegate<avio_protocol_get_class_delegate>("avformat", "avio_protocol_get_class", ThrowErrorIfFunctionNotFound);
        if (_avio_protocol_get_class_cache == null)
            throw new NotSupportedException();
        return _avio_protocol_get_class_cache(@name);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_put_str_delegate(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str);
    private static avio_put_str_delegate? _avio_put_str_cache;
    
    /// <summary>Write a NULL-terminated string.</summary>
    /// <returns>number of bytes written.</returns>
    public static int avio_put_str(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str)
    {
        _avio_put_str_cache ??= FunctionResolver.GetFunctionDelegate<avio_put_str_delegate>("avformat", "avio_put_str", ThrowErrorIfFunctionNotFound);
        if (_avio_put_str_cache == null)
            throw new NotSupportedException();
        return _avio_put_str_cache(@s, @str);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_put_str16be_delegate(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str);
    private static avio_put_str16be_delegate? _avio_put_str16be_cache;
    
    /// <summary>Convert an UTF-8 string to UTF-16BE and write it.</summary>
    /// <param name="s">the AVIOContext</param>
    /// <param name="str">NULL-terminated UTF-8 string</param>
    /// <returns>number of bytes written.</returns>
    public static int avio_put_str16be(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str)
    {
        _avio_put_str16be_cache ??= FunctionResolver.GetFunctionDelegate<avio_put_str16be_delegate>("avformat", "avio_put_str16be", ThrowErrorIfFunctionNotFound);
        if (_avio_put_str16be_cache == null)
            throw new NotSupportedException();
        return _avio_put_str16be_cache(@s, @str);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_put_str16le_delegate(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str);
    private static avio_put_str16le_delegate? _avio_put_str16le_cache;
    
    /// <summary>Convert an UTF-8 string to UTF-16LE and write it.</summary>
    /// <param name="s">the AVIOContext</param>
    /// <param name="str">NULL-terminated UTF-8 string</param>
    /// <returns>number of bytes written.</returns>
    public static int avio_put_str16le(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @str)
    {
        _avio_put_str16le_cache ??= FunctionResolver.GetFunctionDelegate<avio_put_str16le_delegate>("avformat", "avio_put_str16le", ThrowErrorIfFunctionNotFound);
        if (_avio_put_str16le_cache == null)
            throw new NotSupportedException();
        return _avio_put_str16le_cache(@s, @str);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_r8_delegate(AVIOContext* @s);
    private static avio_r8_delegate? _avio_r8_cache;
    
    /// <summary>@{</summary>
    public static int avio_r8(AVIOContext* @s)
    {
        _avio_r8_cache ??= FunctionResolver.GetFunctionDelegate<avio_r8_delegate>("avformat", "avio_r8", ThrowErrorIfFunctionNotFound);
        if (_avio_r8_cache == null)
            throw new NotSupportedException();
        return _avio_r8_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint avio_rb16_delegate(AVIOContext* @s);
    private static avio_rb16_delegate? _avio_rb16_cache;
    
    public static uint avio_rb16(AVIOContext* @s)
    {
        _avio_rb16_cache ??= FunctionResolver.GetFunctionDelegate<avio_rb16_delegate>("avformat", "avio_rb16", ThrowErrorIfFunctionNotFound);
        if (_avio_rb16_cache == null)
            throw new NotSupportedException();
        return _avio_rb16_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint avio_rb24_delegate(AVIOContext* @s);
    private static avio_rb24_delegate? _avio_rb24_cache;
    
    public static uint avio_rb24(AVIOContext* @s)
    {
        _avio_rb24_cache ??= FunctionResolver.GetFunctionDelegate<avio_rb24_delegate>("avformat", "avio_rb24", ThrowErrorIfFunctionNotFound);
        if (_avio_rb24_cache == null)
            throw new NotSupportedException();
        return _avio_rb24_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint avio_rb32_delegate(AVIOContext* @s);
    private static avio_rb32_delegate? _avio_rb32_cache;
    
    public static uint avio_rb32(AVIOContext* @s)
    {
        _avio_rb32_cache ??= FunctionResolver.GetFunctionDelegate<avio_rb32_delegate>("avformat", "avio_rb32", ThrowErrorIfFunctionNotFound);
        if (_avio_rb32_cache == null)
            throw new NotSupportedException();
        return _avio_rb32_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate ulong avio_rb64_delegate(AVIOContext* @s);
    private static avio_rb64_delegate? _avio_rb64_cache;
    
    public static ulong avio_rb64(AVIOContext* @s)
    {
        _avio_rb64_cache ??= FunctionResolver.GetFunctionDelegate<avio_rb64_delegate>("avformat", "avio_rb64", ThrowErrorIfFunctionNotFound);
        if (_avio_rb64_cache == null)
            throw new NotSupportedException();
        return _avio_rb64_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_read_delegate(AVIOContext* @s, byte* @buf, int @size);
    private static avio_read_delegate? _avio_read_cache;
    
    /// <summary>Read size bytes from AVIOContext into buf.</summary>
    /// <returns>number of bytes read or AVERROR</returns>
    public static int avio_read(AVIOContext* @s, byte* @buf, int @size)
    {
        _avio_read_cache ??= FunctionResolver.GetFunctionDelegate<avio_read_delegate>("avformat", "avio_read", ThrowErrorIfFunctionNotFound);
        if (_avio_read_cache == null)
            throw new NotSupportedException();
        return _avio_read_cache(@s, @buf, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_read_dir_delegate(AVIODirContext* @s, AVIODirEntry** @next);
    private static avio_read_dir_delegate? _avio_read_dir_cache;
    
    /// <summary>Get next directory entry.</summary>
    /// <param name="s">directory read context.</param>
    /// <param name="next">next entry or NULL when no more entries.</param>
    /// <returns>&gt;=0 on success or negative on error. End of list is not considered an error.</returns>
    public static int avio_read_dir(AVIODirContext* @s, AVIODirEntry** @next)
    {
        _avio_read_dir_cache ??= FunctionResolver.GetFunctionDelegate<avio_read_dir_delegate>("avformat", "avio_read_dir", ThrowErrorIfFunctionNotFound);
        if (_avio_read_dir_cache == null)
            throw new NotSupportedException();
        return _avio_read_dir_cache(@s, @next);
    }
    
    /// <summary>Get next directory entry.</summary>
    /// <param name="s">directory read context.</param>
    /// <returns>&gt;=0 on success or negative on error. End of list is not considered an error.</returns>
    public static int avio_read_dir(AVIODirContext* @s, ref AVIODirEntry* @next)
    {
        fixed (AVIODirEntry** ptr = &@next)
        {
            return avio_read_dir(@s, ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_read_partial_delegate(AVIOContext* @s, byte* @buf, int @size);
    private static avio_read_partial_delegate? _avio_read_partial_cache;
    
    /// <summary>Read size bytes from AVIOContext into buf. Unlike avio_read(), this is allowed to read fewer bytes than requested. The missing bytes can be read in the next call. This always tries to read at least 1 byte. Useful to reduce latency in certain cases.</summary>
    /// <returns>number of bytes read or AVERROR</returns>
    public static int avio_read_partial(AVIOContext* @s, byte* @buf, int @size)
    {
        _avio_read_partial_cache ??= FunctionResolver.GetFunctionDelegate<avio_read_partial_delegate>("avformat", "avio_read_partial", ThrowErrorIfFunctionNotFound);
        if (_avio_read_partial_cache == null)
            throw new NotSupportedException();
        return _avio_read_partial_cache(@s, @buf, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_read_to_bprint_delegate(AVIOContext* @h, AVBPrint* @pb, ulong @max_size);
    private static avio_read_to_bprint_delegate? _avio_read_to_bprint_cache;
    
    /// <summary>Read contents of h into print buffer, up to max_size bytes, or up to EOF.</summary>
    /// <returns>0 for success (max_size bytes read or EOF reached), negative error code otherwise</returns>
    public static int avio_read_to_bprint(AVIOContext* @h, AVBPrint* @pb, ulong @max_size)
    {
        _avio_read_to_bprint_cache ??= FunctionResolver.GetFunctionDelegate<avio_read_to_bprint_delegate>("avformat", "avio_read_to_bprint", ThrowErrorIfFunctionNotFound);
        if (_avio_read_to_bprint_cache == null)
            throw new NotSupportedException();
        return _avio_read_to_bprint_cache(@h, @pb, @max_size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint avio_rl16_delegate(AVIOContext* @s);
    private static avio_rl16_delegate? _avio_rl16_cache;
    
    public static uint avio_rl16(AVIOContext* @s)
    {
        _avio_rl16_cache ??= FunctionResolver.GetFunctionDelegate<avio_rl16_delegate>("avformat", "avio_rl16", ThrowErrorIfFunctionNotFound);
        if (_avio_rl16_cache == null)
            throw new NotSupportedException();
        return _avio_rl16_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint avio_rl24_delegate(AVIOContext* @s);
    private static avio_rl24_delegate? _avio_rl24_cache;
    
    public static uint avio_rl24(AVIOContext* @s)
    {
        _avio_rl24_cache ??= FunctionResolver.GetFunctionDelegate<avio_rl24_delegate>("avformat", "avio_rl24", ThrowErrorIfFunctionNotFound);
        if (_avio_rl24_cache == null)
            throw new NotSupportedException();
        return _avio_rl24_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint avio_rl32_delegate(AVIOContext* @s);
    private static avio_rl32_delegate? _avio_rl32_cache;
    
    public static uint avio_rl32(AVIOContext* @s)
    {
        _avio_rl32_cache ??= FunctionResolver.GetFunctionDelegate<avio_rl32_delegate>("avformat", "avio_rl32", ThrowErrorIfFunctionNotFound);
        if (_avio_rl32_cache == null)
            throw new NotSupportedException();
        return _avio_rl32_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate ulong avio_rl64_delegate(AVIOContext* @s);
    private static avio_rl64_delegate? _avio_rl64_cache;
    
    public static ulong avio_rl64(AVIOContext* @s)
    {
        _avio_rl64_cache ??= FunctionResolver.GetFunctionDelegate<avio_rl64_delegate>("avformat", "avio_rl64", ThrowErrorIfFunctionNotFound);
        if (_avio_rl64_cache == null)
            throw new NotSupportedException();
        return _avio_rl64_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate long avio_seek_delegate(AVIOContext* @s, long @offset, int @whence);
    private static avio_seek_delegate? _avio_seek_cache;
    
    /// <summary>fseek() equivalent for AVIOContext.</summary>
    /// <returns>new position or AVERROR.</returns>
    public static long avio_seek(AVIOContext* @s, long @offset, int @whence)
    {
        _avio_seek_cache ??= FunctionResolver.GetFunctionDelegate<avio_seek_delegate>("avformat", "avio_seek", ThrowErrorIfFunctionNotFound);
        if (_avio_seek_cache == null)
            throw new NotSupportedException();
        return _avio_seek_cache(@s, @offset, @whence);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate long avio_seek_time_delegate(AVIOContext* @h, int @stream_index, long @timestamp, int @flags);
    private static avio_seek_time_delegate? _avio_seek_time_cache;
    
    /// <summary>Seek to a given timestamp relative to some component stream. Only meaningful if using a network streaming protocol (e.g. MMS.).</summary>
    /// <param name="h">IO context from which to call the seek function pointers</param>
    /// <param name="stream_index">The stream index that the timestamp is relative to. If stream_index is (-1) the timestamp should be in AV_TIME_BASE units from the beginning of the presentation. If a stream_index &gt;= 0 is used and the protocol does not support seeking based on component streams, the call will fail.</param>
    /// <param name="timestamp">timestamp in AVStream.time_base units or if there is no stream specified then in AV_TIME_BASE units.</param>
    /// <param name="flags">Optional combination of AVSEEK_FLAG_BACKWARD, AVSEEK_FLAG_BYTE and AVSEEK_FLAG_ANY. The protocol may silently ignore AVSEEK_FLAG_BACKWARD and AVSEEK_FLAG_ANY, but AVSEEK_FLAG_BYTE will fail if used and not supported.</param>
    /// <returns>&gt;= 0 on success</returns>
    public static long avio_seek_time(AVIOContext* @h, int @stream_index, long @timestamp, int @flags)
    {
        _avio_seek_time_cache ??= FunctionResolver.GetFunctionDelegate<avio_seek_time_delegate>("avformat", "avio_seek_time", ThrowErrorIfFunctionNotFound);
        if (_avio_seek_time_cache == null)
            throw new NotSupportedException();
        return _avio_seek_time_cache(@h, @stream_index, @timestamp, @flags);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate long avio_size_delegate(AVIOContext* @s);
    private static avio_size_delegate? _avio_size_cache;
    
    /// <summary>Get the filesize.</summary>
    /// <returns>filesize or AVERROR</returns>
    public static long avio_size(AVIOContext* @s)
    {
        _avio_size_cache ??= FunctionResolver.GetFunctionDelegate<avio_size_delegate>("avformat", "avio_size", ThrowErrorIfFunctionNotFound);
        if (_avio_size_cache == null)
            throw new NotSupportedException();
        return _avio_size_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate long avio_skip_delegate(AVIOContext* @s, long @offset);
    private static avio_skip_delegate? _avio_skip_cache;
    
    /// <summary>Skip given number of bytes forward</summary>
    /// <returns>new position or AVERROR.</returns>
    public static long avio_skip(AVIOContext* @s, long @offset)
    {
        _avio_skip_cache ??= FunctionResolver.GetFunctionDelegate<avio_skip_delegate>("avformat", "avio_skip", ThrowErrorIfFunctionNotFound);
        if (_avio_skip_cache == null)
            throw new NotSupportedException();
        return _avio_skip_cache(@s, @offset);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int avio_vprintf_delegate(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @ap);
    private static avio_vprintf_delegate? _avio_vprintf_cache;
    
    /// <summary>Writes a formatted string to the context taking a va_list.</summary>
    /// <returns>number of bytes written, &lt; 0 on error.</returns>
    public static int avio_vprintf(AVIOContext* @s,     
    #if NETSTANDARD2_1_OR_GREATER
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #else
    [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
    #endif
    string @fmt, byte* @ap)
    {
        _avio_vprintf_cache ??= FunctionResolver.GetFunctionDelegate<avio_vprintf_delegate>("avformat", "avio_vprintf", ThrowErrorIfFunctionNotFound);
        if (_avio_vprintf_cache == null)
            throw new NotSupportedException();
        return _avio_vprintf_cache(@s, @fmt, @ap);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avio_w8_delegate(AVIOContext* @s, int @b);
    private static avio_w8_delegate? _avio_w8_cache;
    
    public static void avio_w8(AVIOContext* @s, int @b)
    {
        _avio_w8_cache ??= FunctionResolver.GetFunctionDelegate<avio_w8_delegate>("avformat", "avio_w8", ThrowErrorIfFunctionNotFound);
        if (_avio_w8_cache == null)
            throw new NotSupportedException();
        _avio_w8_cache(@s, @b);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avio_wb16_delegate(AVIOContext* @s, uint @val);
    private static avio_wb16_delegate? _avio_wb16_cache;
    
    public static void avio_wb16(AVIOContext* @s, uint @val)
    {
        _avio_wb16_cache ??= FunctionResolver.GetFunctionDelegate<avio_wb16_delegate>("avformat", "avio_wb16", ThrowErrorIfFunctionNotFound);
        if (_avio_wb16_cache == null)
            throw new NotSupportedException();
        _avio_wb16_cache(@s, @val);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avio_wb24_delegate(AVIOContext* @s, uint @val);
    private static avio_wb24_delegate? _avio_wb24_cache;
    
    public static void avio_wb24(AVIOContext* @s, uint @val)
    {
        _avio_wb24_cache ??= FunctionResolver.GetFunctionDelegate<avio_wb24_delegate>("avformat", "avio_wb24", ThrowErrorIfFunctionNotFound);
        if (_avio_wb24_cache == null)
            throw new NotSupportedException();
        _avio_wb24_cache(@s, @val);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avio_wb32_delegate(AVIOContext* @s, uint @val);
    private static avio_wb32_delegate? _avio_wb32_cache;
    
    public static void avio_wb32(AVIOContext* @s, uint @val)
    {
        _avio_wb32_cache ??= FunctionResolver.GetFunctionDelegate<avio_wb32_delegate>("avformat", "avio_wb32", ThrowErrorIfFunctionNotFound);
        if (_avio_wb32_cache == null)
            throw new NotSupportedException();
        _avio_wb32_cache(@s, @val);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avio_wb64_delegate(AVIOContext* @s, ulong @val);
    private static avio_wb64_delegate? _avio_wb64_cache;
    
    public static void avio_wb64(AVIOContext* @s, ulong @val)
    {
        _avio_wb64_cache ??= FunctionResolver.GetFunctionDelegate<avio_wb64_delegate>("avformat", "avio_wb64", ThrowErrorIfFunctionNotFound);
        if (_avio_wb64_cache == null)
            throw new NotSupportedException();
        _avio_wb64_cache(@s, @val);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avio_wl16_delegate(AVIOContext* @s, uint @val);
    private static avio_wl16_delegate? _avio_wl16_cache;
    
    public static void avio_wl16(AVIOContext* @s, uint @val)
    {
        _avio_wl16_cache ??= FunctionResolver.GetFunctionDelegate<avio_wl16_delegate>("avformat", "avio_wl16", ThrowErrorIfFunctionNotFound);
        if (_avio_wl16_cache == null)
            throw new NotSupportedException();
        _avio_wl16_cache(@s, @val);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avio_wl24_delegate(AVIOContext* @s, uint @val);
    private static avio_wl24_delegate? _avio_wl24_cache;
    
    public static void avio_wl24(AVIOContext* @s, uint @val)
    {
        _avio_wl24_cache ??= FunctionResolver.GetFunctionDelegate<avio_wl24_delegate>("avformat", "avio_wl24", ThrowErrorIfFunctionNotFound);
        if (_avio_wl24_cache == null)
            throw new NotSupportedException();
        _avio_wl24_cache(@s, @val);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avio_wl32_delegate(AVIOContext* @s, uint @val);
    private static avio_wl32_delegate? _avio_wl32_cache;
    
    public static void avio_wl32(AVIOContext* @s, uint @val)
    {
        _avio_wl32_cache ??= FunctionResolver.GetFunctionDelegate<avio_wl32_delegate>("avformat", "avio_wl32", ThrowErrorIfFunctionNotFound);
        if (_avio_wl32_cache == null)
            throw new NotSupportedException();
        _avio_wl32_cache(@s, @val);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avio_wl64_delegate(AVIOContext* @s, ulong @val);
    private static avio_wl64_delegate? _avio_wl64_cache;
    
    public static void avio_wl64(AVIOContext* @s, ulong @val)
    {
        _avio_wl64_cache ??= FunctionResolver.GetFunctionDelegate<avio_wl64_delegate>("avformat", "avio_wl64", ThrowErrorIfFunctionNotFound);
        if (_avio_wl64_cache == null)
            throw new NotSupportedException();
        _avio_wl64_cache(@s, @val);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avio_write_delegate(AVIOContext* @s, byte* @buf, int @size);
    private static avio_write_delegate? _avio_write_cache;
    
    public static void avio_write(AVIOContext* @s, byte* @buf, int @size)
    {
        _avio_write_cache ??= FunctionResolver.GetFunctionDelegate<avio_write_delegate>("avformat", "avio_write", ThrowErrorIfFunctionNotFound);
        if (_avio_write_cache == null)
            throw new NotSupportedException();
        _avio_write_cache(@s, @buf, @size);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avio_write_marker_delegate(AVIOContext* @s, long @time, AVIODataMarkerType @type);
    private static avio_write_marker_delegate? _avio_write_marker_cache;
    
    /// <summary>Mark the written bytestream as a specific type.</summary>
    /// <param name="s">the AVIOContext</param>
    /// <param name="time">the stream time the current bytestream pos corresponds to (in AV_TIME_BASE units), or AV_NOPTS_VALUE if unknown or not applicable</param>
    /// <param name="type">the kind of data written starting at the current pos</param>
    public static void avio_write_marker(AVIOContext* @s, long @time, AVIODataMarkerType @type)
    {
        _avio_write_marker_cache ??= FunctionResolver.GetFunctionDelegate<avio_write_marker_delegate>("avformat", "avio_write_marker", ThrowErrorIfFunctionNotFound);
        if (_avio_write_marker_cache == null)
            throw new NotSupportedException();
        _avio_write_marker_cache(@s, @time, @type);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void avsubtitle_free_delegate(AVSubtitle* @sub);
    private static avsubtitle_free_delegate? _avsubtitle_free_cache;
    
    /// <summary>Free all allocated data in the given subtitle struct.</summary>
    /// <param name="sub">AVSubtitle to free.</param>
    public static void avsubtitle_free(AVSubtitle* @sub)
    {
        _avsubtitle_free_cache ??= FunctionResolver.GetFunctionDelegate<avsubtitle_free_delegate>("avcodec", "avsubtitle_free", ThrowErrorIfFunctionNotFound);
        if (_avsubtitle_free_cache == null)
            throw new NotSupportedException();
        _avsubtitle_free_cache(@sub);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string avutil_configuration_delegate();
    private static avutil_configuration_delegate? _avutil_configuration_cache;
    
    /// <summary>Return the libavutil build-time configuration.</summary>
    public static string avutil_configuration()
    {
        _avutil_configuration_cache ??= FunctionResolver.GetFunctionDelegate<avutil_configuration_delegate>("avutil", "avutil_configuration", ThrowErrorIfFunctionNotFound);
        if (_avutil_configuration_cache == null)
            throw new NotSupportedException();
        return _avutil_configuration_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string avutil_license_delegate();
    private static avutil_license_delegate? _avutil_license_cache;
    
    /// <summary>Return the libavutil license.</summary>
    public static string avutil_license()
    {
        _avutil_license_cache ??= FunctionResolver.GetFunctionDelegate<avutil_license_delegate>("avutil", "avutil_license", ThrowErrorIfFunctionNotFound);
        if (_avutil_license_cache == null)
            throw new NotSupportedException();
        return _avutil_license_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint avutil_version_delegate();
    private static avutil_version_delegate? _avutil_version_cache;
    
    /// <summary>Return the LIBAVUTIL_VERSION_INT constant.</summary>
    public static uint avutil_version()
    {
        _avutil_version_cache ??= FunctionResolver.GetFunctionDelegate<avutil_version_delegate>("avutil", "avutil_version", ThrowErrorIfFunctionNotFound);
        if (_avutil_version_cache == null)
            throw new NotSupportedException();
        return _avutil_version_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate SwrContext* swr_alloc_delegate();
    private static swr_alloc_delegate? _swr_alloc_cache;
    
    /// <summary>Allocate SwrContext.</summary>
    /// <returns>NULL on error, allocated context otherwise</returns>
    public static SwrContext* swr_alloc()
    {
        _swr_alloc_cache ??= FunctionResolver.GetFunctionDelegate<swr_alloc_delegate>("swresample", "swr_alloc", ThrowErrorIfFunctionNotFound);
        if (_swr_alloc_cache == null)
            throw new NotSupportedException();
        return _swr_alloc_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int swr_alloc_set_opts2_delegate(SwrContext** @ps, AVChannelLayout* @out_ch_layout, AVSampleFormat @out_sample_fmt, int @out_sample_rate, AVChannelLayout* @in_ch_layout, AVSampleFormat @in_sample_fmt, int @in_sample_rate, int @log_offset, void* @log_ctx);
    private static swr_alloc_set_opts2_delegate? _swr_alloc_set_opts2_cache;
    
    /// <summary>Allocate SwrContext if needed and set/reset common parameters.</summary>
    /// <param name="ps">Pointer to an existing Swr context if available, or to NULL if not. On success, *ps will be set to the allocated context.</param>
    /// <param name="out_ch_layout">output channel layout (e.g. AV_CHANNEL_LAYOUT_*)</param>
    /// <param name="out_sample_fmt">output sample format (AV_SAMPLE_FMT_*).</param>
    /// <param name="out_sample_rate">output sample rate (frequency in Hz)</param>
    /// <param name="in_ch_layout">input channel layout (e.g. AV_CHANNEL_LAYOUT_*)</param>
    /// <param name="in_sample_fmt">input sample format (AV_SAMPLE_FMT_*).</param>
    /// <param name="in_sample_rate">input sample rate (frequency in Hz)</param>
    /// <param name="log_offset">logging level offset</param>
    /// <param name="log_ctx">parent logging context, can be NULL</param>
    /// <returns>0 on success, a negative AVERROR code on error. On error, the Swr context is freed and *ps set to NULL.</returns>
    public static int swr_alloc_set_opts2(SwrContext** @ps, AVChannelLayout* @out_ch_layout, AVSampleFormat @out_sample_fmt, int @out_sample_rate, AVChannelLayout* @in_ch_layout, AVSampleFormat @in_sample_fmt, int @in_sample_rate, int @log_offset, void* @log_ctx)
    {
        _swr_alloc_set_opts2_cache ??= FunctionResolver.GetFunctionDelegate<swr_alloc_set_opts2_delegate>("swresample", "swr_alloc_set_opts2", ThrowErrorIfFunctionNotFound);
        if (_swr_alloc_set_opts2_cache == null)
            throw new NotSupportedException();
        return _swr_alloc_set_opts2_cache(@ps, @out_ch_layout, @out_sample_fmt, @out_sample_rate, @in_ch_layout, @in_sample_fmt, @in_sample_rate, @log_offset, @log_ctx);
    }
    
    /// <summary>Allocate SwrContext if needed and set/reset common parameters.</summary>
    /// <param name="out_ch_layout">output channel layout (e.g. AV_CHANNEL_LAYOUT_*)</param>
    /// <param name="out_sample_fmt">output sample format (AV_SAMPLE_FMT_*).</param>
    /// <param name="out_sample_rate">output sample rate (frequency in Hz)</param>
    /// <param name="in_ch_layout">input channel layout (e.g. AV_CHANNEL_LAYOUT_*)</param>
    /// <param name="in_sample_fmt">input sample format (AV_SAMPLE_FMT_*).</param>
    /// <param name="in_sample_rate">input sample rate (frequency in Hz)</param>
    /// <param name="log_offset">logging level offset</param>
    /// <param name="log_ctx">parent logging context, can be NULL</param>
    /// <returns>0 on success, a negative AVERROR code on error. On error, the Swr context is freed and *ps set to NULL.</returns>
    public static int swr_alloc_set_opts2(ref SwrContext* @ps, AVChannelLayout* @out_ch_layout, AVSampleFormat @out_sample_fmt, int @out_sample_rate, AVChannelLayout* @in_ch_layout, AVSampleFormat @in_sample_fmt, int @in_sample_rate, int @log_offset, void* @log_ctx)
    {
        fixed (SwrContext** ptr = &@ps)
        {
            return swr_alloc_set_opts2(ptr, @out_ch_layout, @out_sample_fmt, @out_sample_rate, @in_ch_layout, @in_sample_fmt, @in_sample_rate, @log_offset, @log_ctx);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int swr_build_matrix2_delegate(AVChannelLayout* @in_layout, AVChannelLayout* @out_layout, double @center_mix_level, double @surround_mix_level, double @lfe_mix_level, double @maxval, double @rematrix_volume, double* @matrix, long @stride, AVMatrixEncoding @matrix_encoding, void* @log_context);
    private static swr_build_matrix2_delegate? _swr_build_matrix2_cache;
    
    /// <summary>Generate a channel mixing matrix.</summary>
    /// <param name="in_layout">input channel layout</param>
    /// <param name="out_layout">output channel layout</param>
    /// <param name="center_mix_level">mix level for the center channel</param>
    /// <param name="surround_mix_level">mix level for the surround channel(s)</param>
    /// <param name="lfe_mix_level">mix level for the low-frequency effects channel</param>
    /// <param name="matrix">mixing coefficients; matrix[i + stride * o] is the weight of input channel i in output channel o.</param>
    /// <param name="stride">distance between adjacent input channels in the matrix array</param>
    /// <param name="matrix_encoding">matrixed stereo downmix mode (e.g. dplii)</param>
    /// <returns>0 on success, negative AVERROR code on failure</returns>
    public static int swr_build_matrix2(AVChannelLayout* @in_layout, AVChannelLayout* @out_layout, double @center_mix_level, double @surround_mix_level, double @lfe_mix_level, double @maxval, double @rematrix_volume, double* @matrix, long @stride, AVMatrixEncoding @matrix_encoding, void* @log_context)
    {
        _swr_build_matrix2_cache ??= FunctionResolver.GetFunctionDelegate<swr_build_matrix2_delegate>("swresample", "swr_build_matrix2", ThrowErrorIfFunctionNotFound);
        if (_swr_build_matrix2_cache == null)
            throw new NotSupportedException();
        return _swr_build_matrix2_cache(@in_layout, @out_layout, @center_mix_level, @surround_mix_level, @lfe_mix_level, @maxval, @rematrix_volume, @matrix, @stride, @matrix_encoding, @log_context);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void swr_close_delegate(SwrContext* @s);
    private static swr_close_delegate? _swr_close_cache;
    
    /// <summary>Closes the context so that swr_is_initialized() returns 0.</summary>
    /// <param name="s">Swr context to be closed</param>
    public static void swr_close(SwrContext* @s)
    {
        _swr_close_cache ??= FunctionResolver.GetFunctionDelegate<swr_close_delegate>("swresample", "swr_close", ThrowErrorIfFunctionNotFound);
        if (_swr_close_cache == null)
            throw new NotSupportedException();
        _swr_close_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int swr_config_frame_delegate(SwrContext* @swr, AVFrame* @out, AVFrame* @in);
    private static swr_config_frame_delegate? _swr_config_frame_cache;
    
    /// <summary>Configure or reconfigure the SwrContext using the information provided by the AVFrames.</summary>
    /// <param name="swr">audio resample context</param>
    /// <param name="out">output AVFrame</param>
    /// <param name="in">input AVFrame</param>
    /// <returns>0 on success, AVERROR on failure.</returns>
    public static int swr_config_frame(SwrContext* @swr, AVFrame* @out, AVFrame* @in)
    {
        _swr_config_frame_cache ??= FunctionResolver.GetFunctionDelegate<swr_config_frame_delegate>("swresample", "swr_config_frame", ThrowErrorIfFunctionNotFound);
        if (_swr_config_frame_cache == null)
            throw new NotSupportedException();
        return _swr_config_frame_cache(@swr, @out, @in);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int swr_convert_delegate(SwrContext* @s, byte** @out, int @out_count, byte** @in, int @in_count);
    private static swr_convert_delegate? _swr_convert_cache;
    
    /// <summary>Convert audio.</summary>
    /// <param name="s">allocated Swr context, with parameters set</param>
    /// <param name="out">output buffers, only the first one need be set in case of packed audio</param>
    /// <param name="out_count">amount of space available for output in samples per channel</param>
    /// <param name="in">input buffers, only the first one need to be set in case of packed audio</param>
    /// <param name="in_count">number of input samples available in one channel</param>
    /// <returns>number of samples output per channel, negative value on error</returns>
    public static int swr_convert(SwrContext* @s, byte** @out, int @out_count, byte** @in, int @in_count)
    {
        _swr_convert_cache ??= FunctionResolver.GetFunctionDelegate<swr_convert_delegate>("swresample", "swr_convert", ThrowErrorIfFunctionNotFound);
        if (_swr_convert_cache == null)
            throw new NotSupportedException();
        return _swr_convert_cache(@s, @out, @out_count, @in, @in_count);
    }
    
    /// <summary>Convert audio.</summary>
    /// <param name="s">allocated Swr context, with parameters set</param>
    /// <param name="out_count">amount of space available for output in samples per channel</param>
    /// <param name="in">input buffers, only the first one need to be set in case of packed audio</param>
    /// <param name="in_count">number of input samples available in one channel</param>
    /// <returns>number of samples output per channel, negative value on error</returns>
    public static int swr_convert(SwrContext* @s, ref byte* @out, int @out_count, byte** @in, int @in_count)
    {
        fixed (byte** ptr = &@out)
        {
            return swr_convert(@s, ptr, @out_count, @in, @in_count);
        }
    }
    
    /// <summary>Convert audio.</summary>
    /// <param name="s">allocated Swr context, with parameters set</param>
    /// <param name="out">output buffers, only the first one need be set in case of packed audio</param>
    /// <param name="out_count">amount of space available for output in samples per channel</param>
    /// <param name="in_count">number of input samples available in one channel</param>
    /// <returns>number of samples output per channel, negative value on error</returns>
    public static int swr_convert(SwrContext* @s, byte** @out, int @out_count, ref byte* @in, int @in_count)
    {
        fixed (byte** ptr = &@in)
        {
            return swr_convert(@s, @out, @out_count, ptr, @in_count);
        }
    }
    
    /// <summary>Convert audio.</summary>
    /// <param name="s">allocated Swr context, with parameters set</param>
    /// <param name="out_count">amount of space available for output in samples per channel</param>
    /// <param name="in_count">number of input samples available in one channel</param>
    /// <returns>number of samples output per channel, negative value on error</returns>
    public static int swr_convert(SwrContext* @s, ref byte* @out, int @out_count, ref byte* @in, int @in_count)
    {
        fixed (byte** ptr1 = &@out)
        {
        fixed (byte** ptr2 = &@in)
        {
                return swr_convert(@s, ptr1, @out_count, ptr2, @in_count);
        }
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int swr_convert_frame_delegate(SwrContext* @swr, AVFrame* @output, AVFrame* @input);
    private static swr_convert_frame_delegate? _swr_convert_frame_cache;
    
    /// <summary>Convert the samples in the input AVFrame and write them to the output AVFrame.</summary>
    /// <param name="swr">audio resample context</param>
    /// <param name="output">output AVFrame</param>
    /// <param name="input">input AVFrame</param>
    /// <returns>0 on success, AVERROR on failure or nonmatching configuration.</returns>
    public static int swr_convert_frame(SwrContext* @swr, AVFrame* @output, AVFrame* @input)
    {
        _swr_convert_frame_cache ??= FunctionResolver.GetFunctionDelegate<swr_convert_frame_delegate>("swresample", "swr_convert_frame", ThrowErrorIfFunctionNotFound);
        if (_swr_convert_frame_cache == null)
            throw new NotSupportedException();
        return _swr_convert_frame_cache(@swr, @output, @input);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int swr_drop_output_delegate(SwrContext* @s, int @count);
    private static swr_drop_output_delegate? _swr_drop_output_cache;
    
    /// <summary>Drops the specified number of output samples.</summary>
    /// <param name="s">allocated Swr context</param>
    /// <param name="count">number of samples to be dropped</param>
    /// <returns>&gt;= 0 on success, or a negative AVERROR code on failure</returns>
    public static int swr_drop_output(SwrContext* @s, int @count)
    {
        _swr_drop_output_cache ??= FunctionResolver.GetFunctionDelegate<swr_drop_output_delegate>("swresample", "swr_drop_output", ThrowErrorIfFunctionNotFound);
        if (_swr_drop_output_cache == null)
            throw new NotSupportedException();
        return _swr_drop_output_cache(@s, @count);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void swr_free_delegate(SwrContext** @s);
    private static swr_free_delegate? _swr_free_cache;
    
    /// <summary>Free the given SwrContext and set the pointer to NULL.</summary>
    /// <param name="s">a pointer to a pointer to Swr context</param>
    public static void swr_free(SwrContext** @s)
    {
        _swr_free_cache ??= FunctionResolver.GetFunctionDelegate<swr_free_delegate>("swresample", "swr_free", ThrowErrorIfFunctionNotFound);
        if (_swr_free_cache == null)
            throw new NotSupportedException();
        _swr_free_cache(@s);
    }
    
    /// <summary>Free the given SwrContext and set the pointer to NULL.</summary>
    public static void swr_free(ref SwrContext* @s)
    {
        fixed (SwrContext** ptr = &@s)
        {
            swr_free(ptr);
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVClass* swr_get_class_delegate();
    private static swr_get_class_delegate? _swr_get_class_cache;
    
    /// <summary>Get the AVClass for SwrContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
    /// <returns>the AVClass of SwrContext</returns>
    public static AVClass* swr_get_class()
    {
        _swr_get_class_cache ??= FunctionResolver.GetFunctionDelegate<swr_get_class_delegate>("swresample", "swr_get_class", ThrowErrorIfFunctionNotFound);
        if (_swr_get_class_cache == null)
            throw new NotSupportedException();
        return _swr_get_class_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate long swr_get_delay_delegate(SwrContext* @s, long @base);
    private static swr_get_delay_delegate? _swr_get_delay_cache;
    
    /// <summary>Gets the delay the next input sample will experience relative to the next output sample.</summary>
    /// <param name="s">swr context</param>
    /// <param name="base">timebase in which the returned delay will be:</param>
    public static long swr_get_delay(SwrContext* @s, long @base)
    {
        _swr_get_delay_cache ??= FunctionResolver.GetFunctionDelegate<swr_get_delay_delegate>("swresample", "swr_get_delay", ThrowErrorIfFunctionNotFound);
        if (_swr_get_delay_cache == null)
            throw new NotSupportedException();
        return _swr_get_delay_cache(@s, @base);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int swr_get_out_samples_delegate(SwrContext* @s, int @in_samples);
    private static swr_get_out_samples_delegate? _swr_get_out_samples_cache;
    
    /// <summary>Find an upper bound on the number of samples that the next swr_convert call will output, if called with in_samples of input samples. This depends on the internal state, and anything changing the internal state (like further swr_convert() calls) will may change the number of samples swr_get_out_samples() returns for the same number of input samples.</summary>
    /// <param name="in_samples">number of input samples.</param>
    public static int swr_get_out_samples(SwrContext* @s, int @in_samples)
    {
        _swr_get_out_samples_cache ??= FunctionResolver.GetFunctionDelegate<swr_get_out_samples_delegate>("swresample", "swr_get_out_samples", ThrowErrorIfFunctionNotFound);
        if (_swr_get_out_samples_cache == null)
            throw new NotSupportedException();
        return _swr_get_out_samples_cache(@s, @in_samples);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int swr_init_delegate(SwrContext* @s);
    private static swr_init_delegate? _swr_init_cache;
    
    /// <summary>Initialize context after user parameters have been set.</summary>
    /// <param name="s">Swr context to initialize</param>
    /// <returns>AVERROR error code in case of failure.</returns>
    public static int swr_init(SwrContext* @s)
    {
        _swr_init_cache ??= FunctionResolver.GetFunctionDelegate<swr_init_delegate>("swresample", "swr_init", ThrowErrorIfFunctionNotFound);
        if (_swr_init_cache == null)
            throw new NotSupportedException();
        return _swr_init_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int swr_inject_silence_delegate(SwrContext* @s, int @count);
    private static swr_inject_silence_delegate? _swr_inject_silence_cache;
    
    /// <summary>Injects the specified number of silence samples.</summary>
    /// <param name="s">allocated Swr context</param>
    /// <param name="count">number of samples to be dropped</param>
    /// <returns>&gt;= 0 on success, or a negative AVERROR code on failure</returns>
    public static int swr_inject_silence(SwrContext* @s, int @count)
    {
        _swr_inject_silence_cache ??= FunctionResolver.GetFunctionDelegate<swr_inject_silence_delegate>("swresample", "swr_inject_silence", ThrowErrorIfFunctionNotFound);
        if (_swr_inject_silence_cache == null)
            throw new NotSupportedException();
        return _swr_inject_silence_cache(@s, @count);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int swr_is_initialized_delegate(SwrContext* @s);
    private static swr_is_initialized_delegate? _swr_is_initialized_cache;
    
    /// <summary>Check whether an swr context has been initialized or not.</summary>
    /// <param name="s">Swr context to check</param>
    /// <returns>positive if it has been initialized, 0 if not initialized</returns>
    public static int swr_is_initialized(SwrContext* @s)
    {
        _swr_is_initialized_cache ??= FunctionResolver.GetFunctionDelegate<swr_is_initialized_delegate>("swresample", "swr_is_initialized", ThrowErrorIfFunctionNotFound);
        if (_swr_is_initialized_cache == null)
            throw new NotSupportedException();
        return _swr_is_initialized_cache(@s);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate long swr_next_pts_delegate(SwrContext* @s, long @pts);
    private static swr_next_pts_delegate? _swr_next_pts_cache;
    
    /// <summary>Convert the next timestamp from input to output timestamps are in 1/(in_sample_rate * out_sample_rate) units.</summary>
    /// <param name="s">initialized Swr context</param>
    /// <param name="pts">timestamp for the next input sample, INT64_MIN if unknown</param>
    /// <returns>the output timestamp for the next output sample</returns>
    public static long swr_next_pts(SwrContext* @s, long @pts)
    {
        _swr_next_pts_cache ??= FunctionResolver.GetFunctionDelegate<swr_next_pts_delegate>("swresample", "swr_next_pts", ThrowErrorIfFunctionNotFound);
        if (_swr_next_pts_cache == null)
            throw new NotSupportedException();
        return _swr_next_pts_cache(@s, @pts);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int swr_set_channel_mapping_delegate(SwrContext* @s, int* @channel_map);
    private static swr_set_channel_mapping_delegate? _swr_set_channel_mapping_cache;
    
    /// <summary>Set a customized input channel mapping.</summary>
    /// <param name="s">allocated Swr context, not yet initialized</param>
    /// <param name="channel_map">customized input channel mapping (array of channel indexes, -1 for a muted channel)</param>
    /// <returns>&gt;= 0 on success, or AVERROR error code in case of failure.</returns>
    public static int swr_set_channel_mapping(SwrContext* @s, int* @channel_map)
    {
        _swr_set_channel_mapping_cache ??= FunctionResolver.GetFunctionDelegate<swr_set_channel_mapping_delegate>("swresample", "swr_set_channel_mapping", ThrowErrorIfFunctionNotFound);
        if (_swr_set_channel_mapping_cache == null)
            throw new NotSupportedException();
        return _swr_set_channel_mapping_cache(@s, @channel_map);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int swr_set_compensation_delegate(SwrContext* @s, int @sample_delta, int @compensation_distance);
    private static swr_set_compensation_delegate? _swr_set_compensation_cache;
    
    /// <summary>Activate resampling compensation (&quot;soft&quot; compensation). This function is internally called when needed in swr_next_pts().</summary>
    /// <param name="s">allocated Swr context. If it is not initialized, or SWR_FLAG_RESAMPLE is not set, swr_init() is called with the flag set.</param>
    /// <param name="sample_delta">delta in PTS per sample</param>
    /// <param name="compensation_distance">number of samples to compensate for</param>
    /// <returns>&gt;= 0 on success, AVERROR error codes if:</returns>
    public static int swr_set_compensation(SwrContext* @s, int @sample_delta, int @compensation_distance)
    {
        _swr_set_compensation_cache ??= FunctionResolver.GetFunctionDelegate<swr_set_compensation_delegate>("swresample", "swr_set_compensation", ThrowErrorIfFunctionNotFound);
        if (_swr_set_compensation_cache == null)
            throw new NotSupportedException();
        return _swr_set_compensation_cache(@s, @sample_delta, @compensation_distance);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int swr_set_matrix_delegate(SwrContext* @s, double* @matrix, int @stride);
    private static swr_set_matrix_delegate? _swr_set_matrix_cache;
    
    /// <summary>Set a customized remix matrix.</summary>
    /// <param name="s">allocated Swr context, not yet initialized</param>
    /// <param name="matrix">remix coefficients; matrix[i + stride * o] is the weight of input channel i in output channel o</param>
    /// <param name="stride">offset between lines of the matrix</param>
    /// <returns>&gt;= 0 on success, or AVERROR error code in case of failure.</returns>
    public static int swr_set_matrix(SwrContext* @s, double* @matrix, int @stride)
    {
        _swr_set_matrix_cache ??= FunctionResolver.GetFunctionDelegate<swr_set_matrix_delegate>("swresample", "swr_set_matrix", ThrowErrorIfFunctionNotFound);
        if (_swr_set_matrix_cache == null)
            throw new NotSupportedException();
        return _swr_set_matrix_cache(@s, @matrix, @stride);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string swresample_configuration_delegate();
    private static swresample_configuration_delegate? _swresample_configuration_cache;
    
    /// <summary>Return the swr build-time configuration.</summary>
    public static string swresample_configuration()
    {
        _swresample_configuration_cache ??= FunctionResolver.GetFunctionDelegate<swresample_configuration_delegate>("swresample", "swresample_configuration", ThrowErrorIfFunctionNotFound);
        if (_swresample_configuration_cache == null)
            throw new NotSupportedException();
        return _swresample_configuration_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string swresample_license_delegate();
    private static swresample_license_delegate? _swresample_license_cache;
    
    /// <summary>Return the swr license.</summary>
    public static string swresample_license()
    {
        _swresample_license_cache ??= FunctionResolver.GetFunctionDelegate<swresample_license_delegate>("swresample", "swresample_license", ThrowErrorIfFunctionNotFound);
        if (_swresample_license_cache == null)
            throw new NotSupportedException();
        return _swresample_license_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint swresample_version_delegate();
    private static swresample_version_delegate? _swresample_version_cache;
    
    /// <summary>Return the LIBSWRESAMPLE_VERSION_INT constant.</summary>
    public static uint swresample_version()
    {
        _swresample_version_cache ??= FunctionResolver.GetFunctionDelegate<swresample_version_delegate>("swresample", "swresample_version", ThrowErrorIfFunctionNotFound);
        if (_swresample_version_cache == null)
            throw new NotSupportedException();
        return _swresample_version_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate SwsContext* sws_alloc_context_delegate();
    private static sws_alloc_context_delegate? _sws_alloc_context_cache;
    
    /// <summary>Allocate an empty SwsContext. This must be filled and passed to sws_init_context(). For filling see AVOptions, options.c and sws_setColorspaceDetails().</summary>
    public static SwsContext* sws_alloc_context()
    {
        _sws_alloc_context_cache ??= FunctionResolver.GetFunctionDelegate<sws_alloc_context_delegate>("swscale", "sws_alloc_context", ThrowErrorIfFunctionNotFound);
        if (_sws_alloc_context_cache == null)
            throw new NotSupportedException();
        return _sws_alloc_context_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate SwsVector* sws_allocVec_delegate(int @length);
    private static sws_allocVec_delegate? _sws_allocVec_cache;
    
    /// <summary>Allocate and return an uninitialized vector with length coefficients.</summary>
    public static SwsVector* sws_allocVec(int @length)
    {
        _sws_allocVec_cache ??= FunctionResolver.GetFunctionDelegate<sws_allocVec_delegate>("swscale", "sws_allocVec", ThrowErrorIfFunctionNotFound);
        if (_sws_allocVec_cache == null)
            throw new NotSupportedException();
        return _sws_allocVec_cache(@length);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void sws_convertPalette8ToPacked24_delegate(byte* @src, byte* @dst, int @num_pixels, byte* @palette);
    private static sws_convertPalette8ToPacked24_delegate? _sws_convertPalette8ToPacked24_cache;
    
    /// <summary>Convert an 8-bit paletted frame into a frame with a color depth of 24 bits.</summary>
    /// <param name="src">source frame buffer</param>
    /// <param name="dst">destination frame buffer</param>
    /// <param name="num_pixels">number of pixels to convert</param>
    /// <param name="palette">array with [256] entries, which must match color arrangement (RGB or BGR) of src</param>
    public static void sws_convertPalette8ToPacked24(byte* @src, byte* @dst, int @num_pixels, byte* @palette)
    {
        _sws_convertPalette8ToPacked24_cache ??= FunctionResolver.GetFunctionDelegate<sws_convertPalette8ToPacked24_delegate>("swscale", "sws_convertPalette8ToPacked24", ThrowErrorIfFunctionNotFound);
        if (_sws_convertPalette8ToPacked24_cache == null)
            throw new NotSupportedException();
        _sws_convertPalette8ToPacked24_cache(@src, @dst, @num_pixels, @palette);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void sws_convertPalette8ToPacked32_delegate(byte* @src, byte* @dst, int @num_pixels, byte* @palette);
    private static sws_convertPalette8ToPacked32_delegate? _sws_convertPalette8ToPacked32_cache;
    
    /// <summary>Convert an 8-bit paletted frame into a frame with a color depth of 32 bits.</summary>
    /// <param name="src">source frame buffer</param>
    /// <param name="dst">destination frame buffer</param>
    /// <param name="num_pixels">number of pixels to convert</param>
    /// <param name="palette">array with [256] entries, which must match color arrangement (RGB or BGR) of src</param>
    public static void sws_convertPalette8ToPacked32(byte* @src, byte* @dst, int @num_pixels, byte* @palette)
    {
        _sws_convertPalette8ToPacked32_cache ??= FunctionResolver.GetFunctionDelegate<sws_convertPalette8ToPacked32_delegate>("swscale", "sws_convertPalette8ToPacked32", ThrowErrorIfFunctionNotFound);
        if (_sws_convertPalette8ToPacked32_cache == null)
            throw new NotSupportedException();
        _sws_convertPalette8ToPacked32_cache(@src, @dst, @num_pixels, @palette);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void sws_frame_end_delegate(SwsContext* @c);
    private static sws_frame_end_delegate? _sws_frame_end_cache;
    
    /// <summary>Finish the scaling process for a pair of source/destination frames previously submitted with sws_frame_start(). Must be called after all sws_send_slice() and sws_receive_slice() calls are done, before any new sws_frame_start() calls.</summary>
    /// <param name="c">The scaling context</param>
    public static void sws_frame_end(SwsContext* @c)
    {
        _sws_frame_end_cache ??= FunctionResolver.GetFunctionDelegate<sws_frame_end_delegate>("swscale", "sws_frame_end", ThrowErrorIfFunctionNotFound);
        if (_sws_frame_end_cache == null)
            throw new NotSupportedException();
        _sws_frame_end_cache(@c);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int sws_frame_start_delegate(SwsContext* @c, AVFrame* @dst, AVFrame* @src);
    private static sws_frame_start_delegate? _sws_frame_start_cache;
    
    /// <summary>Initialize the scaling process for a given pair of source/destination frames. Must be called before any calls to sws_send_slice() and sws_receive_slice().</summary>
    /// <param name="c">The scaling context</param>
    /// <param name="dst">The destination frame.</param>
    /// <param name="src">The source frame. The data buffers must be allocated, but the frame data does not have to be ready at this point. Data availability is then signalled by sws_send_slice().</param>
    /// <returns>0 on success, a negative AVERROR code on failure</returns>
    public static int sws_frame_start(SwsContext* @c, AVFrame* @dst, AVFrame* @src)
    {
        _sws_frame_start_cache ??= FunctionResolver.GetFunctionDelegate<sws_frame_start_delegate>("swscale", "sws_frame_start", ThrowErrorIfFunctionNotFound);
        if (_sws_frame_start_cache == null)
            throw new NotSupportedException();
        return _sws_frame_start_cache(@c, @dst, @src);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void sws_freeContext_delegate(SwsContext* @swsContext);
    private static sws_freeContext_delegate? _sws_freeContext_cache;
    
    /// <summary>Free the swscaler context swsContext. If swsContext is NULL, then does nothing.</summary>
    public static void sws_freeContext(SwsContext* @swsContext)
    {
        _sws_freeContext_cache ??= FunctionResolver.GetFunctionDelegate<sws_freeContext_delegate>("swscale", "sws_freeContext", ThrowErrorIfFunctionNotFound);
        if (_sws_freeContext_cache == null)
            throw new NotSupportedException();
        _sws_freeContext_cache(@swsContext);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void sws_freeFilter_delegate(SwsFilter* @filter);
    private static sws_freeFilter_delegate? _sws_freeFilter_cache;
    
    public static void sws_freeFilter(SwsFilter* @filter)
    {
        _sws_freeFilter_cache ??= FunctionResolver.GetFunctionDelegate<sws_freeFilter_delegate>("swscale", "sws_freeFilter", ThrowErrorIfFunctionNotFound);
        if (_sws_freeFilter_cache == null)
            throw new NotSupportedException();
        _sws_freeFilter_cache(@filter);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void sws_freeVec_delegate(SwsVector* @a);
    private static sws_freeVec_delegate? _sws_freeVec_cache;
    
    public static void sws_freeVec(SwsVector* @a)
    {
        _sws_freeVec_cache ??= FunctionResolver.GetFunctionDelegate<sws_freeVec_delegate>("swscale", "sws_freeVec", ThrowErrorIfFunctionNotFound);
        if (_sws_freeVec_cache == null)
            throw new NotSupportedException();
        _sws_freeVec_cache(@a);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate AVClass* sws_get_class_delegate();
    private static sws_get_class_delegate? _sws_get_class_cache;
    
    /// <summary>Get the AVClass for swsContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
    public static AVClass* sws_get_class()
    {
        _sws_get_class_cache ??= FunctionResolver.GetFunctionDelegate<sws_get_class_delegate>("swscale", "sws_get_class", ThrowErrorIfFunctionNotFound);
        if (_sws_get_class_cache == null)
            throw new NotSupportedException();
        return _sws_get_class_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate SwsContext* sws_getCachedContext_delegate(SwsContext* @context, int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param);
    private static sws_getCachedContext_delegate? _sws_getCachedContext_cache;
    
    /// <summary>Check if context can be reused, otherwise reallocate a new one.</summary>
    public static SwsContext* sws_getCachedContext(SwsContext* @context, int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param)
    {
        _sws_getCachedContext_cache ??= FunctionResolver.GetFunctionDelegate<sws_getCachedContext_delegate>("swscale", "sws_getCachedContext", ThrowErrorIfFunctionNotFound);
        if (_sws_getCachedContext_cache == null)
            throw new NotSupportedException();
        return _sws_getCachedContext_cache(@context, @srcW, @srcH, @srcFormat, @dstW, @dstH, @dstFormat, @flags, @srcFilter, @dstFilter, @param);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int* sws_getCoefficients_delegate(int @colorspace);
    private static sws_getCoefficients_delegate? _sws_getCoefficients_cache;
    
    /// <summary>Return a pointer to yuv&lt;-&gt;rgb coefficients for the given colorspace suitable for sws_setColorspaceDetails().</summary>
    /// <param name="colorspace">One of the SWS_CS_* macros. If invalid, SWS_CS_DEFAULT is used.</param>
    public static int* sws_getCoefficients(int @colorspace)
    {
        _sws_getCoefficients_cache ??= FunctionResolver.GetFunctionDelegate<sws_getCoefficients_delegate>("swscale", "sws_getCoefficients", ThrowErrorIfFunctionNotFound);
        if (_sws_getCoefficients_cache == null)
            throw new NotSupportedException();
        return _sws_getCoefficients_cache(@colorspace);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int sws_getColorspaceDetails_delegate(SwsContext* @c, int** @inv_table, int* @srcRange, int** @table, int* @dstRange, int* @brightness, int* @contrast, int* @saturation);
    private static sws_getColorspaceDetails_delegate? _sws_getColorspaceDetails_cache;
    
    /// <summary>Returns A negative error code on error, non negative otherwise. If `LIBSWSCALE_VERSION_MAJOR &lt; 7`, returns -1 if not supported.</summary>
    /// <returns>A negative error code on error, non negative otherwise. If `LIBSWSCALE_VERSION_MAJOR &lt; 7`, returns -1 if not supported.</returns>
    public static int sws_getColorspaceDetails(SwsContext* @c, int** @inv_table, int* @srcRange, int** @table, int* @dstRange, int* @brightness, int* @contrast, int* @saturation)
    {
        _sws_getColorspaceDetails_cache ??= FunctionResolver.GetFunctionDelegate<sws_getColorspaceDetails_delegate>("swscale", "sws_getColorspaceDetails", ThrowErrorIfFunctionNotFound);
        if (_sws_getColorspaceDetails_cache == null)
            throw new NotSupportedException();
        return _sws_getColorspaceDetails_cache(@c, @inv_table, @srcRange, @table, @dstRange, @brightness, @contrast, @saturation);
    }
    
    /// <summary>Returns A negative error code on error, non negative otherwise. If `LIBSWSCALE_VERSION_MAJOR &lt; 7`, returns -1 if not supported.</summary>
    /// <returns>A negative error code on error, non negative otherwise. If `LIBSWSCALE_VERSION_MAJOR &lt; 7`, returns -1 if not supported.</returns>
    public static int sws_getColorspaceDetails(SwsContext* @c, ref int* @inv_table, int* @srcRange, int** @table, int* @dstRange, int* @brightness, int* @contrast, int* @saturation)
    {
        fixed (int** ptr = &@inv_table)
        {
            return sws_getColorspaceDetails(@c, ptr, @srcRange, @table, @dstRange, @brightness, @contrast, @saturation);
        }
    }
    
    /// <summary>Returns A negative error code on error, non negative otherwise. If `LIBSWSCALE_VERSION_MAJOR &lt; 7`, returns -1 if not supported.</summary>
    /// <returns>A negative error code on error, non negative otherwise. If `LIBSWSCALE_VERSION_MAJOR &lt; 7`, returns -1 if not supported.</returns>
    public static int sws_getColorspaceDetails(SwsContext* @c, int** @inv_table, int* @srcRange, ref int* @table, int* @dstRange, int* @brightness, int* @contrast, int* @saturation)
    {
        fixed (int** ptr = &@table)
        {
            return sws_getColorspaceDetails(@c, @inv_table, @srcRange, ptr, @dstRange, @brightness, @contrast, @saturation);
        }
    }
    
    /// <summary>Returns A negative error code on error, non negative otherwise. If `LIBSWSCALE_VERSION_MAJOR &lt; 7`, returns -1 if not supported.</summary>
    /// <returns>A negative error code on error, non negative otherwise. If `LIBSWSCALE_VERSION_MAJOR &lt; 7`, returns -1 if not supported.</returns>
    public static int sws_getColorspaceDetails(SwsContext* @c, ref int* @inv_table, int* @srcRange, ref int* @table, int* @dstRange, int* @brightness, int* @contrast, int* @saturation)
    {
        fixed (int** ptr1 = &@inv_table)
        {
        fixed (int** ptr2 = &@table)
        {
                return sws_getColorspaceDetails(@c, ptr1, @srcRange, ptr2, @dstRange, @brightness, @contrast, @saturation);
        }
        }
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate SwsContext* sws_getContext_delegate(int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param);
    private static sws_getContext_delegate? _sws_getContext_cache;
    
    /// <summary>Allocate and return an SwsContext. You need it to perform scaling/conversion operations using sws_scale().</summary>
    /// <param name="srcW">the width of the source image</param>
    /// <param name="srcH">the height of the source image</param>
    /// <param name="srcFormat">the source image format</param>
    /// <param name="dstW">the width of the destination image</param>
    /// <param name="dstH">the height of the destination image</param>
    /// <param name="dstFormat">the destination image format</param>
    /// <param name="flags">specify which algorithm and options to use for rescaling</param>
    /// <param name="param">extra parameters to tune the used scaler For SWS_BICUBIC param[0] and [1] tune the shape of the basis function, param[0] tunes f(1) and param[1] f´(1) For SWS_GAUSS param[0] tunes the exponent and thus cutoff frequency For SWS_LANCZOS param[0] tunes the width of the window function</param>
    /// <returns>a pointer to an allocated context, or NULL in case of error</returns>
    public static SwsContext* sws_getContext(int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param)
    {
        _sws_getContext_cache ??= FunctionResolver.GetFunctionDelegate<sws_getContext_delegate>("swscale", "sws_getContext", ThrowErrorIfFunctionNotFound);
        if (_sws_getContext_cache == null)
            throw new NotSupportedException();
        return _sws_getContext_cache(@srcW, @srcH, @srcFormat, @dstW, @dstH, @dstFormat, @flags, @srcFilter, @dstFilter, @param);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate SwsFilter* sws_getDefaultFilter_delegate(float @lumaGBlur, float @chromaGBlur, float @lumaSharpen, float @chromaSharpen, float @chromaHShift, float @chromaVShift, int @verbose);
    private static sws_getDefaultFilter_delegate? _sws_getDefaultFilter_cache;
    
    public static SwsFilter* sws_getDefaultFilter(float @lumaGBlur, float @chromaGBlur, float @lumaSharpen, float @chromaSharpen, float @chromaHShift, float @chromaVShift, int @verbose)
    {
        _sws_getDefaultFilter_cache ??= FunctionResolver.GetFunctionDelegate<sws_getDefaultFilter_delegate>("swscale", "sws_getDefaultFilter", ThrowErrorIfFunctionNotFound);
        if (_sws_getDefaultFilter_cache == null)
            throw new NotSupportedException();
        return _sws_getDefaultFilter_cache(@lumaGBlur, @chromaGBlur, @lumaSharpen, @chromaSharpen, @chromaHShift, @chromaVShift, @verbose);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate SwsVector* sws_getGaussianVec_delegate(double @variance, double @quality);
    private static sws_getGaussianVec_delegate? _sws_getGaussianVec_cache;
    
    /// <summary>Return a normalized Gaussian curve used to filter stuff quality = 3 is high quality, lower is lower quality.</summary>
    public static SwsVector* sws_getGaussianVec(double @variance, double @quality)
    {
        _sws_getGaussianVec_cache ??= FunctionResolver.GetFunctionDelegate<sws_getGaussianVec_delegate>("swscale", "sws_getGaussianVec", ThrowErrorIfFunctionNotFound);
        if (_sws_getGaussianVec_cache == null)
            throw new NotSupportedException();
        return _sws_getGaussianVec_cache(@variance, @quality);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int sws_init_context_delegate(SwsContext* @sws_context, SwsFilter* @srcFilter, SwsFilter* @dstFilter);
    private static sws_init_context_delegate? _sws_init_context_cache;
    
    /// <summary>Initialize the swscaler context sws_context.</summary>
    /// <returns>zero or positive value on success, a negative value on error</returns>
    public static int sws_init_context(SwsContext* @sws_context, SwsFilter* @srcFilter, SwsFilter* @dstFilter)
    {
        _sws_init_context_cache ??= FunctionResolver.GetFunctionDelegate<sws_init_context_delegate>("swscale", "sws_init_context", ThrowErrorIfFunctionNotFound);
        if (_sws_init_context_cache == null)
            throw new NotSupportedException();
        return _sws_init_context_cache(@sws_context, @srcFilter, @dstFilter);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int sws_isSupportedEndiannessConversion_delegate(AVPixelFormat @pix_fmt);
    private static sws_isSupportedEndiannessConversion_delegate? _sws_isSupportedEndiannessConversion_cache;
    
    /// <summary>Returns a positive value if an endianness conversion for pix_fmt is supported, 0 otherwise.</summary>
    /// <param name="pix_fmt">the pixel format</param>
    /// <returns>a positive value if an endianness conversion for pix_fmt is supported, 0 otherwise.</returns>
    public static int sws_isSupportedEndiannessConversion(AVPixelFormat @pix_fmt)
    {
        _sws_isSupportedEndiannessConversion_cache ??= FunctionResolver.GetFunctionDelegate<sws_isSupportedEndiannessConversion_delegate>("swscale", "sws_isSupportedEndiannessConversion", ThrowErrorIfFunctionNotFound);
        if (_sws_isSupportedEndiannessConversion_cache == null)
            throw new NotSupportedException();
        return _sws_isSupportedEndiannessConversion_cache(@pix_fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int sws_isSupportedInput_delegate(AVPixelFormat @pix_fmt);
    private static sws_isSupportedInput_delegate? _sws_isSupportedInput_cache;
    
    /// <summary>Return a positive value if pix_fmt is a supported input format, 0 otherwise.</summary>
    public static int sws_isSupportedInput(AVPixelFormat @pix_fmt)
    {
        _sws_isSupportedInput_cache ??= FunctionResolver.GetFunctionDelegate<sws_isSupportedInput_delegate>("swscale", "sws_isSupportedInput", ThrowErrorIfFunctionNotFound);
        if (_sws_isSupportedInput_cache == null)
            throw new NotSupportedException();
        return _sws_isSupportedInput_cache(@pix_fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int sws_isSupportedOutput_delegate(AVPixelFormat @pix_fmt);
    private static sws_isSupportedOutput_delegate? _sws_isSupportedOutput_cache;
    
    /// <summary>Return a positive value if pix_fmt is a supported output format, 0 otherwise.</summary>
    public static int sws_isSupportedOutput(AVPixelFormat @pix_fmt)
    {
        _sws_isSupportedOutput_cache ??= FunctionResolver.GetFunctionDelegate<sws_isSupportedOutput_delegate>("swscale", "sws_isSupportedOutput", ThrowErrorIfFunctionNotFound);
        if (_sws_isSupportedOutput_cache == null)
            throw new NotSupportedException();
        return _sws_isSupportedOutput_cache(@pix_fmt);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void sws_normalizeVec_delegate(SwsVector* @a, double @height);
    private static sws_normalizeVec_delegate? _sws_normalizeVec_cache;
    
    /// <summary>Scale all the coefficients of a so that their sum equals height.</summary>
    public static void sws_normalizeVec(SwsVector* @a, double @height)
    {
        _sws_normalizeVec_cache ??= FunctionResolver.GetFunctionDelegate<sws_normalizeVec_delegate>("swscale", "sws_normalizeVec", ThrowErrorIfFunctionNotFound);
        if (_sws_normalizeVec_cache == null)
            throw new NotSupportedException();
        _sws_normalizeVec_cache(@a, @height);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int sws_receive_slice_delegate(SwsContext* @c, uint @slice_start, uint @slice_height);
    private static sws_receive_slice_delegate? _sws_receive_slice_cache;
    
    /// <summary>Request a horizontal slice of the output data to be written into the frame previously provided to sws_frame_start().</summary>
    /// <param name="c">The scaling context</param>
    /// <param name="slice_start">first row of the slice; must be a multiple of sws_receive_slice_alignment()</param>
    /// <param name="slice_height">number of rows in the slice; must be a multiple of sws_receive_slice_alignment(), except for the last slice (i.e. when slice_start+slice_height is equal to output frame height)</param>
    /// <returns>a non-negative number if the data was successfully written into the output AVERROR(EAGAIN) if more input data needs to be provided before the output can be produced another negative AVERROR code on other kinds of scaling failure</returns>
    public static int sws_receive_slice(SwsContext* @c, uint @slice_start, uint @slice_height)
    {
        _sws_receive_slice_cache ??= FunctionResolver.GetFunctionDelegate<sws_receive_slice_delegate>("swscale", "sws_receive_slice", ThrowErrorIfFunctionNotFound);
        if (_sws_receive_slice_cache == null)
            throw new NotSupportedException();
        return _sws_receive_slice_cache(@c, @slice_start, @slice_height);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint sws_receive_slice_alignment_delegate(SwsContext* @c);
    private static sws_receive_slice_alignment_delegate? _sws_receive_slice_alignment_cache;
    
    /// <summary>Get the alignment required for slices</summary>
    /// <param name="c">The scaling context</param>
    /// <returns>alignment required for output slices requested with sws_receive_slice(). Slice offsets and sizes passed to sws_receive_slice() must be multiples of the value returned from this function.</returns>
    public static uint sws_receive_slice_alignment(SwsContext* @c)
    {
        _sws_receive_slice_alignment_cache ??= FunctionResolver.GetFunctionDelegate<sws_receive_slice_alignment_delegate>("swscale", "sws_receive_slice_alignment", ThrowErrorIfFunctionNotFound);
        if (_sws_receive_slice_alignment_cache == null)
            throw new NotSupportedException();
        return _sws_receive_slice_alignment_cache(@c);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int sws_scale_delegate(SwsContext* @c, byte*[] @srcSlice, int[] @srcStride, int @srcSliceY, int @srcSliceH, byte*[] @dst, int[] @dstStride);
    private static sws_scale_delegate? _sws_scale_cache;
    
    /// <summary>Scale the image slice in srcSlice and put the resulting scaled slice in the image in dst. A slice is a sequence of consecutive rows in an image.</summary>
    /// <param name="c">the scaling context previously created with sws_getContext()</param>
    /// <param name="srcSlice">the array containing the pointers to the planes of the source slice</param>
    /// <param name="srcStride">the array containing the strides for each plane of the source image</param>
    /// <param name="srcSliceY">the position in the source image of the slice to process, that is the number (counted starting from zero) in the image of the first row of the slice</param>
    /// <param name="srcSliceH">the height of the source slice, that is the number of rows in the slice</param>
    /// <param name="dst">the array containing the pointers to the planes of the destination image</param>
    /// <param name="dstStride">the array containing the strides for each plane of the destination image</param>
    /// <returns>the height of the output slice</returns>
    public static int sws_scale(SwsContext* @c, byte*[] @srcSlice, int[] @srcStride, int @srcSliceY, int @srcSliceH, byte*[] @dst, int[] @dstStride)
    {
        _sws_scale_cache ??= FunctionResolver.GetFunctionDelegate<sws_scale_delegate>("swscale", "sws_scale", ThrowErrorIfFunctionNotFound);
        if (_sws_scale_cache == null)
            throw new NotSupportedException();
        return _sws_scale_cache(@c, @srcSlice, @srcStride, @srcSliceY, @srcSliceH, @dst, @dstStride);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int sws_scale_frame_delegate(SwsContext* @c, AVFrame* @dst, AVFrame* @src);
    private static sws_scale_frame_delegate? _sws_scale_frame_cache;
    
    /// <summary>Scale source data from src and write the output to dst.</summary>
    /// <param name="c">The scaling context</param>
    /// <param name="dst">The destination frame. See documentation for sws_frame_start() for more details.</param>
    /// <param name="src">The source frame.</param>
    /// <returns>0 on success, a negative AVERROR code on failure</returns>
    public static int sws_scale_frame(SwsContext* @c, AVFrame* @dst, AVFrame* @src)
    {
        _sws_scale_frame_cache ??= FunctionResolver.GetFunctionDelegate<sws_scale_frame_delegate>("swscale", "sws_scale_frame", ThrowErrorIfFunctionNotFound);
        if (_sws_scale_frame_cache == null)
            throw new NotSupportedException();
        return _sws_scale_frame_cache(@c, @dst, @src);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void sws_scaleVec_delegate(SwsVector* @a, double @scalar);
    private static sws_scaleVec_delegate? _sws_scaleVec_cache;
    
    /// <summary>Scale all the coefficients of a by the scalar value.</summary>
    public static void sws_scaleVec(SwsVector* @a, double @scalar)
    {
        _sws_scaleVec_cache ??= FunctionResolver.GetFunctionDelegate<sws_scaleVec_delegate>("swscale", "sws_scaleVec", ThrowErrorIfFunctionNotFound);
        if (_sws_scaleVec_cache == null)
            throw new NotSupportedException();
        _sws_scaleVec_cache(@a, @scalar);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int sws_send_slice_delegate(SwsContext* @c, uint @slice_start, uint @slice_height);
    private static sws_send_slice_delegate? _sws_send_slice_cache;
    
    /// <summary>Indicate that a horizontal slice of input data is available in the source frame previously provided to sws_frame_start(). The slices may be provided in any order, but may not overlap. For vertically subsampled pixel formats, the slices must be aligned according to subsampling.</summary>
    /// <param name="c">The scaling context</param>
    /// <param name="slice_start">first row of the slice</param>
    /// <param name="slice_height">number of rows in the slice</param>
    /// <returns>a non-negative number on success, a negative AVERROR code on failure.</returns>
    public static int sws_send_slice(SwsContext* @c, uint @slice_start, uint @slice_height)
    {
        _sws_send_slice_cache ??= FunctionResolver.GetFunctionDelegate<sws_send_slice_delegate>("swscale", "sws_send_slice", ThrowErrorIfFunctionNotFound);
        if (_sws_send_slice_cache == null)
            throw new NotSupportedException();
        return _sws_send_slice_cache(@c, @slice_start, @slice_height);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int sws_setColorspaceDetails_delegate(SwsContext* @c, in int_array4 @inv_table, int @srcRange, in int_array4 @table, int @dstRange, int @brightness, int @contrast, int @saturation);
    private static sws_setColorspaceDetails_delegate? _sws_setColorspaceDetails_cache;
    
    /// <summary>Returns A negative error code on error, non negative otherwise. If `LIBSWSCALE_VERSION_MAJOR &lt; 7`, returns -1 if not supported.</summary>
    /// <param name="c">the scaling context</param>
    /// <param name="inv_table">the yuv2rgb coefficients describing the input yuv space, normally ff_yuv2rgb_coeffs[x]</param>
    /// <param name="srcRange">flag indicating the while-black range of the input (1=jpeg / 0=mpeg)</param>
    /// <param name="table">the yuv2rgb coefficients describing the output yuv space, normally ff_yuv2rgb_coeffs[x]</param>
    /// <param name="dstRange">flag indicating the while-black range of the output (1=jpeg / 0=mpeg)</param>
    /// <param name="brightness">16.16 fixed point brightness correction</param>
    /// <param name="contrast">16.16 fixed point contrast correction</param>
    /// <param name="saturation">16.16 fixed point saturation correction</param>
    /// <returns>A negative error code on error, non negative otherwise. If `LIBSWSCALE_VERSION_MAJOR &lt; 7`, returns -1 if not supported.</returns>
    public static int sws_setColorspaceDetails(SwsContext* @c, in int_array4 @inv_table, int @srcRange, in int_array4 @table, int @dstRange, int @brightness, int @contrast, int @saturation)
    {
        _sws_setColorspaceDetails_cache ??= FunctionResolver.GetFunctionDelegate<sws_setColorspaceDetails_delegate>("swscale", "sws_setColorspaceDetails", ThrowErrorIfFunctionNotFound);
        if (_sws_setColorspaceDetails_cache == null)
            throw new NotSupportedException();
        return _sws_setColorspaceDetails_cache(@c, @inv_table, @srcRange, @table, @dstRange, @brightness, @contrast, @saturation);
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string swscale_configuration_delegate();
    private static swscale_configuration_delegate? _swscale_configuration_cache;
    
    /// <summary>Return the libswscale build-time configuration.</summary>
    public static string swscale_configuration()
    {
        _swscale_configuration_cache ??= FunctionResolver.GetFunctionDelegate<swscale_configuration_delegate>("swscale", "swscale_configuration", ThrowErrorIfFunctionNotFound);
        if (_swscale_configuration_cache == null)
            throw new NotSupportedException();
        return _swscale_configuration_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
    public delegate string swscale_license_delegate();
    private static swscale_license_delegate? _swscale_license_cache;
    
    /// <summary>Return the libswscale license.</summary>
    public static string swscale_license()
    {
        _swscale_license_cache ??= FunctionResolver.GetFunctionDelegate<swscale_license_delegate>("swscale", "swscale_license", ThrowErrorIfFunctionNotFound);
        if (_swscale_license_cache == null)
            throw new NotSupportedException();
        return _swscale_license_cache();
    }
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate uint swscale_version_delegate();
    private static swscale_version_delegate? _swscale_version_cache;
    
    /// <summary>Color conversion and scaling library.</summary>
    public static uint swscale_version()
    {
        _swscale_version_cache ??= FunctionResolver.GetFunctionDelegate<swscale_version_delegate>("swscale", "swscale_version", ThrowErrorIfFunctionNotFound);
        if (_swscale_version_cache == null)
            throw new NotSupportedException();
        return _swscale_version_cache();
    }
    
}
