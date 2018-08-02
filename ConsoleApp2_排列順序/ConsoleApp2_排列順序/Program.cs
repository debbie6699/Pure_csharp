using System;
    class Program
    {
    static void Main(string[] args)
    {
        int[] A;
        A = new int[] { 4, 3, 10, 5 };
        Console.WriteLine();

        for (int t = 0; t < A.Length; t++)
        {
            Console.Write(A[t] + ", ");
        }
        Console.WriteLine();
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        //fix #1 由小到大排序

        for (int i = 0, j = 1; j < 4; i++, j++)
        {
            // A = new int[] { 4, 3, 10, 5 };
            // 加入回合的for回圈，每一輪找出最小的值存在A[i]
            for (int s = 0; s < (A.Length-i-1); s++)
            {
                int t = j; //** t=j，不能設定t=1 在for回圈
                if (A[i] > A[t])
                {
                    int Ano = A[t];
                    A[t] = A[i];
                    A[i] = Ano;
                }
                t++;
            }
            
        }
        Console.Write(A[0] + ", ");
        Console.Write(A[1] + ", ");
        Console.Write(A[2] + ", ");
        Console.Write(A[3] + ", ");

    }


}

