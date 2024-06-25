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
        //MÉTODOS

            //CRIAR ALGUM QUE FAÇA UM FORMULÁRIO CHAMAR OUTRO.
                //Sabemos de duas maneiras até o momento


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            picPerfil.Image = Global.BytesToImage(user.FotoPerfil);
            /* PUXAR O NOME E A FOTO DO USUÁRIO NO BANCO
                     Usuario usuario = new Usuario
                     {
                         Id = Global.IdUsuarioLogado
                       };

                    usuario.Consultar();
                    lblUsuario.Text = $"Usuário: {usuario.Nome}";
                    lblServidor.Text = $"Servidor: {Global.Servidor}";
                    lblBanco.Text = $"Banco: {Global.Banco}";
            */
        }




        //ARRUMAR ESSE PROBLEMINHA AQUI:
        private void btnAgenda_Click(object sender, EventArgs e)
        {
            pnlEnfeite.Height = btnAgenda.Height;
            pnlEnfeite.Top = btnAgenda.Top;

            /* Colocar o User Control da Agenda para frente, assim que acionado o botão:
                    [NOME DO USER CONTROL].BringToFront();
            */
        }
        private void btnGlicemia_Click(object sender, EventArgs e)
        {
            pnlEnfeite.Height = btnGlicemia.Height;
            pnlEnfeite.Top = btnGlicemia.Top;
        }
        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            pnlEnfeite.Height = btnConfiguracao.Height;
            pnlEnfeite.Top = btnConfiguracao.Top;

        }
        //===============================




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
