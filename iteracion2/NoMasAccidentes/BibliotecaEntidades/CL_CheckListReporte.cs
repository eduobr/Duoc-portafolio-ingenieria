using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public class CL_CheckListReporte
    {
        public int idCheListRepo { get; set; }
        public int estadoCheck { get; set; }
        public DateTime fechaCheckRep { get; set; }
        public string mejora { get; set; }
        public int idCheckList { get; set; }
    }
}
