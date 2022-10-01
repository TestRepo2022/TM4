using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM4
{
    class Utility
    {
        public static int n = 0;

        public Utility()
        {
            n++;
        }

        public void PrintNum()
        {
            Console.WriteLine("Num is :"+n);
        }

        public void SendMessage()
        {
            Console.WriteLine("Message has been sended...");
        }
        
        public static void SendEmail()
        {
            Console.WriteLine("Email has been sended...");
        }

    }
}
