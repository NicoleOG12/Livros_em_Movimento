using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Livros
{
    internal class DAO
    {
        MySqlConnection conn;
        MySqlCommand cmd;

            string sql;
            string command = "";
            string connection = "server=localhost;port=3306;Database=Gerenciamento;uid=root;pwd='';";

            public void conexão()
            {
                conn = new MySqlConnection(connection);
                conn.Open();

            }

            public void selecionar()
            {
                cmd = new MySqlCommand(command, conn);
            }

            public void ler()
            {

            }
        }
    }

