using System;

namespace Assignment_1
{
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            int choice, num1, num2;
            Console.WriteLine("Enter \n 1.Addition \n 2.Subraction \n 3.Multiplication \n 4.Division");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2 Nos: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition Result: " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Subtraction Result: " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Multiplication Result: " + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("Division Result: " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Enter correct choice.");
                    break;
            }
            Console.ReadKey();

        }
    }
}