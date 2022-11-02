using DALC_01.Conexion;
using DALC_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.controller
{
    public class TipoEventoController
    {
        private Cl_Operaciones operaciones;

        public TipoEventoController()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<TipoEvento> listarCiudad()
        {

            List<TipoEvento> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<TipoEvento>();
                object[] parametro = new object[1];
                parametro[0] = "TIPOEVENTO";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_TIPOEVENTO.LISTAR_TIPOEVENTO", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        TipoEvento item = new TipoEvento();

                        item.idTipoEven = int.Parse(dr["IDTIPOEVENTO"].ToString());
                        item.descTipoEven = dr["DESCRIPCION"].ToString();


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
