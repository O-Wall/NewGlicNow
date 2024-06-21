﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGlicNow
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form login = new frmLogin();
            Application.Run(login);
            Form cadastro = new frmCadastro();
            if (login.Tag.ToString() == "Cadastro")
            {
                Application.Run(cadastro);
            }
            if (login.DialogResult == DialogResult.OK || cadastro.DialogResult == DialogResult.OK)
            {
                Application.Run(new frmPrincipal());
            }
        }
    }
}
