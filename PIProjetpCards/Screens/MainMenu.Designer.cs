﻿namespace PIProjetpCards
{
    partial class MainMenu
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.sideBarUser2 = new PIProjetpCards.SideBarUser();
            this.SuspendLayout();
            // 
            // sideBarUser2
            // 
            this.sideBarUser2.BackColor = System.Drawing.Color.Transparent;
            this.sideBarUser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBarUser2.Location = new System.Drawing.Point(0, 0);
            this.sideBarUser2.Name = "sideBarUser2";
            this.sideBarUser2.Size = new System.Drawing.Size(800, 749);
            this.sideBarUser2.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.sideBarUser2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private SideBarUser sideBarUser1;
        private SideBarUser sideBarUser2;
    }
}

