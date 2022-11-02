using DALC_01.Conexion;
using DALC_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.controller
{
    public class RubroController
    {
        private Cl_Operaciones operaciones;

        public RubroController()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<Rubro> listarRubro()
        {

            List<Rubro> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Rubro>();
                object[] parametro = new object[1];
                parametro[0] = "RUBRO";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_RUBRO.LISTAR_RUBRO", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Rubro item = new Rubro();

                        item.idRubro = int.Parse(dr["IDRUBRO"].ToString());
                        item.descRubro = dr["DESCRIPCION"].ToString();


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
