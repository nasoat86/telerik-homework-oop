using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2Bank
{
    class Bank
    {
        static void Main(string[] args)
        {
            Deposit individualDeposit = new Deposit(new Individual(1111, "Ivan", "Petrov"), 1000m, 0.5m);
            Deposit companyDeposit = new Deposit(new Company(2222, "Telerik"), 111010.10m, 0.6m);

            Loan individualLoan = new Loan(new Individual(2369, "Todor", "Jiwkov"), 963.99m, 0.9m);
            Loan companyLoan = new Loan(new Company(2500, "BTK"), 500m, 0.5m);

            Mortgage individualMortgage = new Mortgage(new Individual(5478, "Petar", "Petrov"), 890m, 0.5m);
            Mortgage companyMortgage = new Mortgage(new Company(5400, "Procredit"), 870m, 0.5m);

            List<Account> accountList = new List<Account>() { individualDeposit, companyDeposit, individualLoan, companyLoan, individualMortgage, companyMortgage };

            foreach (var account in accountList)
            {
                Console.WriteLine(account.Customer.ToString());
                Console.WriteLine("\tBalance: {0}", account.Balance);
                Console.WriteLine("\tInterestAmmount: {0}", account.CalcInterestAmount(5));
            }

            Console.WriteLine();

            Console.WriteLine(individualDeposit.Customer.ToString());
            Console.WriteLine("\tBalance: {0}", individualDeposit.Balance);
            individualDeposit.DepositMoney(763.00m);
            Console.WriteLine("\tBalance after deposit: {0}", individualDeposit.Balance);
            individualDeposit.DrawMoney(500m);
            Console.WriteLine("\tBalance after draw: {0}", individualDeposit.Balance);

        }
    }
}
