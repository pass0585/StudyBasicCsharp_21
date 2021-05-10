using System;
using System.IO;

namespace FileReadingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullPath = @"C:\Test\Help\PFRO.log";
            StreamReader sr = new StreamReader(new FileStream(fullPath, FileMode.Open));

            while (sr.EndOfStream == false)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();
            // 텍스트 파일 읽어오는 부분
            Console.WriteLine("텍스트파일 읽기완료!!");

            // 텍스트 작성
            string writePath = @"C:\Test\Help\PSS.txt";
            StreamWriter se = new StreamWriter(new FileStream(writePath, FileMode.Create));

            se.Write("Hello, World!\n");
            se.Write("안녕하세요\n");
            se.Write(3.141592f+"\n");
            se.Close(); // 필수

            Console.WriteLine("텍스트파일 작성완료!!");
        }
    }
}
