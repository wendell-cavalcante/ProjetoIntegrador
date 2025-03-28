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

namespace PIProjetpCards.Login___Criar_Conta
{
    public partial class CreateAcc : UserControl
    {
        public CreateAcc()
        {
            InitializeComponent();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || (string.IsNullOrEmpty(txtPassword.Text)))
            {
                MessageBox.Show("Por favor, preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
        }

        private void lblCreate_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            login.Show();
            this.Hide();
            
        }
    }
}
