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
    
    public partial class FORMA_PAGAMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORMA_PAGAMENTO()
        {
            this.CLIENTES = new HashSet<CLIENTES>();
        }
    
        public int CODIGO_FORMA_PAGAMENTO { get; set; }
        public string DESCRICAO_FORMA_PAGAMENTO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTES> CLIENTES { get; set; }
    }
}