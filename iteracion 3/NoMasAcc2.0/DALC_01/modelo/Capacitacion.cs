using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.modelo
{
    public class Capacitacion
    {
        public int idCapacitacion { get; set; }
        public DateTime fechaCapacitacion { get; set; }
        public string desCapacitacion { get; set; }
        public int cantAsistentes { get; set; }
        public int idplan { get; set; }
        public string rutCliente { get; set; }
        public string rutProfesional { get; set; }
    }
}
