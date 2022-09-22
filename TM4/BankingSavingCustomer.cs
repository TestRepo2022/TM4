using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM4
{
    class BankingSavingCustomer
    {
        public string AcNo { get; }


        public string Name;
        private decimal _Amount;

        public BankingSavingCustomer(string AcNo, string Name, decimal Amount)
        {
            this.AcNo = AcNo;
            this.Name = Name;
            this._Amount = Amount;
        }

        //public string AcNo
        //{
        //    get { return _AcNo; }
        //}

        public decimal Amount
        {
            get { return _Amount; }
            set
            {
                if (value >= 1000) {
                    _Amount = value;
                }
                else
                {
                    Console.WriteLine(" Transaction failed,Insufficient amount !");
                }
            }
        }
    }
}
