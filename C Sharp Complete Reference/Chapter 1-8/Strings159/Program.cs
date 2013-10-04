// Introduce strings.
using System;

namespace Strings159
{
    class Program
    {
        static void Main()
        {
            char[] chararray = { 'A', ' ', 's', 't', 'r', 'i', 'n', 'g', '.' };
            string str1 = new string(chararray);
            string str2 = "Another string.";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}
