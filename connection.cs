using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace Library_Book_Store_Management_System_3
{
    class connection
    {
        public OracleConnection thisConnection = new OracleConnection("Data Source=XE;User ID=book_store_management;Password=book_store_management;");
    }
}