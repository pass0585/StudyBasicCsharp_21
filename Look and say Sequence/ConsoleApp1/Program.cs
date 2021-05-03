using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("개미수열 몇 번째 ? ");
            int Num = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 0;
            int count = 1;

            int[] Ant1 = new int[500];
            int[] Ant2 = new int[500];
            Ant1[0] = 1;
            Console.WriteLine("1 번째 수열 : " + Ant1[0]);
            for(int i=0; i<Num; i++)
            {
                while(Ant1[a]!=0)
                {
                    if(Ant1[a]==Ant1[a+1])
                    {
                        ++count;
                    }
                    else
                    {
                        Ant2[b] = Ant1[a];
                        Ant2[b + 1] = count;
                        b = b + 2;
                        count = 1;
                        
                    }
                    ++a;
                }
                Array.Copy(Ant2, Ant1, Ant2.Length);
                a = 0; b = 0;
                Console.Write(i + 2 + "번째 수열 : ");

                foreach(var ant in Ant2)
                {
                    if(ant==0)
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
