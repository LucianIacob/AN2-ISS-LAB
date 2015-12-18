using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB_ISS.Model;
using LAB_ISS.Controller;

namespace LAB_ISS
{
    public partial class Form1 : Form
    {
        private LibraryController controller;
        public Form1()
        {
            InitializeComponent();
            controller = new LibraryController();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string status = controller.adminLogIn(txtUserName.Text, txtPassword.Text);
            txtPassword.Clear();
            txtUserName.Clear();
            if (status.Length != 0)
                MessageBox.Show("Username or password incorrect!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLogInCostumer_Click(object sender, EventArgs e)
        {
            string status = controller.costumerLogIn(txtCode.Text);
            txtCode.Clear();
            if (status.Length != 0)
                MessageBox.Show("Username or password incorrect!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
