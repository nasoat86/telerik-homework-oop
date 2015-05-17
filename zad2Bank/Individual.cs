using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2Bank
{
    class Individual : Customer
    {
        private int egn;

        public int Egn
        {
            get { return this.egn; }
            set { this.egn = value; }
        }

        public Individual(int customerNum, string fName, string lName)
            : base(customerNum, fName, lName)
        {
            if (String.IsNullOrWhiteSpace(lName) || lName.Length < 2)
            {
                throw new ArgumentException("Last name cannot be null or empty.");
            }

            this.Egn = egn;
        }
    }
}
