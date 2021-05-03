using System;

namespace _210503_Test2
{
    class Test2
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요 : ");
            string Name = Console.ReadLine();
            Console.Write("나이를 입력하세요 : ");
            string Age = Console.ReadLine();
            Console.Write("주소를 입력하세요 : ");
            string Adress = Console.ReadLine();

            Console.WriteLine($"반갑습니다. 저는 {Adress}에 살고 있는 {Age}살 {Name}입니다.");

        }
    }
}
