using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeClaudio.model
{
    internal class Conteiner
    {
        public int id_conteiner {  get; set; }
        public string codigoConteiner { get; set; }
        public string tipo {  get; set; }
        public string estado { get; set; }
        public string categoria { get; set; }
        public int id_cliente { get; set; }
    }
}
