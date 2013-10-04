using System;


namespace Operators_79
{
    class Program
    {
        static void Main()
        {
            // Demonstrate the XOR

            char ch1 = 'H';
            char ch2 = 'i';
            char ch3 = '!';
            int key = 88;

            Console.WriteLine("Original message: " + ch1 + ch2 + ch3);

            // Encode the message
            ch1 = (char)(ch1 ^ key);
            ch2 = (char)(ch2 ^ key);
            ch3 = (char)(ch3 ^ key);

            Console.WriteLine("Encoded message: " + ch1 + ch2 + ch3);

            // Decode the message
            ch1 = (char)(ch1 ^ key);
            ch2 = (char)(ch2 ^ key);
            ch3 = (char)(ch3 ^ key);

            Console.WriteLine("Decoded message: " + ch1 + ch2 + ch3);
        }
    }
}
