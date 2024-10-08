﻿namespace FinalGlicNow
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
            this.picClose = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gboCadastro = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblResidencia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gboLogin = new System.Windows.Forms.GroupBox();
            this.picSenha = new System.Windows.Forms.PictureBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.picEditar = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.picConfSenha = new System.Windows.Forms.PictureBox();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.btnExpandir = new System.Windows.Forms.Button();
            this.pnlBordaConfig.SuspendLayout();
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
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(10, 6);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(183, 21);
            this.lblTitulo.TabIndex = 42;
            this.lblTitulo.Text = "Configurações da conta";
            // 
            // pnlBordaConfig
            // 
            this.pnlBordaConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pnlBordaConfig.Controls.Add(this.lblTitulo);
            this.pnlBordaConfig.Controls.Add(this.picClose);
            this.pnlBordaConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBordaConfig.Location = new System.Drawing.Point(0, 0);
            this.pnlBordaConfig.Name = "pnlBordaConfig";
            this.pnlBordaConfig.Size = new System.Drawing.Size(387, 38);
            this.pnlBordaConfig.TabIndex = 102;
            this.pnlBordaConfig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBordaConfig_MouseDown);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Image = global::NewGlicNow.Properties.Resources.Close_vermelho_48;
            this.picClose.Location = new System.Drawing.Point(348, 4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(31, 30);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 44;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.White;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.Location = new System.Drawing.Point(224, 390);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 41);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gboCadastro
            // 
            this.gboCadastro.Controls.Add(this.label1);
            this.gboCadastro.Controls.Add(this.txtNumero);
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
            this.gboCadastro.Controls.Add(this.label2);
            this.gboCadastro.Controls.Add(this.lblResidencia);
            this.gboCadastro.Controls.Add(this.label4);
            this.gboCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.gboCadastro.Location = new System.Drawing.Point(397, 57);
            this.gboCadastro.Name = "gboCadastro";
            this.gboCadastro.Size = new System.Drawing.Size(485, 464);
            this.gboCadastro.TabIndex = 126;
            this.gboCadastro.TabStop = false;
            this.gboCadastro.Text = "Cadastro";
            this.gboCadastro.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 123;
            this.label1.Text = "Dados Pessoais";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtNumero.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtNumero.ForeColor = System.Drawing.Color.Gray;
            this.txtNumero.Location = new System.Drawing.Point(31, 333);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(80, 22);
            this.txtNumero.TabIndex = 122;
            this.txtNumero.Text = "Nº";
            this.txtNumero.Enter += new System.EventHandler(this.txtNumero_Enter);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            this.txtNumero.Leave += new System.EventHandler(this.txtNumero_Leave);
            // 
            // txtComplemento
            // 
            this.txtComplemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtComplemento.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtComplemento.ForeColor = System.Drawing.Color.Gray;
            this.txtComplemento.Location = new System.Drawing.Point(147, 333);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(274, 22);
            this.txtComplemento.TabIndex = 121;
            this.txtComplemento.Text = "Complemento";
            this.txtComplemento.Enter += new System.EventHandler(this.txtComplemento_Enter);
            this.txtComplemento.Leave += new System.EventHandler(this.txtComplemento_Leave);
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtBairro.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtBairro.ForeColor = System.Drawing.Color.Gray;
            this.txtBairro.Location = new System.Drawing.Point(31, 372);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(228, 22);
            this.txtBairro.TabIndex = 117;
            this.txtBairro.Text = "Bairro";
            // 
            // txtCEP
            // 
            this.txtCEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtCEP.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtCEP.ForeColor = System.Drawing.Color.Gray;
            this.txtCEP.Location = new System.Drawing.Point(283, 372);
            this.txtCEP.MaxLength = 9;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(138, 22);
            this.txtCEP.TabIndex = 115;
            this.txtCEP.Text = "CEP";
            this.txtCEP.Enter += new System.EventHandler(this.txtCEP_Enter);
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // cboCidade
            // 
            this.cboCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.cboCidade.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cboCidade.ForeColor = System.Drawing.Color.Gray;
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Items.AddRange(new object[] {
            "Pré-diabetes.",
            "Diabetes tipo 1",
            "Diabetes tipo 2",
            "Diabetes Gestacional",
            ""});
            this.cboCidade.Location = new System.Drawing.Point(31, 412);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(228, 24);
            this.cboCidade.TabIndex = 119;
            this.cboCidade.Text = "Cidade";
            // 
            // cboTipoDiabete
            // 
            this.cboTipoDiabete.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cboTipoDiabete.ForeColor = System.Drawing.Color.Gray;
            this.cboTipoDiabete.FormattingEnabled = true;
            this.cboTipoDiabete.Items.AddRange(new object[] {
            "Pré-diabetes.",
            "Diabetes tipo 1",
            "Diabetes tipo 2",
            "Diabetes Gestacional",
            ""});
            this.cboTipoDiabete.Location = new System.Drawing.Point(257, 174);
            this.cboTipoDiabete.Name = "cboTipoDiabete";
            this.cboTipoDiabete.Size = new System.Drawing.Size(206, 24);
            this.cboTipoDiabete.TabIndex = 112;
            this.cboTipoDiabete.Text = "Tipo Diabete";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtEndereco.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtEndereco.ForeColor = System.Drawing.Color.Gray;
            this.txtEndereco.Location = new System.Drawing.Point(31, 295);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(432, 22);
            this.txtEndereco.TabIndex = 114;
            this.txtEndereco.Text = "Endereço";
            this.txtEndereco.Enter += new System.EventHandler(this.txtEndereco_Enter);
            this.txtEndereco.Leave += new System.EventHandler(this.txtEndereco_Leave);
            // 
            // cboGenero
            // 
            this.cboGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.cboGenero.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cboGenero.ForeColor = System.Drawing.Color.Gray;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Prefiro não informar"});
            this.cboGenero.Location = new System.Drawing.Point(31, 174);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(198, 24);
            this.cboGenero.TabIndex = 113;
            this.cboGenero.Text = "Gênero";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(31, 134);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(432, 22);
            this.txtEmail.TabIndex = 110;
            this.txtEmail.Text = "E-mail";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtNome.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtNome.ForeColor = System.Drawing.Color.Gray;
            this.txtNome.Location = new System.Drawing.Point(29, 59);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(432, 22);
            this.txtNome.TabIndex = 104;
            this.txtNome.Text = "Nome Completo";
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtCPF.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtCPF.ForeColor = System.Drawing.Color.Gray;
            this.txtCPF.Location = new System.Drawing.Point(31, 96);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(198, 22);
            this.txtCPF.TabIndex = 109;
            this.txtCPF.Text = "CPF";
            this.txtCPF.Enter += new System.EventHandler(this.txtCPF_Enter);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtCelular.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtCelular.ForeColor = System.Drawing.Color.Gray;
            this.txtCelular.Location = new System.Drawing.Point(257, 215);
            this.txtCelular.MaxLength = 11;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(206, 22);
            this.txtCelular.TabIndex = 118;
            this.txtCelular.Text = "Celular";
            this.txtCelular.Enter += new System.EventHandler(this.txtCelular_Enter);
            this.txtCelular.Leave += new System.EventHandler(this.txtCelular_Leave);
            // 
            // cboEstado
            // 
            this.cboEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.cboEstado.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cboEstado.ForeColor = System.Drawing.Color.Gray;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Pré-diabetes.",
            "Diabetes tipo 1",
            "Diabetes tipo 2",
            "Diabetes Gestacional",
            ""});
            this.cboEstado.Location = new System.Drawing.Point(283, 412);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(138, 24);
            this.cboEstado.TabIndex = 120;
            this.cboEstado.Text = "Estado";
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(257, 96);
            this.dtpDataNascimento.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(204, 22);
            this.dtpDataNascimento.TabIndex = 111;
            this.dtpDataNascimento.UseWaitCursor = true;
            this.dtpDataNascimento.Value = new System.DateTime(2024, 6, 27, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.label2.Location = new System.Drawing.Point(24, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 20);
            this.label2.TabIndex = 124;
            this.label2.Text = "------------------------------------";
            // 
            // lblResidencia
            // 
            this.lblResidencia.AutoSize = true;
            this.lblResidencia.BackColor = System.Drawing.Color.Transparent;
            this.lblResidencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.lblResidencia.Location = new System.Drawing.Point(29, 270);
            this.lblResidencia.Name = "lblResidencia";
            this.lblResidencia.Size = new System.Drawing.Size(122, 17);
            this.lblResidencia.TabIndex = 125;
            this.lblResidencia.Text = "Dados Residenciais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.label4.Location = new System.Drawing.Point(29, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 20);
            this.label4.TabIndex = 126;
            this.label4.Text = "------------------------------------";
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
            this.gboLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gboLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.gboLogin.Location = new System.Drawing.Point(63, 111);
            this.gboLogin.Name = "gboLogin";
            this.gboLogin.Size = new System.Drawing.Size(261, 258);
            this.gboLogin.TabIndex = 127;
            this.gboLogin.TabStop = false;
            this.gboLogin.Text = "Login";
            // 
            // picSenha
            // 
            this.picSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSenha.Image = ((System.Drawing.Image)(resources.GetObject("picSenha.Image")));
            this.picSenha.Location = new System.Drawing.Point(21, 158);
            this.picSenha.Name = "picSenha";
            this.picSenha.Size = new System.Drawing.Size(24, 24);
            this.picSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSenha.TabIndex = 103;
            this.picSenha.TabStop = false;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtLogin.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtLogin.ForeColor = System.Drawing.Color.Gray;
            this.txtLogin.Location = new System.Drawing.Point(49, 117);
            this.txtLogin.MaxLength = 50;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(180, 22);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Text = "Login";
            this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtSenha.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtSenha.ForeColor = System.Drawing.Color.Gray;
            this.txtSenha.Location = new System.Drawing.Point(49, 160);
            this.txtSenha.MaxLength = 30;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(180, 22);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtConfSenha.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtConfSenha.ForeColor = System.Drawing.Color.Gray;
            this.txtConfSenha.Location = new System.Drawing.Point(49, 204);
            this.txtConfSenha.MaxLength = 30;
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(180, 22);
            this.txtConfSenha.TabIndex = 2;
            this.txtConfSenha.Text = "Confirmar senha";
            this.txtConfSenha.Enter += new System.EventHandler(this.txtConfSenha_Enter);
            this.txtConfSenha.Leave += new System.EventHandler(this.txtConfSenha_Leave);
            // 
            // picEditar
            // 
            this.picEditar.BackColor = System.Drawing.Color.Transparent;
            this.picEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEditar.Image = ((System.Drawing.Image)(resources.GetObject("picEditar.Image")));
            this.picEditar.Location = new System.Drawing.Point(139, 82);
            this.picEditar.Name = "picEditar";
            this.picEditar.Size = new System.Drawing.Size(24, 24);
            this.picEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEditar.TabIndex = 103;
            this.picEditar.TabStop = false;
            this.picEditar.Click += new System.EventHandler(this.picEditar_Click);
            // 
            // picLogin
            // 
            this.picLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogin.Image = ((System.Drawing.Image)(resources.GetObject("picLogin.Image")));
            this.picLogin.Location = new System.Drawing.Point(18, 114);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(30, 30);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogin.TabIndex = 102;
            this.picLogin.TabStop = false;
            // 
            // picConfSenha
            // 
            this.picConfSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picConfSenha.Image = ((System.Drawing.Image)(resources.GetObject("picConfSenha.Image")));
            this.picConfSenha.Location = new System.Drawing.Point(21, 202);
            this.picConfSenha.Name = "picConfSenha";
            this.picConfSenha.Size = new System.Drawing.Size(24, 24);
            this.picConfSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConfSenha.TabIndex = 106;
            this.picConfSenha.TabStop = false;
            // 
            // picPerfil
            // 
            this.picPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPerfil.Image = ((System.Drawing.Image)(resources.GetObject("picPerfil.Image")));
            this.picPerfil.Location = new System.Drawing.Point(93, 36);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(70, 70);
            this.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPerfil.TabIndex = 2;
            this.picPerfil.TabStop = false;
            // 
            // btnExpandir
            // 
            this.btnExpandir.BackColor = System.Drawing.Color.White;
            this.btnExpandir.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExpandir.Location = new System.Drawing.Point(63, 390);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(100, 41);
            this.btnExpandir.TabIndex = 1;
            this.btnExpandir.Text = "&Editar outros dados";
            this.btnExpandir.UseVisualStyleBackColor = false;
            this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(387, 546);
            this.Controls.Add(this.btnExpandir);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gboCadastro);
            this.Controls.Add(this.pnlBordaConfig);
            this.Controls.Add(this.gboLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfig";
            this.Text = "frmConfig";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.pnlBordaConfig.ResumeLayout(false);
            this.pnlBordaConfig.PerformLayout();
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
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox gboCadastro;
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
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResidencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExpandir;
    }
}