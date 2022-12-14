using DALC_01.Conexion;
using DALC_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.controller
{
    public class EventoController
    {
        private Cl_Operaciones operaciones;

        public EventoController()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<Accidente> buscarAccidentes(string param)
        {
            List<Accidente> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Accidente>();
                object[] parametro = new object[2];
                parametro[0] = param; 
                parametro[1] = "Accidente";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_EVENTO.BUSCAR_ACCIDENTES", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Accidente item = new Accidente();

                        item.rutCliente = dr[0].ToString();
                        item.nombreCliente = dr[1].ToString();
                        item.rutProfesional = dr[2].ToString();
                        item.nombreProfesional = dr[3].ToString();
                        item.cantAccidente = int.Parse(dr[4].ToString());

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

        public List<Accidente> listarAccidentes()
        {
            List<Accidente> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Accidente>();
                object[] parametro = new object[1];
                parametro[0] = "Accidente";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_EVENTO.LISTAR_ACCIDENTES", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Accidente item = new Accidente();

                        item.rutCliente = dr[0].ToString();
                        item.nombreCliente = dr[1].ToString();
                        item.rutProfesional = dr[2].ToString();
                        item.nombreProfesional = dr[3].ToString();
                        item.cantAccidente = int.Parse(dr[4].ToString());

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
        
        public List<Evento> listarEvento()
        {

            List<Evento> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Evento>();
                object[] parametro = new object[1];
                parametro[0] = "EVENTO";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_EVENTO.LISTAR_EVENTO", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Evento item = new Evento();

                        item.idEvento = int.Parse(dr["IDEVENTO"].ToString());
                        item.asesoria = dr["ASESORIA"].ToString();
                        item.fechaEvento = DateTime.Parse(dr["FECHA"].ToString());
                        item.idTipoEvento = int.Parse(dr["IDTIPOEVENTO"].ToString());
                        item.idPlan = int.Parse(dr["IDPLAN"].ToString());

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



        public List<Evento> listarEventoID(int id)
        {

            List<Evento> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Evento>();
                object[] parametro = new object[2];
                parametro[0] = id;
                parametro[1] = "EVENTO";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_EVENTO.BUSCAR_EVENTO", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Evento item = new Evento();

                        item.idEvento = int.Parse(dr["IDEVENTO"].ToString());
                        item.asesoria = dr["ASESORIA"].ToString();
                        item.fechaEvento = DateTime.Parse(dr["FECHA"].ToString());
                        item.idTipoEvento = int.Parse(dr["IDTIPOEVENTO"].ToString());
                        item.idPlan = int.Parse(dr["IDPLAN"].ToString());

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
