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
    public partial class Reportesfrm : Form
    {
        public Reportesfrm()
        {
            InitializeComponent();
        }

        private void Reportesfrm_Load(object sender, EventArgs e)
        {
            //Ajustar Tamaño

            


            List<Reportes> Resultado = new List<Reportes>();

            Resultado = new Backend2.ConexionData().BuscarReportes();
         
            dgvReportes.DataSource = Resultado.ToList();

            dgvReportes.Columns["Fecha"].DisplayIndex = 0;
            //dgvReportes.AutoResizeColumn();
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Reportes> Resultado = new List<Reportes>();

            if (tbCarnet.Enabled == true)
            {
        
                Resultado = new ConexionData().BuscarReportes(tbCarnet.Text,"","");

                if (Resultado.Count == 0)
                {
                    MessageBox.Show("No se encontraron Resultados");
                }
            }
            else
            {
                Resultado = new ConexionData().BuscarReportes(dtpFecha.Text);

                if (Resultado.Count == 0)
                {
                    MessageBox.Show("No se encontraron Resultados");
                }
            }
            dgvReportes.DataSource = Resultado.ToList();


        }

        private void cbFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFecha.Checked == true) { 
                dtpFecha.Enabled = true; 
                tbCarnet.Enabled = false;
            }
            else { 
                dtpFecha.Enabled = false; 
                tbCarnet.Enabled = true;
            }
            
        }
    }
}
