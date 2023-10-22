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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Transacao transacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transacao);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(transacao);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Transacoes.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Transacao transacao)
        {
            if (id != transacao.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Transacoes.Update(transacao);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Transacoes.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Transacoes.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Transacoes.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Transacoes.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Movimentacao(Tipo id)
        {
            var transacoes = await _context.Transacoes
                .Where(t => t.Tipo == id)
                .OrderByDescending(t => t.Data)
                .ToListAsync();
            Console.WriteLine("Transações: " + transacoes);
            decimal total = transacoes.Sum(c => c.Valor);

            ViewBag.Total = total;
            ViewBag.Titulo = id + "s";

            return View(transacoes);
        }
    }
}
