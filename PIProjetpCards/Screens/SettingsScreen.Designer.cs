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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsScreen));
            this.sideBarUser1 = new PIProjetpCards.SideBarUser();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sideBarUser1
            // 
            this.sideBarUser1.BackColor = System.Drawing.Color.Transparent;
            this.sideBarUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBarUser1.Location = new System.Drawing.Point(0, 0);
            this.sideBarUser1.Name = "sideBarUser1";
            this.sideBarUser1.Size = new System.Drawing.Size(1854, 943);
            this.sideBarUser1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1216, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Estátisticas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1216, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Alterar senha";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(354, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1216, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cartões";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(354, 462);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(1216, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "Ajuda";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1854, 943);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sideBarUser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsScreen";
            this.Text = "SettingsScreem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private SideBarUser sideBarUser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}