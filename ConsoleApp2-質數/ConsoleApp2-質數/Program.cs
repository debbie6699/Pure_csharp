using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_質數
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("開始");
            int a;
            //int b;
            int x;
            bool adjust;
            a = 1;
            //x = 2; //x在此行指定為2，無法影響回圈的x;
            //b = 16;
            while(a <=100)
            {
                adjust = true;
                x = 2; //需要在回圈指定x從2開始;
                while (x <= (a - 1) && adjust)
                {
                    if (a % x == 0)
                    {
                        adjust = false;
                    }
                    x += 1;
                }
                if (adjust)
                {
                    Console.WriteLine("質數為" + a);
                }
                a += 1;


            }

        }
    }
}
