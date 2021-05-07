using System;
using System.Diagnostics.CodeAnalysis;

namespace ArrayTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("수학점수");
            //int[] scores = new int[5] { 80, 74, 81, 94, 100 };

            int[] scores = { 80, 74, 81, 94, 100 };  // 제일 짧은 초기화방법
            /*scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 94;
            scores[4] = 100;*/

            foreach (var item in scores)
            {
                Console.Write(item+"\t");
            }

            int sum = 0;

            for (int i=0; i<scores.Length;i++)
            {
                sum += scores[i];
            }
            //  평균
            float average = (float) sum / scores.Length;

            Console.WriteLine($"수학점수 총합 : {sum}, 평균 : {average}");
        }
    }
}
