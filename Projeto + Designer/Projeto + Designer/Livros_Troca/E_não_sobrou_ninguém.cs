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
    public partial class E_não_sobrou_ninguém : Form
    {
        public E_não_sobrou_ninguém()
        {
            InitializeComponent();
        }

        private void Adicionar_ao_carrinho_Click(object sender, EventArgs e)
        {
            Carrinho carrinho = new Carrinho();
            carrinho.ShowDialog();
            this.Close();
        }

        private void Solicitar_empréstimo_Click(object sender, EventArgs e)
        {

        }

        private void Solicitar_Troca_Click(object sender, EventArgs e)
        {

        }
    }
}
