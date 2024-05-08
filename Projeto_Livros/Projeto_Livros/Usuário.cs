using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Livros
{
    internal class Usuário
    {
        protected string nome;
        protected string email;
        protected string senha;
        protected string interesse;

        public void cadastrar()
        {
            Console.WriteLine("Digite seu nome completo");
            this.nome = Console.ReadLine();
            Console.WriteLine("Digite seu email");
            this.email = Console.ReadLine();
            Console.WriteLine("Digite sua senha");
            this.senha = Console.ReadLine();
            Console.WriteLine("");
        }
    }
}
