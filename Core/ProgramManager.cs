namespace GenericsModule.Core;

public static class ProgramManager
{
    public static void RunProgram()
    {
        Matrix<Integer> intMatrix = new Matrix<Integer>(new Integer[,]
        {
            { new Integer(1), new Integer(2) },
            { new Integer(3), new Integer(4) },
            { new Integer(5), new Integer(6) },
        });

        Matrix<Double> doubleMatrix = new Matrix<Double>(new Double[,]
        {
            { new Double(1.1), new Double(2.2) },
            { new Double(3.3), new Double(4.4) },
            { new Double(5.5), new Double(6.6) },
        });

        Matrix<Decimal> decimalMatrix = new Matrix<Decimal>(new Decimal[,]
        {
            { new Decimal(1.1M), new Decimal(2.2M) },
            { new Decimal(3.3M), new Decimal(4.4M) },
            { new Decimal(5.5M), new Decimal(6.6M) },
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
        Console.WriteLine(intMatrix.Multiply(new Integer(10)).ToString());

        Console.WriteLine(new string('_', Console.BufferWidth));
        Console.WriteLine("Multiplication of Double matrix: ");
        Console.WriteLine(doubleMatrix.Multiply(new Double(10.1)).ToString());

        Console.WriteLine(new string('_', Console.BufferWidth));
        Console.WriteLine("Multiplication of Decimal matrix: ");
        Console.WriteLine(decimalMatrix.Multiply(new Decimal(10.1M)).ToString());
    }
}