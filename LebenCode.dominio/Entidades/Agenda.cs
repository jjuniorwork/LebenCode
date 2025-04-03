using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LebenCode.dominio.Entidades
{
    public class Agenda : EntidadeBase
    {
        public DateTime Data { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim{ get; set; }
        public long IdServico { get; set; }
        public Servico Servico { get; set; }
    }
}
