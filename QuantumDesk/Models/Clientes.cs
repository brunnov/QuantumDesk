using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuantumDesk.Models
{
    [Table("CLIENTES")]
    public class Clientes
    {
        [Key]
        public int CodigoCliente { get; set; }
        public string CpfCnpj { get; set; }
        public string NomeRazaosocial { get; set; }
        public string Responsavel { get; set; }
        public string StatusCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public string EmailCliente { get; set; }
        public string SenhaCliente { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}