using System;
using System.Collections.Generic;

namespace QuantumDesk.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Analistas = new HashSet<Analistas>();
            Clientes = new HashSet<Clientes>();
        }

        public int IdUsuario { get; set; }
        public string CpfCnpj { get; set; }
        public string NomeRazaosocial { get; set; }
        public int? CodigoStatusUsuarios { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }

        public virtual StatusUsuarios CodigoStatusUsuariosNavigation { get; set; }
        public virtual ICollection<Analistas> Analistas { get; set; }
        public virtual ICollection<Clientes> Clientes { get; set; }
    }
}
