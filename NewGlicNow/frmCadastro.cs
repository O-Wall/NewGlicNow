using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Runtime.InteropServices;


namespace NewGlicNow
{
    public partial class FrmCadastro : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

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
            usuario.TipoDiabeteId = Convert.ToInt32(cboTipoDiabete.SelectedValue);
            usuario.SexoId = Convert.ToInt32(cboGenero.SelectedValue);
            usuario.Celular = txtCelular.Text;

            usuario.endereco.Logradouro = txtEndereco.Text;
            usuario.endereco.Complemento = txtComplemento.Text;
            usuario.endereco.Bairro = txtBairro.Text;
            usuario.endereco.CEP = txtCEP.Text;
            usuario.endereco.CidadeId = cboCidade.SelectedIndex;
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
                if(txtNumero.Text == string.Empty || txtNumero.Text == "Nº")
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
                cboEstado.SelectedIndex = 0;
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
                cboGenero.SelectedIndex = 0;
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
                cboTipoDiabete.SelectedIndex = 0;
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
                cboCidade.SelectedIndex = 0;
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
            picClose.Visible = true;
            picCloseHouver.Visible = false;

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
                Global.IdUsuarioLogado = usuario.Id;
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
                Global.TextBoxLeave(txtNome, "Nome Completo");           
        }
        private void txtNome_Enter(object sender, EventArgs e)
        {
            Global.TextBoxEnter(txtNome, "Nome Completo");

        }


        private void txtSenha_Leave(object sender, EventArgs e)
        {
            Global.TextBoxLeave(txtSenha, "Senha");
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            Global.TextBoxEnter(txtSenha, "Senha");
        }

        


        private void txtConfSenha_Leave(object sender, EventArgs e)
        {
            Global.TextBoxLeave(txtConfSenha, "Confirmar senha");
        }
        private void txtConfSenha_Enter(object sender, EventArgs e)
        {
            Global.TextBoxEnter(txtConfSenha, "Confirmar senha");
        }



        private void txtLogin_Leave(object sender, EventArgs e)
        {
            Global.TextBoxLeave(txtLogin, "Login");

        }
        private void txtLogin_Enter(object sender, EventArgs e)
        {
            Global.TextBoxEnter(txtLogin, "Login");
        }



        private void txtCPF_Leave(object sender, EventArgs e)
        {
            Global.TextBoxLeave(txtCPF, "CPF");
        }
        private void txtCPF_Enter(object sender, EventArgs e)
        {
            Global.TextBoxEnter(txtCPF, "CPF");

        }


        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Global.TextBoxLeave(txtEmail, "E-mail");

        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            Global.TextBoxEnter(txtEmail, "E-mail");
        }


        private void txtCelular_Leave(object sender, EventArgs e)
        {
            Global.TextBoxLeave(txtCelular, "Celular");
        }
        private void txtCelular_Enter(object sender, EventArgs e)
        {
            Global.TextBoxEnter(txtCelular, "Celular");
        }


        private void txtEndereco_Leave(object sender, EventArgs e)
        {
            Global.TextBoxLeave(txtEndereco, "Endereço");
        }
        private void txtEndereco_Enter(object sender, EventArgs e)
        {
            Global.TextBoxEnter(txtEndereco, "Endereço");
        }


        private void txtNumero_Enter(object sender, EventArgs e)
        {
            Global.TextBoxEnter(txtNumero, "Nº");
        }
        private void txtNumero_Leave(object sender, EventArgs e)
        {
            Global.TextBoxLeave(txtNumero, "Nº");
        }


        private void txtComplemento_Leave(object sender, EventArgs e)
        {
            Global.TextBoxLeave(txtComplemento, "Complemento");
        }
        private void txtComplemento_Enter(object sender, EventArgs e)
        {
            Global.TextBoxEnter(txtComplemento, "Complemento");
        }


        private void txtBairro_Leave(object sender, EventArgs e)
        {
            Global.TextBoxLeave(txtBairro, "Bairro");
        }
        private void txtBairro_Enter(object sender, EventArgs e)
        {
            Global.TextBoxEnter(txtBairro, "Bairro");
        }


        private void txtCEP_Leave(object sender, EventArgs e)
        {
            Global.TextBoxLeave(txtCEP, "CEP");
        }
        private void txtCEP_Enter(object sender, EventArgs e)
        {
            Global.TextBoxEnter(txtCEP, "CEP");
        }

        private void cboEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregarCidades();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }


        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.Image = Properties.Resources.icons8_cancelar_48;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.Image = Properties.Resources.Close_vermelho_48;
        }
    }
}
