using System;

namespace Look_and_say_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("개미수열의 몇 번째 항? ");
            int k = int.Parse(Console.ReadLine());
            int a;
            int b;
            int count;
            count = 1; a = 0; b = 0;
            int[] Ant1 = new int[500];
            int[] Ant2 = new int[500];
            Ant1[0] = 1;

            Console.WriteLine("1번째 수열 : " + Ant1[0]);

            for( int i = 0; i < k; i++ )
            {
                while( Ant1[a] != 0 )
                {
                    
                    if( Ant1[a] == Ant1[a+1] )
                    {
                        count = count + 1;
                        
                    }
                    else
                    {
                        Ant2[b] = Ant1[a];
                        Ant2[b+1] = count;
                        b = b + 2;
                        count = 1;
                    }
                    a++;
                }
                Array.Copy(Ant2, Ant1, Ant2.Length);
                a = 0;
                b = 0;
                Console.Write($"{i + 2}번째 수열 : ");

                foreach ( var ant in Ant1)
                {
                    if( ant == 0 )
                    {
                        break;
                    }
                    Console.Write(ant);
                }
                Console.WriteLine();
                
            }
        }
    }
}
