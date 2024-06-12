using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto___Designer
{
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        public int id;
        private void Confirmar_Click(object sender, EventArgs e)
        {
            Tela_Confirmação tela_Confirmação = new Tela_Confirmação();
            DAO dao = new DAO();
            dao.Conectar();
            string comandoSql = $"Update Produto set estoque= estoque - 1 where id= '{id}'";
            dao.ExecutarComando(comandoSql);
            dao.Desconectar();
            tela_Confirmação.ShowDialog();
            this.Hide();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Troca_de_livros troca_De_Livros = new Troca_de_livros();
            troca_De_Livros.ShowDialog();
            this.Hide();
        }
    }
}
