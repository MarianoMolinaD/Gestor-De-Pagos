using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend2
{
    public class DatosCesion
    {
        public int UsuarioId { get; set; }
        public string Usuario {  get; set; }
        public string Clave { get; set; }
        public string Nombres {  get; set; }
        public string Apellidos { get; set; }
        public int Privilegios {  get; set; }
        public bool EstadoDeRespuesta { get; set; }
    }


}
