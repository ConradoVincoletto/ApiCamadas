using Business.InterfaceCategoria;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Categoria;

namespace ProjetoTrêsCamadas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : Controller
    {
        private readonly ICategoria _ICategoria;

        public CategoriaController (ICategoria iCategoria)
        {
            _ICategoria = iCategoria;
        }

        [HttpGet("ListaCategorias")]

        public async Task<IActionResult> ListaCategorias()
        {
            return Json(await _ICategoria.List());
        }

        [HttpPost("AdicionarCategoria")]
        public async Task AdicionarCategoria(CategoriaViewModel categoria)
        {
            await _ICategoria.Add(categoria);
        }

        [HttpGet("ObterCategoriaPorId")]

        public async Task<IActionResult> ObterCategoriaPorId(int Id)
        {
            return Json(await _ICategoria.GetEntityById(Id));
        }

        [HttpPut("AtualizarCategoria")]

        public async Task AtualizarCategoria(CategoriaViewModel categoria)
        {
            await _ICategoria.Update(categoria);
        }

        [HttpDelete("RemoverCategoria")]

        public async Task RemoverCategoria(CategoriaViewModel categoria)
        {
            await _ICategoria.Delete(categoria);
        }
    }
}
