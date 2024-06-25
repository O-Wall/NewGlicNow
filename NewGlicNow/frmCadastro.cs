using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGlicNow
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        bool load = false;
        Usuario usuario = new Usuario();

        private void PreencherClasse()
        {
            usuario.NomeCompleto = txtNome.Text;
            usuario.log_In.Password = Global.Criptografar(txtSenha.Text);
            usuario.log_In.Login = txtLogin.Text;
            usuario.CPF = txtCPF.Text;
            usuario.Email = txtEmail.Text;
            usuario.DataNascimento = dtpDataNascimento.Value;
            usuario.TipoDiabeteId = cboTipoDiabete.SelectedIndex;
            usuario.SexoId = cboGenero.SelectedIndex;
            usuario.Celular = txtCelular.Text;

            usuario.endereco.Logradouro = txtEndereco.Text;
            usuario.endereco.Complemento = txtComplemento.Text;
            usuario.endereco.Bairro = txtBairro.Text;
            usuario.endereco.CEP = txtCEP.Text;
            usuario.endereco.CidadeId = cboCidade.SelectedIndex;
        }
        private string ValidarPreenchimento()
        {
            try
            {
                string msgErro = string.Empty;

                if (txtNome.Text == string.Empty || txtNome.Text == "Nome Completo")
                {
                    msgErro = "Preencha o campo: NOME COMPLETO.\n";
                }

                if (txtSenha.Text == string.Empty || txtSenha.Text == "Senha")
                {
                    msgErro += "Preencha o campo: SENHA.\n";
                }

                if (txtConfSenha.Text == string.Empty || txtConfSenha.Text == "Confirmar senha")
                {
                    msgErro += "Preencha o campo: CONFIRMAR SENHA.\n";
                }
                else if (txtSenha.Text != txtConfSenha.Text)
                {
                    msgErro += "Confirmação da senha não confere.\n";
                }
                if (txtLogin.Text == string.Empty || txtLogin.Text == "Login")
                {
                    msgErro = "Preencha o campo: LOGIN.\n";
                }
                else
                {
                    Usuario u = new Usuario();
                    u.log_In.Login = txtLogin.Text;
                    u.Consultar();
                    if (usuario.Id == 0 && u.Id != 0 ||
                        usuario.Id != 0 && u.Id != 0 && usuario.Id != u.Id)
                    {
                        msgErro += "Login já existente.\n";
                    }
                }     

                if (txtCPF.Text == string.Empty || txtCPF.Text == "CPF")
                {
                    msgErro += "Preencha o campo: CPF.\n";
                }

                if (txtEmail.Text == string.Empty || txtEmail.Text == "E-mail")
                {
                    msgErro += "Preencha o campo E-MAIL.\n";
                }
                else
                {
                    try
                    {
                        MailAddress ma = new MailAddress(txtEmail.Text);
                    }
                    catch
                    {
                        msgErro += "Email inválido.\n";
                    }
                }
                if(txtNumero.Text == string.Empty || txtNumero.Text == "Nº")
                {
                    msgErro += "Preencha o campo NÚMERO.\n";
                }

                if (dtpDataNascimento.Value == DateTime.Parse("01/01/1900"))
                {
                    msgErro += "Preencha o campo: DATA DE NASCIMENTO.\n";
                }

                if (cboTipoDiabete.SelectedIndex == -1)
                {
                    msgErro += "Selecione o campo: Tipo Diabete.\n";
                }

                if (cboGenero.SelectedIndex == -1)
                {
                    msgErro += "Selecione o campo: Gênero.\n";
                }

                if (txtCelular.Text == string.Empty || txtCelular.Text == "Celular")
                {
                    msgErro += "Preencha o campo Celular.\n";
                }

                if (txtEndereco.Text == string.Empty || txtEndereco.Text == "Endereço")
                {
                    msgErro += "Preencha o campo: ENDEREÇO.\n";
                }

                if (txtComplemento.Text == string.Empty || txtComplemento.Text == "Complemento")
                {
                    msgErro += "Preencha o campo: COMPLEMENTO.\n";
                }

                if (txtBairro.Text == string.Empty || txtBairro.Text == "Bairro")
                {
                    msgErro += "Preencha o campo: BAIRRO.\n";
                }

                if (txtCEP.Text == string.Empty || txtCEP.Text == "CEP")
                {
                    msgErro += "Preencha o campo: CEP.\n";
                }

                if (cboCidade.SelectedIndex == -1)
                {
                    msgErro += "Selecione o campo: CIDADE.\n";
                }

                if (cboEstado.SelectedIndex == -1)
                {
                    msgErro += "Selecione o campo: ESTADO.\n";
                }

                return msgErro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }
        private void CarregarEstados()
        {
            try
            {
                cboEstado.DataSource = Global.ConsultarEstados();
                cboEstado.DisplayMember = "Estado";
                cboEstado.ValueMember = "Id";
                cboEstado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarSexos()
        {
            try
            {
                cboGenero.DataSource = Global.ConsultarSexo();
                cboGenero.DisplayMember = "descricao";
                cboGenero.ValueMember = "Id";
                cboGenero.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro -->" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarTipoDiabetes()
        {
            try
            {
                cboTipoDiabete.DataSource = Global.ConsultarTipoDiabete();
                cboTipoDiabete.DisplayMember = "descricao";
                cboTipoDiabete.ValueMember = "Id";
                cboTipoDiabete.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro -->" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
        private void CarregarCidades()
        {
            if (!load)
            {
                return;
            }

            try
            {
                int estado = Convert.ToInt32(cboEstado.SelectedValue);
                cboCidade.DataSource = Global.ConsultarCidades(estado);
                cboCidade.DisplayMember = "Cidade";
                cboCidade.ValueMember = "Id";
                cboCidade.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            CarregarEstados();
            CarregarSexos();
            CarregarTipoDiabetes();
            load = true;

        }
        private void PicClose_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Certeza que deseja encerrar o Cadastro?",
              "Cadastro - GlicNow", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2);
            if (DialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarCidades();
        }
        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.SomenteNumeros(e.KeyChar, (sender as TextBox).Text);

        }
        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.SomenteNumeros(e.KeyChar, (sender as TextBox).Text);

        }
        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.SomenteNumeros(e.KeyChar, (sender as TextBox).Text);
        }
        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                string MsgErro = ValidarPreenchimento();
                if (MsgErro != string.Empty)
                {
                    MessageBox.Show(MsgErro, "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PreencherClasse();                
                usuario.Gravar();
                MessageBox.Show("Usuário Cadastrado com sucesso!", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro -->"+ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void picEditar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImg = new OpenFileDialog();
            abrirImg.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            string profile = "";

            if (abrirImg.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            profile = abrirImg.FileName;
            try
            {
                byte[] imageBytes;
                using (FileStream fs = new FileStream(profile, FileMode.Open, FileAccess.Read))
                {
                    imageBytes = new byte[fs.Length];
                    fs.Read(imageBytes, 0, Convert.ToInt32(fs.Length));
                }
                usuario.FotoPerfil = imageBytes;
                picProfile.Image = Global.BytesToImage(imageBytes);
                picProfile.SizeMode = PictureBoxSizeMode.Zoom;
                MessageBox.Show("Imagem carregada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.SomenteNumeros(e.KeyChar, (sender as TextBox).Text);
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            Global.ResetMensagem(txtNome);
        }
        private void txtNome_Enter(object sender, EventArgs e)
        {
            Global.LimparTexto(txtNome);
        }
        private void txtSenha_Leave(object sender, EventArgs e)
        {
            Global.ResetMensagem(txtSenha);
        }
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            Global.LimparTexto(txtSenha);
        }
        private void txtConfSenha_Leave(object sender, EventArgs e)
        {
            Global.ResetMensagem(txtConfSenha);
        }
        private void txtConfSenha_Enter(object sender, EventArgs e)
        {
            Global.LimparTexto(txtConfSenha);
        }
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            Global.ResetMensagem(txtLogin);
        }
        private void txtLogin_Enter(object sender, EventArgs e)
        {
            Global.LimparTexto(txtLogin);
        }
        private void txtCPF_Leave(object sender, EventArgs e)
        {
            Global.ResetMensagem(txtCPF);
        }
        private void txtCPF_Enter(object sender, EventArgs e)
        {
            Global.LimparTexto(txtCPF);
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Global.ResetMensagem(txtEmail);
        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            Global.LimparTexto(txtEmail);
        }
        private void txtCelular_Leave(object sender, EventArgs e)
        {
            Global.ResetMensagem(txtCelular);
        }
        private void txtCelular_Enter(object sender, EventArgs e)
        {
            Global.LimparTexto(txtCelular);
        }
        private void txtEndereco_Leave(object sender, EventArgs e)
        {
            Global.ResetMensagem(txtEndereco);
        }
        private void txtEndereco_Enter(object sender, EventArgs e)
        {
            Global.LimparTexto(txtEndereco);
        }
        private void txtNumero_Enter(object sender, EventArgs e)
        {
            Global.LimparTexto(txtNumero);
        }
        private void txtNumero_Leave(object sender, EventArgs e)
        {
            Global.ResetMensagem(txtNumero);
        }
        private void txtComplemento_Leave(object sender, EventArgs e)
        {
            Global.ResetMensagem(txtComplemento);
        }
        private void txtComplemento_Enter(object sender, EventArgs e)
        {
            Global.LimparTexto(txtComplemento);
        }
        private void txtBairro_Leave(object sender, EventArgs e)
        {
            Global.ResetMensagem(txtBairro);
        }
        private void txtBairro_Enter(object sender, EventArgs e)
        {
            Global.LimparTexto(txtBairro);
        }
        private void txtCEP_Leave(object sender, EventArgs e)
        {
            Global.ResetMensagem(txtCEP);
        }
        private void txtCEP_Enter(object sender, EventArgs e)
        {
            Global.LimparTexto(txtCEP);
        }

    }
}
