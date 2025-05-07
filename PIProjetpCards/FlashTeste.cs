using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using PIProjetpCards.Screens;

namespace PIProjetpCards
{
    public partial class FlashTeste : Form
    {
        public FlashTeste()
        {
            InitializeComponent();

            // Criar o controle WPF
            var flashCardsControl = new FlashCards();

            // Criar um host WPF no Windows Forms
            ElementHost host = new ElementHost
            {
                Dock = DockStyle.Fill,
                Child = flashCardsControl
            };

            // Adicionar o host ao formulário WinForms
            this.Controls.Add(host);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
