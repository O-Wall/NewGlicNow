namespace FinalGlicNow
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBordaConfig = new System.Windows.Forms.Panel();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gboCadastro = new System.Windows.Forms.GroupBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.cboTipoDiabete = new System.Windows.Forms.ComboBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.gboLogin = new System.Windows.Forms.GroupBox();
            this.picSenha = new System.Windows.Forms.PictureBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.picEditar = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.picConfSenha = new System.Windows.Forms.PictureBox();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.pnlBordaConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.gboCadastro.SuspendLayout();
            this.gboLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(67, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(120, 13);
            this.lblTitulo.TabIndex = 42;
            this.lblTitulo.Text = "Configurações da conta";
            // 
            // pnlBordaConfig
            // 
            this.pnlBordaConfig.BackColor = System.Drawing.Color.Brown;
            this.pnlBordaConfig.Controls.Add(this.picBack);
            this.pnlBordaConfig.Controls.Add(this.picClose);
            this.pnlBordaConfig.Controls.Add(this.lblTitulo);
            this.pnlBordaConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBordaConfig.Location = new System.Drawing.Point(0, 0);
            this.pnlBordaConfig.Name = "pnlBordaConfig";
            this.pnlBordaConfig.Size = new System.Drawing.Size(934, 33);
            this.pnlBordaConfig.TabIndex = 102;
            // 
            // picBack
            // 
            this.picBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBack.BackColor = System.Drawing.Color.Transparent;
            this.picBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBack.Location = new System.Drawing.Point(8, 4);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(24, 24);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBack.TabIndex = 104;
            this.picBack.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(903, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 24);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picClose.TabIndex = 44;
            this.picClose.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(140, 410);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 33);
            this.btnConfirmar.TabIndex = 125;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // gboCadastro
            // 
            this.gboCadastro.Controls.Add(this.txtComplemento);
            this.gboCadastro.Controls.Add(this.txtBairro);
            this.gboCadastro.Controls.Add(this.txtCEP);
            this.gboCadastro.Controls.Add(this.cboCidade);
            this.gboCadastro.Controls.Add(this.cboTipoDiabete);
            this.gboCadastro.Controls.Add(this.txtEndereco);
            this.gboCadastro.Controls.Add(this.cboGenero);
            this.gboCadastro.Controls.Add(this.txtEmail);
            this.gboCadastro.Controls.Add(this.txtNome);
            this.gboCadastro.Controls.Add(this.txtCPF);
            this.gboCadastro.Controls.Add(this.txtCelular);
            this.gboCadastro.Controls.Add(this.cboEstado);
            this.gboCadastro.Controls.Add(this.dtpDataNascimento);
            this.gboCadastro.Location = new System.Drawing.Point(397, 69);
            this.gboCadastro.Name = "gboCadastro";
            this.gboCadastro.Size = new System.Drawing.Size(485, 426);
            this.gboCadastro.TabIndex = 126;
            this.gboCadastro.TabStop = false;
            this.gboCadastro.Text = "Cadastro";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BackColor = System.Drawing.SystemColors.Window;
            this.txtComplemento.ForeColor = System.Drawing.Color.Black;
            this.txtComplemento.Location = new System.Drawing.Point(32, 303);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(432, 20);
            this.txtComplemento.TabIndex = 116;
            this.txtComplemento.Text = "Complemento";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.Window;
            this.txtBairro.ForeColor = System.Drawing.Color.Black;
            this.txtBairro.Location = new System.Drawing.Point(32, 341);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(228, 20);
            this.txtBairro.TabIndex = 117;
            this.txtBairro.Text = "Bairro";
            // 
            // txtCEP
            // 
            this.txtCEP.BackColor = System.Drawing.SystemColors.Window;
            this.txtCEP.ForeColor = System.Drawing.Color.Black;
            this.txtCEP.Location = new System.Drawing.Point(307, 341);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(157, 20);
            this.txtCEP.TabIndex = 115;
            this.txtCEP.Text = "CEP";
            // 
            // cboCidade
            // 
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Items.AddRange(new object[] {
            "Pré-diabetes.",
            "Diabetes tipo 1",
            "Diabetes tipo 2",
            "Diabetes Gestacional",
            ""});
            this.cboCidade.Location = new System.Drawing.Point(32, 383);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(258, 21);
            this.cboCidade.TabIndex = 119;
            this.cboCidade.Text = "Cidade";
            // 
            // cboTipoDiabete
            // 
            this.cboTipoDiabete.FormattingEnabled = true;
            this.cboTipoDiabete.Items.AddRange(new object[] {
            "Pré-diabetes.",
            "Diabetes tipo 1",
            "Diabetes tipo 2",
            "Diabetes Gestacional",
            ""});
            this.cboTipoDiabete.Location = new System.Drawing.Point(256, 156);
            this.cboTipoDiabete.Name = "cboTipoDiabete";
            this.cboTipoDiabete.Size = new System.Drawing.Size(206, 21);
            this.cboTipoDiabete.TabIndex = 112;
            this.cboTipoDiabete.Text = "Tipo Diabete";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndereco.ForeColor = System.Drawing.Color.Black;
            this.txtEndereco.Location = new System.Drawing.Point(32, 264);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(432, 20);
            this.txtEndereco.TabIndex = 114;
            this.txtEndereco.Text = "Endereço";
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Prefiro não informar"});
            this.cboGenero.Location = new System.Drawing.Point(32, 158);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(200, 21);
            this.cboGenero.TabIndex = 113;
            this.cboGenero.Text = "Gênero";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(32, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(432, 20);
            this.txtEmail.TabIndex = 110;
            this.txtEmail.Text = "E-mail";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(30, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(432, 20);
            this.txtNome.TabIndex = 104;
            this.txtNome.Text = "Nome Completo";
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.SystemColors.Window;
            this.txtCPF.ForeColor = System.Drawing.Color.Black;
            this.txtCPF.Location = new System.Drawing.Point(32, 70);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(198, 20);
            this.txtCPF.TabIndex = 109;
            this.txtCPF.Text = "CPF";
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.SystemColors.Window;
            this.txtCelular.ForeColor = System.Drawing.Color.Black;
            this.txtCelular.Location = new System.Drawing.Point(258, 200);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(206, 20);
            this.txtCelular.TabIndex = 118;
            this.txtCelular.Text = "Celular";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Pré-diabetes.",
            "Diabetes tipo 1",
            "Diabetes tipo 2",
            "Diabetes Gestacional",
            ""});
            this.cboEstado.Location = new System.Drawing.Point(324, 383);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(138, 21);
            this.cboEstado.TabIndex = 120;
            this.cboEstado.Text = "Estado";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(256, 70);
            this.dtpDataNascimento.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(206, 20);
            this.dtpDataNascimento.TabIndex = 111;
            this.dtpDataNascimento.UseWaitCursor = true;
            this.dtpDataNascimento.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // gboLogin
            // 
            this.gboLogin.BackColor = System.Drawing.SystemColors.Control;
            this.gboLogin.Controls.Add(this.picSenha);
            this.gboLogin.Controls.Add(this.txtLogin);
            this.gboLogin.Controls.Add(this.txtSenha);
            this.gboLogin.Controls.Add(this.txtConfSenha);
            this.gboLogin.Controls.Add(this.picEditar);
            this.gboLogin.Controls.Add(this.picLogin);
            this.gboLogin.Controls.Add(this.picConfSenha);
            this.gboLogin.Controls.Add(this.picPerfil);
            this.gboLogin.Location = new System.Drawing.Point(60, 109);
            this.gboLogin.Name = "gboLogin";
            this.gboLogin.Size = new System.Drawing.Size(261, 258);
            this.gboLogin.TabIndex = 127;
            this.gboLogin.TabStop = false;
            this.gboLogin.Text = "Login";
            // 
            // picSenha
            // 
            this.picSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSenha.Location = new System.Drawing.Point(19, 156);
            this.picSenha.Name = "picSenha";
            this.picSenha.Size = new System.Drawing.Size(24, 24);
            this.picSenha.TabIndex = 103;
            this.picSenha.TabStop = false;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.Window;
            this.txtLogin.ForeColor = System.Drawing.Color.Black;
            this.txtLogin.Location = new System.Drawing.Point(49, 119);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(180, 20);
            this.txtLogin.TabIndex = 108;
            this.txtLogin.Text = "Login";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(49, 160);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(180, 20);
            this.txtSenha.TabIndex = 105;
            this.txtSenha.Text = "Senha";
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfSenha.ForeColor = System.Drawing.Color.Black;
            this.txtConfSenha.Location = new System.Drawing.Point(49, 202);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(180, 20);
            this.txtConfSenha.TabIndex = 107;
            this.txtConfSenha.Text = "Confirmar senha";
            // 
            // picEditar
            // 
            this.picEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEditar.Location = new System.Drawing.Point(133, 76);
            this.picEditar.Name = "picEditar";
            this.picEditar.Size = new System.Drawing.Size(24, 24);
            this.picEditar.TabIndex = 103;
            this.picEditar.TabStop = false;
            // 
            // picLogin
            // 
            this.picLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogin.Location = new System.Drawing.Point(19, 113);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(24, 24);
            this.picLogin.TabIndex = 102;
            this.picLogin.TabStop = false;
            // 
            // picConfSenha
            // 
            this.picConfSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picConfSenha.Location = new System.Drawing.Point(19, 198);
            this.picConfSenha.Name = "picConfSenha";
            this.picConfSenha.Size = new System.Drawing.Size(24, 24);
            this.picConfSenha.TabIndex = 106;
            this.picConfSenha.TabStop = false;
            // 
            // picPerfil
            // 
            this.picPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPerfil.Location = new System.Drawing.Point(93, 36);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(64, 64);
            this.picPerfil.TabIndex = 2;
            this.picPerfil.TabStop = false;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 546);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gboCadastro);
            this.Controls.Add(this.pnlBordaConfig);
            this.Controls.Add(this.gboLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfig";
            this.Text = "frmConfig";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.pnlBordaConfig.ResumeLayout(false);
            this.pnlBordaConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.gboCadastro.ResumeLayout(false);
            this.gboCadastro.PerformLayout();
            this.gboLogin.ResumeLayout(false);
            this.gboLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBordaConfig;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox gboCadastro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.ComboBox cboTipoDiabete;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.GroupBox gboLogin;
        private System.Windows.Forms.PictureBox picSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.PictureBox picEditar;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.PictureBox picConfSenha;
        private System.Windows.Forms.PictureBox picPerfil;
    }
}