using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIProjetpCards.Screens
{
    public partial class NotesScreen : Form
    {
        public NotesScreen()
        {
            InitializeComponent();
            this.FormClosing += applicationClose;
        }
        private void applicationClose(object sender, FormClosingEventArgs e)
        {
            DialogResult resultadoAcao = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultadoAcao == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }
    }
}
