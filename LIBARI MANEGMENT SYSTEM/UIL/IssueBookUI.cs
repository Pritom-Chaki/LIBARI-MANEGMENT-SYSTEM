using LIBARI_MANEGMENT_SYSTEM.BLL;
using LIBARI_MANEGMENT_SYSTEM.DAL.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBARI_MANEGMENT_SYSTEM.UIL
{
    public partial class IssueBookUI : Form
    {
        public IssueBookUI()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            IssueBook issueOBj = new IssueBook();

            issueOBj.iID = int.Parse(issueIDTextBox.Text);
            issueOBj.mID = int.Parse(memberIDTextBox.Text);

            issueOBj.issueDate = DateTime.Parse(issueDateTimePicker.Text);
            issueOBj.returnDate = DateTime.Parse(returnDateTimePicker.Text);
            issueOBj.bID = int.Parse(bookIDTextBox.Text);

            issueOBj.discription = discriptionTextBox.Text;
            issueOBj.copies = int.Parse(copiesTextBox.Text);
            


            IssueBookBL issueBookBLOBj = new IssueBookBL();
            bool result = issueBookBLOBj.ValidateNewIssueAndSendToDA(issueOBj);


            if (result)
            {
                MessageBox.Show("Succesful!!!!");
                
            }

            else
            {
                MessageBox.Show("ERROR!!");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
