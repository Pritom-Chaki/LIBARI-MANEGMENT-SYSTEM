using LIBARI_MANEGMENT_SYSTEM.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBARI_MANEGMENT_SYSTEM.DAL
{
    class IssueBookDA
    {
        public bool SaveNewIssueToDB(IssueBook isssueBookOBj)
        {
            SqlConnection connection = DatabaseConnection.OpenAnSqlConnection();
            string query = "INSERT INTO Issue VALUES (" + isssueBookOBj.iID + "," + isssueBookOBj.mID + ",'" + isssueBookOBj.issueDate + "','" + isssueBookOBj.returnDate + "' ,'" + isssueBookOBj.discription + "')";
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
