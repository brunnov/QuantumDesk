using QuantumDesk.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace QuantumDesk.DAL
{
    public class QuantumContext : DbContext
    {
        public QuantumContext() : base("QuantumContext")
        {

        }
        public DbSet<Chamados> Chamados { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Contratos> Contratos { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}

    }
}