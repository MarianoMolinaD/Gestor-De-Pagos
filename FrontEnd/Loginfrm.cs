using Backend2;
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
    public partial class Loginfrm : Form
    {
        public Loginfrm()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
          

   
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Sesion sesion = new Sesion();

            List<string> datosCesions = new List<string>();

            datosCesions = sesion.IniciarSecion(tbUsuario.Text, tbClave.Text);

            if (datosCesions.Count == 7)
            {
                GestorDePagosfrm gestorDePagosfrm = new GestorDePagosfrm();
                gestorDePagosfrm.lblUsuario.Text = datosCesions[1];

                gestorDePagosfrm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("No se pudo iniciar");
            }
        

        }
    }
}
