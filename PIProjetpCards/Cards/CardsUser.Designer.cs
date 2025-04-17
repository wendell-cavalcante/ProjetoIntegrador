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
            this.btnSaveCard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubCategorie = new System.Windows.Forms.TextBox();
            this.txtNameCard = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSaveCard
            // 
            this.btnSaveCard.BackColor = System.Drawing.Color.Indigo;
            this.btnSaveCard.FlatAppearance.BorderSize = 0;
            this.btnSaveCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCard.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCard.Location = new System.Drawing.Point(140, 867);
            this.btnSaveCard.Name = "btnSaveCard";
            this.btnSaveCard.Size = new System.Drawing.Size(744, 72);
            this.btnSaveCard.TabIndex = 3;
            this.btnSaveCard.Text = "Salvar Cartão";
            this.btnSaveCard.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(275, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Criar Novo cartão de Estudo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 678);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resposta";
            // 
            // txtAnswer
            // 
            this.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnswer.Location = new System.Drawing.Point(140, 727);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(744, 105);
            this.txtAnswer.TabIndex = 7;
            this.txtAnswer.MouseEnter += new System.EventHandler(this.txtAnswer_MouseEnter);
            this.txtAnswer.MouseLeave += new System.EventHandler(this.txtAnswer_MouseLeave);
            // 
            // txtQuestion
            // 
            this.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestion.Location = new System.Drawing.Point(140, 531);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(744, 105);
            this.txtQuestion.TabIndex = 9;
            this.txtQuestion.MouseEnter += new System.EventHandler(this.txtQuestion_MouseEnter);
            this.txtQuestion.MouseLeave += new System.EventHandler(this.txtQuestion_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categoria:";
            // 
            // txtCategorie
            // 
            this.txtCategorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategorie.Location = new System.Drawing.Point(140, 382);
            this.txtCategorie.Multiline = true;
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(350, 62);
            this.txtCategorie.TabIndex = 10;
            this.txtCategorie.MouseEnter += new System.EventHandler(this.txtCategorie_MouseEnter);
            this.txtCategorie.MouseLeave += new System.EventHandler(this.txtCategorie_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(529, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Subcategoria";
            // 
            // txtSubCategorie
            // 
            this.txtSubCategorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubCategorie.Location = new System.Drawing.Point(533, 381);
            this.txtSubCategorie.Multiline = true;
            this.txtSubCategorie.Name = "txtSubCategorie";
            this.txtSubCategorie.Size = new System.Drawing.Size(350, 62);
            this.txtSubCategorie.TabIndex = 12;
            this.txtSubCategorie.MouseEnter += new System.EventHandler(this.txtSubCategorie_MouseEnter);
            this.txtSubCategorie.MouseLeave += new System.EventHandler(this.txtSubCategorie_MouseLeave);
            // 
            // txtNameCard
            // 
            this.txtNameCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameCard.Location = new System.Drawing.Point(140, 231);
            this.txtNameCard.Multiline = true;
            this.txtNameCard.Name = "txtNameCard";
            this.txtNameCard.Size = new System.Drawing.Size(743, 62);
            this.txtNameCard.TabIndex = 13;
            this.txtNameCard.MouseEnter += new System.EventHandler(this.txtNameCard_MouseEnter);
            this.txtNameCard.MouseLeave += new System.EventHandler(this.txtNameCard_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nome do cartão:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pergunta:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(140, 642);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(744, 1);
            this.panel3.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(140, 838);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 1);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(140, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 1);
            this.panel2.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(140, 450);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 1);
            this.panel4.TabIndex = 40;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(534, 450);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(350, 1);
            this.panel5.TabIndex = 41;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Location = new System.Drawing.Point(122, 64);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(780, 908);
            this.panel6.TabIndex = 42;
            // 
            // CardsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNameCard);
            this.Controls.Add(this.txtSubCategorie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveCard);
            this.Controls.Add(this.panel6);
            this.Name = "CardsUser";
            this.Size = new System.Drawing.Size(1058, 1159);
            this.Load += new System.EventHandler(this.CardsUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubCategorie;
        private System.Windows.Forms.TextBox txtNameCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}
