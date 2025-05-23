﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PIProjetpCards.Screens; // Certifique-se de que este namespace está correto
using PIProjetpCards.Login___Criar_Conta;
using PIProjetpCards.CardView; // Correção: Use o namespace correto do CardViewControl

namespace PIProjetpCards.ShowCards
{
    public partial class ShowCardsControl : UserControl
    {
        private List<Card> userCards = new List<Card>();
        private Card selectedCard = null;
        private int currentUserId;
        private string connectionString = "server=localhost;database=flashcards;uid=root;"; // TODO: Substitua pela sua string de conexão real
        private const string MensagemPadrao = "Marque a caixa para ver suas perguntas e respostas";

        public ShowCardsControl()
        {
            InitializeComponent();

            if (UserSession.userIdLogado.HasValue)
            {
                currentUserId = UserSession.userIdLogado.Value;
                LoadCategories();
            }

            // Inicialmente, exibe a mensagem padrão nos TextBoxes
            txtQuestion.Text = MensagemPadrao;
            txtAnswer.Text = MensagemPadrao;
        }

        private void LoadCategories()
        {
            categorieComboBox.Items.Clear();
            categorieComboBox.Items.Add(new Category { Id = -1, Name = "Todas" });
            categorieComboBox.SelectedIndex = 0; // Seleciona "Todas" inicialmente
        }

        private void categorieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCards();
        }

        private void LoadCards()
        {
            listBoxCards.Items.Clear();
            userCards.Clear();

            string query = "SELECT idCards, nameCard, questions, answers, idCategories FROM cards WHERE idUser = @idUser";

            if (categorieComboBox.SelectedItem is Category selectedCategory && selectedCategory.Id != -1)
            {
                query += " AND idCategories = @idCategory";
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idUser", currentUserId);
                        if (categorieComboBox.SelectedItem is Category category && category.Id != -1)
                        {
                            cmd.Parameters.AddWithValue("@idCategory", category.Id);
                        }

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Card card = new Card
                                {
                                    Id = Convert.ToInt32(reader["idCards"]),
                                    Name = reader["nameCard"].ToString(),
                                    Question = reader["questions"].ToString(),
                                    Answer = reader["answers"].ToString(),
                                    CategoryId = Convert.ToInt32(reader["idCategories"])
                                };
                                userCards.Add(card);
                                listBoxCards.Items.Add(card.Name);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar cards: {ex.Message}");
            }

            // Limpa os text boxes de detalhes quando a categoria muda e exibe a mensagem padrão
            txtQuestion.Text = MensagemPadrao;
            txtAnswer.Text = MensagemPadrao;
            selectedCard = null;
        }

        private void listBoxCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCards.SelectedItem != null)
            {
                selectedCard = userCards.FirstOrDefault(card => card.Name == listBoxCards.SelectedItem.ToString());
                // Atualiza os TextBoxes com base no estado do CheckBox
                UpdateTextBoxes();
            }
            else
            {
                selectedCard = null;
                txtQuestion.Text = MensagemPadrao;
                txtAnswer.Text = MensagemPadrao;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (selectedCard != null && UserSession.userIdLogado.HasValue)
            {
                CardViewControl displayControl = new CardViewControl();
                displayControl.SetCard(selectedCard);
                displayControl.IdUser = UserSession.userIdLogado.Value; // Define o ID do usuário logado!
                displayControl.Location = new Point(200, 69); // Define a posição do UserControl dentro do Form

                // Criar e exibir um Form para hospedar o UserControl
                CardPlayScreen displayForm = new CardPlayScreen();
                displayForm.Controls.Add(displayControl);
                displayForm.Show(); // Ou displayForm.Show()
            }
            else
            {
                MessageBox.Show("Nenhum card está selecionado, selecione um para poder continuar");
                // Adicione aqui qualquer tratamento adicional, como logar o erro ou informar o usuário
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade de edição ainda não implementada.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.ParentForm.Hide();
        }

        private void showAnswerAndQuestion_CheckedChanged(object sender, EventArgs e)
        {
            // Chama a função para atualizar os TextBoxes com base no estado do CheckBox
            UpdateTextBoxes();
        }

        private void UpdateTextBoxes()
        {
            if (showAnswerAndQuestion.Checked && selectedCard != null)
            {
                txtQuestion.Text = $"Pergunta: {selectedCard.Question}";
                txtAnswer.Text = $"Resposta: {selectedCard.Answer}";
            }
            else
            {
                txtQuestion.Text = MensagemPadrao;
                txtAnswer.Text = MensagemPadrao;
            }
        }
    }

    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int CategoryId { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}