using System;

namespace Test3
{
    class Car
    {
        public string Name;
        public string Maker;
        public string Color;
        public int YearModel;
        public int MaxSpeed;
        public string UniqueNumber;

        public void start()
        {
            Console.WriteLine($"{Name}의 시동을 겁니다.");
        }
        public void Accelerate()
        {
            Console.WriteLine($"최대시속 {MaxSpeed}km/h로 가속합니다.");

        }
        public void TurnRight()
        {
            Console.WriteLine($"{Name}를 우회전합니다.");

        }
        public void Brake()
        {
            Console.WriteLine($"{Name}의 브레이크를 밟습니다.");

        }
    }
    abstract class ElectricCar : Car
    {
        public abstract void Recharge();      
    }
    class HybridCar : ElectricCar
    {
        public override void Recharge()
        {
            Console.WriteLine($"달리면서 배터리를 충전합니다");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HybridCar ioniq = new HybridCar();
            ioniq.Name = "아이오닉";
            ioniq.Maker = "현대자동차";
            ioniq.Color = "White";
            ioniq.YearModel = 2018;
            ioniq.MaxSpeed = 220;
            ioniq.UniqueNumber = "54라 3346";

            ioniq.start();
            ioniq.Accelerate();
            ioniq.Recharge();
            ioniq.TurnRight();
            ioniq.Brake();

        }
    }
}
