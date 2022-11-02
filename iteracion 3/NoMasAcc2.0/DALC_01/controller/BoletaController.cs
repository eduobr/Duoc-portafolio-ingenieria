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
        dbController bd = new dbController();

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
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_BOLETA.LISTAR_NO_PAGADOS", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Boleta boleta = new Boleta();

                        boleta.idBoleta = int.Parse(dr["IDBOLETA"].ToString());
                        boleta.rutCliente = dr[1].ToString();
                        boleta.nombreCliente = dr[2].ToString();
                        boleta.fechaLimite = DateTime.Parse( dr["FECLIMITE"].ToString());
                        if (int.Parse(dr["ESTADOBOLETA"].ToString())==1)
                        {
                            boleta.estado = "Pagado";
                        }else
                        {
                            boleta.estado = "No Pagado";
                        }
                        //boleta.estado = dr["ESTADOBOLETA"].ToString();
                        boleta.idPlan = int.Parse(dr["IDPLAN"].ToString());
                        if (int.Parse(dr["ESTADO"].ToString())==1)
                        {
                            boleta.estadoServicio = "Activo";
                        }else
                        {
                            boleta.estadoServicio = "Inactivo";
                        }
                        //boleta.estadoServicio = dr["ESTADO"].ToString();

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

        public int notificarAtraso(int idBoleta)
        {
            try
            {

                object[] parameter = new object[1];
                parameter[0] = idBoleta;
                bd.ExecSP("PKG_BOLETA.NOTIFICAR_ATRASO", parameter);
                return 1;

            }
            catch (Exception e)
            {

                return 0;
            }
        }

        public int quitarServicio(int idPlan)
        {
            try
            {

                object[] parameter = new object[1];
                parameter[0] = idPlan;
                bd.ExecSP("PKG_BOLETA.QUITAR_SERVICIO", parameter);
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int restablecerServicio(int idPlan)
        {
            try
            {

                object[] parameter = new object[1];
                parameter[0] = idPlan;
                bd.ExecSP("PKG_BOLETA.RESTABLECER_SERVICIO", parameter);
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }



    }
}
