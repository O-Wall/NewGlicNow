using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

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
        public Log_in log_In { get; set; }
        public Endereco endereco { get; set; }
        public MapaGlic mapaGlic { get; set; }
        public Agenda agenda {  get; set; }
        

        public Usuario()
        {
            Id = 0;
            NomeCompleto = string.Empty;
            CPF = string.Empty;
            DataNascimento = DateTime.Now;
            Email = string.Empty;
            FotoPerfil = null;
            Celular = string.Empty;
            TipoDiabeteId = 0;
            SexoId = 0;
            log_In = new Log_in();
            endereco = new Endereco();
            mapaGlic = new MapaGlic();
            agenda = new Agenda();
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
                sql = "select Id, NomeCompleto, CPF, DataNascimento," +
                    " Email, Celular, FotoPerfil, TipoDiabeteId, SexoId \n";
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
                    sql += "Where @nomeCompleto = NomeCompleto \n";
                    parameters.Add(new SqlParameter("@nomeCompleto", '%' + NomeCompleto + '%'));
                }
                dt = acesso.Consultar(sql, parameters);
                if (Id != 0 || (CPF != string.Empty && dt.Rows.Count > 0))
                {
                    Id = Convert.ToInt32(dt.Rows[0]["id"]);
                    NomeCompleto = dt.Rows[0]["nomeCompleto"].ToString();
                    CPF = dt.Rows[0]["cpf"].ToString();
                    DataNascimento = Convert.ToDateTime(dt.Rows[0]["dataNascimento"]);
                    Email = dt.Rows[0]["email"].ToString();
                    if (dt.Rows[0]["fotoPerfil"] != DBNull.Value)
                    {
                        FotoPerfil = (byte[])dt.Rows[0]["fotoPerfil"];
                    }
                    Celular = dt.Rows[0]["celular"].ToString();
                    TipoDiabeteId = Convert.ToInt32(dt.Rows[0]["tipoDiabeteId"]);
                    SexoId = Convert.ToInt32(dt.Rows[0]["SexoId"]);
                }
                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro -->" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

                /*throw new Exception(ex.Message);*/
            }
        }


        public void Gravar()
        {
            try
            {
                using (TransactionScope transacao = new TransactionScope())
                {
                    parameters.Clear();
                    if (Id == 0)
                    {
                        sql = "insert into tblUsuario \n";
                        sql += "(NomeCompleto, CPF, DataNascimento, Email, Celular, FotoPerfil, TipoDiabeteId, SexoId)\n";
                        sql += "values \n";
                        sql += "(@nomeCompleto, @cpf, @dataNascimento, @email, @celular, @fotoPerfil, @tipoDiabeteId, @sexoId);\n";
                        sql += "select @@IDENTITY";
                    }
                    else
                    {
                        sql = "update tblUsuario \n";
                        sql += "set \n";
                        sql += "NomeCompleto = @nomeCompleto, \n";
                        sql += "CPF = @cpf, \n";
                        sql += "DataNascimento = @dataNascimento, \n";
                        sql += "Email = @email, \n";
                        sql += "FotoPerfil = @fotoPerfil, \n";
                        sql += "Celular = @Celular, \n";
                        sql += "TipoDiabeteId = @tipoDiabeteId, \n";
                        sql += "SexoId = @sexoId \n";
                        sql += "where Id = @id; \n";
                        parameters.Add(new SqlParameter("@id", Id));
                    }
                    parameters.Add(new SqlParameter("@nomeCompleto", NomeCompleto));
                    parameters.Add(new SqlParameter("@cpf", CPF));
                    parameters.Add(new SqlParameter("@dataNascimento", DataNascimento));
                    parameters.Add(new SqlParameter("@email", Email));
                    parameters.Add(new SqlParameter("@fotoPerfil", FotoPerfil));
                    parameters.Add(new SqlParameter("@celular", Celular));
                    parameters.Add(new SqlParameter("@tipoDiabeteId", TipoDiabeteId));
                    parameters.Add(new SqlParameter("@sexoId", SexoId));

                    if (Id == 0)
                    {
                        Id = acesso.Executar(parameters, sql);
                    }
                    else
                    {
                        acesso.Executar(sql, parameters);
                    }
                    log_In.UsuarioId = Id;
                    log_In.Gravar();
                    endereco.UsuarioId = Id;
                    endereco.Gravar();
                    transacao.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
