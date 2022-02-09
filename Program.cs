using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2proektC_tulusa
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo k;
            do
            {
                Console.WriteLine("Vajuta mingi klahv!!");
                k = Console.ReadKey();
                Console.Beep();
            } while (k.Key!=ConsoleKey.Escape);
            Environment.Exit(0);



    

            
        }
    }
}
