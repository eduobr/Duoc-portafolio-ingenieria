using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public class CL_Usuario
    {
        public int idUsuiario { get; set; }
        public string usu { get; set; }
        public string pass { get; set; }
        public int estadoUsu { get; set; }
        public int idTipoUsu { get; set; }

        public CL_Usuario()
        {

        }

        //Dalc.Entitidades contexto = new Entitidades();
        //public bool crearUsuario()
        //{
        //    try
        //    {
        //        Dalc.USUARIO usua = new USUARIO();
        //        usua.USU = usu;
        //        usua.PASS = pass;
        //        usua.ESTADOUSUARIO = 1;
        //        usua.IDTIPOUSUARIO = 1;

        //        contexto.USUARIO.Add(usua);
        //        contexto.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {

        //        return false;
        //    }
        //}


    }
}
