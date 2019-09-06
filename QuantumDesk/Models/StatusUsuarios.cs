using System;
using System.Collections.Generic;

namespace QuantumDesk.Models
{
    public partial class StatusUsuarios
    {
        public StatusUsuarios()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int CodigoStatusUsuarios { get; set; }
        public string DescricaoStatusUsuarios { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
