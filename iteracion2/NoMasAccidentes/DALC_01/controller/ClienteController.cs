using DALC_01.Conexion;
using DALC_01.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DALC_01.controller
{
    public class ClienteController
    {
        private Cl_Operaciones operaciones;
        dbController bd = new dbController();

        public ClienteController()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<Cliente> listarCliente()
        {

            List<Cliente> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Cliente>();
                object[] parametro = new object[1];
                parametro[0] = "CLIENTE";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_CLIENTE.LISTAR_CLIENTE", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cliente item = new Cliente();

                        item.idCliente = int.Parse(dr["IDCLIENTE"].ToString());
                        item.rutCliente = dr["RUT"].ToString();
                        item.nombre = dr["NOMBRE"].ToString();
                        item.apePaterno = dr["APEPATERNO"].ToString();
                        item.apeMaterno = dr["APEMATERNO"].ToString();
                        item.direccion = dr["DIRECCION"].ToString();
                        item.email = dr["EMAIL"].ToString();
                        item.telefono = dr["TELEFONO"].ToString();
                        item.idComuna = int.Parse(dr["IDCOMUNA"].ToString());
                        item.idRubro = int.Parse(dr["IDRUBRO"].ToString());
                        item.idUsuario = int.Parse(dr["IDUSUARIO"].ToString());

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




        public int Insert_Cliente(string rutCliente, string nombre, string apePaterno, string apeMaterno, string direccion, string email, string telefono, int idComuna, int idRubro, int idUsuario)
        {
            try
            {

                object[] parameter = new object[10];
                
                
                parameter[0] = rutCliente.ToString();
                parameter[1] = nombre.ToString();
                parameter[2] = apePaterno.ToString();
                parameter[3] = apeMaterno.ToString();
                parameter[4] = direccion.ToString();
                parameter[5] = email.ToString();
                parameter[6] = telefono.ToString();
                parameter[7] = idComuna.ToString();
                parameter[8] = idRubro.ToString();
                parameter[9] = idUsuario.ToString();
                

                bd.ExecSP("PKG_CLIENTE.INSERTAR_CLIENTE",parameter);
                return 1;


            }
            catch (Exception e)
            {
               
                return 0;
            }
        }



        public List<Cliente> BuscarCliente(string rut)
        {

            List<Cliente> list;
            Oracle.DataAccess.Client.OracleDataReader dr;
            try
            {
                operaciones.abrirConexion();
                list = new List<Cliente>();
                object[] parametro = new object[2];
                parametro[0] = rut;
                parametro[1] = "CLIENTE";
                Oracle.DataAccess.Client.OracleCommand cmd = operaciones.execSP("PKG_CLIENTE.BUSCAR_CLIENTE", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cliente item = new Cliente();

                        item.idCliente = int.Parse(dr["IDCLIENTE"].ToString());
                        item.rutCliente = dr["RUT"].ToString();
                        item.nombre = dr["NOMBRE"].ToString();
                        item.apePaterno = dr["APEPATERNO"].ToString();
                        item.apeMaterno = dr["APEMATERNO"].ToString();
                        item.direccion = dr["DIRECCION"].ToString();
                        item.email = dr["EMAIL"].ToString();
                        item.telefono = dr["TELEFONO"].ToString();
                        item.idComuna = int.Parse(dr["IDCOMUNA"].ToString());
                        item.idRubro = int.Parse(dr["IDRUBRO"].ToString());
                        item.idUsuario = int.Parse(dr["IDUSUARIO"].ToString());

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




        public int Update_Cliente(int idCliente, string rutCliente, string nombre, string apePaterno, string apeMaterno, string direccion, string email, string telefono, int idComuna, int idRubro, int idUsuario)
        {
            try
            {

                object[] parameter = new object[11];


                parameter[0] = idCliente.ToString();
                parameter[1] = rutCliente.ToString();
                parameter[2] = nombre.ToString();
                parameter[3] = apePaterno.ToString();
                parameter[4] = apeMaterno.ToString();
                parameter[5] = direccion.ToString();
                parameter[6] = email.ToString();
                parameter[7] = telefono.ToString();
                parameter[8] = idComuna.ToString();
                parameter[9] = idRubro.ToString();
                parameter[10] = idUsuario.ToString();


                bd.ExecSP("PKG_CLIENTE.MODIFICAR_CLIENTE", parameter);
                return 1;


            }
            catch (Exception e)
            {

                return 0;
            }
        }



    }
}
