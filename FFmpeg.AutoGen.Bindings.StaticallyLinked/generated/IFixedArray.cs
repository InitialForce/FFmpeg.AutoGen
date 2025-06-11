namespace FFmpeg.AutoGen.Bindings.StaticallyLinked;

public interface IFixedArray
{
    int Length { get; }
}

public interface IFixedArray<T> : IFixedArray
{
    T this[uint index] { get; set; }
    T[] ToArray();
    void UpdateFrom(T[] array);
}
