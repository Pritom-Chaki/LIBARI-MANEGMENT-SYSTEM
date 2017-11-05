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
//using LIBARY_MANEGMENT_SYSTEM.DAL.DAO;

namespace LIBARI_MANEGMENT_SYSTEM
{
    public partial class Add_Members : Form
    {
        private int mID = 0;
        public Add_Members()
        {
            InitializeComponent();
            this.PopulateGridView();
            IntitialButtonMood();
        }

        private void PopulateGridView()
        {
            DataTable dt = new DataTable();
            addMemberBL addMemberBLOBj = new addMemberBL();
            dt = addMemberBLOBj.GetExistingdMemberBL();
            memberDataGridView.DataSource = dt;
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addMember addMemberOBj = new addMember();

            addMemberOBj.mID = int.Parse( mIDTextBox.Text);
            addMemberOBj.name =nameTextBox.Text ;
            addMemberOBj.contactNo = contactNoTextBox.Text;
            addMemberOBj.email = emailTextBox.Text;
            addMemberOBj.address = addressTextBox.Text;

            addMemberBL addMemberBLOBj = new addMemberBL ();
            bool result = addMemberBLOBj.ValidateNewMemberAndSendToDA(addMemberOBj);


            if (result)
            {
                MessageBox.Show("Succesful Added!!!!");
                CleanTextBar();
                this.PopulateGridView();
                //tSSLabel1.Text = "Succesfull!!";
                // label1.Text = rowsAffected + " Rows Succesfull!!!!!!!!!!";
            }

            else
            {
                MessageBox.Show("ERROR!!","Alert!!",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            addMember addMemberOBj = new addMember();

            addMemberOBj.mID = int.Parse(mIDTextBox.Text);
            addMemberOBj.name = nameTextBox.Text;
            addMemberOBj.contactNo = contactNoTextBox.Text;
            addMemberOBj.email = emailTextBox.Text;
            addMemberOBj.address = addressTextBox.Text;

            addMemberBL addMemberBLOBj = new addMemberBL();
            bool result = addMemberBLOBj.UpdateMemberAndSendToBL(addMemberOBj);


            if (result)
            {
                MessageBox.Show("Succesfully Update!!!!");
                CleanTextBar();
                this.PopulateGridView();
            }

            else
            {
                MessageBox.Show("ERROR!!","Alert!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            addMember addMemberOBj = new addMember();

            addMemberOBj.mID = int.Parse(mIDTextBox.Text);
            addMemberOBj.name = nameTextBox.Text;
            addMemberOBj.contactNo = contactNoTextBox.Text;
            addMemberOBj.email = emailTextBox.Text;
            addMemberOBj.address = addressTextBox.Text;

            addMemberBL addMemberBLOBj = new addMemberBL();
            bool result = addMemberBLOBj.DeleteMemberFromBL(addMemberOBj);


            if (result)
            {
                MessageBox.Show("Succesfully Delete!!!!");
                CleanTextBar();
                this.PopulateGridView();
            }

            else
            {
                MessageBox.Show("ERROR!!", "Alert!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

            IntitialButtonMood();
            CleanTextBar();
        }



        private void memberDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (memberDataGridView.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = memberDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow SelectedRow = memberDataGridView.Rows[SelectedRowIndex];

               String msID = Convert.ToString(SelectedRow.Cells["MID"].Value);
                string Name = Convert.ToString(SelectedRow.Cells["Name"].Value);
                string Contact = Convert.ToString(SelectedRow.Cells["ContactNo"].Value);
                string Email = Convert.ToString(SelectedRow.Cells["Email"].Value);
                string Address = Convert.ToString(SelectedRow.Cells["Address"].Value);

                mID = int.Parse(msID);
                mIDTextBox.Text = Convert.ToString(mID);
                nameTextBox.Text = Name;
                contactNoTextBox.Text = Contact;
                emailTextBox.Text = Email;
                addressTextBox.Text = Address;

                updateButton.Enabled = true;
                deleteButton.Enabled = true;
                cancelButton.Enabled = true;
                addButton.Enabled = false;
                BackButton.Enabled = false;

            }
        }

        private void memberDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            memberDataGridView.ClearSelection();
            IntitialButtonMood();
            CleanTextBar();
        }

        public void IntitialButtonMood()
        {
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            cancelButton.Enabled = false;
            addButton.Enabled = true;
            BackButton.Enabled = true;
        }

        public void CleanTextBar()
        {
            mIDTextBox.Text = "";
            nameTextBox.Text = "";
            contactNoTextBox.Text = "";
            emailTextBox.Text = "";
            addressTextBox.Text = "";
        }

    }
}
