using Microsoft.EntityFrameworkCore;
using Model.Categoria;
using Model.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Config
{
    public class Context : DbContext
    {
        protected Context()
        {
        }
        public Context(DbContextOptions options) : base(options)
        {

        }
        DbSet<ProdutoViewModel> Produtos { get; set; }
        DbSet<CategoriaViewModel> Categorias { get; set; }
    }
}
