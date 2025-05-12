namespace PIProjetpCards.Screens
{
    partial class CardPlayScreen
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
            this.cardViewControl1 = new PIProjetpCards.CardView.CardViewControl();
            this.SuspendLayout();
            // 
            // cardViewControl1
            // 
            this.cardViewControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardViewControl1.BackColor = System.Drawing.Color.Transparent;
            this.cardViewControl1.IdUser = 0;
            this.cardViewControl1.Location = new System.Drawing.Point(206, 24);
            this.cardViewControl1.Name = "cardViewControl1";
            this.cardViewControl1.Size = new System.Drawing.Size(379, 506);
            this.cardViewControl1.TabIndex = 0;
            // 
            // CardPlayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(69)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(800, 645);
            this.Controls.Add(this.cardViewControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CardPlayScreen";
            this.Text = "CardPlayScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CardView.CardViewControl cardViewControl1;
    }
}