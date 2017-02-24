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
    public partial class frmPCotizacionResultado : Form
    {
        private String idVehiculo;
        private Vistas.maestros.frmCotizacion padre;

        public frmPCotizacionResultado(String idVehiculo, Vistas.maestros.frmCotizacion padre)
        {
            InitializeComponent();
            this.idVehiculo = idVehiculo;
            this.padre = padre;
            //this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.padre.cargarParcialBusqueda();
            
        }
    }
}
