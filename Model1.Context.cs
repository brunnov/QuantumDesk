﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PROJETOQUANTUMEntities : DbContext
    {
        public PROJETOQUANTUMEntities()
            : base("name=PROJETOQUANTUMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AGENDAMENTO> AGENDAMENTOS { get; set; }
        public virtual DbSet<ANALISTA> ANALISTAS { get; set; }
        public virtual DbSet<CHAMADO> CHAMADOS { get; set; }
        public virtual DbSet<CLIENTE> CLIENTES { get; set; }
        public virtual DbSet<CONTRATO> CONTRATOS { get; set; }
        public virtual DbSet<ESPECIALIDADE> ESPECIALIDADES { get; set; }
        public virtual DbSet<O> OS { get; set; }
        public virtual DbSet<SERVICO> SERVICOS { get; set; }
        public virtual DbSet<USUARIO> USUARIOS { get; set; }
    }
}
