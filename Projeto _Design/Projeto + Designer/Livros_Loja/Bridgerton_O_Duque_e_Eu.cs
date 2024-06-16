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
    public partial class BridgertonO_Duque_e_Eu : Form
    {
        private int idUsuario;
        public BridgertonO_Duque_e_Eu(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void Comprar_agora_Click(object sender, EventArgs e)
        {

        }

        private void Adicionar_ao_carrinho_Click(object sender, EventArgs e)
        {
            Carrinho carrinho = new Carrinho(idUsuario);
            this.Hide();
            carrinho.ShowDialog();
        }

        private void Seta_Click(object sender, EventArgs e)
        {
            Loja_Livros loja_Livros = new Loja_Livros(idUsuario);
            this.Hide();
            loja_Livros.ShowDialog();
        }
    }
}
