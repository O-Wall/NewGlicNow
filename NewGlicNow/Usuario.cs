using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGlicNow
{
    public class Usuario
    {
        public int Id {  get; set; }
        public string NomeCompleto { get; set; }
        public string CPF {  get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public byte[] FotoPerfil { get; set; }
        public string Celular {  get; set; }
        public int TipoDiabeteId { get; set; }
        public int SexoId { get; set; }
        public int LoginId {  get; set; }

        public Usuario()
        {
            Id = 0;
            NomeCompleto = string.Empty;
            CPF = string.Empty;
            DataNascimento = DateTime.MinValue;
            Email = string.Empty;
            FotoPerfil = null;
            Celular = string.Empty;
            TipoDiabeteId = 0;
            SexoId = 0;
            LoginId = 0;
        }

        AcessoBanco acesso = new AcessoBanco();
        DataTable dt = new DataTable(); 
        List<SqlParameter> parameters = new List<SqlParameter>();
        string sql = string.Empty;
        
        public DataTable Consultar()
        {
            try
            {
                parameters.Clear();
                sql = "select id, NomeCompleto, CPF, DataNascimento," +
                    " Email, FotoPerfil, Celular, TipoDiabetesId, SexoId, LoginId \n";
                sql += "from tblUsuario \n";
                if (Id != 0)
                {
                    sql += "where @id = Id \n";
                    parameters.Add(new SqlParameter("@id", Id));
                }
                else if (CPF != string.Empty)
                {
                    sql += "Where @cpf = CPF \n";
                    parameters.Add(new SqlParameter("@cpf", CPF));
                }
                else if (NomeCompleto != string.Empty)
                {
                    //sql += "Where @nomeCompleto = NomeCompleto \n";
                    parameters.Add(new SqlParameter("@nomeCompleto", NomeCompleto));
                }
                dt = acesso.Consultar(sql, parameters);
                if (Id != 0 || (CPF != string.Empty && dt.Rows.Count > 0))
                {
                    Id = Convert.ToInt32(dt.Rows[0]["id"]);
                    NomeCompleto = dt.Rows[0]["nome_completo"].ToString();
                    CPF = dt.Rows[0]["cpf"].ToString();
                    DataNascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                    Email = dt.Rows[0]["email"].ToString();
                    if (dt.Rows[0]["fotoPerfil"] != DBNull.Value) // Lembrar de semprer verificar isso
                    {
                        FotoPerfil = (byte[])dt.Rows[0]["fotoPerfil"];
                    }
                    Celular = dt.Rows[0]["celular"].ToString();
                    TipoDiabeteId = Convert.ToInt32(dt.Rows[0]["tipoDiabeteId"]);
                    SexoId = Convert.ToInt32(dt.Rows[0]["SexoId"]);
                    LoginId = Convert.ToInt32(dt.Rows[0]["loginId"]);
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
