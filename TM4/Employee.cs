using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM4
{
    class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public decimal AnualSalary { get; set; }

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
