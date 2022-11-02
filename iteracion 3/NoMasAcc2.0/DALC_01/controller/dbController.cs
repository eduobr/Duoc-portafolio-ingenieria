using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace DALC_01.controller
{
   public class dbController
    {
        OracleConnection conn = null;
        private string oradb = "Data Source=localhost:1521/xe;User Id=nomas;Password=1234";

        public DataTable ExecuteQuery(string query)
        {
            conn = new OracleConnection(oradb);
            try
            {
                conn.Open();
                OracleCommand selectCommand = new OracleCommand(query, conn);
                selectCommand.CommandType = CommandType.Text;
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(selectCommand);
                DataTable dt = new DataTable();
                oracleDataAdapter.Fill(dt);
                selectCommand.Dispose();
                oracleDataAdapter.Dispose();
                return dt;
            }
            catch (Exception)
            {

                return new DataTable();
            }
            finally
            {
                conn.Close();
            }
        }

        public int ExecSP(string SP, params object[] parametros)
        {
            try
            {
                OracleConnection cn = new OracleConnection(oradb);
                OracleCommand cmd = new OracleCommand(SP, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                OracleCommandBuilder.DeriveParameters(cmd);
                int cuenta = 0;

                foreach (OracleParameter pr in cmd.Parameters)
                {
                    if (pr.ParameterName != "RETURN_VALUE")
                    {
                        pr.Value = parametros[cuenta];
                        cuenta++;
                    }
                }
                int res = cmd.ExecuteNonQuery();
                cn.Close();
                cmd.Dispose();
                return 1;
            }
            catch (Exception ex)
            {

                return 0;
            }
        }
    }
}
