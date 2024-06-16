namespace Projeto___Designer
{
    partial class Troca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Troca));
            this.caixalogin2 = new System.Windows.Forms.GroupBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Confirmar = new System.Windows.Forms.Button();
            this.Email_box = new System.Windows.Forms.TextBox();
            this.Nome_box = new System.Windows.Forms.TextBox();
            this.Nome_txt = new System.Windows.Forms.Label();
            this.Login_txt = new System.Windows.Forms.Label();
            this.Email_txt = new System.Windows.Forms.Label();
            this.caixalogin = new System.Windows.Forms.GroupBox();
            this.Anexar = new System.Windows.Forms.Button();
            this.ImagemLivro = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Livro_do_Usuario = new System.Windows.Forms.Label();
            this.Livro_Selecionado = new System.Windows.Forms.Label();
            this.Nome_do_Livro_Box = new System.Windows.Forms.TextBox();
            this.caixalogin2.SuspendLayout();
            this.caixalogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // caixalogin2
            // 
            this.caixalogin2.BackColor = System.Drawing.Color.MediumPurple;
            this.caixalogin2.Controls.Add(this.Cancelar);
            this.caixalogin2.Controls.Add(this.Confirmar);
            this.caixalogin2.Location = new System.Drawing.Point(232, 488);
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
            // Confirmar
            // 
            this.Confirmar.BackColor = System.Drawing.Color.GhostWhite;
            this.Confirmar.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmar.ForeColor = System.Drawing.Color.MediumPurple;
            this.Confirmar.Location = new System.Drawing.Point(180, 12);
            this.Confirmar.Margin = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(84, 25);
            this.Confirmar.TabIndex = 5;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = false;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // Email_box
            // 
            this.Email_box.BackColor = System.Drawing.SystemColors.Menu;
            this.Email_box.Location = new System.Drawing.Point(61, 148);
            this.Email_box.Margin = new System.Windows.Forms.Padding(2);
            this.Email_box.Name = "Email_box";
            this.Email_box.Size = new System.Drawing.Size(173, 20);
            this.Email_box.TabIndex = 0;
            // 
            // Nome_box
            // 
            this.Nome_box.BackColor = System.Drawing.SystemColors.Menu;
            this.Nome_box.Location = new System.Drawing.Point(61, 93);
            this.Nome_box.Margin = new System.Windows.Forms.Padding(2);
            this.Nome_box.Name = "Nome_box";
            this.Nome_box.Size = new System.Drawing.Size(173, 20);
            this.Nome_box.TabIndex = 1;
            // 
            // Nome_txt
            // 
            this.Nome_txt.AutoSize = true;
            this.Nome_txt.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.Nome_txt.Location = new System.Drawing.Point(58, 74);
            this.Nome_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nome_txt.Name = "Nome_txt";
            this.Nome_txt.Size = new System.Drawing.Size(42, 17);
            this.Nome_txt.TabIndex = 3;
            this.Nome_txt.Text = "Nome";
            // 
            // Login_txt
            // 
            this.Login_txt.AutoSize = true;
            this.Login_txt.Font = new System.Drawing.Font("MV Boli", 15.16F, System.Drawing.FontStyle.Bold);
            this.Login_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.Login_txt.Location = new System.Drawing.Point(32, 29);
            this.Login_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login_txt.Name = "Login_txt";
            this.Login_txt.Size = new System.Drawing.Size(245, 28);
            this.Login_txt.TabIndex = 4;
            this.Login_txt.Text = "Confirmação de Dados\r\n";
            // 
            // Email_txt
            // 
            this.Email_txt.AutoSize = true;
            this.Email_txt.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.Email_txt.Location = new System.Drawing.Point(58, 129);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(39, 17);
            this.Email_txt.TabIndex = 5;
            this.Email_txt.Text = "Email";
            // 
            // caixalogin
            // 
            this.caixalogin.BackColor = System.Drawing.Color.GhostWhite;
            this.caixalogin.Controls.Add(this.Anexar);
            this.caixalogin.Controls.Add(this.ImagemLivro);
            this.caixalogin.Controls.Add(this.textBox1);
            this.caixalogin.Controls.Add(this.Livro_do_Usuario);
            this.caixalogin.Controls.Add(this.Livro_Selecionado);
            this.caixalogin.Controls.Add(this.Nome_do_Livro_Box);
            this.caixalogin.Controls.Add(this.Email_txt);
            this.caixalogin.Controls.Add(this.Login_txt);
            this.caixalogin.Controls.Add(this.Nome_txt);
            this.caixalogin.Controls.Add(this.Nome_box);
            this.caixalogin.Controls.Add(this.Email_box);
            this.caixalogin.Location = new System.Drawing.Point(232, 63);
            this.caixalogin.Name = "caixalogin";
            this.caixalogin.Size = new System.Drawing.Size(302, 433);
            this.caixalogin.TabIndex = 8;
            this.caixalogin.TabStop = false;
            // 
            // Anexar
            // 
            this.Anexar.BackColor = System.Drawing.SystemColors.Menu;
            this.Anexar.Location = new System.Drawing.Point(93, 289);
            this.Anexar.Name = "Anexar";
            this.Anexar.Size = new System.Drawing.Size(98, 23);
            this.Anexar.TabIndex = 11;
            this.Anexar.Text = "Anexar Imagem";
            this.Anexar.UseVisualStyleBackColor = false;
            this.Anexar.Click += new System.EventHandler(this.Anexar_Click);
            // 
            // ImagemLivro
            // 
            this.ImagemLivro.Location = new System.Drawing.Point(107, 318);
            this.ImagemLivro.Name = "ImagemLivro";
            this.ImagemLivro.Size = new System.Drawing.Size(74, 92);
            this.ImagemLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagemLivro.TabIndex = 10;
            this.ImagemLivro.TabStop = false;
            this.ImagemLivro.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(61, 253);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Livro_do_Usuario
            // 
            this.Livro_do_Usuario.AutoSize = true;
            this.Livro_do_Usuario.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Livro_do_Usuario.ForeColor = System.Drawing.Color.MediumPurple;
            this.Livro_do_Usuario.Location = new System.Drawing.Point(58, 234);
            this.Livro_do_Usuario.Name = "Livro_do_Usuario";
            this.Livro_do_Usuario.Size = new System.Drawing.Size(123, 17);
            this.Livro_do_Usuario.TabIndex = 8;
            this.Livro_do_Usuario.Text = "Nome do seu livro ";
            // 
            // Livro_Selecionado
            // 
            this.Livro_Selecionado.AutoSize = true;
            this.Livro_Selecionado.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Livro_Selecionado.ForeColor = System.Drawing.Color.MediumPurple;
            this.Livro_Selecionado.Location = new System.Drawing.Point(58, 181);
            this.Livro_Selecionado.Name = "Livro_Selecionado";
            this.Livro_Selecionado.Size = new System.Drawing.Size(162, 17);
            this.Livro_Selecionado.TabIndex = 7;
            this.Livro_Selecionado.Text = "Nome do livro selecionado";
            // 
            // Nome_do_Livro_Box
            // 
            this.Nome_do_Livro_Box.BackColor = System.Drawing.SystemColors.Menu;
            this.Nome_do_Livro_Box.Location = new System.Drawing.Point(61, 200);
            this.Nome_do_Livro_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Nome_do_Livro_Box.Name = "Nome_do_Livro_Box";
            this.Nome_do_Livro_Box.Size = new System.Drawing.Size(173, 20);
            this.Nome_do_Livro_Box.TabIndex = 6;
            // 
            // Troca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto___Designer.Properties.Resources.wallpaperflare_com_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 548);
            this.Controls.Add(this.caixalogin2);
            this.Controls.Add(this.caixalogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Troca";
            this.Text = "Troca";
            this.caixalogin2.ResumeLayout(false);
            this.caixalogin.ResumeLayout(false);
            this.caixalogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox caixalogin2;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.TextBox Email_box;
        private System.Windows.Forms.TextBox Nome_box;
        private System.Windows.Forms.Label Nome_txt;
        private System.Windows.Forms.Label Login_txt;
        private System.Windows.Forms.Label Email_txt;
        private System.Windows.Forms.GroupBox caixalogin;
        private System.Windows.Forms.Label Livro_Selecionado;
        private System.Windows.Forms.TextBox Nome_do_Livro_Box;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Livro_do_Usuario;
        private System.Windows.Forms.Button Anexar;
        private System.Windows.Forms.PictureBox ImagemLivro;
    }
}