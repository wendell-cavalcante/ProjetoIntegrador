using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIProjetpCards.Screens;

namespace FlashCards.screen.Help
{
    public partial class Ajuda : Form
    {
        public Ajuda()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            label2.Text = comboBox1.Items[comboBox1.SelectedIndex].ToString();



            if (index == 0)
            {
                textBox1.Text = FAQ.utilizar;
            }

            else if (index == 1)
            {

            }

            else if (index == 2)

                textBox1.Text = FAQ.trocar;
            {
             
            }
        }
    }
}