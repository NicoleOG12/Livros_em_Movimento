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
    public partial class Loja : Form
    {
        private int idUsuario;
        public Loja(int idUsuario)
        {

            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void Troca_de_livros_Click(object sender, EventArgs e)
        {
            Troca_de_livros troca_de_livros = new Troca_de_livros(idUsuario);
            this.Hide();
            troca_de_livros.ShowDialog();

        }

        private void Sacola_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja(idUsuario);
            this.Hide();
            loja.ShowDialog();
        }
        private void Carrinho_Click(object sender, EventArgs e)
        {
            Carrinho carrinho = new Carrinho(idUsuario);
            this.Hide();
            carrinho.ShowDialog();
        }

        private void Perfil_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil(idUsuario);
            this.Hide();
            perfil.ShowDialog();
        }

        private void Solicitações_Click(object sender, EventArgs e)
        {
            Notificações solicitações = new Notificações(idUsuario);
            this.Hide();
            solicitações.ShowDialog();
        }

        private void Memórias_Póstumas_Click(object sender, EventArgs e)
        {
            Memórias_Póstumas_de_Brás_Cubas livros = new Memórias_Póstumas_de_Brás_Cubas(idUsuario);
            this.Hide();
            livros.ShowDialog();
        }

        private void Livro1_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Memórias_Póstumas_de_Brás_Cubas livros = new Memórias_Póstumas_de_Brás_Cubas(idUsuario);
            this.Hide();
            livros.ShowDialog();
        }

        private void Mais_que_amigos_Click(object sender, EventArgs e)
        {
            Mais_que_amigos livros = new Mais_que_amigos(idUsuario);
            this.Hide();
            livros.ShowDialog();
        }

        private void Livro2_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Mais_que_amigos livros = new Mais_que_amigos(idUsuario);
            this.Hide();
            livros.ShowDialog();
        }

        private void A_hipótese_do_amor_Click(object sender, EventArgs e)
        {
            A_hipótese_do_amor livros = new A_hipótese_do_amor(idUsuario);
            this.Hide();
            livros.ShowDialog();
        }

        private void Livro3_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            A_hipótese_do_amor livros = new A_hipótese_do_amor(idUsuario);
            this.Hide();
            livros.ShowDialog();
        }

        private void É_assim_que_começa_Click(object sender, EventArgs e)
        {
            É_assim_que_começa livros = new É_assim_que_começa(idUsuario);
            this.Hide();
            livros.ShowDialog();
        }

        private void Livro4_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            É_assim_que_começa livros = new É_assim_que_começa(idUsuario);
            this.Hide();
            livros.ShowDialog();
        }

        private void Além_da_fumaça_Click(object sender, EventArgs e)
        {
            Além_da_Fumaça livros = new Além_da_Fumaça(idUsuario);
            this.Hide();
            livros.ShowDialog();
        }

        private void Livro5_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Além_da_Fumaça livros = new Além_da_Fumaça(idUsuario);
            this.Hide();
            livros.ShowDialog();
        }

        private void Bridgerton_Click(object sender, EventArgs e)
        {
            BridgertonO_Duque_e_Eu livros = new BridgertonO_Duque_e_Eu(idUsuario);
            this.Hide();
            livros.ShowDialog();
        }

        private void Livro6_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BridgertonO_Duque_e_Eu livros = new BridgertonO_Duque_e_Eu(idUsuario);
            this.Hide();
            livros.ShowDialog();
        }

        private void A_garota_do_lago_Click(object sender, EventArgs e)
        {
            A_Garota_do_Lago livros = new A_Garota_do_Lago(idUsuario);
            this.Hide();
            livros.ShowDialog();
        }

        private void Livro7_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            A_Garota_do_Lago livros = new A_Garota_do_Lago(idUsuario);
            this.Hide();
            livros.ShowDialog();
        }

        private void Como_eu_era_antes_de_você_Click(object sender, EventArgs e)
        {
            Como_Eu_Era_Antes_de_Você livros = new Como_Eu_Era_Antes_de_Você();
            this.Hide();
            livros.ShowDialog();
        }

        private void Livro8_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Como_Eu_Era_Antes_de_Você livros = new Como_Eu_Era_Antes_de_Você();
            this.Hide();
            livros.ShowDialog();
        }

        private void MarcaTexto_Click(object sender, EventArgs e)
        {
            Loja_MarcaTexto loja = new Loja_MarcaTexto();
            this.Hide();
            loja.ShowDialog();
        }

        private void MarcaPagina_Click(object sender, EventArgs e)
        {
            Loja_MarcaPágina loja1 = new Loja_MarcaPágina(idUsuario);
            this.Hide();
            loja1.ShowDialog();
        }
    }
}
