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
    public partial class Docentesfrm : Form
    {
        public Docentesfrm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnBuscarDocente_Click(object sender, EventArgs e)
        {
            BuscarDocentefrm buscarDocentefrm = new BuscarDocentefrm();
            buscarDocentefrm.MdiParent = this;
            buscarDocentefrm.Show();
        }

        private void btnAgregarDocente_Click(object sender, EventArgs e)
        {
            AgregarDocentefrm agregarDocentefrm = new AgregarDocentefrm();
            agregarDocentefrm.MdiParent = this;
            agregarDocentefrm.Show();  
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
