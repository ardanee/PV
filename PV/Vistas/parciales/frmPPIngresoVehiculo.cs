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
    public partial class frmPPIngresoVehiculo : Form
    {
        private PV.Vistas.maestros.frmIngresarVehiculo _p;
        public frmPPIngresoVehiculo( PV.Vistas.maestros.frmIngresarVehiculo _p)
        {
            InitializeComponent();
            this._p = _p;
            this.tbCosto.Columns.Add("id", typeof(string));
            this.tbCosto.Columns.Add("tag", typeof(string));
            this.tbCosto.Columns.Add("tipoCosto", typeof(string));
            this.tbCosto.Columns.Add("monto", typeof(double));
            this.tbCosto.Columns.Add("observaciones", typeof(string));
            this.tbCosto.Columns.Add("idTipoCosto", typeof(string));
            this.cmbMarca.Enabled = false;
            this.cmbLinea.Enabled = false;
            //this.cmbModelo.Enabled = false;
        }


        private void frmPPIngresoVehiculo_load(object sender, EventArgs e)
        {

            try
            {

                this.cargarComboTipoVehiculo();
                this.cargarCombosExtra();
                this.cmbTipoVehiculo.Focus();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }



        //metodos paraControles ---------------------------------------------------------------------------------

        //Metodo para consultar que tab esta seleccionada y bloquear
        public void frmChange_Index(object sender, EventArgs e)
        {
            switch (this.tabIngresoVehiculo.SelectedIndex)
            {

                case 0:

                    this.cmbTipoVehiculo.Focus();
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


        // Metodo para bloquear Tabs
        private void tabControler_Selecting(object sender, TabControlCancelEventArgs e)
        {
            /*if (e.TabPage == this.tabPropiedad || e.TabPage == this.tabCostos || e.TabPage == this.tabValorComercial)
            {
                e.Cancel = true;
                //this.txtNombrePropietario.Focus();
                //MessageBox.Show("Hello");
            }*/
        }


        //Metodo generico para cargar combos
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

        //Metodo para cargar combo marca
        private void cargarComboMarca()
        {
            BL.ClsMarcaV clsMarca = new BL.ClsMarcaV();
            //DataTable dt = clsMarca.seleccionar("");
            cargarCombos(clsMarca.seleccionar(""), cmbMarca, "una marca");
        }

        //etodo para cargar combo linea
        private void cargarComboLinea()
        {
            BL.ClsLinea clsLinea = new BL.ClsLinea();
            cargarCombos(clsLinea.seleccionarLineaMarca(cmbMarca.SelectedValue.ToString()), this.cmbLinea, "una Linea");
        }


        private void cargarComboTipoVehiculo()
        {
            BL.ClsTipoVehiculo clsTipoVehiculo = new BL.ClsTipoVehiculo();
            //DataTable dt = clsTipoVehiculo.seleccionar("");
            cargarCombos(clsTipoVehiculo.seleccionar(""), this.cmbTipoVehiculo, "tipo de vehiculo");
        }

        private void cargarCombosExtra()
        {
            for (int i = 1990; i <= DateTime.Now.Year+1; i++)
                this.cmbModelo.Items.Add(i);
            this.cmbTransmision.Items.Add("Automatico");
            this.cmbTransmision.Items.Add("Manual");
            this.cmbCilindros.Items.Add(3);
            this.cmbCilindros.Items.Add(4);
            this.cmbCilindros.Items.Add(6);
            this.cmbCilindros.Items.Add(8);
            this.cmbAsientos.Items.Add(2);
            this.cmbAsientos.Items.Add(3);
            this.cmbAsientos.Items.Add(4);
            this.cmbAsientos.Items.Add(5);
            this.cmbAsientos.Items.Add(6);
            this.cmbPuertas.Items.Add(2);
            this.cmbPuertas.Items.Add(3);
            this.cmbPuertas.Items.Add(4);
            this.cmbPuertas.Items.Add(5);
            this.cmbModelo.SelectedItem = 2010;
            this.cmbPuertas.SelectedItem = 4;
            this.cmbTransmision.SelectedItem = "Automatico";
            this.cmbCilindros.SelectedItem = 4;
            this.cmbPuertas.SelectedItem = 5;
            this.cmbAsientos.SelectedItem = 5;
        }

        private void cambiarPlacaMayuscula(object sender,EventArgs e)
        {
            this.txtPlaca.Text = this.txtPlaca.Text.ToUpper();
            this.txtPlaca.Select(this.txtPlaca.Text.Length,0);
        }

        private void cambiarChasisMayuscula(object sender, EventArgs e)
        {
            this.txtNoChasis.Text = this.txtNoChasis.Text.ToUpper();
            this.txtNoChasis.Select(this.txtNoChasis.Text.Length, 0);
        }

        private void cambiarNoMotorMayuscula(object sender, EventArgs e)
        {
            this.txtNoMotor.Text = this.txtNoMotor.Text.ToUpper();
            this.txtNoMotor.Select(this.txtNoMotor.Text.Length, 0);
        }


        //Metodos para tab Costos----------------------------------------------------------------------------------

        private String idCosto = "0";
        private DataTable tbCosto = new DataTable();
        private int countCosto = 1;

        //Carga el combo de tipo costo
        private void carcarComboTipoCosto()
        {
            BL.ClsTipoCosto clsTipoCosto = new BL.ClsTipoCosto();
            cargarCombos(clsTipoCosto.seleccionar(""), cmbTipoCosto, "tipo de costo");
        }


        //Metodo click en la celda - este controlara seleccionar la celda eliminar o actualizar
        private void grdExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        this.idCosto = this.grdCostos.SelectedRows[0].Cells["idCol"].Value.ToString();
                        this.txtEtiqueta.Text = this.grdCostos.SelectedRows[0].Cells["tagCol"].Value.ToString();
                        this.txtMonto.Text = this.grdCostos.SelectedRows[0].Cells["MontoCol"].Value.ToString();
                        this.txtObservacionCosto.Text = this.grdCostos.SelectedRows[0].Cells["observacionesCol"].Value.ToString();
                        this.cmbTipoCosto.SelectedValue = Int32.Parse(this.grdCostos.SelectedRows[0].Cells["idTipoCostoCol"].Value.ToString());
                        break;
                    case 1:
                        DialogResult r = MessageBox.Show("¿Confirma que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (r == DialogResult.Yes)
                        {
                            DataRow[] dt = this.tbCosto.Select("id = '" + this.grdCostos.SelectedRows[0].Cells["idCol"].Value.ToString() +"'");
                            dt[0].Delete();
                            
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

        //Limpiar controles tab Costos
        private void limpiarControles()
        {
            try{
                this.txtMonto.Clear();
                this.txtObservacionCosto.Clear();
                this.txtEtiqueta.Clear();
                this.cmbTipoCosto.SelectedValue = 0;
                this.idCosto = "0";
                this.txtEtiqueta.Focus();
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Calcular costo de costos almacenados en grid
        private void totalCosto()
        {
            try{
            
                double total = 0.00;
                if(this.tbCosto.Rows.Count > 0)
                     total = (double)this.tbCosto.Compute("sum(monto)", "");

                this.lblTotal.Text = total.ToString();
        
               }catch (Exception ex)
            {
                //this.idCosto = "0";
                ClsHelper.erroLog(ex);
            }

        }

        public void agregarGridCosto()
        {
            DataRow dt = this.tbCosto.NewRow();
            
            if (this.idCosto == "0")
            {
                dt["id"] = "D" + (this.countCosto).ToString();
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
                /*DataRow drow = null;
                for (int i = 0; i <= (this.tbCosto.Rows.Count - 1); i++)
                {
                    DataRow dr = this.tbCosto.Rows[i];
                    if (dr["id"].ToString() == this.idCosto)
                    {
                        drow = dr;
                    }
                }
                */
                DataRow[] srow = this.tbCosto.Select("id = '" + this.idCosto + "'");
                if (this.validarControlesCosto(srow[0]) && srow[0] != null)
                {
                    srow[0]["tipoCosto"] = this.cmbTipoCosto.Text.ToString();
                    srow[0]["observaciones"] = this.txtObservacionCosto.Text;
                    this.tbCosto.AcceptChanges();
                    //this.tbCosto.Rows.Add(drow);
                    this.limpiarControles();
                }

            }
            this.grdCostos.DataSource = this.tbCosto;
            this.totalCosto();
        }


        private bool validarControlesCosto(DataRow dt)
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


        private void button3_Click(object sender, EventArgs e)
        {
            PV.frmTipoCosto frmTCosto = new frmTipoCosto();
            frmTCosto.ShowDialog(this);
            this.carcarComboTipoCosto();
        }

        private void btnCAncelarFrmCosto_Click(object sender, EventArgs e)
        {
            this.limpiarControles();
        }

        private void btnGrabarFrmCosto_Click(object sender, EventArgs e)
        {
            this.agregarGridCosto();
        }




        //Metodos para Tab  Descripcion ----------------------------------------------------------------------------------

        // metodo para cuando se selecciona un item de CmbTipoVehiculo
        public void cmbTipoVehiculo_selected_item(object sender, EventArgs e)
        {
            if (Int32.Parse(cmbTipoVehiculo.SelectedValue.ToString()) > 0)
            {
                this.cmbMarca.Enabled = true;
                this.cargarComboMarca();
                //MessageBox.Show("ID marca: " + cmbMarca.SelectedValue.ToString());
                //this.txtNombre.Enabled = true;
                //this.txtNombre.Focus();
            }
            else
            {
                this.cmbMarca.Enabled = false;
                
                this.cmbMarca.SelectedValue = 0;
                //limpiarControles();
            }
        }

        //Metodo para cuando se selecciona un item de cmbMarca
        public void cmbMarca_selected_item(object sender, EventArgs e)
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
                this.cmbLinea.Enabled = false;
                this.cmbLinea.SelectedValue = 0;
                //limpiarControles();
            }
        }

        private void btnCancelarDescripcion_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Seguro Desea Salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this._p.cargarFormListaVehiculos();
                //this.Dispose();
            }


        }

        private void btnSiguienteDescripcion_Click(object sender, EventArgs e)
        {
            this.tabIngresoVehiculo.SelectedIndex = 1;
        }

        private void btnSiguientePropiedad_Click(object sender, EventArgs e)
        {
            this.tabIngresoVehiculo.SelectedIndex = 2;

        }

        private void btnRegresarPropiedad_Click(object sender, EventArgs e)
        {
            this.tabIngresoVehiculo.SelectedIndex = 0;

        }

        private void btnSiguienteCostos_Click(object sender, EventArgs e)
        {
            this.tabIngresoVehiculo.SelectedIndex = 3;

        }

        private void btnCancelarCostos_Click(object sender, EventArgs e)
        {
            this.tabIngresoVehiculo.SelectedIndex = 2;

        }

        private void btnCancelarPropiedad_Click(object sender, EventArgs e)
        {
            this.tabIngresoVehiculo.SelectedIndex = 1;

        }

        private void btnCancelarRegresar_Click(object sender, EventArgs e)
        {
            this.tabIngresoVehiculo.SelectedIndex = 1;
        }


    }
}
