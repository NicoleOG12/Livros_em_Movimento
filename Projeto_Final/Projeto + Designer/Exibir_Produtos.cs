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
    public partial class Exibir_Produtos : Form
    {
        private int idUsuario;

        public Exibir_Produtos(int idUsuario, string nomeProduto)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.Nome_item_txt.Text = nomeProduto;
            this.ExibirProduto(nomeProduto);

        }

        private void ExibirProduto(string nomeProduto)
        {
            try
            {
                DAO dao = new DAO();
                dao.Conectar();

                string comandoSql = $"SELECT sinopse, estoque, preço, imagem FROM Produtos WHERE nome = '{nomeProduto}'";
                MySqlCommand cmd = new MySqlCommand(comandoSql, dao.Conectar());
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Descrição.Text = reader["sinopse"].ToString();
                    Número_de_itens_txt.Text = reader["estoque"].ToString();
                    Preço_txt.Text = reader["preço"].ToString();


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
                    MessageBox.Show($"Produto '{nomeProduto}' não encontrado.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do produto: " + ex.Message);
            }

        }

        public void Comprar_agora_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.Conectar();
            string comandoSql = $"Select id from Produto where nome= '{Nome_item_txt.Text}'";

            dao.Desconectar();
            Compra compra = new Compra(idUsuario, Nome_item_txt.Text, Quantidade_numericUpDown1.Bottom, Preço_txt.Text);
            this.Hide();
            compra.ShowDialog();
        }

        public void Adicionar_ao_carrinho_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.Conectar();

            try
            {
                if (dao.VerificarExistenciaUsuario(idUsuario))
                {
                    string nome = Nome_item_txt.Text;
                    int idProduto = dao.ObterIdProduto(nome);
                    int preco = Convert.ToInt32(Preço_txt.Text);

                    if (idProduto != -1)
                    {
                        string comandoSql = "INSERT INTO Carrinho (idUsuario, idProduto, quantidade, valor) " +
                                            "VALUES (@IdUsuario, @IdProduto, @Quantidade, @Valor)";

                        using (MySqlCommand cmd = new MySqlCommand(comandoSql, dao.Conectar()))
                        {
                            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                            cmd.Parameters.AddWithValue("@IdProduto", idProduto);
                            cmd.Parameters.AddWithValue("@Quantidade", Quantidade_numericUpDown1.Text);
                            cmd.Parameters.AddWithValue("@Valor", Preço_txt.Text);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Pedido adicionado ao carrinho com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show($"Livro '{nome}' não encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar pedido ao carrinho: " + ex.Message);
            }
            finally
            {
                dao.Desconectar();
            }
        }

        public void Seta_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja(idUsuario);
            this.Hide();
            loja.ShowDialog();

        }
    }
}
