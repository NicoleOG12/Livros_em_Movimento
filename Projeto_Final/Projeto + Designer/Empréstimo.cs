using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto___Designer
{
    public partial class Empréstimo : Form
    {
        private int idUsuario;
        private string nomeLivro;

        public Empréstimo(int idUsuario, string nomeLivro)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.nomeLivro = nomeLivro;
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.Conectar();

            try
            {
                if (dao.VerificarExistenciaUsuario(idUsuario))
                {
                    int idLivro = dao.ObterIdLivroPeloNome(nomeLivro);

                    if (idLivro != -1)
                    {
                        dao.SolicitarEmprestimo(idUsuario, idLivro);

                        MessageBox.Show("Empréstimo solicitado com sucesso!");

                        Tela_Confirmação telaConfirmacao = new Tela_Confirmação(idUsuario);
                        this.Hide();
                        telaConfirmacao.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Livro não encontrado. Verifique o nome do livro.");
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado. Verifique o ID do usuário.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao solicitar empréstimo: " + ex.Message);
            }
            finally
            {
                dao.Desconectar();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Troca_de_livros troca_De_Livros = new Troca_de_livros(idUsuario);
            this.Hide();
            troca_De_Livros.ShowDialog();
        }
    }
}
