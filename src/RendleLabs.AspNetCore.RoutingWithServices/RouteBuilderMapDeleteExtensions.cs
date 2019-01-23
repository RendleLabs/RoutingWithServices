using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

// ReSharper disable once CheckNamespace
namespace Microsoft.AspNetCore.Routing
{
    public static class RouteBuilderMapDeleteExtensions
    {
        public static IRouteBuilder MapDelete<T1>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, Task> handler)
            => builder.MapVerb<T1>("DELETE", template, handler);
        public static IRouteBuilder MapDelete<T1, T2>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, Task> handler)
            => builder.MapVerb<T1, T2>("DELETE", template, handler);
    }
}
