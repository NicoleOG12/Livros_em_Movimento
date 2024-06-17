using MySql.Data.MySqlClient;
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
    public partial class Troca : Form
    {
        private int idUsuario;
        private string nomeLivro;

        public Troca(int idUsuario, string nomeLivro)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nomeLivro = nomeLivro;
            Nome_do_Livro_Box.Text = nomeLivro;
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            string nomeUsuario = Nome_txt.Text;
            string emailUsuario = Email_txt.Text;

            DAO dao = new DAO();
            dao.Conectar();

            if (dao.VerificarExistenciaUsuario(idUsuario))
            {
                int idLivro = dao.ObterIdLivroPeloNome(nomeLivro);

                if (idLivro != -1)
                {
                    try
                    {
                        byte[] imagemBytes = ImageToByteArray(ImagemLivro.Image);

                        string query = "INSERT INTO Troca (idUsuario, idLivro, nomeDoLivrodeTroca, imagem, dataDeSolicitacao) " +
                                       "VALUES (@idUsuario, @idLivro, @nomeLivro, @imagem, @dataDeSolicitacao)";

                        using (MySqlCommand cmd = new MySqlCommand(query, dao.Conectar()))
                        {
                            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                            cmd.Parameters.AddWithValue("@idLivro", idLivro);
                            cmd.Parameters.AddWithValue("@nomeLivro", Nome_do_Livro_Box.Text);
                            cmd.Parameters.AddWithValue("@imagem", imagemBytes);
                            cmd.Parameters.AddWithValue("@dataDeSolicitacao", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Troca solicitada com sucesso!");

                        Troca_de_livros troca_De_Livros = new Troca_de_livros(idUsuario);
                        this.Hide();
                        troca_De_Livros.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro ao solicitar troca: " + ex.Message);
                        MessageBox.Show("Ocorreu um erro ao solicitar a troca. Por favor, tente novamente.");
                    }
                    finally
                    {
                        dao.Desconectar();
                    }
                }
                else
                {
                    MessageBox.Show("Livro não encontrado. Verifique o nome do livro.");
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado. Verifique o nome e email informados.");
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Troca_de_livros troca_De_Livros = new Troca_de_livros(idUsuario);
            this.Hide();
            troca_De_Livros.ShowDialog();
        }

        private void Anexar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImagemLivro.Image = Image.FromFile(openFileDialog.FileName);
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
                byte[] imagemBytes = ImageToByteArray(ImagemLivro.Image);
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
