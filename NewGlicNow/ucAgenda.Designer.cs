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
            this.picMedico = new System.Windows.Forms.PictureBox();
            this.picCalendario = new System.Windows.Forms.PictureBox();
            this.dtpDataAgenda = new System.Windows.Forms.DateTimePicker();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtPesquisaTitulo = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.grdAgenda = new System.Windows.Forms.DataGridView();
            this.gprPesquisar = new System.Windows.Forms.GroupBox();
            this.grpRegistrar = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCalendario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgenda)).BeginInit();
            this.gprPesquisar.SuspendLayout();
            this.grpRegistrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMedico
            // 
            this.picMedico.Location = new System.Drawing.Point(283, 45);
            this.picMedico.Name = "picMedico";
            this.picMedico.Size = new System.Drawing.Size(24, 24);
            this.picMedico.TabIndex = 139;
            this.picMedico.TabStop = false;
            // 
            // picCalendario
            // 
            this.picCalendario.Location = new System.Drawing.Point(11, 45);
            this.picCalendario.Name = "picCalendario";
            this.picCalendario.Size = new System.Drawing.Size(24, 24);
            this.picCalendario.TabIndex = 138;
            this.picCalendario.TabStop = false;
            // 
            // dtpDataAgenda
            // 
            this.dtpDataAgenda.Location = new System.Drawing.Point(11, 45);
            this.dtpDataAgenda.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpDataAgenda.Name = "dtpDataAgenda";
            this.dtpDataAgenda.Size = new System.Drawing.Size(215, 20);
            this.dtpDataAgenda.TabIndex = 129;
            this.dtpDataAgenda.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(84, 424);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 41);
            this.btnLimpar.TabIndex = 135;
            this.btnLimpar.Text = "&Limpar Observação";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(575, 424);
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
            this.txtPesquisaTitulo.Location = new System.Drawing.Point(11, 19);
            this.txtPesquisaTitulo.Name = "txtPesquisaTitulo";
            this.txtPesquisaTitulo.Size = new System.Drawing.Size(598, 20);
            this.txtPesquisaTitulo.TabIndex = 128;
            this.txtPesquisaTitulo.Text = "Título";
            this.txtPesquisaTitulo.TextChanged += new System.EventHandler(this.txtPesquisaTitulo_TextChanged);
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.Color.White;
            this.txtObservacao.Location = new System.Drawing.Point(11, 75);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(598, 86);
            this.txtObservacao.TabIndex = 133;
            this.txtObservacao.Text = "Observações";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(11, 19);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(598, 20);
            this.txtTitulo.TabIndex = 130;
            this.txtTitulo.Text = "Título";
            // 
            // txtMedico
            // 
            this.txtMedico.BackColor = System.Drawing.Color.White;
            this.txtMedico.Location = new System.Drawing.Point(313, 49);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(296, 20);
            this.txtMedico.TabIndex = 132;
            this.txtMedico.Text = "Nome do Medico";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(41, 49);
            this.dtpData.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(212, 20);
            this.dtpData.TabIndex = 131;
            this.dtpData.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // grdAgenda
            // 
            this.grdAgenda.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grdAgenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAgenda.Location = new System.Drawing.Point(73, 89);
            this.grdAgenda.Name = "grdAgenda";
            this.grdAgenda.Size = new System.Drawing.Size(618, 144);
            this.grdAgenda.TabIndex = 136;
            this.grdAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAgenda_CellClick);
            // 
            // gprPesquisar
            // 
            this.gprPesquisar.Controls.Add(this.txtPesquisaTitulo);
            this.gprPesquisar.Controls.Add(this.dtpDataAgenda);
            this.gprPesquisar.Location = new System.Drawing.Point(73, 8);
            this.gprPesquisar.Name = "gprPesquisar";
            this.gprPesquisar.Size = new System.Drawing.Size(618, 75);
            this.gprPesquisar.TabIndex = 141;
            this.gprPesquisar.TabStop = false;
            this.gprPesquisar.Text = "Pesquisar por";
            // 
            // grpRegistrar
            // 
            this.grpRegistrar.Controls.Add(this.txtObservacao);
            this.grpRegistrar.Controls.Add(this.dtpData);
            this.grpRegistrar.Controls.Add(this.picMedico);
            this.grpRegistrar.Controls.Add(this.txtMedico);
            this.grpRegistrar.Controls.Add(this.picCalendario);
            this.grpRegistrar.Controls.Add(this.txtTitulo);
            this.grpRegistrar.Location = new System.Drawing.Point(73, 248);
            this.grpRegistrar.Name = "grpRegistrar";
            this.grpRegistrar.Size = new System.Drawing.Size(618, 170);
            this.grpRegistrar.TabIndex = 142;
            this.grpRegistrar.TabStop = false;
            this.grpRegistrar.Text = "Registrar Tarefa";
            // 
            // ucAgenda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(96)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.grdAgenda);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.gprPesquisar);
            this.Controls.Add(this.grpRegistrar);
            this.Name = "ucAgenda";
            this.Size = new System.Drawing.Size(763, 479);
            this.Load += new System.EventHandler(this.ucAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCalendario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgenda)).EndInit();
            this.gprPesquisar.ResumeLayout(false);
            this.gprPesquisar.PerformLayout();
            this.grpRegistrar.ResumeLayout(false);
            this.grpRegistrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picMedico;
        private System.Windows.Forms.PictureBox picCalendario;
        private System.Windows.Forms.DateTimePicker dtpDataAgenda;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtPesquisaTitulo;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridView grdAgenda;
        private System.Windows.Forms.GroupBox gprPesquisar;
        private System.Windows.Forms.GroupBox grpRegistrar;
    }
}
