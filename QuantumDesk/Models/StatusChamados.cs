using System;
using System.Collections.Generic;

namespace QuantumDesk.Models
{
    public partial class StatusChamados
    {
        public StatusChamados()
        {
            Chamados = new HashSet<Chamados>();
        }

        public int CodigoStatusChamados { get; set; }
        public string DescricaoStatusChamados { get; set; }

        public virtual ICollection<Chamados> Chamados { get; set; }
    }
}
