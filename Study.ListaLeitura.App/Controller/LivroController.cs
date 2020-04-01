using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Study.ListaLeitura.App.Repositorio;

namespace Study.ListaLeitura.App.Controller
{
    public class LivroController : Controller
    {
        public string Detalhe(int id)
        {
            var repo = new LivroRepositorioCSV();
            var livro = repo.Todos.First(p => p.Id == id);

            return livro.ToString();
        }

        public IActionResult Ler()
        {
            var repo = new LivroRepositorioCSV();
            Viewbag.Livros = repo.ParaLer.Livros;
            return View("lista");
        }

        public IActionResult Lendo()
        {
            var repo = new LivroRepositorioCSV();
            Viewbag.Livros = repo.Lendo.Livros;
            return View("lista");
        }

        public IActionResult Lidos()
        {
            var repo = new LivroRepositorioCSV();
            Viewbag.Livros = repo.Lidos.Livros;
            return View("lista");
        }
    }
}