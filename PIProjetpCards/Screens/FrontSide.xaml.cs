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

namespace PIProjetpCards.Screens
{
    /// <summary>
    /// Interação lógica para FrontSide.xam
    /// </summary>
    public partial class FrontSide : UserControl
    {
        public FrontSide()
        {
            InitializeComponent();
        }
        public string Pergunta
        {
            get => txtFrontSide.Text;
            set => txtFrontSide.Text = value;
        }
        private void TextBox_StylusButtonUp(object sender, StylusButtonEventArgs e)
        {

        }

        private void txtFrontSide_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
