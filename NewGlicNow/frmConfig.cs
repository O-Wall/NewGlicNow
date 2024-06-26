﻿using NewGlicNow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalGlicNow
{

    public partial class frmConfig : Form
    {
        public frmConfig()
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
        private void PreencherFormulario()
        {
            txtNome.Text = usuario.NomeCompleto;
            txtSenha.Text = usuario.log_In.Password;
            txtLogin.Text = usuario.log_In.Login;
            txtCPF.Text = usuario.CPF;
            txtEmail.Text = usuario.Email;
            dtpDataNascimento.Value = usuario.DataNascimento;
            cboTipoDiabete.SelectedIndex = usuario.TipoDiabeteId;
            cboGenero.SelectedIndex = usuario.SexoId;
            txtCelular.Text = usuario.Celular;

            txtEndereco.Text = usuario.endereco.Logradouro;
            txtComplemento.Text = usuario.endereco.Complemento;
            txtBairro.Text = usuario.endereco.Bairro;
            txtCEP.Text = usuario.endereco.CEP;
            cboCidade.SelectedIndex = usuario.endereco.CidadeId;
        }
        public static bool ValidarCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (new string(j.ToString()[0], 11) == cpf)
                    return false;

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
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
                else if (!ValidarCPF(txtCPF.Text))
                {
                    msgErro += "CPF inválido.\n";
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
                if (txtNumero.Text == string.Empty || txtNumero.Text == "Nº")
                {
                    msgErro += "Preencha o campo NÚMERO.\n";
                }

                if (dtpDataNascimento.Value == DateTime.Parse("01/01/1999"))
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
        private void frmConfig_Load(object sender, EventArgs e)
        {
            CarregarEstados();
            load = true;
            CarregarCidades();
            CarregarSexos();
            CarregarTipoDiabetes();
            PreencherFormulario();        
        }
        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarCidades();
        }
        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.SomenteNumeros(e.KeyChar, (sender as TextBox).Text);
        }
        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.SomenteNumeros(e.KeyChar, (sender as TextBox).Text);
        }
        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.SomenteNumeros(e.KeyChar, (sender as TextBox).Text);
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string MsgErro = ValidarPreenchimento();
            if (MsgErro != string.Empty)
            {
                MessageBox.Show(MsgErro, "Erro de Preenchimento!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PreencherClasse();
            usuario.Gravar();
            MessageBox.Show("Usuário atualizado com sucesso!", "Configuração de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PreencherFormulario();
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Deseja fechar a aba configuração?",
              "GlicNow", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2);

            if (DialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.SomenteNumeros(e.KeyChar, (sender as TextBox).Text);
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
            FileInfo fileInfo = new FileInfo(profile);

            // Verifique se o tamanho da imagem é maior que 1 MB (1048576 bytes)
            if (fileInfo.Length > 1048576)
            {
                MessageBox.Show("A imagem selecionada é muito grande. Por favor, selecione uma imagem com tamanho menor que 1 MB.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                byte[] imageBytes;
                using (FileStream fs = new FileStream(profile, FileMode.Open, FileAccess.Read))
                {
                    imageBytes = new byte[fs.Length];
                    fs.Read(imageBytes, 0, Convert.ToInt32(fs.Length));
                }
                usuario.FotoPerfil = imageBytes;
                picPerfil.Image = Global.BytesToImage(imageBytes);
                picPerfil.SizeMode = PictureBoxSizeMode.Zoom;
                MessageBox.Show("Imagem carregada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}