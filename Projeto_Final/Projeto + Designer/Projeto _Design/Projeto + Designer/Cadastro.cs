﻿using System;
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
    public partial class Cadastro : Form
    {
        private int idUsuario;
        public Cadastro(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void Entrar(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            dao.Conectar();
            string comandoSql = $"Insert into Usuarios (nome, email, senha) values ('{Nome_box.Text}', '{Email_box.Text}','{Senha_box.Text}')";
            dao.ExecutarComando(comandoSql);
            dao.Desconectar();
            Troca_de_livros troca_de_livros = new Troca_de_livros(idUsuario);
            this.Hide();
            troca_de_livros.ShowDialog();
        }
    }
   
}


