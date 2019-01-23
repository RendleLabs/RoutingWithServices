using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

// ReSharper disable once CheckNamespace
namespace Microsoft.AspNetCore.Routing
{
    public static class RouteBuilderMapPutExtensions
    {
        public static IRouteBuilder MapPut<T1>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, Task> handler)
            => builder.MapVerb<T1>("PUT", template, handler);
        public static IRouteBuilder MapPut<T1, T2>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, Task> handler)
            => builder.MapVerb<T1, T2>("PUT", template, handler);
    }
}
