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
    public partial class FrmLogin : Form
    {
        private int count = 5;
        public FrmLogin()
        {
            InitializeComponent();
        }

        public Boolean autenticar()
        {
            Boolean res = false;
            try
            {
                this.ShowDialog();
                if (ClsGlobals.idUSuario > 0 && !String.IsNullOrEmpty(ClsGlobals.usuario)) {
                    res = true;
                }
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                ClsHelper.erroLog(ex);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            DataTable tblInformacionLogin = new DataTable();
            try
            {
                BL.ClsSeguridad seg = new BL.ClsSeguridad();
                tblInformacionLogin = seg.login(txtUsuario.Text.Trim(), txtContrasena.Text.Trim());
                if (tblInformacionLogin.Rows.Count > 0)
                {
                    ClsGlobals.idUSuario = Convert.ToInt32(tblInformacionLogin.Rows[0]["idUsuario"].ToString());
                    ClsGlobals.usuario = tblInformacionLogin.Rows[0]["usuario"].ToString();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.ToString().Contains("[CC]"))
                {
                    //'Abrir formulario de cambio de pass'
                    ClsHelper.MensajeSistema(ex.Message);
                }
                else
                {
                    count -= 1;
                    ClsHelper.MensajeSistema(ex.Message + " " + count.ToString() + " intentos restantes");
                    if (count == 0) { Application.Exit(); }
                }


            }
        }
    }
}
