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
    public partial class frmPIngresoVehiculo : Form
    {

        private DataTable tbCosto = new DataTable();
        private string idCosto = "0";
        private int countCosto = 1;
        private PV.Vistas.maestros.frmIngresarVehiculo padre;

        public frmPIngresoVehiculo(PV.Vistas.maestros.frmIngresarVehiculo padre)
        {
            InitializeComponent();
            cargarComboTipoVehiculo();
            this.cargarComboTipoVehiculo();
            this.cargarComboMarca();
            this.cargarComboLinea();
            this.padre = padre;
        }

        public void frmIngresoVehiculo_Load(object sender, EventArgs e)
        {
            
        }

        public void frmChange(object sender, EventArgs e)
        {
            switch(this.tabForm.SelectedIndex){

                case 0:

                    this.txtPlaca.Focus();
                    break;

                case 1:
                    this.txtNombrePropietario.Focus();
                    break;

                case 2:
                    this.carcarComboTipoCosto();
                    this.txtEtiqueta.Focus();
                    break;

                case 3:
                    break;
                default:
                    break;
            }

               

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
            if (e.TabPage == this.tabPropiedad)
            {
                //e.Cancel = true;
                //this.txtNombrePropietario.Focus();
                //MessageBox.Show("Hello");
            }
        }

        private void tabControler_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == this.tabPropiedad)
            {
               // this.txtNombrePropietario.Focus();
                //MessageBox.Show("Hello");
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
            Dictionary<int, String> diccionario = new Dictionary<int, string>();
            diccionario.Add(0, "Seleccione " + extra + "...");
            foreach (DataRow row in dataTable.Rows)
            {
                diccionario.Add(Int32.Parse(row[0].ToString()), row[1].ToString());
            }
            combo.DisplayMember = "Value";
            combo.ValueMember = "Key";
            combo.DataSource = diccionario.ToArray();
        }

        private void carcarComboTipoCosto()
        {
            BL.ClsTipoCosto clsTipoCosto = new BL.ClsTipoCosto();
            cargarCombos(clsTipoCosto.seleccionar(""), cmbTipoCosto, "tipo de costo");
        }

        private void btnGrabarFrmCosto_Click(object sender, EventArgs e)
        {
            this.agregarGridCosto();
        }

        private void grdExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        this.idCosto  = this.grdCostos.SelectedRows[0].Cells["idCol"].Value.ToString();
                        this.txtEtiqueta.Text = this.grdCostos.SelectedRows[0].Cells["tagCol"].Value.ToString();
                        this.txtMonto.Text = this.grdCostos.SelectedRows[0].Cells["MontoCol"].Value.ToString();
                        this.txtObservacionCosto.Text = this.grdCostos.SelectedRows[0].Cells["observacionesCol"].Value.ToString();
                        this.cmbTipoCosto.SelectedValue = Int32.Parse(this.grdCostos.SelectedRows[0].Cells["idTipoCostoCol"].Value.ToString());
                        break;
                    case 1:
                        DialogResult r = MessageBox.Show("¿Confirma que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            //DataRow[] dt = this.tbCosto.Select(this.grdCostos.SelectedRows[0].Cells["idCol"].Value.ToString() + "=id");

                            for (int i = 0;i <= (this.tbCosto.Rows.Count - 1) ; i++)
                            {
                                DataRow dr = this.tbCosto.Rows[i];
                                if (dr["id"].ToString() == (this.grdCostos.SelectedRows[0].Cells["idCol"].Value.ToString()))
                                {
                                    dr.Delete();
                                }
                            }
                                limpiarControles();
                                this.totalCosto();
                            //ClsTipoCosto.eliminar(grdExistentes.SelectedRows[0].Cells["idTipoCostoCol"].Value.ToString());
                            //ClsHelper.MensajeSistema("Proceso ejecutado exitosamente");
                            //limpiarControles();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                this.idCosto = "0";
                ClsHelper.erroLog(ex);
            }
        }



        public void agregarGridCosto()
        {
            DataRow dt = this.tbCosto.NewRow();
            if (this.tbCosto.Rows.Count <= 0) {
                if (this.tbCosto.Columns.Count <= 0)
                {
                    this.tbCosto.Columns.Add("id", typeof(string));
                    this.tbCosto.Columns.Add("tag", typeof(string));
                    this.tbCosto.Columns.Add("tipoCosto", typeof(string));
                    this.tbCosto.Columns.Add("monto", typeof(double));
                    this.tbCosto.Columns.Add("observaciones", typeof(string));
                    this.tbCosto.Columns.Add("idTipoCosto", typeof(string));
                }
            }

            if (this.idCosto == "0")
            {
                dt["id"] = "D" +(this.countCosto).ToString();
                if (this.validarControlesCosto(dt))
                {
                    dt["tipoCosto"] = this.cmbTipoCosto.Text.ToString();
                    dt["observaciones"] = this.txtObservacionCosto.Text;
                    this.tbCosto.Rows.Add(dt);
                    this.limpiarControles();
                    this.countCosto++;
                    //this.tbCosto.Rows.Add(this.idCosto);
                }   
                
            }
            else
            {
                //DataRow[] drow = this.tbCosto.Select("id = "+this.idCosto); 
                DataRow drow = null;
                for (int i = 0; i <= (this.tbCosto.Rows.Count - 1); i++)
                {
                    DataRow dr= this.tbCosto.Rows[i];
                    if (dr["id"].ToString() == this.idCosto)
                    {
                        drow = dr;
                    }
                }

                if (this.validarControlesCosto(drow) && drow != null)
                {
                    drow["tipoCosto"] = this.cmbTipoCosto.Text.ToString();
                    drow["observaciones"] = this.txtObservacionCosto.Text;
                    this.tbCosto.AcceptChanges();
                    //this.tbCosto.Rows.Add(drow);
                    this.limpiarControles();
                }

            }
            this.grdCostos.DataSource = this.tbCosto;
            this.totalCosto();
        }

        

        private  bool validarControlesCosto(DataRow dt)
        {
            if (this.txtEtiqueta.Text != "")
                dt["tag"] = this.txtEtiqueta.Text;
            else
            {
                MessageBox.Show("Ingrese una etiqueta para el costo...");
                return false;
            }
            if (this.cmbTipoCosto.SelectedValue.ToString() != "0")
                dt["idTipoCosto"] = this.cmbTipoCosto.SelectedValue.ToString();
            else
            {
                MessageBox.Show("Tipo de Costo no seleccionado...");
                return false;
            }

            if (this.txtMonto.Text != "")
            {
                double i;
                if (double.TryParse(this.txtMonto.Text, out i))
                    dt["monto"] = this.txtMonto.Text;
                else
                {
                    MessageBox.Show("Monto no es Valido");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No hay monto a asignar...");
                return false;
            }
            return true;
        }

        private void limpiarControles()
        {
            this.txtMonto.Clear();
            this.txtObservacionCosto.Clear();
            this.txtEtiqueta.Clear();
            this.cmbTipoCosto.SelectedValue = 0;
            this.idCosto = "0";
        }

        private void btnCAncelarFrmCosto_Click(object sender, EventArgs e)
        {
            this.limpiarControles();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PV.frmTipoCosto frmTCosto = new frmTipoCosto();
            frmTCosto.ShowDialog(this);
            this.carcarComboTipoCosto();
        }

        private void totalCosto()
        {

            if(this.tbCosto.Rows.Count > 0){
                double total = (double)this.tbCosto.Compute("sum(monto)","");
                
            this.lblTotal.Text = total.ToString();
            }
            
        }
        

        

       
    }
}
