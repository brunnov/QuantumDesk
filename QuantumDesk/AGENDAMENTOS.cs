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
    
    public partial class AGENDAMENTOS
    {
        public int CODIGO_AGENDAMENTO { get; set; }
        public Nullable<int> CODIGO_OS { get; set; }
        public Nullable<System.DateTime> DATA_AGENDAMENTO { get; set; }
        public string DESCRICAO_AGENDAMENTO { get; set; }
    
        public virtual OS OS { get; set; }
    }
}