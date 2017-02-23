using Microsoft.Reporting.WinForms;
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
    public partial class FrmReporte : Form
    {
        public string idReporte;
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {

            this.rw1.RefreshReport();
        }

        public void cargarReporte(string nombreReporte, DataTable origenDatos)
        {
            try
            {
                switch (nombreReporte)
                {
                    case "RptRecibo":
                        {
                            rw1.LocalReport.ReportPath = @"Reportes\RptRecibo.rdlc";
                            rw1.LocalReport.DataSources.Clear();
                           rw1.LocalReport.DataSources.Add(new ReportDataSource("DtsRecibo", origenDatos));

                            break;
                        }
                }

                this.rw1.RefreshReport();
                this.ShowDialog();
            }
            catch (Exception ex)
            {

                ClsHelper.erroLog(ex);
            }
        }
    }
}
