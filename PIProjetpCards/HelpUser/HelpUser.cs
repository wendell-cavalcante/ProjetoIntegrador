using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIProjetpCards.Screens;

namespace PIProjetpCards.HelpÚser
{
    public partial class HelpUser : UserControl
    {
        public HelpUser()
        {
            InitializeComponent();
        }


        Dictionary<int, string> questoes = new Dictionary<int, string>()
        {
            { 0, "1 - O que são os FlashCards" },
            { 1, "2 - Como utilizar os FlashCards?" },
            { 2, "3 - Como alterar os dados?" },
            { 3, "4 - Como criar notas?" },

        };

        Dictionary<int, string> respostas = new Dictionary<int, string>()
        {
            { 0, "Flashcards são pequenos cartões com perguntas e respostas sobre um conteúdo específico com a finalidade de avaliar a sua memória." +
                    " Em outras palavras, trata-se de um card com perguntas de um lado, e respostas de outro, no qual é possível se autodesafiar. " },
            { 1, "Usar flashcards é algo muito simples. Primeiro, você deve confeccioná-los à mão ou com a ajuda de sites e aplicativos." +
                    " Lembre-se de investir em perguntas e respostas dinâmicas associadas aos conteúdos de estudo. \r\n\r\nA pergunta fica de um lado, " +
                    "a resposta do outro. Inclusive, a dica é apostar em cores e letras diferentes para uma melhor memorização dos tópicos!" },
            { 2, "Para a alteração de dados, é necessário clicar no ícone de 'ajuda' e clicar no botão 'Dados' e fazer as alterações necessárias." },
            { 3, "EM ATUALIZAÇÃO" }
        };

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opcaoSelecionada = comboBox1.SelectedIndex;

            if (respostas.ContainsKey(opcaoSelecionada))
            {
                txtTexts.Text = respostas[opcaoSelecionada];
            }
            else
            {
                txtTexts.Text = "Opção inválida.";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtTexts.Multiline = true;
            txtTexts.ReadOnly = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SettingsScreen settingsScreen = new SettingsScreen();
            settingsScreen.Show();
            this.ParentForm.Hide();
        }

        private void HelpUser_Load_1(object sender, EventArgs e)
        {
            comboBox1.DataSource = new BindingSource(questoes, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            SettingsScreen settingsScreen = new SettingsScreen();
            settingsScreen.Show();
            this.ParentForm.Hide();
        }
    }
}