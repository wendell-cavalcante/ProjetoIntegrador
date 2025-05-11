using System.Windows;
using System.Windows.Controls;

namespace PIProjetpCards.Screens
{
    public partial class FrontSide : UserControl
    {
        // 1. Definição da DependencyProperty
        public static readonly DependencyProperty CurrentCardProperty =
            DependencyProperty.Register(
                name: "CurrentCard",
                propertyType: typeof(Card),
                ownerType: typeof(FrontSide),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: null,
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault
                )
            );

        // 2. Propriedade para binding
        public Card CurrentCard
        {
            get => (Card)GetValue(CurrentCardProperty);
            set => SetValue(CurrentCardProperty, value);
        }


        public FrontSide()
        {
            InitializeComponent();

            // 3. Garante que o DataContext não seja sobrescrito
            this.DataContext = this;
        }
        public string Pergunta
        {
            get => txtFrontSide.Text; // Supondo que o TextBox se chama "txtFrontSide"
            set => txtFrontSide.Text = value;
        }
    }

    // 4. Classe Card (se não existir em outro arquivo)
    public class Card
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }

}