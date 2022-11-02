using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public class CL_Boleta
    {
        public int idBoleta { get; set; }
        public DateTime fechaPago { get; set; }
        public DateTime fechaLimite { get; set; }
        public int monto { get; set; }
        public bool estadoBoleta { get; set; }
        public int idPlan { get; set; }
    }
}
