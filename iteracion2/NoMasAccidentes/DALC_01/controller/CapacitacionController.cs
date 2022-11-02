using DALC_01.Conexion;
using DALC_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.controller
{
    public class CapacitacionController
    {
        private Cl_Operaciones operaciones;
        public CapacitacionController() {
            operaciones = new Cl_Operaciones();
        }

        public List<Capacitacion> listarCapacitacion()
        {

            List<Capacitacion> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Capacitacion>();
                object[] parametro = new object[1];
                parametro[0] = "CAPACITACION";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_CAPACITACION.LISTAR_CAPACITACION", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Capacitacion capacitacion = new Capacitacion();

                        capacitacion.idCapacitacion = int.Parse(dr["IDCAPACITACION"].ToString());
                        capacitacion.fechaCapacitacion = DateTime.Parse(dr["FECHA"].ToString());
                        capacitacion.desCapacitacion = dr["DESCRIPCION"].ToString();
                        capacitacion.cantAsistentes = int.Parse(dr["CANTASISTENTES"].ToString());
                        capacitacion.idplan = int.Parse(dr["IDPLAN"].ToString());

                        list.Add(capacitacion);
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
