using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public class CL_Cliente
    {
        public int idCliente { get; set; }
        public string rutCliente { get; set; }
        public string nombre { get; set; }
        public string apePaterno { get; set; }
        public string apeMaterno { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public int idComuna { get; set; }
        public int idRubro { get; set; }
        public int idUsuario { get; set; }
    }
}
