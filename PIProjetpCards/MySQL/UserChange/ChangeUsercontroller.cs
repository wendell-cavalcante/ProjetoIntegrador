using System;
using System.Windows;
using MySql.Data.MySqlClient;
using PIProjetpCards.Login___Criar_Conta;
using usermanager.Models;

namespace PIProjetpCards.MySQL.UserChange
{
    public class ChangeUserController // Nome da classe em PascalCase
    {      
        private string connectionString = "server=localhost;database=flashcards;uid=root;";

        public void ChangeUserInfos(string password, string email, string nome, string newPassword)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    
                   bool result = verifyUserPassword(connection, password, email, nome);

                    if (result)
                    {

                        updateUserPassword(connection, newPassword);
                        
                    }
                    else 
                    {
                        MessageBox.Show("Insira os dados corretos para alterar sua senha");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}");
                }
            }

        }
        public static UserModel UserFromDataReader(MySqlDataReader dataReader)
        {


            return new UserModel
            {

                UserName = dataReader.GetString("nome"),
                Email = dataReader.GetString("email"),
                Password = dataReader.GetString("password"),


            };

        }

        private void updateUserPassword(MySqlConnection connection, string newPassword) {

            string query = "UPDATE user SET password = @password WHERE idUser = @idUser";
            connection.Open();

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@password", newPassword);
                command.Parameters.AddWithValue("@idUser", UserSession.userIdLogado.Value);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Usuário atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar o usuário");
                }
                connection.Close();
            }

        }

        private bool verifyUserPassword(MySqlConnection connection, string password, string email, string nome)
        {

            string query = "Select * FROM user WHERE password = @password AND email = @email AND nome = @nome ";
            connection.Open();

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@nome", nome);

                MySqlDataReader result = command.ExecuteReader();

                if (result.Read())
                {
                    connection.Close();
                    return true;
                }
                return false;
            }
        }
    }
}