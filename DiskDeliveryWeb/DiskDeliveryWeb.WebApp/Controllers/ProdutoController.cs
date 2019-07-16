using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiskDeliveryWeb.Data;
using DiskDeliveryWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiskDeliveryWeb.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ApplicationDbContext _contexto;
        public ProdutoController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            List<Produto> ListProdutos = _contexto.Produtos.Include(p => p.Categoria).ToList();
            return View(ListProdutos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categorias = _contexto.Categorias.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _contexto.Produtos.Add(produto);
                await _contexto.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Categorias = _contexto.Categorias.ToList();
            return View(produto);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Produto produto = _contexto.Produtos.Find(id);
            return View(produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _contexto.Produtos.Update(produto);
                await _contexto.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Categorias = _contexto.Categorias.ToList();
            return View(produto);
        }

    }
}
