using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGlicNow
{
    public partial class ucCadastroMapGlic : UserControl
    {
        public ucCadastroMapGlic()
        {
            InitializeComponent();
        }
        Usuario usuario = new Usuario();

        private void CarregarGridGlic()
        {
            try
            {
                dgvMapaGlic.DataSource = usuario.mapaGlic.Consultar();
                //Ocultando colunas
                dgvMapaGlic.Columns[0].Visible = false;
                dgvMapaGlic.Columns[10].Visible = false;
                dgvMapaGlic.Columns[11].Visible = false;
                //Definindo cabeçalhos
                dgvMapaGlic.Columns[1].HeaderText = "Data";
                dgvMapaGlic.Columns[2].HeaderText = "Pre  Café";
                dgvMapaGlic.Columns[3].HeaderText = "Pós Café";
                dgvMapaGlic.Columns[4].HeaderText = "Pre Almoço";
                dgvMapaGlic.Columns[5].HeaderText = "Pós Almoço";
                dgvMapaGlic.Columns[6].HeaderText = "Pre Jantar";
                dgvMapaGlic.Columns[7].HeaderText = "Pós Jantar";
                dgvMapaGlic.Columns[8].HeaderText = "Basal Matutina";
                dgvMapaGlic.Columns[9].HeaderText = "Basal Noturna";
                //Definindo largura das colunas
                dgvMapaGlic.Columns[1].Width = 90;
                dgvMapaGlic.Columns[2].Width = 65;
                dgvMapaGlic.Columns[3].Width = 65;
                dgvMapaGlic.Columns[4].Width = 65;
                dgvMapaGlic.Columns[5].Width = 65;
                dgvMapaGlic.Columns[6].Width = 65;
                dgvMapaGlic.Columns[7].Width = 65;
                dgvMapaGlic.Columns[8].Width = 90;
                dgvMapaGlic.Columns[9].Width = 90;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados da grade: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherClasse()
        {
            try
            {
                if (cboPeriodo.SelectedIndex == 0)
                {
                    usuario.mapaGlic.PreCafe = Convert.ToInt32(txtValores.Text);
                }
                else if (cboPeriodo.SelectedIndex == 1)
                {
                    usuario.mapaGlic.PosCafe = Convert.ToInt32(txtValores.Text);
                }
                else if (cboPeriodo.SelectedIndex == 2)
                {
                    usuario.mapaGlic.PreAlmoco = Convert.ToInt32(txtValores.Text);
                }
                else if (cboPeriodo.SelectedIndex == 3)
                {
                    usuario.mapaGlic.PosAlmoco = Convert.ToInt32(txtValores.Text);
                }
                else if (cboPeriodo.SelectedIndex == 4)
                {
                    usuario.mapaGlic.PreJantar = Convert.ToInt32(txtValores.Text);
                }
                else if (cboPeriodo.SelectedIndex == 5)
                {
                    usuario.mapaGlic.PosJantar = Convert.ToInt32(txtValores.Text);
                }
                else if (cboPeriodo.SelectedIndex == 6)
                {
                    usuario.mapaGlic.BasalMatutino = Convert.ToInt32(txtValores.Text);
                }
                else if (cboPeriodo.SelectedIndex == 7)
                {
                    usuario.mapaGlic.BasalNoturno = Convert.ToInt32(txtValores.Text);
                }
                usuario.mapaGlic.Observacao = txtObservacao.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao preencher dados da classe: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PreencherFormulario()
        {
            if (cboPeriodo.SelectedIndex == 0)
            {
                txtValores.Text = Convert.ToString(usuario.mapaGlic.PreCafe);
            }
            else if (cboPeriodo.SelectedIndex == 1)
            {
                txtValores.Text = Convert.ToString(usuario.mapaGlic.PosCafe);
            }
            else if (cboPeriodo.SelectedIndex == 2)
            {
                txtValores.Text = Convert.ToString(usuario.mapaGlic.PreAlmoco);
            }
            else if (cboPeriodo.SelectedIndex == 3)
            {
                txtValores.Text = Convert.ToString(usuario.mapaGlic.PosAlmoco);
            }
            else if (cboPeriodo.SelectedIndex == 4)
            {
                txtValores.Text = Convert.ToString(usuario.mapaGlic.PreJantar);
            }
            else if (cboPeriodo.SelectedIndex == 5)
            {
                txtValores.Text = Convert.ToString(usuario.mapaGlic.PosJantar);
            }
            else if (cboPeriodo.SelectedIndex == 6)
            {
                txtValores.Text = Convert.ToString(usuario.mapaGlic.BasalMatutino);
            }
            else if (cboPeriodo.SelectedIndex == 7)
            {
                txtValores.Text = Convert.ToString(usuario.mapaGlic.BasalNoturno);
            }
            txtObservacao.Text = usuario.mapaGlic.Observacao;
        }
        private void ucCadastroMapGlic_Load(object sender, EventArgs e)
        {
            CarregarGridGlic();
        }
        private void txtValores_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.SomenteNumeros(e.KeyChar, (sender as TextBox).Text);
        }
        private string ValidarPreenchimento()
        {
            string msgErro = string.Empty;
            if (cboPeriodo.SelectedIndex == -1)
            {
                msgErro = "Selecione um Período!";
            }
            if (txtValores.Text == string.Empty)
            {
                msgErro += "Preencha o campo Valores!";
            }
            return msgErro;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                string msgERRO = ValidarPreenchimento();

                if (msgERRO != string.Empty)
                {
                    MessageBox.Show(msgERRO, "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PreencherClasse();
                usuario.mapaGlic.Gravar();
                MessageBox.Show("Glicemia Gravada com Sucesso!",
                    "Mapa de Glicemia",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValores.Clear();
                txtObservacao.Clear();
                cboPeriodo.SelectedIndex = 0;
                CarregarGridGlic();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar dados: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                usuario = new Usuario();
                usuario.mapaGlic.DataInicio = dtpDataInicio.Value;
                usuario.mapaGlic.DataFim = dtpDataFim.Value;
                CarregarGridGlic();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar dados: " + ex.Message, "Erro",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvMapaGlic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                usuario = new Usuario();
                txtValores.Text = dgvMapaGlic.SelectedCells[0].Value.ToString();
                usuario.mapaGlic.Id = Convert.ToInt32(dgvMapaGlic.Rows[dgvMapaGlic.SelectedCells[0].RowIndex].Cells[0].Value);
                cboPeriodo.SelectedIndex = dgvMapaGlic.SelectedCells[0].ColumnIndex - 2;
                usuario.mapaGlic.Consultar();
                txtObservacao.Text = usuario.mapaGlic.Observacao;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a Glicemia: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            try
            {
                // Abre o diálogo para salvar o arquivo CSV
                SaveFileDialog saveFileDialog1 = new SaveFileDialog
                {
                    Filter = "Arquivo CSV (*.csv)|*.csv",
                    Title = "Salvar arquivo CSV"
                };
                saveFileDialog1.ShowDialog();

                // Se o nome do arquivo não for vazio, exporta os dados
                if (!string.IsNullOrEmpty(saveFileDialog1.FileName))
                {
                    // Cria um StreamWriter para escrever no arquivo CSV
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8))
                    {
                        // Cabeçalhos das colunas
                        for (int i = 0; i < dgvMapaGlic.Columns.Count; i++)
                        {
                            sw.Write(dgvMapaGlic.Columns[i].HeaderText);
                            if (i < dgvMapaGlic.Columns.Count - 1)
                                sw.Write(","); // Usar vírgula como delimitador
                        }
                        sw.WriteLine();

                        // Linhas de dados
                        foreach (DataGridViewRow row in dgvMapaGlic.Rows)
                        {
                            for (int j = 0; j < dgvMapaGlic.Columns.Count; j++)
                            {
                                // Checa se a célula é nula e escreve uma string vazia se for
                                var cellValue = row.Cells[j].Value ?? "";

                                if (dgvMapaGlic.Columns[j].ValueType == typeof(DateTime))
                                {
                                    // Se for uma coluna de DateTime, formate como desejado
                                    sw.Write(Convert.ToDateTime(cellValue).ToString("yyyy-MM-dd"));
                                }
                                else
                                {
                                    // Para outros tipos, apenas converte para string
                                    sw.Write(cellValue.ToString());
                                }

                                if (j < dgvMapaGlic.Columns.Count - 1)
                                    sw.Write(","); // Usar vírgula como delimitador
                            }
                            sw.WriteLine();
                        }

                        // Mensagem de sucesso
                        MessageBox.Show("Dados exportados para CSV com sucesso!", "Exportação",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar para CSV: " + ex.Message, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
