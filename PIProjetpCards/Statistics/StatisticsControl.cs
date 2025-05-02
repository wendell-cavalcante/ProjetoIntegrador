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
            CarregarEstatisticasUsuario(); // Chama a nova função para carregar as estatísticas
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
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Opção 1: Usando GetAnswerCount para acertos e erros separadamente
                        int correctCount = statisticsUser.GetAnswerCount(connection, 1);
                        int incorrectCount = statisticsUser.GetAnswerCount(connection, 0);

                        lblCorrects.Text = correctCount.ToString();
                        lblErrors.Text = incorrectCount.ToString();

                        // Opção 2: Usando GetUserStatistics para obter ambos ao mesmo tempo
                        // Tuple<int, int> stats = statisticsUser.GetUserStatistics(connection);
                        // if (stats.Item1 != -1 && stats.Item2 != -1) // Verifica se não houve erro
                        // {
                        //     lblCorrect.Text = stats.Item1.ToString();
                        //     lblErrors.Text = stats.Item2.ToString();
                        // }
                        // else
                        // {
                        //     MessageBox.Show("Erro ao carregar as estatísticas.");
                        // }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Erro ao carregar as estatísticas: {ex.Message}");
                        lblCorrects.Text = "Erro";
                        lblErrors.Text = "Erro";
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }
    }
}