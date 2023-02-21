using System;



namespace Csharpassignment5._3
{



    class MyStack<T>
    {
        private T[] a = new T[10];
        int top = -1;
        int n;



        public MyStack()
        {




        }
        public MyStack(int n)
        {
            this.n = n;



        }




        bool IsEmpty()
        {
            return (top < 0);
        }



        internal bool Push(T data)
        {
            if (top == n - 1)
            {
                throw new stackException("Stack Overflow");
            }
            else
            {
                a[++top] = data;
                return true;
            }
        }
        internal void Pop()
        {
            if (top == -1)
            {



                throw new stackException("Stack underflow");




            }



            else
            {
                Console.WriteLine($"\n{a[top]} popped.");
                Array.Clear(a, top--, 1);
            }
        }
        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }




    }
    public class stackException : ApplicationException
    {
        public stackException(string message) : base(message)
        {





        }
    }



    class Program
    {
        static void Main()
        {
            MyStack<string> s = new MyStack<string>(10);



            try
            {



                s.Push("Hey");
                s.Push("Aaru");
                s.Push("How");
                s.Push("are");
                s.Push("you");
                s.PrintStack();



                s.Pop();
                s.PrintStack();
            }
            catch (stackException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}



