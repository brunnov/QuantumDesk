using System;
using System.Collections.Generic;

namespace QuantumDesk.Models
{
    public partial class Usuarios
    {
        public int IdUsuario { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }
    }
}
