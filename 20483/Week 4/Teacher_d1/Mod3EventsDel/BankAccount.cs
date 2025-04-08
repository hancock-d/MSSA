using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3EventsDel
{
    delegate void LowBalDel(double bal);
    internal class BankAccount
    {
        public event LowBalDel LowBalance;
        public int AccountNumber {  get; set; }

        private double accountbalance;

        public double AccountBalance
        {
            get { return this.accountbalance; }
            set
            {
                if (value < 200)
                    LowBalance(value);// raising of event
                else
                    this.accountbalance = value;

            }
        }
    }
}
