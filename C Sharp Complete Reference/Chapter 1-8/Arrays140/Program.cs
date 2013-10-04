// Demonstrates a one-dimensional array
using System;

namespace Arrays140
{
    class Program
    {
        static void Main()
        {
            int[] sample = new int[10];
            int i;

            for (i = 0; i < 10; i = i + 1)
                sample[i] = i;

            for (i = 0; i < 10; i = i + 1)
                Console.WriteLine("sample[" + i + "]: " + sample[i]);
        }
    }
}
