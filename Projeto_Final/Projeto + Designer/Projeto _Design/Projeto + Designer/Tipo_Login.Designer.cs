namespace Projeto___Designer
{
    partial class TipoLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoLogin));
            this.Login_txt = new System.Windows.Forms.Label();
            this.caixalogin = new System.Windows.Forms.GroupBox();
            this.ADM = new System.Windows.Forms.Button();
            this.Usuário_btn = new System.Windows.Forms.Button();
            this.caixalogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_txt
            // 
            this.Login_txt.AutoSize = true;
            this.Login_txt.Font = new System.Drawing.Font("MV Boli", 15.16F, System.Drawing.FontStyle.Bold);
            this.Login_txt.ForeColor = System.Drawing.Color.MediumPurple;
            this.Login_txt.Location = new System.Drawing.Point(88, 30);
            this.Login_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login_txt.Name = "Login_txt";
            this.Login_txt.Size = new System.Drawing.Size(125, 28);
            this.Login_txt.TabIndex = 4;
            this.Login_txt.Text = "Você é um";
            // 
            // caixalogin
            // 
            this.caixalogin.BackColor = System.Drawing.Color.GhostWhite;
            this.caixalogin.Controls.Add(this.ADM);
            this.caixalogin.Controls.Add(this.Usuário_btn);
            this.caixalogin.Controls.Add(this.Login_txt);
            this.caixalogin.Location = new System.Drawing.Point(258, 71);
            this.caixalogin.Name = "caixalogin";
            this.caixalogin.Size = new System.Drawing.Size(302, 244);
            this.caixalogin.TabIndex = 7;
            this.caixalogin.TabStop = false;
            // 
            // ADM
            // 
            this.ADM.BackColor = System.Drawing.Color.MediumPurple;
            this.ADM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ADM.CausesValidation = false;
            this.ADM.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ADM.Location = new System.Drawing.Point(73, 156);
            this.ADM.Name = "ADM";
            this.ADM.Size = new System.Drawing.Size(158, 34);
            this.ADM.TabIndex = 7;
            this.ADM.Text = "Administrador";
            this.ADM.UseVisualStyleBackColor = false;
            this.ADM.Click += new System.EventHandler(this.ADM_Click);
            // 
            // Usuário_btn
            // 
            this.Usuário_btn.BackColor = System.Drawing.Color.MediumPurple;
            this.Usuário_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Usuário_btn.CausesValidation = false;
            this.Usuário_btn.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuário_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Usuário_btn.Location = new System.Drawing.Point(73, 87);
            this.Usuário_btn.Name = "Usuário_btn";
            this.Usuário_btn.Size = new System.Drawing.Size(158, 34);
            this.Usuário_btn.TabIndex = 6;
            this.Usuário_btn.Text = "Usuário";
            this.Usuário_btn.UseVisualStyleBackColor = false;
            this.Usuário_btn.Click += new System.EventHandler(this.Usuário_btn_Click);
            // 
            // TipoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImage = global::Projeto___Designer.Properties.Resources._3d_background_purple_background_abstract_background_windows_2560x1080_8292;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 423);
            this.Controls.Add(this.caixalogin);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TipoLogin";
            this.Text = "Login";
            this.caixalogin.ResumeLayout(false);
            this.caixalogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Login_txt;
        private System.Windows.Forms.GroupBox caixalogin;
        private System.Windows.Forms.Button Usuário_btn;
        private System.Windows.Forms.Button ADM;
    }
}

