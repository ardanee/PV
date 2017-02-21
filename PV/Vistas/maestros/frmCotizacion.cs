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
        private Vistas.parciales.frmCotizacionBusqueda parcialBusqueda;
        private Vistas.parciales.formCotizacionResultado parcialResultado;

        public frmCotizacion()
        {
            InitializeComponent();
            this.parcialBusqueda = new parciales.frmCotizacionBusqueda(this);
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
            this.parcialResultado = new Vistas.parciales.formCotizacionResultado(idVehiculo, this);
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
    public class myButtonObj : UserControl
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            graphics.DrawEllipse(myPen, 0, 0, 50, 50);
            myPen.Dispose();
            //base.OnPaint(e);
        }


    }
}
