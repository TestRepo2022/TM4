using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM4
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }


        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return Id;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return Email;
                else if (index == 3)
                    return Salary;
                else
                    throw new IndexOutOfRangeException("Index was not found !");
            }

            set
            {
                if (index == 0)
                    Id = (int)value;
                else if (index == 1)
                    Name = value.ToString();
                else if (index == 2)
                    Email = value.ToString();
                else if (index == 3)
                    Salary = Convert.ToDecimal(value);
                else
                    throw new IndexOutOfRangeException("Index was not found !");

            }
        }

        public object this[string key]
        {
            get
            {
                if (key.ToLower() == "id")
                    return Id;
                else if (key.ToLower() == "name")
                    return Name;
                else if (key.ToLower() == "email")
                    return Email;
                else if (key.ToLower() == "salary")
                    return Salary;
                else
                    throw new Exception("Key was not found !");
            }

            set
            {
                if (key.ToLower() == "id")
                    Id = (int)value;
                else if (key.ToLower() == "name")
                    Name = value.ToString();
                else if (key.ToLower() == "email")
                    Email = value.ToString();
                else if (key.ToLower() == "salary")
                    Salary = Convert.ToDecimal(value);
                else
                    throw new Exception("Key was not found !");

            }
        }
    }
}
