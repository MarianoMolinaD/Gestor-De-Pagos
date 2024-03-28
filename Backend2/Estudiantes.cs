using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend2
{
    public class Estudiantes : Personas
    {
        public string Carnet {  get; set; }
        public string Facultad {  get; set; }
        public string Semestre { get; set; }
        public string Jornada { get; set; }
        public decimal Saldo { get; set; }
        public string Docente { get; set; }

        public Estudiantes(string cui, string nombres, string apellidos, string direccion,string carnet, string faculatad, string semestre, string jornada, 
            string telefono, string email, decimal saldo, string docente)
        {
            Cui = cui;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Carnet = carnet;
            Facultad = faculatad;
            Semestre = semestre;
            Jornada = jornada;
            Telefono = telefono;
            Email = email;
            Saldo = saldo;
            Docente = docente;

        }
    }

}
