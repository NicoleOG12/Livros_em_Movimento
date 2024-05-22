using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Livros
{
    public class Empréstimo
    {
        public int id;
        public int nomeUsuario;
        public string nomeLivro;
        public DateTime dataSolicitacao;
        public bool disponibilidade;
        public DateTime dataDevolucao;

 
        public void VerificacaoDisponibilidade()
        {
            Console.WriteLine("Nome do livro:");
            this.nomeLivro = Console.ReadLine();

            bool disponibilidade = true;
            if (disponibilidade==true)
            {
                Console.WriteLine("Solicitação de empréstimo" );
                Console.WriteLine("Id do Usuário:" + nomeUsuario);
                Console.WriteLine("Nome do Livro:" + nomeLivro);
            }
            else 
            {
                Console.WriteLine("Livro indisponivel");
            }
        }


        public void MostrarDados()
        {
            Console.WriteLine("Id do Usuário:" + nomeUsuario);
            Console.WriteLine("Nome do Livro:" + nomeLivro);
            Console.WriteLine("Data da Solicitação:" + dataSolicitacao);
        }



    }
}

