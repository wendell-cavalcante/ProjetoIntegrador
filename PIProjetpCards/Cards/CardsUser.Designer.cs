namespace PIProjetpCards.Cards
{
    partial class CardsUser
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardsUser));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameCard = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveCard = new System.Windows.Forms.Button();
            this.categorieComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.label6.Location = new System.Drawing.Point(19, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 29);
            this.label6.TabIndex = 55;
            this.label6.Text = "Pergunta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 29);
            this.label5.TabIndex = 54;
            this.label5.Text = "Nome do cartão:";
            // 
            // txtNameCard
            // 
            this.txtNameCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameCard.Location = new System.Drawing.Point(23, 124);
            this.txtNameCard.Multiline = true;
            this.txtNameCard.Name = "txtNameCard";
            this.txtNameCard.Size = new System.Drawing.Size(173, 21);
            this.txtNameCard.TabIndex = 53;
            this.txtNameCard.Enter += new System.EventHandler(this.txtNameCard_Enter);
            this.txtNameCard.Leave += new System.EventHandler(this.txtNameCard_Leave);
            // 
            // txtQuestion
            // 
            this.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestion.Location = new System.Drawing.Point(24, 257);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestion.Size = new System.Drawing.Size(243, 85);
            this.txtQuestion.TabIndex = 49;
            this.txtQuestion.Enter += new System.EventHandler(this.txtQuestion_Enter);
            this.txtQuestion.Leave += new System.EventHandler(this.txtQuestion_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.label3.Location = new System.Drawing.Point(298, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 48;
            this.label3.Text = "Categoria:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnswer.Location = new System.Drawing.Point(303, 257);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnswer.Size = new System.Drawing.Size(243, 85);
            this.txtAnswer.TabIndex = 47;
            this.txtAnswer.Enter += new System.EventHandler(this.txtAnswer_Enter);
            this.txtAnswer.Leave += new System.EventHandler(this.txtAnswer_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.label2.Location = new System.Drawing.Point(298, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 46;
            this.label2.Text = "Resposta:";
            // 
            // btnSaveCard
            // 
            this.btnSaveCard.BackColor = System.Drawing.Color.Indigo;
            this.btnSaveCard.FlatAppearance.BorderSize = 0;
            this.btnSaveCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCard.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCard.ForeColor = System.Drawing.Color.White;
            this.btnSaveCard.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCard.Image")));
            this.btnSaveCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveCard.Location = new System.Drawing.Point(20, 364);
            this.btnSaveCard.Name = "btnSaveCard";
            this.btnSaveCard.Size = new System.Drawing.Size(526, 52);
            this.btnSaveCard.TabIndex = 44;
            this.btnSaveCard.Text = "Salvar Cartão";
            this.btnSaveCard.UseVisualStyleBackColor = false;
            this.btnSaveCard.Click += new System.EventHandler(this.btnSaveCard_Click);
            // 
            // categorieComboBox
            // 
            this.categorieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorieComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categorieComboBox.FormattingEnabled = true;
            this.categorieComboBox.Location = new System.Drawing.Point(303, 124);
            this.categorieComboBox.Name = "categorieComboBox";
            this.categorieComboBox.Size = new System.Drawing.Size(173, 21);
            this.categorieComboBox.TabIndex = 59;
            this.categorieComboBox.TabStop = false;
            // 
            // CardsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.categorieComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNameCard);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveCard);
            this.Name = "CardsUser";
            this.Size = new System.Drawing.Size(1237, 718);
            this.Load += new System.EventHandler(this.CardsUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameCard;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveCard;
        private System.Windows.Forms.ComboBox categorieComboBox;
    }
}
