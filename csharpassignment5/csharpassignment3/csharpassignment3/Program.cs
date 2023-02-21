using System;
using System.Collections.Generic;
using System.Text;

namespace OopsCsharpAssignment3
{
    class MarketingExecutive : Employee, Interface1
    {
        public MarketingExecutive(int EmpNo, string EmpName, double Salary) : base(EmpNo, EmpName, Salary)
        {

        }
        double Kilometer_travel;
        double TourAllowance;
        double TelephoneAllowance;
        double Grosssalary;
        public void MEGROSSSALARY()
        {
            Console.WriteLine("Enter the Kilmeter_travel");
            Kilometer_travel = Convert.ToDouble(Console.ReadLine());
            TourAllowance = 5 * Kilometer_travel;
            TelephoneAllowance = 1000;

            Grosssalary = Salary + hra + ta + da + TelephoneAllowance + TourAllowance;
            Console.WriteLine("GrossSalary is:" + Grosssalary);

        }
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            pf = 0.1 * GrossSalary;
            Console.WriteLine("PF is:" + pf);
            tds = 0.18 * GrossSalary;
            Console.WriteLine("TDS is:" + tds);
            NetSalary = GrossSalary - (pf + tds);
            Console.WriteLine("NetSalary is:" + NetSalary);

        }
        public new void display()
        {
            Console.WriteLine("The employee id is:" + EmpNo);
            Console.WriteLine("The employee name is:" + EmpName);
            Console.WriteLine("The employee salary is:" + Salary);
        }
    }
}


    
