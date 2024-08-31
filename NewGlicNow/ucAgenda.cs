using System;
using System.Windows.Forms;

namespace NewGlicNow
{
    public partial class ucAgenda : UserControl
    {
        public ucAgenda()
        {
            InitializeComponent();
        }

        Usuario usuario = new Usuario();

        private string ValidarPreenchimento()
        {
            string msgErro = string.Empty;

            if (dtpData.Value.Date == dtpData.MinDate.Date || dtpData.Text == "01/01/1999")
            {
                msgErro += "Preencha a DATA.\n";
            }

            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                msgErro += "Preencha o campo: TÍTULO.\n";
            }

            return msgErro;
        }        
        private void PreencherFormulario()
        {
            txtTitulo.Text = usuario.agenda.Titulo;
            txtMedico.Text = usuario.agenda.NomeMedico;
            txtObservacao.Text = usuario.agenda.Observacao;
            dtpData.Value = usuario.agenda.DataHora.Date;
        }

        private void PreencherClasse()
        {
            usuario.agenda.Titulo = txtTitulo.Text;
            usuario.agenda.NomeMedico = txtMedico.Text;
            usuario.agenda.Observacao = txtObservacao.Text;
            usuario.agenda.DataHora = dtpData.Value.Date;
        }

        private void CarregarGridAgenda()
        {
            try
            {
                grdAgenda.DataSource = usuario.agenda.Consultar();
                // Ocultando colunas
                grdAgenda.Columns[0].Visible = false;
                grdAgenda.Columns[3].Visible = false;
                grdAgenda.Columns[4].Visible = false;
                grdAgenda.Columns[5].Visible = false;
                grdAgenda.Columns[6].Visible = false;
                // Definindo cabeçalhos
                grdAgenda.Columns[1].HeaderText = "Data";
                grdAgenda.Columns[2].HeaderText = "Título";
                // Definindo largura das colunas               
                grdAgenda.Columns[1].Width = 100;
                grdAgenda.Columns[2].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a agenda: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AtualizarAtivos()
        {
            try
            {
                CarregarGridAgenda();
                //Verificar cada linha se a data é menor que a data de hoje;
                foreach (var r in grdAgenda.Rows)
                {
                    if ()
                    {

                    }
                }
                //Atualizar os que tiverem ativos para desativados
                //Carregar o grid, com os ativos apenas
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar os eventos ativos para desativados: {ex.Message}", "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            usuario = new Usuario();
            txtTitulo.Clear();
            txtMedico.Clear();
            txtObservacao.Clear();
            dtpData.Value = DateTime.Now.Date;
            txtTitulo.Focus();
        }

        private void ucAgenda_Load(object sender, EventArgs e)
        {
            CarregarGridAgenda();
        }

        private void grdAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = grdAgenda.Rows[e.RowIndex];
                    usuario.agenda.Id = Convert.ToInt32(row.Cells[0].Value);
                    usuario.agenda.Consultar();
                    PreencherFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar a agenda: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                string MsgERRO = ValidarPreenchimento();
                if (!string.IsNullOrEmpty(MsgERRO))
                {
                    MessageBox.Show(MsgERRO, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                PreencherClasse();
                usuario.agenda.Gravar();
                MessageBox.Show("Evento Gravado com Sucesso!",
                    "Agenda",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                CarregarGridAgenda();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gravar a agenda: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                usuario = new Usuario();
                if (txtPesquisaTitulo.Text != "Título")
                {
                    usuario.agenda.Titulo = txtPesquisaTitulo.Text;
                }
                usuario.agenda.DataInicio = dtpDataAgendaInicio.Value.Date;
                usuario.agenda.DataFim = dtpDataAgendaFim.Value.Date;
                CarregarGridAgenda();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar na agenda: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void txtMedico_Enter(object sender, EventArgs e)
        {
            Global.TextBoxEnter(txtMedico, "Nome do Medico");           
        }

        private void txtMedico_Leave(object sender, EventArgs e)
        {
            Global.TextBoxLeave(txtMedico, "Nome do Medico");
        }

        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            Global.TextBoxEnter(txtTitulo, "Título");
        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            Global.TextBoxLeave(txtTitulo, "Título");
        }

        private void txtObservacao_Enter(object sender, EventArgs e)
        {
            Global.TextBoxEnter(txtObservacao, "Observação");
        }

        private void txtObservacao_Leave(object sender, EventArgs e)
        {
            Global.TextBoxLeave(txtObservacao, "Observação");
        }

        private void txtPesquisaTitulo_Enter(object sender, EventArgs e)
        {
            Global.TextBoxEnter(txtPesquisaTitulo, "Título");
        }

        private void txtPesquisaTitulo_Leave(object sender, EventArgs e)
        {
            Global.TextBoxLeave(txtPesquisaTitulo, "Título");
        }
    }
}