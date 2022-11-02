using DALC_01.Conexion;
using DALC_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.controller
{
    public class CheckListController
    {
        private Cl_Operaciones operaciones;
        public CheckListController()
        {
            operaciones = new Cl_Operaciones();
        }


        public List<CheckList> listarCheckList(string rut)
        {

            List<CheckList> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<CheckList>();
                object[] parametro = new object[2];
                parametro[0] = rut;
                parametro[1] = "CHECKLIST";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_CHECKLIST.BUSCAR_CHECKLIST_ADM", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        CheckList checkList = new CheckList();

                        checkList.index = int.Parse(dr[0].ToString());
                        checkList.descCheckList = dr["DESCRIPCION"].ToString();
                        list.Add(checkList);
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
