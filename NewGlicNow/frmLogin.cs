using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGlicNow
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        bool passwordchar = true;
        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Tag = "";
            try
            {
                if (cboSalvo.Checked)
                {
                    
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void lblCasdatre_Click(object sender, EventArgs e)
        {
            Tag = "Cadastro";
            Close();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
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
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Erro --> " +ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (passwordchar)
            {
                Global.LimparTexto(txtPassword);
                txtPassword.UseSystemPasswordChar = true;
                passwordchar = false;
            }           
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Text = Global.ResetMsg;
                Global.ResetMsg = string.Empty;
                txtPassword.UseSystemPasswordChar = false;
                passwordchar = true;
            }
        }
        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if(txtLogin.Text == "Username")
            {
                Global.LimparTexto(txtLogin);
            }
        }
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if(txtLogin.Text == string.Empty)
            {
                txtLogin.Text = Global.ResetMsg;
                Global.ResetMsg = string.Empty;
            }              
            
        }
    }
}
