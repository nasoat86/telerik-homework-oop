using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2Bank
{
    class Loan : Account, IDeposit
    {
        public Loan(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalcInterestAmount(int months)
        {
            if (this.Customer is Customer)
            {
                if (months < 3)
                {
                    return 0;
                }
                else
                {
                    return (months - 3) * this.InterestRate;
                }
            }
            else if (this.Customer is Company)
            {
                if (months < 2)
                {
                    return 0;
                }
                else
                {
                    return (months - 2) * this.InterestRate;
                }
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
    }
}
