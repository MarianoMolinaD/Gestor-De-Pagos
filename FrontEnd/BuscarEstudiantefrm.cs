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
    public partial class BuscarEstudiantefrm : Form
    {
        public BuscarEstudiantefrm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            ConexionData conexionData = new ConexionData();

            List<string> Resultado = new List<string>();

            Resultado = conexionData.Buscar(tbCarnet.Text,"Estudiantes");

            if(Resultado.Count > 0)
            {
                tbCui.Text = Resultado[0];
                tbNombres.Text = Resultado[1];
                tbApellidos.Text = Resultado[2];
                tbTelefono.Text = Resultado[3];
                tbEmail.Text = Resultado[4];
                tbDireccion.Text = Resultado[5];
                tbFacultad.Text = Resultado[6];
                cbSemestre.Text = Resultado[7];
                tbJornada.Text = Resultado[8];
                tbSaldo.Text = Resultado[9];
                tbDocente.Text = Resultado[10];
            }
            else
            {
                MessageBox.Show("No se ha encontrado el alumno que busca");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
