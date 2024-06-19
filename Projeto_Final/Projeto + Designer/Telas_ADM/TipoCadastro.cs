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
    public partial class TipoCadastro : Form
    {
        

        public TipoCadastro()
        {
            InitializeComponent();
        }

        private void Livro_btn_Click(object sender, EventArgs e)
        {
            CadastroLivrosGratuitos cadastroLivros = new CadastroLivrosGratuitos();
            this.Hide();
            cadastroLivros.ShowDialog();
        }

        private void Produto_btn_Click(object sender, EventArgs e)
        {
            CadastroProdutos cadastroProdutos = new CadastroProdutos();
            this.Hide();
            cadastroProdutos.ShowDialog();
        }

        private void LivrosVenda_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
