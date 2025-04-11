using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIProjetpCards.Screens;

namespace PIProjetpCards.SettingsUser
{
    public partial class SettingsUser : UserControl
    {
        public SettingsUser()
        {
            InitializeComponent();

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HelpScreen helpScreen = new HelpScreen();
            helpScreen.Show();
        }
    }
}
