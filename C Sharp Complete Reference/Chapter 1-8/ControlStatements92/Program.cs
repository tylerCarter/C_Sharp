using System;

namespace ControlStatements92
{
    class Program
    {
        static void Main()
        {
            char ch;

            for(ch='A'; ch <= 'E'; ch++)
                switch (ch)
                {
                    case 'A':
                        Console.WriteLine("ch is A");
                        break;
                    case 'B':
                        Console.WriteLine("ch is B");
                        break;
                    case 'C':
                        Console.WriteLine("ch is C");
                        break;
                    case 'D':
                        Console.WriteLine("ch is D");
                        break;
                    case 'E':
                        Console.WriteLine("ch is E");
                        break;
                }
        }
    }
}
