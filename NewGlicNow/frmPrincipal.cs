using FinalGlicNow;
using Microsoft.VisualBasic.ApplicationServices;
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
using System.Runtime.InteropServices;


namespace NewGlicNow
{
    public partial class frmPrincipal : Form
    {
        private ucAgenda ucAgenda;
        private ucCadastroMapGlic ucCadastroMapGlic;


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();


        public frmPrincipal()
        {
            InitializeComponent();
            ucAgenda = new ucAgenda();
            ucCadastroMapGlic = new ucCadastroMapGlic();
            TrocaUser(ucAgenda);
            TrocaCorBtn(btnAgenda);
        }

      

        private void TrocaUser(UserControl userControl)
        {
            pnlPrincipal.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(userControl);
        }
        private void TrocaCorBtn(Button activeButton)
        {
            if (activeButton == btnAgenda)
            {
                btnAgenda.BackColor = Color.FromArgb(181, 63, 59);
                btnGlicemia.BackColor = Color.FromArgb(137, 21, 32);
            }
            else if (activeButton == btnGlicemia)
            {
                btnGlicemia.BackColor = Color.FromArgb(162, 46, 44);
                btnAgenda.BackColor = Color.FromArgb(137, 21, 32);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Id = Global.IdUsuarioLogado;
            usuario.Consultar();
            if (usuario.FotoPerfil != null)
            {
                picPerfil.Image = Global.BytesToImage(usuario.FotoPerfil);
                picPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                picPerfil.BackColor = Color.Transparent;
            }
            lblNomePerfil.Text = usuario.NomeCompleto;
            picClose.Visible = true;
            picCloseHouver.Visible = false;
        }


              
        private void btnAgenda_Click(object sender, EventArgs e)
        {
            pnlEnfeite.Height = btnAgenda.Height;
            pnlEnfeite.Top = btnAgenda.Top;
            TrocaCorBtn(btnAgenda);
            TrocaUser(ucAgenda);


            //Puxar User Control 
            //Colocar cor nova
        }
        private void btnGlicemia_Click(object sender, EventArgs e)
        {
            pnlEnfeite.Height = btnGlicemia.Height;
            pnlEnfeite.Top = btnGlicemia.Top;
            TrocaCorBtn(btnGlicemia);
            TrocaUser(ucCadastroMapGlic);
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

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            picClose.Visible = false;
            picCloseHouver.Visible = true;
            
        }
    }
}
