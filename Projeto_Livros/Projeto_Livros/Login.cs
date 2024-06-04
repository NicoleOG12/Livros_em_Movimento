using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Livros
{
    public class Login
    {
        public string email;
        public string senha;
      
        public bool FazerLogin()
        {
            Console.WriteLine("Digite seu email");
            this.email = Console.ReadLine();
            Console.WriteLine("Digite sua senha");
            this.senha = Console.ReadLine();

            DAO dao = new DAO();
            dao.Conectar();
            string comandoSql = $"SELECT * FROM usuario WHERE email = '{email}' AND senha = '{senha}'";
            var resultado = dao.LerDados(comandoSql);
            resultado.Read();
            int count = resultado.GetInt32(0);
            resultado.Close();
            dao.Desconectar();

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
