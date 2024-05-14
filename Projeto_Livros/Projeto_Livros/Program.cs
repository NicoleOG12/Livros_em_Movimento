using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace Projeto_Livros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //teste
            Console.WriteLine("Faça seu cadastro");

            Usuário um= new Usuário();
            um.cadastrar();

            Console.WriteLine("Cadastro feito com sucesso!");

            Console.WriteLine("Cadastre seu livro");

            Livros livroum = new Livros();
            livroum.cadastroLivro();

            Console.WriteLine("Cadastro feito com sucesso!");

            Empréstimo dois= new Empréstimo();
            dois.verificacaoDisponibilidade();
        }
    }
}
