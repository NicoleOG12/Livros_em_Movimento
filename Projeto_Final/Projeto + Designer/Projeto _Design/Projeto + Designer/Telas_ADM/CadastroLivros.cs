﻿using MySql.Data.MySqlClient;
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
    public partial class CadastroLivros : Form
    {
        public CadastroLivros()
        {
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {

            DAO dao = new DAO();
            dao.Conectar();

            try
            {
                byte[] imagemBytes = ImageToByteArray(ImagemLivro.Image);

                string query = "INSERT INTO Produtos (nome, autor, sinopse, estoque, preço, imagem) " +
                               "VALUES (@Nome, @Autor, @Sinopse, @Estoque, @Preço, @Imagem)";

                using (MySqlCommand cmd = new MySqlCommand(query, dao.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@Nome", Nome_do_Livro_Box );
                    cmd.Parameters.AddWithValue("@Autor", Autor_box );
                    cmd.Parameters.AddWithValue("@Sinopse", Sinopse_Box);
                    cmd.Parameters.AddWithValue("@Estoque", Quantidade);
                    cmd.Parameters.AddWithValue("@Preço", Preço_Box);
                    cmd.Parameters.AddWithValue("@Imagem", imagemBytes);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Livro cadastrado com sucesso!");

                ConfirmaçãoCadastro confirmaçãoCadastro = new ConfirmaçãoCadastro();
                this.Hide();
                confirmaçãoCadastro.ShowDialog();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar livro: " + ex.Message);
                MessageBox.Show("Ocorreu um erro ao cadastrar o livro. Por favor, tente novamente.");
            }
            finally
            {
                dao.Desconectar();
            }
        }
          
        private void Cancelar_Click(object sender, EventArgs e)
        {
            TipoCadastro tipoCadastro = new TipoCadastro();
            this.Hide();
            tipoCadastro.ShowDialog();
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

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}