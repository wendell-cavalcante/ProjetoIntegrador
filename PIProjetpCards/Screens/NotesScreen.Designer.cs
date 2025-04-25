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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sideBarUser1 = new PIProjetpCards.SideBarUser();
            this.blocodeNotas1 = new PIProjetpCards.Bloco_de_Notas.BlocodeNotas();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.27485F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.72515F));
            this.tableLayoutPanel1.Controls.Add(this.sideBarUser1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.blocodeNotas1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 749F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 749F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 749);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sideBarUser1
            // 
            this.sideBarUser1.BackColor = System.Drawing.Color.Transparent;
            this.sideBarUser1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarUser1.Location = new System.Drawing.Point(3, 3);
            this.sideBarUser1.Name = "sideBarUser1";
            this.sideBarUser1.Size = new System.Drawing.Size(86, 743);
            this.sideBarUser1.TabIndex = 0;
            // 
            // blocodeNotas1
            // 
            this.blocodeNotas1.BackColor = System.Drawing.Color.DimGray;
            this.blocodeNotas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blocodeNotas1.Location = new System.Drawing.Point(95, 3);
            this.blocodeNotas1.Name = "blocodeNotas1";
            this.blocodeNotas1.Size = new System.Drawing.Size(659, 743);
            this.blocodeNotas1.TabIndex = 1;
            // 
            // NotesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(757, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NotesScreen";
            this.ShowIcon = false;
            this.Text = "Bloco de notas";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private SideBarUser sideBarUser1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bloco_de_Notas.BlocodeNotas blocodeNotas1;
    }
}