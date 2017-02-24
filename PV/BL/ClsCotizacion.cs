using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV.BL
{
    class ClsCotizacion:ClsDb
    {

        public DataTable seleccionar(string criterio)
        {
            DataTable res = new DataTable();
            try
            {
                res = consultarTabla("SpCotizacion", null, Parametro("@Pcriterio", criterio));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
