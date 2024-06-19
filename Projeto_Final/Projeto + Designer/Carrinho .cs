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
    public partial class Carrinho : Form
    {
        private int idUsuario;
        
        DAO dao = new DAO();
   
        public Carrinho(int idUsuario)
        {
            InitializeComponent();
            CarregarCarrinho();
            //Painel.DataSource = dao.GetCarrinho(idUsuario);
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
            Perfil perfil= new Perfil(idUsuario);
            this.Hide();
            perfil.ShowDialog();
        }

        private void Solicitações_Click(object sender, EventArgs e)
        {
            Notificações solicitações = new Notificações(idUsuario);
            this.Hide();
            solicitações.ShowDialog();
        }

        private void CarregarCarrinho()
        {
            try
            {
                DAO dao = new DAO();
                DataTable carrinho = dao.GetCarrinho(idUsuario);

                if (carrinho.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum livro encontrado no banco de dados.");
                    return;
                }

                foreach (DataRow row in carrinho.Rows)
                {
                    GroupBox groupBox = new GroupBox
                    {
                        Width = 467,
                        Height = 71,
                        Margin = new Padding(15),
                        BackColor = Color.White
                    };

                    PictureBox pictureBox = new PictureBox
                    {
                        Width = 45,
                        Height = 50,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = new Point(19, 14)
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
                        Text = row["Nome, Preço, Quantidade"].ToString(),
                        AutoSize = true,
                        Width = 109,
                        Height = 22,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Location = new Point(40, 165),
                        BackColor = Color.Lavender,
                        ForeColor = Color.MediumPurple
                    };

                    groupBox.Controls.Add(pictureBox);
                    groupBox.Controls.Add(label);
                    flowLayoutPanel1.Controls.Add(groupBox);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar livros: " + ex.Message);
            }
        }
    }
}
