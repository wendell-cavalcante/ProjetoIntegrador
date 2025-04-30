using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PIProjetpCards.Login___Criar_Conta;
using PIProjetpCards.MySQL;
using MySql.Data.MySqlClient;

namespace PIProjetpCards.ShowCards
{
    public partial class ShowCardsControl : UserControl
    {
        private readonly CardRepository _repository = new CardRepository();
        private List<Card> _currentCards = new List<Card>();

        public ShowCardsControl()
        {
            InitializeComponent();
            ConfigureControls(); // Configuração inicial dos controles
        }

        private void ShowCardsControl_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        // Método mantido conforme solicitado
        private void ConfigureControls()
        {
            // Configuração do ListBox
            listBoxCards.DisplayMember = "Name";
            listBoxCards.ValueMember = "Question"; // Não usado, mas mantido para consistência

            // Configuração dos TextBoxes
            txtQuestion.ReadOnly = true;
            txtAnswer.ReadOnly = true;
        }

        private void LoadCategories()
        {
            string[] categories = {
                "Matemática", "Português", "História", "Geografia",
                "Ciências", "Física", "Química", "Biologia", "Inglês",
                "Artes", "Educação Física", "Filosofia", "Sociologia",
                "Redação", "Literatura"
            };

            categorieComboBox.Items.AddRange(categories);
            categorieComboBox.SelectedIndex = 0;
        }

        private void categorieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCardsForSelectedCategory();
        }

        private void LoadCardsForSelectedCategory()
        {
            try
            {
                string category = categorieComboBox.SelectedItem.ToString();
                string userId = UserSession.userIdLogado.ToString();

                _currentCards = _repository.GetCardsByCategory(category, userId);
                UpdateCardsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar cards: {ex.Message}");
            }
        }

        private void UpdateCardsList()
        {
            // Mantém as configurações do ConfigureControls
            listBoxCards.DataSource = null;
            listBoxCards.DataSource = _currentCards;
            ConfigureControls();
        }

        private void listBoxCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCards.SelectedItem != null && listBoxCards.SelectedItem is Card selectedCard)
            {
                txtQuestion.Text = selectedCard.Question;
                txtAnswer.Text = selectedCard.Answer;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.ParentForm.Hide();
        }
    }
}