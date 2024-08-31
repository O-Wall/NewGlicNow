using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGlicNow
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public int CidadeId { get; set; }
        public int UsuarioId { get; set; }

        public Endereco()
        {
            Id = 0;
            Logradouro = string.Empty;
            Numero = string.Empty;
            Complemento = string.Empty;
            Bairro = string.Empty;
            CEP = string.Empty;
            CidadeId = 0;
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
                sql = "select id, endereco, numero, complemento, \n";
                sql += "bairro, CEP, cidadeId, usuarioId \n";
                sql += "from tblEndereco \n";
                sql += "where UsuarioId = @usuarioId";
                parameters.Add(new SqlParameter("@usuarioId", UsuarioId));

                dt = acesso.Consultar(sql, parameters);

                if (dt.Rows.Count > 0)
                {
                    Id = Convert.ToInt32(dt.Rows[0]["id"]);
                    Logradouro = dt.Rows[0]["endereco"].ToString();
                    Numero = dt.Rows[0]["numero"].ToString();
                    Complemento = dt.Rows[0]["complemento"].ToString();
                    Bairro = dt.Rows[0]["bairro"].ToString();
                    CEP = dt.Rows[0]["cep"].ToString();
                    CidadeId = Convert.ToInt32(dt.Rows[0]["cidadeId"]);
                    UsuarioId = Convert.ToInt32(dt.Rows[0]["usuarioId"]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                /*MessageBox.Show("Erro -->" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            }
        }
        public void Gravar()
        {
            try
            {
                parameters.Clear();
                if (Id == 0)
                {
                    sql = "insert into tblEndereco \n";
                    sql += "(endereco, numero, complemento, bairro, \n";
                    sql += "CEP, cidadeId, usuarioId)";
                    sql += "values \n";
                    sql += "(@endereco, @numero, @complemento, @bairro, \n";
                    sql += "@CEP, @cidadeId, @usuarioId)";
                }
                else
                {
                    sql = "update tblEndereco \n";
                    sql += "set \n";
                    sql += "endereco      = @endereco, \n";
                    sql += "numero		  = @numero, \n";
                    sql += "complemento	  = @complemento, \n";
                    sql += "bairro		  = @bairro, \n";
                    sql += "CEP			  = @CEP, \n";
                    sql += "cidadeId	  = @cidadeId, \n";
                    sql += "usuarioId	  = @usuarioId \n";
                    sql += "where id = @id \n";
                    parameters.Add(new SqlParameter("@id", Id));
                }
                parameters.Add(new SqlParameter("@endereco", Logradouro));
                parameters.Add(new SqlParameter("@numero", Numero));
                parameters.Add(new SqlParameter("@complemento", Complemento));
                parameters.Add(new SqlParameter("@bairro", Bairro));
                parameters.Add(new SqlParameter("@CEP", CEP));
                parameters.Add(new SqlParameter("@cidadeId", CidadeId));
                parameters.Add(new SqlParameter("@usuarioId", UsuarioId));

                acesso.Executar(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
