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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarUsuario(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_txt_Click(object sender, EventArgs e)
        {

        }

        private void Email_txt_Click(object sender, EventArgs e)
        {
        
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Logar(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.Conectar();
            string comandoSql = $"SELECT * FROM usuario WHERE email = '{email_box.Text}' AND senha = '{senha_box.Text}'";
            var resultado = dao.LerDados(comandoSql);
            resultado.Read();
            int count = resultado.GetInt32(0);
            resultado.Close();
            dao.Desconectar();

            if (count > 0)
            {
                
                Tela_Principal tela_Principal = new Tela_Principal();
                tela_Principal.ShowDialog();
                this.Close();
            }
            else
            {
               
            }

         
        }
    }
}
