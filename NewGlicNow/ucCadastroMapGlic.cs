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
                dgvMapaGlic.Columns[1].Visible = false;
                dgvMapaGlic.Columns[10].Visible = false;
                dgvMapaGlic.Columns[11].Visible = false;                
                //Definindo cabeçalhos
                dgvMapaGlic.Columns[2].HeaderText = "Pre  Café";
                dgvMapaGlic.Columns[3].HeaderText = "Pós Café";
                dgvMapaGlic.Columns[4].HeaderText = "Pre Almoço";
                dgvMapaGlic.Columns[5].HeaderText = "Pós Almoço";
                dgvMapaGlic.Columns[6].HeaderText = "Pre Jantar";
                dgvMapaGlic.Columns[7].HeaderText = "Pós Jantar";
                dgvMapaGlic.Columns[8].HeaderText = "Basal Matutina";
                dgvMapaGlic.Columns[9].HeaderText = "Basal Noturna";
                //Definindo largura das colunas
                dgvMapaGlic.Columns[2].Width = 73;
                dgvMapaGlic.Columns[3].Width = 73;
                dgvMapaGlic.Columns[4].Width = 73;
                dgvMapaGlic.Columns[5].Width = 73;
                dgvMapaGlic.Columns[6].Width = 73;
                dgvMapaGlic.Columns[7].Width = 73;
                dgvMapaGlic.Columns[8].Width = 90;
                dgvMapaGlic.Columns[9].Width = 91;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro -->" + ex.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucCadastroMapGlic_Load(object sender, EventArgs e)
        {
            CarregarGridGlic();           
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            usuario = new Usuario();
            usuario.mapaGlic.Data = dtpDataInicio.Value;
            CarregarGridGlic();
        }

        private void txtValores_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.SomenteNumeros(e.KeyChar, (sender as TextBox).Text);
        }

        private void ValidarPreenchimento()
        {
            string msgErro = string.Empty;
            if(cboPeriodo.SelectedIndex == -1)
            {
                msgErro = "Selecione um Período!";
                
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
