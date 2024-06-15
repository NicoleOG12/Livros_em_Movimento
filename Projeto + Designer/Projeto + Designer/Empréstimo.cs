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
    public partial class Empréstimo : Form
    {
        public Empréstimo()
        {
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.SolicitarEmprestimo();
            Tela_Confirmação tela_Confirmação = new Tela_Confirmação();
            tela_Confirmação.ShowDialog();
            this.Hide();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Troca_de_livros troca_De_Livros = new Troca_de_livros();
            troca_De_Livros.ShowDialog();
            this.Hide();
        }
    }
}
