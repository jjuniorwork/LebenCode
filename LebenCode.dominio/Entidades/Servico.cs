using LebenCode.dominio.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LebenCode.dominio.Entidades
{
    public class Servico : EntidadeBase
    {
        public long IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public List<Agenda> Agendas { get; set; }
        public CategoriaServico CategoriaServico { get; set; }
    }
}
