using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TM4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E = new Employee();
            //E.Name = "Deepak";
            //E.Id = 1011;
            //E.Email = "deepak8999@gmail.com";
            //E.Salary = 12000;
          

            E["id"] = 1001;
            E["name"] = "Rakesh";
            E["email"] = "rakesh55@gmail.com";
            E[3] = 13000;

            Console.WriteLine(E[0]);
            Console.WriteLine(E[1]);
            Console.WriteLine(E[2]);
            Console.WriteLine(E["salary"]);


           


            //BankingSavingCustomer customer = new BankingSavingCustomer("23100922112", "Rakesh Sharma", 20000);

            //Console.WriteLine("----------Customer details---------------------");
            //Console.WriteLine("Customer Account Number: "+customer.AcNo);
            //Console.WriteLine("Customer Name: "+customer.Name);
            //Console.WriteLine("Customer Amount: "+customer.Amount);

            ////customer.AcNo = "6666";
            //customer.Amount -= 16000;


            //Console.WriteLine("----------Customer details after transaction---------------------");
            //Console.WriteLine("Customer Account Number: " + customer.AcNo);
            //Console.WriteLine("Customer Name: " + customer.Name);
            //Console.WriteLine("Customer Amount: " + customer.Amount);
            Console.Read();
        }
    }
}
