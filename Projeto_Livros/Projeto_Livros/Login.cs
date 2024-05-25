using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Livros
{
    public class Login
    {
        public string email;
        public string senha;
      
        public void FazerLogin()
        {
            Console.WriteLine("Digite seu email");
            this.email = Console.ReadLine();
            Console.WriteLine("Digite sua senha");
            this.senha = Console.ReadLine();
        }
    }
}
