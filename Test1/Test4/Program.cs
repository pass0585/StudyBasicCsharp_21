using System;
using System.Collections;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable()
            {
                [0] = "빨간색",
                [1] = "주황색",
                [2] = "노란색",
                [3] = "초록색",
                [4] = "파란색",
                [5] = "남색",
                [6] = "보라색",
                
            };
            Console.Write("무지개색은 ");
            for (int i = 0; i < ht.Count; i++)
            {
                Console.Write($"{ht[i]}, ");
            }
            Console.WriteLine("입니다.");
            Console.WriteLine();
            Console.WriteLine("Key와 Value 확인");
            Console.WriteLine($"Purple은 {ht[6]} 입니다.");


        }
    }
}
