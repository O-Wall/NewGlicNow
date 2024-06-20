using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGlicNow
{
    public class AcessoBanco
    {
        SqlConnection conn;

        private void Conectar()
        {
            try
            {
                conn = new SqlConnection(Global.Conexao);
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void Desconectar()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable Consultar(string sqlCommand, List<SqlParameter> lista)
        {
            try
            {
                Conectar();
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                foreach (SqlParameter p in lista)
                {
                    command.Parameters.Add(p);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally 
            { 
                Desconectar();
            }
        }
        public void Executar(string sqlCommand, List<SqlParameter> lista)
        {
            try
            {
                Conectar();
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                foreach (SqlParameter p in lista)
                {
                    command.Parameters.Add(p);
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { Desconectar(); }
        }
        public int Executar(List<SqlParameter> lista, string sqlCommand)
        {
            try
            {
                Conectar();
                SqlCommand command = new SqlCommand(sqlCommand, conn);
                foreach (SqlParameter p in lista)
                {
                    command.Parameters.Add(p);
                }
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
