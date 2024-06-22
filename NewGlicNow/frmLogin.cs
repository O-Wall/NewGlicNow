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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tag = "";
        }

        private void lblCasdatrese_Click(object sender, EventArgs e)
        {
            Tag = "Cadastro";
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
