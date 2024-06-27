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

            if (dtpData.Value == dtpData.MinDate)
            {
                msgErro += "Preencha a DATA.\n";
            }

            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                msgErro += "Preencha o campo: TÍTULO.\n";
            }
            if (string.IsNullOrEmpty(txtMedico.Text))
            {
                msgErro += "Preencha o campo: NOME DO MÉDICO.\n";
            }
            if (string.IsNullOrEmpty(txtObservacao.Text))
            {
                msgErro += "Preencha o campo: OBSERVAÇÕES.\n";
            }

            return msgErro;
        }

        private void PreencherFormulario()
        {
            txtTitulo.Text = usuario.agenda.Titulo;
            txtMedico.Text = usuario.agenda.NomeMedico;
            txtObservacao.Text = usuario.agenda.Observacao;
            dtpData.Value = usuario.agenda.DataHora;
        }

        private void PreencherClasse()
        {
            usuario.agenda.Titulo = txtTitulo.Text;
            usuario.agenda.NomeMedico = txtMedico.Text;
            usuario.agenda.Observacao = txtObservacao.Text;
            usuario.agenda.DataHora = dtpData.Value;
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

        private void LimparCampos()
        {
            usuario = new Usuario();
            txtTitulo.Clear();
            txtMedico.Clear();
            txtObservacao.Clear();
            dtpData.Value = DateTime.Now;
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
                if (!string.IsNullOrEmpty(txtPesquisaTitulo.Text) || txtPesquisaTitulo.Text != "Título")
                {
                    usuario.agenda.Titulo = txtPesquisaTitulo.Text;
                }
                usuario.agenda.DataInicio = dtpDataAgendaInicio.Value;
                usuario.agenda.DataFim = dtpDataAgendaFim.Value;
                CarregarGridAgenda();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar na agenda: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
