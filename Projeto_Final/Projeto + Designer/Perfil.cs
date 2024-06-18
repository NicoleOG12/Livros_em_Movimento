using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto___Designer
{
    public partial class Perfil : Form
    {
        private int idUsuario;
        public Perfil(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            MostrarDados();
        }
        private void MostrarDados()
        {
            DAO dao = new DAO();
            dao.Conectar();
            DataTable dados = dao.GetUsuario(idUsuario);
            nomeperfil.Text = dados.Rows[0].ItemArray[1].ToString();
            nomeperfil.ReadOnly = true;
            emailperfil.Text = dados.Rows[0].ItemArray[4].ToString();
            emailperfil.ReadOnly = true;
        }

        private void Troca_de_livros_Click(object sender, EventArgs e)
        {
            Troca_de_livros troca_De_Livros = new Troca_de_livros(idUsuario);
            this.Hide();
            troca_De_Livros.ShowDialog();
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

        private void Anexar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fotoperfil.Image = Image.FromFile(openFileDialog.FileName);
                    string caminhoImagem = openFileDialog.FileName;
                    ConverterImagem(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ConverterImagem()
        {
            try
            {
                byte[] imagemBytes = ImageToByteArray(btn_fotoperfil.Image);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao converter imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}
