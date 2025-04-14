using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace PIProjetpCards.NotePads
{
    public partial class NotesPadUser : UserControl
    {
        private string connectionString = "server=localhost;database=flashcards;uid=root;";

        public NotesPadUser()
        {
            InitializeComponent();
        }

            private void novoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                textBox1.Clear();
            }

            private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }

            private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
                }
            }

            private void sairToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
        }
    }




