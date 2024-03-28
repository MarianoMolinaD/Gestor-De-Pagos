using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend2
{
    public class Pagos
    {
        public string Carnet {  get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Facultad {  get; set; }
        public string Jornada { get; set; }
        public string Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Transaccion {  get; set; }
        public string Mes {  get; set; }
        public string Recibo { get; set; }

        public Pagos(string carnet, string nombres, string apellidos, string fecha, decimal monto, string transaccion, string mes, string recibo)
        {
            Carnet = carnet;
            Nombres = nombres;
            Apellidos = apellidos;
            Fecha = fecha;
            Monto = monto;
            Transaccion = transaccion;
            Mes = mes;
            Recibo = recibo;
        }
    }
}
