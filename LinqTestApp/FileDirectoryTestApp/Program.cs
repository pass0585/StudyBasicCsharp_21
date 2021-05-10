using System;
using System.IO;

namespace FileDirectoryTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string path = @"C:\GitRepository\StudyBasicCsharp_21"; // \\ 역슬래시 두번써도돼 // Verbatim string
            var dirs = Directory.GetDirectories(path);

            foreach (var item in dirs)
            {
                Console.WriteLine(item);
                var dirInfo = new DirectoryInfo(item);
                Console.WriteLine($"{dirInfo.Name} / {dirInfo.Attributes} / {dirInfo.CreationTime}");
            }

            var files = Directory.GetFiles(path);
            foreach (var item in files)
            {
                Console.WriteLine(item);
                var fileInfo = new FileInfo(item);
                Console.WriteLine($"{fileInfo.Name} / {fileInfo.Attributes} / {fileInfo.CreationTime} / {fileInfo.Length}");
            }*/

            string newPath = @"C:\Test\Help";   //  디렉토리, 파일을 생성할 위치
            int dirNum = 0; //  디렉토리 1씩 증가시켜서 중복피하기 위한 정수
            int i = 0;

            while (true)    //  무한반복 프로그램
            {
                Console.WriteLine("file/dir을 입력하세요.(종료는  X)");
                var input = Console.ReadLine();

                if(input == "X")
                { break; }
                else 
                {
                    // 파일폴더 만드는 로직
                    if (input == "file")
                    {
                        var fileName = $"SampleFile_{DateTime.Now.ToString("yyMMddHHmmssff")}.txt";
                        var fullPath = $@"{newPath}\{fileName}";
                        File.Create(fullPath);
                    }
                    else if (input == "dir")
                    {
                        //Console.WriteLine("디렉토리생성");
                        var dirName = "SampleDirectory";
                        var fullPath = @$"{newPath}\{dirName}";
                        
                        if (!Directory.Exists(fullPath))
                        {
                            Directory.CreateDirectory(fullPath);
                        }
                        else
                        {
                            dirNum++;
                            fullPath = $@"{newPath}\{dirName}{dirNum}";
                            Directory.CreateDirectory(fullPath);
                        }
                    }
                    else
                    {
                        Console.WriteLine("file / dir 입력");
                        
                    }
                }
            }
            Console.WriteLine("프로그램종료");
        }
    }
}
