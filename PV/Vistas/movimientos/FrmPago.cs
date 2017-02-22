using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV
{
    public partial class FrmPago : Form
    {
        BL.ClsPago ClsPago = new BL.ClsPago();
        public FrmPago()
        {
            InitializeComponent();
        }

        private void FrmPago_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                grdVenta.DataSource = ClsPago.buscarVentaEncabezado(txtBusqueda.Text.Trim());
                cargarListaPagos();
            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }
        }

        private void grdVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        cargarListaPagos();
                        break;
                    }
                case 1:
                    {

                        break;
                    }
                case 2:
                    {
                        FrmNuevoPago frm = new FrmNuevoPago();
                        frm.idVenta = Convert.ToInt32(grdVenta.SelectedRows[0].Cells["idVentaCol"].Value.ToString());
                        frm.ShowDialog();
                        cargarListaPagos();
                        break;
                    }
            }
        }

        void cargarListaPagos()
        {
            try
            {
                if (grdVenta.SelectedRows.Count > 0)
                {
                    lblTituloVenta.Text = "Lista de pagos de " +
                        grdVenta.SelectedRows[0].Cells["nombreCol"].Value.ToString() + " " +
                        grdVenta.SelectedRows[0].Cells["vehiculoCol"].Value.ToString();
                    grdPago.DataSource = ClsPago.seleccionarPagos(grdVenta.SelectedRows[0].Cells["idVentaCol"].Value.ToString());
                }
                else
                {
                    lblTituloVenta.Text = "Lista de Pagos Recibidos";
                    grdPago.DataSource = null;
                }
            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }
        }


    }
}
