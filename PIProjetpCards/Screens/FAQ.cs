using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FlashCards
{
    class FAQ
    {

        public static string utilizar { get; set; } =
           "Passo 1: Acessar o site do Flash Cards ou baixar o aplicativo " +
        "Passo 2: Clicar em “Criar conta Depois de acessar o site ou abrir o aplicativo, você verá a opção" +
            "“Criar Conta”. Clique nessa opção para iniciar o processo de criação da sua conta.\n\n " +
        "Passo 3: Inserir as informações pessoais " +
        "Agora é hora de preencher suas informações pessoais. O Flash Cards solicitará: " +
        "Nome e sobrenome: Insira seu nome completo. " +
        "E-mail ou número de telefone: Escolha entre inserir um e-mail válido ou o número do seu celular." +
            " Esta informação será usada para verificar sua conta e para notificações. " +
        "Senha: Crie uma senha segura que você possa lembrar facilmente.Ela deve conter uma combinação de letras," +
            " números e caracteres especiais para maior segurança. " +
        "Data de nascimento: Insira sua data de nascimento.Esta informação é usada para personalizar sua experiência na plataforma " +
            "e garantir que você tenha idade suficiente para usar o Flash Cards. " +
        "Gênero: Coloque seu gênero." +
        "Passo 4: Verificar a conta via e-mail ou SMS ";

        public static string trocar { get; set; } =
            "Acesse a página de login do Flash Cards. Clique " +
            "abaixo da caixa de senha. Digite seu e-mail ou número de telefone cadastrado " +
           "Selecione o método de envio do código de confirmação (e-mail ou SMS). " +
            "Acesse seu e-mail ou telefone, localize a mensagem do Flash Cards e clique no link enviado. " +
            "Defina uma nova senha segura e confirme. ";
    }
}
