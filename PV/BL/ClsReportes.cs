﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace PV.BL
{
    class ClsReportes:ClsDb
    {
        public DataTable rptRecibos() {
            try
            {
                return consultarTabla("SPSReporteRecibo", null, Parametro("@Pusuario", ClsGlobals.usuario));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}