using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;
using System.Transactions;

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
            Data = DateTime.MinValue.Date;
            DataInicio = DateTime.MinValue.Date;
            DataFim = DateTime.Today.Date;
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
                sql = "Select Id, Data, PreCafe, PosCafe, PreAlmoco, PosAlmoco, \n";
                sql += "PreJantar, PosJantar, BasalMatutino, BasalNoturno, \n";
                sql += "Observacao, UsuarioId \n";
                sql += "from tblGlicemia \n";

                if (Id != 0)
                {
                    sql += "where @id = Id\n";
                    parameters.Add(new SqlParameter("@id", Id));                    
                }
                else if(Data != DateTime.MinValue.Date)
                {
                    sql += "where @data = Data \n";
                    parameters.Add(new SqlParameter("@data", Data));
                }
                else if( DataInicio != DateTime.MinValue.Date)
                {
                    sql += "where Data BETWEEN cast(@dataInicio as date) AND cast(@dataFim as date) \n";
                    parameters.Add(new SqlParameter("@dataInicio", SqlDbType.DateTime) { Value = DataInicio.Date });
                    parameters.Add(new SqlParameter("@dataFim", SqlDbType.DateTime) { Value = DataFim.Date });
                }
                dt = acesso.Consultar(sql, parameters);
                if (dt.Rows.Count > 0)
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
                using (TransactionScope transacao = new TransactionScope())
                {
                    parameters.Clear();
                    if(Id == 0)
                    {
                        sql = "Insert Into tblGlicemia \n";
                        sql += "(Data, PreCafe, PosCafe, \n";
                        sql += "PreAlmoco, PosAlmoco, \n";
                        sql += "PreJantar, PosJantar, \n";
                        sql += "BasalMatutino, BasalNoturno, \n";
                        sql += "Observacao, UsuarioId)\n";
                        sql += "Values \n";
                        sql += "(@data, @preCafe, @posCafe, \n";
                        sql += "@preAlmoco, @posAlmoco, \n";
                        sql += "@preJantar, @posJantar, \n";
                        sql += "@basalMatutino, @basalNoturno, \n";
                        sql += "@observacao, @usuarioId)\n";
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
                        sql += "where Data = @data; \n";                        
                    }
                    parameters.Add(new SqlParameter("@data", Data));
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
