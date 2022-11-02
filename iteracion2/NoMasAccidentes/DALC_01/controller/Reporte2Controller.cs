using DALC_01.Conexion;
using DALC_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.controller
{
    public class Reporte2Controller
    {
            private Cl_Operaciones operaciones;

            public Reporte2Controller()
            {
                operaciones = new Cl_Operaciones();
            }

            public List<Reporte2> listarCliente(string rut)
            {

                List<Reporte2> list;
                Oracle.DataAccess.Client.OracleDataReader dr;
                try
                {
                    operaciones.abrirConexion();
                    list = new List<Reporte2>();
                    object[] parametro = new object[2];
                    parametro[0] = rut;
                    parametro[1] = "REPORTE";
                    Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_REPORTE.LISTAR_CLIENTE", parametro);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Reporte2 Reporte2 = new Reporte2();

                            Reporte2.precio = int.Parse(dr["PRECIO"].ToString());
                            Reporte2.servicio = dr["DESCRIPCION"].ToString();
                            Reporte2.fechaPlan = DateTime.Parse(dr["FECPLAN"].ToString());
                            Reporte2.fechaPago = DateTime.Parse(dr["FECPAGO"].ToString());
                            Reporte2.fechaLimite = DateTime.Parse(dr["FECLIMITE"].ToString());
                            Reporte2.nombreProfecional = dr["NOMBRE PROFECIONAL"].ToString();
                            Reporte2.telefono = dr["TELEFONO"].ToString();


                            list.Add(Reporte2);
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




            public List<Reporte2> listarGlobal(DateTime fecha1, DateTime fecha2)
            {

                List<Reporte2> list;
                Oracle.DataAccess.Client.OracleDataReader dr;
                try
                {
                    operaciones.abrirConexion();
                    list = new List<Reporte2>();
                    object[] parametro = new object[3];
                    parametro[0] = fecha1;
                    parametro[1] = fecha2;
                    parametro[2] = "REPORTE";
                    Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_REPORTE.LISTAR_GLOBAL", parametro);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Reporte2 Reporte2 = new Reporte2();

                            Reporte2.precio = int.Parse(dr["PRECIO"].ToString());
                            Reporte2.servicio = dr["DESCRIPCION"].ToString();
                            Reporte2.fechaPlan = DateTime.Parse(dr["FECPLAN"].ToString());
                            Reporte2.fechaPago = DateTime.Parse(dr["FECPAGO"].ToString());
                            Reporte2.fechaLimite = DateTime.Parse(dr["FECLIMITE"].ToString());
                            Reporte2.nombreProfecional = dr["NOMBRE PROFECIONAL"].ToString();
                            Reporte2.telefono = dr["TELEFONO"].ToString();


                            list.Add(Reporte2);
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
