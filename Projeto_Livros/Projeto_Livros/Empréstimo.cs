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
        protected int idUsuario;
        protected string nomeLivro;
        protected DateTime dataSolicitacao;
        protected bool disponibilidade;
        protected DateTime dataDevolucao;

 
        public void disponibilidadeDoLivro()
        {
            Console.WriteLine("Nome do livro:" + nomeLivro);
            Console.WriteLine("Disponibilidade:" + disponibilidade);
        }

        //public void SolicitacaoDeEmprestimo()
        //{
          //  Console.WriteLine("Id do Usuário:" + idUsuario);
          //  Console.WriteLine("Nome do Livro:");
        //}


        public void mostrarDados()
        {
            Console.WriteLine("Id do Usuário:" + idUsuario);
            Console.WriteLine("Nome do Livro:" + nomeLivro);
            Console.WriteLine("Data da Solicitação:" + dataSolicitacao);
        }



    }
}

