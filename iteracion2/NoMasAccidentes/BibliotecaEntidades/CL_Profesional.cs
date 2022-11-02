using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BibliotecaEntidades
{
    public class CL_Profesional
    {
        public int idProfesional { get; set; }
        public string rutProfesional { get; set; }
        public string nombre { get; set; }
        public string apePaterno { get; set; }
        public string apeMaterno { get; set; }
        public string telefono { get; set; }
        public DateTime fechaNacimientoPro { get; set; }
        public int idComuna { get; set; }
        
        public int idUsuario { get; set; }

        //Dalc.Entitidades cont = new Entitidades();

        //public CL_Profesional()
        //{

        //}


        //public bool AgregarProfesional()
        //{
        //    try
        //    {
        //        Dalc.PROFESIONAL prof = new PROFESIONAL();
        //        prof.RUT = rutProfesional;
        //        prof.NOMBRE = nombre;
        //        prof.APEPATERNO = apePaterno;
        //        prof.APEMATERNO = apeMaterno;
        //        prof.TELEFONO = telefono;
        //        prof.FECNACIMIENTO = fechaNacimientoPro;

        //        cont.PROFESIONAL.Add(prof);
        //        cont.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Diagnostics.Debug.WriteLine(ex);
                    
        //        return false;
        //    }
        //}
        





    }
}
