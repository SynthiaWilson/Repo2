using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationUI
{
    class BankAccount
    {
        // field -- class local variable

        private double _balance = 0;

        public double Balance 
        {       
            get { return _balance; }

            set { _balance = value; }
        }

        public double GetBalance()
        {
            return Balance; 
        }

        public void Deposit(double amountToDeposit)
        {
            _balance += amountToDeposit;
        }

    public void Withdraw(double amountToDeposit)
        {
            _balance -= amountToDeposit;
        }


    }
}
