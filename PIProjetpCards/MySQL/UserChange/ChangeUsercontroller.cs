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

        public void ChangeUserInfos(string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE user SET password = @password WHERE idUser = @idUser";
                   
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@password", password);
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
    }
}