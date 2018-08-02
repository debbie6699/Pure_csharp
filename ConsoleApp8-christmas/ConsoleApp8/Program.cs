using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("開始");
            int num_star = 1;
            int num_blank = 4;
            int num_line = 1;
            int s = 1;
            while (s <= 5)
            {
                {
                    int i = 1;
                    while (i <= num_blank)
                    {
                        Console.Write(" ");
                        i += 1;                       
                    }
                }
                {
                    int i = 1;
                    while (i <= num_star)
                    {
                        Console.Write("*");
                        i += 1;
                    }
                }
                {
                    Console.WriteLine();
                    /*int i = 1;
                    while (i <= num_line)
                    {
                        Console.Write("\n");
                        i += 1;
                    }*/
                    num_blank -= 1;
                    num_star += 2;
                    s += 1;
                }
            }
        }
    }
}
                /*Console.Write(" ");
                Console.Write(" ");
                Console.Write(" ");
                Console.Write(" ");
                Console.Write("*");
                Console.Write("\n");

                Console.Write(" ");
                Console.Write(" ");
                Console.Write(" ");
                Console.Write("*");
                Console.Write("*");
                Console.Write("*");
                Console.Write("\n");

                Console.Write(" ");
                Console.Write(" ");
                Console.Write("*");
                Console.Write("*");
                Console.Write("*");
                Console.Write("*");
                Console.Write("*");
                Console.Write("\n");*/