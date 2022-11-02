using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public class CL_CheckList
    {
        public int idCheck { get; set; }
        public string descCheckList { get; set; }
        public int estadoCheck { get; set; }
        public int idPlan { get; set; }
    }
}
