﻿namespace PIProjetpCards.Screens
{
    partial class HelpScreen
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
            this.sideBarUser1 = new PIProjetpCards.SideBarUser();
            this.helpUser1 = new PIProjetpCards.HelpÚser.HelpUser();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.43285F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.56715F));
            this.tableLayoutPanel1.Controls.Add(this.sideBarUser1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.helpUser1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1303, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sideBarUser1
            // 
            this.sideBarUser1.BackColor = System.Drawing.Color.Transparent;
            this.sideBarUser1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarUser1.Location = new System.Drawing.Point(3, 3);
            this.sideBarUser1.Name = "sideBarUser1";
            this.sideBarUser1.Size = new System.Drawing.Size(156, 444);
            this.sideBarUser1.TabIndex = 0;
            // 
            // helpUser1
            // 
            this.helpUser1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpUser1.BackColor = System.Drawing.Color.Transparent;
            this.helpUser1.Location = new System.Drawing.Point(366, 28);
            this.helpUser1.Name = "helpUser1";
            this.helpUser1.Size = new System.Drawing.Size(732, 394);
            this.helpUser1.TabIndex = 1;
            // 
            // HelpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(69)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(1303, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HelpScreen";
            this.Text = "Duvídas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SideBarUser sideBarUser1;
        private HelpÚser.HelpUser helpUser1;
    }
}