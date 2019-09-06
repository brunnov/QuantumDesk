using System;
using System.Collections.Generic;

namespace QuantumDesk.Models
{
    public partial class FormaPagamento
    {
        public FormaPagamento()
        {
            Clientes = new HashSet<Clientes>();
        }

        public int CodigoFormaPagamento { get; set; }
        public string DescricaoFormaPagamento { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
    }
}
