using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Livros
{
    public class Login
    {
        protected string email;
        private string senha;

        public void login()
        {
            Console.WriteLine("Digite seu email");
            this.email = Console.ReadLine();
            Console.WriteLine("Digite sua senha");
            this.senha = Console.ReadLine();
        }

    }

}

