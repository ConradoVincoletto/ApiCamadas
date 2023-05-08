using Data.Config;
using Data.RepositorioGenerico;
using Microsoft.EntityFrameworkCore;
using Model.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.CategotiaRepositorio
{
    public class RepositorioCategoria : RepositoryGeneric<CategoriaViewModel>
    {
        private readonly DbContextOptions<Context> _OptionBuilder;

        public RepositorioCategoria()
        {
            _OptionBuilder= new DbContextOptions<Context>();
        }
    }
}
