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
            Livro1 livros = new Livro1();
            livros.ShowDialog();
            this.Close();
        }

        private void Livro1_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Livro1 livros = new Livro1();
            livros.ShowDialog();
            this.Close();
        }

        private void Mais_que_amigos_Click(object sender, EventArgs e)
        {
            Livro2 livros = new Livro2();
            livros.ShowDialog();
            this.Close();
        }

        private void Livro2_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Livro2 livros = new Livro2();
            livros.ShowDialog();
            this.Close();
        }

        private void A_hipótese_do_amor_Click(object sender, EventArgs e)
        {
            Livro3 livros = new Livro3();
            livros.ShowDialog();
            this.Close();
        }

        private void Livro3_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Livro3 livros = new Livro3();
            livros.ShowDialog();
            this.Close();
        }

        private void É_assim_que_começa_Click(object sender, EventArgs e)
        {
            Livro4 livros = new Livro4();
            livros.ShowDialog();
            this.Close();
        }

        private void Livro4_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Livro4 livros = new Livro4();
            livros.ShowDialog();
            this.Close();
        }

        private void Além_da_fumaça_Click(object sender, EventArgs e)
        {
            Livro5 livros = new Livro5();
            livros.ShowDialog();
            this.Close();
        }

        private void Livro5_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Livro5 livros = new Livro5();
            livros.ShowDialog();
            this.Close();
        }

        private void Bridgerton_Click(object sender, EventArgs e)
        {
            Livro6 livros = new Livro6();
            livros.ShowDialog();
            this.Close();
        }

        private void Livro6_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Livro6 livros = new Livro6();
            livros.ShowDialog();
            this.Close();
        }

        private void A_garota_do_lago_Click(object sender, EventArgs e)
        {
            Livro7 livros = new Livro7();
            livros.ShowDialog();
            this.Close();
        }

        private void Livro7_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Livro7 livros = new Livro7();
            livros.ShowDialog();
            this.Close();
        }

        private void Como_eu_era_antes_de_você_Click(object sender, EventArgs e)
        {
            Livro8 livros = new Livro8();
            livros.ShowDialog();
            this.Close();
        }

        private void Livro8_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Livro8 livros = new Livro8();
            livros.ShowDialog();
            this.Close();
        }

    }
}
