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
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        DbSet<ProdutoViewModel> ProdutoViewModels { get; set; }
        DbSet<CategoriaViewModel> CategoriaViewModels { get; set; }

        private string GetStringConectionConfig()
        {
            string strCon = "Data Source=LAPTOP-MGPDKJRC\\SQLSERVER2022;Initial Catalog=API_TRES_CAMADAS;Integrated Security=True;Encrypt=False;TrustServerCertificate=False"));
            return strCon;
        }

        
    }
}
