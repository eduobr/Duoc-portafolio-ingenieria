using DALC_01.Conexion;
using DALC_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.controller
{
    public class BoletaController
    {

        private Cl_Operaciones operaciones;

        public BoletaController()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<Boleta> listarBoleta()
        {

            List<Boleta> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Boleta>();
                object[] parametro = new object[1];
                parametro[0] = "BOLETA";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_BOLETA.LISTAR_BOLETA", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Boleta boleta = new Boleta();

                        boleta.idBoleta = int.Parse(dr["IDBOLETA"].ToString());
                        boleta.fechaPago = DateTime.Parse(dr["FECPAGO"].ToString());
                        boleta.fechaLimite = DateTime.Parse( dr["FECLIMITE"].ToString());
                        boleta.monto = int.Parse(dr["MONTO"].ToString());
                        boleta.estadoBoleta = int.Parse(dr["ESTADOBOLETA"].ToString());
                        boleta.idPlan = int.Parse(dr["IDPLAN"].ToString());

                        list.Add(boleta);
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
