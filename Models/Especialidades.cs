using System;
using System.Collections.Generic;

namespace QuantumDesk.Models
{
    public partial class Especialidades
    {
        public Especialidades()
        {
            Analistas = new HashSet<Analistas>();
        }

        public int CodigoEspecialidade { get; set; }
        public string DescricaoEspecialidade { get; set; }

        public virtual ICollection<Analistas> Analistas { get; set; }
    }
}
