namespace Projeto___Designer
{
    partial class Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produto));
            this.Quantidade_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Preço_txt = new System.Windows.Forms.Label();
            this.Nome_item_txt = new System.Windows.Forms.Label();
            this.Adicionar_ao_carrinho_btn = new System.Windows.Forms.Button();
            this.Comprar_agora_btn = new System.Windows.Forms.Button();
            this.Quantidade_txt = new System.Windows.Forms.Label();
            this.Número_de_itens_txt = new System.Windows.Forms.Label();
            this.Descrição = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.Imagem1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Seta = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Quantidade_numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Quantidade_numericUpDown1
            // 
            this.Quantidade_numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantidade_numericUpDown1.Location = new System.Drawing.Point(454, 223);
            this.Quantidade_numericUpDown1.Name = "Quantidade_numericUpDown1";
            this.Quantidade_numericUpDown1.Size = new System.Drawing.Size(70, 24);
            this.Quantidade_numericUpDown1.TabIndex = 3;
            // 
            // Preço_txt
            // 
            this.Preço_txt.AutoSize = true;
            this.Preço_txt.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preço_txt.Location = new System.Drawing.Point(313, 171);
            this.Preço_txt.Name = "Preço_txt";
            this.Preço_txt.Size = new System.Drawing.Size(75, 21);
            this.Preço_txt.TabIndex = 5;
            this.Preço_txt.Text = "R$13,99";
            // 
            // Nome_item_txt
            // 
            this.Nome_item_txt.AutoSize = true;
            this.Nome_item_txt.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_item_txt.Location = new System.Drawing.Point(312, 128);
            this.Nome_item_txt.Name = "Nome_item_txt";
            this.Nome_item_txt.Size = new System.Drawing.Size(257, 25);
            this.Nome_item_txt.TabIndex = 6;
            this.Nome_item_txt.Text = "Kit 4 marca páginas florido";
            // 
            // Adicionar_ao_carrinho_btn
            // 
            this.Adicionar_ao_carrinho_btn.BackColor = System.Drawing.Color.Lavender;
            this.Adicionar_ao_carrinho_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Adicionar_ao_carrinho_btn.ForeColor = System.Drawing.Color.MediumPurple;
            this.Adicionar_ao_carrinho_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Adicionar_ao_carrinho_btn.Location = new System.Drawing.Point(336, 280);
            this.Adicionar_ao_carrinho_btn.Name = "Adicionar_ao_carrinho_btn";
            this.Adicionar_ao_carrinho_btn.Size = new System.Drawing.Size(146, 34);
            this.Adicionar_ao_carrinho_btn.TabIndex = 7;
            this.Adicionar_ao_carrinho_btn.Text = "          Adicionar ao carrinho";
            this.Adicionar_ao_carrinho_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Adicionar_ao_carrinho_btn.UseVisualStyleBackColor = false;
            this.Adicionar_ao_carrinho_btn.Click += new System.EventHandler(this.Adicionar_ao_carrinho_Click);
            // 
            // Comprar_agora_btn
            // 
            this.Comprar_agora_btn.BackColor = System.Drawing.Color.MediumPurple;
            this.Comprar_agora_btn.ForeColor = System.Drawing.Color.GhostWhite;
            this.Comprar_agora_btn.Location = new System.Drawing.Point(537, 280);
            this.Comprar_agora_btn.Name = "Comprar_agora_btn";
            this.Comprar_agora_btn.Size = new System.Drawing.Size(132, 34);
            this.Comprar_agora_btn.TabIndex = 8;
            this.Comprar_agora_btn.Text = "Comprar agora";
            this.Comprar_agora_btn.UseVisualStyleBackColor = false;
            this.Comprar_agora_btn.Click += new System.EventHandler(this.Comprar_agora_Click);
            // 
            // Quantidade_txt
            // 
            this.Quantidade_txt.AutoSize = true;
            this.Quantidade_txt.BackColor = System.Drawing.Color.White;
            this.Quantidade_txt.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantidade_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.Quantidade_txt.Location = new System.Drawing.Point(377, 226);
            this.Quantidade_txt.Name = "Quantidade_txt";
            this.Quantidade_txt.Size = new System.Drawing.Size(71, 17);
            this.Quantidade_txt.TabIndex = 9;
            this.Quantidade_txt.Text = "Quantidade";
            // 
            // Número_de_itens_txt
            // 
            this.Número_de_itens_txt.AutoSize = true;
            this.Número_de_itens_txt.BackColor = System.Drawing.Color.White;
            this.Número_de_itens_txt.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Número_de_itens_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.Número_de_itens_txt.Location = new System.Drawing.Point(534, 226);
            this.Número_de_itens_txt.Name = "Número_de_itens_txt";
            this.Número_de_itens_txt.Size = new System.Drawing.Size(121, 17);
            this.Número_de_itens_txt.TabIndex = 10;
            this.Número_de_itens_txt.Text = "20 itens disponíveis";
            this.Número_de_itens_txt.Click += new System.EventHandler(this.Número_de_itens_txt_Click);
            // 
            // Descrição
            // 
            this.Descrição.AutoSize = true;
            this.Descrição.BackColor = System.Drawing.Color.Lavender;
            this.Descrição.Font = new System.Drawing.Font("MV Boli", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descrição.Location = new System.Drawing.Point(314, 171);
            this.Descrição.Name = "Descrição";
            this.Descrição.Size = new System.Drawing.Size(0, 11);
            this.Descrição.TabIndex = 11;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Imagem1
            // 
            this.Imagem1.Image = global::Projeto___Designer.Properties.Resources.marca_página1;
            this.Imagem1.Location = new System.Drawing.Point(86, 117);
            this.Imagem1.Name = "Imagem1";
            this.Imagem1.Size = new System.Drawing.Size(176, 244);
            this.Imagem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagem1.TabIndex = 0;
            this.Imagem1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.pictureBox2.Location = new System.Drawing.Point(26, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(705, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBox3.Location = new System.Drawing.Point(26, 57);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(705, 350);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Seta
            // 
            this.Seta.BackColor = System.Drawing.Color.MediumPurple;
            this.Seta.Image = global::Projeto___Designer.Properties.Resources.Seta1;
            this.Seta.Location = new System.Drawing.Point(26, 28);
            this.Seta.Name = "Seta";
            this.Seta.Size = new System.Drawing.Size(74, 50);
            this.Seta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Seta.TabIndex = 13;
            this.Seta.TabStop = false;
            this.Seta.Click += new System.EventHandler(this.Seta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lavender;
            this.pictureBox1.Image = global::Projeto___Designer.Properties.Resources.Carrinho;
            this.pictureBox1.Location = new System.Drawing.Point(339, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // MP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(743, 425);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Seta);
            this.Controls.Add(this.Descrição);
            this.Controls.Add(this.Número_de_itens_txt);
            this.Controls.Add(this.Quantidade_txt);
            this.Controls.Add(this.Comprar_agora_btn);
            this.Controls.Add(this.Adicionar_ao_carrinho_btn);
            this.Controls.Add(this.Nome_item_txt);
            this.Controls.Add(this.Preço_txt);
            this.Controls.Add(this.Quantidade_numericUpDown1);
            this.Controls.Add(this.Imagem1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MP1";
            this.Text = "Kit 4 marca páginas florido";
            ((System.ComponentModel.ISupportInitialize)(this.Quantidade_numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Imagem1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown Quantidade_numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Preço_txt;
        private System.Windows.Forms.Label Nome_item_txt;
        private System.Windows.Forms.Button Adicionar_ao_carrinho_btn;
        private System.Windows.Forms.Button Comprar_agora_btn;
        private System.Windows.Forms.Label Quantidade_txt;
        private System.Windows.Forms.Label Número_de_itens_txt;
        private System.Windows.Forms.Label Descrição;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.PictureBox Seta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}