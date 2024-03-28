using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Backend2
{
    public class Reportes
    {
        public string PagosId { get; set; }
        public string carnet { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Fecha { get; set; }
        public string Mes { get; set; }
        public string Transaccion { get; set; }
        public decimal Monto { get; set; }

    }
}
