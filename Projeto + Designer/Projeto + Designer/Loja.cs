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
    public partial class Tela_Principal : Form
    {
        public Tela_Principal()
        {
            InitializeComponent();
            Image image = new Bitmap("C:/Users/Tecnico/Downloads/Projeto/lupa (2).jpg");
            pb_teste.Image = image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
