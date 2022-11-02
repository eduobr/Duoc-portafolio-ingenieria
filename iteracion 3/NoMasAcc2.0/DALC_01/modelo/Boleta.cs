using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.modelo
{
    public class Boleta
    {
        public int idBoleta { get; set; }
        public string rutCliente { get; set; }
        public string nombreCliente { get; set; }
        public DateTime fechaLimite { get; set; }
        public string estado { get; set; }
        public int idPlan { get; set; }

        public string estadoServicio { get; set; }

    }
}
