using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class McBackupRestore
    {

        SqlConnection cn = Acceso.ObtenerConexionSql();
        SqlCommand cmd = new SqlCommand();

        public void impactarBD(string s)
        {
            try
            {
                cmd.Connection = cn;
                cmd.CommandText = s;
                cmd.CommandType = CommandType.Text;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

        }

    }
}
