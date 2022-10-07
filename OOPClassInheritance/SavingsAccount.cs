﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClassInheritance
{
    internal class SavingsAccount : Account
    {
        public SavingsAccount()
        {
        }

        public double InterestRate { get; set; }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base (number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
