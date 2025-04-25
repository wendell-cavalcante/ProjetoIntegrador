namespace PIProjetpCards.Bloco_de_Notas
{
    partial class BlocodeNotas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NovoBn = new System.Windows.Forms.ToolStripMenuItem();
            this.AbrirBn = new System.Windows.Forms.ToolStripMenuItem();
            this.SalvarBn = new System.Windows.Forms.ToolStripMenuItem();
            this.SairBn = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NovoBn,
            this.AbrirBn,
            this.SalvarBn,
            this.SairBn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1373, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NovoBn
            // 
            this.NovoBn.Name = "NovoBn";
            this.NovoBn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NovoBn.Size = new System.Drawing.Size(53, 20);
            this.NovoBn.Text = "NOVO";
            this.NovoBn.Click += new System.EventHandler(this.NovoBn_Click);
            // 
            // AbrirBn
            // 
            this.AbrirBn.Name = "AbrirBn";
            this.AbrirBn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.AbrirBn.Size = new System.Drawing.Size(51, 20);
            this.AbrirBn.Text = "ABRIR";
            this.AbrirBn.Click += new System.EventHandler(this.AbrirBn_Click);
            // 
            // SalvarBn
            // 
            this.SalvarBn.Name = "SalvarBn";
            this.SalvarBn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SalvarBn.Size = new System.Drawing.Size(59, 20);
            this.SalvarBn.Text = "SALVAR";
            this.SalvarBn.Click += new System.EventHandler(this.SalvarBn_Click);
            // 
            // SairBn
            // 
            this.SairBn.Name = "SairBn";
            this.SairBn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.SairBn.Size = new System.Drawing.Size(43, 20);
            this.SairBn.Text = "SAIR";
            this.SairBn.Click += new System.EventHandler(this.SairBn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1373, 696);
            this.textBox1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BlocodeNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "BlocodeNotas";
            this.Size = new System.Drawing.Size(1373, 720);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NovoBn;
        private System.Windows.Forms.ToolStripMenuItem AbrirBn;
        private System.Windows.Forms.ToolStripMenuItem SalvarBn;
        private System.Windows.Forms.ToolStripMenuItem SairBn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
