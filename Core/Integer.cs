namespace GenericsModule.Core;

public class Integer : INumber<Integer>
{
    private int _value;

    public Integer(int value)
    {
        _value = value;
    }

    public Integer Add(Integer value)
    {
        return new Integer(_value + value._value);
    }

    public Integer Subtract(Integer value)
    {
        return new Integer(_value - value._value);
    }

    public Integer Multiply(Integer value)
    {
        return new Integer(_value * value._value);
    }

    public override string ToString()
    {
        return $"{_value}";
    }
}