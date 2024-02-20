using System;

namespace xtlab
{

   

    class Program
    {
        public static void PrintStr(string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            string s = "hl word";
            PrintStr(s, ConsoleColor.Green);
        }
    }
}
