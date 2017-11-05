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
    class addMemberBL
    {
        public bool ValidateNewMemberAndSendToDA(addMember addMemberOBj)
        {
            if (addMemberOBj.mID == 0 || addMemberOBj.name == "" || addMemberOBj.contactNo == "" || addMemberOBj.email == "" || addMemberOBj.address == "")
            {
                return false;
            }

            else
            {
                addMemberDA addMemberDAobj = new addMemberDA();
                bool result = addMemberDAobj.SaveNewMemberToDB(addMemberOBj);
                return result;
            }

        }

        public bool UpdateMemberAndSendToBL(addMember addMemberOBj)
        {
            if (addMemberOBj.mID == 0 || addMemberOBj.name == "" || addMemberOBj.contactNo == "" || addMemberOBj.email == "" || addMemberOBj.address == "")
            {
                return false;
            }

            else
            {
                addMemberDA addMemberDAobj = new addMemberDA();
                bool result = addMemberDAobj.UpdateMemberToDB(addMemberOBj);
                return result;
            }

        }

        public bool DeleteMemberFromBL(addMember addMemberOBj)
        {
            if (addMemberOBj.mID == 0 || addMemberOBj.name == "" || addMemberOBj.contactNo == "" || addMemberOBj.email == "" || addMemberOBj.address == "")
            {
                return false;
            }

            else
            {
                addMemberDA addMemberDAobj = new addMemberDA();
                bool result = addMemberDAobj.DeleteMemberFromDB(addMemberOBj); 
                return result;
            }

        }


        public DataTable GetExistingdMemberBL()
        {
            DataTable dt = new DataTable();
            addMemberDA addMemberDAOBj = new addMemberDA();
            dt = addMemberDAOBj.GetExistingMembertFromDB();
            return dt;

        }


    }
    }

