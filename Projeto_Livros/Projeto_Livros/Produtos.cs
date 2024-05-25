using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Livros
{
    public class Produtos
    {
        public DAO dao;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public Produtos()
        {
            dao = new DAO();
        }

        public void CadastrarProduto()
        {
            dao.Conectar();
            string comandoSql = $"INSERT INTO produtos (nome, descricao, valor) VALUES ('{Nome}', '{Descricao}', {Valor})";
            dao.ExecutarComando(comandoSql); 
            dao.Desconectar(); 
        }

        public void ListarProdutos()
        {
            dao.Conectar(); 
            string comandoSql = "SELECT * FROM produtos";
            MySqlDataReader reader = dao.LerDados(comandoSql);
            while (reader.Read())
            {              
                Console.WriteLine($"Id: {reader["id"]}, Nome: {reader["nome"]}, Descrição: {reader["descricao"]}, Valor: {reader["valor"]}");
            }

            reader.Close(); 
            dao.Desconectar(); 
        }
    }
}