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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Boolean success = false;
            FrmLogin FrmLogin = new FrmLogin();
           success = FrmLogin.autenticar();
            if(success && !String.IsNullOrEmpty(ClsGlobals.usuario) && ClsGlobals.idUSuario > 0)
            {
                lblUsuario.Text = "Usuario: " + ClsGlobals.usuario + "  ";
                lblComputadora.Text = "Computadora: " + Environment.MachineName;
                mostrarMenu();
            }
        }

        private void mostrarMenu() {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
