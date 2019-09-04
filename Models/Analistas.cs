using System;
using System.Collections.Generic;

namespace QuantumDesk.Models
{
    public partial class Analistas
    {
        public Analistas()
        {
            Os = new HashSet<Os>();
        }

        public int MatriculaAnalista { get; set; }
        public string Cpf { get; set; }
        public string NomeAnalista { get; set; }
        public string Gerente { get; set; }
        public int? CargaHoraria { get; set; }
        public int? CodigoEspecialidade { get; set; }
        public string StatusAnalista { get; set; }
        public string EnderecoAnalista { get; set; }
        public string TelefoneAnalista { get; set; }
        public string EmailAnalista { get; set; }
        public string SenhaAnalista { get; set; }

        public virtual Especialidades CodigoEspecialidadeNavigation { get; set; }
        public virtual ICollection<Os> Os { get; set; }
    }
}
