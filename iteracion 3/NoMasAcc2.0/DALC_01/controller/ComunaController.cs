using DALC_01.Conexion;
using DALC_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.controller
{
    public class ComunaController
    {
        private Cl_Operaciones operaciones;

        public ComunaController()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<Comuna> listarComuna()
        {

            List<Comuna> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Comuna>();
                object[] parametro = new object[1];
                parametro[0] = "CIUDAD";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_COMUNA.LISTAR_COMUNA", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Comuna item = new Comuna();

                        item.idComuna = int.Parse(dr["IDCOMUNA"].ToString());
                        item.descComuna = dr["DESCRIPCION"].ToString();
                        item.idCiudad = int.Parse(dr["IDCIUDAD"].ToString());


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
