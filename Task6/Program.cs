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

        string result = CollapseSpaces(text);

        Console.WriteLine("Бастапқы жол: [" + text + "]");
        Console.WriteLine("Нәтиже:       [" + result + "]");
        Console.WriteLine("Бастапқы ұзындық = " + text.Length + ", жаңа ұзындық = " + result.Length);
    }

    // Қатар тұрған бірнеше бос орынды біреуіне алмастырады
    static string CollapseSpaces(string text)
    {
        string result = "";
        bool previousIsSpace = false;

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (ch == ' ')
            {
                if (!previousIsSpace)
                    result += ch;
                previousIsSpace = true;
            }
            else
            {
                result += ch;
                previousIsSpace = false;
            }
        }
        return result;
    }
}