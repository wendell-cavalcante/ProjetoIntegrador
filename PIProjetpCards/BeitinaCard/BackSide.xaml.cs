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
        private FlashCards _parent;
        public BackSide()
        {
            InitializeComponent();
        }

        public string Resposta
        {
            get => txtBackSide.Text;
            set => txtBackSide.Text = value;
        }

        public void SetParent(FlashCards parent)
        {
            _parent = parent;
        }

        // Adicione os seguintes métodos ao arquivo code-behind (BackSide.xaml.cs)

        //private void AvancarCard()
        //{
        //    if (Window.GetWindow(this) is MainWindow main)
        //    {
        //        main.AvancarParaProximoCard();

        //        // Voltar para o FrontSide
        //        main.Flip_Card.IsChecked = false;
        //    }
        //}

        private void BtnWrong_Click(object sender, RoutedEventArgs e)
        {
            if (_parent != null)
            {
                _parent.RegistrarErro();
                _parent.Flip_Card.IsChecked = false;
                _parent.AvancarParaProximoCard();
            }
        }

        private void BtnRight_Click(object sender, RoutedEventArgs e)
        {
            if (_parent != null)
            {
                _parent.RegistrarAcerto();
                _parent.Flip_Card.IsChecked = false;
                _parent.AvancarParaProximoCard();
            }
        }




        private void TxtBackSide_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Manipule o evento de alteração de texto do TextBox aqui
        }
    }
}


