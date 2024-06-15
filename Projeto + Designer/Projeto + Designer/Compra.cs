using MySql.Data.MySqlClient;
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
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        public int id;
        private void Confirmar_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.Conectar();

            try
            {
                string comandoSql = "INSERT INTO Pedidos (nome, cpf, celular, email, nome_do_livro, quantidade, forma_de_pagamento) " +
                                    "VALUES (@Nome, @CPF, @Celular, @Email, @NomeLivro, @Quantidade, @FormaPagamento)";

                using (MySqlCommand cmd = new MySqlCommand(comandoSql, dao.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@Nome", Nome_box.Text);
                    cmd.Parameters.AddWithValue("@CPF", CPF_box.Text);
                    cmd.Parameters.AddWithValue("@Celular", Celular_Box.Text);
                    cmd.Parameters.AddWithValue("@Email", Email_Box.Text);
                    cmd.Parameters.AddWithValue("@NomeLivro", NomedoLivro_Box.Text);
                    cmd.Parameters.AddWithValue("@Quantidade", Quantidade.Text);
                    cmd.Parameters.AddWithValue("@FormaPagamento", Forma_de_pagamento.Text);

                    cmd.ExecuteNonQuery();
                }

                string comandoSqlEstoque = "UPDATE Produtos SET estoque = estoque - 1 WHERE id = @IdProduto";
                using (MySqlCommand cmdEstoque = new MySqlCommand(comandoSqlEstoque, dao.Conectar()))
                {
                    cmdEstoque.Parameters.AddWithValue("@IdProduto", id);
                    cmdEstoque.ExecuteNonQuery();
                }

                dao.FinalizarCompra(id);

                Tela_Confirmação tela_Confirmação = new Tela_Confirmação();
                this.Hide();
                tela_Confirmação.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao finalizar compra: " + ex.Message);
            }
            finally
            {
                dao.Desconectar();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Troca_de_livros troca_De_Livros = new Troca_de_livros();
            troca_De_Livros.ShowDialog();
            this.Hide();
        }
    }
}
