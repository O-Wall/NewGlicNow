using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NewGlicNow
{
    public static class Global
    {
        public static string Conexao = string.Empty;
        public static string Servidor = string.Empty;
        public static string Banco = string.Empty;
        public static int IdUsuarioLogado = 0;
        public static string UltimoIdLogado = "0";
        public static string ResetMsg = string.Empty;

        public static string Criptografar(string senha)
        {
            Byte[] original;
            Byte[] criptografado;
            MD5 md5 = new MD5CryptoServiceProvider();
            original = ASCIIEncoding.Default.GetBytes(senha);
            criptografado = md5.ComputeHash(original);

            return Regex.Replace(BitConverter.ToString(criptografado), "-", "").ToLower();
        }

        public static void LerAppConfig()
        {
            Servidor = ConfigurationManager.AppSettings.Get("servidor");
            Banco = ConfigurationManager.AppSettings.Get("banco");
            UltimoIdLogado = ConfigurationManager.AppSettings.Get("UltimoIdLogado");

            Conexao = $"Data Source={Servidor};Initial Catalog={Banco};Integrated Security=true;";
        }

        public static bool SomenteNumeros(char tecla, string texto)
        {
            if ((!char.IsDigit(tecla) && tecla != (char)Keys.Back))
            {
                return true;
            }
            return false;
        }

        public static void LimparTexto(TextBox txt)
        {
            ResetMsg = txt.Text;
            txt.Clear();
        }
        public static void ResetMensagem(TextBox txt)
        {
            if (txt.Text == string.Empty)
            {
                txt.Text = Global.ResetMsg;
                Global.ResetMsg = string.Empty;
            }
        }

        /* LIMPAR O TEXTO BOX EM TODOS OS LUGARES:
       Criar um método no qual quando eu clico em qualquer textbox, ele faz a mesma coisa.
           Ficar esperto em relação aos plugins;
           Fazer outro somente para senhas (Login, Cadastro e Configurações) 
       */

        public static DataTable ConsultarEstados()
        {
            try
            {
                string sql = "select id, estado from tblEstado \n";
                return new AcessoBanco().Consultar(sql, new List<SqlParameter>());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ConsultarCidades(int estadoId)
        {
            try
            {
                string sql = "select id, cidade from tblCidade \n";
                sql += "where estadoId = @estadoId";
                DataTable dt = new DataTable();
                AcessoBanco acesso = new AcessoBanco();
                List<SqlParameter> lista = new List<SqlParameter>();
                lista.Add(new SqlParameter("@estadoId", estadoId));
                dt = acesso.Consultar(sql, lista);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable ConsultarSexo()
        {
            try
            {
                string sql = "select id, descricao from tblSexo \n";
                return new AcessoBanco().Consultar(sql, new List<SqlParameter>());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable ConsultarTipoDiabete()
        {
            try
            {
                string sql = "select id, descricao from tblTipoDiabete \n";
                return new AcessoBanco().Consultar(sql, new List<SqlParameter>());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
