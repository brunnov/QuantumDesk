using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuantumDesk.Models
{   
    [Table("CONTRATOS")]
    public class Contratos{
    
        [Key]
        public int CodigoContrato { get; set; }
    
        public DateTime InicioContrato { get; set; }
        public DateTime FimContrato { get; set; }




        public virtual Clientes CodigoClienteNavigation { get; set; }
        public virtual ICollection<Chamados> Chamados { get; set; }
        
     }
}
