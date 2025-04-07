using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PIProjepCards.MySQL // Nome corrigido
{
    internal class LoginController
    {
        private string connectionString = "server=localhost;database=flashcards;uid=root;";
        public string LoginUser(string password, string email)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT nome FROM user WHERE email = @email AND password = @password";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string nomeUsuario = result.ToString();
                            MessageBox.Show($"Bem-vindo, {nomeUsuario}!");
                            return "success"; // Retorna status de sucesso
                        }
                        else
                        {
                            return "Email ou senha incorretos."; // Retorna mensagem de erro
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "Erro ao conectar ao banco de dados: ";
            }
        }
    }
}