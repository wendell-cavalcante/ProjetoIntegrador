using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using PIProjetpCards.Login___Criar_Conta;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using usermanager.Models;

namespace PIProjetpCards.Statistics
{
    public class StatisticsUser
    {
        private string connectionString = "server=localhost;database=flashcards;uid=root;";

        public bool RegisterAnswer(MySqlConnection connection, int answer)
        {
            string query = "INSERT INTO statistics (answer, idUser) VALUES (@answer, @idUser)";
            connection.Open();

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@answer", answer);
                command.Parameters.AddWithValue("@idUser", UserSession.userIdLogado.Value);

                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();

                return rowsAffected > 0;
            }
        }

        public int GetAnswerCount(MySqlConnection connection, int answer)
        {
            int count = 0;
            string showAnswers = "SELECT COUNT(*) FROM statistics WHERE answer = @answer AND idUser = @idUser";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(showAnswers, connection))
                {
                    command.Parameters.AddWithValue("@answer", answer);
                    command.Parameters.AddWithValue("@idUser", UserSession.userIdLogado.Value);

                    count = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (MySqlException ex)
            {
                // Log de erro ou tratamento de exceção mais elaborado
                Console.WriteLine($"Erro ao obter contagem de respostas: {ex.Message}");
                count = -1; // Indica um erro
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return count;
        }

        public Tuple<int, int> GetUserStatistics(MySqlConnection connection)
        {
            int correctAnswers = 0;
            int incorrectAnswers = 0;

            try
            {
                connection.Open();

                // Busca a contagem de acertos (answer = 1) para o usuário logado
                string correctQuery = "SELECT COUNT(*) FROM statistics WHERE answer = 1 AND idUser = @idUser";
                using (MySqlCommand correctCommand = new MySqlCommand(correctQuery, connection))
                {
                    correctCommand.Parameters.AddWithValue("@idUser", UserSession.userIdLogado.Value);
                    correctAnswers = Convert.ToInt32(correctCommand.ExecuteScalar());
                }

                // Busca a contagem de erros (answer = 0) para o usuário logado
                string incorrectQuery = "SELECT COUNT(*) FROM statistics WHERE answer = 0 AND idUser = @idUser";
                using (MySqlCommand incorrectCommand = new MySqlCommand(incorrectQuery, connection))
                {
                    incorrectCommand.Parameters.AddWithValue("@idUser", UserSession.userIdLogado.Value);
                    incorrectAnswers = Convert.ToInt32(incorrectCommand.ExecuteScalar());
                }
            }
            catch (MySqlException ex)
            {
                // Log de erro ou tratamento de exceção mais elaborado
                Console.WriteLine($"Erro ao obter estatísticas do usuário: {ex.Message}");
                correctAnswers = -1; // Indica um erro
                incorrectAnswers = -1; // Indica um erro
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return Tuple.Create(correctAnswers, incorrectAnswers);
        }

        public int GetTotalAnswers(MySqlConnection connection)
        {
            int totalAnswers = 0;
            string totalQuery = "SELECT COUNT(*) FROM statistics WHERE idUser = @idUser";

            try
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(totalQuery, connection))
                {
                    command.Parameters.AddWithValue("@idUser", UserSession.userIdLogado.Value);
                    totalAnswers = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Erro ao obter total de respostas: {ex.Message}");
                totalAnswers = -1;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return totalAnswers;
        }
    }
}