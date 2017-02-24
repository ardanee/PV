using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV.Vistas.parciales
{
    public partial class frmPListaVehiculo : Form
    {

        private PV.Vistas.maestros.frmIngresarVehiculo padre;
        public frmPListaVehiculo(PV.Vistas.maestros.frmIngresarVehiculo padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            this.padre.cargarFormIngreso();
        }
    }
}
