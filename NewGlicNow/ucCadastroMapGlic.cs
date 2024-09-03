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
        private void ucCadastroMapGlic_Load(object sender, EventArgs e)
        {
            CarregarGridGlic();
            cboPeriodo.SelectedIndex = -1;
            dtpData.Value = DateTime.Today;
            dtpDataFim.Value = DateTime.Today;
        }       
        private string ValidarCampos()
        {
            string msgErro = string.Empty;
            if(cboPeriodo.SelectedIndex == -1)
            {
                msgErro = "Selecione o Período; \n";
            }
            if(txtValores.Text == string.Empty)
            {
                msgErro += "Preencha o campo: Valor da Glicemia; \n";
            }
            if(dtpData.Value.Date == DateTime.MinValue)
            {
                msgErro += "Selecione a Data; \n";
            }
            return msgErro;            
        }
        private void LimaprCampos()
        {
            cboPeriodo.SelectedIndex = -1;
            txtValores.Clear();
            txtObservacao.Clear();
            dtpData.Value = DateTime.Today;
            dtpDataFim.Value = DateTime.Today;
            dtpDataInicio.Value = new DateTime(2024, 1, 1);
            ckbMatutino.Checked = false;
            ckbNoturno.Checked = false;
            usuario = new Usuario();
            txtValores.Focus();
        }
        private void PreencherClasse()
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
            if (ckbNoturno.Checked == true)
            {
                usuario.mapaGlic.BasalNoturno = true;
            }
            else
            {
                usuario.mapaGlic.BasalNoturno = false;
            }
            if (ckbMatutino.Checked == true)
            {
                usuario.mapaGlic.BasalMatutino = true;
            }
            else
            {
                usuario.mapaGlic.BasalMatutino = false;
            }
            usuario.mapaGlic.Observacao = txtObservacao.Text;
            usuario.mapaGlic.Data = dtpData.Value.Date;
        }
        private void dgvMapaGlic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                usuario = new Usuario();

                var selectedCell = dgvMapaGlic.SelectedCells[0];

                if (selectedCell is DataGridViewCheckBoxCell)
                {
                    MessageBox.Show("A célula selecionada é um checkbox.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (selectedCell.OwningColumn.Name == "Data")
                {
                    if (selectedCell.Value != null && DateTime.TryParse(selectedCell.Value.ToString(), out DateTime data))
                    {
                        dtpData.Value = data;
                    }
                    else
                    {
                        MessageBox.Show("O valor da célula não é uma data válida.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {                   
                    txtValores.Text = selectedCell.Value?.ToString();
                }
                usuario.mapaGlic.Id = Convert.ToInt32(dgvMapaGlic.Rows[selectedCell.RowIndex].Cells[0].Value);
                cboPeriodo.SelectedIndex = selectedCell.ColumnIndex - 2;
                usuario.mapaGlic.Consultar();
                txtObservacao.Text = usuario.mapaGlic.Observacao;
                dtpData.Value = usuario.mapaGlic.Data.Date;
                ckbNoturno.Checked = usuario.mapaGlic.BasalNoturno;
                ckbMatutino.Checked = usuario.mapaGlic.BasalMatutino;
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
                        // Cabeçalhos das colunas visíveis
                        for (int i = 0; i < dgvMapaGlic.Columns.Count; i++)
                        {
                            if (dgvMapaGlic.Columns[i].Visible)
                            {
                                sw.Write(dgvMapaGlic.Columns[i].HeaderText);
                                sw.Write(","); // Usar vírgula como delimitador
                            }
                        }
                        sw.WriteLine();

                        // Linhas de dados
                        foreach (DataGridViewRow row in dgvMapaGlic.Rows)
                        {
                            for (int j = 0; j < dgvMapaGlic.Columns.Count; j++)
                            {
                                if (dgvMapaGlic.Columns[j].Visible)
                                {
                                    // Checa se a célula é nula e escreve uma string vazia se for
                                    var cellValue = row.Cells[j].Value ?? "";

                                    if (dgvMapaGlic.Columns[j].ValueType == typeof(DateTime))
                                    {
                                        // Se for uma coluna de DateTime, formate como desejado
                                        sw.Write(Convert.ToDateTime(cellValue).ToString("dd/MM/yy"));
                                    }
                                    else
                                    {
                                        // Para outros tipos, apenas converte para string
                                        sw.Write(cellValue.ToString());
                                    }

                                    sw.Write(","); // Usar vírgula como delimitador
                                }
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
                usuario.mapaGlic.Data = dtpData.Value.Date;
                usuario.mapaGlic.Consultar();
                PreencherClasse();
                usuario.mapaGlic.Gravar();
                MessageBox.Show("Glicemia Gravada com Sucesso", "Mapa de Glicemia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarGridGlic();
                LimaprCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Gravar Glicemia: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.mapaGlic.DataInicio = dtpDataInicio.Value.Date;
            u.mapaGlic.DataFim = dtpDataFim.Value.Date;
            dgvMapaGlic.DataSource = u.mapaGlic.Consultar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.mapaGlic.ExcluirPorData(dtpData.Value.Date);
            CarregarGridGlic();
        }
    }

}
