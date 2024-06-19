using MySql.Data.MySqlClient;
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
    public partial class Exibir_Livros : Form
    {
        private int idUsuario;

        public Exibir_Livros(int idUsuario, string nomeLivro)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.Nome_item_txt.Text = nomeLivro;
            this.ExibirLivros(nomeLivro);

        }

        private void ExibirLivros(string nomeLivro)
        {
            try
            {
                DAO dao = new DAO();
                dao.Conectar();

                string comandoSql = $"SELECT sinopse, estoque, imagem FROM Livros WHERE nome = '{nomeLivro}'";
                MySqlCommand cmd = new MySqlCommand(comandoSql, dao.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Descrição.Text = reader["sinopse"].ToString();
               

                    byte[] imagemBytes = (byte[])reader["imagem"];
                    if (imagemBytes != null && imagemBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imagemBytes))
                        {
                            Imagem1.Image = Image.FromStream(ms);
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Livro '{nomeLivro}' não encontrado.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do livro: " + ex.Message);
            }

        }

        public void Comprar_agora_Click(object sender, EventArgs e)
        {

            Empréstimo compra = new Empréstimo(idUsuario, Nome_item_txt.Text);
            this.Hide();
            compra.ShowDialog();
        }

        public void Adicionar_ao_carrinho_Click(object sender, EventArgs e)
        {
            Troca troca = new Troca(idUsuario, Nome_item_txt.Text);
            this.Hide();
            troca.ShowDialog();
        }

        public void Seta_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja(idUsuario);
            this.Hide();
            loja.ShowDialog();

        }
    }
}
