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

        public BusinessAccount(double loanLimit)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            amount = amount * LoanLimit;    
        }
    }
}
