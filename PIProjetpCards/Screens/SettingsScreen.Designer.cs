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
            this.settingsUser1 = new PIProjetpCards.SettingsUser.SettingsUser();
            this.sideBarUser1 = new PIProjetpCards.SideBarUser();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsUser1
            // 
            this.settingsUser1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsUser1.BackColor = System.Drawing.Color.Transparent;
            this.settingsUser1.Location = new System.Drawing.Point(289, 93);
            this.settingsUser1.Name = "settingsUser1";
            this.settingsUser1.Size = new System.Drawing.Size(969, 563);
            this.settingsUser1.TabIndex = 1;
            // 
            // sideBarUser1
            // 
            this.sideBarUser1.BackColor = System.Drawing.Color.Transparent;
            this.sideBarUser1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarUser1.Location = new System.Drawing.Point(3, 3);
            this.sideBarUser1.Name = "sideBarUser1";
            this.sideBarUser1.Size = new System.Drawing.Size(172, 743);
            this.sideBarUser1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87F));
            this.tableLayoutPanel1.Controls.Add(this.sideBarUser1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.settingsUser1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 749F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 749);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SettingsUser.SettingsUser settingsUser1;
        private SideBarUser sideBarUser1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}