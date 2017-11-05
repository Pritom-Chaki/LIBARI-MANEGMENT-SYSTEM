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
    class addMemberDA
    {
        public bool SaveNewMemberToDB(addMember addMemberOBj)
        {
            SqlConnection connection = DatabaseConnection.OpenAnSqlConnection();
            string query = "INSERT INTO Member VALUES(" + addMemberOBj.mID + ",'" + addMemberOBj.name + "','" + addMemberOBj.contactNo + "','" + addMemberOBj.email + "' ,'" + addMemberOBj.address + "')";
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

        public bool UpdateMemberToDB(addMember addMemberOBj)
        {
            SqlConnection connection = DatabaseConnection.OpenAnSqlConnection();
            string query = "UPDATE Member SET Name ='" + addMemberOBj.name + "', ContactNo='" + addMemberOBj.contactNo + "', Email ='" + addMemberOBj.email + "' , Address ='" + addMemberOBj.address + "' WHERE MID =" + addMemberOBj.mID + "";
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


        public bool DeleteMemberFromDB(addMember addMemberOBj) 
        {
            SqlConnection connection = DatabaseConnection.OpenAnSqlConnection();
            string query = "DELETE WHERE MID =" + addMemberOBj.mID + "";
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




        public DataTable GetExistingMembertFromDB()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = DatabaseConnection.OpenAnSqlConnection();
            string query = "select * from Member";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            adapter.Dispose();
            return dt;
        }

    }
}

