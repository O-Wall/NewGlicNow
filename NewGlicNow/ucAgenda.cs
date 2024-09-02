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
        private void CarregarGridAgenda()
        {
            try
            {
                grdAgenda.DataSource = usuario.agenda.Consultar();
                // Ocultando colunas
                grdAgenda.Columns[0].Visible = false;
                grdAgenda.Columns[3].Visible = false;
                grdAgenda.Columns[4].Visible = false;
                grdAgenda.Columns[6].Visible = false;
                // Definindo cabeçalhos
                grdAgenda.Columns[1].HeaderText = "Data";
                grdAgenda.Columns[2].HeaderText = "Título";
                grdAgenda.Columns[5].HeaderText = "Ativo";
                // Definindo largura das colunas               
                grdAgenda.Columns[1].Width = 70;
                grdAgenda.Columns[2].Width = 444;
                // Exibindo apenas o Importante
                grdAgenda.Columns[1].Visible = true;
                grdAgenda.Columns[2].Visible = true;
                grdAgenda.Columns[5].Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a agenda: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ValidarCampos()
        {
            string msgErro = string.Empty;
            if (txtTitulo.Text == string.Empty || txtTitulo.Text == "Título")
            {
                msgErro = "Preencha o campo: Título; \n";
            }
            if(dtpData.Value.Date == DateTime.MinValue)
            {
                msgErro += "Selecione a Data; \n";
            }
            return msgErro;
        }
        private void PreencherClasse()
        {
            usuario.agenda.DataHora = dtpData.Value.Date;
            usuario.agenda.Titulo = txtTitulo.Text;
            usuario.agenda.NomeMedico = txtMedico.Text;
            usuario.agenda.Observacao = txtObservacao.Text;
            if(rdbAtivo.Checked)
            {
                usuario.agenda.Ativado = true;
            }
            else if(rdbDesativado.Checked)
            {
                usuario.agenda.Ativado = false;
            }
        }
        private void LimparCampos()
        {
            txtTitulo.Text = "Título";
            txtMedico.Text = "Nome do Medico";
            txtObservacao.Text = "Observações";
            dtpData.Value = DateTime.Today;
            dtpDataAgendaInicio.Value = new DateTime(2024, 1, 1);
            dtpDataAgendaFim.Value = DateTime.Today;
            rdbAtivo.Checked = true;
            rdbDesativado.Checked = false;
            usuario = new Usuario();
            txtTitulo.Focus();
        }
        private void ucAgenda_Load(object sender, EventArgs e)
        {
            CarregarGridAgenda();
            dtpDataAgendaFim.Value = DateTime.Today;
            dtpData.Value = DateTime.Today;
        }
        private void grdAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifica se o clique foi em uma célula válida (não cabeçalho ou fora do grid)
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    var selectedRow = grdAgenda.Rows[e.RowIndex];
                    var selectedCell = selectedRow.Cells[e.ColumnIndex];
                    var selectedColumn = grdAgenda.Columns[e.ColumnIndex].Name;

                    // Supondo que o ID está na primeira coluna (ajuste se necessário)
                    int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                    // Chama a função Consultar usando o ID recuperado
                    Usuario u = new Usuario();
                    u.agenda.Id = id;
                    u.agenda.Consultar();

                    // Agora preenche os controles do formulário com os dados retornados
                    if (selectedColumn == "Data")
                    {
                        dtpData.Value = u.agenda.DataHora.Date;
                    }
                    else if (selectedColumn == "Titulo")
                    {
                        txtTitulo.Text = u.agenda.Titulo.ToString();
                    }
                    if(u.agenda.Ativado == true)
                    {
                        rdbAtivo.Checked = true;
                    }
                    else
                    {
                        rdbDesativado.Checked = true;
                    }
                    txtMedico.Text = u.agenda.NomeMedico.ToString();
                    txtObservacao.Text = u.agenda.Observacao.ToString();
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
                string Erro = ValidarCampos();
                if (Erro != string.Empty)
                {
                    MessageBox.Show(Erro, "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PreencherClasse();
                usuario.agenda.Gravar();
                MessageBox.Show("Evento Gravado com Sucesso", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarGridAgenda();
                LimparCampos();
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
                Usuario u = new Usuario();
                u.agenda.DataInicio = dtpDataAgendaInicio.Value.Date;
                u.agenda.DataFim = dtpDataAgendaFim.Value.Date;
                if(rdbPesquisarAtivos.Checked)
                {
                    u.agenda.Ativado = true;
                }
                else if(rdbPesquisarDesativados.Checked)
                {
                    u.agenda.Ativado = false;
                }
                grdAgenda.DataSource = u.agenda.Consultar();
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
            Global.TextBoxEnter(txtObservacao, "Observações");
        }
        private void txtObservacao_Leave(object sender, EventArgs e)
        {
            Global.TextBoxLeave(txtObservacao, "Observações");
        }
    }
}