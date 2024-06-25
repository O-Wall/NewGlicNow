﻿using FinalGlicNow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGlicNow
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        Usuario user = new Usuario();


        /* AFAZERES
         
               //Deixar o botão agenda como "inicial" e trazer a ucAgenda junto, podemos colocar uma mensagem na parte branca.
               //Olhe o botão agenda
               //Olhe o botão glicemia
                       
         */


        //MÉTODOS

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (user.FotoPerfil != null)
            {
                picPerfil.Image = Global.BytesToImage(user.FotoPerfil);
            }
            lblNomePerfil.Text = user.NomeCompleto; //Vai ficar estranho o nome completo, será que dá para limitar?

            //Deixar o botão agenda como "inicial" e trazer a ucAgenda junto, podemos colocar uma mensagem na parte branca.
        }


              
        private void btnAgenda_Click(object sender, EventArgs e)
        {
            pnlEnfeite.Height = btnAgenda.Height;
            pnlEnfeite.Top = btnAgenda.Top;
            //Trazer o ucAgenda para frente
        }
        private void btnGlicemia_Click(object sender, EventArgs e)
        {
            pnlEnfeite.Height = btnGlicemia.Height;
            pnlEnfeite.Top = btnGlicemia.Top;
            //Trazer o ucCadastroMapGlic para frente
        }
        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            pnlEnfeite.Height = btnConfiguracao.Height;
            pnlEnfeite.Top = btnConfiguracao.Top;

            frmConfig frmConfig = new frmConfig();
            frmConfig.ShowDialog();

        }


        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação?",
               "GlicNow", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
