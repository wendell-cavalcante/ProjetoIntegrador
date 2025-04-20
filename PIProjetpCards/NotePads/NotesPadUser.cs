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
using System.Runtime.CompilerServices;

namespace PIProjetpCards.NotePads
{
    public partial class NotesPadUser : UserControl
    {

        bool alterado;

        public NotesPadUser()
        {
            InitializeComponent();
            this.Text = "";
        }



        private void rchTxtBxConteudo_TextChanged(object sender, EventArgs e)
        {

            alterado = true;

        }


        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (!alterado)
            {

                this.abrir();

            }

            else
            {

                if (MessageBox.Show("Você tem certeza que deseja abrir um novo arquivo? O arquivo atual não foi salvo.", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {

                    this.abrir();

                }

                else
                {
                    if (this.Text != "")
                    {
                        this.Salvar(this.Text);
                    }

                    else
                    {
                        this.salvarComo();
                    }

                }

            }


        }



        private void abrir()
        {


            if (opnFiDlgAbrir.ShowDialog() == DialogResult.OK)
            {

                //colocar nome do arquivo na barra de título
                this.Text = opnFiDlgAbrir.FileName;
                using (StreamReader sr = new StreamReader(opnFiDlgAbrir.OpenFile()))
                {
                    //ler o arquivo e colocar no richTextBox
                    rchTxtBxConteudo.Text = sr.ReadToEnd();
                    alterado = false;


                }

            }
        }


        private void Salvar(string arquivo)
        {

            if (arquivo != "")
            {

                StreamWriter buffer = new StreamWriter(arquivo);
                buffer.Write(rchTxtBxConteudo.Rtf);
                buffer.Close();
                this.Text = arquivo;

            }
            else
            {

                MessageBox.Show("Nome invalido!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void salvarComo()

        {
            if (opnFiDlgAbrir.ShowDialog() == DialogResult.OK)
            {
                this.Salvar(opnFiDlgAbrir.FileName);


            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text != "")
            {
                this.Salvar(this.Text);
            }
            else
            {
                this.salvarComo();
            }
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.salvarComo();
        }

       
    }
}


        

   





