using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Livros
{
    internal class Livros
    {
        public int id;
        public string nomeLivro;
        public string autor;
        public string genero;

        public void CadastroLivro()
        {
            Console.WriteLine("Digite o nome do livro");
            this.nomeLivro = Console.ReadLine();
            Console.WriteLine("Digite o autor");
            this.autor = Console.ReadLine();
            Console.WriteLine("Digite o gênero");
            this.genero = Console.ReadLine();
     
        }

        public void Pesquisa()
        {
            Console.WriteLine("O que você procura?");
            this.nomeLivro = Console.ReadLine();
        }

    }
}
 