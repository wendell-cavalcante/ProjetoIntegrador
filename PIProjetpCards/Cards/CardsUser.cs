using System;
using System.Drawing;
using System.Windows.Forms;
using PIProjetpCards.Login___Criar_Conta;

namespace PIProjetpCards.Cards
{
    public partial class CardsUser : UserControl
    {
        public CardsUser()
        {
            InitializeComponent();
        }

        private void CardsUser_Load(object sender, EventArgs e)
        {
            // Configurações iniciais dos placeholders
            txtNameCard.Text = "Nome do cartão";
            txtCategorie.Text = "Nome da Categoria";
            txtSubCategorie.Text = "Nome da Subcategoria";
            txtQuestion.Text = "Escreva a sua pergunta";
            txtAnswer.Text = "Escreva a sua resposta";
        }

        // Eventos para o campo "Nome do cartão"
        private void txtNameCard_Enter(object sender, EventArgs e)
        {
            if (txtNameCard.Text == "Nome do cartão")
            {
                txtNameCard.Text = "";
                txtNameCard.ForeColor = Color.Black;
            }
        }

        private void txtNameCard_Leave(object sender, EventArgs e)
        {
            if (txtNameCard.Text == "")
            {
                txtNameCard.Text = "Nome do cartão";
                txtNameCard.ForeColor = Color.Black;
            }
        }

        // Eventos para o campo "Categoria"
        private void txtCategorie_Enter(object sender, EventArgs e)
        {
            if (txtCategorie.Text == "Nome da Categoria")
            {
                txtCategorie.Text = "";
                txtCategorie.ForeColor = Color.Black;
            }
        }

        private void txtCategorie_Leave(object sender, EventArgs e)
        {
            if (txtCategorie.Text == "")
            {
                txtCategorie.Text = "Nome da Categoria";
                txtCategorie.ForeColor = Color.Black;
            }
        }

        // Eventos para o campo "Subcategoria"
        private void txtSubCategorie_Enter(object sender, EventArgs e)
        {
            if (txtSubCategorie.Text == "Nome da Subcategoria")
            {
                txtSubCategorie.Text = "";
                txtSubCategorie.ForeColor = Color.Black;
            }
        }

        private void txtSubCategorie_Leave(object sender, EventArgs e)
        {
            if (txtSubCategorie.Text == "")
            {
                txtSubCategorie.Text = "Nome da Subcategoria";
                txtSubCategorie.ForeColor = Color.Black;
            }
        }

        // Eventos para o campo "Pergunta"
        private void txtQuestion_Enter(object sender, EventArgs e)
        {
            if (txtQuestion.Text == "Escreva a sua pergunta")
            {
                txtQuestion.Text = "";
                txtQuestion.ForeColor = Color.Black;
            }
        }

        private void txtQuestion_Leave(object sender, EventArgs e)
        {
            if (txtQuestion.Text == "")
            {
                txtQuestion.Text = "Escreva a sua pergunta";
                txtQuestion.ForeColor = Color.Black;
            }
        }

        // Eventos para o campo "Resposta"
        private void txtAnswer_Enter(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "Escreva a sua resposta")
            {
                txtAnswer.Text = "";
                txtAnswer.ForeColor = Color.Black;
            }
        }

        private void txtAnswer_Leave(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "")
            {
                txtAnswer.Text = "Escreva a sua resposta";
                txtAnswer.ForeColor = Color.Black;
            }
        }

        // Botão "Voltar"
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.ParentForm.Hide();
        }

        // Botão "Salvar"
        private void btnSaveCard_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNameCard.Text) || txtNameCard.Text == "Nome do cartão" ||
                string.IsNullOrWhiteSpace(txtCategorie.Text) || txtCategorie.Text == "Nome da Categoria" ||
                string.IsNullOrWhiteSpace(txtSubCategorie.Text) || txtSubCategorie.Text == "Nome da Subcategoria" ||
                string.IsNullOrWhiteSpace(txtQuestion.Text) || txtQuestion.Text == "Escreva a sua pergunta" ||
                string.IsNullOrWhiteSpace(txtAnswer.Text) || txtAnswer.Text == "Escreva a sua resposta")
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.");
                return;
            }

            string nameCard = txtNameCard.Text;
            string answer = txtAnswer.Text;
            string question = txtQuestion.Text;
            string nameCategorie = txtCategorie.Text;
            string subCategorie = txtSubCategorie.Text;

            string idUser = UserSession.userIdLogado.ToString();

            CardSave.cardCriado.CreateCard(nameCard, question, answer, nameCategorie, subCategorie, idUser);
        }
    }
}