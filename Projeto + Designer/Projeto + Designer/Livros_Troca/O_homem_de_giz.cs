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
    public partial class O_homem_de_giz : Form
    {
        public O_homem_de_giz()
        {
            InitializeComponent();
        }

        private void Solicitar_Troca_Click(object sender, EventArgs e)
        {
            Troca troca = new Troca();
            troca.ShowDialog();
            this.Close();
        }

        private void Solicitar_empréstimo_Click(object sender, EventArgs e)
        {
            Empréstimo empréstimo = new Empréstimo();
            empréstimo.ShowDialog();
            this.Close();
        }

        private void Seta_Click(object sender, EventArgs e)
        {
            Troca_de_livros troca_De_Livros = new Troca_de_livros();
            troca_De_Livros.ShowDialog();
            this.Close();
        }
    }
}
