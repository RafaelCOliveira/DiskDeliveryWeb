using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiskDeliveryWeb.Data;
using DiskDeliveryWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DiskDeliveryWeb.WebApp.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ApplicationDbContext _contexto;
        public CategoriaController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            List<Categoria> ListCategoria = _contexto.Categorias.ToList();
            return View(ListCategoria);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _contexto.Categorias.Add(categoria);
                await _contexto.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(categoria);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Categoria categoria = _contexto.Categorias.Find(id);
            return View(categoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _contexto.Categorias.Update(categoria);
                await _contexto.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(categoria);
        }
        
    }
}
