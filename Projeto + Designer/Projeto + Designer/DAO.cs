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

        MySqlConnection conn;
        MySqlCommand cmd;
        string connection = "server=localhost; port=3306; database=Gerenciamento; uid=root; pwd='FuscaAzuL123.'";

        public void Conectar()
        {
            conn = new MySqlConnection(connection);
            conn.Open();
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
            string query = "SELECT Id, Nome FROM Livros_Emprestimos";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable livros = new DataTable();
            adapter.Fill(livros);
            Desconectar();
            return livros;
        }

        public DataTable BuscarLivros(string filtro)
        {
            Conectar();
            string query = "SELECT Id, Nome FROM Livros_Emprestimos WHERE Nome LIKE @Filtro";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");
            DataTable livros = new DataTable();
            adapter.Fill(livros);
            Desconectar();
            return livros;
        }

        public void SolicitarEmprestimo(int idUsuario, int idLivro)
        {
            Conectar();
            string query = "INSERT INTO Solicitacao (idUsuario, idLivro, dataDeSolicitacao, statusDaSolicitacao, dataDeDevolucao) " +
                           "VALUES (@idUsuario, @idLivro, @dataDeSolicitacao, 'pendente', @dataDeDevolucao)";
            using (cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@idLivro", idLivro);
                cmd.Parameters.AddWithValue("@dataDeSolicitacao", DateTime.Now);
                cmd.Parameters.AddWithValue("@dataDeDevolucao", DateTime.Now.AddDays(14));
                cmd.ExecuteNonQuery();
            }
            Desconectar();
        }
    }

}



