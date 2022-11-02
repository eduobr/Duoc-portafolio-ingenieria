using DALC_01.Conexion;
using DALC_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.controller
{
    public class VisitaController
    {
        private Cl_Operaciones operaciones;

        public VisitaController()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<Visita> buscarVisita(string param)
        {

            List<Visita> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Visita>();
                object[] parametro = new object[2];
                //parametro[0] = rut;
                parametro[0] = param;
                parametro[1] = "VISITA";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_VISITA.BUSCAR_VISITA", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Visita visita = new Visita();
                        visita.idVisita = int.Parse(dr[0].ToString());
                        visita.fecha = DateTime.Parse(dr[1].ToString());
                        if (int.Parse(dr[2].ToString()) == 1)
                        {
                            visita.idEstado = "Realizada";
                        }
                        else
                        {
                            visita.idEstado = "No Realizada";
                        }
                        //visita.idEstado = dr[2].ToString();
                        visita.rutCliente = dr[3].ToString();
                        visita.rutProfesional = dr[4].ToString();
                        visita.nombreCliente = dr[5].ToString();
                        visita.nombreProfecional = dr[6].ToString();

                        list.Add(visita);
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

        public List<Visita> listarVisita()
        {

            List<Visita> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Visita>();
                object[] parametro = new object[1];
                //parametro[0] = rut;
                parametro[0] = "VISITA";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_VISITA.LISTAR_VISITA", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Visita visita = new Visita();
                        visita.idVisita = int.Parse(dr[0].ToString());
                        visita.fecha = DateTime.Parse(dr[1].ToString());
                        if (int.Parse(dr[2].ToString())==1)
                        {
                            visita.idEstado = "Realizada";
                        }else
                        {
                            visita.idEstado = "No Realizada";
                        }
                        //visita.idEstado = dr[2].ToString();
                        visita.rutCliente = dr[3].ToString();
                        visita.rutProfesional = dr[4].ToString(); 
                        visita.nombreCliente = dr[5].ToString();
                        visita.nombreProfecional = dr[6].ToString();

                        list.Add(visita);
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
