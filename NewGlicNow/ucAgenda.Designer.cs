namespace NewGlicNow
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
            this.grdAgenda = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.gprPesquisar = new System.Windows.Forms.GroupBox();
            this.rdbPesquisarDesativados = new System.Windows.Forms.RadioButton();
            this.rdbPesquisarAtivos = new System.Windows.Forms.RadioButton();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.dtpDataAgendaFim = new System.Windows.Forms.DateTimePicker();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dtpDataAgendaInicio = new System.Windows.Forms.DateTimePicker();
            this.grpRegistrar = new System.Windows.Forms.GroupBox();
            this.rdbDesativado = new System.Windows.Forms.RadioButton();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.picMedico = new System.Windows.Forms.PictureBox();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.picCalendario = new System.Windows.Forms.PictureBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgenda)).BeginInit();
            this.gprPesquisar.SuspendLayout();
            this.grpRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCalendario)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAgenda
            // 
            this.grdAgenda.AllowUserToAddRows = false;
            this.grdAgenda.AllowUserToDeleteRows = false;
            this.grdAgenda.AllowUserToResizeColumns = false;
            this.grdAgenda.AllowUserToResizeRows = false;
            this.grdAgenda.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grdAgenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAgenda.Location = new System.Drawing.Point(73, 69);
            this.grdAgenda.Name = "grdAgenda";
            this.grdAgenda.ReadOnly = true;
            this.grdAgenda.RowHeadersVisible = false;
            this.grdAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAgenda.Size = new System.Drawing.Size(618, 173);
            this.grdAgenda.TabIndex = 145;
            this.grdAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAgenda_CellClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.Location = new System.Drawing.Point(73, 424);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 41);
            this.btnLimpar.TabIndex = 144;
            this.btnLimpar.Text = "&Limpar Observação";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.White;
            this.btnGravar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGravar.Location = new System.Drawing.Point(584, 424);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(107, 41);
            this.btnGravar.TabIndex = 143;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // gprPesquisar
            // 
            this.gprPesquisar.Controls.Add(this.rdbPesquisarDesativados);
            this.gprPesquisar.Controls.Add(this.rdbPesquisarAtivos);
            this.gprPesquisar.Controls.Add(this.lblDataFim);
            this.gprPesquisar.Controls.Add(this.dtpDataAgendaFim);
            this.gprPesquisar.Controls.Add(this.lblDataInicio);
            this.gprPesquisar.Controls.Add(this.btnPesquisar);
            this.gprPesquisar.Controls.Add(this.dtpDataAgendaInicio);
            this.gprPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gprPesquisar.ForeColor = System.Drawing.Color.White;
            this.gprPesquisar.Location = new System.Drawing.Point(73, 8);
            this.gprPesquisar.Name = "gprPesquisar";
            this.gprPesquisar.Size = new System.Drawing.Size(618, 55);
            this.gprPesquisar.TabIndex = 146;
            this.gprPesquisar.TabStop = false;
            this.gprPesquisar.Text = "Pesquisar por";
            // 
            // rdbPesquisarDesativados
            // 
            this.rdbPesquisarDesativados.AutoSize = true;
            this.rdbPesquisarDesativados.Location = new System.Drawing.Point(515, 23);
            this.rdbPesquisarDesativados.Name = "rdbPesquisarDesativados";
            this.rdbPesquisarDesativados.Size = new System.Drawing.Size(99, 21);
            this.rdbPesquisarDesativados.TabIndex = 143;
            this.rdbPesquisarDesativados.Text = "Desativados";
            this.rdbPesquisarDesativados.UseVisualStyleBackColor = true;
            // 
            // rdbPesquisarAtivos
            // 
            this.rdbPesquisarAtivos.AutoSize = true;
            this.rdbPesquisarAtivos.Checked = true;
            this.rdbPesquisarAtivos.Location = new System.Drawing.Point(450, 23);
            this.rdbPesquisarAtivos.Name = "rdbPesquisarAtivos";
            this.rdbPesquisarAtivos.Size = new System.Drawing.Size(64, 21);
            this.rdbPesquisarAtivos.TabIndex = 142;
            this.rdbPesquisarAtivos.TabStop = true;
            this.rdbPesquisarAtivos.Text = "Ativos";
            this.rdbPesquisarAtivos.UseVisualStyleBackColor = true;
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFim.ForeColor = System.Drawing.Color.White;
            this.lblDataFim.Location = new System.Drawing.Point(278, 28);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(58, 13);
            this.lblDataFim.TabIndex = 135;
            this.lblDataFim.Text = "Data Final:";
            // 
            // dtpDataAgendaFim
            // 
            this.dtpDataAgendaFim.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dtpDataAgendaFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAgendaFim.Location = new System.Drawing.Point(345, 25);
            this.dtpDataAgendaFim.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpDataAgendaFim.Name = "dtpDataAgendaFim";
            this.dtpDataAgendaFim.Size = new System.Drawing.Size(97, 20);
            this.dtpDataAgendaFim.TabIndex = 133;
            this.dtpDataAgendaFim.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.ForeColor = System.Drawing.Color.White;
            this.lblDataInicio.Location = new System.Drawing.Point(94, 27);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(63, 13);
            this.lblDataInicio.TabIndex = 134;
            this.lblDataInicio.Text = "Data Inicial:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisar.Location = new System.Drawing.Point(11, 20);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(77, 26);
            this.btnPesquisar.TabIndex = 131;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtpDataAgendaInicio
            // 
            this.dtpDataAgendaInicio.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dtpDataAgendaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAgendaInicio.Location = new System.Drawing.Point(166, 24);
            this.dtpDataAgendaInicio.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpDataAgendaInicio.Name = "dtpDataAgendaInicio";
            this.dtpDataAgendaInicio.Size = new System.Drawing.Size(97, 20);
            this.dtpDataAgendaInicio.TabIndex = 132;
            this.dtpDataAgendaInicio.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // grpRegistrar
            // 
            this.grpRegistrar.Controls.Add(this.rdbDesativado);
            this.grpRegistrar.Controls.Add(this.rdbAtivo);
            this.grpRegistrar.Controls.Add(this.txtObservacao);
            this.grpRegistrar.Controls.Add(this.dtpData);
            this.grpRegistrar.Controls.Add(this.picMedico);
            this.grpRegistrar.Controls.Add(this.txtMedico);
            this.grpRegistrar.Controls.Add(this.picCalendario);
            this.grpRegistrar.Controls.Add(this.txtTitulo);
            this.grpRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpRegistrar.ForeColor = System.Drawing.Color.White;
            this.grpRegistrar.Location = new System.Drawing.Point(73, 248);
            this.grpRegistrar.Name = "grpRegistrar";
            this.grpRegistrar.Size = new System.Drawing.Size(618, 170);
            this.grpRegistrar.TabIndex = 147;
            this.grpRegistrar.TabStop = false;
            this.grpRegistrar.Text = "Registrar Tarefa";
            // 
            // rdbDesativado
            // 
            this.rdbDesativado.AutoSize = true;
            this.rdbDesativado.Location = new System.Drawing.Point(226, 48);
            this.rdbDesativado.Name = "rdbDesativado";
            this.rdbDesativado.Size = new System.Drawing.Size(93, 21);
            this.rdbDesativado.TabIndex = 141;
            this.rdbDesativado.Text = "Desativado";
            this.rdbDesativado.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Checked = true;
            this.rdbAtivo.Location = new System.Drawing.Point(149, 48);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(58, 21);
            this.rdbAtivo.TabIndex = 140;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.Color.White;
            this.txtObservacao.Font = new System.Drawing.Font("Arial", 8F);
            this.txtObservacao.Location = new System.Drawing.Point(11, 75);
            this.txtObservacao.MaxLength = 1000;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(598, 86);
            this.txtObservacao.TabIndex = 133;
            this.txtObservacao.Text = "Observações";
            this.txtObservacao.Enter += new System.EventHandler(this.txtObservacao_Enter);
            this.txtObservacao.Leave += new System.EventHandler(this.txtObservacao_Leave);
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Arial", 8F);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(41, 49);
            this.dtpData.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(92, 20);
            this.dtpData.TabIndex = 131;
            this.dtpData.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // picMedico
            // 
            this.picMedico.Image = global::NewGlicNow.Properties.Resources.Medico____ucAgenda___Branco;
            this.picMedico.Location = new System.Drawing.Point(325, 47);
            this.picMedico.Name = "picMedico";
            this.picMedico.Size = new System.Drawing.Size(22, 22);
            this.picMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMedico.TabIndex = 139;
            this.picMedico.TabStop = false;
            // 
            // txtMedico
            // 
            this.txtMedico.BackColor = System.Drawing.Color.White;
            this.txtMedico.Font = new System.Drawing.Font("Arial", 8F);
            this.txtMedico.Location = new System.Drawing.Point(353, 49);
            this.txtMedico.MaxLength = 100;
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(256, 20);
            this.txtMedico.TabIndex = 132;
            this.txtMedico.Text = "Nome do Medico";
            this.txtMedico.Enter += new System.EventHandler(this.txtMedico_Enter);
            this.txtMedico.Leave += new System.EventHandler(this.txtMedico_Leave);
            // 
            // picCalendario
            // 
            this.picCalendario.Image = global::NewGlicNow.Properties.Resources.Calendario___ucAgenda___Branco;
            this.picCalendario.Location = new System.Drawing.Point(11, 46);
            this.picCalendario.Name = "picCalendario";
            this.picCalendario.Size = new System.Drawing.Size(24, 24);
            this.picCalendario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCalendario.TabIndex = 138;
            this.picCalendario.TabStop = false;
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.White;
            this.txtTitulo.Font = new System.Drawing.Font("Arial", 8F);
            this.txtTitulo.Location = new System.Drawing.Point(11, 19);
            this.txtTitulo.MaxLength = 150;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(598, 20);
            this.txtTitulo.TabIndex = 130;
            this.txtTitulo.Text = "Título";
            this.txtTitulo.Enter += new System.EventHandler(this.txtTitulo_Enter);
            this.txtTitulo.Leave += new System.EventHandler(this.txtTitulo_Leave);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.Location = new System.Drawing.Point(328, 424);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(107, 41);
            this.btnExcluir.TabIndex = 148;
            this.btnExcluir.Text = "&Excluir Registro";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // ucAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(63)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.grdAgenda);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.gprPesquisar);
            this.Controls.Add(this.grpRegistrar);
            this.Name = "ucAgenda";
            this.Size = new System.Drawing.Size(763, 479);
            this.Load += new System.EventHandler(this.ucAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAgenda)).EndInit();
            this.gprPesquisar.ResumeLayout(false);
            this.gprPesquisar.PerformLayout();
            this.grpRegistrar.ResumeLayout(false);
            this.grpRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCalendario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAgenda;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox gprPesquisar;
        private System.Windows.Forms.GroupBox grpRegistrar;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.PictureBox picMedico;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.PictureBox picCalendario;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.DateTimePicker dtpDataAgendaInicio;
        private System.Windows.Forms.DateTimePicker dtpDataAgendaFim;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton rdbPesquisarDesativados;
        private System.Windows.Forms.RadioButton rdbPesquisarAtivos;
        private System.Windows.Forms.RadioButton rdbDesativado;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnExcluir;
    }
}
