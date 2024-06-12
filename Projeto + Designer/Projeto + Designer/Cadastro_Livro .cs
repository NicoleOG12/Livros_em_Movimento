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
    public partial class Cadastro_Livro : Form
    {
        public Cadastro_Livro()
        {
            InitializeComponent();
        }

        private void Cadastrar(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.Conectar();
            string comandoSql = $"Insert into Livros_Emprestimos (nome, autor, genero) values ('{Nome_do_Livro_box.Text}','{Autor_box.Text}','{Gênero_box.Text}')";
            dao.ExecutarComando(comandoSql);
            dao.Desconectar();
            Troca_de_livros troca_de_livros = new Troca_de_livros();
            troca_de_livros.ShowDialog();
            this.Hide();
        }

        private void Seta_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.ShowDialog();
            this.Hide();
        }
    }
   
}
