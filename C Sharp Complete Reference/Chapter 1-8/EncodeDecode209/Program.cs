// Encode or decode a message using a simple substitution cipher.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeDecode209
{
    class Program
    {
        static int Main(string[] args)
        {
            // See if arguments are present.
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: encode/decode word1 [word2...wordN]");
                return 1; // return failure code
            }

            // if args present, first arg must be encode or decode.
            if (args[0] != "encode" & args[0] != "decode")
            {
                Console.WriteLine("First arg must be encode of decode.");
                return 1; // return failure code
            }

            // Encode of decode message.
            for (int n = 1; n < args.Length; n++)
            {
                for (int i = 0; i < args[n].Length; i++)
                {
                    if(args[0] == "encode")
                        Console.Write((char) (args[n][i] + 1));
                    else
                        Console.Write((char) (args[n][i] - 1));
                }
                Console.Write(" ");
            }

            Console.WriteLine();
            Console.ReadKey();
            return 0;
        }
    }
}
