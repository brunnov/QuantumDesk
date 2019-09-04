using System;
using System.Collections.Generic;

namespace QuantumDesk.Models
{
    public partial class Clientes
    {
        public Clientes()
        {
            Contratos = new HashSet<Contratos>();
        }

        public int CodigoCliente { get; set; }
        public string CpfCnpj { get; set; }
        public string NomeRazaosocial { get; set; }
        public string Responsavel { get; set; }
        public string StatusCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public string EmailCliente { get; set; }
        public string SenhaCliente { get; set; }

        public virtual ICollection<Contratos> Contratos { get; set; }
    }
}
