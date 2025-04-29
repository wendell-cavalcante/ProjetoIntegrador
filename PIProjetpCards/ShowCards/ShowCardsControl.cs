using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIProjetpCards.ShowCards
{
    public partial class ShowCardsControl : UserControl
    {
        public ShowCardsControl()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.ParentForm.Hide();
        }

        private void ShowCardsControl_Load(object sender, EventArgs e)
        {
            // Popula o ComboBox apenas uma vez
            string[] materias = {
        "Matemática", "Português", "História", "Geografia",
        "Ciências", "Física", "Química", "Biologia", "Inglês",
        "Artes", "Educação Física", "Filosofia", "Sociologia",
        "Redação", "Literatura" };

            categorieComboBox.Items.AddRange(materias);
            categorieComboBox.SelectedIndex = 0; // Opcional: seleciona o primeiro item
        }
    }
}
