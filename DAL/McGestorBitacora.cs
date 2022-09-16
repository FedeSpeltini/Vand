using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class McGestorBitacora
    {
        private Acceso acceso = new Acceso();

        public List<EventoBitacora> LeerBitacora()
        {
            List<EventoBitacora> registro = new List<EventoBitacora>();

            Acceso.Abrir();
            DataTable tabla = Acceso.Leer("spLeerBitacora");
            Acceso.Cerrar();
            foreach (DataRow row in tabla.Rows)
            {
                EventoBitacora evento = new EventoBitacora();
                evento.idEvento = int.Parse(row["Id"].ToString());
                evento.actividad = row["Actividad"].ToString();
                evento.información = row["Descripcion"].ToString();
                evento.fecha = DateTime.Parse(row["Fecha"].ToString());
                evento.nombreUsuario = row["NombreUsuario"].ToString();
                registro.Add(evento);
            }
            return registro;
        }

        public void Grabar(string accion, string información, int idusuario)
        {
            Acceso.Abrir();
            List<IDbDataParameter> parameters = new List<IDbDataParameter>();

            //parameters.Add(Acceso.CrearParametro("@Id", id));
            parameters.Add(Acceso.CrearParametro("@actividad", accion));
            parameters.Add(Acceso.CrearParametro("@desc", información));
            parameters.Add(Acceso.CrearParametro("@fecha", DateTime.Now));
            parameters.Add(Acceso.CrearParametro("@idUsr", idusuario));

            Acceso.Escribir("spCrearCopia", parameters);
        }


    }
}
