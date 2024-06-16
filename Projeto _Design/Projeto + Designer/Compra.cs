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
        private int idUsuario;
        public Compra(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.Conectar();

            try
            {
                string comandoSqlAtualizar = "UPDATE Usuarios SET cpf = @CPF, celular = @Celular " +
                                             "WHERE nome = @Nome AND email = @Email";
                MySqlCommand cmdAtualizar = new MySqlCommand(comandoSqlAtualizar, dao.Conectar());
                cmdAtualizar.Parameters.AddWithValue("@CPF", CPF_box.Text);
                cmdAtualizar.Parameters.AddWithValue("@Celular", Celular_Box.Text);
                cmdAtualizar.Parameters.AddWithValue("@Nome", Nome_box.Text);
                cmdAtualizar.Parameters.AddWithValue("@Email", Email_Box.Text);

                int linhasAtualizadas = cmdAtualizar.ExecuteNonQuery();

                if (linhasAtualizadas > 0)
                {
                    string comandoSqlVerificarUsuario = "SELECT id FROM Usuarios WHERE nome = @Nome AND email = @Email";
                    MySqlCommand cmdVerificarUsuario = new MySqlCommand(comandoSqlVerificarUsuario, dao.Conectar());
                    cmdVerificarUsuario.Parameters.AddWithValue("@Nome", Nome_box.Text);
                    cmdVerificarUsuario.Parameters.AddWithValue("@Email", Email_Box.Text);

                    var resultadoUsuario = cmdVerificarUsuario.ExecuteScalar();

                    if (resultadoUsuario != null)
                    {
                        int idUsuario = Convert.ToInt32(resultadoUsuario);

                        string comandoSqlProduto = "SELECT id FROM Produtos WHERE nome = @NomeProduto";
                        MySqlCommand cmdProduto = new MySqlCommand(comandoSqlProduto, dao.Conectar());
                        cmdProduto.Parameters.AddWithValue("@NomeProduto", NomedoProduto_Box.Text);

                        var resultadoProduto = cmdProduto.ExecuteReader();

                        if (resultadoProduto.Read())
                        {
                            int idProduto = Convert.ToInt32(resultadoProduto["id"]);

                            string comandoSqlPedido = "INSERT INTO Pedidos (idUsuario, idProduto, quantidade, forma_de_pagamento) " +
                                                      "VALUES (@IdUsuario, @IdProduto, @Quantidade, @FormaPagamento)";

                            using (MySqlCommand cmdPedido = new MySqlCommand(comandoSqlPedido, dao.Conectar()))
                            {
                                cmdPedido.Parameters.AddWithValue("@IdUsuario", idUsuario);
                                cmdPedido.Parameters.AddWithValue("@IdProduto", idProduto);
                                cmdPedido.Parameters.AddWithValue("@Quantidade", Quantidade.Text);
                                cmdPedido.Parameters.AddWithValue("@FormaPagamento", Forma_de_pagamento.Text);

                                cmdPedido.ExecuteNonQuery();
                            }

                            string comandoSqlEstoque = "UPDATE Produtos SET estoque = estoque - 1 WHERE id = @IdProduto";
                            using (MySqlCommand cmdEstoque = new MySqlCommand(comandoSqlEstoque, dao.Conectar()))
                            {
                                cmdEstoque.Parameters.AddWithValue("@IdProduto", idProduto);
                                cmdEstoque.ExecuteNonQuery();
                            }

                            Tela_Confirmação tela_Confirmação = new Tela_Confirmação(idUsuario);
                            this.Hide();
                            tela_Confirmação.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado. Verifique o nome do Produto fornecido.");
                        }

                        resultadoProduto.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado. Verifique os dados fornecidos.");
                    }

                }
                else
                {
                    MessageBox.Show("Falha ao atualizar CPF e celular do usuário.");
                }
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
            Troca_de_livros troca_De_Livros = new Troca_de_livros(idUsuario);
            troca_De_Livros.ShowDialog();
            this.Hide();
        }
    }
}
