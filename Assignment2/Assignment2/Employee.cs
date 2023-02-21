using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Employee
    {
        int EmpNo;
        string EmpName;
        double Salary, hra, da, ta, pf, tds, NetSalary, GrossSalary;


        //constructor
        public Employee(int EmpNo, string EmpName, double Salary)
        {
            if (EmpNo <= 0)
            {
                throw new Exception("Empty");
            }

            else
            {
                this.EmpNo = EmpNo;
            }
            if (string.IsNullOrEmpty(EmpName))
            {
                throw new Exception("This is Empty");

            }
            else
            {
                this.EmpName = EmpName;
            }
            if (Salary <= 0)
            {
                throw new Exception("Empty");
            }
            else
            {
                this.Salary = Salary;
            }
        }
        public void HRACALCULATE(int v)
        {
            if (Salary < 5000)
            {
                hra = 0.1 * Salary;
            }
            else if (Salary < 10000)
            {
                hra = 0.15 * Salary;
            }
            else if (Salary < 15000)
            {
                hra = 0.20 * Salary;
            }
            else if (Salary < 20000)
            {
                hra = 0.25 * Salary;
            }
            else
            {
                hra = 0.30 * Salary;
            }
            Console.WriteLine("HRA is." + hra);
        }
        public void TACALCULATE(int v)
        {
            if (Salary < 5000)
            {
                ta = 0.05 * Salary;
            }
            else if (Salary < 10000)
            {
                ta = 0.10 * Salary;
            }
            else if (Salary < 15000)
            {
                ta = 0.15 * Salary;
            }
            else if (Salary < 20000)
            {
                ta = 0.20 * Salary;
            }
            else
            {
                ta = 0.25 * Salary;
            }
            Console.WriteLine("TA is." + ta);

        }
        public void DACALCULATE(int v)
        {
            if (Salary < 5000)
            {
                da = 0.15 * Salary;
            }
            else if (Salary < 10000)
            {
                da = 0.20 * Salary;
            }
            else if (Salary < 15000)
            {
                da = 0.25 * Salary;
            }
            else if (Salary < 20000)
            {
                da = 0.30 * Salary;
            }
            else
            {
                da = 0.35 * Salary;
            }
            Console.WriteLine("DA is." + da);

        }
        public void GROSSSALARY(double Salary)
        {
            GrossSalary = Salary + hra + ta + da;
            Console.WriteLine("GrossSalary is " +GrossSalary);
        }
        public void CALCULATESALARY()
        {
            pf = 0.1 * GrossSalary;
            Console.WriteLine("PF is:" + pf);
            tds = 0.18 * GrossSalary;
            Console.WriteLine("TDS is:" + tds);
            NetSalary = GrossSalary - (pf + tds);
            Console.WriteLine("NetSalary is:" + NetSalary);
        }
        public void Display()
        {
            Console.WriteLine("The Employee id is" + EmpNo);
            Console.WriteLine("The Employee name is" + EmpName);
            Console.WriteLine("The Employee Salary is" + Salary);
            

        }







    }
}
