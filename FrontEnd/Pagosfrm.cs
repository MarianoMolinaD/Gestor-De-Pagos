using Backend2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class Pagosfrm : Form
    {
        public Pagosfrm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            List<string> Resultado = new List<string>();

            Resultado = new ConexionData().Buscar(tbCarnet.Text, "Estudiantes");

            if (Resultado.Count > 0)
            {
                tbNombres.Text = Resultado[1];
                tbApellidos.Text = Resultado[2];
                tbFacultad.Text = Resultado[6];
                tbJornada.Text = Resultado[8];

            }
            else
            {
                MessageBox.Show("No se ha encontrado el alumno que busca");
            }
                                     

        }

        private void Pagosfrm_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string Aleatorio = rnd.Next(10000, 99999 + 1).ToString();
            tbRecibo.Text = Aleatorio;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string Aleatorio = rnd.Next(10000, 99999 + 1).ToString();
            tbRecibo.Text = Aleatorio;

                tbCarnet.Clear();
                tbNombres.Clear();
                tbApellidos.Clear();
                tbMonto.Clear();
                tbFacultad.Clear();
                tbJornada.Clear();
                cbTransaccion.Text = "";
                tbMes.Text = "";

            Close();
               

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Pagos pagos = new Pagos(
                tbCarnet.Text,
                tbNombres.Text,
                tbApellidos.Text,
                dtpFecha.Text,
                decimal.Parse(tbMonto.Text),
                cbTransaccion.Text,
                tbMes.Text,
                tbRecibo.Text
                );


            ConexionData conexionData = new ConexionData();

            bool resultado = conexionData.Agregar(pagos.Recibo, pagos.Carnet, pagos.Nombres, pagos.Apellidos, pagos.Fecha, pagos.Mes, pagos.Transaccion, pagos.Monto,"Pagos");
            
            if (resultado == true)
            {   

                MessageBox.Show("Se a realizado el pago con exito \n \n Recibo # " + pagos.Recibo + "\n Estudiante: " + pagos.Nombres + " " + pagos.Apellidos);
            }
            else
            {
                MessageBox.Show("Error al conectar la Base de Datos");
            }  

        }
    }
}
