using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBARI_MANEGMENT_SYSTEM.DAL.DAO
{
    class DatabaseConnection
    {

        public static SqlConnection OpenAnSqlConnection()
        {
            string conectionString = @"Data Source=.\SQLEXPRESS; Database= LibaryManegmentSystem ; Integrated Security = SSPI";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conectionString;
            connection.Open();
            // MessageBox.Show("DONE!!");
            return connection;
        }
    }
}
