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
            this.lblValores = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.dgvMapaGlic = new System.Windows.Forms.DataGridView();
            this.grpRegistrar = new System.Windows.Forms.GroupBox();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.btnMapa = new System.Windows.Forms.Button();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.picPesquisa = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.grbBasal = new System.Windows.Forms.GroupBox();
            this.ckbNoturno = new System.Windows.Forms.CheckBox();
            this.ckbMatutino = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapaGlic)).BeginInit();
            this.grpRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPesquisa)).BeginInit();
            this.grbBasal.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValores
            // 
            this.txtValores.Font = new System.Drawing.Font("Arial", 8.25F);
            this.txtValores.Location = new System.Drawing.Point(150, 63);
            this.txtValores.MaxLength = 3;
            this.txtValores.Name = "txtValores";
            this.txtValores.Size = new System.Drawing.Size(100, 20);
            this.txtValores.TabIndex = 13;
            this.txtValores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValores_KeyPress);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Arial", 8.25F);
            this.txtObservacao.Location = new System.Drawing.Point(106, 98);
            this.txtObservacao.MaxLength = 100;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(484, 60);
            this.txtObservacao.TabIndex = 12;
            // 
            // lblValores
            // 
            this.lblValores.AutoSize = true;
            this.lblValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValores.ForeColor = System.Drawing.Color.White;
            this.lblValores.Location = new System.Drawing.Point(27, 67);
            this.lblValores.Name = "lblValores";
            this.lblValores.Size = new System.Drawing.Size(103, 13);
            this.lblValores.TabIndex = 9;
            this.lblValores.Text = "Valores da Glicemia:";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.ForeColor = System.Drawing.Color.White;
            this.lblPeriodo.Location = new System.Drawing.Point(27, 32);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(48, 13);
            this.lblPeriodo.TabIndex = 8;
            this.lblPeriodo.Text = "Período:";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.ForeColor = System.Drawing.Color.White;
            this.lblObservacao.Location = new System.Drawing.Point(27, 98);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(68, 13);
            this.lblObservacao.TabIndex = 7;
            this.lblObservacao.Text = "Observação:";
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.White;
            this.btnGravar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGravar.Location = new System.Drawing.Point(599, 419);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(103, 35);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // dgvMapaGlic
            // 
            this.dgvMapaGlic.AllowUserToAddRows = false;
            this.dgvMapaGlic.AllowUserToDeleteRows = false;
            this.dgvMapaGlic.AllowUserToResizeColumns = false;
            this.dgvMapaGlic.AllowUserToResizeRows = false;
            this.dgvMapaGlic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMapaGlic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMapaGlic.Location = new System.Drawing.Point(56, 46);
            this.dgvMapaGlic.MultiSelect = false;
            this.dgvMapaGlic.Name = "dgvMapaGlic";
            this.dgvMapaGlic.ReadOnly = true;
            this.dgvMapaGlic.RowHeadersVisible = false;
            this.dgvMapaGlic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMapaGlic.Size = new System.Drawing.Size(661, 182);
            this.dgvMapaGlic.TabIndex = 16;
            this.dgvMapaGlic.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMapaGlic_CellClick);
            // 
            // grpRegistrar
            // 
            this.grpRegistrar.Controls.Add(this.grbBasal);
            this.grpRegistrar.Controls.Add(this.lblData);
            this.grpRegistrar.Controls.Add(this.dtpData);
            this.grpRegistrar.Controls.Add(this.cboPeriodo);
            this.grpRegistrar.Controls.Add(this.txtValores);
            this.grpRegistrar.Controls.Add(this.txtObservacao);
            this.grpRegistrar.Controls.Add(this.lblValores);
            this.grpRegistrar.Controls.Add(this.lblPeriodo);
            this.grpRegistrar.Controls.Add(this.lblObservacao);
            this.grpRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpRegistrar.ForeColor = System.Drawing.Color.White;
            this.grpRegistrar.Location = new System.Drawing.Point(73, 234);
            this.grpRegistrar.Name = "grpRegistrar";
            this.grpRegistrar.Size = new System.Drawing.Size(629, 171);
            this.grpRegistrar.TabIndex = 17;
            this.grpRegistrar.TabStop = false;
            this.grpRegistrar.Text = "Registrar dados";
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.Font = new System.Drawing.Font("Arial", 8F);
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Items.AddRange(new object[] {
            "Pre-Café",
            "Pós-Café",
            "Pre-Almoço",
            "Pós-Almoço",
            "Pre-Jantar",
            "Pós-Jantar"});
            this.cboPeriodo.Location = new System.Drawing.Point(81, 28);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(169, 22);
            this.cboPeriodo.TabIndex = 14;
            // 
            // btnMapa
            // 
            this.btnMapa.BackColor = System.Drawing.Color.White;
            this.btnMapa.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMapa.Location = new System.Drawing.Point(73, 419);
            this.btnMapa.Name = "btnMapa";
            this.btnMapa.Size = new System.Drawing.Size(112, 35);
            this.btnMapa.TabIndex = 18;
            this.btnMapa.Text = "&Mapa de Glicemia";
            this.btnMapa.UseVisualStyleBackColor = false;
            this.btnMapa.Click += new System.EventHandler(this.btnMapa_Click);
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(338, 15);
            this.dtpDataInicio.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(97, 20);
            this.dtpDataInicio.TabIndex = 15;
            this.dtpDataInicio.Value = new System.DateTime(2024, 6, 25, 0, 0, 0, 0);
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.Location = new System.Drawing.Point(516, 15);
            this.dtpDataFim.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(97, 20);
            this.dtpDataFim.TabIndex = 19;
            this.dtpDataFim.Value = new System.DateTime(2024, 6, 25, 0, 0, 0, 0);
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.ForeColor = System.Drawing.Color.White;
            this.lblDataInicio.Location = new System.Drawing.Point(267, 19);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(63, 13);
            this.lblDataInicio.TabIndex = 20;
            this.lblDataInicio.Text = "Data Inicial:";
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFim.ForeColor = System.Drawing.Color.White;
            this.lblDataFim.Location = new System.Drawing.Point(449, 19);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(58, 13);
            this.lblDataFim.TabIndex = 21;
            this.lblDataFim.Text = "Data Final:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPesquisar.Location = new System.Drawing.Point(186, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 26);
            this.btnPesquisar.TabIndex = 22;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // picPesquisa
            // 
            this.picPesquisa.Image = global::NewGlicNow.Properties.Resources.Pesquisa___MapaGlic___Branco2;
            this.picPesquisa.Location = new System.Drawing.Point(151, 13);
            this.picPesquisa.Name = "picPesquisa";
            this.picPesquisa.Size = new System.Drawing.Size(24, 24);
            this.picPesquisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPesquisa.TabIndex = 139;
            this.picPesquisa.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(276, 32);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 141;
            this.lblData.Text = "Data:";
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(324, 28);
            this.dtpData.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(97, 20);
            this.dtpData.TabIndex = 140;
            this.dtpData.Value = new System.DateTime(2024, 6, 25, 0, 0, 0, 0);
            // 
            // grbBasal
            // 
            this.grbBasal.Controls.Add(this.ckbMatutino);
            this.grbBasal.Controls.Add(this.ckbNoturno);
            this.grbBasal.Location = new System.Drawing.Point(427, 24);
            this.grbBasal.Name = "grbBasal";
            this.grbBasal.Size = new System.Drawing.Size(163, 68);
            this.grbBasal.TabIndex = 142;
            this.grbBasal.TabStop = false;
            this.grbBasal.Text = "Basal";
            // 
            // ckbNoturno
            // 
            this.ckbNoturno.AutoSize = true;
            this.ckbNoturno.Location = new System.Drawing.Point(15, 18);
            this.ckbNoturno.Name = "ckbNoturno";
            this.ckbNoturno.Size = new System.Drawing.Size(79, 21);
            this.ckbNoturno.TabIndex = 0;
            this.ckbNoturno.Text = "Noturno";
            this.ckbNoturno.UseVisualStyleBackColor = true;
            // 
            // ckbMatutino
            // 
            this.ckbMatutino.AutoSize = true;
            this.ckbMatutino.Location = new System.Drawing.Point(16, 38);
            this.ckbMatutino.Name = "ckbMatutino";
            this.ckbMatutino.Size = new System.Drawing.Size(83, 21);
            this.ckbMatutino.TabIndex = 1;
            this.ckbMatutino.Text = "Matutino";
            this.ckbMatutino.UseVisualStyleBackColor = true;
            // 
            // ucCadastroMapGlic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(46)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.picPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblDataFim);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.dtpDataFim);
            this.Controls.Add(this.dtpDataInicio);
            this.Controls.Add(this.btnMapa);
            this.Controls.Add(this.dgvMapaGlic);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.grpRegistrar);
            this.Name = "ucCadastroMapGlic";
            this.Size = new System.Drawing.Size(763, 479);
            this.Load += new System.EventHandler(this.ucCadastroMapGlic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapaGlic)).EndInit();
            this.grpRegistrar.ResumeLayout(false);
            this.grpRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPesquisa)).EndInit();
            this.grbBasal.ResumeLayout(false);
            this.grbBasal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValores;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblValores;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DataGridView dgvMapaGlic;
        private System.Windows.Forms.GroupBox grpRegistrar;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Button btnMapa;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.PictureBox picPesquisa;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.GroupBox grbBasal;
        private System.Windows.Forms.CheckBox ckbMatutino;
        private System.Windows.Forms.CheckBox ckbNoturno;
    }
}
