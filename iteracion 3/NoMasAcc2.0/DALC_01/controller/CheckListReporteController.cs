using DALC_01.Conexion;
using DALC_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.controller
{
    public class CheckListReporteController
    {
        private Cl_Operaciones operaciones;

        public CheckListReporteController()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<CheckListReporte> listarCheckListReporte()
        {

            List<CheckListReporte> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<CheckListReporte>();
                object[] parametro = new object[1];
                parametro[0] = "CHECKLISTREPORTE";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_CHECKLISTREPORTE.LISTAR_CHECKREPORTE", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        CheckListReporte item = new CheckListReporte();

                        item.idCheListRepo = int.Parse(dr["IDCHECKREPORTE"].ToString());
                        item.estadoCheck = int.Parse(dr["ESTADOCHECK"].ToString());
                        item.fechaCheckRep = DateTime.Parse(dr["FECHA"].ToString());
                        item.mejora = dr["MEJORA"].ToString();
                        item.idCheckList = int.Parse(dr["IDCHECKLIST"].ToString());
                        
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
