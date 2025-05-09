using System.Collections.ObjectModel;
using System.ComponentModel;
using MySql.Data.MySqlClient;


namespace PIProjetpCards.Screens
{
    public class FlashCardsViewModel : INotifyPropertyChanged
    {
        private string connectionString = "server=localhost;database=flashcards;uid=root;";

        public ObservableCollection<Cards> Cards { get; } = new ObservableCollection<Cards>();
        public ObservableCollection<Category> Categories { get; } = new ObservableCollection<Category>();

        private Cards _selectedCard;
        public Cards SelectedCard
        {
            get => _selectedCard;
            set
            {
                _selectedCard = value;
                OnPropertyChanged(nameof(SelectedCard));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void LoadData(int userId)
        {
            LoadCategories(userId);
            LoadCards(userId);
        }

        private void LoadCategories(int userId)
        {
            Categories.Clear();
            Categories.Add(new Category { Id = -1, Name = "Todas" });

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var cmd = new MySqlCommand("SELECT idCategories, nameCategorie FROM categories WHERE idUser = @userId", connection);
                cmd.Parameters.AddWithValue("@userId", userId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Categories.Add(new Category
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
            }
        }

        private void LoadCards(int userId)
        {
            Cards.Clear();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var cmd = new MySqlCommand("SELECT idCards, nameCard, questions, answers FROM cards WHERE idUser = @userId", connection);
                cmd.Parameters.AddWithValue("@userId", userId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cards.Add(new Cards
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Question = reader.GetString(2),
                            Answer = reader.GetString(3)
                        });
                    }
                }
            }
        }
    }

    public class Cards
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}