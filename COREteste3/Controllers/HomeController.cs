using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using COREteste3.Models;
using Microsoft.AspNetCore.Http;

namespace COREteste3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            //GravarUsandoEntity();
            RecuperarProdutos();
            return View();

        }

        private void RecuperarProdutos()
        {

            using (var repo = new LojaContext())
            {

                IList<Produto> produtos = repo.Produtos.ToList();
                ViewBag.Produtos = produtos;

            }

        }

        private void GravarUsandoEntity()
        {

            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new LojaContext())
            {
                repo.Produtos.Add(p);
                repo.SaveChanges();
            }

        }
    }
}
