using LIBARI_MANEGMENT_SYSTEM.DAL;
using LIBARI_MANEGMENT_SYSTEM.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBARI_MANEGMENT_SYSTEM.BLL
{
    class IssueBookBL
    {

        public bool ValidateNewIssueAndSendToDA(IssueBook issueBookOBj)
        {
            if (issueBookOBj.iID == 0 /*|| addMemberOBj.name == "" || addMemberOBj.contactNo == "" || addMemberOBj.email == "" || addMemberOBj.address == ""*/)
            {
                return false;
            }

            else
            {
                IssueBookDA issueBookDAobj = new IssueBookDA(); 
                bool result = issueBookDAobj.SaveNewIssueToDB(issueBookOBj);

                //IssueDetailsDA issueDetailsDAobj = new IssueDetailsDA();
                //bool result = issueDetailsDAobj.SaveNewIssueDatailsToDB(isssueBookOBj);

                return result;
            }

        }
    }
}
