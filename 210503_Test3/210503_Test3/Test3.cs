using System;

namespace _210503_Test3
{
    class Test3
    {
        static void Main(string[] args)
        {
            int i;
            int j;

            for(i=1; i<=5; i++)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (i = 6; i <= 10; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
