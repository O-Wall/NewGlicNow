using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Transactions;

namespace NewGlicNow
{
    public class Agenda
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime DataHora { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string NomeMedico { get; set; }
        public string Observacao { get; set; }
        public bool Ativado { get; set; }
        public int UsuarioId { get; set; }


        public Agenda()
        {
            Id = 0;
            Titulo = string.Empty;
            DataHora = DateTime.Now;
            DataInicio = DateTime.Now;
            DataFim = DateTime.Now;
            NomeMedico = string.Empty;
            Observacao = string.Empty;
            Ativado = false;
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
                sql = "select Id, Titulo, DataHora, NomeMedico," +
                    " Observacao, Ativado, UsuarioId \n";
                sql += "from tblAgenda \n";
                if (Id != 0)
                {
                    sql += "where Id = @Id \n";
                    parameters.Add(new SqlParameter("@id", Id));
                }
                else
                {
                    sql += "WHERE UsuarioId = @usuarioId \n";
                    parameters.Add(new SqlParameter("@usuarioId", Global.IdUsuarioLogado));

                    if (DataInicio != DateTime.Now || DataFim != DateTime.Now)
                    {
                        sql += "AND Data BETWEEN cast(@dataInicio as date) AND cast(@dataFim as date) \n";
                        parameters.Add(new SqlParameter("@dataInicio", SqlDbType.DateTime) { Value = DataInicio });
                        parameters.Add(new SqlParameter("@dataFim", SqlDbType.DateTime) { Value = DataFim });
                    }
                    if(Ativado == true)
                    {
                        sql += "AND Ativado = 1 \n";
                        parameters.Add(new SqlParameter("@ativado", Ativado));
                    }
                    else
                    {
                        sql += "AND Ativado = 0 \n";
                        parameters.Add(new SqlParameter("@ativado", Ativado));
                    }
                }
                dt = acesso.Consultar(sql, parameters);
                if (dt.Rows.Count == 1)
                {
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                    Titulo = dt.Rows[0]["Titulo"].ToString();
                    DataHora = Convert.ToDateTime(dt.Rows[0]["DataHora"]);
                    NomeMedico = dt.Rows[0]["NomeMedico"].ToString();
                    Observacao = dt.Rows[0]["Observacao"].ToString();
                    Ativado = Convert.ToBoolean(dt.Rows[0]["Ativado"].ToString());
                    UsuarioId = Convert.ToInt32(dt.Rows[0]["UsuarioId"]);
                }
                return dt;
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
                using (TransactionScope transacao = new TransactionScope())
                {
                    parameters.Clear();
                    if (Id == 0)
                    {
                        sql = "insert into tblAgenda \n";
                        sql += "(Titulo, DataHora, NomeMedico, Observacao, Ativado, UsuarioId)\n";
                        sql += "values \n";
                        sql += "(@Titulo, @DataHora, @NomeMedico, @Observacao, @Ativado, @UsuarioId);\n";
                    }
                    else
                    {
                        sql = "update tblAgenda \n";
                        sql += "set \n";
                        sql += "Titulo = @Titulo, \n";
                        sql += "DataHora = @DataHora, \n";
                        sql += "NomeMedico = @NomeMedico, \n";
                        sql += "Observacao = @Observacao, \n";
                        sql += "Ativado = @Ativado, \n";
                        sql += "UsuarioId = @UsuarioId \n";
                        sql += "where Id = @id; \n";
                        parameters.Add(new SqlParameter("@id", Id));
                    }
                    parameters.Add(new SqlParameter("@Titulo", Titulo));
                    parameters.Add(new SqlParameter("@DataHora", DataHora));
                    parameters.Add(new SqlParameter("@NomeMedico", NomeMedico));
                    parameters.Add(new SqlParameter("@Observacao", Observacao));
                    parameters.Add(new SqlParameter("@Ativado", Ativado));
                    parameters.Add(new SqlParameter("@UsuarioId", Global.IdUsuarioLogado));

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
