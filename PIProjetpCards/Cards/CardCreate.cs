using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PIProjetpCards.Cards
{
    internal class CardCreate
    {
        private string connectionString = "server=localhost;database=flashcards;uid=root;";

        public void CreateCard(string name, string question, string answer, string nameCategorie, string subCategorie, string idUser)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Verificar se o card já existe
                    string checkCardQuery = "SELECT COUNT(*) FROM cards WHERE nameCard = @nameCard AND idUser = @idUser";
                    MySqlCommand checkCardCommand = new MySqlCommand(checkCardQuery, connection);
                    checkCardCommand.Parameters.AddWithValue("@nameCard", name);
                    checkCardCommand.Parameters.AddWithValue("@idUser", idUser);

                    int cardExists = Convert.ToInt32(checkCardCommand.ExecuteScalar());

                    if (cardExists > 0)
                    {
                        MessageBox.Show("Já existe um cartão com esse nome para este usuário.");
                        return;
                    }

                    // Verificar se a categoria e subcategoria já existem
                    string checkCategoryQuery = "SELECT COUNT(*) FROM categories WHERE nameCategorie = @catName AND nameSubCategorie = @subCatName AND idUser = @idUser";
                    MySqlCommand checkCategoryCommand = new MySqlCommand(checkCategoryQuery, connection);
                    checkCategoryCommand.Parameters.AddWithValue("@catName", nameCategorie);
                    checkCategoryCommand.Parameters.AddWithValue("@subCatName", subCategorie);
                    checkCategoryCommand.Parameters.AddWithValue("@idUser", idUser);

                    int categoryExists = Convert.ToInt32(checkCategoryCommand.ExecuteScalar());

                    if (categoryExists > 0)
                    {
                        MessageBox.Show("Essa categoria e subcategoria já existem para este usuário.");
                        return;
                    }

                    // Inserir cartão
                    string insertCardQuery = "INSERT INTO cards (nameCard, questions, answers, idUser) VALUES (@nameCard, @questions, @answers, @idUser)";
                    MySqlCommand insertCardCmd = new MySqlCommand(insertCardQuery, connection);
                    insertCardCmd.Parameters.AddWithValue("@nameCard", name);
                    insertCardCmd.Parameters.AddWithValue("@questions", question);
                    insertCardCmd.Parameters.AddWithValue("@answers", answer);
                    insertCardCmd.Parameters.AddWithValue("@idUser", idUser);
                    insertCardCmd.ExecuteNonQuery();

                    // Inserir categoria
                    string insertCategoryQuery = "INSERT INTO categories (nameCategorie, nameSubCategorie, idUser) VALUES (@catName, @subCatName, @idUser)";
                    MySqlCommand insertCategoryCmd = new MySqlCommand(insertCategoryQuery, connection);
                    insertCategoryCmd.Parameters.AddWithValue("@catName", nameCategorie);
                    insertCategoryCmd.Parameters.AddWithValue("@subCatName", subCategorie);
                    insertCategoryCmd.Parameters.AddWithValue("@idUser", idUser);
                    insertCategoryCmd.ExecuteNonQuery();

                    MessageBox.Show("Cartão salvo com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar o cartão: {ex.Message}");
                }
            }
        }
    }
}
