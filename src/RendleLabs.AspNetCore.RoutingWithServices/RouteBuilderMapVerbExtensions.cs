using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

// ReSharper disable once CheckNamespace
namespace Microsoft.AspNetCore.Routing
{
    public static class RouteBuilderMapVerbExtensions
    {
        public static IRouteBuilder MapVerb<T1>(this IRouteBuilder builder, string verb, string template, Func<HttpRequest, HttpResponse, RouteData, T1, Task> handler)
        {
            return builder.MapVerb(verb, template, (request, response, routeData) =>
            {
                var d1 = request.HttpContext.RequestServices.GetRequiredService<T1>();
                return handler(request, response, routeData, d1);
            });
        }
        public static IRouteBuilder MapVerb<T1, T2>(this IRouteBuilder builder, string verb, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, Task> handler)
        {
            return builder.MapVerb(verb, template, (request, response, routeData) =>
            {
                var d1 = request.HttpContext.RequestServices.GetRequiredService<T1>();
                var d2 = request.HttpContext.RequestServices.GetRequiredService<T2>();
                return handler(request, response, routeData, d1, d2);
            });
        }
    }
}
