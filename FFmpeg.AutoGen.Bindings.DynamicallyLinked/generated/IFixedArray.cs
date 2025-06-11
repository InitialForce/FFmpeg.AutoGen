namespace FFmpeg.AutoGen.Bindings.DynamicallyLinked;

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
