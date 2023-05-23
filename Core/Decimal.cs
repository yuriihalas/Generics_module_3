namespace GenericsModule.Core;

public class Decimal : INumber<Decimal>
{
    private decimal _value;

    public Decimal(decimal value) => _value = value;

    public Decimal Add(Decimal value) => new(_value + value._value);

    public Decimal Subtract(Decimal value) => new(_value - value._value);

    public Decimal Multiply(Decimal value) => new(_value * value._value);

    public override string ToString() => $"{_value}";
}