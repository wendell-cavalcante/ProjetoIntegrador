using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;
using NotesPadUser = PIProjetpCards.NotePads.NotesPadUser;


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




   


