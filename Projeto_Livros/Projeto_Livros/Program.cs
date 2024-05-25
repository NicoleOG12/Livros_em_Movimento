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

            Console.WriteLine("\n-----------------------------------------------------------------------------Bem vindo ao-------------------------------------------------------------------------------\n");
            Console.WriteLine("Já possui uma conta? S/N");
            string resposta = Console.ReadLine();

            if (resposta.ToUpper() == "S")
            {
                Console.WriteLine("\nFaça seu login\n");
                Login existente = new Login();
                existente.FazerLogin();
            }
            else
            {
                Console.WriteLine("\nFaça seu cadastro\n");
                Usuário novo = new Usuário();
                novo.Cadastrar();
            }
            string opcao;
            while (true)
            {
                Console.WriteLine("Escolha uma das opções:");
                Console.WriteLine("\n 1- Cadastrar livro" +
                                  "\n 2- Ver minhas solicitações" +
                                  "\n 3- Pesquisar" +
                                  "\n 4- Notificações" +
                                  "\n 5- Meu Perfil" +
                                  "\n 6- Loja" +
                                  "\n 7- Sair");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        
                        Console.WriteLine("\nCadastro de livros\n");
                        Livros novoLivro = new Livros();
                        novoLivro.CadastroLivro();
                        Console.WriteLine("Livro cadastrado com sucesso!");
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Solicitações");
                        Solicitação minhasSolicitacoes = new Solicitação();
                        minhasSolicitacoes.MinhaSolicitacao();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Pesquisa");
                        Pesquisa novaPesquisa = new Pesquisa();
                        novaPesquisa.MinhaPesquisa();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Notificações");
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Perfil");
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("Loja");
                        break;

                    case "7":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\n Opção inválida! Tente novamente");
                        break;
                }

            }
        }
    }
}
