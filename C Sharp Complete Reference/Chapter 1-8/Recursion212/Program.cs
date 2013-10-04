// Display a string in reverse by using recursion.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion212
{
    class RevStr
    {
        // Display a string backward.
        public void DisplayRev(string str)
        {
            if (str.Length > 0)
                DisplayRev(str.Substring(1, str.Length - 1));
            else
                return;
            Console.Write(str[0]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = "this is a test";
            RevStr rsOb = new RevStr();

            Console.WriteLine("Original string: " + s);

            Console.Write("Reversed string: ");
            rsOb.DisplayRev(s);

            Console.WriteLine();
        }
    }
}
