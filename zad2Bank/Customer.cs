using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2Bank
{
    class Customer
    {
        private int customerNum;
        private string fName;
        private string lName;

        public int CustomerNum
        {
            get { return this.customerNum; }
            set { this.customerNum = value; }
        }

        public string FName
        {
            get { return this.fName; }
            set { this.fName = value; }

        }

        public string LName
        {
            get { return this.lName; }
            set { this.lName = value; }

        }

        public Customer(int customerNum, string fname, string lname)
        {
            if (customerNum < 0)
            {
                throw new ArgumentException("Customer num can not be negative");
            }

            if (String.IsNullOrWhiteSpace(fname) || fname.Length < 2 )
            {
                throw new ArgumentException("First name should be valid");
            }

            this.CustomerNum = customerNum;
            this.FName = fname;
            this.LName = lname;

        }

        public override string ToString()
        {
            return String.Format("{0} {1} (Customer number: {2})", this.FName, this.LName, this.CustomerNum);
        }
    }
}
