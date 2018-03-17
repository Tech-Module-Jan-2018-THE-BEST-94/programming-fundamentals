using System;
using System.Text;

namespace word_reverser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in here:");
            Console.WriteLine();
            string input = Console.ReadLine();
            Console.WriteLine();
            var str = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                str.Append(input[i]);
            }
            string output = str.ToString();
            Console.WriteLine("Here is your result:");
            Console.WriteLine();
            Console.WriteLine(str);
            Console.WriteLine();
        }
    }
}
