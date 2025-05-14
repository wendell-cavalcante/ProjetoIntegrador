using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIProjetpCards.Screens
{
    public partial class NotesScreen : Form
    {
        private string caminhoAtual;

        public string TextBox { get; private set; }

        private bool textoModificado;

        public object Notes { get; private set; }

        public NotesScreen()
        {
            InitializeComponent();
            this.FormClosing += applicationClose;
        }

        private void blocodeNotas1_Load(object sender, EventArgs e)
        {

        }
        private void applicationClose(object sender, FormClosingEventArgs e)
        {
            DialogResult resultadoAcao = MessageBox.Show("Deseja realmente voltar? (todo arquivo não salvo será perdido)", "Voltar para o menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultadoAcao == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
        }
    }
}