using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Study.ListaLeitura.App.Negocio;
using Study.ListaLeitura.App.Repositorio;

namespace Study.ListaLeitura.App.Controller
{
    public class CadastroController : Controller
    {
        public IActionResult Exibir()
        {
            return View("formulario");
        }

        public string Incluir(Livro livro)
        {
            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);
            return "Livro incluido com sucesso";
        }

        public string Ler(Livro livro)
        {
            var repo = new LivroRepositorioCSV();

            repo.Incluir(livro);
            return "Livro incluido com sucesso";
        }
    }
}