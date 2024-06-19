using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.CarregarProdutos();
        }

        private void Troca_de_livros_Click(object sender, EventArgs e)
        {
            Feed feed = new Feed(idUsuario);
            this.Hide();
            feed.ShowDialog();

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


        private void CarregarProdutos()
        {
            try
            {
                DAO dao = new DAO();
                DataTable produtos = dao.GetProdutos();

                if (produtos.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum produto encontrado no banco de dados.");
                    return;
                }

                foreach (DataRow row in produtos.Rows)
                {
                    GroupBox groupBox = new GroupBox
                    {
                        Width = 134,
                        Height = 207,
                        Margin = new Padding(15),
                        BackColor = Color.White
                    };

                    PictureBox pictureBox = new PictureBox
                    {
                        Width = 103,
                        Height = 144,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = new Point(15, 15)
                    };

                    byte[] imagemBytes = (byte[])row["Imagem"];
                    if (imagemBytes != null && imagemBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imagemBytes))
                        {
                            pictureBox.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Imagem não encontrada.");
                    }

                    Label label = new Label
                    {
                        Text = row["Nome"].ToString(),
                        AutoSize = true,
                        Width = 109,
                        Height = 22,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Location = new Point(40, 165),
                        BackColor = Color.Lavender,
                        ForeColor = Color.MediumPurple,
                        Cursor= Cursors.Hand
                    };

                    groupBox.Controls.Add(pictureBox);
                    groupBox.Controls.Add(label);
                    flowLayoutPanel1.Controls.Add(groupBox);

                    string nomeProduto = row["Nome"].ToString();
                    pictureBox.Click += (sender, e) =>
                    {
                        ExibirProduto(idUsuario, nomeProduto);
                    };
                    label.Click += (sender, e) =>
                    {
                        ExibirProduto(idUsuario, nomeProduto);
                    };

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }


        public void ExibirProduto(int idUsuario, string nomeProduto)
        {
            Exibir_Produtos produtos = new Exibir_Produtos(idUsuario, nomeProduto );
            this.Hide();
            produtos.ShowDialog();
        }
    }
}