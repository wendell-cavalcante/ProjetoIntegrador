using System;
using System.Windows.Forms;
using PIProjetpCards.ShowCards;

namespace PIProjetpCards.Screens
{
    public partial class CardViewScreen : Form
    {
        private Card cardExibido;

        // Exemplo de nomes de controles (ajuste para os seus)
        public Label lblViewNome;
        public TextBox txtViewPergunta;
        public TextBox txtViewResposta;

        public CardViewScreen(Card card)
        {
            InitializeComponent();
            cardExibido = card;
            ExibirDetalhesDoCard();
        }

        private void ExibirDetalhesDoCard()
        {
            if (cardExibido != null)
            {
                // Adapte os nomes dos controles para os seus nomes REAIS
                // Exemplo:
                // if (lblViewNome != null) lblViewNome.Text = cardExibido.Name;
                // if (txtViewPergunta != null) txtViewPergunta.Text = cardExibido.Question;
                // if (txtViewResposta != null) txtViewResposta.Text = cardExibido.Answer;
            }
        }
    }
}