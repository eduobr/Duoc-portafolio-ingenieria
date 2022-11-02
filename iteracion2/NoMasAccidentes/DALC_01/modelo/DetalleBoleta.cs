using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.modelo
{
    public class DetalleBoleta
    {
        public int idDetalleBoleta { get; set; }
        public int precio { get; set; }
        public int idBoleta { get; set; }
        public int idServicio { get; set; }
    }
}
