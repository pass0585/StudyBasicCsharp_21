using System;

namespace _210503_Test
{
    class Test1
    {
        static void Main(string[] args)
        {
            Console.Write("원의 반지름을 입력하세요 : ");
            string input = Console.ReadLine();
            double r = double.Parse(input);
            double S = r * r * Math.PI;
            Console.WriteLine($"원의 반지름은 { S } ");
            

        }
    }
}
