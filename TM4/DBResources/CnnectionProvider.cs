using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM4.DBResources
{
   public class CnnectionProvider
    {
       // Connection connection = new Connection();
        public void ReadConnection()
        {
            //some logic to read connection
            string cnn = "my db connection";
            Connection.ConnectionStr = cnn;
        }
    }
}
