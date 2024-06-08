using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
        string connection = "server=localhost; port=3306; database=gerenciamento; uid=root; pwd='FuscaAzuL123.'";

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
    }
}


