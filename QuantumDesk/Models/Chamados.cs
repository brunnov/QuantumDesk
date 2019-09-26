using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuantumDesk.Models
{
    //[Table("CHAMADOS")]
    public class Chamados
    {
        //public Chamados()
        //{
        //    Os = new HashSet<Os>();
        //}


        [Key]
        public int CodigoChamado { get; set; }
        public int CodigoContrato { get; set; }

       
        public DateTime DataAberturaChamado { get; set; }

      
        public DateTime DataTerminoChamado { get; set; }
        public string StatusChamado { get; set; }
        public string DescricaoChamado { get; set; }

        public virtual Contratos CodigoContratoNavigation { get; set; }

        public virtual Clientes CodigoClienteNavigation { get; set; }
        //public virtual ICollection<Os> Os { get; set; }
    }
}

