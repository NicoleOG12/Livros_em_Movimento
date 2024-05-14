using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Livros
{
    public class DAO
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader rd;
        string comandoSql;
        string connection = "server=localhost;port=3306;Database=Gerenciamento;uid=root;pwd='';";

       public void conectar()
         {
            conn = new MySqlConnection(connection);
            conn.Open();
         }

       public void Execucao(string comandoSql)
         {
            cmd = new MySqlCommand(comandoSql, conn);
            cmd.ExecuteNonQuery();
              
         }

       public void lerDados()
         {
            cmd = new MySqlCommand(comandoSql, conn);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read()) 
            {

            }

            rd.Close(); 

         }
        }
    }

