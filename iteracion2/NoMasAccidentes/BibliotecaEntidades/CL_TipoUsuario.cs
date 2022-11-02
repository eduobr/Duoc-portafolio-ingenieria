using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public class CL_TipoUsuario
    {
        public int idTIpoUsu { get; set; }
        public string descTipoUsu { get; set; }

        public CL_TipoUsuario()
        {

        }

    //    Dalc.Entitidades cont = new Dalc.Entitidades();

    //    public bool CrearTipoUsuario()
    //    {
    //        try
    //        {
    //            Dalc.TIPOUSUARIO tipoUsu = new Dalc.TIPOUSUARIO();
    //            tipoUsu.DESCRIPCION = descTipoUsu;
    //            cont.TIPOUSUARIO.Add(tipoUsu);
    //            cont.SaveChanges();
    //            return true;
    //        }
    //        catch (Exception)
    //        {

    //            return false;
    //        }
    //    }

    }
}
