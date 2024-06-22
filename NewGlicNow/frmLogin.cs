using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGlicNow
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        bool passwordchar = true;
        private void PicClose_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Deseja encerrar a aplicação?",
              "GlicNow", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2);
            if (DialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Tag = "";
            Global.LerAppConfig();
            if (Global.UltimoIdLogado != "0")
            {
                try
                {
                    Usuario usuario = new Usuario();
                    usuario.log_In.Id = Convert.ToInt32(Global.UltimoIdLogado);
                    usuario.log_In.Consultar();
                    if(usuario.log_In.Salvo == true)
                    {
                        txtLogin.Text = usuario.log_In.Login;
                        txtPassword.Text = usuario.log_In.Password;
                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro --> " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LblCasdatre_Click(object sender, EventArgs e)
        {
            Tag = "Cadastro";
            Close();
        }
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string PasswordCriptografada = Global.Criptografar(txtPassword.Text);
                Usuario usuario = new Usuario();
                usuario.log_In.Login = txtLogin.Text;
                usuario.log_In.Consultar();
                if (usuario.log_In.Id == 0)
                {
                    MessageBox.Show("Usuário e/ou senha inválidos", "Erro no Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!usuario.log_In.Autenticar(PasswordCriptografada))
                {
                    MessageBox.Show("Usuário e/ou senha inválidos", "Erro no Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                usuario.Id = usuario.log_In.UsuarioId;
                usuario.Consultar();
                MessageBox.Show($"Bem vindo {usuario.NomeCompleto}. ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Global.IdUsuarioLogado = usuario.Id;
                if(cboSalvo.Checked == true)
                {
                    usuario.log_In.Salvo = true;
                    usuario.log_In.Gravar();
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["UltimoIdLogado"].Value = Convert.ToString(Global.IdUsuarioLogado);
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }
                else
                {
                    usuario.log_In.Salvo = false;
                    usuario.log_In.Gravar();
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["UltimoIdLogado"].Value = "0";
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Erro --> " +ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (passwordchar)
            {
                Global.LimparTexto(txtPassword);
                txtPassword.UseSystemPasswordChar = true;
                passwordchar = false;
            }           
        }
        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Text = Global.ResetMsg;
                Global.ResetMsg = string.Empty;
                txtPassword.UseSystemPasswordChar = false;
                passwordchar = true;
            }
        }
        private void TxtLogin_Enter(object sender, EventArgs e)
        {
            if(txtLogin.Text == "Username")
            {
                Global.LimparTexto(txtLogin);
            }
        }
        private void TxtLogin_Leave(object sender, EventArgs e)
        {
            if(txtLogin.Text == string.Empty)
            {
                txtLogin.Text = Global.ResetMsg;
                Global.ResetMsg = string.Empty;
            }              
            
        }
    }
}
