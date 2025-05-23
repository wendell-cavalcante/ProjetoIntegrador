﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIProjetpCards.Screens;

namespace PIProjetpCards
{
    public partial class SideBarUser: UserControl
    {
        private bool menuOpen = false;
        private int menuMaxHeight = 167; // Altura máxima do menu
        private int menuMinHeight = 57; // Altura mínima do menu

        public SideBarUser()
        {
            InitializeComponent();
        }


        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuOpen == false)
            {
                // Abrir o menu
                menuContainer.Height += 100;
                if (menuContainer.Height >= menuMaxHeight)
                {
                    menuContainer.Height = menuMaxHeight; // Garante que a altura não ultrapasse o máximo
                    menuTransition.Stop();
                    menuOpen = true;
                }

                if (menuContainer.Height == menuMaxHeight) // Atualizqa a posição dos painéis
                {
                    
                    pnSettings.Location = new Point(3, 323);
                }
                else
                {
                    
                    pnSettings.Location = new Point(3, 218);
                }
            }
            else
            {
                // Fechar o menu
                menuContainer.Height -= 100;
                if (menuContainer.Height <= menuMinHeight)
                {
                    menuContainer.Height = menuMinHeight; // Garante que a altura não ultrapasse o mínimo
                    menuTransition.Stop();
                    menuOpen = false;
                }

                if (menuContainer.Height == menuMaxHeight) // Atualizqa a posição dos painéis
                {
                    
                    pnSettings.Location = new Point(3, 323);
                }
                else
                {
                    pnSettings.Location = new Point(3, 218);
                }
            }
        }

        private bool sidebarExpand = false; // Inicializa como false para começar fechado

        private void sidebarOpen_Click(object sender, EventArgs e)
        {
            
            sidebarExpand = !sidebarExpand; // Inverte o estado para abrir ou fechar
            sidebarTransition.Start();
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == true)
            {
                // Expandir a sidebar
                sidebar.Width += 10;
                if (sidebar.Width >= 200)
                {
                    sidebar.Width = 200; // Garante que a largura não ultrapasse o máximo
                    sidebarTransition.Stop();
                }
            }
            else
            {
                // Colapsar a sidebar
                sidebar.Width -= 10;
                if (sidebar.Width <= 50)
                {
                    sidebar.Width = 50; // Garante que a largura não ultrapasse o mínimo
                    sidebarTransition.Stop();
                }
            }

            // Atualiza a largura dos painéis dentro da sidebar
            pnSettings.Width = sidebar.Width;
            pnLogout.Width = sidebar.Width;
            pnmainmenu.Width = sidebar.Width;
            menuContainer.Width = sidebar.Width;
        }

        public void btnsettings_Click(object sender, EventArgs e)
        {
            SettingsScreen settingsScreen = new SettingsScreen();
            settingsScreen.Show();
            this.ParentForm.Hide();


        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.ParentForm.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginScreen loginScreen = new LoginScreen();
                loginScreen.Show();
                this.ParentForm.Hide();
                
            }
        }
        private void btnCards_Click(object sender, EventArgs e)
        {
            ShowCardsScreen cardsScreen = new ShowCardsScreen();
            cardsScreen.Show();
            this.ParentForm.Hide();
        }
        private void btnNotes_Click(object sender, EventArgs e)
        {
            NotesScreen notesScreen = new NotesScreen();
            notesScreen.Show();
            this.ParentForm.Hide();
        }

        private void btnCreateCard_Click(object sender, EventArgs e)
        {
            CardsScreen cardsScreen = new CardsScreen();
            cardsScreen.Show();
            this.ParentForm.Hide();
        }
    }
}
