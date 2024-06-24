using NewGlicNow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalGlicNow
{
    public partial class ucAgenda : UserControl
    {
        public ucAgenda()
        {
            InitializeComponent();
        }

        bool load = false;
        Usuario usuario = new Usuario();


        //MÉTODOS
        private string ValidarPreenchimento()
        {
            try
            {
                string msgErro = string.Empty;

                if (dtpData.Value == DateTime.Parse("01/01/1900"))
                {
                    msgErro += "Preencha a DATA.\n";
                }

                if (txtTitulo.Text == string.Empty)
                {
                    msgErro += "Preencha o campo: TÍTULO.\n";
                }
                if (txtMedico.Text == string.Empty)
                {
                    msgErro += "Preencha o campo: NOME DO MÉDICO.\n";
                }
                if (txtObservacao.Text == string.Empty)
                {
                    msgErro += "Preencha o campo: OBSERVAÇÕES.\n";
                }

                return msgErro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void PreencherFormulario()
        {
            /*
            txtTitulo.Text = //usuario.Login;
            //dtpData
            txtMedico.Text = //usuario.Password;
            txtObservacao.Text = //usuario.Password;            
            */
        }

        private void CarregarGridAgenda()
        {
            /* AQUI SERÁ PRECISO FAZER O SISTEMA CONVERSAR COM A TABLE "AGENDA"
             do USUARIO POR MEIO DO [ CONSULTAR(); ]
            */
            try
            {
                grdAgenda.DataSource = usuario.Consultar();

                //Ocultando colunas
                grdAgenda.Columns[0].Visible = false;
                grdAgenda.Columns[3].Visible = false;
                grdAgenda.Columns[5].Visible = false;
                //Definindo cabeçalhos
                grdAgenda.Columns[1].HeaderText = "Título";
                grdAgenda.Columns[2].HeaderText = "Data";
                grdAgenda.Columns[4].HeaderText = "Observação";

                //Definindo largura das colunas               
                grdAgenda.Columns[1].Width = 149;
                grdAgenda.Columns[2].Width = 149;
                grdAgenda.Columns[3].Width = 149;
                grdAgenda.Columns[4].Width = 149;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            //Irá apagar somente o que está abaixo de "Registrar tarefas"
            usuario = new Usuario();
            txtTitulo.Clear();
            txtMedico.Clear();
            txtObservacao.Clear();
            txtTitulo.Focus();
        }
        //



        //"FUNÇÕES"
        private void ucAgenda_Load(object sender, EventArgs e)
        {
            CarregarGridAgenda();
            load = true;
        }


        //ARRUMAR ESSE PROBLEMINHA AQUI:
        private void txtPesquisaTitulo_TextChanged(object sender, EventArgs e)
        {
            /* Fazer busca no banco de dados
                    Preciso verificar se é o "TextChanged" o mais aconselhável
             */

            /*
            usuario = new Usuario();
            usuario.Nome = txtPesquisaTitulo.Text; //COLOCAR: "objeto.NOME A SER PREENCHIDO"
            CarregarGridAgenda();
            */
        }
        private void dtpDataAgenda_ValueChanged(object sender, EventArgs e)
        {
            /*
           usuario = new Usuario();
           usuario.DataHora = dtpData.Value; //COLOCAR: "objeto.NOME A SER PREENCHIDO"
           CarregarGridAgenda();
           */
        }
        private void grdAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            try
            {
                 ALTEREI ALGUMAS COISAS, MAS AINDA PRECISA ARRUMAR O ACESSO AO BANCO
                usuario = new Usuario();
                usuario.Id = Convert.ToInt32(grdAgenda.SelectedRows[0].Cells[0].Value);
                usuario.Consultar();
                PreencherFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }
        //===============================



        //ARRUMAR ESSE PROBLEMINHA AQUI:
        private void btnGravar_Click(object sender, EventArgs e)
        {
            /*Gravar tudo no banco de dados
             */
        }
        //===============================


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
             


    }
}
