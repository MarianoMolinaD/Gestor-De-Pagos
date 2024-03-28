using Backend2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class AgregarDocentefrm : Form
    {
        public AgregarDocentefrm()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarDocente_Click(object sender, EventArgs e)
        {
            Backend2.Docentes docentes = new Backend2.Docentes(
                tbCui.Text,
                tbNombres.Text,
                tbApellidos.Text,
                tbEmail.Text,
                tbTelefono.Text,
                tbDireccion.Text
                );

            string Conexion = @"Data Source=DESKTOP-NST5V41\SQLEXPRESS;Initial Catalog=GestorPagosDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(Conexion))
            {
                conn.Open();
                string sql = $"INSERT INTO Docentes VALUES ('{docentes.Cui}','{docentes.Nombres}','{docentes.Apellidos}','{docentes.Telefono}','{docentes.Email}','{docentes.Direccion}')";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Se a agregado el Docente correctamente");
                }
            }

        }
    }
}
