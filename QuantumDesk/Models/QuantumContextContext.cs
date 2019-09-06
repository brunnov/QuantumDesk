//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

//namespace QuantumDesk.Models
//{
//    public partial class QuantumContextContext : DbContext
//    {
//        public QuantumContextContext()
//        {
//        }

//        public QuantumContextContext(DbContextOptions<QuantumContextContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<Agendamentos> Agendamentos { get; set; }
//        public virtual DbSet<Analistas> Analistas { get; set; }
//        public virtual DbSet<Chamados> Chamados { get; set; }
//        public virtual DbSet<Clientes> Clientes { get; set; }
//        public virtual DbSet<Contratos> Contratos { get; set; }
//        public virtual DbSet<Especialidades> Especialidades { get; set; }
//        public virtual DbSet<FormaPagamento> FormaPagamento { get; set; }
//        public virtual DbSet<Os> Os { get; set; }
//        public virtual DbSet<Servicos> Servicos { get; set; }
//        public virtual DbSet<StatusChamados> StatusChamados { get; set; }
//        public virtual DbSet<StatusOs> StatusOs { get; set; }
//        public virtual DbSet<StatusUsuarios> StatusUsuarios { get; set; }
//        public virtual DbSet<Usuarios> Usuarios { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=QuantumContext;Trusted_Connection=True;");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

//            modelBuilder.Entity<Agendamentos>(entity =>
//            {
//                entity.HasKey(e => e.CodigoAgendamento)
//                    .HasName("PK__AGENDAME__57DDDA062274C179");

//                entity.ToTable("AGENDAMENTOS");

//                entity.Property(e => e.CodigoAgendamento).HasColumnName("CODIGO_AGENDAMENTO");

//                entity.Property(e => e.CodigoOs).HasColumnName("CODIGO_OS");

//                entity.Property(e => e.DataAgendamento)
//                    .HasColumnName("DATA_AGENDAMENTO")
//                    .HasColumnType("date");

//                entity.Property(e => e.DescricaoAgendamento)
//                    .HasColumnName("DESCRICAO_AGENDAMENTO")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.HasOne(d => d.CodigoOsNavigation)
//                    .WithMany(p => p.Agendamentos)
//                    .HasForeignKey(d => d.CodigoOs)
//                    .HasConstraintName("FK__AGENDAMEN__CODIG__45F365D3");
//            });

//            modelBuilder.Entity<Analistas>(entity =>
//            {
//                entity.HasKey(e => e.MatriculaAnalista)
//                    .HasName("PK__ANALISTA__C45D401C47FC3FAA");

//                entity.ToTable("ANALISTAS");

//                entity.Property(e => e.MatriculaAnalista).HasColumnName("MATRICULA_ANALISTA");

//                entity.Property(e => e.CargaHoraria).HasColumnName("CARGA_HORARIA");

//                entity.Property(e => e.CodigoEspecialidade).HasColumnName("CODIGO_ESPECIALIDADE");

//                entity.Property(e => e.Gerente).HasColumnName("GERENTE");

//                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

//                entity.HasOne(d => d.CodigoEspecialidadeNavigation)
//                    .WithMany(p => p.Analistas)
//                    .HasForeignKey(d => d.CodigoEspecialidade)
//                    .HasConstraintName("FK__ANALISTAS__CODIG__32E0915F");

//                entity.HasOne(d => d.IdUsuarioNavigation)
//                    .WithMany(p => p.Analistas)
//                    .HasForeignKey(d => d.IdUsuario)
//                    .HasConstraintName("FK__ANALISTAS__ID_US__31EC6D26");
//            });

//            modelBuilder.Entity<Chamados>(entity =>
//            {
//                entity.HasKey(e => e.CodigoChamado)
//                    .HasName("PK__CHAMADOS__73D200B474814C04");

//                entity.ToTable("CHAMADOS");

//                entity.Property(e => e.CodigoChamado).HasColumnName("CODIGO_CHAMADO");

//                entity.Property(e => e.CodigoContrato).HasColumnName("CODIGO_CONTRATO");

//                entity.Property(e => e.CodigoStatusChamados).HasColumnName("CODIGO_STATUS_CHAMADOS");

//                entity.Property(e => e.DataAberturaChamado)
//                    .HasColumnName("DATA_ABERTURA_CHAMADO")
//                    .HasColumnType("date");

//                entity.Property(e => e.DataTerminoChamado)
//                    .HasColumnName("DATA_TERMINO_CHAMADO")
//                    .HasColumnType("date");

//                entity.Property(e => e.DescricaoChamado)
//                    .HasColumnName("DESCRICAO_CHAMADO")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.HasOne(d => d.CodigoContratoNavigation)
//                    .WithMany(p => p.Chamados)
//                    .HasForeignKey(d => d.CodigoContrato)
//                    .HasConstraintName("FK__CHAMADOS__CODIGO__3C69FB99");

//                entity.HasOne(d => d.CodigoStatusChamadosNavigation)
//                    .WithMany(p => p.Chamados)
//                    .HasForeignKey(d => d.CodigoStatusChamados)
//                    .HasConstraintName("FK__CHAMADOS__CODIGO__3D5E1FD2");
//            });

//            modelBuilder.Entity<Clientes>(entity =>
//            {
//                entity.HasKey(e => e.CodigoCliente)
//                    .HasName("PK__CLIENTES__934C3A684887D316");

//                entity.ToTable("CLIENTES");

//                entity.Property(e => e.CodigoCliente).HasColumnName("CODIGO_CLIENTE");

//                entity.Property(e => e.CodigoFormaPagamento).HasColumnName("CODIGO_FORMA_PAGAMENTO");

//                entity.Property(e => e.DiaPagamento).HasColumnName("DIA_PAGAMENTO");

//                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

//                entity.Property(e => e.Responsavel)
//                    .HasColumnName("RESPONSAVEL")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.HasOne(d => d.CodigoFormaPagamentoNavigation)
//                    .WithMany(p => p.Clientes)
//                    .HasForeignKey(d => d.CodigoFormaPagamento)
//                    .HasConstraintName("FK__CLIENTES__CODIGO__36B12243");

//                entity.HasOne(d => d.IdUsuarioNavigation)
//                    .WithMany(p => p.Clientes)
//                    .HasForeignKey(d => d.IdUsuario)
//                    .HasConstraintName("FK__CLIENTES__ID_USU__35BCFE0A");
//            });

//            modelBuilder.Entity<Contratos>(entity =>
//            {
//                entity.HasKey(e => e.CodigoContrato)
//                    .HasName("PK__CONTRATO__F9ACAB359EE87944");

//                entity.ToTable("CONTRATOS");

//                entity.Property(e => e.CodigoContrato).HasColumnName("CODIGO_CONTRATO");

//                entity.Property(e => e.CodigoCliente).HasColumnName("CODIGO_CLIENTE");

//                entity.Property(e => e.FimContrato)
//                    .HasColumnName("FIM_CONTRATO")
//                    .HasColumnType("date");

//                entity.Property(e => e.InicioContrato)
//                    .HasColumnName("INICIO_CONTRATO")
//                    .HasColumnType("date");

//                entity.HasOne(d => d.CodigoClienteNavigation)
//                    .WithMany(p => p.Contratos)
//                    .HasForeignKey(d => d.CodigoCliente)
//                    .HasConstraintName("FK__CONTRATOS__CODIG__398D8EEE");
//            });

//            modelBuilder.Entity<Especialidades>(entity =>
//            {
//                entity.HasKey(e => e.CodigoEspecialidade)
//                    .HasName("PK__ESPECIAL__BE3EB32E8503CF7B");

//                entity.ToTable("ESPECIALIDADES");

//                entity.Property(e => e.CodigoEspecialidade).HasColumnName("CODIGO_ESPECIALIDADE");

//                entity.Property(e => e.DescricaoEspecialidade)
//                    .HasColumnName("DESCRICAO_ESPECIALIDADE")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<FormaPagamento>(entity =>
//            {
//                entity.HasKey(e => e.CodigoFormaPagamento)
//                    .HasName("PK__FORMA_PA__CDF88A73CB4BFC86");

//                entity.ToTable("FORMA_PAGAMENTO");

//                entity.Property(e => e.CodigoFormaPagamento).HasColumnName("CODIGO_FORMA_PAGAMENTO");

//                entity.Property(e => e.DescricaoFormaPagamento)
//                    .HasColumnName("DESCRICAO_FORMA_PAGAMENTO")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Os>(entity =>
//            {
//                entity.HasKey(e => e.CodigoOs)
//                    .HasName("PK__OS__77CC3943FCE020EC");

//                entity.ToTable("OS");

//                entity.Property(e => e.CodigoOs).HasColumnName("CODIGO_OS");

//                entity.Property(e => e.CodigoChamado).HasColumnName("CODIGO_CHAMADO");

//                entity.Property(e => e.CodigoServico).HasColumnName("CODIGO_SERVICO");

//                entity.Property(e => e.CodigoStatusOs).HasColumnName("CODIGO_STATUS_OS");

//                entity.Property(e => e.DataAberturaOs)
//                    .HasColumnName("DATA_ABERTURA_OS")
//                    .HasColumnType("date");

//                entity.Property(e => e.DataTerminoOs)
//                    .HasColumnName("DATA_TERMINO_OS")
//                    .HasColumnType("date");

//                entity.Property(e => e.DescricaoOs)
//                    .HasColumnName("DESCRICAO_OS")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.MatriculaAnalista).HasColumnName("MATRICULA_ANALISTA");

//                entity.Property(e => e.Prioridade)
//                    .HasColumnName("PRIORIDADE")
//                    .HasMaxLength(5)
//                    .IsUnicode(false);

//                entity.HasOne(d => d.CodigoChamadoNavigation)
//                    .WithMany(p => p.Os)
//                    .HasForeignKey(d => d.CodigoChamado)
//                    .HasConstraintName("FK__OS__CODIGO_CHAMA__403A8C7D");

//                entity.HasOne(d => d.CodigoServicoNavigation)
//                    .WithMany(p => p.Os)
//                    .HasForeignKey(d => d.CodigoServico)
//                    .HasConstraintName("FK__OS__CODIGO_SERVI__4222D4EF");

//                entity.HasOne(d => d.CodigoStatusOsNavigation)
//                    .WithMany(p => p.Os)
//                    .HasForeignKey(d => d.CodigoStatusOs)
//                    .HasConstraintName("FK__OS__CODIGO_STATU__4316F928");

//                entity.HasOne(d => d.MatriculaAnalistaNavigation)
//                    .WithMany(p => p.Os)
//                    .HasForeignKey(d => d.MatriculaAnalista)
//                    .HasConstraintName("FK__OS__MATRICULA_AN__412EB0B6");
//            });

//            modelBuilder.Entity<Servicos>(entity =>
//            {
//                entity.HasKey(e => e.CodigoServico)
//                    .HasName("PK__SERVICOS__94D9994735D2F1FC");

//                entity.ToTable("SERVICOS");

//                entity.Property(e => e.CodigoServico).HasColumnName("CODIGO_SERVICO");

//                entity.Property(e => e.DescricaoServico)
//                    .HasColumnName("DESCRICAO_SERVICO")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<StatusChamados>(entity =>
//            {
//                entity.HasKey(e => e.CodigoStatusChamados)
//                    .HasName("PK__STATUS_C__F117F3FD1B177047");

//                entity.ToTable("STATUS_CHAMADOS");

//                entity.Property(e => e.CodigoStatusChamados).HasColumnName("CODIGO_STATUS_CHAMADOS");

//                entity.Property(e => e.DescricaoStatusChamados)
//                    .HasColumnName("DESCRICAO_STATUS_CHAMADOS")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<StatusOs>(entity =>
//            {
//                entity.HasKey(e => e.CodigoStatusOs)
//                    .HasName("PK__STATUS_O__77C012E7E0A7B886");

//                entity.ToTable("STATUS_OS");

//                entity.Property(e => e.CodigoStatusOs).HasColumnName("CODIGO_STATUS_OS");

//                entity.Property(e => e.DescricaoStatusOs)
//                    .HasColumnName("DESCRICAO_STATUS_OS")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<StatusUsuarios>(entity =>
//            {
//                entity.HasKey(e => e.CodigoStatusUsuarios)
//                    .HasName("PK__STATUS_U__F0EC35AC3E7BB9EE");

//                entity.ToTable("STATUS_USUARIOS");

//                entity.Property(e => e.CodigoStatusUsuarios).HasColumnName("CODIGO_STATUS_USUARIOS");

//                entity.Property(e => e.DescricaoStatusUsuarios)
//                    .HasColumnName("DESCRICAO_STATUS_USUARIOS")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Usuarios>(entity =>
//            {
//                entity.HasKey(e => e.IdUsuario)
//                    .HasName("PK__USUARIOS__91136B90C9E2E5C5");

//                entity.ToTable("USUARIOS");

//                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

//                entity.Property(e => e.CodigoStatusUsuarios).HasColumnName("CODIGO_STATUS_USUARIOS");

//                entity.Property(e => e.CpfCnpj)
//                    .HasColumnName("CPF_CNPJ")
//                    .HasMaxLength(15)
//                    .IsUnicode(false);

//                entity.Property(e => e.Email)
//                    .HasColumnName("EMAIL")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.Endereco)
//                    .HasColumnName("ENDERECO")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.NomeRazaosocial)
//                    .HasColumnName("NOME_RAZAOSOCIAL")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.Senha)
//                    .HasColumnName("SENHA")
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.Property(e => e.Telefone)
//                    .HasColumnName("TELEFONE")
//                    .HasMaxLength(30)
//                    .IsUnicode(false);

//                entity.Property(e => e.Tipo)
//                    .HasColumnName("TIPO")
//                    .HasMaxLength(10)
//                    .IsUnicode(false);

//                entity.HasOne(d => d.CodigoStatusUsuariosNavigation)
//                    .WithMany(p => p.Usuarios)
//                    .HasForeignKey(d => d.CodigoStatusUsuarios)
//                    .HasConstraintName("FK__USUARIOS__CODIGO__2F10007B");
//            });
//        }
//    }
//}
