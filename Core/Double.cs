namespace GenericsModule.Core;

public class Double : INumber<Double>
{
    private double _value;

    public Double(double value) => _value = value;

    public Double Add(Double value) => new(_value + value._value);

    public Double Subtract(Double value) => new(_value - value._value);

    public Double Multiply(Double value) => new(_value * value._value);

    public override string ToString() => $"{_value}";
}