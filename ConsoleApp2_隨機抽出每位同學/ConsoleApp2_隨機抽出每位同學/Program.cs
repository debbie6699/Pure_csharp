using System;
    class Program
    {
    static void Main(string[] args)
    {
        Random x = new Random();
        Double Mrx = x.NextDouble();
        Console.WriteLine("Mrx==" + Mrx);

        string[] C;
        C = new string[] { "BLUE","YELLOW", "RED", "BLACK" }; //if "BLUE,YELLOW,RED,BLACK" 是否可以?
        Console.WriteLine("=================================");

        Console.WriteLine("目前的顏色有 ");
        for (int t=0;  t < C.Length; t++)
        {
            Console.WriteLine(" " + C[t]);
        }

        Console.WriteLine();
        Console.WriteLine("隨機抽出的顏色 ");

        int uncount = C.Length;

        {
            uncount = C.Length; //
            for (int s = 0; s < C.Length; s++)
            {
                Mrx = x.NextDouble();
                int code = (int)(Mrx * uncount); //此句(Mrx)

                Console.WriteLine(" " + C[code]);
                // 對調，eg.C[0~3],若隨機抽中C[1],C[1]放入cal,C[4-1=3]放入C[1],cal=C[1]放入C[3];
                {
                    string cal = C[code];
                    C[code] = C[uncount - 1];
                    C[uncount - 1] = cal;
                }

                uncount -= 1;
            }

        }
        Console.WriteLine("結束");


    }
    }
