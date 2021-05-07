using System;

namespace ArrayClassTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array 클래스 사용");

            int[] array = new int[] { 5, 7, 3, 1, 9, 10, 4, 8, 2, 6 };

            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();



            System.Array.Sort(array);   //  오름차순 정렬

            foreach (var item in array) 
            {
                Console.Write($"{item}\t");
            }
              
            Console.WriteLine();



            System.Array.Reverse(array);    //  내림차순 정렬

            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
        }
    }
}
