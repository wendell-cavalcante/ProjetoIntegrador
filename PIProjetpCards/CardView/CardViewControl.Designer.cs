namespace PIProjetpCards.CardView
{
    partial class CardViewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardViewControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.btnCorrect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-268, -80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(944, 898);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtResposta
            // 
            this.txtResposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResposta.Location = new System.Drawing.Point(41, 212);
            this.txtResposta.Multiline = true;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(326, 236);
            this.txtResposta.TabIndex = 1;
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackColor = System.Drawing.Color.Indigo;
            this.btnAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer.FlatAppearance.BorderSize = 0;
            this.btnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.ForeColor = System.Drawing.Color.White;
            this.btnAnswer.Location = new System.Drawing.Point(85, 471);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(242, 45);
            this.btnAnswer.TabIndex = 83;
            this.btnAnswer.Text = "Ver Resposta";
            this.btnAnswer.UseVisualStyleBackColor = false;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnError
            // 
            this.btnError.BackColor = System.Drawing.Color.Indigo;
            this.btnError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnError.FlatAppearance.BorderSize = 0;
            this.btnError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnError.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnError.ForeColor = System.Drawing.Color.White;
            this.btnError.Image = ((System.Drawing.Image)(resources.GetObject("btnError.Image")));
            this.btnError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnError.Location = new System.Drawing.Point(213, 526);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(145, 45);
            this.btnError.TabIndex = 86;
            this.btnError.Text = "Errou";
            this.btnError.UseVisualStyleBackColor = false;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnCorrect
            // 
            this.btnCorrect.BackColor = System.Drawing.Color.Indigo;
            this.btnCorrect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorrect.FlatAppearance.BorderSize = 0;
            this.btnCorrect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrect.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrect.ForeColor = System.Drawing.Color.White;
            this.btnCorrect.Image = ((System.Drawing.Image)(resources.GetObject("btnCorrect.Image")));
            this.btnCorrect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorrect.Location = new System.Drawing.Point(52, 526);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(145, 45);
            this.btnCorrect.TabIndex = 87;
            this.btnCorrect.Text = "Acertou";
            this.btnCorrect.UseVisualStyleBackColor = false;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // CardViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnCorrect);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CardViewControl";
            this.Size = new System.Drawing.Size(391, 622);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Button btnCorrect;
    }
}
