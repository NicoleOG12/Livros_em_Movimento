namespace Projeto___Designer
{
    partial class Notificações
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notificações));
            this.Carrinho_Box = new System.Windows.Forms.PictureBox();
            this.Perfil_Box = new System.Windows.Forms.PictureBox();
            this.Sacola_Box = new System.Windows.Forms.PictureBox();
            this.Troca_de_livros_box = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Painel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Carrinho_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perfil_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sacola_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Troca_de_livros_box)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Painel)).BeginInit();
            this.SuspendLayout();
            // 
            // Carrinho_Box
            // 
            this.Carrinho_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Carrinho_Box.Image = global::Projeto___Designer.Properties.Resources.Carrinho;
            this.Carrinho_Box.Location = new System.Drawing.Point(10, 157);
            this.Carrinho_Box.Name = "Carrinho_Box";
            this.Carrinho_Box.Size = new System.Drawing.Size(54, 50);
            this.Carrinho_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Carrinho_Box.TabIndex = 6;
            this.Carrinho_Box.TabStop = false;
            this.Carrinho_Box.Click += new System.EventHandler(this.Carrinho_Click);
            // 
            // Perfil_Box
            // 
            this.Perfil_Box.BackColor = System.Drawing.Color.Transparent;
            this.Perfil_Box.Image = global::Projeto___Designer.Properties.Resources.Perfil;
            this.Perfil_Box.Location = new System.Drawing.Point(9, 225);
            this.Perfil_Box.Name = "Perfil_Box";
            this.Perfil_Box.Size = new System.Drawing.Size(55, 49);
            this.Perfil_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Perfil_Box.TabIndex = 4;
            this.Perfil_Box.TabStop = false;
            this.Perfil_Box.Click += new System.EventHandler(this.Perfil_Click);
            // 
            // Sacola_Box
            // 
            this.Sacola_Box.BackColor = System.Drawing.Color.Transparent;
            this.Sacola_Box.Image = global::Projeto___Designer.Properties.Resources.Sacola;
            this.Sacola_Box.Location = new System.Drawing.Point(10, 90);
            this.Sacola_Box.Name = "Sacola_Box";
            this.Sacola_Box.Size = new System.Drawing.Size(55, 50);
            this.Sacola_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sacola_Box.TabIndex = 2;
            this.Sacola_Box.TabStop = false;
            this.Sacola_Box.Click += new System.EventHandler(this.Sacola_Click);
            // 
            // Troca_de_livros_box
            // 
            this.Troca_de_livros_box.BackColor = System.Drawing.Color.Transparent;
            this.Troca_de_livros_box.Image = global::Projeto___Designer.Properties.Resources.Troca_de_Livros;
            this.Troca_de_livros_box.Location = new System.Drawing.Point(10, 27);
            this.Troca_de_livros_box.Name = "Troca_de_livros_box";
            this.Troca_de_livros_box.Size = new System.Drawing.Size(54, 50);
            this.Troca_de_livros_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Troca_de_livros_box.TabIndex = 1;
            this.Troca_de_livros_box.TabStop = false;
            this.Troca_de_livros_box.Click += new System.EventHandler(this.Troca_de_livros_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.GhostWhite;
            this.Menu.Controls.Add(this.Carrinho_Box);
            this.Menu.Controls.Add(this.Perfil_Box);
            this.Menu.Controls.Add(this.Sacola_Box);
            this.Menu.Controls.Add(this.Troca_de_livros_box);
            this.Menu.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.MediumPurple;
            this.Menu.Location = new System.Drawing.Point(3, 22);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(81, 284);
            this.Menu.TabIndex = 10;
            this.Menu.TabStop = false;
            this.Menu.Text = "  Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(340, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Notificações";
            // 
            // Painel
            // 
            this.Painel.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.Painel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Painel.Location = new System.Drawing.Point(233, 135);
            this.Painel.Name = "Painel";
            this.Painel.Size = new System.Drawing.Size(415, 244);
            this.Painel.TabIndex = 15;
            // 
            // Notificações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.Painel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notificações";
            this.Text = "Minhas Solicitações";
            ((System.ComponentModel.ISupportInitialize)(this.Carrinho_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perfil_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sacola_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Troca_de_livros_box)).EndInit();
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Painel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Troca_de_livros_box;
        private System.Windows.Forms.PictureBox Sacola_Box;
        private System.Windows.Forms.PictureBox Perfil_Box;
        private System.Windows.Forms.PictureBox Carrinho_Box;
        private new System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Painel;
    }
}