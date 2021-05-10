﻿using System;

namespace LambdaTestApp
{
    class Program
    {
        delegate void DoSomething();
        delegate string Concatenate(string[] arr);
        static void Main(string[] args)
        {
           
            //DoSomething doIt = delegate ();
            DoSomething doIt = () =>
            {
                Console.WriteLine("Hello, ");
                Console.WriteLine("John Doe~!");
                return;
            };
            doIt();



            Concatenate concat = (arr) =>
            {
                string result = "";
                foreach (var item in arr)
                {
                    result += item;
                }
                return result;
            };

            string[] strarr = { "아버지가", "방에", "들어가신다" };
            Console.WriteLine(concat(strarr));


            Func<int> func1 = () =>  3;

            var val = func1();
            Console.WriteLine($"val의 값은 {val}.");

            Func<int, int, int> plus = (x, y) => x + y;
            Console.WriteLine($"3 + 5 = {plus(3, 5)}");

            Action<int> area = (r) =>
            {
                Console.WriteLine($"원의 넓이는 {(double)r * r * Math.PI}");
            };
            area(10);
        }
    }
}
