using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace PIProjetpCards.ShowCards
{
    public class CardRepository
    {
        private readonly string _connectionString = "server=localhost;database=flashcards;uid=root;";

        public List<Card> GetCardsByCategory(string category, string userId)
        {
            var cards = new List<Card>();

            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT c.nameCard, c.questions, c.answers 
                    FROM cards c
                    INNER JOIN categories cat ON c.idCategories = cat.idCategories
                    WHERE cat.nameCategorie = @category AND c.idUser = @userId";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cards.Add(new Card
                            {
                                Name = reader["nameCard"].ToString(),
                                Question = reader["questions"].ToString(),
                                Answer = reader["answers"].ToString()
                            });
                        }
                    }
                }
            }

            return cards;
        }
    }

    public class Card
    {
        public string Name { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}