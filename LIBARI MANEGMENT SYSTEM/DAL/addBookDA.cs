using LIBARI_MANEGMENT_SYSTEM.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBARI_MANEGMENT_SYSTEM.DAL
{
    class addBookDA
    {
        public bool SaveNewBookToDB(addBook addBookOBj)
        {
            SqlConnection connection = DatabaseConnection.OpenAnSqlConnection();
            string query = "INSERT INTO Book VALUES (" + addBookOBj.bID + ",'" + addBookOBj.titel + "', " + addBookOBj.cID + ",'" + addBookOBj.isbn + "', '" + addBookOBj.publisher + "', '" + addBookOBj.edition + "' , '" + addBookOBj.arthor + "' , " + addBookOBj.copies + ")";
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


        public bool UpdateBookToDB(addBook addBookOBj)
        {
            SqlConnection connection = DatabaseConnection.OpenAnSqlConnection();
            string query = "UPDATE  Book SET  Titel = '" + addBookOBj.titel + "', CID =" + addBookOBj.cID + ",ISBN='" + addBookOBj.isbn + "', Publisher ='" + addBookOBj.publisher + "', Edition = '" + addBookOBj.edition + "' , Arthor='" + addBookOBj.arthor + "' , Copies = " + addBookOBj.copies + " WHERE BID = " + addBookOBj.bID + " ";
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

        public bool DeleteBookFromDB(addBook addBookOBj)
        {
            SqlConnection connection = DatabaseConnection.OpenAnSqlConnection();
            string query = "Delete Book WHERE BID = " + addBookOBj.bID + " ";
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

        public DataTable GetExistingBookFromDB()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = DatabaseConnection.OpenAnSqlConnection();
            string query = "select * from Book";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            adapter.Dispose();
            return dt;
        }
    }
}
