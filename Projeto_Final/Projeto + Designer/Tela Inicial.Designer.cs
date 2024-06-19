namespace Projeto___Designer
{
    partial class Tela_Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Inicial));
            this.Continuar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Continuar_btn
            // 
            this.Continuar_btn.BackColor = System.Drawing.Color.GhostWhite;
            this.Continuar_btn.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continuar_btn.ForeColor = System.Drawing.Color.MediumPurple;
            this.Continuar_btn.Location = new System.Drawing.Point(370, 643);
            this.Continuar_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Continuar_btn.Name = "Continuar_btn";
            this.Continuar_btn.Size = new System.Drawing.Size(320, 62);
            this.Continuar_btn.TabIndex = 0;
            this.Continuar_btn.Text = "Iniciar";
            this.Continuar_btn.UseVisualStyleBackColor = false;
            this.Continuar_btn.Click += new System.EventHandler(this.Continuar_btn_Click);
            // 
            // Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Projeto___Designer.Properties.Resources.IMG_20240606_WA0014;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1035, 760);
            this.Controls.Add(this.Continuar_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Tela_Inicial";
            this.Text = "Tela_Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Continuar_btn;
    }
}