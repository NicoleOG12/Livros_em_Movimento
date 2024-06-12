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
    public partial class Solicitações : Form
    {
        public Solicitações()
        {

            InitializeComponent();
         
        }

        private void Troca_de_livros_Click(object sender, EventArgs e)
        {
            Troca_de_livros troca_de_livros = new Troca_de_livros();
            this.Hide();
            troca_de_livros.ShowDialog();
        }

        private void Sacola_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja();
            this.Hide();
            loja.ShowDialog();
        }

        private void Carrinho_Click(object sender, EventArgs e)
        {
            Carrinho carrinho = new Carrinho();
            this.Hide();
            carrinho.ShowDialog();
        }

        private void Perfil_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            this.Hide();
            perfil.ShowDialog();
        }

        private void Solicitações_Click(object sender, EventArgs e)
        {
            Solicitações solicitações = new Solicitações();
            this.Hide();
            solicitações.ShowDialog();
        }

    }
}
