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
    public partial class Menubar : Form
    {
        public Menubar()
        {
            InitializeComponent();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookUI Obj = new AddBookUI();
            Obj.MdiParent = this;
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
        }

        private void Menubar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Members addMembersOBj = new Add_Members();
            addMembersOBj.MdiParent = this;
            addMembersOBj.StartPosition = FormStartPosition.CenterScreen;
            addMembersOBj.Show();
        }

        private void bookCatagoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookCatagoryUI OBJ = new BookCatagoryUI();
            OBJ.MdiParent = this;
            OBJ.StartPosition = FormStartPosition.CenterScreen;
            OBJ.Show();
        }

        private void issueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBookUI OBJ = new IssueBookUI();
            OBJ.MdiParent = this;
            OBJ.StartPosition = FormStartPosition.CenterScreen;
            OBJ.Show();
     
        }
    }
}
