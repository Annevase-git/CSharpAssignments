
using System;
using System.Threading;
using System.Collections;

namespace ass63
{
    public delegate bool UnderBalance(double amount);
    public delegate bool BalanceZero(double amount);
    class Account
    {

        public int accno { get; set; }
        public string name;
        public double bal;
        public double dep;
        public double withdraw;


        public Account()
        {
            accno = 0;
            name = "";
            bal = 0.0;
        }
        public Account(int accno, string name, double bal)
        {
            this.accno = accno;
            this.name = name;
            this.bal = bal;
        }
        public void Deposit(double dep)
        {
            bal = bal + dep;
            Console.WriteLine("The amount is" + bal);


        }
        public void Withdraw(double withdraw, UnderBalance ub, BalanceZero bz)
        {
            if (!bz(withdraw))
            {
                if (!ub(withdraw))
                {
                    bal = bal - withdraw;
                    Console.WriteLine("The amount is" + bal);
                }
            }

        }
        public bool UnderBalance(double amount) { return false; }
        public bool BalanceZero(double amount)
        {
            if (bal <= 0 || bal - amount <= 0)
            {
                Console.WriteLine("Transaction cannot be continued as balance is/will be insufficient/zero in Account \n");
                return true;
            }
            else
                return false;
        }

        public override string ToString()
        {
            return "\n Account number = " + accno + "\n Account name = " + name +
            "\n Account balance = " + bal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(100000282, "Dnane", 20000);
            Console.WriteLine(acc);
            acc.Deposit(5000);
            acc.Withdraw(2000, acc.UnderBalance, acc.BalanceZero);
            acc.Withdraw(60000, acc.UnderBalance, acc.BalanceZero);





        }
    }
}


 

        
            

        
    

    



