using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLayer;

namespace TM4
{
    class Employee:MyClass
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public decimal AnualSalary { get; set; }

        public void callUtils()
        {
            base.Message();
        }

        public string GetFullName()
        {
            return this.Fname + " " + this.Lname;
        }

        public virtual decimal GetMonthSalary()
        {
            return this.AnualSalary / 12;
        }
    }

    class ChildEmployee : Employee
    {
        public decimal Bonus { get; set; }

        public override decimal GetMonthSalary()
        {
            return this.AnualSalary/12+Bonus;
        }

    }

}
