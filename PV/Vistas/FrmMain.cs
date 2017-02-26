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
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable dtAccesoFormularios = new DataTable();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                autenticacion();
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void autenticacion()
        {
            try
            {
                Boolean success = false;
                FrmLogin FrmLogin = new FrmLogin();
                success = FrmLogin.autenticar();
                if (success && !String.IsNullOrEmpty(ClsGlobals.usuario) && ClsGlobals.idUSuario > 0)
                {
                    //lblUsuario.Text = "Usuario: " + ClsGlobals.usuario + "  ";
                    //lblComputadora.Text = "Computadora: " + Environment.MachineName;
                    txtUsuario.Caption = "Usuario: " + ClsGlobals.usuario + "  ";
                    txtComputadora.Caption = "Computadora: " + Environment.MachineName;
                    mostrarMenu();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mostrarMenu()
        {
            BL.ClsSeguridad ClsSeguridad = new BL.ClsSeguridad();

            try
            {
                dtAccesoFormularios = ClsSeguridad.formulariosPorUsuario();
                foreach (DataRow r in dtAccesoFormularios.Rows)
                {

                    ribbon.Manager.Items[r["etiqueta"].ToString().Trim()].Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ribbon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                String etiqueta = e.Item.Name;
                //Si es cerrar sesión o restaurar no utilizar este método, sino sus propios
                if(etiqueta== "mnuCerrarSesion" || etiqueta == "mnuRestaurar") { return; }

                String nombreForm = string.Empty;
                Int16 modal = 0;
                DataRow[] r = dtAccesoFormularios.Select(" etiqueta LIKE'" + etiqueta.Trim() + "%'");
                if (r.Length < 1) { return; }
                nombreForm = r[0]["nombre"].ToString();
                modal = Convert.ToInt16(r[0]["modal"].ToString());
                object frm;
                frm = System.Reflection.Assembly.GetExecutingAssembly().CreateInstance("PV." + nombreForm);
                if (modal == 1)
                {
                    ((Form)frm).ShowDialog();
                }
                else
                {
                    ((Form)frm).MdiParent = this;
                    ((Form)frm).Show();
                }
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void mnuCerrarSesion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ClsGlobals.usuario = string.Empty;
                ClsGlobals.idUSuario = 0;
                txtComputadora.Caption = string.Empty;
                txtUsuario.Caption = string.Empty;
                for (Int32 i = 0; i <= ribbon.Manager.Items.Count - 1; i++) {
                    ribbon.Manager.Items[i].Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        }
                //Muestra el item cerrar sessión ya que este es visible para cualquier usuario
                ribbon.Manager.Items["mnuCerrarSesion"].Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                //Muestra ventana login
                this.autenticacion();
            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }
        }
    }
}
