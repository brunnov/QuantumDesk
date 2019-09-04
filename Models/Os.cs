using System;
using System.Collections.Generic;

namespace QuantumDesk.Models
{
    public partial class Os
    {
        public Os()
        {
            Agendamentos = new HashSet<Agendamentos>();
        }

        public int CodigoOs { get; set; }
        public int? CodigoChamado { get; set; }
        public DateTime? DataAberturaOs { get; set; }
        public DateTime? DataTerminoOs { get; set; }
        public string StatusOs { get; set; }
        public int? MatriculaAnalista { get; set; }
        public string Prioridade { get; set; }
        public int? CodigoServico { get; set; }
        public string DescricaoOs { get; set; }

        public virtual Chamados CodigoChamadoNavigation { get; set; }
        public virtual Servicos CodigoServicoNavigation { get; set; }
        public virtual Analistas MatriculaAnalistaNavigation { get; set; }
        public virtual ICollection<Agendamentos> Agendamentos { get; set; }
    }
}
