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

            int[] list = { 107, 108, 109 };

            try
            {
                string message = null;
                Console.WriteLine(message.Length);
                var result = list[1] / 0;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            /*catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                // IndexOutOfRange 예외시 다른일 처리
                Console.WriteLine("IndexOutOfRange 이후 처리!");
                throw;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                Console.WriteLine("DivideByZeroException 이후 처리!!");

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                Console.WriteLine("NullReferenceException 이후 처리!!");

            }*/
            catch (Exception ex) // 모든 예외 포함
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("finally_언제든지 실행됨");
            }
            Console.WriteLine("프로그램 종료");

        }
    }
}
