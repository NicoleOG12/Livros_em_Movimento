namespace Projeto___Designer
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Email_txt = new System.Windows.Forms.Label();
            this.senha_txt = new System.Windows.Forms.Label();
            this.Login_txt = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(659, 182);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(659, 248);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Email_txt
            // 
            this.Email_txt.AutoSize = true;
            this.Email_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.Email_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Email_txt.Location = new System.Drawing.Point(592, 183);
            this.Email_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email_txt.MaximumSize = new System.Drawing.Size(45, 20);
            this.Email_txt.MinimumSize = new System.Drawing.Size(45, 20);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(45, 20);
            this.Email_txt.TabIndex = 2;
            this.Email_txt.Text = "Email\r\n";
            // 
            // senha_txt
            // 
            this.senha_txt.AutoSize = true;
            this.senha_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.senha_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.senha_txt.Location = new System.Drawing.Point(588, 248);
            this.senha_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.senha_txt.Name = "senha_txt";
            this.senha_txt.Size = new System.Drawing.Size(49, 17);
            this.senha_txt.TabIndex = 3;
            this.senha_txt.Text = "Senha";
            // 
            // Login_txt
            // 
            this.Login_txt.AutoSize = true;
            this.Login_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.16F);
            this.Login_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_txt.Location = new System.Drawing.Point(654, 89);
            this.Login_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login_txt.Name = "Login_txt";
            this.Login_txt.Size = new System.Drawing.Size(65, 25);
            this.Login_txt.TabIndex = 4;
            this.Login_txt.Text = "Login";
            // 
            // Cadastrar
            // 
            this.Cadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cadastrar.Location = new System.Drawing.Point(659, 337);
            this.Cadastrar.Margin = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(72, 20);
            this.Cadastrar.TabIndex = 5;
            this.Cadastrar.Text = "Cadastre-se";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.cadastrarUsuario);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(637, 300);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Não possui cadastro?  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(987, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.Login_txt);
            this.Controls.Add(this.senha_txt);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Email_txt;
        private System.Windows.Forms.Label senha_txt;
        private System.Windows.Forms.Label Login_txt;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Label label1;
    }
}

