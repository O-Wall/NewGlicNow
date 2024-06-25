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


    }
    Usuario usuario = new Usuario();

    //MÉTODOS

    /* Tarefas
     *
         //CRIAR VALIDAÇÃO DE PREENCHIMENTO

         //AJUSTAR TAMANHO DOS CARACTERES EM CADA TEXTBOX

         //REFAZER BANCO DE DADOS
                AO CLICAR NA COLUNA DESEJA, SEJA SELECIONADO O "PRECAFE" E O "VALOR" QUE ESTÁ DENTRO DELE, DE CADA DIA.
                     Estou achando que precisará usar consultar do banco como "inner join" "group by"
        
        //FAZER O GRID

        //FAZER O BOTÃO GRAVAR (INSERT)


    */


    /*
    //É aqui dentro (User Control) mesmo que cria?
    
    private void CarregarPeriodo()
    {
        try
        {
            cboPeriodo.DataSource = Global.ConsultarGlicemia();

            //Irei ter que criar uma coluna no banco onde precisarei adicionar todos esses nomes dentro? ou existe outro método?
            cboPeriodo.DisplayMember = "PreCafe";
            cboPeriodo.DisplayMember = "PosCafe";
            cboPeriodo.DisplayMember = "PreAlmoco";
            cboPeriodo.DisplayMember = "PosAlmoco";
            cboPeriodo.DisplayMember = "PreJantar";
            cboPeriodo.DisplayMember = "PosJantar";
            cboPeriodo.DisplayMember = "BasalMatutino";
            cboPeriodo.DisplayMember = "BasalNoturno";
            cboPeriodo.DisplayMember = "Carboidrato";
            cboPeriodo.DisplayMember = "Observacao";
            

            cboPeriodo.ValueMember = "Id";

            cboPeriodo.SelectedIndex = -1;

            
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro -->" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
       

    }
    //=============================

    */






}
