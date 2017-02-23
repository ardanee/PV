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
    public partial class frmIngresoVehiculo : Form
    {
        public frmIngresoVehiculo()
        {
            InitializeComponent();
            cargarComboTipoVehiculo();
            this.cargarComboTipoVehiculo();
            this.cargarComboMarca();
            this.cargarComboLinea();
        }

        public void frmIngresoVehiculo_Load(object sender, EventArgs e)
        {

        }

        public void mbMarca_selected_item(object sender, EventArgs e)
        {
            if (Int32.Parse(cmbMarca.SelectedValue.ToString()) > 0)
            {
                this.cmbLinea.Enabled = true;
                this.cargarComboLinea();
                //MessageBox.Show("ID marca: " + cmbMarca.SelectedValue.ToString());
                //this.txtNombre.Enabled = true;
                //this.txtNombre.Focus();
            }
            else
            {
                //limpiarControles();
            }
        }

        private void tabControler_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == this.tabPage2)
            {
                //e.Cancel = true;
            }
        }

        private void cargarComboTipoVehiculo()
        {
            BL.ClsTipoVehiculo clsTipoVehiculo = new BL.ClsTipoVehiculo();
            //DataTable dt = clsTipoVehiculo.seleccionar("");
            cargarCombos(clsTipoVehiculo.seleccionar(""), cmbTipoVehiculo, "tipo de vehiculo");
        }

       


        private void cargarComboMarca()
        {
           BL.ClsMarcaV clsMarca = new BL.ClsMarcaV();
            //DataTable dt = clsMarca.seleccionar("");
            cargarCombos(clsMarca.seleccionar(""), cmbMarca,"una marca");
        }

        private void cargarComboLinea()
        {
            
            BL.ClsLinea clsLinea = new BL.ClsLinea();
            cargarCombos(clsLinea.seleccionarLineaMarca(cmbMarca.SelectedValue.ToString()),this.cmbLinea,"una Linea");
        }

        private void cargarCombos(DataTable dataTable, ComboBox combo, string extra)
        {
            Dictionary<int, String> dicTipoVehiculo = new Dictionary<int, string>();
            dicTipoVehiculo.Add(0, "Seleccione " + extra + "...");
            foreach (DataRow row in dataTable.Rows)
            {
                dicTipoVehiculo.Add(Int32.Parse(row[0].ToString()), row[1].ToString());
            }
            combo.DisplayMember = "Value";
            combo.ValueMember = "Key";
            combo.DataSource = dicTipoVehiculo.ToArray();
        }

      

        

       
    }
}
