using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    class CheckingAccount : Account
    {
        const double TRANSACTION_FEE = 0.40;
        public double WithdrawLimit { get; set; }
        public CheckingAccount(int number, string clientName, double balance, double withdrawLimit) : base(number, clientName, balance)
        {
            WithdrawLimit = withdrawLimit;
        }
        public override void Deposit(double amount)
        {
            Balance += amount - TRANSACTION_FEE;
        }
        public override void Withdraw(double amount)
        {
            Balance -= amount - TRANSACTION_FEE;
        }
    }  
}
