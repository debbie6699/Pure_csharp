using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_輸入數字出現圖案
{
    class Program
    {
        static void Main(string[] args)
        {
            String keyNum;
            Console.Write("請任意輸入一個整數: ");
            keyNum = Console.ReadLine( );
            //Console.WriteLine(keyNum);

            bool nLevel;
            // int nLevel;要用bool值;
            int nShow;
            int nBlank;
            int nPic;
            
            nLevel = int.TryParse(keyNum,out nShow); //注意語法，間隔用","，"out"的o為小寫
            //Console.WriteLine(nShow);
            //nBlank = nShow - 1; //nBlank指定
            nPic = 1;
            while (nShow>=1)
            {
                {
                    int w = 1;
                    nBlank = nShow - 1;
                    while (w <= nBlank)
                    {
                        Console.Write(" ");
                        w += 1;
                    }
                }
                {
                    int w = 1;                   
                    while (w <= nPic)
                    {
                        Console.Write("Y");
                        w += 1;
                        // nPic += 2; //此句不可以加在回圈
                    }
                }
                {
                    Console.WriteLine();
                    nPic += 2;
                    nShow -= 1;
                }

            }






        }
    }
}
