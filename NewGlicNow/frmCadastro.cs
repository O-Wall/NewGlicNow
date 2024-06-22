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
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Deseja encerrar a aplicação?",
              "GlicNow", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2);
            if (DialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
        }
    }
}
