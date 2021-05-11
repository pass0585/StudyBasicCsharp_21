using System;

namespace Test2
{
    class Boiler
    {
        
        byte voltage;
        int temperature;

        public byte Voltage
        {
            get { return this.voltage; }
            set
            {
                if (value == 110 || value == 220)
                {
                    voltage = value;
                }
                else
                {
                    Console.WriteLine("잘못된 전압 입력");
                }
            }
        }
        public int Temperature
        {
            get { return this.temperature; }
            set 
            {
                if (value <= 5)
                {
                    temperature = 5;

                }
                else if (value > 5 && value < 70)
                {
                    temperature = value;

                }
                else if (value >= 70)
                {
                    temperature = 70;
                }
                else
                {
                    Console.WriteLine("잘못된 온도 입력");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler();
            Console.Write("온도입력 :");
            kitturami.Temperature = int.Parse(Console.ReadLine());
            Console.Write("전압입력 :");
            kitturami.Voltage = byte.Parse(Console.ReadLine());
            

            Console.WriteLine($"온도 : {kitturami.Temperature}, 전압 : {kitturami.Voltage}");
        }
    }
}
