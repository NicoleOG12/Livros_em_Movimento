namespace Projeto___Designer
{
    partial class Cadastro
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
            this.cadastro_txt = new System.Windows.Forms.Label();
            this.nome_txt = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.Label();
            this.senha_txt = new System.Windows.Forms.Label();
            this.nome_box = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.senha_box = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.generoInteresse = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastro_txt
            // 
            this.cadastro_txt.AutoSize = true;
            this.cadastro_txt.BackColor = System.Drawing.Color.Transparent;
            this.cadastro_txt.Font = new System.Drawing.Font("MV Boli", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.cadastro_txt.Location = new System.Drawing.Point(136, 16);
            this.cadastro_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cadastro_txt.Name = "cadastro_txt";
            this.cadastro_txt.Size = new System.Drawing.Size(131, 34);
            this.cadastro_txt.TabIndex = 0;
            this.cadastro_txt.Text = "Cadastro";
            this.cadastro_txt.Click += new System.EventHandler(this.cadastro_txt_Click);
            // 
            // nome_txt
            // 
            this.nome_txt.AutoSize = true;
            this.nome_txt.BackColor = System.Drawing.Color.GhostWhite;
            this.nome_txt.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.nome_txt.Location = new System.Drawing.Point(65, 62);
            this.nome_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nome_txt.Name = "nome_txt";
            this.nome_txt.Size = new System.Drawing.Size(47, 17);
            this.nome_txt.TabIndex = 1;
            this.nome_txt.Text = "Nome:";
            this.nome_txt.Click += new System.EventHandler(this.nome_txt_Click);
            // 
            // email_txt
            // 
            this.email_txt.AutoSize = true;
            this.email_txt.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.email_txt.Location = new System.Drawing.Point(65, 119);
            this.email_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(44, 17);
            this.email_txt.TabIndex = 4;
            this.email_txt.Text = "Email:";
            this.email_txt.Click += new System.EventHandler(this.email_txt_Click);
            // 
            // senha_txt
            // 
            this.senha_txt.AutoSize = true;
            this.senha_txt.BackColor = System.Drawing.Color.Transparent;
            this.senha_txt.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.senha_txt.Location = new System.Drawing.Point(65, 176);
            this.senha_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.senha_txt.Name = "senha_txt";
            this.senha_txt.Size = new System.Drawing.Size(47, 17);
            this.senha_txt.TabIndex = 5;
            this.senha_txt.Text = "Senha:";
            this.senha_txt.Click += new System.EventHandler(this.senha_txt_Click);
            // 
            // nome_box
            // 
            this.nome_box.BackColor = System.Drawing.SystemColors.Menu;
            this.nome_box.Location = new System.Drawing.Point(68, 82);
            this.nome_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nome_box.Name = "nome_box";
            this.nome_box.Size = new System.Drawing.Size(266, 20);
            this.nome_box.TabIndex = 6;
            this.nome_box.TextChanged += new System.EventHandler(this.nome_box_TextChanged);
            // 
            // email_box
            // 
            this.email_box.BackColor = System.Drawing.SystemColors.Menu;
            this.email_box.Location = new System.Drawing.Point(68, 139);
            this.email_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(266, 20);
            this.email_box.TabIndex = 7;
            // 
            // senha_box
            // 
            this.senha_box.BackColor = System.Drawing.SystemColors.Menu;
            this.senha_box.Location = new System.Drawing.Point(68, 196);
            this.senha_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.senha_box.Name = "senha_box";
            this.senha_box.Size = new System.Drawing.Size(266, 20);
            this.senha_box.TabIndex = 8;
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.MediumPurple;
            this.btncadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncadastrar.Location = new System.Drawing.Point(142, 278);
            this.btncadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(145, 34);
            this.btncadastrar.TabIndex = 9;
            this.btncadastrar.Text = "Entrar\r\n";
            this.btncadastrar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.btncadastrar);
            this.groupBox1.Controls.Add(this.generoInteresse);
            this.groupBox1.Controls.Add(this.nome_txt);
            this.groupBox1.Controls.Add(this.email_box);
            this.groupBox1.Controls.Add(this.cadastro_txt);
            this.groupBox1.Controls.Add(this.senha_box);
            this.groupBox1.Controls.Add(this.nome_box);
            this.groupBox1.Controls.Add(this.email_txt);
            this.groupBox1.Controls.Add(this.senha_txt);
            this.groupBox1.Location = new System.Drawing.Point(349, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 318);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox2.Location = new System.Drawing.Point(28, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 317);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // generoInteresse
            // 
            this.generoInteresse.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generoInteresse.ForeColor = System.Drawing.Color.MediumPurple;
            this.generoInteresse.FormattingEnabled = true;
            this.generoInteresse.Items.AddRange(new object[] {
            "Comédia",
            "Drama",
            "Ficção",
            "Romance",
            "Outros"});
            this.generoInteresse.Location = new System.Drawing.Point(68, 235);
            this.generoInteresse.Name = "generoInteresse";
            this.generoInteresse.Size = new System.Drawing.Size(156, 24);
            this.generoInteresse.TabIndex = 10;
            this.generoInteresse.Text = "Gênero de interesse";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 416);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cadastro_txt;
        private System.Windows.Forms.Label nome_txt;
        private System.Windows.Forms.Label email_txt;
        private System.Windows.Forms.Label senha_txt;
        private System.Windows.Forms.TextBox nome_box;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox senha_box;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox generoInteresse;
    }
}