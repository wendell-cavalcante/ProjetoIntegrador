using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace usermanager.Models
{
    public class UserModel
    {
        // String de conexão com o banco de dados MySQL
        private string connectionString = "server=localhost;database=flashcards;uid=root;";

        // Método responsável por criar um novo usuário no banco de dados
        public string CreateUser(string name, string password, string email)
        {
            // Cria a conexão com o banco de dados
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Abre a conexão com o banco

                    // Comando SQL para inserir um novo usuário na tabela "user"
                    string query = "INSERT INTO user (nome, password, email) VALUES (@nome, @password, @email)";

                    // Cria um comando MySQL com a query e a conexão
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Adiciona os parâmetros para evitar SQL Injection
                        command.Parameters.AddWithValue("@nome", name);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@email", email);

                        // Executa a query e retorna o número de linhas afetadas
                        int rowsAffected = command.ExecuteNonQuery();

                        // Verifica se o usuário foi inserido corretamente
                        if (rowsAffected > 0)
                        {

                            return "Usuário criado com sucesso!"; // Retorna sucesso
                        }
                        else
                        {

                            return "Erro ao criar usuário."; // Retorna erro
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Retorna a mensagem de erro caso ocorra uma exceção no banco de dados
                    return "Esse usuário já está cadastrado em nosso sistema";
                }
            }
        }
    }
}
