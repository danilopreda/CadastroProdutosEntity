using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroProdutos.Models
{
    public class Categoria
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public virtual SubCategoria SubCategoria { get; set; }
        public int SubCategoriaID { get; set; }
    }
}