using NewGlicNow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        bool passwordchar = true;


        //MÉTODOS
        private string ValidarPreenchimento()
        {
            try
            {
                string msgErro = string.Empty;

                /* [LOGIN]  VERIFICAR ISSO AQUI 
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


                if (txtNome.Text == string.Empty)
                {
                    msgErro += "Preencha o campo: NOME COMPLETO.\n";
                }

                if (txtCPF.Text == string.Empty)
                {
                    msgErro += "Preencha o campo: CPF.\n";
                }

                if (dtpDataNascimento.Value == DateTime.Parse("01/01/1900"))
                {
                    msgErro += "Preencha o campo: DATA DE NASCIMENTO.\n";
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

                if (cboGenero.SelectedIndex == -1)
                {
                    msgErro += "Selecione o campo: Gênero.\n";
                }

                if (cboTipoDiabete.SelectedIndex == -1)
                {
                    msgErro += "Selecione o campo: Tipo Diabete.\n";
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

        //CRIAR UM MÉTODO QUE AO ABRIR O "FORM CONFIGURAÇÕES" JÁ TRAGA OS DADOS DO USUÁRIO
        /* POR EXEMPLO:
 private void PreencherClasse() //PRECISAREI USAR EM CONFIGURAÇÕES
 {
       usuario.Login = txtUsuario.Text;
       usuario.Nome = txtNome.Text;
       if (usuario.Password != txtSenha.Text)
       {
          usuario.Password = Global.Criptografar(txtSenha.Text);
       }
       usuario.Ativo = rdbAtivo.Checked;
 }
*/

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
        //


        //"FUNÇÕES"
        private void frmConfig_Load(object sender, EventArgs e)
        {
            CarregarEstados();
            load = true;
        }

        //========================

        //========================


        //ARRUMAR ESSE PROBLEMINHA AQUI: (Fazer o sistema puxar do banco de dados para exibir)
        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cboTipoDiabete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //========================


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


        //ARRUMAR ESSE PROBLEMINHA AQUI:
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            /* Fazer com que atualize o banco de dados do usuário
             * Mostrar uma mensagem de alteração bem-sucedida
             */
        }
        //========================


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


    }
}