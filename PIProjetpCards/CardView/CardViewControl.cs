using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PIProjetpCards.Screens;
using PIProjetpCards.ShowCards;

namespace PIProjetpCards.CardView
{
    public partial class CardViewControl : UserControl
    {
        private Card cardExibido;
        private bool exibindoPergunta = true;
        private string connectionString = "server=localhost;database=flashcards;uid=root;"; // TODO: Substitua pela sua string de conexão
        public int IdUser { get; set; }

        public CardViewControl()
        {
            InitializeComponent();
            txtResposta.Text = "";
            exibindoPergunta = true;
            btnCorrect.Visible = false;
            btnError.Visible = false;
            Anchor = AnchorStyles.None;

            txtResposta.KeyPress += TxtMultiline_KeyPress; 
        }

        public void SetCard(Card card)
        {
            cardExibido = card;
            ExibirPergunta();
        }

        private void ExibirPergunta()
        {
            if (cardExibido != null && txtResposta != null)
            {
                txtResposta.Text = cardExibido.Question;
                exibindoPergunta = true;
                btnCorrect.Visible = false;
                btnError.Visible = false;
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (cardExibido != null && txtResposta != null)
            {
                if (exibindoPergunta)
                {
                    txtResposta.Text = cardExibido.Answer;
                    exibindoPergunta = false;
                    btnAnswer.Text = "Ver Pergunta";
                    btnCorrect.Visible = true;
                    btnError.Visible = true;
                }
                else
                {
                    txtResposta.Text = cardExibido.Question;
                    exibindoPergunta = true;
                    btnAnswer.Text = "Ver Resposta";
                    btnCorrect.Visible = false;
                    btnError.Visible = false;
                }
            }
        }

        private void AtualizarPontuacao(bool acertou)
        {
            if (cardExibido == null || IdUser == 0)
            {
                MessageBox.Show("Erro ao atualizar pontuação: Card ou Usuário inválido.");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // 1. Verificar se o usuário existe na tabela 'user'
                    string checkUserQuery = "SELECT COUNT(*) FROM user WHERE idUser = @idUser";
                    using (MySqlCommand checkUserCmd = new MySqlCommand(checkUserQuery, connection))
                    {
                        checkUserCmd.Parameters.AddWithValue("@idUser", IdUser);
                        int userCount = Convert.ToInt32(checkUserCmd.ExecuteScalar());

                        if (userCount == 0)
                        {
                            MessageBox.Show($"Erro ao atualizar pontuação: Usuário com ID {IdUser} não encontrado.");
                            connection.Close();
                            return;
                        }
                    }

                    // 2. Verificar se o registro existe na tabela 'statistics'
                    string checkQuery = "SELECT COUNT(*) FROM statistics WHERE idUser = @idUser";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@idUser", IdUser);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            // 3. Se não existir, inserir novo registro
                            string insertQuery = "INSERT INTO statistics (idUser, correct, errors) VALUES (@idUser, 0, 0)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                            {
                                insertCmd.Parameters.AddWithValue("@idUser", IdUser);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // 4. Atualizar o registro existente
                    string query;
                    if (acertou)
                    {
                        query = "UPDATE statistics SET correct = correct + 1 WHERE idUser = @idUser";
                    }
                    else
                    {
                        query = "UPDATE statistics SET errors = errors + 1 WHERE idUser = @idUser";
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idUser", IdUser);
                        cmd.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar pontuação: {ex.Message}");
            }
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            AtualizarPontuacao(true);
            MessageBox.Show("Acertou! Parabéns!");
            // Acessa o Form pai (CardPlayScreen) e o fecha
            if (this.ParentForm != null)
            {
                this.ParentForm.Hide();
               ShowCardsScreen showCardsScreen = new ShowCardsScreen();
               showCardsScreen.Show();
            }
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            AtualizarPontuacao(false);
            MessageBox.Show("Errou! Continue praticando!");
            // Acessa o Form pai (CardPlayScreen) e o fecha
            if (this.ParentForm != null)
            {
                this.ParentForm.Hide();
                ShowCardsScreen showCardsScreen = new ShowCardsScreen();
                showCardsScreen.Show();
            }
        }
        private void TxtMultiline_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Ignora a tecla Enter pressionada
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowCardsScreen showCardsScreen = new ShowCardsScreen();
            this.ParentForm.Hide();
            showCardsScreen.Show();

        }
    }
}