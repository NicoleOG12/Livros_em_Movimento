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
    public partial class Tela_Inicial : Form
    {
        private int idUsuario;
        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void Continuar_btn_Click(object sender, EventArgs e)
        {
            TipoLogin login = new TipoLogin();
            this.Hide();
            login.ShowDialog();
        }
    }
}
