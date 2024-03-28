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
    public partial class GestorDePagosfrm : Form
    {
        public GestorDePagosfrm()
        {
            InitializeComponent();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cerrarCesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GestorDePagosfrm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pagosfrm frmPagos = new Pagosfrm();
            //frmPagos.MdiParent = this;
            frmPagos.Show();    
        }

        private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Estudiantesfrn frmEstudiantes = new Estudiantesfrn();
            //frmPagos.MdiParent = this;
            frmEstudiantes.Show();
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            AgregarDocentefrm frmDocentes = new AgregarDocentefrm();
            frmDocentes.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportesfrm reportesfrm = new Reportesfrm();
            reportesfrm.Show();
        }

        private void opcionesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void opcionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loginfrm loginfrm = new Loginfrm(); 

            Backend2.Sesion sesion = new Backend2.Sesion();

   

            loginfrm.Show();
            this.Close();
        }
    }
}
