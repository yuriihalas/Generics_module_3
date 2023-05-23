using System.Text;

namespace GenericsModule.Core;

public class Matrix<T> where T : INumber<T>
{
    private T[,] _data;

    public int FirstLength => _data.GetLength(0);

    public int SecondLength => _data.GetLength(1);

    public Matrix(T[,] data) => _data = data;

    public Matrix<T> Add(Matrix<T> matrix)
    {
        CheckSize(matrix);
        T[,] finalResult = new T[FirstLength, SecondLength];
        for (int i = 0; i < FirstLength; i++)
        {
            for (int j = 0; j < SecondLength; j++)
            {
                finalResult[i, j] = _data[i, j].Add(matrix._data[i, j]);
            }
        }

        return new(finalResult);
    }

    public Matrix<T> Subtract(Matrix<T> matrix)
    {
        CheckSize(matrix);
        T[,] finalResult = new T[FirstLength, SecondLength];
        for (int i = 0; i < FirstLength; i++)
        {
            for (int j = 0; j < SecondLength; j++)
            {
                finalResult[i, j] = _data[i, j].Subtract(matrix._data[i, j]);
            }
        }

        return new(finalResult);
    }

    public Matrix<T> Multiply(T constant)
    {
        T[,] finalResult = new T[FirstLength, SecondLength];
        for (int i = 0; i < FirstLength; i++)
        {
            for (int j = 0; j < SecondLength; j++)
            {
                finalResult[i, j] = constant.Multiply(_data[i, j]);
            }
        }

        return new(finalResult);
    }

    private void CheckSize(Matrix<T> matrix)
    {
        if (FirstLength != matrix.FirstLength ||
            SecondLength != matrix.SecondLength)
        {
            throw new InvalidOperationException("Matrices should have the same size!");
        }
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        for (int i = 0; i < FirstLength; i++)
        {
            for (int j = 0; j < SecondLength; j++)
            {
                stringBuilder.Append(_data[i, j] + "\t");
            }

            stringBuilder.AppendLine();
        }

        return stringBuilder.ToString();
    }
}