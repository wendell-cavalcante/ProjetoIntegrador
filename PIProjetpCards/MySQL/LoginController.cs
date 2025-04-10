using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using usermanager.Models;
using PIProjetpCards.Login___Criar_Conta;

namespace PIProjepCards.MySQL
{
    internal class LoginController
    {
        private string connectionString = "server=localhost;database=flashcards;uid=root;";

        public string LoginUser(string name, string password, string email)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta corrigida (usando AND em vez de vírgula)
                    string query = "SELECT * FROM user WHERE email = @email AND nome = @nome AND password = @password";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@nome", name);

                        MySqlDataReader result = command.ExecuteReader();

                        if (result.Read())
                        {

                            UserModel userModel = UserModel.UserFromDataReader(result);
                            UserSession.userLogado = userModel;

                            string nomeUsuario = result["nome"].ToString();
                            MessageBox.Show($"Bem-vindo, {nomeUsuario}!");
                            return "success";
                        }
                        else
                        {
                            MessageBox.Show("Verifique se preencheu todos os dados corretamente e tente novamente."); return "error";
                        }
                    }
                }
            }
            catch (Exception ex) // Adicionei a variável ex para melhor tratamento de erro
            {
                // Log do erro (opcional)
                Console.WriteLine($"Erro: {ex.Message}");
                return $"Erro ao conectar ao banco de dados {ex.Message}";
            }
        }
    }
}