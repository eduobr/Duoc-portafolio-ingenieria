using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public class CL_PlanContratado
    {
        public int idPlanContra { get; set; }
        public DateTime fechaPlanContra { get; set; }
        public int precio { get; set; }
        public string sucursal { get; set; }
        public bool estadoPlanContra { get; set; }
        public int idCliente { get; set; }
        public int idProfesional { get; set; }
    }
}
