﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class ComisionBusiness
    {
        ComisionEntity comision = new ComisionEntity();

        McComision mc = new McComision();
        public decimal AplicarComision(CopiaEntity copia, VentaEntity venta)
        {

            comision.Venta = venta;
            comision.Ganancia = copia.Precio.Cantidad * comision.Porcentaje;

            copia.Precio.Cantidad -= copia.Precio.Cantidad * comision.Porcentaje;

            mc.Agregar(comision);

            return copia.Precio.Cantidad;

        }
    }
}
