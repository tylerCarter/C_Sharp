﻿// Demonstrate an array overrun.

using System;

namespace Array143
{
    class Program
    {
        static void Main()
        {
            int[] sample = new int[10];
            int i;

            // Generate an array overrun.
            for (i = 0; i < 100; i = i + 1)
                sample[i] = i;
        }
    }
}
