using LIBARI_MANEGMENT_SYSTEM.DAL;
using LIBARI_MANEGMENT_SYSTEM.DAL.DAO;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LIBARI_MANEGMENT_SYSTEM.BLL
{
    class BookCatagoryBL
    {
        public bool ValidateNewCatagoryAndSendToBL(BookCatagory bCatagoryOBj)
        {
            if (bCatagoryOBj.cID == 0 || bCatagoryOBj.catagoryName == "" || bCatagoryOBj.catagoryDetails == "")
            {
                return false;
            }

            else
            {
                BookCatagoryDA BookCatagoryDAOBj = new BookCatagoryDA();
                bool result = BookCatagoryDAOBj.SaveNewCatagoryToDB(bCatagoryOBj);
                return result;
            }



        }


        public bool UpdateCatagoryAndSendToBL(BookCatagory bCatagoryOBj)
        {
            if (bCatagoryOBj.cID == 0 || bCatagoryOBj.catagoryName == "" || bCatagoryOBj.catagoryDetails == "")
            {
                return false;
            }

            else
            {
                BookCatagoryDA BookCatagoryDAOBj = new BookCatagoryDA();
                bool result = BookCatagoryDAOBj.UpdateCatagoryToDB(bCatagoryOBj); 
                return result;
            }



        }


        public bool DeleteCatagoryAndSendToBL(BookCatagory bCatagoryOBj)
        {
            if (bCatagoryOBj.cID == 0 || bCatagoryOBj.catagoryName == "" || bCatagoryOBj.catagoryDetails == "")
            {
                return false;
            }

            else
            {
                BookCatagoryDA BookCatagoryDAOBj = new BookCatagoryDA();
                bool result = BookCatagoryDAOBj.DeleteCatagoryFromDB(bCatagoryOBj);
                return result;
            }



        }

        public DataTable GetExistingdBookCatagoryBL()
        {
            DataTable dt = new DataTable();
            BookCatagoryDA studentDAOBj = new BookCatagoryDA();
            dt = studentDAOBj.GetExistingBookCatagoryFromDB();
            return dt;

        }
    }
}
