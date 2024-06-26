namespace NewGlicNow
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.cboTipoDiabete = new System.Windows.Forms.ComboBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picEstado = new System.Windows.Forms.PictureBox();
            this.picCelular = new System.Windows.Forms.PictureBox();
            this.picCidade = new System.Windows.Forms.PictureBox();
            this.picBairro = new System.Windows.Forms.PictureBox();
            this.picComplemento = new System.Windows.Forms.PictureBox();
            this.picCep = new System.Windows.Forms.PictureBox();
            this.picEndereco = new System.Windows.Forms.PictureBox();
            this.picEmail = new System.Windows.Forms.PictureBox();
            this.picCpf = new System.Windows.Forms.PictureBox();
            this.picConfSenha = new System.Windows.Forms.PictureBox();
            this.picSenha = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.picEditar = new System.Windows.Forms.PictureBox();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.picNumero = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBairro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComplemento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEndereco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEstado
            // 
            this.cboEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.cboEstado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(109, 463);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(170, 23);
            this.cboEstado.TabIndex = 16;
            this.cboEstado.Text = "Estado";
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // cboCidade
            // 
            this.cboCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.cboCidade.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCidade.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(315, 462);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(226, 23);
            this.cboCidade.TabIndex = 17;
            this.cboCidade.Text = "Cidade";
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtCelular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.ForeColor = System.Drawing.Color.Gray;
            this.txtCelular.Location = new System.Drawing.Point(335, 299);
            this.txtCelular.MaxLength = 11;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(206, 22);
            this.txtCelular.TabIndex = 10;
            this.txtCelular.Text = "Celular";
            this.txtCelular.Enter += new System.EventHandler(this.txtCelular_Leave);
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtBairro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.Gray;
            this.txtBairro.Location = new System.Drawing.Point(109, 426);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(239, 22);
            this.txtBairro.TabIndex = 14;
            this.txtBairro.Text = "Bairro";
            this.txtBairro.Enter += new System.EventHandler(this.txtBairro_Leave);
            // 
            // txtComplemento
            // 
            this.txtComplemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtComplemento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.ForeColor = System.Drawing.Color.Gray;
            this.txtComplemento.Location = new System.Drawing.Point(285, 389);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(256, 22);
            this.txtComplemento.TabIndex = 13;
            this.txtComplemento.Text = "Complemento";
            this.txtComplemento.Enter += new System.EventHandler(this.txtComplemento_Leave);
            // 
            // txtCEP
            // 
            this.txtCEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtCEP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.ForeColor = System.Drawing.Color.Gray;
            this.txtCEP.Location = new System.Drawing.Point(384, 425);
            this.txtCEP.MaxLength = 9;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(157, 22);
            this.txtCEP.TabIndex = 15;
            this.txtCEP.Text = "CEP";
            this.txtCEP.Enter += new System.EventHandler(this.txtCEP_Leave);
            this.txtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCEP_KeyPress);
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtEndereco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.Gray;
            this.txtEndereco.Location = new System.Drawing.Point(109, 351);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(432, 22);
            this.txtEndereco.TabIndex = 11;
            this.txtEndereco.Text = "Endereço";
            this.txtEndereco.Enter += new System.EventHandler(this.txtEndereco_Leave);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.Location = new System.Drawing.Point(310, 520);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(113, 36);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "&Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.White;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.Location = new System.Drawing.Point(429, 520);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(112, 36);
            this.btnCadastro.TabIndex = 18;
            this.btnCadastro.Text = "&Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // cboGenero
            // 
            this.cboGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.cboGenero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenero.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(79, 298);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(200, 24);
            this.cboGenero.TabIndex = 9;
            this.cboGenero.Text = "Gênero";
            // 
            // cboTipoDiabete
            // 
            this.cboTipoDiabete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.cboTipoDiabete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDiabete.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cboTipoDiabete.FormattingEnabled = true;
            this.cboTipoDiabete.Location = new System.Drawing.Point(285, 256);
            this.cboTipoDiabete.Name = "cboTipoDiabete";
            this.cboTipoDiabete.Size = new System.Drawing.Size(256, 23);
            this.cboTipoDiabete.TabIndex = 8;
            this.cboTipoDiabete.Text = "Tipo de Diabete";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.dtpDataNascimento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(79, 256);
            this.dtpDataNascimento.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(200, 22);
            this.dtpDataNascimento.TabIndex = 7;
            this.dtpDataNascimento.UseWaitCursor = true;
            this.dtpDataNascimento.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(109, 220);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(432, 22);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Text = "E-mail";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtCPF.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.ForeColor = System.Drawing.Color.Gray;
            this.txtCPF.Location = new System.Drawing.Point(343, 183);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(198, 22);
            this.txtCPF.TabIndex = 5;
            this.txtCPF.Text = "CPF";
            this.txtCPF.Enter += new System.EventHandler(this.txtCPF_Leave);
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.Gray;
            this.txtLogin.Location = new System.Drawing.Point(109, 183);
            this.txtLogin.MaxLength = 50;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(180, 22);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.Text = "Login";
            this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtConfSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfSenha.ForeColor = System.Drawing.Color.Gray;
            this.txtConfSenha.Location = new System.Drawing.Point(343, 149);
            this.txtConfSenha.MaxLength = 30;
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(198, 22);
            this.txtConfSenha.TabIndex = 3;
            this.txtConfSenha.Text = "Confirmar senha";
            this.txtConfSenha.Enter += new System.EventHandler(this.txtConfSenha_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Gray;
            this.txtSenha.Location = new System.Drawing.Point(109, 148);
            this.txtSenha.MaxLength = 30;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(180, 22);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Gray;
            this.txtNome.Location = new System.Drawing.Point(155, 104);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(386, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Nome Completo";
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.lblCadastro);
            this.panel2.Controls.Add(this.picClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 33);
            this.panel2.TabIndex = 18;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.White;
            this.lblCadastro.Location = new System.Drawing.Point(11, 5);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(75, 21);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "Cadastro";
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(588, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 24);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picClose.TabIndex = 42;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.PicClose_Click);
            // 
            // picEstado
            // 
            this.picEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEstado.Location = new System.Drawing.Point(285, 461);
            this.picEstado.Name = "picEstado";
            this.picEstado.Size = new System.Drawing.Size(24, 24);
            this.picEstado.TabIndex = 73;
            this.picEstado.TabStop = false;
            // 
            // picCelular
            // 
            this.picCelular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCelular.Location = new System.Drawing.Point(305, 297);
            this.picCelular.Name = "picCelular";
            this.picCelular.Size = new System.Drawing.Size(24, 24);
            this.picCelular.TabIndex = 70;
            this.picCelular.TabStop = false;
            // 
            // picCidade
            // 
            this.picCidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCidade.Location = new System.Drawing.Point(79, 461);
            this.picCidade.Name = "picCidade";
            this.picCidade.Size = new System.Drawing.Size(24, 24);
            this.picCidade.TabIndex = 69;
            this.picCidade.TabStop = false;
            // 
            // picBairro
            // 
            this.picBairro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBairro.Location = new System.Drawing.Point(79, 424);
            this.picBairro.Name = "picBairro";
            this.picBairro.Size = new System.Drawing.Size(24, 24);
            this.picBairro.TabIndex = 67;
            this.picBairro.TabStop = false;
            // 
            // picComplemento
            // 
            this.picComplemento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picComplemento.Location = new System.Drawing.Point(255, 386);
            this.picComplemento.Name = "picComplemento";
            this.picComplemento.Size = new System.Drawing.Size(24, 24);
            this.picComplemento.TabIndex = 66;
            this.picComplemento.TabStop = false;
            // 
            // picCep
            // 
            this.picCep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCep.Location = new System.Drawing.Point(355, 423);
            this.picCep.Name = "picCep";
            this.picCep.Size = new System.Drawing.Size(24, 24);
            this.picCep.TabIndex = 63;
            this.picCep.TabStop = false;
            // 
            // picEndereco
            // 
            this.picEndereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEndereco.Location = new System.Drawing.Point(79, 350);
            this.picEndereco.Name = "picEndereco";
            this.picEndereco.Size = new System.Drawing.Size(24, 24);
            this.picEndereco.TabIndex = 62;
            this.picEndereco.TabStop = false;
            // 
            // picEmail
            // 
            this.picEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEmail.Location = new System.Drawing.Point(79, 219);
            this.picEmail.Name = "picEmail";
            this.picEmail.Size = new System.Drawing.Size(24, 24);
            this.picEmail.TabIndex = 55;
            this.picEmail.TabStop = false;
            // 
            // picCpf
            // 
            this.picCpf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCpf.Location = new System.Drawing.Point(313, 181);
            this.picCpf.Name = "picCpf";
            this.picCpf.Size = new System.Drawing.Size(24, 24);
            this.picCpf.TabIndex = 52;
            this.picCpf.TabStop = false;
            // 
            // picConfSenha
            // 
            this.picConfSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picConfSenha.Location = new System.Drawing.Point(313, 146);
            this.picConfSenha.Name = "picConfSenha";
            this.picConfSenha.Size = new System.Drawing.Size(24, 24);
            this.picConfSenha.TabIndex = 49;
            this.picConfSenha.TabStop = false;
            // 
            // picSenha
            // 
            this.picSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSenha.Location = new System.Drawing.Point(79, 146);
            this.picSenha.Name = "picSenha";
            this.picSenha.Size = new System.Drawing.Size(24, 24);
            this.picSenha.TabIndex = 46;
            this.picSenha.TabStop = false;
            // 
            // picLogin
            // 
            this.picLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogin.Location = new System.Drawing.Point(79, 180);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(24, 24);
            this.picLogin.TabIndex = 45;
            this.picLogin.TabStop = false;
            // 
            // picEditar
            // 
            this.picEditar.BackColor = System.Drawing.Color.Black;
            this.picEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEditar.Location = new System.Drawing.Point(119, 104);
            this.picEditar.Name = "picEditar";
            this.picEditar.Size = new System.Drawing.Size(24, 24);
            this.picEditar.TabIndex = 44;
            this.picEditar.TabStop = false;
            this.picEditar.Click += new System.EventHandler(this.picEditar_Click);
            // 
            // picProfile
            // 
            this.picProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picProfile.Location = new System.Drawing.Point(79, 64);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(64, 64);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 43;
            this.picProfile.TabStop = false;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtNumero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.Gray;
            this.txtNumero.Location = new System.Drawing.Point(109, 389);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(109, 22);
            this.txtNumero.TabIndex = 12;
            this.txtNumero.Text = "Nº";
            this.txtNumero.Enter += new System.EventHandler(this.txtNumero_Enter);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            this.txtNumero.Leave += new System.EventHandler(this.txtNumero_Leave);
            // 
            // picNumero
            // 
            this.picNumero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picNumero.Location = new System.Drawing.Point(79, 386);
            this.picNumero.Name = "picNumero";
            this.picNumero.Size = new System.Drawing.Size(24, 24);
            this.picNumero.TabIndex = 75;
            this.picNumero.TabStop = false;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(618, 575);
            this.Controls.Add(this.picNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.picEstado);
            this.Controls.Add(this.cboCidade);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.picCelular);
            this.Controls.Add(this.picCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.picBairro);
            this.Controls.Add(this.picComplemento);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.picCep);
            this.Controls.Add(this.picEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.cboTipoDiabete);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.picEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.picCpf);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtConfSenha);
            this.Controls.Add(this.picConfSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.picSenha);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.picEditar);
            this.Controls.Add(this.picProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastro";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBairro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComplemento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEndereco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.PictureBox picEstado;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.PictureBox picCelular;
        private System.Windows.Forms.PictureBox picCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.PictureBox picBairro;
        private System.Windows.Forms.PictureBox picComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.PictureBox picCep;
        private System.Windows.Forms.PictureBox picEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.ComboBox cboTipoDiabete;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.PictureBox picEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.PictureBox picCpf;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.PictureBox picConfSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox picSenha;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.PictureBox picEditar;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.PictureBox picNumero;
    }
}