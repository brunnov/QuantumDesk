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
    
    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            this.CONTRATOS = new HashSet<CONTRATO>();
        }
    
        public int CODIGO_CLIENTE { get; set; }
        public string CPF_CNPJ { get; set; }
        public string NOME_RAZAOSOCIAL { get; set; }
        public string RESPONSAVEL { get; set; }
        public string STATUS_CLIENTE { get; set; }
        public string ENDERECO_CLIENTE { get; set; }
        public string TELEFONE_CLIENTE { get; set; }
        public string EMAIL_CLIENTE { get; set; }
        public string SENHA_CLIENTE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATO> CONTRATOS { get; set; }
    }
}
