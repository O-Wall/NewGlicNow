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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapaGlic)).BeginInit();
            this.grpRegistrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValores
            // 
            this.txtValores.Location = new System.Drawing.Point(121, 60);
            this.txtValores.MaxLength = 5;
            this.txtValores.Name = "txtValores";
            this.txtValores.Size = new System.Drawing.Size(100, 20);
            this.txtValores.TabIndex = 13;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(121, 92);
            this.txtObservacao.MaxLength = 1000;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(484, 60);
            this.txtObservacao.TabIndex = 12;
            // 
            // lblValores
            // 
            this.lblValores.AutoSize = true;
            this.lblValores.Location = new System.Drawing.Point(15, 60);
            this.lblValores.Name = "lblValores";
            this.lblValores.Size = new System.Drawing.Size(100, 13);
            this.lblValores.TabIndex = 9;
            this.lblValores.Text = "Valores da Glicemia";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(15, 24);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(45, 13);
            this.lblPeriodo.TabIndex = 8;
            this.lblPeriodo.Text = "Período";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(15, 95);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 7;
            this.lblObservacao.Text = "Observação";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(602, 428);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(103, 35);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // dgvMapaGlic
            // 
            this.dgvMapaGlic.AllowUserToAddRows = false;
            this.dgvMapaGlic.AllowUserToDeleteRows = false;
            this.dgvMapaGlic.AllowUserToResizeColumns = false;
            this.dgvMapaGlic.AllowUserToResizeRows = false;
            this.dgvMapaGlic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMapaGlic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMapaGlic.Location = new System.Drawing.Point(56, 22);
            this.dgvMapaGlic.MultiSelect = false;
            this.dgvMapaGlic.Name = "dgvMapaGlic";
            this.dgvMapaGlic.ReadOnly = true;
            this.dgvMapaGlic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMapaGlic.Size = new System.Drawing.Size(661, 219);
            this.dgvMapaGlic.TabIndex = 16;
            // 
            // grpRegistrar
            // 
            this.grpRegistrar.Controls.Add(this.cboPeriodo);
            this.grpRegistrar.Controls.Add(this.txtValores);
            this.grpRegistrar.Controls.Add(this.txtObservacao);
            this.grpRegistrar.Controls.Add(this.lblValores);
            this.grpRegistrar.Controls.Add(this.lblPeriodo);
            this.grpRegistrar.Controls.Add(this.lblObservacao);
            this.grpRegistrar.Location = new System.Drawing.Point(56, 251);
            this.grpRegistrar.Name = "grpRegistrar";
            this.grpRegistrar.Size = new System.Drawing.Size(661, 164);
            this.grpRegistrar.TabIndex = 17;
            this.grpRegistrar.TabStop = false;
            this.grpRegistrar.Text = "Registrar dados";
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Items.AddRange(new object[] {
            "PRE-Café",
            "PÓS-Café",
            "PRE-Almoço",
            "PÓS-Almoço",
            "PRE-Jantar",
            "PÓS-Jantar",
            "Basal Matutino",
            "Basal Noturno"});
            this.cboPeriodo.Location = new System.Drawing.Point(121, 24);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(152, 21);
            this.cboPeriodo.TabIndex = 14;
            // 
            // ucCadastroMapGlic
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dgvMapaGlic);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.grpRegistrar);
            this.Name = "ucCadastroMapGlic";
            this.Size = new System.Drawing.Size(763, 479);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapaGlic)).EndInit();
            this.grpRegistrar.ResumeLayout(false);
            this.grpRegistrar.PerformLayout();
            this.ResumeLayout(false);

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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cboPeriodo;
    }
}
