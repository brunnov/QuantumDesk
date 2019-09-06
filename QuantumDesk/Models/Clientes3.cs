//using System;
//using System.Collections.Generic;

//namespace QuantumDesk.Models
//{
//    public partial class Clientes
//    {

//        public Clientes()
//        {
//            Contratos = new HashSet<Contratos>();
//        }

//        public int CodigoCliente { get; set; }
//        public int? IdUsuario { get; set; }
//        public string Responsavel { get; set; }
//        public int? CodigoFormaPagamento { get; set; }
//        public int? DiaPagamento { get; set; }

//        public virtual FormaPagamento CodigoFormaPagamentoNavigation { get; set; }
//        public virtual Usuarios IdUsuarioNavigation { get; set; }
//        public virtual ICollection<Contratos> Contratos { get; set; }
//    }
//}
