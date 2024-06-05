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
            this.caixa_generos = new System.Windows.Forms.CheckedListBox();
            this.generos_txt = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.Label();
            this.senha_txt = new System.Windows.Forms.Label();
            this.nome_box = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.senha_box = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadastro_txt
            // 
            this.cadastro_txt.AutoSize = true;
            this.cadastro_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadastro_txt.Location = new System.Drawing.Point(414, 59);
            this.cadastro_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cadastro_txt.Name = "cadastro_txt";
            this.cadastro_txt.Size = new System.Drawing.Size(133, 31);
            this.cadastro_txt.TabIndex = 0;
            this.cadastro_txt.Text = "Cadastro";
            this.cadastro_txt.Click += new System.EventHandler(this.cadastro_txt_Click);
            // 
            // nome_txt
            // 
            this.nome_txt.AutoSize = true;
            this.nome_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nome_txt.Location = new System.Drawing.Point(304, 132);
            this.nome_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nome_txt.Name = "nome_txt";
            this.nome_txt.Size = new System.Drawing.Size(49, 17);
            this.nome_txt.TabIndex = 1;
            this.nome_txt.Text = "Nome:";
            this.nome_txt.Click += new System.EventHandler(this.nome_txt_Click);
            // 
            // caixa_generos
            // 
            this.caixa_generos.BackColor = System.Drawing.SystemColors.Menu;
            this.caixa_generos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa_generos.FormattingEnabled = true;
            this.caixa_generos.Items.AddRange(new object[] {
            "Comédia",
            "Drama",
            "Ficção",
            "Romance",
            "Outros"});
            this.caixa_generos.Location = new System.Drawing.Point(420, 293);
            this.caixa_generos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.caixa_generos.Name = "caixa_generos";
            this.caixa_generos.Size = new System.Drawing.Size(139, 79);
            this.caixa_generos.TabIndex = 2;
            this.caixa_generos.SelectedIndexChanged += new System.EventHandler(this.caixa_generos_SelectedIndexChanged);
            // 
            // generos_txt
            // 
            this.generos_txt.AutoSize = true;
            this.generos_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generos_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.generos_txt.Location = new System.Drawing.Point(386, 270);
            this.generos_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.generos_txt.Name = "generos_txt";
            this.generos_txt.Size = new System.Drawing.Size(196, 20);
            this.generos_txt.TabIndex = 3;
            this.generos_txt.Text = "Gêneros de seu interesse:";
            this.generos_txt.Click += new System.EventHandler(this.generos_txt_Click);
            // 
            // email_txt
            // 
            this.email_txt.AutoSize = true;
            this.email_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.email_txt.Location = new System.Drawing.Point(308, 174);
            this.email_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(46, 17);
            this.email_txt.TabIndex = 4;
            this.email_txt.Text = "Email:";
            this.email_txt.Click += new System.EventHandler(this.email_txt_Click);
            // 
            // senha_txt
            // 
            this.senha_txt.AutoSize = true;
            this.senha_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.senha_txt.Location = new System.Drawing.Point(304, 217);
            this.senha_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.senha_txt.Name = "senha_txt";
            this.senha_txt.Size = new System.Drawing.Size(53, 17);
            this.senha_txt.TabIndex = 5;
            this.senha_txt.Text = "Senha:";
            this.senha_txt.Click += new System.EventHandler(this.senha_txt_Click);
            // 
            // nome_box
            // 
            this.nome_box.Location = new System.Drawing.Point(368, 132);
            this.nome_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nome_box.Name = "nome_box";
            this.nome_box.Size = new System.Drawing.Size(266, 20);
            this.nome_box.TabIndex = 6;
            this.nome_box.TextChanged += new System.EventHandler(this.nome_box_TextChanged);
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(369, 174);
            this.email_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(265, 20);
            this.email_box.TabIndex = 7;
            // 
            // senha_box
            // 
            this.senha_box.Location = new System.Drawing.Point(368, 217);
            this.senha_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.senha_box.Name = "senha_box";
            this.senha_box.Size = new System.Drawing.Size(266, 20);
            this.senha_box.TabIndex = 8;
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.SlateBlue;
            this.btncadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncadastrar.Location = new System.Drawing.Point(414, 394);
            this.btncadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(145, 34);
            this.btncadastrar.TabIndex = 9;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.senha_box);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.nome_box);
            this.Controls.Add(this.senha_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.generos_txt);
            this.Controls.Add(this.caixa_generos);
            this.Controls.Add(this.nome_txt);
            this.Controls.Add(this.cadastro_txt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cadastro_txt;
        private System.Windows.Forms.Label nome_txt;
        private System.Windows.Forms.CheckedListBox caixa_generos;
        private System.Windows.Forms.Label generos_txt;
        private System.Windows.Forms.Label email_txt;
        private System.Windows.Forms.Label senha_txt;
        private System.Windows.Forms.TextBox nome_box;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox senha_box;
        private System.Windows.Forms.Button btncadastrar;
    }
}