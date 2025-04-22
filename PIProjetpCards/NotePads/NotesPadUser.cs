using System;
using System.Windows.Forms;
using System.IO;
using NotesScreen = PIProjetpCards.Screens.NotesScreen;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                    rchTxtBxConteudo.Rtf = sr.ReadToEnd();
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
                alterado = false;
                

                using (StreamWriter writer = new StreamWriter("lista.txt"))
                {
                    foreach (var item in listBox1.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }

            }
            else
            {

                MessageBox.Show("Nome invalido!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void salvarComo()

        {
            if (svFIDlgAbrir.ShowDialog() == DialogResult.OK)
            {
                this.Salvar(svFIDlgAbrir.FileName);

            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (this.Text != "")
            {
                
                this.Salvar(this.Text);
                MessageBox.Show("Arquivo salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);

          
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

        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchTxtBxConteudo.Undo();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBxConteudo.SelectedRtf != "")
            {
                Clipboard.SetDataObject(rchTxtBxConteudo.SelectedRtf);
                rchTxtBxConteudo.SelectedRtf = "";
            }

        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBxConteudo.SelectedRtf != "")
            {
                Clipboard.SetDataObject(rchTxtBxConteudo.SelectedRtf);
            }

        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))

            {
                rchTxtBxConteudo.SelectedText = Clipboard.GetData(DataFormats.Text).ToString();
            }

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBxConteudo.SelectedRtf != "")
            {
                rchTxtBxConteudo.SelectedText = "";
            }

        }

        private void buscarNaWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBxConteudo.SelectedRtf != "")
            {
                String pesquisa = rchTxtBxConteudo.SelectedRtf;
                pesquisa = pesquisa.Replace(" ", "+");
                System.Diagnostics.Process.Start("https://www.google.com/search?q=" + rchTxtBxConteudo.SelectedText);
            }
            else
            {
                MessageBox.Show("Selecione um texto para pesquisar na web!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchTxtBxConteudo.SelectAll();
        }

        private void dataEHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchTxtBxConteudo.SelectedText = System.Environment.NewLine + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void quebraDeLinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quebraDeLinhaToolStripMenuItem.CheckState == CheckState.Checked)
            {
                quebraDeLinhaToolStripMenuItem.CheckState = CheckState.Unchecked;
                rchTxtBxConteudo.WordWrap = false;
            }
            else
            {
                quebraDeLinhaToolStripMenuItem.CheckState = CheckState.Unchecked;
                rchTxtBxConteudo.WordWrap = true;
            }


        }

        private void configurarPaginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pgStpDlgConfiguraPg.ShowDialog();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prlmprimirDlg.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!alterado)
            {

                this.Text = "";
                rchTxtBxConteudo.Text = "";
                MessageBox.Show("Criado!");

            }

            else
            {

                if (MessageBox.Show("Você tem certeza que deseja um novo arquivo? O arquivo atual não foi salvo.", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    this.Text = "";
                    rchTxtBxConteudo.Text = "";

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

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotesScreen novo = new NotesScreen();
            novo.Show();
            novo.WindowState = FormWindowState.Normal;

        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fntDlgFonte.ShowDialog() == DialogResult.OK)
            {
                rchTxtBxConteudo.SelectionFont = fntDlgFonte.Font;
            }
        }

        private void salvarNaListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {

                listBox1.Items.Add(rchTxtBxConteudo.Text);
                //rchTxtBxConteudo.Clear();

            }


            using (StreamWriter writer = new StreamWriter("lista.txt"))
                {
                    foreach (var item in listBox1.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
                MessageBox.Show("Lista salva com sucesso!");
            
        }

    }
}



        

   





