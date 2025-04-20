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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sideBarUser1 = new PIProjetpCards.SideBarUser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notesPadUser1 = new PIProjetpCards.NotePads.NotesPadUser();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sideBarUser1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 719);
            this.panel1.TabIndex = 1;
            // 
            // sideBarUser1
            // 
            this.sideBarUser1.BackColor = System.Drawing.Color.Transparent;
            this.sideBarUser1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarUser1.Location = new System.Drawing.Point(0, 0);
            this.sideBarUser1.Name = "sideBarUser1";
            this.sideBarUser1.Size = new System.Drawing.Size(197, 719);
            this.sideBarUser1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.notesPadUser1);
            this.panel2.Location = new System.Drawing.Point(206, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 790);
            this.panel2.TabIndex = 2;
            // 
            // notesPadUser1
            // 
            this.notesPadUser1.AutoSize = true;
            this.notesPadUser1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.notesPadUser1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.notesPadUser1.Location = new System.Drawing.Point(25, 43);
            this.notesPadUser1.Name = "notesPadUser1";
            this.notesPadUser1.Size = new System.Drawing.Size(486, 300);
            this.notesPadUser1.TabIndex = 0;
            // 
            // NotesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1011, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NotesScreen";
            this.ShowIcon = false;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private SideBarUser sideBarUser1;
        private System.Windows.Forms.Panel panel2;
        private NotePads.NotesPadUser notesPadUser1;
    }
}