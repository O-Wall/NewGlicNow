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
        Log_in log_In = new Log_in();
        Endereco endereco = new Endereco();

        //MÉTODOS
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

                if (txtNome.Text == string.Empty)
                {
                    msgErro += "Preencha o campo: NOME COMPLETO.\n";
                }

                if (txtSenha.Text == string.Empty)
                {
                    msgErro += "Preencha o campo: SENHA.\n";
                }

                if (txtConfSenha.Text == string.Empty)
                {
                    msgErro += "Preencha o campo: CONFIRMAR SENHA.\n";
                }
                else if (txtSenha.Text != txtConfSenha.Text)
                {
                    msgErro += "Confirmação da senha não confere.\n";
                }

                /* VERIFICAR ISSO AQUI [LOGIN]
                 * if (txtLogin.Text == string.Empty)
                {
                    msgErro = "Preencha o USUÁRIO.\n";
                }
                else
                {
                    Usuario u = new Usuario();
                    u.Login = txtUsuario.Text;
                    u.Consultar();
                    if (usuario.Id == 0 && u.Id != 0 ||
                        usuario.Id != 0 && u.Id != 0 && usuario.Id != u.Id)
                    {
                        msgErro += "Usuário já existente.\n";
                    }
                }
                */

                if (txtCPF.Text == string.Empty)
                {
                    msgErro += "Preencha o campo: CPF.\n";
                }

                if (txtEmail.Text == string.Empty)
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

                if (txtCelular.Text == string.Empty)
                {
                    msgErro += "Preencha o campo NÚMERO.\n";
                }

                if (txtEndereco.Text == string.Empty)
                {
                    msgErro += "Preencha o campo: ENDEREÇO.\n";
                }

                if (txtComplemento.Text == string.Empty)
                {
                    msgErro += "Preencha o campo: COMPLEMENTO.\n";
                }

                if (txtBairro.Text == string.Empty)
                {
                    msgErro += "Preencha o campo: BAIRRO.\n";
                }

                if (txtCEP.Text == string.Empty)
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
                cboGenero.DisplayMember = "Gênero";
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
                cboTipoDiabete.DisplayMember = "Tipo Diabete";
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
        //


        //"FUNÇÕES"
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
                log_In.Gravar();
                endereco.Gravar();
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

            if (abrirImg.ShowDialog() == DialogResult.OK)
            {
                profile = abrirImg.FileName;
            }

            try
            {
                byte[] imageBytes;
                using (FileStream fs = new FileStream(profile, FileMode.Open, FileAccess.Read))
                {
                    imageBytes = new byte[fs.Length];
                    fs.Read(imageBytes, 0, Convert.ToInt32(fs.Length));
                }


                MessageBox.Show("Imagem carregada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //picProfile.Image =  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
