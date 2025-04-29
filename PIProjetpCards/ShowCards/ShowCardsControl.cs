using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PIProjetpCards.Login___Criar_Conta;

namespace PIProjetpCards.ShowCards
{
    public partial class ShowCardsControl : UserControl
    {
        private readonly CardRepository _repository = new CardRepository();

        public ShowCardsControl()
        {
            InitializeComponent();
        }

        // Carrega categorias ao iniciar
        private void ShowCardsControl_Load(object sender, EventArgs e)
        {
            string[] categories = {
                "Matemática", "Português", "História", "Geografia",
                "Ciências", "Física", "Química", "Biologia", "Inglês",
                "Artes", "Educação Física", "Filosofia", "Sociologia",
                "Redação", "Literatura"
            };

            categorieComboBox.Items.AddRange(categories);
            categorieComboBox.SelectedIndex = 0; // Seleciona a primeira categoria
        }

        // Atualiza cards quando a categoria é alterada
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

                var cards = _repository.GetCardsByCategory(category, userId);
                DisplayCards(cards);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar cards: {ex.Message}");
            }
        }

        // Exibe os cards no TextBox
        private void DisplayCards(List<Card> cards)
        {
            txtCardsList.Clear();

            if (cards.Count == 0)
            {
                txtCardsList.Text = "Nenhum card encontrado nesta categoria.";
                return;
            }

            foreach (var card in cards)
            {
                txtCardsList.AppendText($"► {card.Name}{Environment.NewLine}");
                txtCardsList.AppendText($"   Pergunta: {card.Question}{Environment.NewLine}");
                txtCardsList.AppendText($"   Resposta: {card.Answer}{Environment.NewLine}{Environment.NewLine}");
            }
        }

        // Botão de voltar (mantido)
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.ParentForm.Hide();
        }
    }
}