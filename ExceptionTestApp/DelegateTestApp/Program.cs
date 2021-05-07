using System;

namespace DelegateTestApp
{
    delegate int Calculate(int a, int b); // 계산 대리자 선언
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc;
            calc = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine($"a + b = {calc(3, 5)}");
        }
    }
}
