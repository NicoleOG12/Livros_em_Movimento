namespace Projeto___Designer
{
    partial class Exibir_Livros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exibir_Livros));
            this.Imagem1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Nome_item_txt = new System.Windows.Forms.Label();
            this.Adicionar_ao_carrinho_btn = new System.Windows.Forms.Button();
            this.Comprar_agora_btn = new System.Windows.Forms.Button();
            this.Descrição = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.Seta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seta)).BeginInit();
            this.SuspendLayout();
            // 
            // Imagem1
            // 
            this.Imagem1.Location = new System.Drawing.Point(129, 180);
            this.Imagem1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Imagem1.Name = "Imagem1";
            this.Imagem1.Size = new System.Drawing.Size(264, 375);
            this.Imagem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagem1.TabIndex = 0;
            this.Imagem1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.pictureBox2.Location = new System.Drawing.Point(39, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1058, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBox3.Location = new System.Drawing.Point(39, 145);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1058, 538);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Nome_item_txt
            // 
            this.Nome_item_txt.AutoSize = true;
            this.Nome_item_txt.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_item_txt.Location = new System.Drawing.Point(468, 197);
            this.Nome_item_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nome_item_txt.Name = "Nome_item_txt";
            this.Nome_item_txt.Size = new System.Drawing.Size(261, 39);
            this.Nome_item_txt.TabIndex = 6;
            this.Nome_item_txt.Text = "Nome do Produto";
            // 
            // Adicionar_ao_carrinho_btn
            // 
            this.Adicionar_ao_carrinho_btn.BackColor = System.Drawing.Color.Lavender;
            this.Adicionar_ao_carrinho_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Adicionar_ao_carrinho_btn.ForeColor = System.Drawing.Color.MediumPurple;
            this.Adicionar_ao_carrinho_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Adicionar_ao_carrinho_btn.Location = new System.Drawing.Point(504, 554);
            this.Adicionar_ao_carrinho_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Adicionar_ao_carrinho_btn.Name = "Adicionar_ao_carrinho_btn";
            this.Adicionar_ao_carrinho_btn.Size = new System.Drawing.Size(219, 52);
            this.Adicionar_ao_carrinho_btn.TabIndex = 7;
            this.Adicionar_ao_carrinho_btn.Text = "Troca";
            this.Adicionar_ao_carrinho_btn.UseVisualStyleBackColor = false;
            this.Adicionar_ao_carrinho_btn.Click += new System.EventHandler(this.Adicionar_ao_carrinho_Click);
            // 
            // Comprar_agora_btn
            // 
            this.Comprar_agora_btn.BackColor = System.Drawing.Color.MediumPurple;
            this.Comprar_agora_btn.ForeColor = System.Drawing.Color.GhostWhite;
            this.Comprar_agora_btn.Location = new System.Drawing.Point(806, 554);
            this.Comprar_agora_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Comprar_agora_btn.Name = "Comprar_agora_btn";
            this.Comprar_agora_btn.Size = new System.Drawing.Size(198, 52);
            this.Comprar_agora_btn.TabIndex = 8;
            this.Comprar_agora_btn.Text = "Emprestimo";
            this.Comprar_agora_btn.UseVisualStyleBackColor = false;
            this.Comprar_agora_btn.Click += new System.EventHandler(this.Comprar_agora_Click);
            // 
            // Descrição
            // 
            this.Descrição.AutoSize = true;
            this.Descrição.BackColor = System.Drawing.Color.Lavender;
            this.Descrição.Font = new System.Drawing.Font("MV Boli", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descrição.Location = new System.Drawing.Point(471, 263);
            this.Descrição.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Descrição.Name = "Descrição";
            this.Descrição.Size = new System.Drawing.Size(67, 18);
            this.Descrição.TabIndex = 11;
            this.Descrição.Text = "Descrição";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Seta
            // 
            this.Seta.BackColor = System.Drawing.Color.MediumPurple;
            this.Seta.Image = global::Projeto___Designer.Properties.Resources.Seta1;
            this.Seta.Location = new System.Drawing.Point(39, 37);
            this.Seta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Seta.Name = "Seta";
            this.Seta.Size = new System.Drawing.Size(111, 77);
            this.Seta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Seta.TabIndex = 13;
            this.Seta.TabStop = false;
            this.Seta.Click += new System.EventHandler(this.Seta_Click);
            // 
            // Exibir_Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1114, 749);
            this.Controls.Add(this.Seta);
            this.Controls.Add(this.Descrição);
            this.Controls.Add(this.Comprar_agora_btn);
            this.Controls.Add(this.Adicionar_ao_carrinho_btn);
            this.Controls.Add(this.Nome_item_txt);
            this.Controls.Add(this.Imagem1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exibir_Livros";
            this.Text = "A Garota do Lago";
            ((System.ComponentModel.ISupportInitialize)(this.Imagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Imagem1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Nome_item_txt;
        private System.Windows.Forms.Button Adicionar_ao_carrinho_btn;
        private System.Windows.Forms.Button Comprar_agora_btn;
        private System.Windows.Forms.Label Descrição;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.PictureBox Seta;
    }
}