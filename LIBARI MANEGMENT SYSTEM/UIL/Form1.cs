using LIBARI_MANEGMENT_SYSTEM.UIL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBARI_MANEGMENT_SYSTEM
{
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
           Menubar mainwindows = new Menubar();
            mainwindows.Show();
            this.Hide();
        }
    }
}
