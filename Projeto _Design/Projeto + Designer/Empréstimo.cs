using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto___Designer
{
    public partial class Empréstimo : Form
    {
        private int idUsuario;
        public Empréstimo(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.SolicitarEmprestimo();
            Tela_Confirmação tela_Confirmação = new Tela_Confirmação(idUsuario);
            tela_Confirmação.ShowDialog();
            this.Hide();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Troca_de_livros troca_De_Livros = new Troca_de_livros(idUsuario);
            troca_De_Livros.ShowDialog();
            this.Hide();
        }

        private void Nome_box_TextChanged(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.Conectar();
            string comandoSql = $"Select * from Usuarios (nome) values ('{Nome_box.Text}')";
            dao.ExecutarComando(comandoSql);
            dao.Desconectar();
        }

        private void Email_box_TextChanged(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.Conectar();
            string comandoSql = $"Select * from Usuarios (email) values ('{Email_box.Text}')";
            dao.ExecutarComando(comandoSql);
            dao.Desconectar();
        }

        private void Nome_do_Livro_Box_TextChanged(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.Conectar();
            string comandoSql = $"Select * from Usuarios (nome do livro) values (' {Nome_do_Livro_Box.Text}')";
            dao.ExecutarComando(comandoSql);
            dao.Desconectar();
        }
    }
}
