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
    
    public partial class QuantumContext : DbContext
    {
        public QuantumContext()
            : base("name=QuantumContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AGENDAMENTOS> AGENDAMENTOS { get; set; }
        public virtual DbSet<ANALISTAS> ANALISTAS { get; set; }
        public virtual DbSet<CHAMADOS> CHAMADOS { get; set; }
        public virtual DbSet<CLIENTES> CLIENTES { get; set; }
        public virtual DbSet<CONTRATOS> CONTRATOS { get; set; }
        public virtual DbSet<ESPECIALIDADES> ESPECIALIDADES { get; set; }
        public virtual DbSet<FORMA_PAGAMENTO> FORMA_PAGAMENTO { get; set; }
        public virtual DbSet<OS> OS { get; set; }
        public virtual DbSet<SERVICOS> SERVICOS { get; set; }
        public virtual DbSet<STATUS_CHAMADOS> STATUS_CHAMADOS { get; set; }
        public virtual DbSet<STATUS_OS> STATUS_OS { get; set; }
        public virtual DbSet<STATUS_USUARIOS> STATUS_USUARIOS { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
    }
}