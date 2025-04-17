using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            txtNameCard.Text = "Nome do cartão";
            txtCategorie.Text = "Nome da Categoria";
            txtSubCategorie.Text = "Nome da Subcategoria";
            txtQuestion.Text = "Escreva a sua pergunta";
            txtAnswer.Text = "Escreva a sua resposta";
        }

        private void txtNameCard_MouseEnter(object sender, EventArgs e)
        {
            if (txtNameCard.Text == "Nome do cartão")
            {
                txtNameCard.Text = "";
                txtNameCard.ForeColor = Color.Black;
            }
        }

        private void txtNameCard_MouseLeave(object sender, EventArgs e)
        {
            if (txtNameCard.Text == "")
            {
                txtNameCard.Text = "Nome do cartão";
                txtNameCard.ForeColor = Color.Black;
            }
        }

        private void txtCategorie_MouseEnter(object sender, EventArgs e)
        {
            if (txtCategorie.Text == "Nome da Categoria")
            {
                txtCategorie.Text = "";
                txtCategorie.ForeColor = Color.Black;
            }
        }

        private void txtCategorie_MouseLeave(object sender, EventArgs e)
        {
            if (txtCategorie.Text == "")
            {
                txtCategorie.Text = "Nome da Categoria";
                txtCategorie.ForeColor = Color.Black;
            }
        }

        private void txtSubCategorie_MouseEnter(object sender, EventArgs e)
        {
            if (txtSubCategorie.Text == "Nome da Subcategoria")
            {
                txtSubCategorie.Text = "";
                txtSubCategorie.ForeColor = Color.Black;
            }
        }

        private void txtSubCategorie_MouseLeave(object sender, EventArgs e)
        {
            if (txtSubCategorie.Text == "")
            {
                txtSubCategorie.Text = "Nome da Subcategoria";
                txtSubCategorie.ForeColor = Color.Black;
            }
        }

        private void txtQuestion_MouseEnter(object sender, EventArgs e)
        {
            if (txtQuestion.Text == "Escreva a sua pergunta")
            {
                txtQuestion.Text = "";
                txtQuestion.ForeColor = Color.Black;
            }
        }

        private void txtQuestion_MouseLeave(object sender, EventArgs e)
        {
            if (txtQuestion.Text == "")
            {
                txtQuestion.Text = "Escreva a sua pergunta";
                txtQuestion.ForeColor = Color.Black;
            }
        }

        private void txtAnswer_MouseEnter(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "Escreva a sua resposta")
            {
                txtAnswer.Text = "";
                txtAnswer.ForeColor = Color.Black;
            }
        }

        private void txtAnswer_MouseLeave(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "")
            {
                txtAnswer.Text = "Escreva a sua resposta";
                txtAnswer.ForeColor = Color.Black;
            }
        }

    }
}
