﻿using MySql.Data.MySqlClient;
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
    public partial class A_Garota_do_Lago : Form
    {
        private int idUsuario;
        public A_Garota_do_Lago(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        public void Comprar_agora_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.Conectar();
            string comandoSql = $"Select id from Produto where nome= '{Nome_item_txt.Text}'";

            dao.Desconectar();
            Compra compra = new Compra(idUsuario, Nome_item_txt.Text, Preço_txt.Text, Quantidade_numericUpDown1.Bottom);
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
            Loja_Livros loja_Livros = new Loja_Livros(idUsuario);
            this.Hide();
            loja_Livros.ShowDialog();

        }
    }
}