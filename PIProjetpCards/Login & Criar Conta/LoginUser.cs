using System;
using System.Text.RegularExpressions;
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
            lblnaoconta.Text = "Não possui uma conta?";

            // Adiciona o evento Leave para a TextBox de email
            txtEmail.Leave += TxtEmail_Leave;

            // Adiciona o evento KeyPress para impedir quebras de linha
            txtUsername.KeyPress += TxtMultiline_KeyPress;
            txtPassword.KeyPress += TxtMultiline_KeyPress;
            txtEmail.KeyPress += TxtMultiline_KeyPress;
        }

        private void TxtMultiline_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Ignora a tecla Enter pressionada
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Por favor, insira um email em um formato válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus(); // Devolve o foco para a TextBox para o usuário corrigir
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Expressão regular para validar o formato de email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string name = txtUsername.Text;

            // Verifica se os campos estão vazios
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // Valida o formato do email antes de tentar o login
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Por favor, insira um email em um formato válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            // Faz o login (agora usando a instância criada no construtor)
            string result = loginController.LoginUser(name, password, email);

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
            if (lblnaoconta.Text == "Não possui uma conta?")
            {
                lblnaoconta.Text = "Possui uma conta?";
                btnCreate.Visible = false;
                return;
            }

            lblnaoconta.Text = "Não possui uma conta?";
            btnCreate.Visible = true;
        }

        // Botão de criar conta (mantido como estava)
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;

            // Valida o formato do email antes de criar a conta
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Por favor, insira um email em um formato válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
        }
    }
}