using MySql.Data.MySqlClient;
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
        string connection = "server=localhost; port=3306; database=Gerenciamento; uid=root;";

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

        public DataTable GetUsuario(int id)
        {
            Conectar();
            string query = $"SELECT * FROM Usuarios where id={id}";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable Usuarios = new DataTable();
            adapter.Fill(Usuarios);
            Desconectar();
            return Usuarios;
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

        public void SolicitarEmprestimo(int idUsuario, int idLivro)
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

        public DataTable BuscarProdutos(string filtro)
        {
            Conectar();
            string query = "SELECT Id, Nome FROM Produtos WHERE Nome LIKE @Filtro";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");
            DataTable produtos = new DataTable();
            adapter.Fill(produtos);
            Desconectar();
            return produtos;
        }

        public DataTable GetProdutos(string nome)
        {
            Conectar();
            string query = $"SELECT Id, nome, estoque, Valor FROM Produtos where nome='{nome}'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable produtos = new DataTable();
            adapter.Fill(produtos);
            Desconectar();
            return produtos;
        }

        public bool AtualizarUsuario(int idUsuario, string cpf, string celular)
        {
            bool sucesso = false;
            try
            {
                Conectar();

                string comandoSqlAtualizar = "UPDATE Usuarios SET cpf = @CPF, celular = @Celular " +
                                             "WHERE id = @IdUsuario";

                MySqlCommand cmdAtualizar = new MySqlCommand(comandoSqlAtualizar, conn);
                cmdAtualizar.Parameters.AddWithValue("@CPF", cpf);
                cmdAtualizar.Parameters.AddWithValue("@Celular", celular);
                cmdAtualizar.Parameters.AddWithValue("@IdUsuario", idUsuario);

                int linhasAtualizadas = cmdAtualizar.ExecuteNonQuery();

                if (linhasAtualizadas > 0)
                {
                    sucesso = true;
                }
                else
                {
                    Console.WriteLine("Nenhuma linha foi atualizada. Verifique o ID do usuário.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar usuário: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

            return sucesso;
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
        public int ObterIdProduto(string nomeProduto)
        {
            int idProduto = -1;
            try
            {
                Conectar();
                string query = "SELECT id FROM Produtos WHERE nome = @Nome";
                using (cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nomeProduto);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        idProduto = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter ID do Produto: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return idProduto;
        }
        public bool VerificarExistenciaUsuario(int idUsuario)
        {
            bool usuarioExiste = false;
            try
            {
                Conectar();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE id = @IdUsuario";
                using (cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        usuarioExiste = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar existência do usuário: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return usuarioExiste;
        }

        public int ObterIdLivroPeloNome(string nomeLivro)
        {
            int idLivro = -1; 

            try
            {
                Conectar();

                string query = "SELECT Id FROM Livros WHERE Nome = @Nome";
                using (cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nomeLivro);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        idLivro = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter ID do livro: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

            return idLivro;
        }

        public DataTable UltimoLivroCadastrado()
        {
            DataTable livro = null;
            try
            {
                Conectar();
                string query = "SELECT Id, Nome FROM Produtos ORDER BY Id DESC";
                DataTable result = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    adapter.Fill(result);
                }

                if (result.Rows.Count > 0)
                {
                    livro = result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter último livro cadastrado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

            return livro;
        }

        public DataRow UltimoProdutoCadastrado()
        {
            DataRow produto = null;
            try
            {
                Conectar();
                string query = "SELECT Id, Nome, Imagem FROM Produtos ORDER BY Id DESC LIMIT 1";
                DataTable result = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    adapter.Fill(result);
                }

                if (result.Rows.Count > 0)
                {
                    produto = result.Rows[0];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter último produto cadastrado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

            return produto;
        }

        public DataTable GetNotificacoes(int idUsuario)
        {
            DataTable notificacoes = new DataTable();

            try
            {
                Conectar();

                string queryEmprestimo = @"SELECT e.id AS IdNotificacao, u.Nome AS NomeUsuario, l.Nome AS NomeLivro, e.dataDeSolicitacao, 'Emprestimo' AS Tipo
                                   FROM Emprestimo e
                                   JOIN Usuarios u ON e.idUsuario = u.id
                                   JOIN Livros l ON e.idLivro = l.id
                                   WHERE e.statusDaSolicitacao = 'pendente'";

                string queryTroca = @"SELECT t.id AS IdNotificacao, u.Nome AS NomeUsuario, l.Nome AS NomeLivro, t.dataDeSolicitacao, 'Troca' AS Tipo
                              FROM Troca t
                              JOIN Usuarios u ON t.idUsuario = u.id
                              JOIN Livros l ON t.idLivro = l.id";

                MySqlCommand cmd = new MySqlCommand(queryEmprestimo + " UNION ALL " + queryTroca, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(notificacoes);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter notificações: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

            return notificacoes;
        }

    }
}






