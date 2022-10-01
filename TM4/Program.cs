using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TM4.DBResources;
using TM4.UserManagement;
using System.Collections;
using UtilityLayer;
namespace TM4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.callUtils();

            //ArrayList list = new ArrayList();
            //list.Add("Php");
            //list.Add("java");
            //list.Add(1000);
            //list.Add(true);

            //list.Capacity = 10;


            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);
            //Console.WriteLine(list.IsFixedSize);
            //Console.WriteLine(list.IsReadOnly);


            //IUserAutho autho = new UserService();

            //IUserManage manage = new UserService();





            //ChildEmployee obj = new ChildEmployee();
            //obj.Fname = "Rakesh";
            //obj.Lname = "Verma";
            //obj.AnualSalary = 120000;
            //obj.Bonus = 6000;

            //Console.WriteLine("Full Name: "+obj.GetFullName());
            //Console.WriteLine("Total Month Salary : "+obj.GetMonthSalary());



            //Calculation obj = new Calculation();
            //var result=obj.Addition(10.54, 90.888);
            //Console.WriteLine("Result : "+result);

            //obj.Login("923892422");

            //CnnectionProvider provider = new CnnectionProvider();
            //provider.ReadConnection();
            //ManageEmployees manage = new ManageEmployees();
            //manage.CreateEmployee();

            //Utility o1 = new Utility();
            //Utility o2 = new Utility();
            //Utility o3 = new Utility();

            //o1.PrintNum();



            // Utility.SendEmail();

            //Utility utility = new Utility();
            //utility.SendMessage();


            //Employee E = new Employee();
            ////E.Name = "Deepak";
            ////E.Id = 1011;
            ////E.Email = "deepak8999@gmail.com";
            ////E.Salary = 12000;


            //E["id"] = 1001;
            //E["name"] = "Rakesh";
            //E["email"] = "rakesh55@gmail.com";
            //E[3] = 13000;

            //Console.WriteLine(E[0]);
            //Console.WriteLine(E[1]);
            //Console.WriteLine(E[2]);
            //Console.WriteLine(E["salary"]);





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
