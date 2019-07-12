using System.Collections.Generic;
using DiskDeliveryWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiskDeliveryWeb.WebApp.Controllers
{
    public class CategoriaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Categoria> ListCategoria = new List<Categoria>();

            /* Categoria s1 = new Categoria() { Id_Categoria = 1, Descricao = "Comida" };
            ListCategoria.Add(s1);
            Categoria s2 = new Categoria() { Id_Categoria = 2, Descricao = "Bebida" };
            ListCategoria.Add(s2);
            Categoria s3 = new Categoria() { Id_Categoria = 3, Descricao = "Outros" };
            ListCategoria.Add(s3);*/
            return View(ListCategoria);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Categoria categoria)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int Id_Categoria)
        {
            Categoria s1 = new Categoria() { Id_Categoria = 1, Descricao = "Comida" };
            return View(s1);
        }

        [HttpPut]
        public IActionResult Edit(Categoria categoria)
        {
            return View();
        }
    }
}
