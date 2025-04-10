using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using usermanager.Models;

namespace PIProjetpCards.SettingsUser
{
    public partial class SettingsUser : UserControl
    {
        public SettingsUser()
        {
            InitializeComponent();
            UserModel userModel = new UserModel();
        }


        private string connectionString = "server=localhost;database=flashcards;uid=root;";

        private void btnProfileInfos_Click(object sender, EventArgs e)
        {
             MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();
            try
            {
                string query = "SELECT nome, email, password FROM user;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            string nomeUsuario = reader["nome"].ToString();
                            string emailUsuario = reader["email"].ToString();
                            string senhaUsuario = reader["password"].ToString(); 

                            string mensagem = $"Nome: {nomeUsuario}\nEmail: {emailUsuario}\nSenha: {senhaUsuario}";
                            MessageBox.Show(mensagem, "Informações do seu perfil");
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado.");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
