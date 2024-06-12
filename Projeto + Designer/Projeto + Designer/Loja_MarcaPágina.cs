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
    public partial class Loja_MarcaPágina : Form
    {
        public Loja_MarcaPágina()
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

        private void MarcaPágina1_Click(object sender, EventArgs e)
        {
            MP1 mP1 = new MP1();
            this.Hide();
            mP1.ShowDialog();
        }

        private void MarcaPágina1_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MP1 mP1 = new MP1();
            this.Hide();
            mP1.ShowDialog();
        }

        private void MarcaPágina2_Click(object sender, EventArgs e)
        {
            MP2 mP2 = new MP2();
            this.Hide();
            mP2.ShowDialog();
        }

        private void MarcaPágina2_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MP2 mp2 = new MP2();
            this.Hide();
            mp2.ShowDialog();
        }

        private void MarcaPágina3_Click(object sender, EventArgs e)
        {
            MP3 mp3 = new MP3();    
            this.Hide();
            mp3.ShowDialog();
        }

        private void MarcaPágina3_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MP3 mP3 = new MP3();
            this.Hide();
            mP3.ShowDialog();
        }

        private void MarcaPágina4_Click(object sender, EventArgs e)
        {
            MP4 mp4 = new MP4();
            this.Hide();
            mp4.ShowDialog();
        }

        private void MarcaPágina4_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MP4 mP4 = new MP4();
            this.Hide();
            mP4.ShowDialog();
        }

        private void MarcaPágina5_Click(object sender, EventArgs e)
        {
            MP5 mp5 = new MP5();    
            this.Hide();
            mp5.ShowDialog();
        }

        private void MarcaPágina5_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MP5 mP5 = new MP5();
            this.Hide();
            mP5.ShowDialog();
        }

        private void MarcaPágina6_Click(object sender, EventArgs e)
        {
            MP6 mp6 = new MP6();
            this.Hide();
            mp6.ShowDialog();
        }

        private void MarcaPágina6_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MP6 mp6 = new MP6();
            this.Hide();
            mp6 .ShowDialog();
        }

        private void MarcaPágina7_Click(object sender, EventArgs e)
        {
            MP7 mp7 = new MP7();
            this.Hide();
            mp7.ShowDialog();
        }

        private void MarcaPágina7_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MP7 mP7 = new MP7();
            this.Hide();
            mP7.ShowDialog();
        }

        private void MarcaPágina8_Click(object sender, EventArgs e)
        {
            MP8 mp8 = new MP8();
            this.Hide();
            mp8.ShowDialog();
        }

        private void MarcaPágina8_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MP8 mP8 = new MP8();
            this.Hide();
            mP8.ShowDialog();
        }
    }
}
