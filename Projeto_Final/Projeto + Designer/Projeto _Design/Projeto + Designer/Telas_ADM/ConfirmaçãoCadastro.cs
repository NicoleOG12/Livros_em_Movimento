﻿using System;
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
    public partial class ConfirmaçãoCadastro : Form
    {
        public ConfirmaçãoCadastro()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            TipoCadastro tipocadastro = new TipoCadastro();
            this.Hide();
            tipocadastro.ShowDialog();
        }
    }
}
