using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend2
{
    public class Docentes : Personas
    {
        public Docentes(string cui, string nombres, string apellidos, string email,string telefono, string direccion) 
        { 
            Cui = cui;
            Nombres = nombres;
            Apellidos = apellidos;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;        
        }

    }
}
