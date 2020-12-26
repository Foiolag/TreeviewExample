using System.Collections.Generic;
using TreeviewExample.Models;

namespace TreeviewExample.Models
{
    public class Banco
    {       
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Apelido { get; set; }

        public List<Grupo> Grupos { get; set; }
    }
}