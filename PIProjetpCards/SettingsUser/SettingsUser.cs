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
            CarregarInformacoesUsuarioLogado();
        }

        private void btnProfileInfos_Click(object sender, EventArgs e)
        {
            CarregarInformacoesUsuarioLogado();
        }

        private void CarregarInformacoesUsuarioLogado()
        {
            if (UserSession.userIdLogado.HasValue) // Verifica se userIdLogado tem um valor
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                try
                { // Conexão com o banco de dados
                    conn.Open();

                    // Comando SQL para selecionar o usuário logado
                    string query = "SELECT * FROM user WHERE idUser = @idUser;";

                    // Cria um comando MySQL com a query e a conexão
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Adiciona o parâmetro para evitar SQL Injection
                        cmd.Parameters.AddWithValue("@idUser", UserSession.userIdLogado.Value);

                        using (MySqlDataReader result = cmd.ExecuteReader())
                        {
                            if (result.Read())
                            {
                                // Cria um novo objeto UserModel a partir do DataReader
                                UserModel userModel = UserModel.UserFromDataReader(result);
                                UserSession.userLogado = userModel; // Atualiza a informação, se necessário

                                // Exibe as informações do usuário
                                string nomeUsuario = result["nome"].ToString();
                                string emailUsuario = result["email"].ToString();
                                MessageBox.Show($"Nome: {nomeUsuario}\nEmail: {emailUsuario}", "Informações do usuário");
                            }
                            else
                            {
                                MessageBox.Show("Usuário logado não encontrado no banco de dados.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nenhum usuário está logado.");
            }
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