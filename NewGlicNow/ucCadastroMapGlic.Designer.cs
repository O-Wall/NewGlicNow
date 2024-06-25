namespace NewGlicNow
{
    partial class ucCadastroMapGlic
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValores = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblValores = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValores
            // 
            this.txtValores.Location = new System.Drawing.Point(138, 65);
            this.txtValores.MaxLength = 5;
            this.txtValores.Name = "txtValores";
            this.txtValores.Size = new System.Drawing.Size(100, 20);
            this.txtValores.TabIndex = 13;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(138, 97);
            this.txtObservacao.MaxLength = 1000;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(484, 60);
            this.txtObservacao.TabIndex = 12;
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(138, 29);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(152, 21);
            this.cboPeriodo.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(25, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 265);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblValores
            // 
            this.lblValores.AutoSize = true;
            this.lblValores.Location = new System.Drawing.Point(32, 65);
            this.lblValores.Name = "lblValores";
            this.lblValores.Size = new System.Drawing.Size(100, 13);
            this.lblValores.TabIndex = 9;
            this.lblValores.Text = "Valores da Glicemia";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(32, 29);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(45, 13);
            this.lblPeriodo.TabIndex = 8;
            this.lblPeriodo.Text = "Período";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(32, 100);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 7;
            this.lblObservacao.Text = "Observação";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtValores);
            this.panel1.Controls.Add(this.cboPeriodo);
            this.panel1.Controls.Add(this.txtObservacao);
            this.panel1.Controls.Add(this.lblObservacao);
            this.panel1.Controls.Add(this.lblPeriodo);
            this.panel1.Controls.Add(this.lblValores);
            this.panel1.Location = new System.Drawing.Point(25, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 174);
            this.panel1.TabIndex = 14;
            // 
            // ucCadastroMapGlic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ucCadastroMapGlic";
            this.Size = new System.Drawing.Size(684, 496);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtValores;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblValores;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Panel panel1;
    }
}
