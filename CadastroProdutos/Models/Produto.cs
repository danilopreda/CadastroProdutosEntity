using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastroProdutos.Models
{
    public class Produto
    {
        [Key]
        public int codigo { get; set; }
        public string nome { get; set; }     
        public decimal  preco { get; set; }
        public string descricao { get; set; }
        public virtual Categoria categoria { get; set; }
        public int CategoriaID { get; set; }
    }
}