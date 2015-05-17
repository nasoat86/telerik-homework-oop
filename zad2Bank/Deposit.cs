using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2Bank
{
    class Deposit : Account, IDeposit, IDraw
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalcInterestAmount(int months)
        {
            if (this.balance > 1000)
            {
                return months * this.InterestRate;
            }
            else
            {
                return 0;
            }

           
        }

        public decimal DepositMoney(decimal amount)
        {
            return this.Balance += amount;
        }

        public decimal DrawMoney(decimal amount)
        {
            return this.Balance -= amount;
        }
    }
}
