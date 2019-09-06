//using System;
//using System.Collections.Generic;

//namespace QuantumDesk.Models
//{
//    public partial class Chamados
//    {
//        public Chamados()
//        {
//            Os = new HashSet<Os>();
//        }

//        public int CodigoChamado { get; set; }
//        public int? CodigoContrato { get; set; }
//        public DateTime? DataAberturaChamado { get; set; }
//        public DateTime? DataTerminoChamado { get; set; }
//        public int? CodigoStatusChamados { get; set; }
//        public string DescricaoChamado { get; set; }

//        public virtual Contratos CodigoContratoNavigation { get; set; }
//        public virtual StatusChamados CodigoStatusChamadosNavigation { get; set; }
//        public virtual ICollection<Os> Os { get; set; }
//    }
//}
