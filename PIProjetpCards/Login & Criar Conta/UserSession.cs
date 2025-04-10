using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using usermanager.Models;

namespace PIProjetpCards.Login___Criar_Conta
{
    public class UserSession
    {
        public static UserModel userLogado {  get; set; } 

        public UserSession(UserModel usuario)
        {
            userLogado = usuario;
        }

        public static UserModel GetUserLogado() {

            return userLogado;
        
        }
    }
}
