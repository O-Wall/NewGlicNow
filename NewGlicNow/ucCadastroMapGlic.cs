using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                MessageBox.Show("Erro -->" + ex.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherClasse()
        {
            if(cboPeriodo.SelectedIndex == 0)
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
        private void PreencherFormulario()
        {
            if (cboPeriodo.SelectedIndex == 0)
            {
                txtValores.Text = Convert.ToString(usuario.mapaGlic.PreCafe);
            }
            if (cboPeriodo.SelectedIndex == 1)
            {
                txtValores.Text = Convert.ToString(usuario.mapaGlic.PosCafe);
            }
            if (cboPeriodo.SelectedIndex == 2)
            {
                txtValores.Text = Convert.ToString(usuario.mapaGlic.PreAlmoco);
            }
            if (cboPeriodo.SelectedIndex == 3)
            {
                txtValores.Text = Convert.ToString(usuario.mapaGlic.PosAlmoco);
            }
            if (cboPeriodo.SelectedIndex == 4)
            {
                txtValores.Text = Convert.ToString(usuario.mapaGlic.PreJantar);
            }
            if (cboPeriodo.SelectedIndex == 5)
            {
                txtValores.Text = Convert.ToString(usuario.mapaGlic.PosJantar);
            }
            if (cboPeriodo.SelectedIndex == 6)
            {
                txtValores.Text = Convert.ToString(usuario.mapaGlic.BasalMatutino);
            }
            if (cboPeriodo.SelectedIndex == 7)
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
            if(cboPeriodo.SelectedIndex == -1)
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
                cboPeriodo.SelectedIndex = -1;
                CarregarGridGlic();
            }
            catch(Exception ex) 
            { 
                MessageBox.Show("Erro -->"+ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            usuario = new Usuario();
            usuario.mapaGlic.DataInicio = dtpDataInicio.Value;
            usuario.mapaGlic.DataFim = dtpDataFim.Value;
            CarregarGridGlic();
        }

        private void dgvMapaGlic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                usuario = new Usuario();
                txtValores.Text = dgvMapaGlic.SelectedCells[0].Value.ToString();
                usuario.mapaGlic.Id = Convert.ToInt32(dgvMapaGlic.Rows[dgvMapaGlic.SelectedCells[0].RowIndex].Cells[0].Value);
                cboPeriodo.SelectedIndex = dgvMapaGlic.SelectedCells[0].ColumnIndex-2;                
                usuario.mapaGlic.Consultar();
                txtObservacao.Text = usuario.mapaGlic.Observacao;
            }
            catch (Exception)
            {

                throw;
            }
            

            
        }
    }
    /* Tarefas
    //CRIAR VALIDAÇÃO DE PREENCHIMENTO
    //AJUSTAR TAMANHO DOS CARACTERES EM CADA TEXTBOX
    //REFAZER BANCO DE DADOS AO CLICAR NA COLUNA DESEJA, SEJA SELECIONADO O "PRECAFE" E O "VALOR" QUE ESTÁ DENTRO DELE, DE CADA DIA.
    //Estou achando que precisará usar consultar do banco como "inner join" "group by"
    //FAZER O GRID
    //FAZER O BOTÃO GRAVAR (INSERT)
    */
}
