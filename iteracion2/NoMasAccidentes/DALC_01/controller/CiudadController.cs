using DALC_01.Conexion;
using DALC_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.controller
{
    public class CiudadController
    {
        private Cl_Operaciones operaciones;

        public CiudadController()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<Ciudad> listarCiudad()
        {

            List<Ciudad> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Ciudad>();
                object[] parametro = new object[1];
                parametro[0] = "CIUDAD";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_CIUDAD.LISTAR_CIUDAD", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Ciudad item = new Ciudad();

                        item.idCiudad = int.Parse(dr["IDCIUDAD"].ToString());
                        item.descCiudad = dr["DESCRIPCION"].ToString();
                        

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
