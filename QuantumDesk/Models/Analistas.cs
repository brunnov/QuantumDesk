using System;
using System.Collections.Generic;

namespace QuantumDesk.Models
{
    public partial class Analistas
    {
        public Analistas()
        {
            //Os = new HashSet<Os>();
        }

        public int MatriculaAnalista { get; set; }
        public int? IdUsuario { get; set; }
        public int? Gerente { get; set; }
        public int? CargaHoraria { get; set; }
        public int? CodigoEspecialidade { get; set; }

        public virtual Especialidades CodigoEspecialidadeNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
        //public virtual ICollection<Os> Os { get; set; }
    }
}
