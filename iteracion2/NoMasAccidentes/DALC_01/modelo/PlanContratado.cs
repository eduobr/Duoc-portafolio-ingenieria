using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.modelo
{
    public class PlanContratado
    {
        public int idPlanContra { get; set; }
        public DateTime fechaPlanContra { get; set; }
        public int precio { get; set; }
        public string sucursal { get; set; }
        public int estadoPlanContra { get; set; }
        public int idCliente { get; set; }
        public int idProfesional { get; set; }
    }
}
