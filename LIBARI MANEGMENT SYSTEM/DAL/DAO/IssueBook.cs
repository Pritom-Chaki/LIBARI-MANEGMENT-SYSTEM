using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBARI_MANEGMENT_SYSTEM.DAL.DAO
{
    class IssueBook
    {
        public int iID;
        public int mID;
        public int bID;
        public string discription;
        public int copies;

        public DateTime issueDate; 
        public DateTime returnDate;

    }
}
