using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Log : ILog
    {
        public IUsuario Usuario { get; set; }
        public DateTime FecIngreso { get; set; }
        public DateTime FecEgreso { get; set; }
    }
}
