namespace GenericsModule.Core;

public static class ProgramManager
{
    public static void RunProgram()
    {
        Matrix<Integer> intMatrix = new(new Integer[,]
        {
            { new(1), new(2) },
            { new(3), new(4) },
            { new(5), new(6) },
        });

        Matrix<Double> doubleMatrix = new(new Double[,]
        {
            { new(1.1), new(2.2) },
            { new(3.3), new(4.4) },
            { new(5.5), new(6.6) },
        });

        Matrix<Decimal> decimalMatrix = new(new Decimal[,]
        {
            { new(1.1M), new(2.2M) },
            { new(3.3M), new(4.4M) },
            { new(5.5M), new(6.6M) },
        });

        Console.WriteLine(new string('_', Console.BufferWidth));
        Console.WriteLine("Addition of Integer matrix: ");
        Console.WriteLine(intMatrix.Add(intMatrix).ToString());

        Console.WriteLine(new string('_', Console.BufferWidth));
        Console.WriteLine("Addition of Double matrix: ");
        Console.WriteLine(doubleMatrix.Add(doubleMatrix).ToString());

        Console.WriteLine(new string('_', Console.BufferWidth));
        Console.WriteLine("Addition of Decimal matrix: ");
        Console.WriteLine(decimalMatrix.Add(decimalMatrix).ToString());


        Console.WriteLine(new string('_', Console.BufferWidth));
        Console.WriteLine("Subtraction of Integer matrix: ");
        Console.WriteLine(intMatrix.Subtract(intMatrix).ToString());

        Console.WriteLine(new string('_', Console.BufferWidth));
        Console.WriteLine("Subtraction of Double matrix: ");
        Console.WriteLine(doubleMatrix.Subtract(doubleMatrix).ToString());

        Console.WriteLine(new string('_', Console.BufferWidth));
        Console.WriteLine("Subtraction of Decimal matrix: ");
        Console.WriteLine(decimalMatrix.Subtract(decimalMatrix).ToString());


        Console.WriteLine(new string('_', Console.BufferWidth));
        Console.WriteLine("Multiplication of Integer matrix: ");
        Console.WriteLine(intMatrix.Multiply(new(10)).ToString());

        Console.WriteLine(new string('_', Console.BufferWidth));
        Console.WriteLine("Multiplication of Double matrix: ");
        Console.WriteLine(doubleMatrix.Multiply(new(10.1)).ToString());

        Console.WriteLine(new string('_', Console.BufferWidth));
        Console.WriteLine("Multiplication of Decimal matrix: ");
        Console.WriteLine(decimalMatrix.Multiply(new(10.1M)).ToString());
    }
}