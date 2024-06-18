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
    public partial class Teste : Form
    {
        private int idUsuario;
        private DAO dao;

        public Teste(int idUsuario)
        {

            InitializeComponent();
            this.idUsuario = idUsuario;
            dao = new DAO();
        }

        private void FormLivros_Load(object sender, EventArgs e)
        {
            CarregarLivrosDoBanco();
        }

        private void CarregarLivrosDoBanco()
        {
            try
            {
                DataRow livro = dao.UltimoLivroCadastrado();

                if (livro != null)
                {
                    int livroId = Convert.ToInt32(livro["Id"]);
                    string nomeLivro = livro["Nome"].ToString();
                    byte[] imagemBytes = (byte[])livro["Imagem"];

                    GroupBox groupBox = new GroupBox();
                    groupBox.Width = 130;
                    groupBox.Height = 204;
                    groupBox.Margin = new Padding(15, 15, 15, 15);

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 103;
                    pictureBox.Height = 144;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    if (imagemBytes != null && imagemBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imagemBytes))
                        {
                            pictureBox.Image = Image.FromStream(ms);
                        }
                    }

                    Label labelNome = new Label();
                    labelNome.Text = nomeLivro;
                    labelNome.AutoSize = true;
                    labelNome.Location = new Point(10, pictureBox.Bottom + 10);

                    groupBox.Controls.Add(pictureBox);
                    groupBox.Controls.Add(labelNome);

                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(groupBox);
                }
                else
                {
                    MessageBox.Show("Nenhum livro cadastrado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao carregar último livro cadastrado: " + ex.Message);
            }

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


        private void Lupa_box_Click(object sender, EventArgs e)
        {
            ExecutarPesquisa();
        }

        private void ExecutarPesquisa()
        {
            string filtro = Pesquisa_barra.Text.Trim();

            if (!string.IsNullOrEmpty(filtro))
            {
                DataTable livrosFiltrados = dao.BuscarLivros(filtro);

                flowLayoutPanel1.Controls.Clear();

                foreach (DataRow row in livrosFiltrados.Rows)
                {
                    int livroId = Convert.ToInt32(row["Id"]);
                    string nomeLivro = row["Nome"].ToString();
                    byte[] imagemBytes = (byte[])row["Imagem"];

                    GroupBox groupBox = new GroupBox();
                    groupBox.Width = 130;
                    groupBox.Height = 204;
                    groupBox.Margin = new Padding(15, 15, 15, 15);

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 103;
                    pictureBox.Height = 144;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    if (imagemBytes != null && imagemBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imagemBytes))
                        {
                            pictureBox.Image = Image.FromStream(ms);
                        }
                    }

                    Label labelNome = new Label();
                    labelNome.Text = nomeLivro;
                    labelNome.AutoSize = true;
                    labelNome.Location = new Point(10, pictureBox.Bottom + 10);

                    groupBox.Controls.Add(pictureBox);
                    groupBox.Controls.Add(labelNome);

                    flowLayoutPanel1.Controls.Add(groupBox);
                }
            }

            else
            {
                CarregarLivrosDoBanco(); 
            }
        }
    }
}
