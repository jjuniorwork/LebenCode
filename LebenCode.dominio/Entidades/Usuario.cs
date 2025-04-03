using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LebenCode.dominio.Entidades
{
    public class Usuario : EntidadeBase 
    {
        public   string Nome { get; set; }
        public int Idade { get; set;}
        public List<Endereco> Enderecos { get; set; }
    }
}
