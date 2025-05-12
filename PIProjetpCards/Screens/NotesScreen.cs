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
        }

        private void blocodeNotas1_Load(object sender, EventArgs e)
        {

        }
    }
}