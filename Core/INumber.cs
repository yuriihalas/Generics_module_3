namespace GenericsModule.Core;

public interface INumber<T>
{
    public T Add(T value);

    public T Subtract(T value);

    public T Multiply(T value);
}