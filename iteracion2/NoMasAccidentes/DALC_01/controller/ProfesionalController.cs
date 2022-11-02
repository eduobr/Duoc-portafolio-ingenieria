using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALC_01.modelo;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;
using DALC_01.Conexion;
using Oracle.DataAccess.Client;


namespace DALC_01.controller
{
    public class ProfesionalController
    {
        private Cl_Operaciones operaciones;
        dbController bd = new dbController();

        public ProfesionalController()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<Profesional> listarProfecional()
        {
            
            List<Profesional> listaPro;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                listaPro = new List<Profesional>();
                object[] parametro = new object[1];
                parametro[0] = "PROFESIONAL";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_PROFESIONAL.LISTAR_PROFESIONAL", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Profesional profecional = new Profesional();

                        profecional.idProfesional =int.Parse( dr["IDPROFESIONAL"].ToString());
                        profecional.rutProfesional = dr["RUT"].ToString();
                        profecional.nombre = dr["NOMBRE"].ToString();
                        profecional.apePaterno = dr["APEPATERNO"].ToString();
                        profecional.apeMaterno = dr["APEMATERNO"].ToString();
                        profecional.telefono = dr["TELEFONO"].ToString();
                        profecional.fechaNacimientoPro = DateTime.Parse(dr["FECNACIMIENTO"].ToString());
                        profecional.idComuna = int.Parse(dr["IDCOMUNA"].ToString());
                        profecional.idUsuario = int.Parse(dr["IDUSUARIO"].ToString());

                        listaPro.Add(profecional);
                    }
                }
                dr.Dispose();
                return listaPro;
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

        public int Insert_Profecional(string rutProfesional, string nombre, string apePaterno, string apeMaterno, string telefono, DateTime fechaNacimientoPro, int idComuna, int idUsuario)
        {
            try
            {

            object[] parameter = new object[9];
            
            parameter[0] = rutProfesional.ToString();
            parameter[1] = nombre.ToString();
            parameter[2] = apePaterno.ToString();
            parameter[3] = apeMaterno.ToString();
            parameter[4] = telefono.ToString();
            parameter[5] = fechaNacimientoPro.ToString();
            parameter[6] = idComuna.ToString();

                //Oracle.DataAccess.Client.OracleCommand cmd = operaciones.ExecSP("PKG_PROFESIONAL.INSERTAR_PROFESIONAL", parameter);
                bd.ExecSP("PKG_PROFESIONAL.INSERTAR_PROFESIONAL", parameter);
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }



        public int Update_Profecional(int idProfesional, string rutProfesional, string nombre, string apePaterno, string apeMaterno, string telefono, DateTime fechaNacimientoPro, int idComuna, int idUsuario)
        {
            try
            {

                object[] parameter = new object[9];

                parameter[0] = idProfesional.ToString();
                parameter[1] = rutProfesional.ToString();
                parameter[2] = nombre.ToString();
                parameter[3] = apePaterno.ToString();
                parameter[4] = apeMaterno.ToString();
                parameter[5] = telefono.ToString();
                parameter[6] = fechaNacimientoPro.ToString();
                parameter[7] = idComuna.ToString();
                parameter[8] = idUsuario.ToString();

                //Oracle.DataAccess.Client.OracleCommand cmd = operaciones.ExecSP("PKG_PROFESIONAL.INSERTAR_PROFESIONAL", parameter);
                bd.ExecSP("PKG_PROFESIONAL.MODIFICAR_PROFESIONAL", parameter);
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }




        public List<Profesional> Buscar_Profecional(string rut)
        {

            List<Profesional> listaPro;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                listaPro = new List<Profesional>();
                object[] parametro = new object[2];
                parametro[0] = rut;
                parametro[1] = "PROFESIONAL";

                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_PROFESIONAL.BUSCAR_PROFESIONAL", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Profesional profecional = new Profesional();

                        profecional.idProfesional = int.Parse(dr["IDPROFESIONAL"].ToString());
                        profecional.rutProfesional = dr["RUT"].ToString();
                        profecional.nombre = dr["NOMBRE"].ToString();
                        profecional.apePaterno = dr["APEPATERNO"].ToString();
                        profecional.apeMaterno = dr["APEMATERNO"].ToString();
                        profecional.telefono = dr["TELEFONO"].ToString();
                        profecional.fechaNacimientoPro = DateTime.Parse(dr["FECNACIMIENTO"].ToString());
                        profecional.idComuna = int.Parse(dr["IDCOMUNA"].ToString());
                        profecional.idUsuario = int.Parse(dr["IDUSUARIO"].ToString());

                        listaPro.Add(profecional);
                    }
                }
                dr.Dispose();
                return listaPro;
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
