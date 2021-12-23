using Abstractions;
using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class LogBusiness
    {
        public static void CreateLog(ILog log)
        {
            McLog.CreateLog(log);
        }

        public static List<ILog> GetLogs()
        {
            return McLog.GetLogs();
        }

        public static List<ILog> GetLog(IUsuario user)
        {
            return McLog.GetLog(user);
        }

        public static void PutFinishHour(IUsuario user, DateTime date)
        {
            

            var q = (from ILog l in GetLog(user)
                     where l.Usuario.Nombre == user.Nombre
                     orderby l.FecIngreso ascending
                     select l
            );

            Log log = (Log)q;

            log.FecEgreso = date;
            McLog.PutFinishHourLog(log);
        }
    }
}
