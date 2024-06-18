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
    public partial class Tela_Confirmação : Form
    {
        private int idUsuario;
        public Tela_Confirmação(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            Troca_de_livros troca_De_Livros = new Troca_de_livros(idUsuario);
            this.Hide();
            troca_De_Livros.ShowDialog();
        }
    }
}
