using System.Numerics;
using System.Text;

namespace GenericsModule.Core;

public class Matrix<T> where T : INumber<T>
{
    private T[,] _matrix;

    public Matrix(T[,] matrix)
    {
        _matrix = matrix;
    }

    public Matrix<T> Add(Matrix<T> matrix)
    {
        CheckSize(matrix);
        T[,] finalResult = new T[_matrix.GetLength(0), _matrix.GetLength(1)];
        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            for (int j = 0; j < _matrix.GetLength(1); j++)
            {
                finalResult[i, j] = _matrix[i, j].Add(matrix._matrix[i, j]);
            }
        }

        return new Matrix<T>(finalResult);
    }

    public Matrix<T> Subtract(Matrix<T> matrix)
    {
        CheckSize(matrix);
        T[,] finalResult = new T[_matrix.GetLength(0), _matrix.GetLength(1)];
        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            for (int j = 0; j < _matrix.GetLength(1); j++)
            {
                finalResult[i, j] = _matrix[i, j].Subtract(matrix._matrix[i, j]);
            }
        }

        return new Matrix<T>(finalResult);
    }

    public Matrix<T> Multiply(T constant)
    {
        T[,] finalResult = new T[_matrix.GetLength(0), _matrix.GetLength(1)];
        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            for (int j = 0; j < _matrix.GetLength(1); j++)
            {
                finalResult[i, j] = constant.Multiply(_matrix[i, j]);
            }
        }

        return new Matrix<T>(finalResult);
    }

    private void CheckSize(Matrix<T> matrix)
    {
        if (_matrix.GetLength(0) != matrix._matrix.GetLength(0) ||
            _matrix.GetLength(1) != matrix._matrix.GetLength(1))
        {
            throw new InvalidOperationException("Matrices should have the same size!");
        }
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            for (int j = 0; j < _matrix.GetLength(1); j++)
            {
               stringBuilder.Append(_matrix[i, j] + "\t");
            }

            stringBuilder.AppendLine();
        }

        return stringBuilder.ToString();
    }
}