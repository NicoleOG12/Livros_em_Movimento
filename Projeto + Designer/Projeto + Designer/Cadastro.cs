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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Entrar(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.Conectar();
            string comandoSql = $"Insert into Usuario (nome, email, senha, generosdeinteresse) values ('{Nome_box.Text}', '{Email_box.Text}','{Senha_box.Text}','{GeneroInteresse.Text}')";
            dao.ExecutarComando(comandoSql);
            dao.Desconectar();
            Troca_de_livros troca_de_livros = new Troca_de_livros();
            troca_de_livros.ShowDialog();
            this.Hide();
        }
    }
   
}
