using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.modelo
{
    public class Evento
    {
        public int idEvento { get; set; }
        public string asesoria { get; set; }
        public DateTime fechaEvento { get; set; }
        public int idTipoEvento { get; set; }
        public int idPlan { get; set; }
    }
}
