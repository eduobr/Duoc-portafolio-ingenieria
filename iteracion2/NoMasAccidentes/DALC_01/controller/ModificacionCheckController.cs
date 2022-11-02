using DALC_01.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALC_01.modelo;

namespace DALC_01.controller
{
    public class ModificacionCheckController
    {
        private Cl_Operaciones operaciones;

        public ModificacionCheckController()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<ModificarCheck> listarCiudad()
        {

            List<ModificarCheck> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<ModificarCheck>();
                object[] parametro = new object[1];
                parametro[0] = "MODIFICACIONCHECK";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_MODIFICACIONCHECK.LISTAR_MODIFICACIONCHECK", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ModificarCheck item = new ModificarCheck();

                        item.idModCheck = int.Parse(dr["IDMODIFICACION"].ToString());
                        item.fechaModCheck = DateTime.Parse(dr["FECHA"].ToString());
                        item.idCheck = int.Parse(dr["IDCHECK"].ToString());


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
