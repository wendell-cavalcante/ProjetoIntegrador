using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PIProjetpCards.ManagerCardUser
{
    internal class CardManager
    {
        private string connectionString = "server=localhost;database=flashcards;uid=root;";
        public void SelectCard(int nameCard)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT nameCard, questions, answers FROM cards WHERE idUser = @idUser";

                }
                catch 
                {

                }
            }
        }
    }
}
