using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace RendleLabs.AspNetCore.RoutingWithServices
{
    public static class RouteBuilderMapHeadExtensions
    {
        /// <summary>
        /// Adds a route to the <see cref="IRouteBuilder"/> that only matches HTTP PATCH requests for the given <c>template</c> and <c>handler</c>.
        /// </summary>
        /// <param name="builder">The <see cref="IRouteBuilder"/></param>.
        /// <param name="template">The route template.</param>
        /// <param name="handler">The route handler.</param>
        /// <typeparam name="T1">A service object type to be resolved.</typeparam>
        /// <returns>The <see cref="IRouteBuilder"/>.</returns>
        public static IRouteBuilder MapHead<T1>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, Task> handler)
            => builder.MapVerb("HEAD", template, handler);

        /// <summary>
        /// Adds a route to the <see cref="IRouteBuilder"/> that only matches HTTP PATCH requests for the given <c>template</c> and <c>handler</c>.
        /// </summary>
        /// <param name="builder">The <see cref="IRouteBuilder"/></param>.
        /// <param name="template">The route template.</param>
        /// <param name="handler">The route handler.</param>
        /// <typeparam name="T1">A service object type to be resolved.</typeparam>
        /// <typeparam name="T2">A service object type to be resolved.</typeparam>
        /// <returns>The <see cref="IRouteBuilder"/>.</returns>
        public static IRouteBuilder MapHead<T1, T2>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, Task> handler)
            => builder.MapVerb("HEAD", template, handler);

        /// <summary>
        /// Adds a route to the <see cref="IRouteBuilder"/> that only matches HTTP PATCH requests for the given <c>template</c> and <c>handler</c>.
        /// </summary>
        /// <param name="builder">The <see cref="IRouteBuilder"/></param>.
        /// <param name="template">The route template.</param>
        /// <param name="handler">The route handler.</param>
        /// <typeparam name="T1">A service object type to be resolved.</typeparam>
        /// <typeparam name="T2">A service object type to be resolved.</typeparam>
        /// <typeparam name="T3">A service object type to be resolved.</typeparam>
        /// <returns>The <see cref="IRouteBuilder"/>.</returns>
        public static IRouteBuilder MapHead<T1, T2, T3>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, T3, Task> handler)
            => builder.MapVerb("HEAD", template, handler);

        /// <summary>
        /// Adds a route to the <see cref="IRouteBuilder"/> that only matches HTTP PATCH requests for the given <c>template</c> and <c>handler</c>.
        /// </summary>
        /// <param name="builder">The <see cref="IRouteBuilder"/></param>.
        /// <param name="template">The route template.</param>
        /// <param name="handler">The route handler.</param>
        /// <typeparam name="T1">A service object type to be resolved.</typeparam>
        /// <typeparam name="T2">A service object type to be resolved.</typeparam>
        /// <typeparam name="T3">A service object type to be resolved.</typeparam>
        /// <typeparam name="T4">A service object type to be resolved.</typeparam>
        /// <returns>The <see cref="IRouteBuilder"/>.</returns>
        public static IRouteBuilder MapHead<T1, T2, T3, T4>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, T3, T4, Task> handler)
            => builder.MapVerb("HEAD", template, handler);

        /// <summary>
        /// Adds a route to the <see cref="IRouteBuilder"/> that only matches HTTP PATCH requests for the given <c>template</c> and <c>handler</c>.
        /// </summary>
        /// <param name="builder">The <see cref="IRouteBuilder"/></param>.
        /// <param name="template">The route template.</param>
        /// <param name="handler">The route handler.</param>
        /// <typeparam name="T1">A service object type to be resolved.</typeparam>
        /// <typeparam name="T2">A service object type to be resolved.</typeparam>
        /// <typeparam name="T3">A service object type to be resolved.</typeparam>
        /// <typeparam name="T4">A service object type to be resolved.</typeparam>
        /// <typeparam name="T5">A service object type to be resolved.</typeparam>
        /// <returns>The <see cref="IRouteBuilder"/>.</returns>
        public static IRouteBuilder MapHead<T1, T2, T3, T4, T5>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, T3, T4, T5, Task> handler)
            => builder.MapVerb("HEAD", template, handler);

        /// <summary>
        /// Adds a route to the <see cref="IRouteBuilder"/> that only matches HTTP PATCH requests for the given <c>template</c> and <c>handler</c>.
        /// </summary>
        /// <param name="builder">The <see cref="IRouteBuilder"/></param>.
        /// <param name="template">The route template.</param>
        /// <param name="handler">The route handler.</param>
        /// <typeparam name="T1">A service object type to be resolved.</typeparam>
        /// <typeparam name="T2">A service object type to be resolved.</typeparam>
        /// <typeparam name="T3">A service object type to be resolved.</typeparam>
        /// <typeparam name="T4">A service object type to be resolved.</typeparam>
        /// <typeparam name="T5">A service object type to be resolved.</typeparam>
        /// <typeparam name="T6">A service object type to be resolved.</typeparam>
        /// <returns>The <see cref="IRouteBuilder"/>.</returns>
        public static IRouteBuilder MapHead<T1, T2, T3, T4, T5, T6>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, T3, T4, T5, T6, Task> handler)
            => builder.MapVerb("HEAD", template, handler);

        /// <summary>
        /// Adds a route to the <see cref="IRouteBuilder"/> that only matches HTTP PATCH requests for the given <c>template</c> and <c>handler</c>.
        /// </summary>
        /// <param name="builder">The <see cref="IRouteBuilder"/></param>.
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
        public static IRouteBuilder MapHead<T1, T2, T3, T4, T5, T6, T7>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, T3, T4, T5, T6, T7, Task> handler)
            => builder.MapVerb("HEAD", template, handler);

        /// <summary>
        /// Adds a route to the <see cref="IRouteBuilder"/> that only matches HTTP PATCH requests for the given <c>template</c> and <c>handler</c>.
        /// </summary>
        /// <param name="builder">The <see cref="IRouteBuilder"/></param>.
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
        public static IRouteBuilder MapHead<T1, T2, T3, T4, T5, T6, T7, T8>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, T1, T2, T3, T4, T5, T6, T7, T8, Task> handler)
            => builder.MapVerb("HEAD", template, handler);

    }
}
