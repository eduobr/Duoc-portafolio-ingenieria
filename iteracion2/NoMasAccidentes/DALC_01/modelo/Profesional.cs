using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.modelo
{
    public class Profesional
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
    }
}
