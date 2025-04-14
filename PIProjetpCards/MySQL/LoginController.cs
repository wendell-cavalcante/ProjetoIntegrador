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

                    string query = "SELECT * FROM user WHERE email = @email AND nome = @nome AND password = @password";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@nome", name);

                        // **Executa o comando e obtém o resultado**
                        MySqlDataReader result = command.ExecuteReader();

                        if (result.Read())
                        {
                            // **Cria um novo objeto UserModel a partir do DataReader**
                            UserModel userModel = UserModel.UserFromDataReader(result);

                            // **Atribuição direta à propriedade estática**
                            UserSession.userLogado = userModel;

                            // **Armazenando o ID do usuário**
                            UserSession.userIdLogado = Convert.ToInt32(result["idUser"]); // Assumindo que sua coluna de ID se chama "id"

                            // **Exibe uma mensagem de boas-vindas**
                            string nomeUsuario = result["nome"].ToString();
                            MessageBox.Show($"Bem-vindo, {nomeUsuario}!");
                            return "success";
                        }
                        else
                        {
                            MessageBox.Show("Verifique se preencheu todos os dados corretamente e tente novamente.");
                            return "error";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                return $"Erro ao conectar ao banco de dados {ex.Message}";
            }
        }
    }
}