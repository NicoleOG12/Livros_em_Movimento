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
    public partial class Como_Eu_Era_Antes_de_Você : Form
    {
        public Como_Eu_Era_Antes_de_Você()
        {
            InitializeComponent();
        }

        private void Comprar_agora_Click(object sender, EventArgs e)
        {

        }

        private void Adicionar_ao_carrinho_Click(object sender, EventArgs e)
        {
            Carrinho carrinho = new Carrinho();
            carrinho.ShowDialog();
            this.Close();
        }
    }
}
