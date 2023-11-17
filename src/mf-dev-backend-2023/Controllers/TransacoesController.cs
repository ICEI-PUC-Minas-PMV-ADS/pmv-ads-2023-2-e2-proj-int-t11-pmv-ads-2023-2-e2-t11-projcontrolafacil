using mf_dev_backend_2023.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using NuGet.ContentModel;
using System.Net.NetworkInformation;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;

namespace mf_dev_backend_2023.Controllers
{
    [Authorize]
    public class TransacoesController : Controller
    {
        private readonly AppDbContext _context;
        //private readonly UserManager<IdentityUser> _userManager;

        //public TransacoesController(UserManager<IdentityUser> userManager, AppDbContext context)
        public TransacoesController(AppDbContext context)
        {
            //_userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var transacao = await _context.Transacoes
                .Where(t => t.Usuario.Nome == User.Identity.Name)
                .OrderByDescending(t => t.Data)
                .ToListAsync();

            return View(transacao);
        }

        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tipo,Valor,Data,Descricao,UsuarioId")] Transacao transacao)
        {
            if (ModelState.IsValid)
            {
                //var userId = _userManager.GetUserId(User);
                //transacao.UsuarioId = Int32.Parse(userId);

                _context.Add(transacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome", transacao.UsuarioId);
            return View(transacao);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Transacoes == null)
            {
                return NotFound();
            }

            var transacao = await _context.Transacoes.FindAsync(id);
            if (transacao == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome", transacao.UsuarioId);
            return View(transacao);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tipo,Valor,Data,Descricao,UsuarioId")] Transacao transacao)
        {
            if (id != transacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransacaoExists(transacao.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Nome", transacao.UsuarioId);
            return View(transacao);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Transacoes == null)
            {
                return NotFound();
            }

            var transacao = await _context.Transacoes
                .Include(t => t.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transacao == null)
            {
                return NotFound();
            }

            return View(transacao);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Transacoes == null)
            {
                return NotFound();
            }

            var transacao = await _context.Transacoes
                .Include(t => t.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transacao == null)
            {
                return NotFound();
            }

            return View(transacao);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Transacoes == null)
            {
                return Problem("Entity set 'AppDbContext.Transacoes'  is null.");
            }
            var transacao = await _context.Transacoes.FindAsync(id);
            if (transacao != null)
            {
                _context.Transacoes.Remove(transacao);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Movimentacao(Tipo id)
        {
            var transacoes = await _context.Transacoes
                .Where(t => t.Tipo == id && t.Usuario.Nome == User.Identity.Name)
                .OrderByDescending(t => t.Data)
                .ToListAsync();
            Console.WriteLine("Transações: " + transacoes);
            decimal total = transacoes.Sum(c => c.Valor);

            ViewBag.Total = total;
            ViewBag.Titulo = id+"s";

            return View(transacoes);
        }

        private bool TransacaoExists(int id)
        {
            return _context.Transacoes.Any(e => e.Id == id);
        }
    }
}