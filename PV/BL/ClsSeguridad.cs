﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace PV.BL
{
    class ClsSeguridad : ClsDb
    {
        public DataTable seleccionarRol()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = consultarTabla("SELECT idRol, CONVERT(VARCHAR,idRol) +'-'+nombre nombre FROM TblSecRol");
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable selecFormulariosRol(int idRol)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = consultarTabla("SpFormulariosRol", null, Parametro("@PidRol", idRol.ToString()));
                return dt;
            }
            catch (Exception) { throw; }
        }

        public void brindarDenegarAcceso(int idFormulario, int idRol, string modo, int acceso)
        {
            try
            {
                ejecutarSP("SpBrindarDenegarAcceso", null, Parametro("@PidFormulario", idFormulario.ToString())
                      , Parametro("@PidRol", idRol.ToString()), Parametro("@Pmodo", modo), Parametro("@Pacceso", acceso.ToString()));

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Boolean existeNombreRol(string nombre)
        {
            Boolean res = false;
            try
            {
                if (Convert.ToInt32(consultarEscalar("SELECT COUNT(1) FROM TblSecRol WHERE nombre ='" + nombre + "'")) > 0)
                {
                    res = true;
                }
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void insertarRol(string nombre, string descripcion)
        {
            try
            {
                ejecutarSP("SpIRol", null, Parametro("@Pnombre", nombre)
                      , Parametro("@Pdescripcion", descripcion));
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void grabarModificarUsuario(string idUsuario,string nombre, string usuario, string fechaNacimiento,string descripcion, string activo, string cambiarContrasena)
        {
            try
            {
                ejecutarSP("SpIUUSuario",null, Parametro("@PidUsuario", idUsuario), Parametro("@Pnombre", nombre), Parametro("@Pusuario", usuario), Parametro("@Pdescripcion", descripcion), Parametro("@Pactivo", activo), Parametro("@PfechaNacimiento", fechaNacimiento), Parametro("@PcambiarContrasena", cambiarContrasena));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable buscarUsuario(string criterio) {
            DataTable res;
            try
            {
                res = consultarTabla("SpBuscarUsuario", null, Parametro("@Pcriterio", criterio));
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}