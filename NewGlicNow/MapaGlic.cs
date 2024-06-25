using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NewGlicNow
{
    public  class MapaGlic
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int PreCafe {  get; set; }
        public int PosCafe { get; set;}
        public int PreAlmoco { get; set; }
        public int PosAlmoco { get; set; }
        public int PreJantar { get; set; }
        public int PosJantar { get; set; }
        public int BasalMatutino { get; set; }
        public int BasalNoturno { get; set; }
        public string Observacao { get; set; }
        public int UsuarioId { get; set; }

        public MapaGlic()
        {
            Id = 0;
            Data = DateTime.MinValue;
            PreCafe = 0;
            PosCafe = 0;
            PreAlmoco = 0;
            PosAlmoco = 0;
            PreJantar = 0;
            PosJantar = 0;
            BasalMatutino = 0;
            BasalNoturno = 0;
            Observacao = string.Empty;
            UsuarioId = 0;
        }
        AcessoBanco acesso = new AcessoBanco();
        DataTable dt = new DataTable();
        List<SqlParameter> parameters = new List<SqlParameter>();
        string sql = string.Empty;
        public void Consultar()
        {
            try
            {
                parameters.Clear();
                if (Id != 0)
                {
                    sql = "select Data, PreCafe, PosCafe, PreAlmoco, PosAlmoco, PreJantar, PosJantar, BasalMatutino, BasalNoturno, Observacao, UsuarioId \n";
                    sql += "from tblGlicemia \n";
                    if (UsuarioId != 0)
                    {
                        sql += "where UsuarioId = @usuarioid \n";
                        parameters.Add(new SqlParameter("@usuarioid", UsuarioId));
                    }
                    else if (Data != DateTime.MinValue)
                    {
                        sql += "where Data = @data \n";
                        parameters.Add(new SqlParameter("@data", Data));
                    }
                    dt = acesso.Consultar(sql, parameters);
                    if (Id != 0)
                    {
                        Id = Convert.ToInt32(dt.Rows[0]["id"]);
                        Data = Convert.ToDateTime(dt.Rows[0]["data"]);
                        PreCafe = Convert.ToInt32(dt.Rows[0]["preCafe"]);
                        PosCafe = Convert.ToInt32(dt.Rows[0]["posCafe"]);
                        PreAlmoco = Convert.ToInt32(dt.Rows[0]["preAlmoco"]);
                        PosAlmoco = Convert.ToInt32(dt.Rows[0]["posAlmoco"]);
                        PreJantar = Convert.ToInt32(dt.Rows[0]["preJantar"]);
                        PosJantar = Convert.ToInt32(dt.Rows[0]["posJantar"]);
                        BasalMatutino = Convert.ToInt32(dt.Rows[0]["basalMatutino"]);
                        BasalNoturno = Convert.ToInt32(dt.Rows[0]["basalNoturno"]);
                        Observacao = dt.Rows[0]["observacao"].ToString();
                        UsuarioId = Convert.ToInt32(dt.Rows[0]["usuarioId"]);
                    }
                    return dt;
                }
            }
            catch (Exception ex)
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
                    sql += "(Data,PreCafe, PosCafe, PreAlmoco, PosAlmoco, PreJantar," +
                        " PosJantar, BasalMatutino, BasalNoturno, Observacao, UsuarioId) \n";
                    sql += "values \n\";
                    sql += "(@data, @preCafe, @posCafe, @preAlmoco, @posAlmoco," +
                        " @preJantar, @posJantar, @basalMatutino, @basalNoturno, @observacao, @usuarioId) \n";
                    sql += "select @@IDENTITY";
                }
                else
                {
                    sql = "update tblGlicemia \n";
                    sql += "set \n";
                    sql += "Data = @data, \n";
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
                parameters.Add(new SqlParameter("@data", Data));
                parameters.Add(new SqlParameter("@preCafe", PreCafe));
                parameters.Add(new SqlParameter("@posCafe", PosCafe));
                parameters.Add(new SqlParameter("@preAlmoco", PreAlmoco));
                parameters.Add(new SqlParameter("@posAlmoco", PosAlmoco));
                parameters.Add(new SqlParameter("@preJantar", PreJantar));
                parameters.Add(new SqlParameter("@basalMatutino", BasalMatutino));
                parameters.Add(new SqlParameter("@basalNoturno", BasalNoturno));
                parameters.Add(new SqlParameter("@observacao", Observacao));
                parameters.Add(new SqlParameter("@usuarioId", UsuarioId));

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
