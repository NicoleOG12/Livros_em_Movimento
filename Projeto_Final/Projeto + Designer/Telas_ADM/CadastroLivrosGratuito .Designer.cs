namespace Projeto___Designer
{
    partial class CadastroLivrosGratuitos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroLivrosGratuitos));
            this.caixalogin2 = new System.Windows.Forms.GroupBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Login_txt = new System.Windows.Forms.Label();
            this.caixalogin = new System.Windows.Forms.GroupBox();
            this.Quantidade = new System.Windows.Forms.NumericUpDown();
            this.Estoque = new System.Windows.Forms.Label();
            this.Sinopse_Box = new System.Windows.Forms.TextBox();
            this.Autor = new System.Windows.Forms.Label();
            this.Anexar = new System.Windows.Forms.Button();
            this.ImagemLivro = new System.Windows.Forms.PictureBox();
            this.Autor_box = new System.Windows.Forms.TextBox();
            this.Sinopse = new System.Windows.Forms.Label();
            this.Livro = new System.Windows.Forms.Label();
            this.Nome_do_Livro_Box = new System.Windows.Forms.TextBox();
            this.caixalogin2.SuspendLayout();
            this.caixalogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // caixalogin2
            // 
            this.caixalogin2.BackColor = System.Drawing.Color.MediumPurple;
            this.caixalogin2.Controls.Add(this.Cancelar);
            this.caixalogin2.Controls.Add(this.Cadastrar);
            this.caixalogin2.Location = new System.Drawing.Point(232, 564);
            this.caixalogin2.Name = "caixalogin2";
            this.caixalogin2.Size = new System.Drawing.Size(302, 48);
            this.caixalogin2.TabIndex = 9;
            this.caixalogin2.TabStop = false;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.GhostWhite;
            this.Cancelar.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.Color.MediumPurple;
            this.Cancelar.Location = new System.Drawing.Point(37, 12);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(84, 25);
            this.Cancelar.TabIndex = 6;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.Color.GhostWhite;
            this.Cadastrar.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.ForeColor = System.Drawing.Color.MediumPurple;
            this.Cadastrar.Location = new System.Drawing.Point(180, 12);
            this.Cadastrar.Margin = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(84, 25);
            this.Cadastrar.TabIndex = 5;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // Login_txt
            // 
            this.Login_txt.AutoSize = true;
            this.Login_txt.Font = new System.Drawing.Font("MV Boli", 15.16F, System.Drawing.FontStyle.Bold);
            this.Login_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.Login_txt.Location = new System.Drawing.Point(67, 36);
            this.Login_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login_txt.Name = "Login_txt";
            this.Login_txt.Size = new System.Drawing.Size(168, 28);
            this.Login_txt.TabIndex = 4;
            this.Login_txt.Text = "Cadastro Livro";
            // 
            // caixalogin
            // 
            this.caixalogin.BackColor = System.Drawing.Color.GhostWhite;
            this.caixalogin.Controls.Add(this.Quantidade);
            this.caixalogin.Controls.Add(this.Estoque);
            this.caixalogin.Controls.Add(this.Sinopse_Box);
            this.caixalogin.Controls.Add(this.Autor);
            this.caixalogin.Controls.Add(this.Anexar);
            this.caixalogin.Controls.Add(this.ImagemLivro);
            this.caixalogin.Controls.Add(this.Autor_box);
            this.caixalogin.Controls.Add(this.Sinopse);
            this.caixalogin.Controls.Add(this.Livro);
            this.caixalogin.Controls.Add(this.Nome_do_Livro_Box);
            this.caixalogin.Controls.Add(this.Login_txt);
            this.caixalogin.Location = new System.Drawing.Point(232, 43);
            this.caixalogin.Name = "caixalogin";
            this.caixalogin.Size = new System.Drawing.Size(302, 526);
            this.caixalogin.TabIndex = 8;
            this.caixalogin.TabStop = false;
            // 
            // Quantidade
            // 
            this.Quantidade.BackColor = System.Drawing.SystemColors.Menu;
            this.Quantidade.Location = new System.Drawing.Point(61, 274);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(120, 20);
            this.Quantidade.TabIndex = 17;
            // 
            // Estoque
            // 
            this.Estoque.AutoSize = true;
            this.Estoque.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estoque.ForeColor = System.Drawing.Color.MediumPurple;
            this.Estoque.Location = new System.Drawing.Point(58, 254);
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(55, 17);
            this.Estoque.TabIndex = 16;
            this.Estoque.Text = "Estoque";
            // 
            // Sinopse_Box
            // 
            this.Sinopse_Box.BackColor = System.Drawing.SystemColors.Menu;
            this.Sinopse_Box.Location = new System.Drawing.Point(61, 214);
            this.Sinopse_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Sinopse_Box.Name = "Sinopse_Box";
            this.Sinopse_Box.Size = new System.Drawing.Size(173, 20);
            this.Sinopse_Box.TabIndex = 13;
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autor.ForeColor = System.Drawing.Color.MediumPurple;
            this.Autor.Location = new System.Drawing.Point(58, 136);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(44, 17);
            this.Autor.TabIndex = 12;
            this.Autor.Text = "Autor";
            // 
            // Anexar
            // 
            this.Anexar.BackColor = System.Drawing.SystemColors.Menu;
            this.Anexar.Location = new System.Drawing.Point(101, 323);
            this.Anexar.Name = "Anexar";
            this.Anexar.Size = new System.Drawing.Size(98, 23);
            this.Anexar.TabIndex = 11;
            this.Anexar.Text = "Anexar Imagem";
            this.Anexar.UseVisualStyleBackColor = false;
            this.Anexar.Click += new System.EventHandler(this.Anexar_Click);
            // 
            // ImagemLivro
            // 
            this.ImagemLivro.Location = new System.Drawing.Point(99, 354);
            this.ImagemLivro.Name = "ImagemLivro";
            this.ImagemLivro.Size = new System.Drawing.Size(108, 137);
            this.ImagemLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagemLivro.TabIndex = 10;
            this.ImagemLivro.TabStop = false;
            this.ImagemLivro.UseWaitCursor = true;
            // 
            // Autor_box
            // 
            this.Autor_box.BackColor = System.Drawing.SystemColors.Menu;
            this.Autor_box.Location = new System.Drawing.Point(61, 155);
            this.Autor_box.Margin = new System.Windows.Forms.Padding(2);
            this.Autor_box.Name = "Autor_box";
            this.Autor_box.Size = new System.Drawing.Size(173, 20);
            this.Autor_box.TabIndex = 9;
            // 
            // Sinopse
            // 
            this.Sinopse.AutoSize = true;
            this.Sinopse.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sinopse.ForeColor = System.Drawing.Color.MediumPurple;
            this.Sinopse.Location = new System.Drawing.Point(58, 195);
            this.Sinopse.Name = "Sinopse";
            this.Sinopse.Size = new System.Drawing.Size(51, 17);
            this.Sinopse.TabIndex = 8;
            this.Sinopse.Text = "Sinopse";
            // 
            // Livro
            // 
            this.Livro.AutoSize = true;
            this.Livro.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Livro.ForeColor = System.Drawing.Color.MediumPurple;
            this.Livro.Location = new System.Drawing.Point(58, 82);
            this.Livro.Name = "Livro";
            this.Livro.Size = new System.Drawing.Size(99, 17);
            this.Livro.TabIndex = 7;
            this.Livro.Text = "Nome do livro ";
            // 
            // Nome_do_Livro_Box
            // 
            this.Nome_do_Livro_Box.BackColor = System.Drawing.SystemColors.Menu;
            this.Nome_do_Livro_Box.Location = new System.Drawing.Point(61, 101);
            this.Nome_do_Livro_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Nome_do_Livro_Box.Name = "Nome_do_Livro_Box";
            this.Nome_do_Livro_Box.Size = new System.Drawing.Size(173, 20);
            this.Nome_do_Livro_Box.TabIndex = 6;
            // 
            // CadastroLivrosGratuitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto___Designer.Properties.Resources.wallpaperflare_com_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 654);
            this.Controls.Add(this.caixalogin2);
            this.Controls.Add(this.caixalogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroLivrosGratuitos";
            this.Text = "Troca";
            this.Load += new System.EventHandler(this.CadastroProdutos_Load);
            this.caixalogin2.ResumeLayout(false);
            this.caixalogin.ResumeLayout(false);
            this.caixalogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox caixalogin2;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Label Login_txt;
        private System.Windows.Forms.GroupBox caixalogin;
        private System.Windows.Forms.Label Livro;
        private System.Windows.Forms.TextBox Nome_do_Livro_Box;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.TextBox Autor_box;
        private System.Windows.Forms.Label Sinopse;
        private System.Windows.Forms.Button Anexar;
        private System.Windows.Forms.PictureBox ImagemLivro;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.TextBox Sinopse_Box;
        private System.Windows.Forms.Label Estoque;
        private System.Windows.Forms.NumericUpDown Quantidade;
    }
}