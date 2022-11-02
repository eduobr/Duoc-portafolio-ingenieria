using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace DALC_01.Conexion
{
    public class Cl_Conexion
    {
        private OracleConnection conn;
        private string cadena = "Data Source=xe;USER ID=nomas; PASSWORD=1234";

        public Cl_Conexion()
        {
            try
            {
                if (conn == null)
                {
                    conn = new OracleConnection(cadena);
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public OracleConnection obtenerConexion()
        {
            return conn;
        }
    }
}
