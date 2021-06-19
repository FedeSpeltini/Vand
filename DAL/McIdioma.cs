using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class McIdioma
    {
        private Acceso acceso = new Acceso();


        //public List<HistorialEntity> Listar()
        //{
        //    List<HistorialEntity> tablaHistorial = new List<HistorialEntity>();

        //    acceso.Abrir();
        //    DataTable tabla = acceso.Leer("spObtenerHistorial");
        //    acceso.Cerrar();

        //    foreach (DataRow registro in tabla.Rows)
        //    {
        //        HistorialEntity historial = new HistorialEntity();
        //        historial.NombreJugador = registro["NombreJugador"].ToString();
        //        historial.Ganadas = int.Parse(registro["PartidasGanadas"].ToString());
        //        historial.Empatadas = int.Parse(registro["PartidasEmpatadas"].ToString());
        //        historial.Perdidas = int.Parse(registro["PartidasPerdidas"].ToString());
        //        historial.Jugadas = int.Parse(registro["PartidasJugadas"].ToString());
        //        historial.Puntos = int.Parse(registro["TotalPuntos"].ToString());

        //        tablaHistorial.Add(historial);
        //    }

        //    return tablaHistorial;
        //}





        //public  List<IdiomaEntity> ObtenerIdiomas()
        //{
        //    acceso.Abrir();
        //    List<IdiomaEntity> tablaIdioma = new List<IdiomaEntity>();
        //    acceso.Cerrar();
        //    foreach (DataRow registro in tabla.Rows)
        //    {
        //        IdiomaEntity historial = new IdiomaEntity();
        //        historial.NombreJugador = registro["NombreJugador"].ToString();
        //        historial.Ganadas = int.Parse(registro["PartidasGanadas"].ToString());
        //        historial.Empatadas = int.Parse(registro["PartidasEmpatadas"].ToString());
        //        historial.Perdidas = int.Parse(registro["PartidasPerdidas"].ToString());
        //        historial.Jugadas = int.Parse(registro["PartidasJugadas"].ToString());
        //        historial.Puntos = int.Parse(registro["TotalPuntos"].ToString());

        //        tablaHistorial.Add(historial);
        //    }

        //    return tablaIdioma;

        //}
    }
}
