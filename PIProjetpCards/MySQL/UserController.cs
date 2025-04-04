using usermanager.Models; // Importa o Model
using System.Windows.Forms; // Importa recursos do Windows Forms

namespace usermanager.Controllers
{
    public class UserController
    {
        // Instância do Model que será usada para interagir com o banco de dados
        private UserModel userModel;

        // Construtor do Controller, inicializando o Model
        public UserController()
        {
            userModel = new UserModel();
        }

        // Método responsável por criar um usuário no sistema
        public string CreateUser(string name, string password, string email)
        {
            // Verifica se algum campo está vazio antes de tentar inserir no banco
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return "Erro: Campos vazios"; // Retorna uma mensagem para evitar erro de compilação
            }

            // Chama o Model para inserir o usuário e recebe a mensagem de retorno
            string message = userModel.CreateUser(name, password, email); // Agora chamamos o Model corretamente

            // Exibe a mensagem recebida do Model (sucesso ou erro)
            MessageBox.Show(message);

            return message; // Retorna a mensagem para evitar erro CS0161
        }
    }
}
