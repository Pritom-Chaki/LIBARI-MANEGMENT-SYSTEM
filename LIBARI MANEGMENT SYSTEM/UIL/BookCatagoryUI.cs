using LIBARI_MANEGMENT_SYSTEM.BLL;
using LIBARI_MANEGMENT_SYSTEM.DAL.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBARI_MANEGMENT_SYSTEM.UIL
{
    public partial class BookCatagoryUI : Form
    {
        private int cID = 0;

        public BookCatagoryUI()
        {
            InitializeComponent();
            this.PopulateGridView();
            IntitialButtonMood();
        }

        private void PopulateGridView()
        {
            DataTable dt = new DataTable();
            BookCatagoryBL studentBLOBj = new BookCatagoryBL();
            dt = studentBLOBj.GetExistingdBookCatagoryBL();
            bookCatagoryDataGridView.DataSource = dt;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            BookCatagory bookCatagoryOBj = new BookCatagory();
            bookCatagoryOBj.cID = int.Parse( cIDTextBox.Text);
            bookCatagoryOBj.catagoryName = cNameTextBox.Text;
            bookCatagoryOBj.catagoryDetails = detailsTextBox.Text; 

            BookCatagoryBL bCatBLOBj = new BookCatagoryBL();
            bool result = bCatBLOBj.ValidateNewCatagoryAndSendToBL(bookCatagoryOBj);

            if (result)
            {
                MessageBox.Show("Succesfuly Added!!!!");

                this.PopulateGridView();
                IntitialButtonMood();
                CleanTextBar();
            }

            else
            {
                MessageBox.Show("ERROR!!");
            }

        
    }

        private void updateButton_Click(object sender, EventArgs e)
        {

            BookCatagory bookCatagoryOBj = new BookCatagory();
            bookCatagoryOBj.cID = int.Parse(cIDTextBox.Text);
            bookCatagoryOBj.catagoryName = cNameTextBox.Text;
            bookCatagoryOBj.catagoryDetails = detailsTextBox.Text;

            BookCatagoryBL bCatBLOBj = new BookCatagoryBL();
            bool result = bCatBLOBj.UpdateCatagoryAndSendToBL(bookCatagoryOBj);

            if (result)
            {
                MessageBox.Show("Succesfuly Updated!!!!");

                this.PopulateGridView();
                IntitialButtonMood();
                CleanTextBar();
            }

            else
            {
                MessageBox.Show("ERROR!!");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            BookCatagory bookCatagoryOBj = new BookCatagory();
            bookCatagoryOBj.cID = int.Parse(cIDTextBox.Text);
            bookCatagoryOBj.catagoryName = cNameTextBox.Text;
            bookCatagoryOBj.catagoryDetails = detailsTextBox.Text;

            BookCatagoryBL bCatBLOBj = new BookCatagoryBL();
            bool result = bCatBLOBj.DeleteCatagoryAndSendToBL(bookCatagoryOBj); 

            if (result)
            {
                MessageBox.Show("Succesfuly Deleted!!!!");

                this.PopulateGridView();
                IntitialButtonMood();
                CleanTextBar();
            }

            else
            {
                MessageBox.Show("ERROR!!");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            IntitialButtonMood();
            CleanTextBar();
        }

        private void bookCatagoryDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (bookCatagoryDataGridView.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = bookCatagoryDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow SelectedRow = bookCatagoryDataGridView.Rows[SelectedRowIndex];

                String csID = Convert.ToString(SelectedRow.Cells["CID"].Value);
                string Name = Convert.ToString(SelectedRow.Cells["Catagory"].Value);
                string Details = Convert.ToString(SelectedRow.Cells["Details"].Value);

                cID = int.Parse(csID);
                cIDTextBox.Text = Convert.ToString(cID);
                cNameTextBox.Text = Name;
                detailsTextBox.Text = Details;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
                cancelButton.Enabled = true;
                saveButton.Enabled = false;
                backButton.Enabled = false;
            }
        }

        private void bookCatagoryDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            bookCatagoryDataGridView.ClearSelection();
            IntitialButtonMood();
            CleanTextBar();
        }

        public void IntitialButtonMood()
        {
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            cancelButton.Enabled = false;
            saveButton.Enabled = true;
            backButton.Enabled = true;
        }

        public void CleanTextBar()
        {
            cIDTextBox.Text = "";
            cNameTextBox.Text = "";
            detailsTextBox.Text = "";
        }
    }
}
