using System;
using System.Collections.Generic;

namespace QuantumDesk.Models
{
    public partial class StatusOs
    {
        public StatusOs()
        {
            //Os = new HashSet<Os>();
        }

        public int CodigoStatusOs { get; set; }
        public string DescricaoStatusOs { get; set; }

        //public virtual ICollection<Os> Os { get; set; }
    }
}
