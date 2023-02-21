using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee(1,"Anita", 8000);
            Emp.Display();
            Emp.GROSSSALARY(8000);
            Emp.HRACALCULATE(8000);
            Emp.TACALCULATE(8000);
            Emp.DACALCULATE(8000);
        }
    }
}
