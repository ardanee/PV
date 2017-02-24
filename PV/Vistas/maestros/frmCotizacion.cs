using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV.Vistas.maestros
{
    public partial class frmCotizacion : Form
    {
        private Vistas.parciales.frmPCotizacionBusqueda parcialBusqueda;
        private Vistas.parciales.frmPCotizacionResultado parcialResultado;

        public frmCotizacion()
        {
            InitializeComponent();
            this.parcialBusqueda = new parciales.frmPCotizacionBusqueda(this);
            cargarParcialBusqueda();
            //myButtonObj btn = new myButtonObj();
            
            //btn.Location.Y(18);
            //this.panel1.Controls.Add(btn);
            
        }


        public void cargarParcialBusqueda(){
            cargarForm(parcialBusqueda);
        }

        public void cargarParcialCotizacion(String idVehiculo)
        {
            this.parcialResultado = new Vistas.parciales.frmPCotizacionResultado(idVehiculo, this);
            cargarForm(this.parcialResultado);
        }
        

        //Carga formulario a el un panel
        private void cargarForm(object frmpartial){
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form partial = frmpartial as Form;
            partial.TopLevel = false;
            partial.FormBorderStyle = FormBorderStyle.None;
            partial.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(partial);
            this.panelContenedor.Tag = partial;
            partial.Show();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.cargarParcialBusqueda();
            this.parcialResultado.Dispose();
            this.parcialResultado = null;
        }

        

        
    }
}
