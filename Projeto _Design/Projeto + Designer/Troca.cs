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
    public partial class Troca : Form
    {
        private int idUsuario;
        public Troca(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            Tela_Confirmação tela_Confirmação = new Tela_Confirmação(idUsuario);
            this.Hide();
            tela_Confirmação.ShowDialog();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Troca_de_livros troca_De_Livros = new Troca_de_livros(idUsuario);
            this.Hide();
            troca_De_Livros.ShowDialog();
        }
    }
}
