using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeClaudio.model
{
    internal class Movimentacao
    {
        public int id { get; set; }
        public string tipoMovimentacao { get; set;}
        public string dataInicio { get; set; }
        public string dataFim {  get; set; }
        public int idConteiner { get; set; }
        public int idCliente { get; set; }
    }
}
