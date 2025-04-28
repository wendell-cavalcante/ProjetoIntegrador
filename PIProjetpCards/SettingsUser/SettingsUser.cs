using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using usermanager.Models;
using PIProjetpCards.Login___Criar_Conta;
using PIProjetpCards.Screens; // Certifique-se de ter este using

namespace PIProjetpCards.SettingsUser
{
    public partial class SettingsUser : UserControl
    {
        private string connectionString = "server=localhost;database=flashcards;uid=root;";

        public SettingsUser()
        {
            InitializeComponent();
            // Não precisa instanciar UserModel aqui
        }

        private void SettingsUser_Load(object sender, EventArgs e)
        {
            
        }

        private void btnProfileInfos_Click(object sender, EventArgs e)
        {
            UserInfosScreen userInfosScreen = new UserInfosScreen();
            userInfosScreen.Show();
            this.ParentForm.Hide();
        }

        private void btnUserChanges_Click(object sender, EventArgs e)
        {
            UserChangeInfosScreen userChangeInfosScreen = new UserChangeInfosScreen();
            userChangeInfosScreen.Show();
            this.ParentForm.Hide();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            StatistcsScreen statistcsScreen = new StatistcsScreen();
            statistcsScreen.Show();
            this.ParentForm.Hide();
        }

        private void btnDoubt_Click(object sender, EventArgs e)
        {
            HelpScreen helpScreen = new HelpScreen();
            helpScreen.Show();
            this.ParentForm.Hide();
        }
    }
}