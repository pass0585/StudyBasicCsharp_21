using System;

namespace Test1
{
    class Boiler
    {
        public string Brand;
        public int Voltage;
        public int Temperature;

        public void PrintAll()
        {
            Console.WriteLine($"Brand : {Brand}, Voltage : {Voltage}, Temperature : {Temperature}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler { Brand = "귀뚜라미", Voltage = 220, Temperature = 45 };
            kitturami.PrintAll();
        }
    }
}
