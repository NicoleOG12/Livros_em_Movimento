namespace Projeto___Designer
{
    partial class TipoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroLivros));
            this.Login_txt = new System.Windows.Forms.Label();
            this.caixalogin = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Livro_btn = new System.Windows.Forms.Button();
            this.Produto_btn = new System.Windows.Forms.Button();
            this.caixalogin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_txt
            // 
            this.Login_txt.AutoSize = true;
            this.Login_txt.Font = new System.Drawing.Font("MV Boli", 15.16F, System.Drawing.FontStyle.Bold);
            this.Login_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.Login_txt.Location = new System.Drawing.Point(67, 36);
            this.Login_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login_txt.Name = "Login_txt";
            this.Login_txt.Size = new System.Drawing.Size(160, 28);
            this.Login_txt.TabIndex = 4;
            this.Login_txt.Text = "Tipo Cadastro";
            // 
            // caixalogin
            // 
            this.caixalogin.BackColor = System.Drawing.Color.MediumPurple;
            this.caixalogin.Controls.Add(this.groupBox1);
            this.caixalogin.Controls.Add(this.Login_txt);
            this.caixalogin.Location = new System.Drawing.Point(221, 64);
            this.caixalogin.Name = "caixalogin";
            this.caixalogin.Size = new System.Drawing.Size(318, 294);
            this.caixalogin.TabIndex = 8;
            this.caixalogin.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.Produto_btn);
            this.groupBox1.Controls.Add(this.Livro_btn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 274);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(67, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo Cadastro";
            // 
            // Livro_btn
            // 
            this.Livro_btn.BackColor = System.Drawing.Color.MediumPurple;
            this.Livro_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Livro_btn.CausesValidation = false;
            this.Livro_btn.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Livro_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Livro_btn.Location = new System.Drawing.Point(72, 100);
            this.Livro_btn.Name = "Livro_btn";
            this.Livro_btn.Size = new System.Drawing.Size(158, 34);
            this.Livro_btn.TabIndex = 7;
            this.Livro_btn.Text = "Livro";
            this.Livro_btn.UseVisualStyleBackColor = false;
            this.Livro_btn.Click += new System.EventHandler(this.Livro_btn_Click);
            // 
            // Produto_btn
            // 
            this.Produto_btn.BackColor = System.Drawing.Color.MediumPurple;
            this.Produto_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Produto_btn.CausesValidation = false;
            this.Produto_btn.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produto_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Produto_btn.Location = new System.Drawing.Point(72, 179);
            this.Produto_btn.Name = "Produto_btn";
            this.Produto_btn.Size = new System.Drawing.Size(158, 34);
            this.Produto_btn.TabIndex = 8;
            this.Produto_btn.Text = "Outro Produto";
            this.Produto_btn.UseVisualStyleBackColor = false;
            this.Produto_btn.Click += new System.EventHandler(this.Produto_btn_Click);
            // 
            // CadastroLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto___Designer.Properties.Resources.wallpaperflare_com_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 532);
            this.Controls.Add(this.caixalogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroLivros";
            this.Text = "Tipo Cadastro";
            this.caixalogin.ResumeLayout(false);
            this.caixalogin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Login_txt;
        private System.Windows.Forms.GroupBox caixalogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Produto_btn;
        private System.Windows.Forms.Button Livro_btn;
    }
}