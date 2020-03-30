using Study.ListaLeitura.App.Negocio;
using Study.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Hosting;
using System;

namespace Study.ListaLeitura.App
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebHost host = new WebHostBuilder()
                                    .UseKestrel() // Seleciona o servidor que implementa o protocolo http
                                    .UseStartup<Startup>() // Seleciona a classe de configurações na inicialização
                                    .Build(); // Constroi o objeto que implementa a interface IWebHost

            // Levantar o servidor hospedado
            host.Run();
        }

        static void ImprimeLista(ListaDeLeitura lista)
        {
            Console.WriteLine(lista);
        }
    }
}
