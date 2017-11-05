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
    public partial class AddBookUI : Form
    {
        private int bID = 0;

        public AddBookUI()
        {
            InitializeComponent();
            this.PopulateGridView();
        }

        private void PopulateGridView()
        {
            DataTable dt = new DataTable();
            addBookBL studentBLOBj = new addBookBL();
            dt = studentBLOBj.GetExistingdBookBL();
            bookDataGridView.DataSource = dt;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            addBook addBookOBj = new addBook();

            addBookOBj.bID = int.Parse(bIDTextBox.Text);
            addBookOBj.titel = titelTextBox.Text;
            addBookOBj.cID = int.Parse(cIDTextBox.Text);
            addBookOBj.isbn = isbnTextBox.Text;
            addBookOBj.publisher = publisherTextBox.Text;
            addBookOBj.edition = editionTextBox.Text;
            addBookOBj.arthor = arthorTextBox.Text;
            addBookOBj.copies = int.Parse(copiesTextBox.Text);

            addBookBL bookBLOBj = new addBookBL();
            bool result = bookBLOBj.ValidateNewBookAndSendToBL(addBookOBj);

            if (result)
            {
                MessageBox.Show("Succesfuly Added!!!!");
                CleanTextBar();
                this.PopulateGridView();
                IntitialButtonMood();
                CleanTextBar();
            }

            else
            {
                MessageBox.Show("ERROR!!");
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
 
            this.Hide();

        }

        private void publisherLabel_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            addBook addBookOBj = new addBook();

            addBookOBj.bID = int.Parse(bIDTextBox.Text);
            addBookOBj.titel = titelTextBox.Text;
            addBookOBj.cID = int.Parse(cIDTextBox.Text);
            addBookOBj.isbn = isbnTextBox.Text;
            addBookOBj.publisher = publisherTextBox.Text;
            addBookOBj.edition = editionTextBox.Text;
            addBookOBj.arthor = arthorTextBox.Text;
            addBookOBj.copies = int.Parse(copiesTextBox.Text);

            addBookBL bookBLOBj = new addBookBL();
            bool result = bookBLOBj.UpdateBookAndSendToBL(addBookOBj);

            if (result)
            {
                MessageBox.Show("Succesfuly Update!!!!");
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
            addBook addBookOBj = new addBook();

            addBookOBj.bID = int.Parse(bIDTextBox.Text);
            addBookOBj.titel = titelTextBox.Text;
            addBookOBj.cID = int.Parse(cIDTextBox.Text);
            addBookOBj.isbn = isbnTextBox.Text;
            addBookOBj.publisher = publisherTextBox.Text;
            addBookOBj.edition = editionTextBox.Text;
            addBookOBj.arthor = arthorTextBox.Text;
            addBookOBj.copies = int.Parse(copiesTextBox.Text);

            addBookBL bookBLOBj = new addBookBL();
            bool result = bookBLOBj.DeleteBookAndSendToBL(addBookOBj);

            if (result)
            {
                MessageBox.Show("Succesfuly Delete!!!!");
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

        private void bookDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (bookDataGridView.SelectedCells.Count > 0)
            {
                int SelectedRowIndex = bookDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow SelectedRow = bookDataGridView.Rows[SelectedRowIndex];

                string bsID = Convert.ToString(SelectedRow.Cells["BID"].Value);
                string Titel = Convert.ToString(SelectedRow.Cells["Titel"].Value);
                string csID = Convert.ToString(SelectedRow.Cells["CID"].Value);
                string Isbn = Convert.ToString(SelectedRow.Cells["ISBN"].Value);
                string Publisher = Convert.ToString(SelectedRow.Cells["Publisher"].Value);
                string Edition = Convert.ToString(SelectedRow.Cells["Edition"].Value);
                string Arthor = Convert.ToString(SelectedRow.Cells["Arthor"].Value);
                string sCopies = Convert.ToString(SelectedRow.Cells["Copies"].Value);

                bID = int.Parse(bsID);
                bIDTextBox.Text = Convert.ToString(bID);
                titelTextBox.Text = Titel;
                int cID = int.Parse(csID);
                cIDTextBox.Text = Convert.ToString(cID);
                isbnTextBox.Text = Isbn;
                editionTextBox.Text = Edition;
                arthorTextBox.Text = Arthor;
                int Copies  = int.Parse(sCopies);
                copiesTextBox.Text = Convert.ToString(Copies);

                publisherTextBox.Text = Publisher ;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
                cancelButton.Enabled = true;
                saveButton.Enabled = false;
                backButton.Enabled = false;

            }
        }

        private void bookDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            bookDataGridView.ClearSelection();
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
            bIDTextBox.Text = "";
            titelTextBox.Text = "";
            cIDTextBox.Text = "";
            isbnTextBox.Text = "";
            publisherTextBox.Text = "";
            editionTextBox.Text = "";
            arthorTextBox.Text = "";
            copiesTextBox.Text = "";
        }

    }
}
