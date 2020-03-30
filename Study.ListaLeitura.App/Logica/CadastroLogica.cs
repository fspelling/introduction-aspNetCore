using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Study.ListaLeitura.App.Negocio;
using Study.ListaLeitura.App.Repositorio;

namespace Study.ListaLeitura.App.Logica
{
    public class CadastroLogica
    {
        public static Task ExibirCadastroLivrosLer(HttpContext context)
        {
            var html = HtmlUtils.CarregarArquivoHTML("formulario");
            return context.Response.WriteAsync(html);
        }

        public static Task CadastroLivrosLer(HttpContext context)
        {
            var repo = new LivroRepositorioCSV();
            var livro = new Livro()
            {
                Titulo = context.Request.Form["titulo"].First(),
                Autor = context.Request.Form["autor"].First()
            };

            repo.Incluir(livro);
            return context.Response.WriteAsync("Livro incluido com sucesso");
        }

        public static Task CadastroLivrosLerEndereco(HttpContext context)
        {
            var repo = new LivroRepositorioCSV();
            var livro = new Livro()
            {
                Id = 244,
                Titulo = context.GetRouteValue("titulo").ToString(),
                Autor = context.GetRouteValue("autor").ToString()
            };

            repo.Incluir(livro);
            return context.Response.WriteAsync("Livro incluido com sucesso");
        }
    }
}