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
    public partial class frmIngresarVehiculo : Form
    {

        private Vistas.parciales.frmPPIngresoVehiculo frmIngreso;
        private Vistas.parciales.frmPListaVehiculo frmVehiculos;
        public frmIngresarVehiculo()
        {
            InitializeComponent();
            
        }

        private void frIngresarVehiculo_Load(object sender, EventArgs e)
        {

            this.frmVehiculos = new parciales.frmPListaVehiculo(this);

            this.frmIngreso = new parciales.frmPPIngresoVehiculo(this);
            this.cargarFormListaVehiculos();

        }


        public void cargarFormIngreso()
        {
            this.cargarForm(this.frmIngreso);
            //MessageBox.Show("clicl");
        }

        public void cargarFormListaVehiculos()
        {
            //this.frmIngreso.Dispose();
            this.cargarForm(this.frmVehiculos);
        }

        //Carga formulario a el un panel
        private void cargarForm(object frmpartial)
        {
            if (this.panContenedor.Controls.Count > 0)
            {
                this.panContenedor.Controls.RemoveAt(0);
            }
            Form partial = frmpartial as Form;
            partial.TopLevel = false;
            partial.FormBorderStyle = FormBorderStyle.None;
            partial.Dock = DockStyle.Fill;
            this.panContenedor.Controls.Add(partial);
            this.panContenedor.Tag = partial;
            partial.Show();
        }
    }
}
