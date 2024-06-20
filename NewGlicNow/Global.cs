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
    }
}
