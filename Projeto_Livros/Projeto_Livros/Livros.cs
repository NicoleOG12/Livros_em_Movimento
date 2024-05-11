using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Livros
{
    public class Livros
    {
        protected int id;
        protected string titulo;
        protected string autor;
        protected string genero;
        protected bool disponibilidade;

        public void cadastro_livro()
        {
            Console.WriteLine("Digite o título");
            this.titulo = Console.ReadLine();
            Console.WriteLine("Digite o autor");
            this.autor = Console.ReadLine();
            Console.WriteLine("Digite o gênero");
            this.genero = Console.ReadLine();
            Console.WriteLine("");

        }
    }
}
