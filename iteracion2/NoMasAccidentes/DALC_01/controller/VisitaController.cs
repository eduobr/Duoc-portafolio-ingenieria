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

        public List<Visita> listarVisita(string rut)
        {

            List<Visita> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Visita>();
                object[] parametro = new object[2];
                parametro[0] = rut;
                parametro[1] = "VISITA";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_VISITA.LISTAR_VISITA", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Visita visita = new Visita();

                        visita.idEstado = int.Parse(dr["IDVISITA"].ToString());
                        visita.fecha = DateTime.Parse(dr["FECHA"].ToString());
                        visita.idEstado = int.Parse(dr["IDESTADO"].ToString());
                        visita.rutCliente = dr["RUT CLIENTE"].ToString();
                        visita.rutProfesional = dr["RUT PROFESIONAL"].ToString(); 
                        visita.nombreCliente = dr["NOMBRE CLIENTE"].ToString();
                        visita.nombreProfecional = dr["NOMBRE PROFESIONAL"].ToString();

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
