using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIProjetpCards.UserInfos;
using MySql.Data.MySqlClient;
using PIProjetpCards.Login___Criar_Conta;
using usermanager.Models;

namespace PIProjetpCards.Statistics
{
    public partial class StatisticsControl : UserControl
    {
        private string connectionString = "server=localhost;database=flashcards;uid=root;";
        private StatisticsUser statisticsUser; // Instância da classe StatisticsUser

        public StatisticsControl()
        {
            InitializeComponent();
            statisticsUser = new StatisticsUser(); // Inicializa a instância
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.ParentForm.Hide();
        }

        private void StatisticsControl_Load(object sender, EventArgs e)
        {
            CarregarInformacoesUsuarioLogado();
            CarregarEstatisticasUsuario();
        }

        public void CarregarInformacoesUsuarioLogado()
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

                                    lblUserName.Text = nomeUsuario;
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

        private void CarregarEstatisticasUsuario()
        {
            if (UserSession.userIdLogado.HasValue)
            {
                int userId = UserSession.userIdLogado.Value;
                string connectionString = "server=localhost;database=flashcards;uid=root;"; // TODO: Substitua pela sua string de conexão real

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT correct, errors FROM statistics WHERE idUser = @idUser";
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@idUser", userId);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int correctCount = Convert.ToInt32(reader["correct"]);
                                    int errorCount = Convert.ToInt32(reader["errors"]);

                                    // Atualiza o texto dos labels
                                    lblCorrects.Text = $"{correctCount}";
                                    lblErrors.Text = $"{errorCount}";
                                }
                                else
                                {
                                    // Caso não encontre estatísticas para o usuário (pode ser a primeira vez)
                                    lblCorrects.Text = "0";
                                    lblErrors.Text = "0";
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar estatísticas: {ex.Message}");
                    // Ou logue o erro de uma forma mais apropriada
                    lblCorrects.Text = "Acertos: -";
                    lblErrors.Text = "Erros: -";
                }
            }
            else
            {
                // Caso o ID do usuário não esteja definido na sessão
                lblCorrects.Text = "Acertos: -";
                lblErrors.Text = "Erros: -";
            }
        }
    }
}