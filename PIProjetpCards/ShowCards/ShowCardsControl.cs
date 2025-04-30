using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PIProjetpCards.Login___Criar_Conta;

namespace PIProjetpCards.ShowCards
{
    public partial class ShowCardsControl : UserControl
    {
        private readonly CardRepository _repository = new CardRepository();
        private List<Card> _currentCards = new List<Card>();

        public ShowCardsControl()
        {
            InitializeComponent();
        }

        // Carrega categorias e configura controles
        private void ShowCardsControl_Load(object sender, EventArgs e)
        {
            LoadCategories();
            ConfigureControls();
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

        private void ConfigureControls()
        {
            // Configura ListBox para seleção
            listBoxCards.DisplayMember = "Name";
            listBoxCards.ValueMember = "Name";
        }

        // Atualiza cards ao mudar a categoria
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
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        // Atualiza a lista de cards
        private void UpdateCardsList()
        {
            listBoxCards.DataSource = null; // Força atualização
            listBoxCards.DataSource = _currentCards;
            ConfigureControls();
        }

        // Quando um card é selecionado na lista
        private void listBoxCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCards.SelectedItem is Card selectedCard)
            {
                txtQuestion.Text = selectedCard.Question;
                txtAnswer.Text = selectedCard.Answer;
            }
        }

        // Botão de voltar
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.ParentForm.Hide();
        }
    }
}