using System;

namespace DelegateChainApp
{
    delegate int Calculate(int a, int b);


    class Program
    {
        static void Main(string[] args)
        {
            #region

            Calculate calc;

            //람다식
            calc = (a, b) => a + b;
            Console.WriteLine($"a + b = {calc(3, 5)}");


            //일반식
            /*calc = delegate (int a, int b)
            {
                return a + b;
            };*/
        }
    }
}
