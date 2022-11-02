using DALC_01.Conexion;
using DALC_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.controller
{
    public class TipoUsuarioController
    {
        private Cl_Operaciones operaciones;

        public TipoUsuarioController()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<TipoUsuario> listarCiudad()
        {

            List<TipoUsuario> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<TipoUsuario>();
                object[] parametro = new object[1];
                parametro[0] = "TIPOUSUARIO";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_TIPOUSUARIO.LISTAR_TIPOUSUARIO", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        TipoUsuario item = new TipoUsuario();

                        item.idTIpoUsu = int.Parse(dr["IDTIPOUSUARIO"].ToString());
                        item.descTipoUsu = dr["DESCRIPCION"].ToString();


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
