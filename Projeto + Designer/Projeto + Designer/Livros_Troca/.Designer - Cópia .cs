namespace Projeto___Designer
{
    partial class A_mente_de_Adolf_Hitler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_mente_de_Adolf_Hitler));
            this.Imagem1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Nome_item_txt = new System.Windows.Forms.Label();
            this.Solicitar_empréstimo_btn = new System.Windows.Forms.Button();
            this.Solicitar_Troca_btn = new System.Windows.Forms.Button();
            this.Descrição = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.Imagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // Imagem1
            // 
            this.Imagem1.Image = ((System.Drawing.Image)(resources.GetObject("Imagem1.Image")));
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
            this.pictureBox3.Location = new System.Drawing.Point(26, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(705, 350);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Nome_item_txt
            // 
            this.Nome_item_txt.AutoSize = true;
            this.Nome_item_txt.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_item_txt.Location = new System.Drawing.Point(312, 128);
            this.Nome_item_txt.Name = "Nome_item_txt";
            this.Nome_item_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Nome_item_txt.Size = new System.Drawing.Size(232, 25);
            this.Nome_item_txt.TabIndex = 6;
            this.Nome_item_txt.Text = "A mente de Adolf Hitler";
            // 
            // Solicitar_empréstimo_btn
            // 
            this.Solicitar_empréstimo_btn.BackColor = System.Drawing.Color.Lavender;
            this.Solicitar_empréstimo_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Solicitar_empréstimo_btn.ForeColor = System.Drawing.Color.MediumPurple;
            this.Solicitar_empréstimo_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Solicitar_empréstimo_btn.Location = new System.Drawing.Point(343, 351);
            this.Solicitar_empréstimo_btn.Name = "Solicitar_empréstimo_btn";
            this.Solicitar_empréstimo_btn.Size = new System.Drawing.Size(118, 34);
            this.Solicitar_empréstimo_btn.TabIndex = 7;
            this.Solicitar_empréstimo_btn.Text = "Solicitar empréstimo";
            this.Solicitar_empréstimo_btn.UseVisualStyleBackColor = false;
            this.Solicitar_empréstimo_btn.Click += new System.EventHandler(this.Solicitar_empréstimo_Click);
            // 
            // Solicitar_Troca_btn
            // 
            this.Solicitar_Troca_btn.BackColor = System.Drawing.Color.MediumPurple;
            this.Solicitar_Troca_btn.ForeColor = System.Drawing.Color.GhostWhite;
            this.Solicitar_Troca_btn.Location = new System.Drawing.Point(536, 351);
            this.Solicitar_Troca_btn.Name = "Solicitar_Troca_btn";
            this.Solicitar_Troca_btn.Size = new System.Drawing.Size(132, 34);
            this.Solicitar_Troca_btn.TabIndex = 8;
            this.Solicitar_Troca_btn.Text = "Solicitar Troca";
            this.Solicitar_Troca_btn.UseVisualStyleBackColor = false;
            this.Solicitar_Troca_btn.Click += new System.EventHandler(this.Solicitar_Troca_Click);
            // 
            // Descrição
            // 
            this.Descrição.AutoSize = true;
            this.Descrição.BackColor = System.Drawing.Color.Lavender;
            this.Descrição.Font = new System.Drawing.Font("MV Boli", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descrição.Location = new System.Drawing.Point(314, 171);
            this.Descrição.Name = "Descrição";
            this.Descrição.Size = new System.Drawing.Size(395, 143);
            this.Descrição.TabIndex = 11;
            this.Descrição.Text = resources.GetString("Descrição.Text");
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // A_mente_de_Adolf_Hitler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(743, 493);
            this.Controls.Add(this.Descrição);
            this.Controls.Add(this.Solicitar_Troca_btn);
            this.Controls.Add(this.Solicitar_empréstimo_btn);
            this.Controls.Add(this.Nome_item_txt);
            this.Controls.Add(this.Imagem1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "A_mente_de_Adolf_Hitler";
            this.Text = "A mente de Adolf Hitler";
            ((System.ComponentModel.ISupportInitialize)(this.Imagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Imagem1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Nome_item_txt;
        private System.Windows.Forms.Button Solicitar_empréstimo_btn;
        private System.Windows.Forms.Button Solicitar_Troca_btn;
        private System.Windows.Forms.Label Descrição;
        private System.Diagnostics.EventLog eventLog1;
    }
}