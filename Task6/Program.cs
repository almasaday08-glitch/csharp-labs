using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        string text;
        do
        {
            Console.WriteLine("Жолды енгізіңіз:");
            text = Console.ReadLine();
            if (text == null || text.Length == 0)
                Console.WriteLine("Жол бос. Қайта енгізіңіз.");
        } while (text == null || text.Length == 0);

        Console.WriteLine("Бастапқы жол: [" + text + "]");
    }
}