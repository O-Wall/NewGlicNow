namespace FinalGlicNow
{
    partial class ucAgenda
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
            this.lblRegistrar = new System.Windows.Forms.Label();
            this.picMedico = new System.Windows.Forms.PictureBox();
            this.picCalendario = new System.Windows.Forms.PictureBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.dtpDataAgenda = new System.Windows.Forms.DateTimePicker();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtPesquisaTitulo = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.grdAgenda = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCalendario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.AutoSize = true;
            this.lblRegistrar.Location = new System.Drawing.Point(81, 248);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(84, 13);
            this.lblRegistrar.TabIndex = 140;
            this.lblRegistrar.Text = "Registrar tarefas";
            // 
            // picMedico
            // 
            this.picMedico.Location = new System.Drawing.Point(356, 292);
            this.picMedico.Name = "picMedico";
            this.picMedico.Size = new System.Drawing.Size(24, 24);
            this.picMedico.TabIndex = 139;
            this.picMedico.TabStop = false;
            // 
            // picCalendario
            // 
            this.picCalendario.Location = new System.Drawing.Point(84, 292);
            this.picCalendario.Name = "picCalendario";
            this.picCalendario.Size = new System.Drawing.Size(24, 24);
            this.picCalendario.TabIndex = 138;
            this.picCalendario.TabStop = false;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(81, 18);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(74, 13);
            this.lblPesquisar.TabIndex = 137;
            this.lblPesquisar.Text = "Pesquisar por:";
            // 
            // dtpDataAgenda
            // 
            this.dtpDataAgenda.Location = new System.Drawing.Point(84, 60);
            this.dtpDataAgenda.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpDataAgenda.Name = "dtpDataAgenda";
            this.dtpDataAgenda.Size = new System.Drawing.Size(198, 20);
            this.dtpDataAgenda.TabIndex = 129;
            this.dtpDataAgenda.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(84, 419);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 41);
            this.btnLimpar.TabIndex = 135;
            this.btnLimpar.Text = "&Limpar Observação";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(575, 419);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(107, 41);
            this.btnGravar.TabIndex = 134;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtPesquisaTitulo
            // 
            this.txtPesquisaTitulo.BackColor = System.Drawing.Color.White;
            this.txtPesquisaTitulo.Location = new System.Drawing.Point(84, 34);
            this.txtPesquisaTitulo.Name = "txtPesquisaTitulo";
            this.txtPesquisaTitulo.Size = new System.Drawing.Size(598, 20);
            this.txtPesquisaTitulo.TabIndex = 128;
            this.txtPesquisaTitulo.Text = "Título";
            this.txtPesquisaTitulo.TextChanged += new System.EventHandler(this.txtPesquisaTitulo_TextChanged);
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.Color.White;
            this.txtObservacao.Location = new System.Drawing.Point(84, 322);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(598, 86);
            this.txtObservacao.TabIndex = 133;
            this.txtObservacao.Text = "Observações";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(84, 266);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(598, 20);
            this.txtTitulo.TabIndex = 130;
            this.txtTitulo.Text = "Título";
            // 
            // txtMedico
            // 
            this.txtMedico.BackColor = System.Drawing.Color.White;
            this.txtMedico.Location = new System.Drawing.Point(386, 296);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(296, 20);
            this.txtMedico.TabIndex = 132;
            this.txtMedico.Text = "Nome do Medico";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(114, 296);
            this.dtpData.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 131;
            this.dtpData.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // grdAgenda
            // 
            this.grdAgenda.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grdAgenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAgenda.Location = new System.Drawing.Point(84, 86);
            this.grdAgenda.Name = "grdAgenda";
            this.grdAgenda.Size = new System.Drawing.Size(598, 144);
            this.grdAgenda.TabIndex = 136;
            this.grdAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAgenda_CellClick);
            // 
            // ucAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(96)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.lblRegistrar);
            this.Controls.Add(this.picMedico);
            this.Controls.Add(this.picCalendario);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.dtpDataAgenda);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtPesquisaTitulo);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.grdAgenda);
            this.Name = "ucAgenda";
            this.Size = new System.Drawing.Size(763, 479);
            this.Load += new System.EventHandler(this.ucAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCalendario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrar;
        private System.Windows.Forms.PictureBox picMedico;
        private System.Windows.Forms.PictureBox picCalendario;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.DateTimePicker dtpDataAgenda;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtPesquisaTitulo;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridView grdAgenda;
    }
}
