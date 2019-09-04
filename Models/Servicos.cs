using System;
using System.Collections.Generic;

namespace QuantumDesk.Models
{
    public partial class Servicos
    {
        public Servicos()
        {
            Os = new HashSet<Os>();
        }

        public int CodigoServico { get; set; }
        public string DescricaoServico { get; set; }

        public virtual ICollection<Os> Os { get; set; }
    }
}
