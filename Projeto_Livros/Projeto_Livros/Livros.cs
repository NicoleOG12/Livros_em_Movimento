using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Livros
{
    internal class Livros
    {
        public string nome;
        public string autor;
        public string genero;

        public void CadastroLivro(int idUsuario, int idGenero)
        {
            Console.WriteLine("Digite o nome do livro");
            this.nome = Console.ReadLine();
            Console.WriteLine("Digite o autor");
            this.autor = Console.ReadLine();
            Console.WriteLine("Digite o gênero");
            this.genero = Console.ReadLine();

            DAO dao = new DAO();
            dao.Conectar(); 
            string comandoSql = $"INSERT INTO livros (idUsuario,idGenero, nome, autor, genero) VALUES ('{idUsuario}', '{idGenero}','{nome}', '{autor}', '{genero}')";
            dao.ExecutarComando(comandoSql);
            dao.Desconectar();

        }

        public void Pesquisa()
        {
            Console.WriteLine("Digite o nome do livro que você procura:");
            string livroPesquisado = Console.ReadLine();

            DAO dao = new DAO();
            dao.Conectar();
            string comandoSql = $"SELECT * FROM livros WHERE nome = '{livroPesquisado}'";
            var resultado = dao.LerDados(comandoSql); 

            while (resultado.Read())
            {
                Console.WriteLine($"Nome: {resultado["nome"]}, Autor: {resultado["autor"]}, Gênero: {resultado["genero"]}");
            }

            resultado.Close();
            dao.Desconectar();
        }
    }

   
}
 