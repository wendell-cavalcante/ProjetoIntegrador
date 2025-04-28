using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIProjetpCards.Screens;
using System.IO;

namespace PIProjetpCards.Bloco_de_Notas
{
    public partial class BlocodeNotas : UserControl
    {
        private string caminhoAtual;
        private bool textoModificado;

        public BlocodeNotas()
        {
            InitializeComponent();
            this.Text = "";
        }

        bool close = false;

        private void NovoBn_Click(object sender, EventArgs e)
        {
            NotesScreen notesScreen = new NotesScreen();
            notesScreen.Show();
        }

        private void AbrirBn_Click(object sender, EventArgs e)

        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoAtual = openFileDialog.FileName;
                textBox1.Text = File.ReadAllText(caminhoAtual);
                textoModificado = false;
            }
        }

        private void SalvarBn_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                caminhoAtual = saveFileDialog1.FileName;
                File.WriteAllText(caminhoAtual, textBox1.Text);
                textoModificado = false;
            }
        }

        private void SairBn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.ParentForm.Hide();
        }
    }
}