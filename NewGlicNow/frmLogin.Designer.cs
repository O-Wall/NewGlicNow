﻿namespace NewGlicNow
{
    partial class FrmLogin
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCadastre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.TelaLogin = new System.Windows.Forms.Panel();
            this.picImagemLogin = new System.Windows.Forms.PictureBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.BordaSenha = new System.Windows.Forms.Panel();
            this.BordaLogin = new System.Windows.Forms.Panel();
            this.cboSalvo = new System.Windows.Forms.CheckBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.picSenha = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.TelaLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadastre
            // 
            this.lblCadastre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCadastre.AutoSize = true;
            this.lblCadastre.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastre.Location = new System.Drawing.Point(494, 399);
            this.lblCadastre.Name = "lblCadastre";
            this.lblCadastre.Size = new System.Drawing.Size(94, 16);
            this.lblCadastre.TabIndex = 47;
            this.lblCadastre.Text = "Cadastre aqui!";
            this.lblCadastre.Click += new System.EventHandler(this.lblCadastre_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(323, 58);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 43;
            this.lblTitulo.Text = "Login";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Location = new System.Drawing.Point(393, 148);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(83, 13);
            this.lblBemVindo.TabIndex = 40;
            this.lblBemVindo.Text = "Seja bem vindo!";
            // 
            // TelaLogin
            // 
            this.TelaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(46)))), ((int)(((byte)(44)))));
            this.TelaLogin.Controls.Add(this.picImagemLogin);
            this.TelaLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.TelaLogin.Location = new System.Drawing.Point(0, 0);
            this.TelaLogin.Name = "TelaLogin";
            this.TelaLogin.Size = new System.Drawing.Size(257, 549);
            this.TelaLogin.TabIndex = 41;
            // 
            // picImagemLogin
            // 
            this.picImagemLogin.BackColor = System.Drawing.Color.White;
            this.picImagemLogin.Location = new System.Drawing.Point(22, 100);
            this.picImagemLogin.Name = "picImagemLogin";
            this.picImagemLogin.Size = new System.Drawing.Size(204, 341);
            this.picImagemLogin.TabIndex = 41;
            this.picImagemLogin.TabStop = false;
            // 
            // lblCadastro
            // 
            this.lblCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(355, 397);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(138, 18);
            this.lblCadastro.TabIndex = 51;
            this.lblCadastro.Text = "Não tem cadastro?";
            // 
            // BordaSenha
            // 
            this.BordaSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BordaSenha.BackColor = System.Drawing.Color.Black;
            this.BordaSenha.Location = new System.Drawing.Point(388, 271);
            this.BordaSenha.Name = "BordaSenha";
            this.BordaSenha.Size = new System.Drawing.Size(200, 1);
            this.BordaSenha.TabIndex = 53;
            // 
            // BordaLogin
            // 
            this.BordaLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BordaLogin.BackColor = System.Drawing.Color.Black;
            this.BordaLogin.Location = new System.Drawing.Point(388, 223);
            this.BordaLogin.Name = "BordaLogin";
            this.BordaLogin.Size = new System.Drawing.Size(200, 1);
            this.BordaLogin.TabIndex = 52;
            // 
            // cboSalvo
            // 
            this.cboSalvo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSalvo.AutoSize = true;
            this.cboSalvo.Checked = true;
            this.cboSalvo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboSalvo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSalvo.Location = new System.Drawing.Point(358, 298);
            this.cboSalvo.Name = "cboSalvo";
            this.cboSalvo.Size = new System.Drawing.Size(118, 24);
            this.cboSalvo.TabIndex = 42;
            this.cboSalvo.Text = "Salvar login";
            this.cboSalvo.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.BackColor = System.Drawing.SystemColors.Control;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(388, 253);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(190, 13);
            this.txtSenha.TabIndex = 45;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.BackColor = System.Drawing.SystemColors.Control;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.ForeColor = System.Drawing.Color.Black;
            this.txtLogin.Location = new System.Drawing.Point(388, 205);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(190, 13);
            this.txtLogin.TabIndex = 44;
            this.txtLogin.Text = "Login";
            this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // picSenha
            // 
            this.picSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSenha.Location = new System.Drawing.Point(358, 248);
            this.picSenha.Name = "picSenha";
            this.picSenha.Size = new System.Drawing.Size(24, 24);
            this.picSenha.TabIndex = 50;
            this.picSenha.TabStop = false;
            // 
            // picLogin
            // 
            this.picLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogin.Location = new System.Drawing.Point(358, 200);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(24, 24);
            this.picLogin.TabIndex = 49;
            this.picLogin.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.Gray;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Location = new System.Drawing.Point(600, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 24);
            this.picClose.TabIndex = 48;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Location = new System.Drawing.Point(415, 338);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(89, 36);
            this.btnEntrar.TabIndex = 55;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 549);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblCadastre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.TelaLogin);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.BordaSenha);
            this.Controls.Add(this.BordaLogin);
            this.Controls.Add(this.cboSalvo);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.picSenha);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.picClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.TelaLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagemLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Panel TelaLogin;
        private System.Windows.Forms.PictureBox picImagemLogin;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Panel BordaSenha;
        private System.Windows.Forms.Panel BordaLogin;
        private System.Windows.Forms.CheckBox cboSalvo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.PictureBox picSenha;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Button btnEntrar;
    }
}

