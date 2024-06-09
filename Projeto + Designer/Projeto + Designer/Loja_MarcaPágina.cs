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
    public partial class Loja_MarcaPágina: Form
    {
        public Loja_MarcaPágina()
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

        private void MarcaPágina1_Click(object sender, EventArgs e)
        {

        }

        private void MarcaPágina1_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void MarcaPágina2_Click(object sender, EventArgs e)
        {

        }

        private void MarcaPágina2_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void MarcaPágina3_Click(object sender, EventArgs e)
        {

        }

        private void MarcaPágina3_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void MarcaPágina4_Click(object sender, EventArgs e)
        {

        }

        private void MarcaPágina4_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void MarcaPágina5_Click(object sender, EventArgs e)
        {

        }

        private void MarcaPágina5_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void BMarcaPágina6_Click(object sender, EventArgs e)
        {

        }

        private void MarcaPágina6_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void MarcaPágina7_Click(object sender, EventArgs e)
        {

        }

        private void MarcaPágina7_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void MarcaPágina8_Click(object sender, EventArgs e)
        {

        }

        private void MarcaPágina8_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
