using DALC_01.Conexion;
using DALC_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.controller
{
    class UbicacionController
    {

        private Cl_Operaciones operaciones;

        public UbicacionController()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<Ubicacion> listarCiudad()
        {

            List<Ubicacion> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Ubicacion>();
                object[] parametro = new object[1];
                parametro[0] = "UBICACION";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_UBICACION.LISTAR_UBICACION", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Ubicacion item = new Ubicacion();

                        item.idUbicacion = int.Parse(dr["IDUBICACION"].ToString());
                        item.direccion = dr["DIRECCION"].ToString();
                        item.fechaUbicacion = DateTime.Parse(dr["FECHA"].ToString());
                        item.idUbicacion = int.Parse(dr["IDPROFESIONAL"].ToString());

                        list.Add(item);
                    }
                }
                dr.Dispose();
                return list;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            finally
            {
                operaciones.cerrarConexion();
            }
        }

    }
}
