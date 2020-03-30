using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Study.ListaLeitura.App.Logica;

namespace Study.ListaLeitura.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        public void Configure(IApplicationBuilder app)
        {
            var builderRoute = new RouteBuilder(app);
            builderRoute.MapRoute("livros/ler", LivroLogica.LivrosLer);
            builderRoute.MapRoute("livros/lidos", LivroLogica.LivrosLidos);
            builderRoute.MapRoute("livros/lendo", LivroLogica.LivrosLendo);
            builderRoute.MapRoute("livros/ler/Cadastro/{titulo}/{autor}", CadastroLogica.CadastroLivrosLerEndereco);
            builderRoute.MapRoute("livros/ler/CadastroForm", CadastroLogica.ExibirCadastroLivrosLer);
            builderRoute.MapRoute("livros/ler/Cadastro", CadastroLogica.CadastroLivrosLer);
            builderRoute.MapRoute("livros/Detalhe/{id:int}", LivroLogica.LivrosDetalhe);

            var routes = builderRoute.Build();
            app.UseRouter(routes);
        }
    }
}