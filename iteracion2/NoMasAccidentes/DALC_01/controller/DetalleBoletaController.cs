using DALC_01.Conexion;
using DALC_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.controller
{
    public class DetalleBoletaController
    {
        private Cl_Operaciones operaciones;

        public DetalleBoletaController()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<DetalleBoleta> listarDetalleBoleta()
        {

            List<DetalleBoleta> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<DetalleBoleta>();
                object[] parametro = new object[1];
                parametro[0] = "DETALLEBOLETA";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_DETALLEBOLETA.LISTAR_DETALLEBOLETA", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DetalleBoleta item = new DetalleBoleta();

                        item.idDetalleBoleta = int.Parse(dr["IDDETALLEBOLETA"].ToString());
                        item.precio = int.Parse(dr["PRECIO"].ToString());
                        item.idBoleta = int.Parse(dr["IDBOLETA"].ToString());
                        item.idServicio = int.Parse(dr["IDSERVICIO"].ToString());

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
