using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class Cat : Animal
    {

        // 기본생성자
        public Cat() { this.Age = 0; } 

        //액션 -> 메서드
        public void Meow() { Console.WriteLine("냥냥 웁니다."); }
    }
}
