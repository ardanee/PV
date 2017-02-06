using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV.Vistas
{
    public partial class FrmUsuario : Form
    {
        private PV.BL.ClsSeguridad ClsSeguridad = new PV.BL.ClsSeguridad();
         string idUsuario;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string activo;
            string cambiarContrasena;
            try
            {
                if (!ClsHelper.camposObligatorios(txtNombre, txtUsuario, txtFechaNacimiento)) {
                    return;
                }
                if (!ClsHelper.isDate(txtFechaNacimiento.Text))
                {
                    ClsHelper.MensajeSistema("Ingrese una fecha válida");
                    txtFechaNacimiento.Focus();
                                    }
                activo = Convert.ToInt16(chkActivo.Checked).ToString();
                cambiarContrasena = Convert.ToInt16(chkReiniciarContrasena.Checked).ToString();
                if (idUsuario == null) { idUsuario = "0"; }
                ClsSeguridad.grabarModificarUsuario(idUsuario, txtNombre.Text, txtUsuario.Text, txtFechaNacimiento.Text, txtDescripcion.Text, activo, cambiarContrasena);
                ClsHelper.MensajeSistema("Proceso completado exitosamente");
            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);                
            }
        }

        private void limpiarControles() {
            try
            {
                idUsuario = string.Empty;
                txtUsuario.Clear();
                txtNombre.Clear();
                txtFechaNacimiento.Clear();
                txtDescripcion.Clear();
                chkActivo.Checked = true;
                chkReiniciarContrasena.Checked = false;
                txtNombre.Focus();                  
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            
        }
    }
}
