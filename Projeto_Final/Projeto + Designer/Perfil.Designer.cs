﻿namespace Projeto___Designer
{
    partial class Perfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.Carrinho_Box = new System.Windows.Forms.PictureBox();
            this.Perfil_Box = new System.Windows.Forms.PictureBox();
            this.Sacola_Box = new System.Windows.Forms.PictureBox();
            this.Troca_de_livros_box = new System.Windows.Forms.PictureBox();
            this.fotoperfil = new System.Windows.Forms.PictureBox();
            this.Nome = new System.Windows.Forms.Label();
            this.nomeperfil = new System.Windows.Forms.TextBox();
            this.emailperfil = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.btn_fotoperfil = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Carrinho_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perfil_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sacola_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Troca_de_livros_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoperfil)).BeginInit();
            this.SuspendLayout();
            // 
            // Carrinho_Box
            // 
            this.Carrinho_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Carrinho_Box.Image = global::Projeto___Designer.Properties.Resources.Carrinho;
            this.Carrinho_Box.Location = new System.Drawing.Point(287, 354);
            this.Carrinho_Box.Name = "Carrinho_Box";
            this.Carrinho_Box.Size = new System.Drawing.Size(67, 74);
            this.Carrinho_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Carrinho_Box.TabIndex = 6;
            this.Carrinho_Box.TabStop = false;
            this.Carrinho_Box.Click += new System.EventHandler(this.Carrinho_Click);
            // 
            // Perfil_Box
            // 
            this.Perfil_Box.BackColor = System.Drawing.Color.Transparent;
            this.Perfil_Box.Image = global::Projeto___Designer.Properties.Resources.Perfil;
            this.Perfil_Box.Location = new System.Drawing.Point(392, 354);
            this.Perfil_Box.Name = "Perfil_Box";
            this.Perfil_Box.Size = new System.Drawing.Size(80, 74);
            this.Perfil_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Perfil_Box.TabIndex = 4;
            this.Perfil_Box.TabStop = false;
            this.Perfil_Box.Click += new System.EventHandler(this.Perfil_Click);
            // 
            // Sacola_Box
            // 
            this.Sacola_Box.BackColor = System.Drawing.Color.Transparent;
            this.Sacola_Box.Image = global::Projeto___Designer.Properties.Resources.Sacola;
            this.Sacola_Box.Location = new System.Drawing.Point(175, 354);
            this.Sacola_Box.Name = "Sacola_Box";
            this.Sacola_Box.Size = new System.Drawing.Size(76, 74);
            this.Sacola_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sacola_Box.TabIndex = 2;
            this.Sacola_Box.TabStop = false;
            this.Sacola_Box.Click += new System.EventHandler(this.Sacola_Click);
            // 
            // Troca_de_livros_box
            // 
            this.Troca_de_livros_box.BackColor = System.Drawing.Color.Transparent;
            this.Troca_de_livros_box.Image = global::Projeto___Designer.Properties.Resources.Troca_de_Livros;
            this.Troca_de_livros_box.Location = new System.Drawing.Point(61, 354);
            this.Troca_de_livros_box.Name = "Troca_de_livros_box";
            this.Troca_de_livros_box.Size = new System.Drawing.Size(77, 74);
            this.Troca_de_livros_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Troca_de_livros_box.TabIndex = 1;
            this.Troca_de_livros_box.TabStop = false;
            this.Troca_de_livros_box.Click += new System.EventHandler(this.Troca_de_livros_Click);
            // 
            // fotoperfil
            // 
            this.fotoperfil.Location = new System.Drawing.Point(182, 34);
            this.fotoperfil.Name = "fotoperfil";
            this.fotoperfil.Size = new System.Drawing.Size(122, 104);
            this.fotoperfil.TabIndex = 7;
            this.fotoperfil.TabStop = false;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.MediumPurple;
            this.Nome.Location = new System.Drawing.Point(214, 215);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(47, 17);
            this.Nome.TabIndex = 8;
            this.Nome.Text = "Nome:";
            // 
            // nomeperfil
            // 
            this.nomeperfil.Location = new System.Drawing.Point(122, 235);
            this.nomeperfil.Name = "nomeperfil";
            this.nomeperfil.Size = new System.Drawing.Size(250, 20);
            this.nomeperfil.TabIndex = 9;
            // 
            // emailperfil
            // 
            this.emailperfil.Location = new System.Drawing.Point(122, 308);
            this.emailperfil.Name = "emailperfil";
            this.emailperfil.Size = new System.Drawing.Size(250, 20);
            this.emailperfil.TabIndex = 10;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.MediumPurple;
            this.Email.Location = new System.Drawing.Point(214, 288);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(44, 17);
            this.Email.TabIndex = 11;
            this.Email.Text = "Email:";
            // 
            // btn_fotoperfil
            // 
            this.btn_fotoperfil.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_fotoperfil.Location = new System.Drawing.Point(182, 144);
            this.btn_fotoperfil.Name = "btn_fotoperfil";
            this.btn_fotoperfil.Size = new System.Drawing.Size(122, 23);
            this.btn_fotoperfil.TabIndex = 12;
            this.btn_fotoperfil.Text = "Anexar foto de perfil";
            this.btn_fotoperfil.UseVisualStyleBackColor = false;
            this.btn_fotoperfil.Click += new System.EventHandler(this.Anexar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(424, 12);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 13;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 445);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_fotoperfil);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.emailperfil);
            this.Controls.Add(this.nomeperfil);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.fotoperfil);
            this.Controls.Add(this.Carrinho_Box);
            this.Controls.Add(this.Perfil_Box);
            this.Controls.Add(this.Sacola_Box);
            this.Controls.Add(this.Troca_de_livros_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Perfil";
            this.Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.Carrinho_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perfil_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sacola_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Troca_de_livros_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoperfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Troca_de_livros_box;
        private System.Windows.Forms.PictureBox Sacola_Box;
        private System.Windows.Forms.PictureBox Perfil_Box;
        private System.Windows.Forms.PictureBox Carrinho_Box;
        private System.Windows.Forms.PictureBox fotoperfil;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox nomeperfil;
        private System.Windows.Forms.TextBox emailperfil;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button btn_fotoperfil;
        private System.Windows.Forms.Button btn_sair;
    }
}