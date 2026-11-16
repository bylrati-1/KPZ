using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб_3._1
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
        public string UserName = "";
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "Gleb" && tbPassword.Text == "Qwerty")
            {
                UserName = "Autorized User";
            }
            else
            {
                MessageBox.Show("Wrong login or password");
                tbLogin.Text = "";
                tbPassword.Text = "";
                DialogResult = DialogResult.None;
                tbLogin.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chbViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chbViewPassword.Checked)
               tbPassword.PasswordChar = '\0';
            else
                tbPassword.PasswordChar = '*';
        }
    }
}
