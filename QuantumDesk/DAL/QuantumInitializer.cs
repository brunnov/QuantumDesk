using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using QuantumDesk.Models;

namespace QuantumDesk.DAL
{
    public class QuantumInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<QuantumContext>
    {
        protected override void Seed(QuantumContext context)
        {
            var clientes = new List<Clientes> {
            new Clientes{ CodigoCliente=1, CpfCnpj= "06410982941", NomeRazaosocial="Feel Good Inc",Responsavel= "Fulano de Tal", StatusCliente="Ativo", EnderecoCliente="Rua tal", TelefoneCliente="21982208110", EmailCliente="killme@mailnator.com", SenhaCliente="12345" }
            };
            clientes.ForEach(s => context.Clientes.Add(s));
            context.SaveChanges();
            var contratos = new List<Contratos>
            {
             new Contratos{ CodigoContrato=1, InicioContrato=DateTime.Parse("2005-09-01"), FimContrato=DateTime.Parse("2019-11-01") }
            };
            contratos.ForEach(s => context.Contratos.Add(s));
            context.SaveChanges();

            var chamados = new List<Chamados>
            {
                new Chamados{CodigoChamado=1, DataAberturaChamado=DateTime.Parse("2005-09-01"), DataTerminoChamado=DateTime.Parse("2019-11-01"), DescricaoChamado="TESTE TESTE TESTE TESTE"   }
            };
            chamados.ForEach(s => context.Chamados.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment{CodigoCliente=1,CodigoContrato=1,CodigoChamado=1 }
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}