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
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;

namespace NewGlicNow
{
    public static class Global
    {
        public static string Conexao = string.Empty;
        public static string Servidor = string.Empty;
        public static string Banco = string.Empty;
        public static int IdUsuarioLogado = 0;
        public static string UltimoIdLogado = "0";

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
        public static Image BytesToImage(byte[] bytes)
        {
            try
            {
                MemoryStream oMemoryStream = new MemoryStream(bytes);
                return Image.FromStream(oMemoryStream);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static byte[] ImageToBytes(PictureBox picture)
        {
            try
            {
                byte[] bytes;
                MemoryStream oMemoryStream = new MemoryStream();
                picture.Image.Save(oMemoryStream, ImageFormat.Jpeg);
                bytes = new byte[oMemoryStream.Length];
                oMemoryStream.Position = 0;
                oMemoryStream.Read(bytes, 0, bytes.Length);
                return bytes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void TextBoxEnter(TextBox txt, string texto)
        {            
            if (txt.Text == texto)
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
            }
        }
        public static void TextBoxLeave(TextBox txt, string texto)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = texto;
                txt.ForeColor = Color.Gray;
            }
        }
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
        public static int ConsultarEstado(int cidadeId)
        {
            try
            {
                int estado = 0;
                string sql = "select EstadoId from tblCidade \n";
                sql += "where Id = @Id";
                DataTable dt = new DataTable();
                AcessoBanco acesso = new AcessoBanco();
                List<SqlParameter> lista = new List<SqlParameter>();
                lista.Add(new SqlParameter("@Id", cidadeId));
                dt = acesso.Consultar(sql, lista);
                if (dt.Rows.Count > 0)
                {
                    estado = Convert.ToInt32(dt.Rows[0]["EstadoId"]);
                }
                return estado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                /*MessageBox.Show("Erro -->" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;*/
            }
        }
    }
}
