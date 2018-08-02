using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_排列順序
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] A;
            A = new double[] { 4.2, 0.6, 5.3, 11.2, 3.8 };
            Console.WriteLine();

            for(int t=0; t < A.Length;t++)
            {
                Console.Write(A[t]+", ");
            }
            Console.WriteLine();



        }
    }
}
