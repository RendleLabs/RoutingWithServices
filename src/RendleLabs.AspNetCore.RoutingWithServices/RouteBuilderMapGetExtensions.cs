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
        public static IRouteBuilder MapGet<T1, T2, T3>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, T3, Task> handler)
            => builder.MapVerb<T1, T2, T3>("GET", template, handler);
        public static IRouteBuilder MapGet<T1, T2, T3, T4>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, T3, T4, Task> handler)
            => builder.MapVerb<T1, T2, T3, T4>("GET", template, handler);
        public static IRouteBuilder MapGet<T1, T2, T3, T4, T5>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, T3, T4, T5, Task> handler)
            => builder.MapVerb<T1, T2, T3, T4, T5>("GET", template, handler);
        public static IRouteBuilder MapGet<T1, T2, T3, T4, T5, T6>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, T3, T4, T5, T6, Task> handler)
            => builder.MapVerb<T1, T2, T3, T4, T5, T6>("GET", template, handler);
        public static IRouteBuilder MapGet<T1, T2, T3, T4, T5, T6, T7>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, T3, T4, T5, T6, T7, Task> handler)
            => builder.MapVerb<T1, T2, T3, T4, T5, T6, T7>("GET", template, handler);
        public static IRouteBuilder MapGet<T1, T2, T3, T4, T5, T6, T7, T8>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, T3, T4, T5, T6, T7, T8, Task> handler)
            => builder.MapVerb<T1, T2, T3, T4, T5, T6, T7, T8>("GET", template, handler);
    }
}
