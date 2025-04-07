using System;
using System.Windows.Forms;
using PIProjepCards.MySQL;
using PIProjetpCards.MySQL;
using usermanager.Controllers;

namespace PIProjetpCards.Login___Criar_Conta
{
    public partial class LoginUser : UserControl
    {
        private UserController userController;
        private LoginController loginController;

        public LoginUser()
        {
            InitializeComponent();
            userController = new UserController();
            loginController = new LoginController();

            // Configuração inicial dos controles
            btnCreate.Visible = true;
            lblnaoconta.Text = "Possui uma conta?";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string email = txtEmail.Text;

            // Verifica se os campos estão vazios
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // Faz o login (agora usando a instância criada no construtor)
            string result = loginController.LoginUser(password, email);

            if (result == "success") // Se o login foi bem-sucedido
            {
                this.ParentForm.Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show(result); // Mostra a mensagem de erro
            }
        }

        // SEU LABEL ORIGINAL (MANTIDO EXATAMENTE COMO ESTAVA)
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

        // Botão de criar conta (mantido como estava)
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;

            userController.CreateUser(name, password, email);
        }

        // Checkbox de mostrar senha (mantido como estava)
        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
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