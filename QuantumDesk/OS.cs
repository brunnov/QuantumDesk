//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuantumDesk
{
    using System;
    using System.Collections.Generic;
    
    public partial class OS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OS()
        {
            this.AGENDAMENTOS = new HashSet<AGENDAMENTOS>();
        }
    
        public int CODIGO_OS { get; set; }
        public Nullable<int> CODIGO_CHAMADO { get; set; }
        public Nullable<System.DateTime> DATA_ABERTURA_OS { get; set; }
        public Nullable<System.DateTime> DATA_TERMINO_OS { get; set; }
        public Nullable<int> CODIGO_STATUS_OS { get; set; }
        public Nullable<int> MATRICULA_ANALISTA { get; set; }
        public Nullable<int> CODIGO_PRIORIDADE { get; set; }
        public Nullable<int> CODIGO_SERVICO { get; set; }
        public string DESCRICAO_OS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENDAMENTOS> AGENDAMENTOS { get; set; }
        public virtual ANALISTAS ANALISTAS { get; set; }
        public virtual CHAMADOS CHAMADOS { get; set; }
        public virtual PRIORIDADES PRIORIDADES { get; set; }
        public virtual SERVICOS SERVICOS { get; set; }
        public virtual STATUS_OS STATUS_OS { get; set; }
    }
}
