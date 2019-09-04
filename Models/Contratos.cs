using System;
using System.Collections.Generic;

namespace QuantumDesk.Models
{
    public partial class Contratos
    {
        public Contratos()
        {
            Chamados = new HashSet<Chamados>();
        }

        public int CodigoContrato { get; set; }
        public int? CodigoCliente { get; set; }
        public DateTime? InicioContrato { get; set; }
        public DateTime? FimContrato { get; set; }

        public virtual Clientes CodigoClienteNavigation { get; set; }
        public virtual ICollection<Chamados> Chamados { get; set; }
    }
}
