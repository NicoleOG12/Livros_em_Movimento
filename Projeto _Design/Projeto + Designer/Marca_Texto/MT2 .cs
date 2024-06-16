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
    public partial class MT2 : Form
    {
        private int idUsuario;
        public MT2()
        {
            InitializeComponent();
        }

        private void Comprar_agora_Click(object sender, EventArgs e)
        {

        }

        private void Adicionar_ao_carrinho_Click(object sender, EventArgs e)
        {
            Carrinho carrinho = new Carrinho(idUsuario);
            carrinho.ShowDialog();
            this.Hide();
        }

        private void Seta_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja(idUsuario);
            loja.ShowDialog();
            this.Hide();
        }
    }
}
