using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClassInheritance
{
    internal class Account
    {
        public Account()
        {
        }

        public int Number { get; set; }
        public string  Holder { get; set; }
        public double Balance { get; set; }


        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void WithDraw(double amount)
        {
            amount--;   
        }

        public void Deposit(double amount)
        {
            amount++;
        }


    }
}
