using LIBARI_MANEGMENT_SYSTEM.DAL;
using LIBARI_MANEGMENT_SYSTEM.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBARI_MANEGMENT_SYSTEM.BLL
{
    class addBookBL
    {
        public bool ValidateNewBookAndSendToBL(addBook addBookOBj)
        {
            if (addBookOBj.bID == 0 || addBookOBj.titel == "" || addBookOBj.cID == 0 || addBookOBj.isbn == "" || addBookOBj.publisher == "" || addBookOBj.edition == "" || addBookOBj.copies == 0  )
            {
                return false;
            }

            else
            {
                addBookDA addBookDAobj = new addBookDA();
                bool result = addBookDAobj.SaveNewBookToDB(addBookOBj);
                return result;
            }

        }


        public bool UpdateBookAndSendToBL(addBook addBookOBj)
        {
            if (addBookOBj.bID == 0 || addBookOBj.titel == "" || addBookOBj.cID == 0 || addBookOBj.isbn == "" || addBookOBj.publisher == "" || addBookOBj.edition == "" || addBookOBj.copies == 0)
            {
                return false;
            }

            else
            {
                addBookDA addBookDAobj = new addBookDA();
                bool result = addBookDAobj.UpdateBookToDB(addBookOBj);
                return result;
            }

        }

        public bool DeleteBookAndSendToBL(addBook addBookOBj)
        {
            if (addBookOBj.bID == 0 || addBookOBj.titel == "" || addBookOBj.cID == 0 || addBookOBj.isbn == "" || addBookOBj.publisher == "" || addBookOBj.edition == "" || addBookOBj.copies == 0)
            {
                return false;
            }

            else
            {
                addBookDA addBookDAobj = new addBookDA();
                bool result = addBookDAobj.DeleteBookFromDB(addBookOBj);
                return result;
            }

        }

        public DataTable GetExistingdBookBL()
        {
            DataTable dt = new DataTable();
            addBookDA studentDAOBj = new addBookDA();
            dt = studentDAOBj.GetExistingBookFromDB();
            return dt;

        }
    }
}
