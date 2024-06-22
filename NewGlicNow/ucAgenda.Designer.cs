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
            this.components = new System.ComponentModel.Container();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(84, 408);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 41);
            this.btnLimpar.TabIndex = 113;
            this.btnLimpar.Text = "&Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(588, 408);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(94, 41);
            this.btnGravar.TabIndex = 112;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.White;
            this.txtPesquisa.Location = new System.Drawing.Point(84, 41);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(598, 20);
            this.txtPesquisa.TabIndex = 111;
            this.txtPesquisa.Text = "Pesquisar por Título";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(84, 307);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(598, 86);
            this.textBox1.TabIndex = 110;
            this.textBox1.Text = "Complemento";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(84, 269);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(598, 20);
            this.txtTitulo.TabIndex = 109;
            this.txtTitulo.Text = "Título";
            // 
            // txtMedico
            // 
            this.txtMedico.BackColor = System.Drawing.Color.White;
            this.txtMedico.Location = new System.Drawing.Point(479, 233);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(203, 20);
            this.txtMedico.TabIndex = 108;
            this.txtMedico.Text = "Nome do Medico";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 233);
            this.dateTimePicker1.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(389, 20);
            this.dateTimePicker1.TabIndex = 107;
            this.dateTimePicker1.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(84, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 144);
            this.dataGridView1.TabIndex = 106;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ucAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(96)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ucAgenda";
            this.Size = new System.Drawing.Size(763, 479);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
