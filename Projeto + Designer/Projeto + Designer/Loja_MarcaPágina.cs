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
            MP1 mP1 = new MP1();
            mP1.ShowDialog();
            this.Close();
        }

        private void MarcaPágina1_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MP1 mP1 = new MP1();
            mP1.ShowDialog();
            this.Close();
        }

        private void MarcaPágina2_Click(object sender, EventArgs e)
        {
            MP2 mP2 = new MP2();
            mP2.ShowDialog();
            this.Close();
        }

        private void MarcaPágina2_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MP2 mp2 = new MP2();
            mp2.ShowDialog();
            this.Close();
        }

        private void MarcaPágina3_Click(object sender, EventArgs e)
        {
            MP3 mp3 = new MP3();    
            mp3.ShowDialog();
            this.Close();
        }

        private void MarcaPágina3_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MP3 mP3 = new MP3();
            mP3.ShowDialog();
            this.Close();
        }

        private void MarcaPágina4_Click(object sender, EventArgs e)
        {
            MP4 mp4 = new MP4();
            mp4.ShowDialog();
            this.Close();
        }

        private void MarcaPágina4_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MP4 mP4 = new MP4();
            mP4.ShowDialog();
            this.Close();
        }

        private void MarcaPágina5_Click(object sender, EventArgs e)
        {
            MP5 mp5 = new MP5();    
            mp5.ShowDialog();
            this.Close();
        }

        private void MarcaPágina5_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MP5 mP5 = new MP5();
            mP5.ShowDialog();
            this.Close();
        }

        private void MarcaPágina6_Click(object sender, EventArgs e)
        {
            MP6 mp6 = new MP6();
            mp6.ShowDialog();
            this.Close();
        }

        private void MarcaPágina6_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MP6 mp6 = new MP6();
            mp6 .ShowDialog();
            this.Close();
        }

        private void MarcaPágina7_Click(object sender, EventArgs e)
        {
            MP7 mp7 = new MP7();
            mp7.ShowDialog();
            this.Close();
        }

        private void MarcaPágina7_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MP7 mP7 = new MP7();
            mP7.ShowDialog();
            this.Close();
        }

        private void MarcaPágina8_Click(object sender, EventArgs e)
        {
            MP8 mp8 = new MP8();
            mp8.ShowDialog();
            this.Close();
        }

        private void MarcaPágina8_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MP8 mP8 = new MP8();
            mP8.ShowDialog();
            this.Close();
        }
    }
}
