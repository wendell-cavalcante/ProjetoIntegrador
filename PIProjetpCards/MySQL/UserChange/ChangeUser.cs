using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIProjetpCards.MySQL.UserChange
{
    public partial class ChangeUser: UserControl
    {
        public ChangeUser()
        {
            InitializeComponent();
        }
        private void ChangeUser_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "Email";
            txtPassword.Text = "Senha atual";
            txtUser.Text = "Nome";
            txtNewPassword.Text = "Nova senha";
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Nome")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Nome";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Senha atual")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Senha atual";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtNewPassword_Enter(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "Nova senha")
            {
                txtNewPassword.Text = "";
                txtNewPassword.ForeColor = Color.Black;
            }
        }

        private void txtNewPassword_Leave(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "")
            {
                txtNewPassword.Text = "Nova Senha";
                txtNewPassword.ForeColor = Color.Black;
            }
        }

    }
}
