using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2Bank
{
    class Company : Customer
    {
        private int eik;

        public int Eik
        {
            get { return this.eik; }
            set { this.eik = value; }
        }

        public Company(int customerNum, string fName)
            : base(customerNum, fName, null)
        {
            this.Eik = eik;
        }

        public Company(int customerNum, string fName, string lName)
            : base(customerNum, fName, lName)
        {
            this.Eik = eik;
        }
    }
}
