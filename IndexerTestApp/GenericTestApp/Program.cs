using System;

namespace GenericTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Int
            // int 배열을 int 배열로 복사
            int[] sourceInt = { 1, 2, 3, 4, 5};
            int[] targetInt = new int[sourceInt.Length];    // 5짜리 int 배열 {0,0,0,0,0}
            
            Console.WriteLine("복사전 targetInt");           
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

          
            CopyArray(sourceInt, targetInt);


            Console.WriteLine("복사후 targetInt");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            #endregion
            #region Float
            float[] sourceFloat = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
            float[] targetFloat = new float[sourceFloat.Length];

            Console.WriteLine("복사전 targerFloat");
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();


            CopyArray(sourceFloat, targetFloat);


            Console.WriteLine("복사후 targerFloat");
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            #endregion
            #region String
            string[] sourceString = { "하나", "둘", "셋", "넷", "다섯" };
            string[] targetString = new string[sourceString.Length]; // 문자열의 초기값은 빈칸

            Console.WriteLine("복사전 targerString");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();


            CopyArray(sourceString, targetString);


            Console.WriteLine("복사후 targerString");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            #endregion
        }

        private static void CopyArray(string[] source, string[] target) // String
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];

            }
        }

        private static void CopyArray(float[] source, float[] target) // Float
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];

            }
        }

        private static void CopyArray(int[] source, int[] target)   // Int
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];

            }
        }
    }
}
