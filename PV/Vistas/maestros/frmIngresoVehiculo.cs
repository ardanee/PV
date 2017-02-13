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
            
        }


        private void frmIngresoVehiculo_Load(object sender, EventArgs e)
        {
            cargarComboTipoVehiculo();
            cargarComboMarca();
        }

        private void cargarComboMarca()
        {
            BL.ClsMarcaVehiculo clsMarca = new BL.ClsMarcaVehiculo();
            //DataTable dt = clsMarca.seleccionar("");
            cargarCombos(clsMarca.seleccionar(""),cmbMarca);

        }


        private void cargarComboTipoVehiculo()
        {
            BL.ClsTipoVehiculo clsTipoVehiculo = new BL.ClsTipoVehiculo();
            //DataTable dt = clsTipoVehiculo.seleccionar("");
            cargarCombos(clsTipoVehiculo.seleccionar(""),cmbTipoVehiculo);
            
        }
       
        private void cargarCombos(DataTable dataTable, ComboBox combo){
            Dictionary<int, String> dicTipoVehiculo = new Dictionary<int, string>();
            foreach (DataRow row in dataTable.Rows)
            {
                dicTipoVehiculo.Add(Int32.Parse(row[0].ToString()), row[1].ToString());
            }
            combo.DisplayMember = "Value";
            combo.ValueMember = "Key";
            combo.DataSource = dicTipoVehiculo.ToArray();   
        }

        
        private void btnAddTipoVehiculo_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Value: " + cmbTipoVehiculo.SelectedValue + " Key: " + cmbTipoVehiculo.SelectedText);
            frmTipoVehiculo frmvehiculo = new frmTipoVehiculo();
            frmvehiculo.ShowDialog(this);
            cargarComboTipoVehiculo();
        }

        private void btnAddMarca_Click(object sender, EventArgs e)
        {
            frmMarca frmmarca = new frmMarca();
            frmmarca.ShowDialog(this);

        }
    }
}
