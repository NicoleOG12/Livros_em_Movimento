﻿using MySql.Data.MySqlClient;
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
    public partial class Login : Form
    {
        private int idUsuario;

        public Login(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void Cadastro_btn(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro(idUsuario);
            this.Hide();
            cadastro.ShowDialog();
        }

        private void Logar_btn(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            try
            {
                dao.Conectar();

                string comandoSql = "SELECT id FROM usuarios WHERE email = @Email AND senha = @Senha";
                MySqlCommand cmd = new MySqlCommand(comandoSql, dao.Conectar());
                cmd.Parameters.AddWithValue("@Email", Email_Box.Text);
                cmd.Parameters.AddWithValue("@Senha", Senha_Box.Text);

                object idUsuario = cmd.ExecuteScalar();

                if (idUsuario != null)  
                {
                    int id = Convert.ToInt32(idUsuario);

                    Feed feed = new Feed(id);
                    this.Hide();
                    feed.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Email ou senha incorretos. Tente novamente.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao tentar logar: " + ex.Message);
            }
            finally
            {
                dao.Desconectar();
            }
        }
    }
}







