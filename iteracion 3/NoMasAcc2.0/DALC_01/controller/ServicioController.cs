using DALC_01.Conexion;
using DALC_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.controller
{
    public class ServicioController
    {
        private Cl_Operaciones operaciones;

        public ServicioController()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<Servicio> listarCiudad()
        {

            List<Servicio> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Servicio>();
                object[] parametro = new object[1];
                parametro[0] = "SERVICIO";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_SERVICIO.LISTAR_SERVICIO", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Servicio item = new Servicio();

                        item.idServicio = int.Parse(dr["IDSERVICIO"].ToString());
                        item.descServicio = dr["DESCRIPCION"].ToString();


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
