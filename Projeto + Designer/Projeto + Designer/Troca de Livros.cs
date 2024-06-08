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
    public partial class Troca_de_livros : Form
    {
        public Troca_de_livros()
        {

            InitializeComponent();
         
        }

        private void Troca_de_livros_Click(object sender, EventArgs e)
        {
            Troca_de_livros troca_de_livros = new Troca_de_livros();
            troca_de_livros.ShowDialog();
            this.Close();

        }

        private void Sacola_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja();
            loja.ShowDialog();
            this.Close();
        }
        private void Carrinho_Click(object sender, EventArgs e)
        {
            Carrinho carrinho = new Carrinho();
            carrinho.ShowDialog();
            this.Close();
        }

        private void Perfil_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.ShowDialog();
            this.Close();
        }

        private void Solicitações_Click(object sender, EventArgs e)
        {
            Solicitações solicitações = new Solicitações();
            solicitações.ShowDialog();
            this.Close();
        }

        private void Memórias_Póstumas_Click(object sender, EventArgs e)
        {
            Livros livros = new Livros();
            livros.ShowDialog();
            this.Close();
        }

        private void Livro1_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Livros livros = new Livros();
            livros.ShowDialog();
            this.Close();
        }

        private void Mais_que_amigos_Click(object sender, EventArgs e)
        {

        }

        private void Livro2_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void A_hipótese_do_amor_Click(object sender, EventArgs e)
        {

        }

        private void Livro3_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void É_assim_que_começa_Click(object sender, EventArgs e)
        {

        }

        private void Livro4_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Além_da_fumaça_Click(object sender, EventArgs e)
        {

        }

        private void Livro5_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Bridgerton_Click(object sender, EventArgs e)
        {

        }

        private void Livro6_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void A_garota_do_lago_Click(object sender, EventArgs e)
        {

        }

        private void Livro7_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Como_eu_era_antes_de_você_Click(object sender, EventArgs e)
        {

        }

        private void Livro8_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

    }
}
