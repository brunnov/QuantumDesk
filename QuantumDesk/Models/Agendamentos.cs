using System;
using System.Collections.Generic;

namespace QuantumDesk.Models
{
    public partial class Agendamentos
    {
        public int CodigoAgendamento { get; set; }
        public int? CodigoOs { get; set; }
        public DateTime? DataAgendamento { get; set; }
        public string DescricaoAgendamento { get; set; }

        //public virtual Os CodigoOsNavigation { get; set; }
    }
}
