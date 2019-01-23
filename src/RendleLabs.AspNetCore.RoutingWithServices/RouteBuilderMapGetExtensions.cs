using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

// ReSharper disable once CheckNamespace
namespace Microsoft.AspNetCore.Routing
{
    public static class RouteBuilderMapGetExtensions
    {
        public static IRouteBuilder MapGet<T1>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, Task> handler)
            => builder.MapVerb<T1>("GET", template, handler);
        public static IRouteBuilder MapGet<T1, T2>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, Task> handler)
            => builder.MapVerb<T1, T2>("GET", template, handler);
    }
}
