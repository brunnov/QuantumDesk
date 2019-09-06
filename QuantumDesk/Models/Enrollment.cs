using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuantumDesk.Models
{
    
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoContrato { get; set; }
        public int CodigoChamado { get; set; }
        public virtual Clientes Clientes { get; set; }
        public virtual Contratos Contratos { get; set; }
        

    }

    
}