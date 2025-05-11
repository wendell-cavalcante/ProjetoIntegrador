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
            // Configura placeholders
            txtNameCard.Text = "Nome do cartão";
            txtQuestion.Text = "Escreva a sua pergunta";
            txtAnswer.Text = "Escreva a sua resposta";
            
            // Carrega categorias
            LoadCategories();
        }

        private void LoadCategories()
        {
            // Lista completa de categorias
            string[] categories = {
                "Matemática",
                "Português",
                "História",
                "Geografia",
                "Ciências",
                "Física",
                "Química",
                "Biologia",
                "Inglês",
                "Artes",
                "Educação Física",
                "Filosofia",
                "Sociologia",
                "Redação",
                "Literatura"
            };

            categorieComboBox.Items.AddRange(categories);
            categorieComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categorieComboBox.SelectedIndex = 0;
        }

        // Métodos de Placeholder para os TextBoxes
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.ParentForm.Hide();
        }

        private void btnSaveCard_Click(object sender, EventArgs e)
        {
            // Validação do nome do cartão
            if (string.IsNullOrWhiteSpace(txtNameCard.Text) || 
                txtNameCard.Text == "Nome do cartão")
            {
                MessageBox.Show("Digite um nome válido para o cartão!");
                return;
            }

            // Coleta dos dados
            string nameCard = txtNameCard.Text;
            string question = txtQuestion.Text;
            string answer = txtAnswer.Text;
            string category = categorieComboBox.SelectedItem.ToString();
            string userId = UserSession.userIdLogado?.ToString();

            // Criação do cartão
            try
            {
                CardSave.cardCriado.CreateCard(nameCard, question, answer, category, userId);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            // Reseta todos os campos
            txtNameCard.Text = "Nome do cartão";
            txtQuestion.Text = "Escreva a sua pergunta";
            txtAnswer.Text = "Escreva a sua resposta";
            categorieComboBox.SelectedIndex = 0;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.ParentForm.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}