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
    public class Log_in
    {
        public int Id { get; set; }
        public string Login {  get; set; }
        public string Password { get; set; }
        public bool Salvo {  get; set; }
        public int UsuarioId { get; set; }        

        public Log_in() 
        {
            Id = 0;
            Login = string.Empty;
            Password = string.Empty;
            Salvo = false;
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
                sql = "select Id, Login, Password, Salvo, UsuarioId\n";
                sql += "from tblLogin \n";
                if (UsuarioId != 0)
                {
                    sql += "where UsuarioId = @usuarioid \n";
                    parameters.Add(new SqlParameter("@usuarioid", UsuarioId));
                }
                else if (Login != string.Empty)
                {
                    sql += "where Login = @login \n";
                    parameters.Add(new SqlParameter("@login", Login));
                }
                dt = acesso.Consultar(sql, parameters);
                if (UsuarioId != 0 || (Login != string.Empty && dt.Rows.Count > 0))
                {
                    Id = Convert.ToInt32(dt.Rows[0]["id"]);
                    Login = dt.Rows[0]["login"].ToString();                    
                    Password = dt.Rows[0]["password"].ToString();
                    Salvo = Convert.ToBoolean(dt.Rows[0]["salvo"]);
                    UsuarioId = Convert.ToInt32(dt.Rows[0]["usuarioId"]);
                }                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                /*MessageBox.Show("Erro -->" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                
            }
        }

        public bool Autenticar(string senha)
        {
            return senha == Password;
        }

        public void Gravar()
        {
            try
            {
                parameters.Clear();
                if (Id == 0)
                {
                    sql = "insert into tblLogin \n";
                    sql += "(Login, Password, Salvo, UsuarioId)\n";
                    sql += "values \n";
                    sql += "(@login, @password, @salvo, @usuarioId)";
                }
                else
                {
                    sql = "update tblLogin\n";
                    sql += "set \n";
                    sql += "Login     = @login, \n";                    
                    sql += "Password  = @password, \n";
                    sql += "Salvo = @salvo, \n";
                    sql += "UsuarioId = @usuarioId \n";
                    sql += "where id  = @id \n";
                    parameters.Add(new SqlParameter("@id", Id));
                }
                parameters.Add(new SqlParameter("@login", Login));                
                parameters.Add(new SqlParameter("@password", Password));
                parameters.Add(new SqlParameter("@salvo", Salvo));
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
