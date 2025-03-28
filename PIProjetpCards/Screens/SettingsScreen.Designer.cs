namespace PIProjetpCards.Screens
{
    partial class SettingsScreen
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
            this.sideBarUser1 = new PIProjetpCards.SideBarUser();
            this.SuspendLayout();
            // 
            // sideBarUser1
            // 
            this.sideBarUser1.BackColor = System.Drawing.Color.Transparent;
            this.sideBarUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBarUser1.Location = new System.Drawing.Point(0, 0);
            this.sideBarUser1.Name = "sideBarUser1";
            this.sideBarUser1.Size = new System.Drawing.Size(893, 749);
            this.sideBarUser1.TabIndex = 0;
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(893, 749);
            this.Controls.Add(this.sideBarUser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsScreen";
            this.Text = "SettingsScreem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private SideBarUser sideBarUser1;
    }
}