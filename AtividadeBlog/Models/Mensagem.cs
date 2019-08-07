using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeBlog
{
    public class Mensagem
    {
        public int Id { get; set; }
        
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataMensagem { get; set; }
        public Categoria Categoria { get; set; }
    }
}
