using System;
using System.Security.Cryptography.X509Certificates;

namespace IndexerTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyEnumerator();
            foreach (var i in obj)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}
