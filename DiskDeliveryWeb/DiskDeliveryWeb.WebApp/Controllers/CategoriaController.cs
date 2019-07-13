using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiskDeliveryWeb.Data;
using DiskDeliveryWeb.Models;
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
        public async Task<IActionResult> Create(Categoria categoria)
        {

            
            _contexto.Categorias.Add(categoria);
            await _contexto.SaveChangesAsync();
         
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Categoria categoria = _contexto.Categorias.Find(id);
            return View(categoria);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Categoria categoria)
        {
           
            _contexto.Categorias.Update(categoria);
            await _contexto.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
