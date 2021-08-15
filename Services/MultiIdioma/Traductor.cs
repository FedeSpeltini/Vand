using Abstractions;
using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class Traductor
    {
        //esta capa podria estar separada en BLL de  servicios y Repo de servicios



        public static IIdioma ObtenerIdiomaDefault()
        {
            return ObtenerIdiomas().Where(i => i.Default).FirstOrDefault();
        }

        public static IList<IIdioma> ObtenerIdiomas()
        {
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.InitialCatalog = "Vand";
            cs.DataSource = ".";
            cs.IntegratedSecurity = true;

            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = cs.ConnectionString;
            IDataReader reader = null;
            IList<IIdioma> _idiomas = new List<IIdioma>();
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sql;
                cmd.CommandText = "select * from idiomas";


                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    _idiomas.Add(
                     new IdiomaEntity()
                     {
                         Id= int.Parse(reader["id_idioma"].ToString()),
                         Nombre = reader["nombre"].ToString(),
                         Default= bool.Parse(reader["idioma_default"].ToString())
                       
                     });
                }
                return _idiomas;

            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (sql != null)
                    sql.Close();


            }
        }


    }
}
