using Business.InterfaceProduto;
using Data.Config;
using Data.RepositorioGenerico;
using Microsoft.EntityFrameworkCore;
using Model.Produto;

namespace Data.ProdutoRepositorio
{
    public class RepositorioProduto : RepositoryGeneric<ProdutoViewModel>, IProduto
    {

        private readonly DbContextOptions<Context> _OptionBuilder;
        public RepositorioProduto()
        {
            _OptionBuilder = new DbContextOptions<Context>();
        }
    }
}
