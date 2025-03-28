namespace PIProjetpCards.Screens
{
    partial class CreateAccScreen
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
            this.createAcc1 = new PIProjetpCards.Login___Criar_Conta.CreateAcc();
            this.SuspendLayout();
            // 
            // createAcc1
            // 
            this.createAcc1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.createAcc1.Location = new System.Drawing.Point(525, 150);
            this.createAcc1.Name = "createAcc1";
            this.createAcc1.Size = new System.Drawing.Size(292, 447);
            this.createAcc1.TabIndex = 0;
            // 
            // CreateAccScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createAcc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateAccScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Login___Criar_Conta.CreateAcc createAcc1;
    }
}