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
        private int idUsuario;
        private string nomeLivro;
        public E_não_sobrou_ninguém()
        {
            InitializeComponent();
        }

        private void Solicitar_empréstimo_Click(object sender, EventArgs e)
        {
            Empréstimo empréstimo = new Empréstimo(idUsuario, nomeLivro);
            empréstimo.ShowDialog();
            this.Hide();
        }

        private void Solicitar_Troca_Click(object sender, EventArgs e)
        {
            Troca troca = new Troca(idUsuario, nomeLivro);
            troca.ShowDialog();
            this.Hide();
        }

        private void Seta_Click(object sender, EventArgs e)
        {
            Troca_de_livros troca_De_Livros = new Troca_de_livros(idUsuario);
            troca_De_Livros.ShowDialog();
            this.Hide();
        }
    }
}
