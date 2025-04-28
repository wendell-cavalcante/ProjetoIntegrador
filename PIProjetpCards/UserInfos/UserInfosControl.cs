using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PIProjetpCards.Login___Criar_Conta;
using PIProjetpCards.Screens;
using usermanager.Models;

namespace PIProjetpCards.UserInfos
{
    public partial class UserInfosControl : UserControl
    {
        public UserInfosControl()
        {
            InitializeComponent();
        }
        private void UserInfosControl_Load(object sender, EventArgs e)
        {
            CarregarInformacoesUsuarioLogado();
        }

        private string connectionString = "server=localhost;database=flashcards;uid=root;";

        private void CarregarInformacoesUsuarioLogado()
        {
            if (UserSession.userIdLogado.HasValue) // Verifica se userIdLogado tem um valor
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                    try
                { // Conexão com o banco de dados
                    connection.Open();

                    // Comando SQL para selecionar o usuário logado
                    string query = "SELECT * FROM user WHERE idUser = @idUser;";

                    // Cria um comando MySQL com a query e a conexão
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
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

                                lblUserName.Text = nomeUsuario;
                                lblEmail.Text = emailUsuario;
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
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            UserChangeInfosScreen userChangeInfosScreen = new UserChangeInfosScreen();
            userChangeInfosScreen.Show();
            this.ParentForm.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SettingsScreen settingsScreen = new SettingsScreen();
            settingsScreen.Show();
            this.ParentForm.Hide();
        }
    }
}
