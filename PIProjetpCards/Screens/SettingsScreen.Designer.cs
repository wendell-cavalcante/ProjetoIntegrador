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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sideBarUser2 = new PIProjetpCards.SideBarUser();
            this.settingsUser1 = new PIProjetpCards.SettingsUser.SettingsUser();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.sideBarUser2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.settingsUser1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 749);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // sideBarUser2
            // 
            this.sideBarUser2.BackColor = System.Drawing.Color.Transparent;
            this.sideBarUser2.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarUser2.Location = new System.Drawing.Point(3, 3);
            this.sideBarUser2.Name = "sideBarUser2";
            this.sideBarUser2.Size = new System.Drawing.Size(181, 743);
            this.sideBarUser2.TabIndex = 0;
            // 
            // settingsUser1
            // 
            this.settingsUser1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsUser1.BackColor = System.Drawing.Color.Transparent;
            this.settingsUser1.Location = new System.Drawing.Point(245, 79);
            this.settingsUser1.Name = "settingsUser1";
            this.settingsUser1.Size = new System.Drawing.Size(1067, 591);
            this.settingsUser1.TabIndex = 1;
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(69)))), ((int)(((byte)(141)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SideBarUser sideBarUser2;
        private SettingsUser.SettingsUser settingsUser1;
    }
}