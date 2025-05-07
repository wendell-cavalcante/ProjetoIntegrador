using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PIProjetpCards.Screens
{
    public partial class FlashCards : UserControl
    {
        public FlashCards()
        {
            InitializeComponent();
            Back_Side.SetParent(this);
            ShowCard(0);
            AtualizarContadores();



        }

        public class Card
        {
            public string Pergunta { get; set; }
            public string Resposta { get; set; }
        }

        private List<Card> cards = new List<Card>();
        private int currentIndex = 0;
        private int acertos = 0;
        private int erros = 0;


        // exibe o card de índice idx (ou limpa se não existir)
        private void ShowCard(int idx)
        {
            if (cards.Count > 0 && idx >= 0 && idx < cards.Count)
            {
                var card = cards[idx];
                Front_Side.Pergunta = card.Pergunta;
                Back_Side.Resposta = card.Resposta;
            }
            else
            {
                Front_Side.Pergunta = "";
                Back_Side.Resposta = "";
            }
        }

        public void AvancarParaProximoCard()
        {
            if (cards.Count == 0) return;

            currentIndex++;

            if (currentIndex >= cards.Count)
            {
                // Se chegou ao final, pergunta se quer reiniciar
                var resultado = MessageBox.Show(
                    "Você chegou ao final da revisão. Deseja reiniciar?",
                    "Fim da Revisão",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);
                if (resultado == MessageBoxResult.No)
                {
                    return;
                }
                ;

                MessageBox.Show(
                    $"Revisão finalizada!\n\n✅ Acertos: {acertos}\n❌ Erros: {erros}",
                    "Fim da Revisão",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                currentIndex = 0;
                acertos = 0;
                erros = 0;
                AtualizarContadores();
            }


            ShowCard(currentIndex);
        }


        private void ManageBtn_Click(object sender, RoutedEventArgs e)
        {
            // Zera contadores ao abrir o gerenciador
            acertos = 0;
            erros = 0;
            AtualizarContadores();



            // Reinicia do primeiro card após gerenciar
            currentIndex = 0;
            ShowCard(currentIndex);
        }

        public void TrocarConteudo(UserControl novoControle)
        {

        }

        private void Viewport3D_Initialized(object sender, EventArgs e)
        {
            MaxWidthProperty.OverrideMetadata(typeof(Viewport3D), new FrameworkPropertyMetadata(double.PositiveInfinity));
        }

        private void Window_Initialized(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Se necessário, dispare um evento para o Windows Forms tratar o fechamento
            MessageBox.Show("Este botão deveria fechar a janela, mas estamos em um UserControl.");
        }


        private void Anterior_Click(object sender, RoutedEventArgs e)
        {
            if (cards.Count == 0) return;

            currentIndex--;
            if (currentIndex < 0)
                currentIndex = cards.Count - 1; // volta para o último

            ShowCard(currentIndex);
        }

        private void Proximo_Click(object sender, RoutedEventArgs e)
        {
            if (cards.Count == 0) return;

            currentIndex++;
            if (currentIndex >= cards.Count)
                currentIndex = 0; // volta para o primeiro

            ShowCard(currentIndex);
        }
        public void AtualizarContadores()
        {
            lblAcertos.Text = $"✅ Acertos: {acertos}";
            lblErros.Text = $"❌ Erros: {erros}";
        }
        public void RegistrarAcerto()
        {
            acertos++;
            AtualizarContadores();
        }

        public void RegistrarErro()
        {
            erros++;
            AtualizarContadores();


        }
    }
}

