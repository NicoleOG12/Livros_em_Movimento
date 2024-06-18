namespace Projeto___Designer
{
    partial class Loja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loja));
            this.Pesquisa_barra = new System.Windows.Forms.TextBox();
            this.new_txt = new System.Windows.Forms.Label();
            this.Solicitação_Box = new System.Windows.Forms.PictureBox();
            this.Lupa_box = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Solicitação_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lupa_box)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            this.SuspendLayout();
            // 
            // Pesquisa_barra
            // 
            this.Pesquisa_barra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisa_barra.Location = new System.Drawing.Point(197, 31);
            this.Pesquisa_barra.Name = "Pesquisa_barra";
            this.Pesquisa_barra.Size = new System.Drawing.Size(404, 29);
            this.Pesquisa_barra.TabIndex = 5;
            // 
            // new_txt
            // 
            this.new_txt.AutoSize = true;
            this.new_txt.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.new_txt.Location = new System.Drawing.Point(129, 85);
            this.new_txt.Name = "new_txt";
            this.new_txt.Size = new System.Drawing.Size(66, 31);
            this.new_txt.TabIndex = 36;
            this.new_txt.Text = "New";
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
            // Lupa_box
            // 
            this.Lupa_box.BackColor = System.Drawing.Color.Transparent;
            this.Lupa_box.Image = global::Projeto___Designer.Properties.Resources.lupa;
            this.Lupa_box.Location = new System.Drawing.Point(607, 31);
            this.Lupa_box.Name = "Lupa_box";
            this.Lupa_box.Size = new System.Drawing.Size(28, 29);
            this.Lupa_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lupa_box.TabIndex = 0;
            this.Lupa_box.TabStop = false;
            this.Lupa_box.Click += new System.EventHandler(this.Lupa_box_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.GhostWhite;
            this.Menu.Controls.Add(this.pictureBox1);
            this.Menu.Controls.Add(this.pictureBox17);
            this.Menu.Controls.Add(this.pictureBox18);
            this.Menu.Controls.Add(this.pictureBox19);
            this.Menu.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.MediumPurple;
            this.Menu.Location = new System.Drawing.Point(2, 31);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(81, 284);
            this.Menu.TabIndex = 39;
            this.Menu.TabStop = false;
            this.Menu.Text = "  Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Projeto___Designer.Properties.Resources.Carrinho;
            this.pictureBox1.Location = new System.Drawing.Point(10, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Carrinho_Click);
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.Image = global::Projeto___Designer.Properties.Resources.Perfil;
            this.pictureBox17.Location = new System.Drawing.Point(9, 225);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(55, 49);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 4;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Click += new System.EventHandler(this.Perfil_Click);
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.Image = global::Projeto___Designer.Properties.Resources.Sacola;
            this.pictureBox18.Location = new System.Drawing.Point(10, 90);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(55, 50);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 2;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Click += new System.EventHandler(this.Sacola_Click);
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox19.Image = global::Projeto___Designer.Properties.Resources.Troca_de_Livros;
            this.pictureBox19.Location = new System.Drawing.Point(10, 27);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(54, 50);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 1;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Click += new System.EventHandler(this.Troca_de_livros_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.MediumPurple;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(135, 133);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(708, 354);
            this.flowLayoutPanel1.TabIndex = 40;
            // 
            // Loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 519);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.new_txt);
            this.Controls.Add(this.Pesquisa_barra);
            this.Controls.Add(this.Solicitação_Box);
            this.Controls.Add(this.Lupa_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loja";
            this.Text = "Loja";
            ((System.ComponentModel.ISupportInitialize)(this.Solicitação_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lupa_box)).EndInit();
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Lupa_box;
        private System.Windows.Forms.PictureBox Solicitação_Box;
        private System.Windows.Forms.TextBox Pesquisa_barra;
        private System.Windows.Forms.Label new_txt;
        private new System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}