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
                string comandoSqlUsuario = "SELECT id FROM Usuarios WHERE nome = @Nome AND cpf = @CPF AND celular = @Celular AND email = @Email";
                MySqlCommand cmdUsuario = new MySqlCommand(comandoSqlUsuario, dao.Conectar());
                cmdUsuario.Parameters.AddWithValue("@Nome", Nome_box.Text);
                cmdUsuario.Parameters.AddWithValue("@CPF", CPF_box.Text);
                cmdUsuario.Parameters.AddWithValue("@Celular", Celular_Box.Text);
                cmdUsuario.Parameters.AddWithValue("@Email", Email_Box.Text);

                var resultadoUsuario = cmdUsuario.ExecuteReader();

                if (resultadoUsuario.Read())
                {
                    int idUsuario = Convert.ToInt32(resultadoUsuario["id"]);

                    string comandoSqlLivro = "SELECT id FROM Livros WHERE nome = @NomeLivro";
                    MySqlCommand cmdLivro = new MySqlCommand(comandoSqlLivro, dao.Conectar());
                    cmdLivro.Parameters.AddWithValue("@NomeLivro", NomedoLivro_Box.Text);

                    var resultadoLivro = cmdLivro.ExecuteReader();

                    if (resultadoLivro.Read())
                    {
                        int idLivro = Convert.ToInt32(resultadoLivro["id"]);

                        string comandoSqlPedido = "INSERT INTO Pedidos (idUsuario, idProduto, quantidade, forma_de_pagamento) " +
                                                  "VALUES (@IdUsuario, @IdLivro, @Quantidade, @FormaPagamento)";

                        using (MySqlCommand cmdPedido = new MySqlCommand(comandoSqlPedido, dao.Conectar()))
                        {
                            cmdPedido.Parameters.AddWithValue("@IdUsuario", idUsuario);
                            cmdPedido.Parameters.AddWithValue("@IdLivro", idLivro);
                            cmdPedido.Parameters.AddWithValue("@Quantidade",Quantidade.Text);
                            cmdPedido.Parameters.AddWithValue("@FormaPagamento", Forma_de_pagamento.Text);

                            cmdPedido.ExecuteNonQuery();
                        }

                        string comandoSqlEstoque = "UPDATE Livros SET estoque = estoque - 1 WHERE id = @IdLivro";
                        using (MySqlCommand cmdEstoque = new MySqlCommand(comandoSqlEstoque, dao.Conectar()))
                        {
                            cmdEstoque.Parameters.AddWithValue("@IdLivro", idLivro);
                            cmdEstoque.ExecuteNonQuery();
                        }

                        Tela_Confirmação tela_Confirmação = new Tela_Confirmação(idUsuario);
                        this.Hide();
                        tela_Confirmação.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Livro não encontrado. Verifique o nome do livro fornecido.");
                    }

                    resultadoLivro.Close();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado. Verifique os dados fornecidos.");
                }

                resultadoUsuario.Close();
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
