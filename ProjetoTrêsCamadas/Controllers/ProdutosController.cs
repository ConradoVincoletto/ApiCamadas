using Azure.Core;
using Business.InterfaceProduto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Model.Produto;

namespace ProjetoTrêsCamadas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : Controller
    {
        private readonly IProduto _IProduto;

        public ProdutosController(IProduto IProduto)
        {
            _IProduto= IProduto;
        }

        [HttpGet("ListasProdutos")]
        public async Task<IActionResult> ListasProdutos()
        {
            return Json(await _IProduto.List());
        }

        [HttpPost("AdicionarProduto")]
        public async Task AdicionarProduto(ProdutoViewModel produto)
        {
            await _IProduto.Add(produto);
        }

        [HttpGet("ObterProdutoPorId")]
        public async Task<IActionResult> ObterProdutoPorId(int Id)
        {
            return Json(await _IProduto.GetEntityById(Id));
        }



        [HttpPut("AtualizarProduto")]
        public async Task AtualizarProduto(ProdutoViewModel produto)
        {
            await _IProduto.Update(produto);
        }

        [HttpDelete("RemoverProduto")]
        public async Task RemoverProduto(ProdutoViewModel produto)
        {
            await _IProduto.Delete(produto);
        }

    }
}
