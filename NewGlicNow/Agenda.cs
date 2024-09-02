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
            DataHora = DateTime.MinValue.Date;
            DataInicio = DateTime.MinValue.Date;
            DataFim = DateTime.Today.Date;
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
                sql = "select Id, DataHora, Titulo, \n";
                sql += "NomeMedico, Observacao, Ativado, UsuarioId \n";
                sql += "from tblAgenda \n";

                if(Id != 0)
                {
                    sql += "where @id = Id\n";
                    parameters.Add(new SqlParameter("@id", Id));
                }
                else if (DataInicio != DateTime.MinValue.Date)
                {
                    sql += "where DataHora BETWEEN cast(@dataInicio as date) AND cast(@dataFim as date) \n";
                    parameters.Add(new SqlParameter("@dataInicio", SqlDbType.DateTime) { Value = DataInicio.Date });
                    parameters.Add(new SqlParameter("@dataFim", SqlDbType.DateTime) { Value = DataFim.Date });
                    if (Ativado != false)
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
                if (dt.Rows.Count > 0)
                {
                    DataHora = Convert.ToDateTime(dt.Rows[0]["dataHora"]);
                    Titulo = Convert.ToString(dt.Rows[0]["titulo"]);
                    NomeMedico = Convert.ToString(dt.Rows[0]["nomeMedico"]);
                    Observacao = Convert.ToString(dt.Rows[0]["observacao"]);
                    Ativado = Convert.ToBoolean(dt.Rows[0]["ativado"]);
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
                    if (Id == 0)
                    {
                        sql = "Insert Into tblAgenda \n";
                        sql += "(DataHora, Titulo, \n";
                        sql += "NomeMedico, Observacao, \n";
                        sql += "Ativado, UsuarioId)\n";
                        sql += "Values \n";
                        sql += "(@dataHora, @titulo, \n";
                        sql += "@nomeMedico, @observacao, \n";
                        sql += "@ativado, @usuarioId)\n";
                    }
                    else
                    {
                        sql = "update tblAgenda \n";
                        sql += "set \n";
                        sql += "DataHora = @dataHora, \n";
                        sql += "Titulo = @titulo, \n";
                        sql += "NomeMedico = @nomeMedico, \n";
                        sql += "Observacao = @observacao, \n";
                        sql += "Ativado = @ativado, \n";
                        sql += "UsuarioId = @usuarioId \n";
                        sql += "where Id = @id; \n";
                        parameters.Add(new SqlParameter("@id", Id));
                    }
                    parameters.Add(new SqlParameter("@dataHora", DataHora));
                    parameters.Add(new SqlParameter("@titulo", Titulo));
                    parameters.Add(new SqlParameter("@nomeMedico", NomeMedico));
                    parameters.Add(new SqlParameter("@observacao", Observacao));
                    parameters.Add(new SqlParameter("@ativado", Ativado));
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
