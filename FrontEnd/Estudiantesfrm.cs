using Backend2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class Estudiantesfrm : Form
    {

        public Estudiantesfrm()
        {
            InitializeComponent();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Estudiantesfrm_Load(object sender, EventArgs e)
        {

            tbCarnet.Text = new FuncionesGenerales().Aleatorio(100000,999999);

            ConexionData conexionData = new ConexionData();

            List<string> Resultado = new List<string>();

            Resultado = conexionData.Buscar("", "Docentes");

            foreach (string resultado in Resultado)
            {
                cbDocente.Items.Add(resultado); 
            }
          

        }

        private void btnGuardarEstudiante_Click(object sender, EventArgs e)
        {
            Backend2.Estudiantes estudiantes = new Backend2.Estudiantes(
                tbCui.Text,
                tbNombres.Text,
                tbApellidos.Text,
                tbDireccion.Text,
                tbCarnet.Text,
                tbFacultad.Text,
                cbSemestre.Text,
                tbJornada.Text,
                tbTelefono.Text,
                tbEmail.Text,
                decimal.Parse(tbPagoAnual.Text),
                cbDocente.Text
                );

            

            string Conexion = @"Data Source=DESKTOP-NST5V41\SQLEXPRESS;Initial Catalog=GestorPagosDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(Conexion))
            {
                conn.Open();

                string sql = $"INSERT INTO Estudiantes VALUES ('{estudiantes.Carnet}','{estudiantes.Cui}','{estudiantes.Nombres}','{estudiantes.Apellidos}','{estudiantes.Telefono}','{estudiantes.Email}','{estudiantes.Direccion}','{estudiantes.Facultad}','{estudiantes.Semestre}','{estudiantes.Jornada}',{estudiantes.Saldo},'{estudiantes.Docente}')";
                

                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;

                    comando.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Estudiante "+ estudiantes.Nombres + " "+estudiantes.Apellidos + " con carnet " + estudiantes.Carnet+ " guardado exitosamente");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbCui.Clear();
            tbNombres.Clear();
            tbApellidos.Clear();
            tbDireccion.Clear();
            tbFacultad.Text = "";
            cbSemestre.Text = "";
            tbJornada.Text = "";
            tbTelefono.Text = "";
            tbEmail.Text = "";
            tbPagoAnual.Text = "";
            cbDocente.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
