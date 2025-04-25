namespace PIProjetpCards.Screens
{
    partial class NotesScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.blocodeNotas1 = new PIProjetpCards.Bloco_de_Notas.BlocodeNotas();
            this.SuspendLayout();
            // 
            // blocodeNotas1
            // 
            this.blocodeNotas1.BackColor = System.Drawing.Color.DimGray;
            this.blocodeNotas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blocodeNotas1.Location = new System.Drawing.Point(0, 0);
            this.blocodeNotas1.Name = "blocodeNotas1";
            this.blocodeNotas1.Size = new System.Drawing.Size(757, 749);
            this.blocodeNotas1.TabIndex = 0;
            // 
            // NotesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(757, 749);
            this.Controls.Add(this.blocodeNotas1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NotesScreen";
            this.ShowIcon = false;
            this.Text = "Bloco de notas";
            this.ResumeLayout(false);

        }

        #endregion

        private Bloco_de_Notas.BlocodeNotas blocodeNotas1;
    }
}