using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using usermanager.Models;
using PIProjetpCards.Login___Criar_Conta; // Certifique-se de ter este using

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
                {
                    conn.Open();
                    string query = "SELECT * FROM user WHERE idUser = @idUser;";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idUser", UserSession.userIdLogado.Value);

                        using (MySqlDataReader result = cmd.ExecuteReader())
                        {
                            if (result.Read())
                            {
                                UserModel userModel = UserModel.UserFromDataReader(result);
                                UserSession.userLogado = userModel; // Atualiza a informação, se necessário

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
    }
}