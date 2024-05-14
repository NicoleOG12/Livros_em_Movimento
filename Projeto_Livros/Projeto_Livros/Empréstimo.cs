using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Livros
{
    public class Empréstimo
    {
        protected int id;
        protected int nomeUsuario;
        protected string nomeLivro;
        protected DateTime dataSolicitacao;
        protected bool disponibilidade;
        protected DateTime dataDevolucao;

 
        public void verificacaoDisponibilidade()
        {
            Console.WriteLine("Nome do livro:" + nomeLivro);

            bool disponibilidade = true;
            if (disponibilidade==true)
            {
                Console.WriteLine("Solicitação de empréstimo");
                Console.WriteLine("Id do Usuário:" + nomeUsuario);
                Console.WriteLine("Nome do Livro:" + nomeLivro);
            }
            else 
            {
                Console.WriteLine("Livro indisponivel");
            }
        }


        public void mostrarDados()
        {
            Console.WriteLine("Id do Usuário:" + nomeUsuario);
            Console.WriteLine("Nome do Livro:" + nomeLivro);
            Console.WriteLine("Data da Solicitação:" + dataSolicitacao);
        }



    }
}

