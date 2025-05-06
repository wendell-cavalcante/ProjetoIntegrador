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
using System.Windows.Forms.Integration;

namespace PIProjetpCards.Screens
{

    public partial class BackSide : UserControl
    {
        public BackSide()
        {
            InitializeComponent();
        }

        public string Resposta
        {
            get => TxtBackSide.Text;
            set => TxtBackSide.Text = value;
        }

        // Adicione os seguintes métodos ao arquivo code-behind (BackSide.xaml.cs)

        private void AvancarCard()
        {
            if (Window.GetWindow(this) is MainWindow main)
            {
                main.AvancarParaProximoCard();

                // Voltar para o FrontSide
                main.Flip_Card.IsChecked = false;
            }
        }

        private void BtnWrong_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow main)
            {
                // 1. Voltar para frente ANTES de mudar o conteúdo
                main.Flip_Card.IsChecked = false;

                // 2. Avançar card
                main.RegistrarErro();
                main.AvancarParaProximoCard();
            }
        }

        private void BtnRight_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow main)
            {
                main.Flip_Card.IsChecked = false;

                main.RegistrarAcerto();
                main.AvancarParaProximoCard();
            }
        }




        private void TxtBackSide_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Manipule o evento de alteração de texto do TextBox aqui
        }
    }
}


