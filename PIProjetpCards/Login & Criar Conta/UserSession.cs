using usermanager.Models;

namespace PIProjetpCards.Login___Criar_Conta
{
    public static class UserSession
    {
        public static UserModel userLogado { get; set; }
        public static int? userIdLogado { get; set; } // Para armazenar o ID do usuário
    }
}