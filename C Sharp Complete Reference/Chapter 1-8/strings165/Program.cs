﻿using System;

namespace strings165
{
    class Program
    {
        static void Main()
        {
            string orgstr = "C# makes strings easy.";

            // Construct a substring.
            string substr = orgstr.Substring(5, 12);

            Console.WriteLine("orgstr: " + orgstr);
            Console.WriteLine("substr: " + substr);
        }
    }
}
