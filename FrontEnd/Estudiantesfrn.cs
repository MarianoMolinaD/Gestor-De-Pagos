using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class Estudiantesfrn : Form
    {
        public Estudiantesfrn()
        {
            InitializeComponent();
        }

        private void buscarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            Estudiantesfrm Estudiantes = new Estudiantesfrm();
            Estudiantes.MdiParent = this;
            Estudiantes.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            BuscarEstudiantefrm frmBuscarEstudiante = new BuscarEstudiantefrm();
            frmBuscarEstudiante.MdiParent = this;
            frmBuscarEstudiante.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
