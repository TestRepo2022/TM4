using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM4
{
    class Calculation
    {

        public void Login(string email , string password)
        {
            Console.WriteLine("Login By Email and Password");
        }

        public void Login(string mobile )
        {
            Console.WriteLine("Login By Mobile");
        }

        public int Addition(int x , int y)
        {
            Console.WriteLine("----------version 1-----------");
            return x + y;
        }
       public double Addition(int x , double y)
        {
            Console.WriteLine("----------version 2-----------");
            return x + y;
        }
        public double Addition(double x , double y)
        {
            Console.WriteLine("----------version 3-----------");
            return x + y;
        } 
        
        public string Addition(string x , string y)
        {
            Console.WriteLine("----------version 4-----------");
            return x + y;
        }


    }
}
