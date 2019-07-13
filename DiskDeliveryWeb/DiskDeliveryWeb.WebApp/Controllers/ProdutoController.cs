using System.Collections.Generic;
using DiskDeliveryWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiskDeliveryWeb.Controllers
{
    public class ProdutoController : Controller
    {
        public ProdutoController()
        {

        }
        
        [HttpGet]
        public IActionResult Index()
        {
            List<Produto> ListFormaPagamento = new List<Produto>();
            Produto s1 = new Produto() { Id_Produto = 1, Descricao = "Teste", Nome = "Teste", Preco = 10, Ativo = true, Categoria = new Categoria(){Id_Categoria =1, Descricao = "Comida"} };
            ListFormaPagamento.Add(s1);
            Produto s2 = new Produto() { Id_Produto = 2, Descricao = "Teste1", Nome = "Teste1", Preco = 15, Ativo = true, Categoria = new Categoria(){Id_Categoria =2, Descricao = "Bebida"} };
            ListFormaPagamento.Add(s2);
            Produto s3 = new Produto() { Id_Produto = 3, Descricao = "Teste2", Nome = "Teste2", Preco = 15, Ativo = false, Categoria = new Categoria(){Id_Categoria =3, Descricao = "Bebida"} };
            ListFormaPagamento.Add(s3);
            return View(ListFormaPagamento);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto produto)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int Id_Produto)
        {
            Produto s1 = new Produto() { Id_Produto = 1, Descricao = "Dinheiro", Ativo = true };
            return View(s1);
        }

        [HttpPut]
        public IActionResult Edit(Produto produto)
        {
            return View();
        }
    }
}
