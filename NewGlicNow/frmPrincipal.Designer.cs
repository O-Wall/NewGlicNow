namespace NewGlicNow
{
    partial class frmPrincipal
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
            System.Windows.Forms.Button btnMapaGlicemia;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.Button btnAgenda;
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNomePerfil = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.picConfigu = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            btnMapaGlicemia = new System.Windows.Forms.Button();
            btnAgenda = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfigu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OrangeRed;
            this.panel3.Location = new System.Drawing.Point(1, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 45);
            this.panel3.TabIndex = 20;
            // 
            // btnMapaGlicemia
            // 
            btnMapaGlicemia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(63)))), ((int)(((byte)(59)))));
            btnMapaGlicemia.FlatAppearance.BorderSize = 0;
            btnMapaGlicemia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMapaGlicemia.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnMapaGlicemia.ForeColor = System.Drawing.Color.White;
            btnMapaGlicemia.Location = new System.Drawing.Point(12, 211);
            btnMapaGlicemia.Name = "btnMapaGlicemia";
            btnMapaGlicemia.Size = new System.Drawing.Size(173, 45);
            btnMapaGlicemia.TabIndex = 14;
            btnMapaGlicemia.Text = "Mapa de Glicemia";
            btnMapaGlicemia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMapaGlicemia.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.picMinimize);
            this.panel2.Controls.Add(this.picClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 33);
            this.panel2.TabIndex = 24;
            // 
            // picMinimize
            // 
            this.picMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimize.BackColor = System.Drawing.Color.Transparent;
            this.picMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picMinimize.Image")));
            this.picMinimize.Location = new System.Drawing.Point(891, 6);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(24, 24);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMinimize.TabIndex = 26;
            this.picMinimize.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(922, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 24);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picClose.TabIndex = 25;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.PicClose_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(63)))), ((int)(((byte)(59)))));
            this.panel4.Controls.Add(btnAgenda);
            this.panel4.Controls.Add(this.lblNomePerfil);
            this.panel4.Controls.Add(this.panel13);
            this.panel4.Controls.Add(this.picProfile);
            this.panel4.Controls.Add(btnMapaGlicemia);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(-1, 98);
            this.panel4.Name = "panel4";
            this.panel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel4.Size = new System.Drawing.Size(186, 504);
            this.panel4.TabIndex = 27;
            // 
            // btnAgenda
            // 
            btnAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(63)))), ((int)(((byte)(59)))));
            btnAgenda.FlatAppearance.BorderSize = 0;
            btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAgenda.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAgenda.ForeColor = System.Drawing.Color.White;
            btnAgenda.Location = new System.Drawing.Point(12, 120);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new System.Drawing.Size(173, 45);
            btnAgenda.TabIndex = 36;
            btnAgenda.Text = "Agenda";
            btnAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAgenda.UseVisualStyleBackColor = false;
            // 
            // lblNomePerfil
            // 
            this.lblNomePerfil.AutoSize = true;
            this.lblNomePerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblNomePerfil.Location = new System.Drawing.Point(52, 40);
            this.lblNomePerfil.Name = "lblNomePerfil";
            this.lblNomePerfil.Size = new System.Drawing.Size(85, 13);
            this.lblNomePerfil.TabIndex = 35;
            this.lblNomePerfil.Text = "Nome do Sujeito";
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel13.BackColor = System.Drawing.Color.Black;
            this.panel13.Location = new System.Drawing.Point(63, 29);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(64, 2);
            this.panel13.TabIndex = 34;
            // 
            // picProfile
            // 
            this.picProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picProfile.Image = ((System.Drawing.Image)(resources.GetObject("picProfile.Image")));
<<<<<<< HEAD
            this.picProfile.Location = new System.Drawing.Point(5, 227);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(182, 266);
=======
            this.picProfile.Location = new System.Drawing.Point(3, 263);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(182, 237);
>>>>>>> 37d9d37d6de89b02612ee5252c2814aec34c2b23
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 22;
            this.picProfile.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(185, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 500);
            this.panel1.TabIndex = 28;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.OrangeRed;
            this.panel6.Location = new System.Drawing.Point(187, 112);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(772, 2);
            this.panel6.TabIndex = 29;
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(-1, 96);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(63, 2);
            this.panel9.TabIndex = 30;
            // 
            // panel10
            // 
            this.panel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(125, 96);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(62, 2);
            this.panel10.TabIndex = 31;
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(62, 63);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(63, 2);
            this.panel12.TabIndex = 33;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Black;
            this.panel16.Location = new System.Drawing.Point(124, 63);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(2, 66);
            this.panel16.TabIndex = 23;
            // 
            // picPerfil
            // 
            this.picPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPerfil.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.picPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPerfil.Location = new System.Drawing.Point(61, 63);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(64, 64);
            this.picPerfil.TabIndex = 21;
            this.picPerfil.TabStop = false;
            // 
            // picConfigu
            // 
            this.picConfigu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picConfigu.BackColor = System.Drawing.Color.Transparent;
            this.picConfigu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picConfigu.Image = ((System.Drawing.Image)(resources.GetObject("picConfigu.Image")));
            this.picConfigu.Location = new System.Drawing.Point(11, 45);
            this.picConfigu.Name = "picConfigu";
            this.picConfigu.Size = new System.Drawing.Size(32, 32);
            this.picConfigu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConfigu.TabIndex = 27;
            this.picConfigu.TabStop = false;
            this.picConfigu.Click += new System.EventHandler(this.PicConfigu_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(60, 63);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 66);
            this.panel7.TabIndex = 24;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(954, 594);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picPerfil);
            this.Controls.Add(this.picConfigu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal_";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConfigu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picPerfil;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picConfigu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Label lblNomePerfil;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.Panel panel7;
    }
}