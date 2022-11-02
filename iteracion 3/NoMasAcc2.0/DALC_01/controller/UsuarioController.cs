using DALC_01.Conexion;
using DALC_01.modelo;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.controller
{
    public class UsuarioController
    {
        private Cl_Operaciones operaciones;

        public UsuarioController()
        {
            operaciones = new Cl_Operaciones();
        }

        public int insertarUsuario(string user, string pass, int idTipoUsuario)
        {
            try
            {
                object[] parametros = new object[4];
                parametros[0] = user;
                parametros[1] = pass;
                parametros[2] = idTipoUsuario;
                parametros[3] = "P_IDUSUARIO";
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_USUARIO.INSERTAR_USUARIO",parametros);
                cmd.ExecuteNonQuery();
                int idUsuario = Convert.ToInt32(cmd.Parameters["P_IDUSUARIO"].Value);
                return idUsuario;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public List<Usuario> listarUsuario()
        {

            List<Usuario> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Usuario>();
                object[] parametro = new object[1];
                parametro[0] = "USUARIO";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_USUARIO.LISTAR_USUARIO", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Usuario item = new Usuario();

                        item.idUsuiario = int.Parse(dr["IDUSUARIO"].ToString());
                        item.usu = dr["USU"].ToString();
                        item.pass = dr["PASS"].ToString();
                        item.estadoUsu = int.Parse(dr["ESTADOUSUARIO"].ToString());
                        item.idTipoUsu = int.Parse(dr["IDTIPOUSUARIO"].ToString());

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
