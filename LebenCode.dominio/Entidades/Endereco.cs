using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LebenCode.dominio.Entidades
{
    public class Endereco : EntidadeBase
    {
        public long IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public bool Ativo { get; set; }
    }
}
