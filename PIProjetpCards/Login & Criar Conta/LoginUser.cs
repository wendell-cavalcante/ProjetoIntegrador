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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PIProjetpCards.Login___Criar_Conta
{
    public partial class LoginUser : UserControl
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {
            CreateAccScreen createAcc = new CreateAccScreen();
            createAcc.Show();
            this.Hide();
        }
    }
}
