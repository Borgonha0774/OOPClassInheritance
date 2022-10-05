using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClassInheritance
{
    internal class BusinessAccount : Account
    {
        public BusinessAccount()
        {
        }

        public double LoanLimit { get; set; }

        //atraves da super classe ( : base) posso reutilizar o construtor do Account
        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
                Balance += amount;
        }
    }
}
