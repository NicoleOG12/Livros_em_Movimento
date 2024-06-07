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
            this.Cadastro_txt = new System.Windows.Forms.Label();
            this.Nome_txt = new System.Windows.Forms.Label();
            this.Email_txt = new System.Windows.Forms.Label();
            this.Senha_txt = new System.Windows.Forms.Label();
            this.Nome_box = new System.Windows.Forms.TextBox();
            this.Email_box = new System.Windows.Forms.TextBox();
            this.Senha_box = new System.Windows.Forms.TextBox();
            this.Cadastrar_btn = new System.Windows.Forms.Button();
            this.CaixaBranca = new System.Windows.Forms.GroupBox();
            this.GeneroInteresse = new System.Windows.Forms.ComboBox();
            this.CaixaRoxa = new System.Windows.Forms.GroupBox();
            this.CaixaBranca.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cadastro_txt
            // 
            this.Cadastro_txt.AutoSize = true;
            this.Cadastro_txt.BackColor = System.Drawing.Color.Transparent;
            this.Cadastro_txt.Font = new System.Drawing.Font("MV Boli", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastro_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.Cadastro_txt.Location = new System.Drawing.Point(136, 16);
            this.Cadastro_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cadastro_txt.Name = "Cadastro_txt";
            this.Cadastro_txt.Size = new System.Drawing.Size(131, 34);
            this.Cadastro_txt.TabIndex = 0;
            this.Cadastro_txt.Text = "Cadastro";
            // 
            // Nome_txt
            // 
            this.Nome_txt.AutoSize = true;
            this.Nome_txt.BackColor = System.Drawing.Color.GhostWhite;
            this.Nome_txt.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.Nome_txt.Location = new System.Drawing.Point(65, 62);
            this.Nome_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nome_txt.Name = "Nome_txt";
            this.Nome_txt.Size = new System.Drawing.Size(47, 17);
            this.Nome_txt.TabIndex = 1;
            this.Nome_txt.Text = "Nome:";
            // 
            // Email_txt
            // 
            this.Email_txt.AutoSize = true;
            this.Email_txt.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.Email_txt.Location = new System.Drawing.Point(65, 119);
            this.Email_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(44, 17);
            this.Email_txt.TabIndex = 4;
            this.Email_txt.Text = "Email:";
            // 
            // Senha_txt
            // 
            this.Senha_txt.AutoSize = true;
            this.Senha_txt.BackColor = System.Drawing.Color.Transparent;
            this.Senha_txt.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.Senha_txt.Location = new System.Drawing.Point(65, 176);
            this.Senha_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Senha_txt.Name = "Senha_txt";
            this.Senha_txt.Size = new System.Drawing.Size(47, 17);
            this.Senha_txt.TabIndex = 5;
            this.Senha_txt.Text = "Senha:";
            // 
            // Nome_box
            // 
            this.Nome_box.BackColor = System.Drawing.SystemColors.Menu;
            this.Nome_box.Location = new System.Drawing.Point(68, 82);
            this.Nome_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Nome_box.Name = "Nome_box";
            this.Nome_box.Size = new System.Drawing.Size(266, 20);
            this.Nome_box.TabIndex = 6;
            this.Nome_box.TextChanged += new System.EventHandler(this.nome_box_TextChanged);
            // 
            // Email_box
            // 
            this.Email_box.BackColor = System.Drawing.SystemColors.Menu;
            this.Email_box.Location = new System.Drawing.Point(68, 139);
            this.Email_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Email_box.Name = "Email_box";
            this.Email_box.Size = new System.Drawing.Size(266, 20);
            this.Email_box.TabIndex = 7;
            // 
            // Senha_box
            // 
            this.Senha_box.BackColor = System.Drawing.SystemColors.Menu;
            this.Senha_box.Location = new System.Drawing.Point(68, 196);
            this.Senha_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Senha_box.Name = "Senha_box";
            this.Senha_box.Size = new System.Drawing.Size(266, 20);
            this.Senha_box.TabIndex = 8;
            // 
            // Cadastrar_btn
            // 
            this.Cadastrar_btn.BackColor = System.Drawing.Color.MediumPurple;
            this.Cadastrar_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cadastrar_btn.Location = new System.Drawing.Point(142, 278);
            this.Cadastrar_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cadastrar_btn.Name = "Cadastrar_btn";
            this.Cadastrar_btn.Size = new System.Drawing.Size(145, 34);
            this.Cadastrar_btn.TabIndex = 9;
            this.Cadastrar_btn.Text = "Entrar\r\n";
            this.Cadastrar_btn.UseVisualStyleBackColor = false;
            this.Cadastrar_btn.Click += new System.EventHandler(this.Entrar);
            // 
            // CaixaBranca
            // 
            this.CaixaBranca.BackColor = System.Drawing.Color.GhostWhite;
            this.CaixaBranca.Controls.Add(this.Cadastrar_btn);
            this.CaixaBranca.Controls.Add(this.GeneroInteresse);
            this.CaixaBranca.Controls.Add(this.Nome_txt);
            this.CaixaBranca.Controls.Add(this.Email_box);
            this.CaixaBranca.Controls.Add(this.Cadastro_txt);
            this.CaixaBranca.Controls.Add(this.Senha_box);
            this.CaixaBranca.Controls.Add(this.Nome_box);
            this.CaixaBranca.Controls.Add(this.Email_txt);
            this.CaixaBranca.Controls.Add(this.Senha_txt);
            this.CaixaBranca.Location = new System.Drawing.Point(349, 52);
            this.CaixaBranca.Name = "CaixaBranca";
            this.CaixaBranca.Size = new System.Drawing.Size(399, 318);
            this.CaixaBranca.TabIndex = 10;
            this.CaixaBranca.TabStop = false;
            // 
            // GeneroInteresse
            // 
            this.GeneroInteresse.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneroInteresse.ForeColor = System.Drawing.Color.MediumPurple;
            this.GeneroInteresse.FormattingEnabled = true;
            this.GeneroInteresse.Items.AddRange(new object[] {
            "Comédia",
            "Drama",
            "Ficção",
            "Romance",
            "Outros"});
            this.GeneroInteresse.Location = new System.Drawing.Point(68, 235);
            this.GeneroInteresse.Name = "GeneroInteresse";
            this.GeneroInteresse.Size = new System.Drawing.Size(156, 24);
            this.GeneroInteresse.TabIndex = 10;
            this.GeneroInteresse.Text = "Gênero de interesse";
            // 
            // CaixaRoxa
            // 
            this.CaixaRoxa.BackColor = System.Drawing.Color.MediumPurple;
            this.CaixaRoxa.Location = new System.Drawing.Point(28, 52);
            this.CaixaRoxa.Name = "CaixaRoxa";
            this.CaixaRoxa.Size = new System.Drawing.Size(325, 317);
            this.CaixaRoxa.TabIndex = 11;
            this.CaixaRoxa.TabStop = false;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 416);
            this.Controls.Add(this.CaixaRoxa);
            this.Controls.Add(this.CaixaBranca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.CaixaBranca.ResumeLayout(false);
            this.CaixaBranca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Cadastro_txt;
        private System.Windows.Forms.Label Nome_txt;
        private System.Windows.Forms.Label Email_txt;
        private System.Windows.Forms.Label Senha_txt;
        private System.Windows.Forms.TextBox Nome_box;
        private System.Windows.Forms.TextBox Email_box;
        private System.Windows.Forms.TextBox Senha_box;
        private System.Windows.Forms.Button Cadastrar_btn;
        private System.Windows.Forms.GroupBox CaixaBranca;
        private System.Windows.Forms.GroupBox CaixaRoxa;
        private System.Windows.Forms.ComboBox GeneroInteresse;
    }
}