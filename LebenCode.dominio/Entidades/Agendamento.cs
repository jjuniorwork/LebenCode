using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LebenCode.dominio.Entidades
{
    public class Agendamento : EntidadeBase
    {
        public long IdAgenda { get; set; }
        public Agenda Agenda { get; set; }
        public long IdUsuarioCliente { get; set; }
        public Usuario UsuarioCliente { get; set; }
    }
}
