using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PIProjetpCards.Cards
{
    internal class CardCreate
    {
        private string connectionString = "server=localhost;database=flashcards;uid=root;";

        public void CreateCard(string name, string question, string answer, string nameCategorie, string idUser)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlTransaction transaction = null;

                try
                {
                    transaction = connection.BeginTransaction();

                    // Verificar se o card já existe (mantido)
                    string checkCardQuery = "SELECT COUNT(*) FROM cards WHERE nameCard = @nameCard AND idUser = @idUser";
                    MySqlCommand checkCardCommand = new MySqlCommand(checkCardQuery, connection, transaction);
                    checkCardCommand.Parameters.AddWithValue("@nameCard", name);
                    checkCardCommand.Parameters.AddWithValue("@idUser", Convert.ToInt32(idUser));

                    int cardExists = Convert.ToInt32(checkCardCommand.ExecuteScalar());

                    if (cardExists > 0)
                    {
                        MessageBox.Show("Já existe um cartão com esse nome para este usuário.");
                        transaction.Rollback();
                        return;
                    }

                    // Removida a verificação de categoria duplicada

                    // Inserir categoria (sempre cria nova, mesmo com nome repetido)
                    string insertCategoryQuery = "INSERT INTO categories (nameCategorie, idUser) VALUES (@catName, @idUser); SELECT LAST_INSERT_ID();";
                    MySqlCommand insertCategoryCmd = new MySqlCommand(insertCategoryQuery, connection, transaction);
                    insertCategoryCmd.Parameters.AddWithValue("@catName", nameCategorie);
                    insertCategoryCmd.Parameters.AddWithValue("@idUser", Convert.ToInt32(idUser));

                    int lastIdCard = Convert.ToInt32(insertCategoryCmd.ExecuteScalar());

                    // Inserir cartão
                    string insertCardQuery = "INSERT INTO cards (nameCard, questions, answers, idUser, idCategories) VALUES (@nameCard, @questions, @answers, @idUser, @idCategories)";
                    MySqlCommand insertCardCmd = new MySqlCommand(insertCardQuery, connection, transaction);
                    insertCardCmd.Parameters.AddWithValue("@nameCard", name);
                    insertCardCmd.Parameters.AddWithValue("@questions", question);
                    insertCardCmd.Parameters.AddWithValue("@answers", answer);
                    insertCardCmd.Parameters.AddWithValue("@idUser", Convert.ToInt32(idUser));
                    insertCardCmd.Parameters.AddWithValue("@idCategories", lastIdCard);
                    insertCardCmd.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Cartão salvo com sucesso!");
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    MessageBox.Show($"Erro ao salvar o cartão: {ex.Message}");
                }
            }
        }
    }
}