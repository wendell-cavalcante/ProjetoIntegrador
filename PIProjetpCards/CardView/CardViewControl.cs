using System;
using System.Windows.Forms;
using PIProjetpCards.ShowCards;

namespace PIProjetpCards.CardView
{
    public partial class CardViewControl : UserControl
    {
        private Card cardExibido;

        public CardViewControl()
        {
            InitializeComponent();
        }

        public void SetCard(Card card)
        {
            cardExibido = card;
            ExibirPergunta();
        }

        private void ExibirPergunta()
        {
            if (cardExibido != null && lblPerguntaCard != null)
            {
                lblPerguntaCard.Text = cardExibido.Question;
            }
        }

        private void btnVerResposta_Click(object sender, EventArgs e)
        {
            if (cardExibido != null && txtResposta != null)
            {
                txtResposta.Text = cardExibido.Answer;
            }
        }
    }
}
