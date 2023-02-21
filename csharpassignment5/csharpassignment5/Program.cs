using System;



namespace csharpassignment5
{
    public class Program
    {
        public static void Main()
        {




            // allocating memory for topic.
            string[] s = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("element - {0} : ", i);
                s[i] = Convert.ToString(Console.ReadLine());
            }
            PrintArray(s);
            string[] copy = new string[s.Length];
            Array.Copy(s, copy, s.Length);
            Console.WriteLine("After Copy:");
            PrintArray(s);
            Array.Sort(s);
            Console.WriteLine("After Sort:");
            PrintArray(s);
            Array.Reverse(s);
            Console.WriteLine("After Reverse:");
            PrintArray(s);
            Array.Clear(s, 1, 2);
            Console.WriteLine("After Clear:");
            PrintArray(s);



            int[] a = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            PrintArray1(a);
            int[] copy1 = new int[a.Length];
            Array.Copy(a, copy1, a.Length);
            Console.WriteLine("After Copy:");
            PrintArray1(a);
            Array.Sort(a);
            Console.WriteLine("After Sort:");
            PrintArray1(a);
            Array.Reverse(a);
            Console.WriteLine("After Reverse:");
            PrintArray1(a);
            Array.Clear(a, 1, 2);
            Console.WriteLine("After Clear:");
            PrintArray1(a);




        }
        public static void PrintArray(string[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine("Array will be:" + Arr[i]);
            }
        }
        public static void PrintArray1(int[] Ar)
        {
            for (int i = 0; i < Ar.Length; i++)
            {
                Console.WriteLine("Array will be:" + Ar[i]);
            }
        }
    }
}
