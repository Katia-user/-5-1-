using System;

class Program
{
    static void Main()
    {
        int n = 8; // Розмірність матриці
        int[,] matrix = new int[n, n];
        Random random = new Random();

        // Генерація матриці і виведення її на екран
        Console.WriteLine("Початкова матриця:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = random.Next(0, 101); // Випадкові числа від 0 до 100
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Обробка матриці: заміна елементів головної діагоналі
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < n; j++)
            {
                if (i != j && i + j != n - 1) // Перпендикулярні до головної діагоналі
                {
                    sum += matrix[j, i];
                }
            }
            matrix[i, i] = sum; // Заміна елементу головної діагоналі
        }

        // Виведення перетвореної матриці
        Console.WriteLine("\nПеретворена матриця:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}


