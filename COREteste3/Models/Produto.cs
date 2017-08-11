using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COREteste3.Models
{
    public class Produto
    {

        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double Preco { get; internal set; }

    }
}
