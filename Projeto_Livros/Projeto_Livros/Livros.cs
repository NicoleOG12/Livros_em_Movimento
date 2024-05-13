using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Livros
{
    internal class Livros
    {
        protected int id;
        protected string nomeLivro;
        protected string titulo;
        protected string autor;
        protected string genero;

        public void cadastro_livro()
        {
            Console.WriteLine("Digite o título");
            this.titulo = Console.ReadLine();
            Console.WriteLine("Digite o autor");
            this.autor = Console.ReadLine();
            Console.WriteLine("Digite o gênero");
            this.genero = Console.ReadLine();
     
        }

        public void pesquisa()
        {
            Console.WriteLine("Digite o nome do livro:");
            this.nomeLivro = Console.ReadLine();
        }

    }
}
 