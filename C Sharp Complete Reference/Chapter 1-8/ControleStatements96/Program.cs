using System;

namespace ControleStatements96
{
    class Program
    {
        static void Main()
        {
            // Use commas in a for statement

            int i, j;
            for (i = 0, j = 10; i < j ; i++, j--)
                Console.WriteLine("i and j: " + i + " " + j);
        }
    }
}
