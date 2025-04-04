using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIProjetpCards.Screens;
using usermanager.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PIProjetpCards.Login___Criar_Conta
{
    public partial class LoginUser : UserControl
    {
        private UserController userController;

        public LoginUser()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || (string.IsNullOrEmpty(txtPassword.Text)))  
                {
                MessageBox.Show("Por favor, preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.ParentForm.Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (lblnaoconta.Text == "Possui uma conta?")
            {
                
                lblnaoconta.Text = "Não possui uma conta?";
                btnCreate.Visible = false;
                return;
            }
            
            lblnaoconta.Text = "Possui uma conta?";
            btnCreate.Visible = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;

            userController.CreateUser(name, password, email);

                this.ParentForm.Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(showPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
