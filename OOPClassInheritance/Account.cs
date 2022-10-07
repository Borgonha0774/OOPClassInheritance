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

        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }


        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //Permite a sobreposição ou sobrescrita adicionar  (virtual)
        public virtual void WithDraw(double amount)
        {
            Balance -= amount + 5.0                                                       ;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }


    }
}
