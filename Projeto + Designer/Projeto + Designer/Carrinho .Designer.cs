namespace Projeto___Designer
{
    partial class Carrinho
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
            this.Carrinho_Box = new System.Windows.Forms.PictureBox();
            this.Perfil_Box = new System.Windows.Forms.PictureBox();
            this.Solicitação_Box = new System.Windows.Forms.PictureBox();
            this.Sacola_Box = new System.Windows.Forms.PictureBox();
            this.Troca_de_livros_box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Carrinho_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perfil_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Solicitação_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sacola_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Troca_de_livros_box)).BeginInit();
            this.SuspendLayout();
            // 
            // Carrinho_Box
            // 
            this.Carrinho_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Carrinho_Box.Image = global::Projeto___Designer.Properties.Resources.Carrinho;
            this.Carrinho_Box.Location = new System.Drawing.Point(450, 666);
            this.Carrinho_Box.Name = "Carrinho_Box";
            this.Carrinho_Box.Size = new System.Drawing.Size(67, 74);
            this.Carrinho_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Carrinho_Box.TabIndex = 6;
            this.Carrinho_Box.TabStop = false;
            // 
            // Perfil_Box
            // 
            this.Perfil_Box.BackColor = System.Drawing.Color.Transparent;
            this.Perfil_Box.Image = global::Projeto___Designer.Properties.Resources.Perfil;
            this.Perfil_Box.Location = new System.Drawing.Point(617, 666);
            this.Perfil_Box.Name = "Perfil_Box";
            this.Perfil_Box.Size = new System.Drawing.Size(80, 74);
            this.Perfil_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Perfil_Box.TabIndex = 4;
            this.Perfil_Box.TabStop = false;
            this.Perfil_Box.Click += new System.EventHandler(this.Perfil_Click);
            // 
            // Solicitação_Box
            // 
            this.Solicitação_Box.BackColor = System.Drawing.Color.Transparent;
            this.Solicitação_Box.Image = global::Projeto___Designer.Properties.Resources.Notificações;
            this.Solicitação_Box.Location = new System.Drawing.Point(717, 24);
            this.Solicitação_Box.Name = "Solicitação_Box";
            this.Solicitação_Box.Size = new System.Drawing.Size(47, 46);
            this.Solicitação_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Solicitação_Box.TabIndex = 3;
            this.Solicitação_Box.TabStop = false;
            this.Solicitação_Box.Click += new System.EventHandler(this.Solicitações_Click);
            // 
            // Sacola_Box
            // 
            this.Sacola_Box.BackColor = System.Drawing.Color.Transparent;
            this.Sacola_Box.Image = global::Projeto___Designer.Properties.Resources.Sacola;
            this.Sacola_Box.Location = new System.Drawing.Point(269, 666);
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
            this.Troca_de_livros_box.Location = new System.Drawing.Point(86, 666);
            this.Troca_de_livros_box.Name = "Troca_de_livros_box";
            this.Troca_de_livros_box.Size = new System.Drawing.Size(77, 74);
            this.Troca_de_livros_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Troca_de_livros_box.TabIndex = 1;
            this.Troca_de_livros_box.TabStop = false;
            this.Troca_de_livros_box.Click += new System.EventHandler(this.Troca_de_livros_Click);
            // 
            // Carrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 734);
            this.Controls.Add(this.Carrinho_Box);
            this.Controls.Add(this.Perfil_Box);
            this.Controls.Add(this.Solicitação_Box);
            this.Controls.Add(this.Sacola_Box);
            this.Controls.Add(this.Troca_de_livros_box);
            this.Name = "Carrinho";
            this.Text = "Carrinho";
            ((System.ComponentModel.ISupportInitialize)(this.Carrinho_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perfil_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Solicitação_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sacola_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Troca_de_livros_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Troca_de_livros_box;
        private System.Windows.Forms.PictureBox Sacola_Box;
        private System.Windows.Forms.PictureBox Solicitação_Box;
        private System.Windows.Forms.PictureBox Perfil_Box;
        private System.Windows.Forms.PictureBox Carrinho_Box;
    }
}