using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Livros
{
    public class Usuário
    {
        protected int id;
        protected string nome;
        protected string email;
        private string senha;
        protected string generos_de_interesse;

        public void cadastrar()
        {
            Console.WriteLine("Digite seu nome completo:");
            this.nome = Console.ReadLine();
            Console.WriteLine("Digite seu email:");
            this.email = Console.ReadLine();
            Console.WriteLine("Digite sua senha:");
            this.senha = Console.ReadLine();
            Console.WriteLine("Gêneros de interesse:");
            this.generos_de_interesse = Console.ReadLine();
        }


        public void mostrarDados()
        {
            Console.WriteLine("Nome:" + nome);
            Console.WriteLine("Email:{0}", email);
            Console.WriteLine("Senha:" + senha);
            Console.WriteLine("Gêneros de interesse" + generos_de_interesse);
        }
    }
}


