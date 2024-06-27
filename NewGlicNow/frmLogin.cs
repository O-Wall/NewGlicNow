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

        //colocar mais um botão vermelho (claro)

        bool passwordchar = true;

        private string ValidarCampos()
        {
            string msgErro = string.Empty;
            if(txtLogin.Text == string.Empty)
            {
                msgErro = "Preencha o campo: Login! \n";
            }
            if(txtSenha.Text  == string.Empty)
            {
                msgErro += "Preencha o campo: Senha! \n";
            }
            return msgErro;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Tag = "";
            Global.LerAppConfig();
            if (Global.UltimoIdLogado != "0")
            {
                try
                {
                    Usuario usuario = new Usuario();
                    usuario.log_In.UsuarioId = Convert.ToInt32(Global.UltimoIdLogado);
                    usuario.log_In.Consultar();
                    if (usuario.log_In.Salvo == true)
                    {
                        txtLogin.Text = usuario.log_In.Login;
                        txtSenha.Text = usuario.log_In.Password;
                        txtSenha.UseSystemPasswordChar = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro --> " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Login")
            {
                Global.LimparTexto(txtLogin);
            }
        }
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            Global.ResetMensagem(txtLogin);
        }
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (passwordchar)
            {
                Global.LimparTexto(txtSenha);
                txtSenha.UseSystemPasswordChar = true;
                passwordchar = false;
            }
        }
        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                txtSenha.Text = Global.ResetMsg;
                Global.ResetMsg = string.Empty;
                txtSenha.UseSystemPasswordChar = false;
                passwordchar = true;
            }
        }
        private void lblCadastre_Click(object sender, EventArgs e)
        {
            Tag = "Cadastro";
            Close();
        }
        private void picClose_Click(object sender, EventArgs e)
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
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string msgErro = ValidarCampos();
                if(msgErro != string.Empty)
                {
                    MessageBox.Show(msgErro, "Erro de Preenchimento",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string PasswordCriptografada = txtSenha.Text;
                Usuario usuario = new Usuario();
                usuario.log_In.Login = txtLogin.Text;
                usuario.log_In.Consultar();
                if (txtSenha.Text != usuario.log_In.Password)
                {
                    PasswordCriptografada = Global.Criptografar(txtSenha.Text);
                }
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

                if (cboSalvo.Checked == true)
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
                MessageBox.Show("Erro --> " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void lblCadastre_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblCadastre_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}