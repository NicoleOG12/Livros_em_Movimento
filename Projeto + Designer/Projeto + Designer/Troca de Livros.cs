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
    public partial class Tela_Principal : Form
    {
        public Tela_Principal()
        {
            InitializeComponent();
         
        }

        private void Tela_Principal_Load(object sender, EventArgs e)
        {

        }

        private void Troca_de_livros_Click(object sender, EventArgs e)
        {
            /* Troca_de_Livros troca_de_livros = new Troca_de_Livros();
            troca_de_livros.ShowDialog();
            this.Close();*/

            
        }

        private void Sacola_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja();
            loja.ShowDialog();
            this.Close();
        }

        private void Solicitações_Click(object sender, EventArgs e)
        {
            Solicitações solicitações= new Solicitações();
            solicitações.ShowDialog();
            this.Close();
        }

        private void Perfil_Click(object sender, EventArgs e)
        {
            Perfil perfil= new Perfil();
            perfil.ShowDialog();
            this.Close();
        }


        private void Livro1_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Livro2_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Livro3_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Livro4_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Livro5_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Livro6_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Livro7_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Livro8_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
