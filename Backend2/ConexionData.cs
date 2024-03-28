using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Web;
using Backend2;
using System.Threading;

namespace Backend2
{
    public class ConexionData
    {
        

        public bool Agregar(string recibo, string carnet, string nombres, string apellidos, string fecha, string mes, string transaccion, decimal monto, string Tabla)
        {

            string Conexion = @"Data Source=DESKTOP-NST5V41\SQLEXPRESS;Initial Catalog=GestorPagosDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(Conexion))
            {
                try
                {
                    conn.Open();
                }
                catch
                {
                    return false;

                }

                string sql = $"INSERT INTO {Tabla} VALUES ('{recibo}','{carnet}','{nombres}'," +
                    $"'{apellidos}','{fecha}','{mes}','{transaccion}',{monto})";

                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;

                    comando.ExecuteNonQuery();
                    conn.Close();
                }

            }

            return true;

        }

        public List<string> Buscar(string carnet,string tabla)
        {
            string Conexion = @"Data Source=DESKTOP-NST5V41\SQLEXPRESS;Initial Catalog=GestorPagosDB;Integrated Security=True";

            List<string> Buscar = new List<string>();

            using (SqlConnection conn = new SqlConnection(Conexion))
            {
                try
                {
                    conn.Open();
                }
                catch
                {
                    return Buscar;
                }

                using (SqlCommand comando = new SqlCommand("SELECT * FROM "+tabla, conn))
                {
                    comando.CommandType = CommandType.Text;

                    DataTable dtEstudiantes = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dtEstudiantes.Load(reader);
                    }
                    if(tabla == "Estudiantes")
                    {
                        foreach (DataRow item in dtEstudiantes.Rows)
                        {
                            if (item["CarnetId"].ToString() == carnet)
                            {
                                Buscar.Add(item["cui"].ToString());
                                Buscar.Add(item["Nombres"].ToString());
                                Buscar.Add(item["Apellidos"].ToString());
                                Buscar.Add(item["Telefono"].ToString());
                                Buscar.Add(item["Email"].ToString());
                                Buscar.Add(item["Direccion"].ToString());
                                Buscar.Add(item["Facultad"].ToString());
                                Buscar.Add(item["Semestre"].ToString());
                                Buscar.Add(item["Jornada"].ToString());
                                Buscar.Add(item["Saldo"].ToString());
                                Buscar.Add(item["Docente"].ToString());

                            }
                            
                        }

                    }
                    else 
                    if(tabla == "Docentes")
                    {
                        foreach (DataRow item in dtEstudiantes.Rows)
                        {
                            Buscar.Add(item["Nombres"].ToString() + " " + item["Apellidos"].ToString());

                        }
                    }
                    else
                    {
                        Buscar.Add("Tabla no existe");
                    }
                    conn.Close();
                }

            }

            return Buscar;
        }

        public List<Reportes> BuscarReportes()
        {
            string Conexion = @"Data Source=DESKTOP-NST5V41\SQLEXPRESS;Initial Catalog=GestorPagosDB;Integrated Security=True";

            List<Reportes> Buscar = new List<Reportes>();

            using (SqlConnection conn = new SqlConnection(Conexion))
            {
                try
                {
                    conn.Open();
                }
                catch
                {
                    return Buscar;
                }

                using (SqlCommand comando = new SqlCommand("SELECT * FROM Pagos", conn))
                {
                    comando.CommandType = CommandType.Text;

                    DataTable dtEstudiantes = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dtEstudiantes.Load(reader);
                    }
                   
                        foreach (DataRow item in dtEstudiantes.Rows)
                        {

                        Buscar.Add(new Reportes
                        {
                            PagosId = item["PagosId"].ToString(),
                            carnet = item["carnet"].ToString(),
                            Nombres = item["Nombres"].ToString(),
                            Apellidos = item["Apellidos"].ToString(),
                            Fecha = item["Fecha"].ToString(),
                            Mes = item["Mes"].ToString(),
                            Transaccion = item["Transaccion"].ToString(),
                            Monto = Convert.ToInt32(item["Monto"])
                        }) ; 

                       }

 
                    conn.Close();
                }

            }

            return Buscar;


        }

        public List<Reportes> BuscarReportes(string fecha)
        {
            string Conexion = @"Data Source=DESKTOP-NST5V41\SQLEXPRESS;Initial Catalog=GestorPagosDB;Integrated Security=True";

            List<Reportes> Buscar = new List<Reportes>();

            using (SqlConnection conn = new SqlConnection(Conexion))
            {
                try
                {
                    conn.Open();
                }
                catch
                {
                    return Buscar;
                }

                using (SqlCommand comando = new SqlCommand("SELECT * FROM Pagos", conn))
                {
                    comando.CommandType = CommandType.Text;

                    DataTable dtEstudiantes = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dtEstudiantes.Load(reader);
                    }

                    foreach (DataRow item in dtEstudiantes.Rows)
                    {
                        if (fecha == item["Fecha"].ToString())
                        {
                            Buscar.Add(new Reportes
                            {
                                PagosId = item["PagosId"].ToString(),
                                carnet = item["carnet"].ToString(),
                                Nombres = item["Nombres"].ToString(),
                                Apellidos = item["Apellidos"].ToString(),
                                Fecha = item["Fecha"].ToString(),
                                Mes = item["Mes"].ToString(),
                                Transaccion = item["Transaccion"].ToString(),
                                Monto = Convert.ToInt32(item["Monto"])
                            });
                        }


                    }


                    conn.Close();
                }

            }

            return Buscar;


        }

        public List<Reportes> BuscarReportes(string carnet,string nada,string nada1)
        {
            string Conexion = @"Data Source=DESKTOP-NST5V41\SQLEXPRESS;Initial Catalog=GestorPagosDB;Integrated Security=True";

            List<Reportes> Buscar = new List<Reportes>();

            using (SqlConnection conn = new SqlConnection(Conexion))
            {
                try
                {
                    conn.Open();
                }
                catch
                {
                    return Buscar;
                }

                using (SqlCommand comando = new SqlCommand("SELECT * FROM Pagos", conn))
                {
                    comando.CommandType = CommandType.Text;

                    DataTable dtEstudiantes = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dtEstudiantes.Load(reader);
                    }

                    foreach (DataRow item in dtEstudiantes.Rows)
                    {
                        if (carnet == item["carnet"].ToString())
                        {
                            Buscar.Add(new Reportes
                            {
                                PagosId = item["PagosId"].ToString(),
                                carnet = item["carnet"].ToString(),
                                Nombres = item["Nombres"].ToString(),
                                Apellidos = item["Apellidos"].ToString(),
                                Fecha = item["Fecha"].ToString(),
                                Mes = item["Mes"].ToString(),
                                Transaccion = item["Transaccion"].ToString(),
                                Monto = Convert.ToInt32(item["Monto"])
                            });
                        }


                    }


                    conn.Close();
                }

            }

            return Buscar;


        }
        public List<Reportes> BuscarReportes(string fecha,string carnet)
        {
            string Conexion = @"Data Source=DESKTOP-NST5V41\SQLEXPRESS;Initial Catalog=GestorPagosDB;Integrated Security=True";

            List<Reportes> Buscar = new List<Reportes>();

            using (SqlConnection conn = new SqlConnection(Conexion))
            {
                try
                {
                    conn.Open();
                }
                catch
                {
                    return Buscar;
                }

                using (SqlCommand comando = new SqlCommand("SELECT * FROM Pagos", conn))
                {
                    comando.CommandType = CommandType.Text;

                    DataTable dtEstudiantes = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dtEstudiantes.Load(reader);
                    }

                    foreach (DataRow item in dtEstudiantes.Rows)
                    {
                        if (fecha == item["Fecha"].ToString() && carnet == item["carnet"].ToString()) {
                            Buscar.Add(new Reportes
                            {
                                PagosId = item["PagosId"].ToString(),
                                carnet = item["carnet"].ToString(),
                                Nombres = item["Nombres"].ToString(),
                                Apellidos = item["Apellidos"].ToString(),
                                Fecha = item["Fecha"].ToString(),
                                Mes = item["Mes"].ToString(),
                                Transaccion = item["Transaccion"].ToString(),
                                Monto = Convert.ToInt32(item["Monto"])
                                
                            });
                        }
                        

                    }


                    conn.Close();
                }

            }

            return Buscar;


        }

    }

    public class FuncionesGenerales
    {
        public string Aleatorio(int min, int max){

            Random rnd = new Random();
            string Aleatorio = rnd.Next(min, max + 1).ToString();

            return Aleatorio;
    
        }
    }

    public class Sesion
    {
        public List<string> IniciarSecion(string usuario, string clave)
        {
           
            string Conexion = @"Data Source=DESKTOP-NST5V41\SQLEXPRESS;Initial Catalog=GestorPagosDB;Integrated Security=True";

            
            List<string> listaPrueba = new List<string>();

            using (SqlConnection conn = new SqlConnection(Conexion))
            {
                try
                {
                    conn.Open();
                }
                catch
                {
                    //sesion.Add(new DatosCesion
                    //{
                    //    EstadoDeRespuesta = false,
                    //    Usuario = "No se Encontro la base de datos",
                    //    //Nombres = "",
                    //    //Apellidos = "",
                    //    //Privilegios = 0,
                    //    //Estado = false

                    //});
                    return listaPrueba;
                }

                using (SqlCommand comando = new SqlCommand("SELECT * FROM Usuarios", conn))
                {
                    comando.CommandType = CommandType.Text;

                    DataTable dtEstudiantes = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dtEstudiantes.Load(reader);
                    }

                    foreach (DataRow item in dtEstudiantes.Rows)
                    {

                        if (usuario == item["NombreUsuario"].ToString() && clave == item["Clave"].ToString())
                        {

                            listaPrueba.Add(item["UsuarioId"].ToString());
                            listaPrueba.Add(item["NombreUsuario"].ToString());
                            listaPrueba.Add(item["Clave"].ToString());
                            listaPrueba.Add(item["Nombres"].ToString());
                            listaPrueba.Add(item["Apellidos"].ToString());
                            listaPrueba.Add(item["Privilegio"].ToString());
                            listaPrueba.Add(item["Estado"].ToString());

                        }

                    }

                    if (listaPrueba.Count > 0)
                    {
                        string sqlModificar = @"UPDATE Usuarios " +
                            "SET Estado = " + 1 +
                            " Where UsuarioId = " + listaPrueba[0];

                        using (SqlCommand comandoM = new SqlCommand(sqlModificar, conn))
                        {
                            comandoM.CommandType = CommandType.Text;

                            comandoM.ExecuteNonQuery();

                        }
                    }


                    conn.Close();
                    return listaPrueba;
                }
              

            }
        }


    }

}

