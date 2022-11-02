using DALC_01.Conexion;
using DALC_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.controller
{
    public class ReporteController
    {
        private Cl_Operaciones operaciones;

        public ReporteController()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<Reporte> listarCiudad()
        {

            List<Reporte> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Reporte>();
                object[] parametro = new object[1];
                parametro[0] = "REPORTE";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_REPORTE.LISTAR_REPORTE", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Reporte item = new Reporte();

                        item.idReporte = int.Parse(dr["IDREPORTE"].ToString());
                        item.Visitas = int.Parse(dr["VISITAS"].ToString());
                        item.capacitacion = int.Parse(dr["CAPACITACION"].ToString());
                        item.accidente = int.Parse(dr["ACCIDENTES"].ToString());
                        item.multas = int.Parse(dr["MULTAS"].ToString());
                        item.idUsuAdmin = int.Parse(dr["IDUSUADMIN"].ToString());
                        item.idCliente = int.Parse(dr["IDCLIENTE"].ToString());


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
