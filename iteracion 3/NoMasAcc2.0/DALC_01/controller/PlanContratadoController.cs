using DALC_01.Conexion;
using DALC_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.controller
{
   public class PlanContratadoController
    {
        private Cl_Operaciones operaciones;
        dbController bd = new dbController();

        public PlanContratadoController()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<PlanContratado> buscarPlan(string param)
        {

            List<PlanContratado> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<PlanContratado>();
                object[] parametro = new object[2];
                parametro[0] = param;
                parametro[1] = "PLANCONTRATADO";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_PLANCONTRATADO.BUSCAR_PLANCONTRATADO", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        PlanContratado item = new PlanContratado();

                        item.idPlanContra = int.Parse(dr["IDPLAN"].ToString());
                        item.fechaPlanContra = DateTime.Parse(dr["FECPLAN"].ToString());
                        item.nombreCliente = dr["NOMBRE CLIENTE"].ToString();
                        item.nombreProfesional = dr["NOMBRE PROFESIONAL"].ToString();
                        if (int.Parse(dr["ESTADO"].ToString()) == 1)
                        {
                            item.estado = "Activo";
                        }
                        else
                        {
                            item.estado = "Inactivo";
                        }
                        //item.estado = dr["ESTADO"].ToString();

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

        public List<PlanContratado> listarPlan()
        {

            List<PlanContratado> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<PlanContratado>();
                object[] parametro = new object[1];
                parametro[0] = "PLANCONTRATADO";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_PLANCONTRATADO.LISTAR_PLANCONTRATADO", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        PlanContratado item = new PlanContratado();

                        item.idPlanContra = int.Parse(dr["IDPLAN"].ToString());
                        item.fechaPlanContra = DateTime.Parse(dr["FECPLAN"].ToString());
                        item.nombreCliente = dr["NOMBRE CLIENTE"].ToString();
                        item.nombreProfesional = dr["NOMBRE PROFESIONAL"].ToString();
                        if (int.Parse(dr["ESTADO"].ToString())==1)
                        {
                            item.estado = "Activo";
                        }else
                        {
                            item.estado = "Inactivo";
                        }
                        //item.estado = dr["ESTADO"].ToString();

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

        //---------------------------------------------------------

        public List<PlanContratado> buscarPlan(int id)
        {

            List<PlanContratado> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<PlanContratado>();
                object[] parametro = new object[2];
                parametro[0] = id.ToString();
                parametro[1] = "PLANCONTRATADO";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_PLANCONTRATADO.BUSCAR_PLANCONTRATADO", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        PlanContratado item = new PlanContratado();

                        item.idPlanContra = int.Parse(dr["IDPLAN"].ToString());
                        item.fechaPlanContra = DateTime.Parse(dr["FECPLAN"].ToString());
                        item.nombreCliente = dr["NOMBRE CLIENTE"].ToString();
                        item.nombreProfesional = dr["NOMBRE PROFESIONAL"].ToString();
                        item.estado = dr["ESTADO"].ToString();

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

        public int Insert_Plan(int precio, string rutCli, string rutProf, DateTime fecVisita1, DateTime fecVisita2)
        {
            try
            {
                object[] parameter = new object[5];

                parameter[0] = precio;
                parameter[1] = rutCli;
                parameter[2] = rutProf;
                parameter[3] = fecVisita1;
                parameter[4] = fecVisita2;

                bd.ExecSP("PKG_PLANCONTRATADO.INSERTAR_PLANCONTRATADO", parameter);
                return 1;


            }
            catch (Exception e)
            {

                return 0;
            }
        }




    }
}
