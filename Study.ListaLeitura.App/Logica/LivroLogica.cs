using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Study.ListaLeitura.App.Repositorio;

namespace Study.ListaLeitura.App.Logica
{
    public class LivroLogica
    {
        public static Task LivrosDetalhe(HttpContext context)
        {
            var id = Convert.ToInt32(context.GetRouteValue("id"));

            var repo = new LivroRepositorioCSV();
            var livro = repo.Todos.First(p => p.Id == id);

            return context.Response.WriteAsync(livro.ToString());
        }

        public static Task LivrosLer(HttpContext context)
        {
            var repo = new LivroRepositorioCSV();
            var htmlLivros = HtmlUtils.CarregarArquivoHTML("livros");

            foreach(var livro in repo.ParaLer.Livros)
                htmlLivros = htmlLivros.Replace("#NEW_ITEM", $"<li>{livro.ToString()}</li>#NEW_ITEM");
            
            htmlLivros = htmlLivros.Replace("#NEW_ITEM", string.Empty);
            return context.Response.WriteAsync(htmlLivros);
        }

        public static Task LivrosLendo(HttpContext context)
        {
            var repo = new LivroRepositorioCSV();
            var htmlLivros = HtmlUtils.CarregarArquivoHTML("livros");

            foreach(var livro in repo.Lendo.Livros)
                htmlLivros = htmlLivros.Replace("#NEW_ITEM", $"<li>{livro.ToString()}</li>#NEW_ITEM");
            
            htmlLivros = htmlLivros.Replace("#NEW_ITEM", string.Empty);
            return context.Response.WriteAsync(htmlLivros);
        }

        public static Task LivrosLidos(HttpContext context)
        {
            var repo = new LivroRepositorioCSV();
            var htmlLivros = HtmlUtils.CarregarArquivoHTML("livros");

            foreach(var livro in repo.Lidos.Livros)
                htmlLivros = htmlLivros.Replace("#NEW_ITEM", $"<li>{livro.ToString()}</li>#NEW_ITEM");
            
            htmlLivros = htmlLivros.Replace("#NEW_ITEM", string.Empty);
            return context.Response.WriteAsync(htmlLivros);
        }
    }
}