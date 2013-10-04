// Display all command-line information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineArgs209
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There are " + args.Length + " command-line arguments.");
            Console.WriteLine("They are: ");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}
