using System;

class Program
{
    static void Main(string[] args)
    {
        // Встановлення кодування для кирилиці
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        MathOperations mathOps = new MathOperations();

        // Додавання чисел
        Console.WriteLine($"Сума чисел 3 і 5: {mathOps.Add(3, 5)}");

        // Додавання масиву чисел
        double[] numbers = { 1.0, 2.0, 3.0, 4.0 };
        Console.WriteLine($"Сума масиву чисел: {mathOps.Add(numbers)}");

        // Додавання матриць
        double[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        double[,] matrix2 = { { 5, 6 }, { 7, 8 } };
        double[,] sumMatrix = mathOps.Add(matrix1, matrix2);

        Console.WriteLine("Сума матриць:");
        PrintMatrix(sumMatrix);

        // Віднімання чисел
        Console.WriteLine($"Різниця чисел 10 і 4: {mathOps.Subtract(10, 4)}");

        // Віднімання масиву чисел
        Console.WriteLine($"Різниця масиву чисел: {mathOps.Subtract(numbers)}");

        // Множення числа на число
        Console.WriteLine($"Множення чисел 6 і 7: {mathOps.Multiply(6, 7)}");

        // Множення матриці на скаляр
        double[,] scaledMatrix = mathOps.Multiply(matrix1, 2);
        Console.WriteLine("Множення матриці на скаляр 2:");
        PrintMatrix(scaledMatrix);
    }

    static void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}

