
using System;

class Program
{

    static void PrintMatrix(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write(m[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

   
    static void FindElements(int[,] m)
    {
        int count = 0;
        long product = 1;

        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                if (j > i && m[i, j] > 0 && m[i, j] % 2 == 0)
                {
                    count++;
                    product *= m[i, j];
                }
            }
        }

        if (count > 0)
        {
            Console.WriteLine("Жұп оң элементтер саны = " + count);
            Console.WriteLine("Элементтер көбейтіндісі = " + product);
        }
        else
        {
            Console.WriteLine("Бас диагональдан жоғары жұп оң элементтер жоқ.");
        }
    }

    static void Main()
    {
        int nomer = 4;
        int n = 5;

        int[,] matrix = new int[n, n];
        Random rnd = new Random(nomer);

        // Матрицаны толтыру
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rnd.Next(-10, 11);
            }
        }

        Console.WriteLine("Матрица:");
        PrintMatrix(matrix);

        Console.WriteLine();
        FindElements(matrix);
    }
}