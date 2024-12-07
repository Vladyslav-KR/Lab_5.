using System;

public class MathOperations
{
    // Додавання двох чисел
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Додавання масиву чисел
    public double Add(double[] numbers)
    {
        double sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    // Додавання двох матриць
    public double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        if (rows != matrix2.GetLength(0) || cols != matrix2.GetLength(1))
        {
            throw new ArgumentException("Розміри матриць мають співпадати!");
        }

        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return result;
    }

    // Віднімання двох чисел
    public double Subtract(double a, double b)
    {
        return a - b;
    }

    // Віднімання масиву чисел
    public double Subtract(double[] numbers)
    {
        double result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            result -= numbers[i];
        }
        return result;
    }

    // Віднімання двох матриць
    public double[,] Subtract(double[,] matrix1, double[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        if (rows != matrix2.GetLength(0) || cols != matrix2.GetLength(1))
        {
            throw new ArgumentException("Розміри матриць мають співпадати!");
        }

        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        return result;
    }

    // Множення двох чисел
    public double Multiply(double a, double b)
    {
        return a * b;
    }

    // Множення матриці на число
    public double[,] Multiply(double[,] matrix, double scalar)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }
        return result;
    }
}
