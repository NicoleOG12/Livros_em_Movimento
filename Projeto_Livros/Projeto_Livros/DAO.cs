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
        public DAO() 
        {
            string connectionString = "server=localhost;port=3306;Database=Gerenciamento;uid=root;pwd='';";
            MySqlConnection connection = new MySqlConnection(connectionString);


        }

    }
}
