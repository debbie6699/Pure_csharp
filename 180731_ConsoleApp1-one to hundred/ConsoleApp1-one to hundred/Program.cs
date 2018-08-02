using System;
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("從1~100猜一個數字:");

            int Mrx;
            // fix#1 NextDouble是大於0，小於1的數字，int強制轉換double為整數
            // fix#2 new Random() 隨機產生數字
            Mrx =(int)(new Random ().NextDouble() * 100+1);
            // Console.WriteLine(Mrx); 不顯示出隨機的數字
            /* int Msx;
            Msx = (int)(new Random().NextDouble()*1000);
            Console.WriteLine(Msx); */
            Console.WriteLine("===============================");

            String guessNum;
            int showNum;
            bool keyNum;

            bool guess = false;

            while(! guess)
            {
                Console.WriteLine("請輸入一個整數:");
                guessNum = Console.ReadLine();
                // Console.WriteLine(guessNum);
                // 把輸入的字串轉換成int
                keyNum = int.TryParse(guessNum, out showNum);
                if (keyNum)
                {
                    Console.Write("Key in number is ");
                    Console.WriteLine(showNum);
                    if (showNum > Mrx)
                    {
                        Console.WriteLine("please key in smaller");
                    }
                    if (showNum < Mrx)
                    {
                        Console.WriteLine("please key in bigger");
                    }
                    if (showNum == Mrx)
                    {
                        guess = true;
                        Console.WriteLine("Bingo");
                    }


                }

            }                       
        }
    }

