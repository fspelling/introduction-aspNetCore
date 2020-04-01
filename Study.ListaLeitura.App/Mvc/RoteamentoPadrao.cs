using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Study.ListaLeitura.App.Mvc
{
    public class RoteamentoPadrao
    {
        public static Task TratamentoPadrao(HttpContext context)
        {
            var classe = $@"Study.ListaLeitura.App.Logica.{context.GetRouteValue("classe").ToString()}Logica";
            var metodoNome = context.GetRouteValue("metodo").ToString();

            var tipo = Type.GetType(classe);
            var metodo = tipo.GetMethods().Where(p => p.Name == metodoNome).First();
            var delegateMetodo = (RequestDelegate)Delegate.CreateDelegate(typeof(RequestDelegate), metodo);

            return delegateMetodo.Invoke(context);
        }
    }
}