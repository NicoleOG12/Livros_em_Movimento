using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto___Designer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Cadastro_btn(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            this.Hide();
            cadastro.ShowDialog();
        }

        private void Logar_btn(object sender, EventArgs e)
        {
            try
            {
                DAO dao = new DAO();
                dao.Conectar();
                string comandoSql = $"SELECT * FROM usuario WHERE email = '{email_box.Text}' AND senha = '{senha_box.Text}'";
                var resultado = dao.LerDados(comandoSql);

                if (resultado.Read())
                {
                    int count = resultado.GetInt32(0);

                    if (count > 0)
                    {
                        Troca_de_livros troca_de_livros = new Troca_de_livros();
                        this.Hide();
                        troca_de_livros.ShowDialog();
                    }

                    else
                    {
                        MessageBox.Show("Email ou senha incorreto. Tente novamente");
                        Login login = new Login();
                        this.Hide();
                        login.ShowDialog();
                    }


                    resultado.Close();
                    dao.Desconectar();
                }
            }


            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar logar");
            }
        }
    }
}



              

 
