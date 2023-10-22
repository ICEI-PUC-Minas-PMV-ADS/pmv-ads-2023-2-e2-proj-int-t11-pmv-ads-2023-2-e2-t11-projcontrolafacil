using mf_dev_backend_2023.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2023.Controllers
{
    public class TransacoesController : Controller
    {
        private readonly AppDbContext _context;
        public TransacoesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Transacoes.ToListAsync();

            return View(dados);
        }

    }   
}
