﻿namespace Projeto___Designer
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.senha_box = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.senha_txt = new System.Windows.Forms.Label();
            this.Login_txt = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.caixalogin = new System.Windows.Forms.GroupBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.email_txt = new System.Windows.Forms.Label();
            this.caixalogin2 = new System.Windows.Forms.GroupBox();
            this.semcadastro_txt = new System.Windows.Forms.Label();
            this.caixalogin.SuspendLayout();
            this.caixalogin2.SuspendLayout();
            this.SuspendLayout();
            // 
            // senha_box
            // 
            this.senha_box.BackColor = System.Drawing.SystemColors.Menu;
            this.senha_box.Location = new System.Drawing.Point(71, 157);
            this.senha_box.Margin = new System.Windows.Forms.Padding(2);
            this.senha_box.Name = "senha_box";
            this.senha_box.Size = new System.Drawing.Size(173, 20);
            this.senha_box.TabIndex = 0;
            // 
            // email_box
            // 
            this.email_box.BackColor = System.Drawing.SystemColors.Menu;
            this.email_box.Location = new System.Drawing.Point(71, 104);
            this.email_box.Margin = new System.Windows.Forms.Padding(2);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(173, 20);
            this.email_box.TabIndex = 1;
            this.email_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // senha_txt
            // 
            this.senha_txt.AutoSize = true;
            this.senha_txt.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.senha_txt.Location = new System.Drawing.Point(68, 138);
            this.senha_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.senha_txt.Name = "senha_txt";
            this.senha_txt.Size = new System.Drawing.Size(66, 17);
            this.senha_txt.TabIndex = 3;
            this.senha_txt.Text = "Sua senha";
            // 
            // Login_txt
            // 
            this.Login_txt.AutoSize = true;
            this.Login_txt.Font = new System.Drawing.Font("MV Boli", 15.16F, System.Drawing.FontStyle.Bold);
            this.Login_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.Login_txt.Location = new System.Drawing.Point(114, 25);
            this.Login_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login_txt.Name = "Login_txt";
            this.Login_txt.Size = new System.Drawing.Size(68, 28);
            this.Login_txt.TabIndex = 4;
            this.Login_txt.Text = "Login";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_cadastrar.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.MediumPurple;
            this.btn_cadastrar.Location = new System.Drawing.Point(193, 13);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(84, 25);
            this.btn_cadastrar.TabIndex = 5;
            this.btn_cadastrar.Text = "Cadastre-se";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.cadastrarUsuario);
            // 
            // caixalogin
            // 
            this.caixalogin.BackColor = System.Drawing.Color.GhostWhite;
            this.caixalogin.Controls.Add(this.Login_btn);
            this.caixalogin.Controls.Add(this.email_txt);
            this.caixalogin.Controls.Add(this.Login_txt);
            this.caixalogin.Controls.Add(this.senha_txt);
            this.caixalogin.Controls.Add(this.email_box);
            this.caixalogin.Controls.Add(this.senha_box);
            this.caixalogin.Location = new System.Drawing.Point(258, 71);
            this.caixalogin.Name = "caixalogin";
            this.caixalogin.Size = new System.Drawing.Size(302, 244);
            this.caixalogin.TabIndex = 7;
            this.caixalogin.TabStop = false;
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.MediumPurple;
            this.Login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Login_btn.CausesValidation = false;
            this.Login_btn.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_btn.Location = new System.Drawing.Point(73, 204);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(158, 34);
            this.Login_btn.TabIndex = 6;
            this.Login_btn.Text = "Logar";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Logar);
            // 
            // email_txt
            // 
            this.email_txt.AutoSize = true;
            this.email_txt.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.email_txt.Location = new System.Drawing.Point(70, 85);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(64, 17);
            this.email_txt.TabIndex = 5;
            this.email_txt.Text = "Seu email";
            // 
            // caixalogin2
            // 
            this.caixalogin2.BackColor = System.Drawing.Color.MediumPurple;
            this.caixalogin2.Controls.Add(this.semcadastro_txt);
            this.caixalogin2.Controls.Add(this.btn_cadastrar);
            this.caixalogin2.Location = new System.Drawing.Point(258, 315);
            this.caixalogin2.Name = "caixalogin2";
            this.caixalogin2.Size = new System.Drawing.Size(302, 48);
            this.caixalogin2.TabIndex = 8;
            this.caixalogin2.TabStop = false;
            // 
            // semcadastro_txt
            // 
            this.semcadastro_txt.AutoSize = true;
            this.semcadastro_txt.BackColor = System.Drawing.Color.MediumPurple;
            this.semcadastro_txt.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semcadastro_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.semcadastro_txt.Location = new System.Drawing.Point(7, 16);
            this.semcadastro_txt.Name = "semcadastro_txt";
            this.semcadastro_txt.Size = new System.Drawing.Size(175, 17);
            this.semcadastro_txt.TabIndex = 6;
            this.semcadastro_txt.Text = "Ainda não possui uma conta?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImage = global::Projeto___Designer.Properties.Resources._3d_background_purple_background_abstract_background_windows_2560x1080_8292;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 423);
            this.Controls.Add(this.caixalogin2);
            this.Controls.Add(this.caixalogin);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.caixalogin.ResumeLayout(false);
            this.caixalogin.PerformLayout();
            this.caixalogin2.ResumeLayout(false);
            this.caixalogin2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox senha_box;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.Label senha_txt;
        private System.Windows.Forms.Label Login_txt;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.GroupBox caixalogin;
        private System.Windows.Forms.Label email_txt;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.GroupBox caixalogin2;
        private System.Windows.Forms.Label semcadastro_txt;
    }
}
