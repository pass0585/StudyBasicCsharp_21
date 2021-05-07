using System;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int Num = random.Next();
            int Order = int.Parse(Console.ReadLine());

            while(Num==Order)
            {

            }
            Console.WriteLine("");
        }
    }
}
