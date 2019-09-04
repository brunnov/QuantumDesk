using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QuantumDesk.Models
{
    public partial class PROJETOQUANTUMContext : DbContext
    {
        public PROJETOQUANTUMContext()
        {
        }

        public PROJETOQUANTUMContext(DbContextOptions<PROJETOQUANTUMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agendamentos> Agendamento { get; set; }
        public virtual DbSet<Analistas> Analista { get; set; }
        public virtual DbSet<Chamados> Chamado { get; set; }
        public virtual DbSet<Clientes> Cliente { get; set; }
        public virtual DbSet<Contratos> Contrato { get; set; }
        public virtual DbSet<Especialidades> Especialidade { get; set; }
        public virtual DbSet<Os> Os { get; set; }
        public virtual DbSet<Servicos> Servico { get; set; }
        public virtual DbSet<Usuarios> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=PROJETOQUANTUM;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Agendamentos>(entity =>
            {
                entity.HasKey(e => e.CodigoAgendamento)
                    .HasName("PK__AGENDAME__57DDDA069A979F14");

                entity.ToTable("AGENDAMENTOS");

                entity.Property(e => e.CodigoAgendamento).HasColumnName("CODIGO_AGENDAMENTO");

                entity.Property(e => e.CodigoOs).HasColumnName("CODIGO_OS");

                entity.Property(e => e.DataAgendamento)
                    .HasColumnName("DATA_AGENDAMENTO")
                    .HasColumnType("date");

                entity.Property(e => e.DescricaoAgendamento)
                    .HasColumnName("DESCRICAO_AGENDAMENTO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusAgendamento)
                    .HasColumnName("STATUS_AGENDAMENTO")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoOsNavigation)
                    .WithMany(p => p.Agendamentos)
                    .HasForeignKey(d => d.CodigoOs)
                    .HasConstraintName("FK__AGENDAMEN__CODIG__3C34F16F");
            });

            modelBuilder.Entity<Analistas>(entity =>
            {
                entity.HasKey(e => e.MatriculaAnalista)
                    .HasName("PK__ANALISTA__C45D401C570A9444");

                entity.ToTable("ANALISTAS");

                entity.Property(e => e.MatriculaAnalista).HasColumnName("MATRICULA_ANALISTA");

                entity.Property(e => e.CargaHoraria).HasColumnName("CARGA_HORARIA");

                entity.Property(e => e.CodigoEspecialidade).HasColumnName("CODIGO_ESPECIALIDADE");

                entity.Property(e => e.Cpf)
                    .HasColumnName("CPF")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAnalista)
                    .HasColumnName("EMAIL_ANALISTA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoAnalista)
                    .HasColumnName("ENDERECO_ANALISTA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gerente)
                    .HasColumnName("GERENTE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NomeAnalista)
                    .HasColumnName("NOME_ANALISTA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SenhaAnalista)
                    .HasColumnName("SENHA_ANALISTA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatusAnalista)
                    .HasColumnName("STATUS_ANALISTA")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TelefoneAnalista)
                    .HasColumnName("TELEFONE_ANALISTA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoEspecialidadeNavigation)
                    .WithMany(p => p.Analistas)
                    .HasForeignKey(d => d.CodigoEspecialidade)
                    .HasConstraintName("FK__ANALISTAS__CODIG__2CF2ADDF");
            });

            modelBuilder.Entity<Chamados>(entity =>
            {
                entity.HasKey(e => e.CodigoChamado)
                    .HasName("PK__CHAMADOS__73D200B4FD02EB83");

                entity.ToTable("CHAMADOS");

                entity.Property(e => e.CodigoChamado).HasColumnName("CODIGO_CHAMADO");

                entity.Property(e => e.CodigoContrato).HasColumnName("CODIGO_CONTRATO");

                entity.Property(e => e.DataAberturaChamado)
                    .HasColumnName("DATA_ABERTURA_CHAMADO")
                    .HasColumnType("date");

                entity.Property(e => e.DataTerminoChamado)
                    .HasColumnName("DATA_TERMINO_CHAMADO")
                    .HasColumnType("date");

                entity.Property(e => e.DescricaoChamado)
                    .HasColumnName("DESCRICAO_CHAMADO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusChamado)
                    .HasColumnName("STATUS_CHAMADO")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoContratoNavigation)
                    .WithMany(p => p.Chamados)
                    .HasForeignKey(d => d.CodigoContrato)
                    .HasConstraintName("FK__CHAMADOS__CODIGO__3493CFA7");
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.CodigoCliente)
                    .HasName("PK__CLIENTES__934C3A686EC97CD8");

                entity.ToTable("CLIENTES");

                entity.Property(e => e.CodigoCliente).HasColumnName("CODIGO_CLIENTE");

                entity.Property(e => e.CpfCnpj)
                    .HasColumnName("CPF_CNPJ")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EmailCliente)
                    .HasColumnName("EMAIL_CLIENTE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EnderecoCliente)
                    .HasColumnName("ENDERECO_CLIENTE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomeRazaosocial)
                    .HasColumnName("NOME_RAZAOSOCIAL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Responsavel)
                    .HasColumnName("RESPONSAVEL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SenhaCliente)
                    .HasColumnName("SENHA_CLIENTE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCliente)
                    .HasColumnName("STATUS_CLIENTE")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TelefoneCliente)
                    .HasColumnName("TELEFONE_CLIENTE")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contratos>(entity =>
            {
                entity.HasKey(e => e.CodigoContrato)
                    .HasName("PK__CONTRATO__F9ACAB35E7AFE03C");

                entity.ToTable("CONTRATOS");

                entity.Property(e => e.CodigoContrato).HasColumnName("CODIGO_CONTRATO");

                entity.Property(e => e.CodigoCliente).HasColumnName("CODIGO_CLIENTE");

                entity.Property(e => e.FimContrato)
                    .HasColumnName("FIM_CONTRATO")
                    .HasColumnType("date");

                entity.Property(e => e.InicioContrato)
                    .HasColumnName("INICIO_CONTRATO")
                    .HasColumnType("date");

                entity.HasOne(d => d.CodigoClienteNavigation)
                    .WithMany(p => p.Contratos)
                    .HasForeignKey(d => d.CodigoCliente)
                    .HasConstraintName("FK__CONTRATOS__CODIG__31B762FC");
            });

            modelBuilder.Entity<Especialidades>(entity =>
            {
                entity.HasKey(e => e.CodigoEspecialidade)
                    .HasName("PK__ESPECIAL__BE3EB32E8B29AEAB");

                entity.ToTable("ESPECIALIDADES");

                entity.Property(e => e.CodigoEspecialidade).HasColumnName("CODIGO_ESPECIALIDADE");

                entity.Property(e => e.DescricaoEspecialidade)
                    .HasColumnName("DESCRICAO_ESPECIALIDADE")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Os>(entity =>
            {
                entity.HasKey(e => e.CodigoOs)
                    .HasName("PK__OS__77CC39437372E4C0");

                entity.ToTable("OS");

                entity.Property(e => e.CodigoOs).HasColumnName("CODIGO_OS");

                entity.Property(e => e.CodigoChamado).HasColumnName("CODIGO_CHAMADO");

                entity.Property(e => e.CodigoServico).HasColumnName("CODIGO_SERVICO");

                entity.Property(e => e.DataAberturaOs)
                    .HasColumnName("DATA_ABERTURA_OS")
                    .HasColumnType("date");

                entity.Property(e => e.DataTerminoOs)
                    .HasColumnName("DATA_TERMINO_OS")
                    .HasColumnType("date");

                entity.Property(e => e.DescricaoOs)
                    .HasColumnName("DESCRICAO_OS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MatriculaAnalista).HasColumnName("MATRICULA_ANALISTA");

                entity.Property(e => e.Prioridade)
                    .HasColumnName("PRIORIDADE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StatusOs)
                    .HasColumnName("STATUS_OS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodigoChamadoNavigation)
                    .WithMany(p => p.Os)
                    .HasForeignKey(d => d.CodigoChamado)
                    .HasConstraintName("FK__OS__CODIGO_CHAMA__37703C52");

                entity.HasOne(d => d.CodigoServicoNavigation)
                    .WithMany(p => p.Os)
                    .HasForeignKey(d => d.CodigoServico)
                    .HasConstraintName("FK__OS__CODIGO_SERVI__395884C4");

                entity.HasOne(d => d.MatriculaAnalistaNavigation)
                    .WithMany(p => p.Os)
                    .HasForeignKey(d => d.MatriculaAnalista)
                    .HasConstraintName("FK__OS__MATRICULA_AN__3864608B");
            });

            modelBuilder.Entity<Servicos>(entity =>
            {
                entity.HasKey(e => e.CodigoServico)
                    .HasName("PK__SERVICOS__94D9994733E4589D");

                entity.ToTable("SERVICOS");

                entity.Property(e => e.CodigoServico).HasColumnName("CODIGO_SERVICO");

                entity.Property(e => e.DescricaoServico)
                    .HasColumnName("DESCRICAO_SERVICO")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__USUARIOS__91136B90E30FA4AD");

                entity.ToTable("USUARIOS");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_USUARIO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Senha)
                    .HasColumnName("SENHA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
        }
    }
}
