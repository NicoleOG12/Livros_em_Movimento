using MySql.Data.MySqlClient;
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
    public partial class LoginADM : Form
    {
        
        public LoginADM()
        {
            InitializeComponent();
        }

        private void Logar_btn(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            try
            {
                dao.Conectar();

                string comandoSql = "SELECT id FROM administradores WHERE email = @Email AND senha = @Senha";
                MySqlCommand cmd = new MySqlCommand(comandoSql, dao.Conectar());
                cmd.Parameters.AddWithValue("@Email", Email_box.Text);
                cmd.Parameters.AddWithValue("@Senha", Senha_Box.Text);

                object idADM = cmd.ExecuteScalar();

                if (idADM != null)  
                {
                    int id = Convert.ToInt32(idADM);

                    TipoCadastro tipoCadastro = new TipoCadastro();
                    this.Hide();
                    tipoCadastro.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Email ou senha incorretos. Tente novamente.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao tentar logar: " + ex.Message);
            }
            finally
            {
                dao.Desconectar();
            }
        }
    }
}







