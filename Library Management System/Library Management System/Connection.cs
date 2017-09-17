using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library_Management_System
{
    public class Connection
    {
        SqlConnection myCon = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=LMSdatabase;Integrated Security=True");//Connection String

        public SqlConnection ActiveConnection()
        {
            if (myCon.State == ConnectionState.Closed)
            {
                myCon.Open();
            }
            return myCon;
        }

    }
}
