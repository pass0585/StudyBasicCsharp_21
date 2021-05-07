using System;

namespace ExceptionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("프로그램 시작");

            int[] array = new int[5];
            for (int i = 0; i <= 5; i++)
            {
                try
                {
                    array[i] = (i + 1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"문제발생 {ex.Message}, 관리자에게 문의하세요 : Main(16~)");
                }
            }

            Console.WriteLine("다른 로직 수행");
            //  ...

            Console.WriteLine("프로그램 종료");

        }
    }
}
