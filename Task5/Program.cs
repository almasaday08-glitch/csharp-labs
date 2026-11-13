
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

        Console.WriteLine("Жұп оң элементтер саны = " + count);

        if (count > 0)
        {
            Console.WriteLine("Элементтер көбейтіндісі = " + product);
        }
        else
        {
            Console.WriteLine("Ондай элементтер жоқ.");
        }
    }

    static void Main()
    {
        int nomer = 4;
        int n = 5;

        // TEST = 0: негізгі Random(4)
        // TEST = 1: барлық элемент 1
        // TEST = 2: барлық элемент 2
        int TEST = 0;

        int[,] matrix = new int[n, n];
        Random rnd = new Random(nomer);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (TEST == 1)
                {
                    matrix[i, j] = 1;
                }
                else if (TEST == 2)
                {
                    matrix[i, j] = 2;
                }
                else
                {
                    matrix[i, j] = rnd.Next(-10, 11);
                }
            }
        }

        Console.WriteLine("Матрица:");
        PrintMatrix(matrix);

        Console.WriteLine();
        FindElements(matrix);
    }
}
