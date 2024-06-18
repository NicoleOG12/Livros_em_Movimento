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
    public partial class Loja_MarcaTexto : Form
    {
        private int idUsuario;
        public Loja_MarcaTexto(int idUsuario)
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

        private void MT1_Click(object sender, EventArgs e)
        {
            MT1 mT1 = new MT1();
            this.Hide();
            mT1.ShowDialog();
        }

        private void MT1_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MT1 mT1 = new MT1();
            this.Hide();
            mT1.ShowDialog();
        }

        private void MT2_Click(object sender, EventArgs e)
        {
            MT2 mT2 = new MT2(idUsuario);
            this.Hide();
            mT2.ShowDialog();
        }

        private void MT2_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MT2 mT2 = new MT2(idUsuario);
            this.Hide();
            mT2.ShowDialog();
        }

        private void MT3_Click(object sender, EventArgs e)
        {
            MT3 mT3 = new MT3(idUsuario);
            this.Hide();
            mT3.ShowDialog();
        }

        private void MT3_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MT3 mT3 = new MT3(idUsuario);
            this.Hide();
            mT3.ShowDialog();
        }

        private void MT4_Click(object sender, EventArgs e)
        {
            MT4 mT4 = new MT4();
            this.Hide();
            mT4.ShowDialog();
        }

        private void MT4_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MT4 mT4 = new MT4();
            this.Hide();
            mT4.ShowDialog();
        }

        private void MT5_Click(object sender, EventArgs e)
        {
            MT5 mT5 = new MT5(idUsuario);
            this.Hide();
            mT5.ShowDialog();
        }

        private void MT5_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MT5 mT5 = new MT5(idUsuario);
            this.Hide();
            mT5.ShowDialog();
        }

        private void MT6_Click(object sender, EventArgs e)
        {
            MT6 mT6 = new MT6();
            this.Hide();
            mT6.ShowDialog();
        }

        private void MT6_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MT6 mT6 = new MT6();
            this.Hide();
            mT6.ShowDialog();
        }

        private void MT7_Click(object sender, EventArgs e)
        {
            MT7 mT7 = new MT7(idUsuario);
            this.Hide();
            mT7.ShowDialog();
        }

        private void MT7_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MT7 mT7 = new MT7(idUsuario);
            this.Hide();
            mT7.ShowDialog();
        }

        private void MT8_Click(object sender, EventArgs e)
        {
            MT8 mT8 = new MT8(idUsuario);
            this.Hide();
            mT8.ShowDialog();
        }

        private void MT8_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MT8 mT8 = new MT8(idUsuario);
            this.Hide();
            mT8.ShowDialog();
        }
    }
}
