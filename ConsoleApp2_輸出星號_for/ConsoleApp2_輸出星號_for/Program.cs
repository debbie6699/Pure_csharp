using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_輸出星號_for
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("請輸入數字：");//輸出主控台
            int Z = int.Parse(Console.ReadLine());//讓變數Z等同輸入的數字

            string Y = "";
            for (int i = 0; i < Z; i++)
            {
                string X = "*";
                if (i == 0)
                {
                    Y = X;
                }
                else
                {
                    Y = X + Y;
                }
                System.Console.WriteLine(Y);//輸出主控台
            }
        }
    }
}
