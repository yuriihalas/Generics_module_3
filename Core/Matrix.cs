using System.Text;

namespace GenericsModule.Core;

public class Matrix<T> where T : INumber<T>
{
    private T[,] _data;

    public Matrix(T[,] data) => _data = data;

    public Matrix<T> Add(Matrix<T> matrix)
    {
        CheckSize(matrix);
        T[,] finalResult = new T[_data.GetLength(0), _data.GetLength(1)];
        for (int i = 0; i < _data.GetLength(0); i++)
        {
            for (int j = 0; j < _data.GetLength(1); j++)
            {
                finalResult[i, j] = _data[i, j].Add(matrix._data[i, j]);
            }
        }

        return new Matrix<T>(finalResult);
    }

    public Matrix<T> Subtract(Matrix<T> matrix)
    {
        CheckSize(matrix);
        T[,] finalResult = new T[_data.GetLength(0), _data.GetLength(1)];
        for (int i = 0; i < _data.GetLength(0); i++)
        {
            for (int j = 0; j < _data.GetLength(1); j++)
            {
                finalResult[i, j] = _data[i, j].Subtract(matrix._data[i, j]);
            }
        }

        return new Matrix<T>(finalResult);
    }

    public Matrix<T> Multiply(T constant)
    {
        T[,] finalResult = new T[_data.GetLength(0), _data.GetLength(1)];
        for (int i = 0; i < _data.GetLength(0); i++)
        {
            for (int j = 0; j < _data.GetLength(1); j++)
            {
                finalResult[i, j] = constant.Multiply(_data[i, j]);
            }
        }

        return new Matrix<T>(finalResult);
    }

    private void CheckSize(Matrix<T> matrix)
    {
        if (_data.GetLength(0) != matrix._data.GetLength(0) ||
            _data.GetLength(1) != matrix._data.GetLength(1))
        {
            throw new InvalidOperationException("Matrices should have the same size!");
        }
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < _data.GetLength(0); i++)
        {
            for (int j = 0; j < _data.GetLength(1); j++)
            {
                stringBuilder.Append(_data[i, j] + "\t");
            }

            stringBuilder.AppendLine();
        }

        return stringBuilder.ToString();
    }
}