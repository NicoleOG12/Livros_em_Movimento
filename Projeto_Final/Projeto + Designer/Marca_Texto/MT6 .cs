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
    public partial class MT6 : Form
    {
        private int idUsuario;
        public MT6()
        {
            InitializeComponent();
        }

        public void Comprar_agora_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.Conectar();
            string comandoSql = $"Select id from Produtos where nome= '{Nome_item_txt.Text}'";

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

                    if (idProduto != -1)
                    {
                        string comandoSql = "INSERT INTO Carrinho (idUsuario, idProduto, quantidade) " +
                                            "VALUES (@IdUsuario, @IdProduto, @Quantidade)";

                        using (MySqlCommand cmd = new MySqlCommand(comandoSql, dao.Conectar()))
                        {
                            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                            cmd.Parameters.AddWithValue("@IdProduto", idProduto);
                            cmd.Parameters.AddWithValue("@Quantidade", Quantidade_numericUpDown1.Text);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Pedido adicionado ao carrinho com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show($"Marca Texto '{nome}' não encontrado.");
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
            Loja_MarcaTexto loja_MT = new Loja_MarcaTexto(idUsuario);
            this.Hide();
            loja_MT.ShowDialog();

        }
    }
}