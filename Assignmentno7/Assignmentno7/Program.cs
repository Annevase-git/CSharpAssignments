using System;
using System.IO;

namespace Assignmentno7
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Assignment 7.1\anita.txt";
            if (File.Exists(path))
            {
              Console.WriteLine("File is exit..");

            }
            else
            {
                Console.WriteLine("File is not exit..");
            }

            Console.ReadLine();
        }
    }
}
