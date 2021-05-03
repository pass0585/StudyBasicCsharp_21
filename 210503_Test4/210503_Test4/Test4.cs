using System;

namespace _210503_Test4
{
    class Test4
    {
        static void Main(string[] args)
        {
            int i;
            int j;

            for(i=7;i<=9;i++)
            {
                Console.WriteLine($"{i}단 계산 시작");
                for(j=1;j<=9;j++)
                {
                    Console.Write($"{i} * {j} = { i * j }   ");
                }
                Console.WriteLine();
            }
        }
    }
}
