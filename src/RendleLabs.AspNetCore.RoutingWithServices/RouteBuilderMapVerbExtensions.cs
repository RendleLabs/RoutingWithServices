using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace RendleLabs.AspNetCore.RoutingWithServices
{
    public static class RouteBuilderMapVerbExtensions
    {
        /// <summary>
        /// Adds a route to the <see cref="IRouteBuilder"/> that only matches HTTP PATCH requests for the given <c>verb</c>, <c>template</c> and <c>handler</c>.
        /// </summary>
        /// <param name="builder">The <see cref="IRouteBuilder"/></param>.
        /// <param name="verb">The HTTP verb allowed by the route.</param>
        /// <param name="template">The route template.</param>
        /// <param name="handler">The route handler.</param>
        /// <typeparam name="T1">A service object type to be resolved.</typeparam>
        /// <returns>The <see cref="IRouteBuilder"/>.</returns>
        public static IRouteBuilder MapVerb<T1>(this IRouteBuilder builder, string verb, string template, Func<HttpRequest, HttpResponse, RouteData, T1, Task> handler)
        {
            return builder.MapVerb(verb, template, (request, response, routeData) =>
            {
                var d1 = request.HttpContext.RequestServices.GetRequiredService<T1>();
                return handler(request, response, routeData, d1);
            });
        }

        /// <summary>
        /// Adds a route to the <see cref="IRouteBuilder"/> that only matches HTTP PATCH requests for the given <c>verb</c>, <c>template</c> and <c>handler</c>.
        /// </summary>
        /// <param name="builder">The <see cref="IRouteBuilder"/></param>.
        /// <param name="verb">The HTTP verb allowed by the route.</param>
        /// <param name="template">The route template.</param>
        /// <param name="handler">The route handler.</param>
        /// <typeparam name="T1">A service object type to be resolved.</typeparam>
        /// <typeparam name="T2">A service object type to be resolved.</typeparam>
        /// <returns>The <see cref="IRouteBuilder"/>.</returns>
        public static IRouteBuilder MapVerb<T1, T2>(this IRouteBuilder builder, string verb, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, Task> handler)
        {
            return builder.MapVerb(verb, template, (request, response, routeData) =>
            {
                var d1 = request.HttpContext.RequestServices.GetRequiredService<T1>();
                var d2 = request.HttpContext.RequestServices.GetRequiredService<T2>();
                return handler(request, response, routeData, d1, d2);
            });
        }

        /// <summary>
        /// Adds a route to the <see cref="IRouteBuilder"/> that only matches HTTP PATCH requests for the given <c>verb</c>, <c>template</c> and <c>handler</c>.
        /// </summary>
        /// <param name="builder">The <see cref="IRouteBuilder"/></param>.
        /// <param name="verb">The HTTP verb allowed by the route.</param>
        /// <param name="template">The route template.</param>
        /// <param name="handler">The route handler.</param>
        /// <typeparam name="T1">A service object type to be resolved.</typeparam>
        /// <typeparam name="T2">A service object type to be resolved.</typeparam>
        /// <typeparam name="T3">A service object type to be resolved.</typeparam>
        /// <returns>The <see cref="IRouteBuilder"/>.</returns>
        public static IRouteBuilder MapVerb<T1, T2, T3>(this IRouteBuilder builder, string verb, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, T3, Task> handler)
        {
            return builder.MapVerb(verb, template, (request, response, routeData) =>
            {
                var d1 = request.HttpContext.RequestServices.GetRequiredService<T1>();
                var d2 = request.HttpContext.RequestServices.GetRequiredService<T2>();
                var d3 = request.HttpContext.RequestServices.GetRequiredService<T3>();
                return handler(request, response, routeData, d1, d2, d3);
            });
        }

        /// <summary>
        /// Adds a route to the <see cref="IRouteBuilder"/> that only matches HTTP PATCH requests for the given <c>verb</c>, <c>template</c> and <c>handler</c>.
        /// </summary>
        /// <param name="builder">The <see cref="IRouteBuilder"/></param>.
        /// <param name="verb">The HTTP verb allowed by the route.</param>
        /// <param name="template">The route template.</param>
        /// <param name="handler">The route handler.</param>
        /// <typeparam name="T1">A service object type to be resolved.</typeparam>
        /// <typeparam name="T2">A service object type to be resolved.</typeparam>
        /// <typeparam name="T3">A service object type to be resolved.</typeparam>
        /// <typeparam name="T4">A service object type to be resolved.</typeparam>
        /// <returns>The <see cref="IRouteBuilder"/>.</returns>
        public static IRouteBuilder MapVerb<T1, T2, T3, T4>(this IRouteBuilder builder, string verb, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, T3, T4, Task> handler)
        {
            return builder.MapVerb(verb, template, (request, response, routeData) =>
            {
                var d1 = request.HttpContext.RequestServices.GetRequiredService<T1>();
                var d2 = request.HttpContext.RequestServices.GetRequiredService<T2>();
                var d3 = request.HttpContext.RequestServices.GetRequiredService<T3>();
                var d4 = request.HttpContext.RequestServices.GetRequiredService<T4>();
                return handler(request, response, routeData, d1, d2, d3, d4);
            });
        }

        /// <summary>
        /// Adds a route to the <see cref="IRouteBuilder"/> that only matches HTTP PATCH requests for the given <c>verb</c>, <c>template</c> and <c>handler</c>.
        /// </summary>
        /// <param name="builder">The <see cref="IRouteBuilder"/></param>.
        /// <param name="verb">The HTTP verb allowed by the route.</param>
        /// <param name="template">The route template.</param>
        /// <param name="handler">The route handler.</param>
        /// <typeparam name="T1">A service object type to be resolved.</typeparam>
        /// <typeparam name="T2">A service object type to be resolved.</typeparam>
        /// <typeparam name="T3">A service object type to be resolved.</typeparam>
        /// <typeparam name="T4">A service object type to be resolved.</typeparam>
        /// <typeparam name="T5">A service object type to be resolved.</typeparam>
        /// <returns>The <see cref="IRouteBuilder"/>.</returns>
        public static IRouteBuilder MapVerb<T1, T2, T3, T4, T5>(this IRouteBuilder builder, string verb, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, T3, T4, T5, Task> handler)
        {
            return builder.MapVerb(verb, template, (request, response, routeData) =>
            {
                var d1 = request.HttpContext.RequestServices.GetRequiredService<T1>();
                var d2 = request.HttpContext.RequestServices.GetRequiredService<T2>();
                var d3 = request.HttpContext.RequestServices.GetRequiredService<T3>();
                var d4 = request.HttpContext.RequestServices.GetRequiredService<T4>();
                var d5 = request.HttpContext.RequestServices.GetRequiredService<T5>();
                return handler(request, response, routeData, d1, d2, d3, d4, d5);
            });
        }

        /// <summary>
        /// Adds a route to the <see cref="IRouteBuilder"/> that only matches HTTP PATCH requests for the given <c>verb</c>, <c>template</c> and <c>handler</c>.
        /// </summary>
        /// <param name="builder">The <see cref="IRouteBuilder"/></param>.
        /// <param name="verb">The HTTP verb allowed by the route.</param>
        /// <param name="template">The route template.</param>
        /// <param name="handler">The route handler.</param>
        /// <typeparam name="T1">A service object type to be resolved.</typeparam>
        /// <typeparam name="T2">A service object type to be resolved.</typeparam>
        /// <typeparam name="T3">A service object type to be resolved.</typeparam>
        /// <typeparam name="T4">A service object type to be resolved.</typeparam>
        /// <typeparam name="T5">A service object type to be resolved.</typeparam>
        /// <typeparam name="T6">A service object type to be resolved.</typeparam>
        /// <returns>The <see cref="IRouteBuilder"/>.</returns>
        public static IRouteBuilder MapVerb<T1, T2, T3, T4, T5, T6>(this IRouteBuilder builder, string verb, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, T3, T4, T5, T6, Task> handler)
        {
            return builder.MapVerb(verb, template, (request, response, routeData) =>
            {
                var d1 = request.HttpContext.RequestServices.GetRequiredService<T1>();
                var d2 = request.HttpContext.RequestServices.GetRequiredService<T2>();
                var d3 = request.HttpContext.RequestServices.GetRequiredService<T3>();
                var d4 = request.HttpContext.RequestServices.GetRequiredService<T4>();
                var d5 = request.HttpContext.RequestServices.GetRequiredService<T5>();
                var d6 = request.HttpContext.RequestServices.GetRequiredService<T6>();
                return handler(request, response, routeData, d1, d2, d3, d4, d5, d6);
            });
        }

        /// <summary>
        /// Adds a route to the <see cref="IRouteBuilder"/> that only matches HTTP PATCH requests for the given <c>verb</c>, <c>template</c> and <c>handler</c>.
        /// </summary>
        /// <param name="builder">The <see cref="IRouteBuilder"/></param>.
        /// <param name="verb">The HTTP verb allowed by the route.</param>
        /// <param name="template">The route template.</param>
        /// <param name="handler">The route handler.</param>
        /// <typeparam name="T1">A service object type to be resolved.</typeparam>
        /// <typeparam name="T2">A service object type to be resolved.</typeparam>
        /// <typeparam name="T3">A service object type to be resolved.</typeparam>
        /// <typeparam name="T4">A service object type to be resolved.</typeparam>
        /// <typeparam name="T5">A service object type to be resolved.</typeparam>
        /// <typeparam name="T6">A service object type to be resolved.</typeparam>
        /// <typeparam name="T7">A service object type to be resolved.</typeparam>
        /// <returns>The <see cref="IRouteBuilder"/>.</returns>
        public static IRouteBuilder MapVerb<T1, T2, T3, T4, T5, T6, T7>(this IRouteBuilder builder, string verb, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, T3, T4, T5, T6, T7, Task> handler)
        {
            return builder.MapVerb(verb, template, (request, response, routeData) =>
            {
                var d1 = request.HttpContext.RequestServices.GetRequiredService<T1>();
                var d2 = request.HttpContext.RequestServices.GetRequiredService<T2>();
                var d3 = request.HttpContext.RequestServices.GetRequiredService<T3>();
                var d4 = request.HttpContext.RequestServices.GetRequiredService<T4>();
                var d5 = request.HttpContext.RequestServices.GetRequiredService<T5>();
                var d6 = request.HttpContext.RequestServices.GetRequiredService<T6>();
                var d7 = request.HttpContext.RequestServices.GetRequiredService<T7>();
                return handler(request, response, routeData, d1, d2, d3, d4, d5, d6, d7);
            });
        }

        /// <summary>
        /// Adds a route to the <see cref="IRouteBuilder"/> that only matches HTTP PATCH requests for the given <c>verb</c>, <c>template</c> and <c>handler</c>.
        /// </summary>
        /// <param name="builder">The <see cref="IRouteBuilder"/></param>.
        /// <param name="verb">The HTTP verb allowed by the route.</param>
        /// <param name="template">The route template.</param>
        /// <param name="handler">The route handler.</param>
        /// <typeparam name="T1">A service object type to be resolved.</typeparam>
        /// <typeparam name="T2">A service object type to be resolved.</typeparam>
        /// <typeparam name="T3">A service object type to be resolved.</typeparam>
        /// <typeparam name="T4">A service object type to be resolved.</typeparam>
        /// <typeparam name="T5">A service object type to be resolved.</typeparam>
        /// <typeparam name="T6">A service object type to be resolved.</typeparam>
        /// <typeparam name="T7">A service object type to be resolved.</typeparam>
        /// <typeparam name="T8">A service object type to be resolved.</typeparam>
        /// <returns>The <see cref="IRouteBuilder"/>.</returns>
        public static IRouteBuilder MapVerb<T1, T2, T3, T4, T5, T6, T7, T8>(this IRouteBuilder builder, string verb, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, T3, T4, T5, T6, T7, T8, Task> handler)
        {
            return builder.MapVerb(verb, template, (request, response, routeData) =>
            {
                var d1 = request.HttpContext.RequestServices.GetRequiredService<T1>();
                var d2 = request.HttpContext.RequestServices.GetRequiredService<T2>();
                var d3 = request.HttpContext.RequestServices.GetRequiredService<T3>();
                var d4 = request.HttpContext.RequestServices.GetRequiredService<T4>();
                var d5 = request.HttpContext.RequestServices.GetRequiredService<T5>();
                var d6 = request.HttpContext.RequestServices.GetRequiredService<T6>();
                var d7 = request.HttpContext.RequestServices.GetRequiredService<T7>();
                var d8 = request.HttpContext.RequestServices.GetRequiredService<T8>();
                return handler(request, response, routeData, d1, d2, d3, d4, d5, d6, d7, d8);
            });
        }

    }
}
