using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC_01.modelo
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string rutCliente { get; set; }
        public string nombre { get; set; }

        public string empresa { get; set; }
        public string direccion { get; set; }
    }
}
