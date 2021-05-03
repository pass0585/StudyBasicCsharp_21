using System;

namespace _210503_Test5
{
    class Test5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3,6,9! 3,6,9! 3,6,9! 3,6,9!!");
            Console.WriteLine();

            int i;

            for(i = 0; i<=100; i++)
            {
                string Num = i.ToString();
                
                if(i==0)
                {
                    Console.Write("짝!\t");

                }
                else if( Num.Contains("3") || Num.Contains("6") || Num.Contains("9"))
                {
                    Console.Write("짝!\t");

                    if (i % 15 == 14)
                    {
                        Console.WriteLine();
                    }
                }
                
                else
                {
                    Console.Write(i+"\t");

                    if ( i % 15 == 14)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
