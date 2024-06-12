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
    public partial class A_Garota_do_Lago : Form
    {
        public A_Garota_do_Lago()
        {
            InitializeComponent();
        }

        private void Comprar_agora_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.Conectar();
            string comandoSql = $"Select id from Produto where nome= '{Nome_item_txt.Text}'";

            dao.Desconectar();
        }

        private void Adicionar_ao_carrinho_Click(object sender, EventArgs e)
        {
            Carrinho carrinho = new Carrinho();
            this.Hide();
            carrinho.ShowDialog();
        }

        private void Seta_Click(object sender, EventArgs e)
        {
            Loja_Livros loja_Livros = new Loja_Livros();
            this.Hide();
            loja_Livros.ShowDialog();
            
        }
    }
}
