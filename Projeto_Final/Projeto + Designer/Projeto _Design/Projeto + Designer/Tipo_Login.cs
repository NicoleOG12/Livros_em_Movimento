using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto___Designer
{
    public partial class TipoLogin : Form
    {
        public int idUsuario;

        public TipoLogin()
        {
            InitializeComponent();
        }

        private void Usuário_btn_Click(object sender, EventArgs e)
        {
            Login login= new Login(idUsuario);
            this.Hide();
            login.ShowDialog();
        }

        private void ADM_Click(object sender, EventArgs e)
        {
            LoginADM login= new LoginADM();
            this.Hide();
            login.ShowDialog();
        }
    }
}







