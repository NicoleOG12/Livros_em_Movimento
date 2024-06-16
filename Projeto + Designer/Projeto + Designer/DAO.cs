﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto___Designer
{
    public class DAO
    {
        public int idUsuario;
        public int idLivro;
        public DateTime dataDeDevolucao;

        MySqlConnection conn;
        MySqlCommand cmd;
        string connection = "server=localhost; port=3306; database=Gerenciamento; uid=root; pwd='FuscaAzuL123.'";

        public MySqlConnection Conectar()
        {
            conn = new MySqlConnection(connection);
            conn.Open();
            return conn;
        }

        public void Desconectar()
        {
            conn.Close();
        }

        public void ExecutarComando(string comandoSql)
        {
            using (cmd = new MySqlCommand(comandoSql, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public MySqlDataReader LerDados(string comandoSql)
        {
            cmd = new MySqlCommand(comandoSql, conn);
            return cmd.ExecuteReader();
        }

        public DataTable GetLivros()
        {
            Conectar();
            string query = "SELECT Id, Nome FROM Livros";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable livros = new DataTable();
            adapter.Fill(livros);
            Desconectar();
            return livros;
        }

        public DataTable BuscarLivros(string filtro)
        {
            Conectar();
            string query = "SELECT Id, Nome FROM Livros WHERE Nome LIKE @Filtro";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");
            DataTable livros = new DataTable();
            adapter.Fill(livros);
            Desconectar();
            return livros;
        }

        public void SolicitarTroca(int idUsuario, int idLivro)
        {
            Conectar();
            string query = "INSERT INTO Troca (idUsuario, idLivro, dataDeSolicitacao) " +
                           "VALUES (@idUsuario, @idLivro, @dataDeSolicitacao)";
            using (cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@idLivro", idLivro);
                cmd.Parameters.AddWithValue("@dataDeSolicitacao", DateTime.Now);
                cmd.ExecuteNonQuery();
            }
            Desconectar();
        }

        public void SolicitarEmprestimo()
        {
            Conectar();
            string query = "INSERT INTO Emprestimo (idUsuario, idLivro, dataDeSolicitacao, statusDaSolicitacao, dataDeDevolucao) " +
                           "VALUES (@idUsuario, @idLivro, @dataDeSolicitacao, 'pendente', @dataDeDevolucao)";
            using (cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@idLivro", idLivro);
                cmd.Parameters.AddWithValue("@dataDeSolicitacao", DateTime.Now);
                cmd.Parameters.AddWithValue("@dataDeDevolucao", dataDeDevolucao);
                cmd.ExecuteNonQuery();
            }
            Desconectar();
        }

        public DataTable GetSolicitacoes(int idUsuario)
        {
            Conectar();
            string query = "SELECT e.Id, l.Nome, e.dataDeSolicitacao, e.dataDeDevolucao, e.statusDaSolicitacao " +
                           "FROM Solicitacao s " +
                           "JOIN Livros l ON s.idLivro = l.Id " +
                           "WHERE l.idUsuario = @idUsuario AND s.statusDaSolicitacao = 'pendente'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@idUsuario", idUsuario);
            DataTable solicitacoes = new DataTable();
            adapter.Fill(solicitacoes);
            Desconectar();
            return solicitacoes;
        }

        public DataTable GetProdutos()
        {
            Conectar();
            string query = "SELECT Id, Nome, Quantidade, Valor FROM Produtos";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable produtos = new DataTable();
            adapter.Fill(produtos);
            Desconectar();
            return produtos;
        }

        public void AdicionarAoCarrinho(int idUsuario, int idProduto, int quantidade)
        {
            Conectar();
            string query = "INSERT INTO Carrinho (idUsuario, idProduto, quantidade) " +
                           "VALUES (@idUsuario, @idProduto, @quantidade) " +
                           "ON DUPLICATE KEY UPDATE quantidade = quantidade + @quantidade";
            using (cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@idProduto", idProduto);
                cmd.Parameters.AddWithValue("@quantidade", quantidade);
                cmd.ExecuteNonQuery();
            }
            Desconectar();
        }

        public void RemoverDoCarrinho(int idUsuario, int idProduto)
        {
            Conectar();
            string query = "DELETE FROM Carrinho WHERE idUsuario = @idUsuario AND idProduto = @idProduto";
            using (cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@idProduto", idProduto);
                cmd.ExecuteNonQuery();
            }
            Desconectar();
        }

        public DataTable GetCarrinho(int idUsuario)
        {
            Conectar();
            string query = "SELECT c.idProduto, p.Nome, p.Valor, c.quantidade " +
                           "FROM Carrinho c " +
                           "JOIN Produtos p ON c.idProduto = p.id " +
                           "WHERE c.idUsuario = @idUsuario";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@idUsuario", idUsuario);
            DataTable carrinho = new DataTable();
            adapter.Fill(carrinho);
            Desconectar();
            return carrinho;
        }

        public void FinalizarCompra(int idUsuario)
        {
            Conectar();

            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                string queryPedido = "INSERT INTO Pedidos (idUsuario, dataPedido, statusPedido) " +
                                     "VALUES (@idUsuario, @dataPedido, 'pendente')";
                using (cmd = new MySqlCommand(queryPedido, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@dataPedido", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }

                int idPedido = (int)cmd.LastInsertedId;

                string queryCarrinho = "SELECT idProduto, quantidade FROM Carrinho WHERE idUsuario = @idUsuario";
                using (cmd = new MySqlCommand(queryCarrinho, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idProduto = reader.GetInt32("idProduto");
                            int quantidade = reader.GetInt32("quantidade");

                            string queryPedidoProduto = "INSERT INTO Pedidos_Produtos (idPedido, idProduto, quantidade) " +
                                                        "VALUES (@idPedido, @idProduto, @quantidade)";
                            using (MySqlCommand cmdPedidoProduto = new MySqlCommand(queryPedidoProduto, conn, transaction))
                            {
                                cmdPedidoProduto.Parameters.AddWithValue("@idPedido", idPedido);
                                cmdPedidoProduto.Parameters.AddWithValue("@idProduto", idProduto);
                                cmdPedidoProduto.Parameters.AddWithValue("@quantidade", quantidade);
                                cmdPedidoProduto.ExecuteNonQuery();
                            }

                            string queryUpdateEstoque = "UPDATE Produtos SET estoque = estoque - @quantidade WHERE id = @idProduto";
                            using (MySqlCommand cmdUpdateEstoque = new MySqlCommand(queryUpdateEstoque, conn, transaction))
                            {
                                cmdUpdateEstoque.Parameters.AddWithValue("@quantidade", quantidade);
                                cmdUpdateEstoque.Parameters.AddWithValue("@idProduto", idProduto);
                                cmdUpdateEstoque.ExecuteNonQuery();
                            }
                        }
                    }
                }

                string queryLimparCarrinho = "DELETE FROM Carrinho WHERE idUsuario = @idUsuario";
                using (cmd = new MySqlCommand(queryLimparCarrinho, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                Desconectar();
            }
        }
    }


}





