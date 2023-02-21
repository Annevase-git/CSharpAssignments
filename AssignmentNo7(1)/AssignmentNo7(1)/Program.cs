using System;
using System.IO;

namespace AssignmentNo7_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ANNEVASE\CSharpAssignments\Assignment 1";

            var dir = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

            var files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
            Console.WriteLine("Display Directories");

            foreach(string obj in dir)
            {
                var info = new DirectoryInfo(obj);
                Console.WriteLine($"{info.FullName}");

            }
            Console.WriteLine("Display Files");
            foreach (string obj1 in files)
            {
                var info = new FileInfo(obj1);
                Console.WriteLine($"{Path.GetFileName(obj1)} - { info.Length} bytes");

            }
            Console.ReadKey();


        }
    }
}
