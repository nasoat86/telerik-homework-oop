using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2Bank
{
    class Mortgage : Account, IDeposit
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {            
        }

        public override decimal CalcInterestAmount(int months)
        {
            if (this.Customer is Individual)
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
                {
                    return (months - 6) * this.InterestRate;
                }
            }
            else if (this.Customer is Company)
            {
                if (months <= 12)
                {
                    return (months*this.InterestRate)/2;
                }
                else
                {
                    return (12 * this.InterestRate)/2 + (months - 12) * this.InterestRate;
                }
            }
            else return 0;
        }

        public decimal DepositMoney(decimal amount)
        {
            return this.Balance += amount;
        }
    }
}
