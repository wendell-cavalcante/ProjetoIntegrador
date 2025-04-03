namespace PIProjetpCards
{
    partial class SideBarUser
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideBarUser));
            this.sidebar = new System.Windows.Forms.Panel();
            this.pnmainmenu = new System.Windows.Forms.Panel();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.btnsettings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuContainer = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.pnmainmenu.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.pnSettings.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.White;
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.pnmainmenu);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.Controls.Add(this.pnSettings);
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(50, 1114);
            this.sidebar.TabIndex = 2;
            // 
            // pnmainmenu
            // 
            this.pnmainmenu.Controls.Add(this.btnMainMenu);
            this.pnmainmenu.Location = new System.Drawing.Point(3, 104);
            this.pnmainmenu.Name = "pnmainmenu";
            this.pnmainmenu.Size = new System.Drawing.Size(194, 48);
            this.pnmainmenu.TabIndex = 6;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMainMenu.Image")));
            this.btnMainMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainMenu.Location = new System.Drawing.Point(3, 3);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(173, 42);
            this.btnMainMenu.TabIndex = 7;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.btnLogout);
            this.pnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnLogout.Location = new System.Drawing.Point(0, 1056);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(50, 58);
            this.pnLogout.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(173, 49);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnSettings
            // 
            this.pnSettings.Controls.Add(this.btnsettings);
            this.pnSettings.Controls.Add(this.button1);
            this.pnSettings.Location = new System.Drawing.Point(3, 218);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(194, 107);
            this.pnSettings.TabIndex = 3;
            // 
            // btnsettings
            // 
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Image = ((System.Drawing.Image)(resources.GetObject("btnsettings.Image")));
            this.btnsettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsettings.Location = new System.Drawing.Point(3, 55);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(173, 49);
            this.btnsettings.TabIndex = 7;
            this.btnsettings.Text = "Configurações";
            this.btnsettings.UseVisualStyleBackColor = true;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Criar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuContainer
            // 
            this.menuContainer.Controls.Add(this.button3);
            this.menuContainer.Controls.Add(this.button5);
            this.menuContainer.Controls.Add(this.button4);
            this.menuContainer.Location = new System.Drawing.Point(3, 155);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(194, 57);
            this.menuContainer.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 49);
            this.button3.TabIndex = 8;
            this.button3.Text = "Estudos";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.menu_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 113);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 49);
            this.button5.TabIndex = 7;
            this.button5.Text = "Cards";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 49);
            this.button4.TabIndex = 7;
            this.button4.Text = "Anotações";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 48);
            this.panel1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 42);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.sidebarOpen_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 48);
            this.panel2.TabIndex = 8;
            // 
            // SideBarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.sidebar);
            this.Name = "SideBarUser";
            this.Size = new System.Drawing.Size(874, 1114);
            this.sidebar.ResumeLayout(false);
            this.pnmainmenu.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.pnSettings.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.Panel menuContainer;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnmainmenu;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
    }
}
