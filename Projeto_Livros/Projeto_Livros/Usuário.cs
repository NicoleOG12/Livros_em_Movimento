using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Livros
{
    public class Usuário
    {
        public string nome;
        public string email;
        public string senha;
        public string generos_de_interesse;

        public void Cadastrar()
        {
            Console.WriteLine("Digite seu nome completo:");
            this.nome = Console.ReadLine();
            Console.WriteLine("Digite seu email:");
            this.email = Console.ReadLine();
            Console.WriteLine("Digite sua senha:");
            this.senha = Console.ReadLine();
            Console.WriteLine("Gêneros de interesse:");
            this.generos_de_interesse = Console.ReadLine();

            DAO dao = new DAO();
            dao.Conectar();
            string comandoSql = $"Insert into Usuario (nome, email, senha, generosdeinteresse) values ('{nome}', '{email}', '{senha}', '{generos_de_interesse}')";
            dao.ExecutarComando(comandoSql);
            dao.Desconectar();
        }

        public void MostrarDados()
        {
            Console.WriteLine("Nome:" + nome);
            Console.WriteLine("Email:"+ email);
            Console.WriteLine("Gêneros de interesse" + generos_de_interesse);

        }
    }
}


