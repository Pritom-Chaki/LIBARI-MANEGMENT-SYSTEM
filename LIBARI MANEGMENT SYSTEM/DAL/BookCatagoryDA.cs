using LIBARI_MANEGMENT_SYSTEM.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LIBARI_MANEGMENT_SYSTEM.DAL
{
    class BookCatagoryDA
    {
        public bool SaveNewCatagoryToDB(BookCatagory bCatagoryOBj) 
        {
            SqlConnection connection = DatabaseConnection.OpenAnSqlConnection();
            string query = "INSERT INTO BookCatagory VALUES(" + bCatagoryOBj.cID + ",'" + bCatagoryOBj.catagoryName + "','" + bCatagoryOBj.catagoryDetails + "')";
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

        public bool UpdateCatagoryToDB(BookCatagory bCatagoryOBj)
        {
            SqlConnection connection = DatabaseConnection.OpenAnSqlConnection();
            string query = "UPDATE BookCatagory SET Catagory ='" + bCatagoryOBj.catagoryName + "', Details ='" + bCatagoryOBj.catagoryDetails + "' WHERE CID = " + bCatagoryOBj.cID + "";
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


        public bool DeleteCatagoryFromDB(BookCatagory bCatagoryOBj)
        {
            SqlConnection connection = DatabaseConnection.OpenAnSqlConnection();
            string query = "DELETE FROM BookCatagory WHERE CID = " + bCatagoryOBj.cID + "";
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

        public DataTable GetExistingBookCatagoryFromDB()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = DatabaseConnection.OpenAnSqlConnection();
            string query = "select * from BookCatagory";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            adapter.Dispose();
            return dt;
        }
    }
}
