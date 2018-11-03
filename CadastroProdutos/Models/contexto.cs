using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CadastroProdutos.Models
{
    public class contexto: DbContext
    {
        public contexto()
            :base("MVCProdutos")
        {

        }
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<SubCategoria> SubCategorias { get; set; }
    }
}