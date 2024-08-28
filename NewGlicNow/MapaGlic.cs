using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;

namespace NewGlicNow
{
    public  class MapaGlic
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int PreCafe {  get; set; }
        public int PosCafe { get; set;}
        public int PreAlmoco { get; set; }
        public int PosAlmoco { get; set; }
        public int PreJantar { get; set; }
        public int PosJantar { get; set; }
        public bool BasalMatutino { get; set; }
        public bool BasalNoturno { get; set; }
        public string Observacao { get; set; }
        public int UsuarioId { get; set; }

        public MapaGlic()
        {
            Id = 0;
            Data = DateTime.Now;
            DataInicio = DateTime.Now;
            DataFim = DateTime.Now;
            PreCafe = 0;
            PosCafe = 0;
            PreAlmoco = 0;
            PosAlmoco = 0;
            PreJantar = 0;
            PosJantar = 0;
            BasalMatutino = false;
            BasalNoturno = false;
            Observacao = string.Empty;
            UsuarioId = 0;
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
                sql = "select Id, Data, PreCafe, PosCafe," +
                    " PreAlmoco, PosAlmoco, PreJantar, PosJantar, BasalMatutino, BasalNoturno," +
                    "Observacao, UsuarioId \n";
                sql += "from tblGlicemia \n";
                if (Id != 0)
                {
                    sql += "where Id = @Id \n";
                    parameters.Add(new SqlParameter("@Id", Id));
                }
                else
                {
                    sql += "WHERE UsuarioId = @usuarioId \n";
                    parameters.Add(new SqlParameter("@usuarioId", Global.IdUsuarioLogado));

                    if (DataInicio != DateTime.MinValue && DataFim != DateTime.MinValue)
                    {
                        sql += "AND Data BETWEEN cast(@dataInicio as date) AND cast(@dataFim as date) \n";
                        parameters.Add(new SqlParameter("@dataInicio", SqlDbType.DateTime) { Value = DataInicio });
                        parameters.Add(new SqlParameter("@dataFim", SqlDbType.DateTime) { Value = DataFim });
                    }
                }
                dt = acesso.Consultar(sql, parameters);
                if(dt.Rows.Count>0)
                {
                    Id = Convert.ToInt32(dt.Rows[0]["id"]);
                    Data = Convert.ToDateTime(dt.Rows[0]["data"]);
                    PreCafe = Convert.ToInt32(dt.Rows[0]["preCafe"]);
                    PosCafe = Convert.ToInt32(dt.Rows[0]["posCafe"]);
                    PreAlmoco = Convert.ToInt32(dt.Rows[0]["preAlmoco"]);
                    PosAlmoco = Convert.ToInt32(dt.Rows[0]["posAlmoco"]);
                    PreJantar = Convert.ToInt32(dt.Rows[0]["preJantar"]);
                    PosJantar = Convert.ToInt32(dt.Rows[0]["posJantar"]);
                    BasalMatutino = Convert.ToBoolean(dt.Rows[0]["basalMatutino"]);
                    BasalNoturno = Convert.ToBoolean(dt.Rows[0]["basalNoturno"]);
                    Observacao = Convert.ToString(dt.Rows[0]["observacao"]);
                    UsuarioId = Convert.ToInt32(dt.Rows[0]["usuarioId"]);
                }
                return dt;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
       
        public void Gravar()
        {
            try
            {
                parameters.Clear();
                if (Id == 0)
                {
                    sql = "insert into tblGlicemia \n";
                    sql += "(Data, PreCafe, PosCafe, PreAlmoco, PosAlmoco, PreJantar," +
                        " PosJantar, BasalMatutino, BasalNoturno, Observacao, UsuarioId) \n";
                    sql += "values \n";
                    sql += "(@data,@preCafe, @posCafe, @preAlmoco, @posAlmoco," +
                        " @preJantar, @posJantar, @basalMatutino, @basalNoturno, @observacao, @usuarioId) \n";
                    parameters.Add(new SqlParameter("@data", Data));
                }
                else
                {
                    sql = "update tblGlicemia \n";
                    sql += "set \n";
                    sql += "PreCafe = @preCafe, \n";
                    sql += "PosCafe = @posCafe, \n";
                    sql += "PreAlmoco = @preAlmoco, \n";
                    sql += "PosAlmoco = @posAlmoco, \n";
                    sql += "PreJantar = @preJantar, \n";
                    sql += "PosJantar = @posJantar, \n";
                    sql += "BasalMatutino = @basalMatutino, \n";
                    sql += "BasalNoturno = @basalNoturno, \n";
                    sql += "Observacao = @observacao, \n";
                    sql += "UsuarioId = @usuarioId \n";
                    sql += "where Id = @id; \n";
                    parameters.Add(new SqlParameter("@id", Id));
                }
                parameters.Add(new SqlParameter("@preCafe", PreCafe));
                parameters.Add(new SqlParameter("@posCafe", PosCafe));
                parameters.Add(new SqlParameter("@preAlmoco", PreAlmoco));
                parameters.Add(new SqlParameter("@posAlmoco", PosAlmoco));
                parameters.Add(new SqlParameter("@preJantar", PreJantar));
                parameters.Add(new SqlParameter("@posJantar", PosJantar));
                parameters.Add(new SqlParameter("@basalMatutino", BasalMatutino));
                parameters.Add(new SqlParameter("@basalNoturno", BasalNoturno));
                parameters.Add(new SqlParameter("@observacao", Observacao));
                parameters.Add(new SqlParameter("@usuarioId", Global.IdUsuarioLogado));

                if (Id == 0)
                {
                    Id = acesso.Executar(parameters, sql);
                }
                else
                {
                    acesso.Executar(sql, parameters);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
