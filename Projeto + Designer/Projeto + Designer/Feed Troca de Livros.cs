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


        private void Para_além_do_diário_de_Anne_Frank_Click(object sender, EventArgs e)
        {
            Para_além_do_diário_de_Anne_Frank livro1= new Para_além_do_diário_de_Anne_Frank();
            this.Hide();
            livro1.ShowDialog();
        }

        private void Livro1_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Para_além_do_diário_de_Anne_Frank livro1 = new Para_além_do_diário_de_Anne_Frank();
            this.Hide();
            livro1.ShowDialog();
        }

        private void A_mente_de_Adolf_Hitler_Click(object sender, EventArgs e)
        {
            A_mente_de_Adolf_Hitler livro2 = new A_mente_de_Adolf_Hitler();
            this.Hide();
            livro2.ShowDialog();
        }

        private void Livro2_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            A_mente_de_Adolf_Hitler livro2 = new A_mente_de_Adolf_Hitler();
            this.Hide();
            livro2.ShowDialog();
        }

        private void Assinato_na_casa_do_pastor_Click(object sender, EventArgs e)
        {
            Assinato_na_casa_do_pastor livro3 = new Assinato_na_casa_do_pastor();
            this.Hide();
            livro3.ShowDialog();
        }

        private void Livro3_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Assinato_na_casa_do_pastor livro3 = new Assinato_na_casa_do_pastor();
            this.Hide();
            livro3.ShowDialog();
        }

        private void E_não_sobrou_ninguém_Click(object sender, EventArgs e)
        {
            E_não_sobrou_ninguém livro4 = new E_não_sobrou_ninguém();
            this.Hide();
            livro4.ShowDialog();
        }

        private void Livro4_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            E_não_sobrou_ninguém livro4 = new E_não_sobrou_ninguém();
            this.Hide();
            livro4.ShowDialog();
        }

        private void O_homem_de_giz_Click(object sender, EventArgs e)
        {
            O_homem_de_giz livro5 = new O_homem_de_giz();
            this.Hide();
            livro5.ShowDialog();
        }

        private void Livro5_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            O_homem_de_giz livro5 = new O_homem_de_giz();
            this.Hide();
            livro5.ShowDialog();
        }

        private void Pessoas_normais_Click(object sender, EventArgs e)
        {
            Pessoas_normais livro6= new Pessoas_normais();
            this.Hide();
            livro6.ShowDialog();
        }

        private void Livro6_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pessoas_normais livro6 = new Pessoas_normais();
            this.Hide();
            livro6.ShowDialog();
        }

        private void A_vida_invisível_de_Addie_Larue_Click(object sender, EventArgs e)
        {
            A_vida_invisível_de_Addie_Larue livro7 = new A_vida_invisível_de_Addie_Larue();
            this.Hide();
            livro7.ShowDialog();
        }

        private void Livro7_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            A_vida_invisível_de_Addie_Larue livro7 = new A_vida_invisível_de_Addie_Larue();
            this.Hide();
            livro7.ShowDialog();
        }

        private void Um_de_nós_está_mentindo_Click(object sender, EventArgs e)
        {
            Um_de_nós_está_mentindo livro8 = new Um_de_nós_está_mentindo();
            this.Hide();
            livro8.ShowDialog();
        }

        private void Livro8_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Um_de_nós_está_mentindo livro8 = new Um_de_nós_está_mentindo();
            this.Hide();
            livro8.ShowDialog();
            
        }
    }
}
