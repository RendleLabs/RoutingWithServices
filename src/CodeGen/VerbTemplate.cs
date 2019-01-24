namespace CodeGen
{
    static class VerbTemplate
    {
        public const string MethodStart =
            @"        {DocComments}
        public static IRouteBuilder MapVerb<{TypeParams}>(this IRouteBuilder builder, string verb, string template, Func<HttpRequest, HttpResponse, RouteData, {TypeParams}, Task> handler)
        {
            return builder.MapVerb(verb, template, (request, response, routeData) =>
            {";

        public const string MethodEnd =
            @"                return handler(request, response, routeData, {Dependencies});
            });
        }
";

        public const string GetRequiredService = "                var d{Number} = request.HttpContext.RequestServices.GetRequiredService<T{Number}>();";

        public const string FileStart = @"using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace RendleLabs.AspNetCore.RoutingWithServices
{
    public static class RouteBuilderMapVerbExtensions
    {";

        public const string FileEnd = @"    }
}";
        
        public const string DocComments =
            @"/// <summary>
        /// Adds a route to the <see cref=""IRouteBuilder""/> that only matches HTTP PATCH requests for the given <c>verb</c>, <c>template</c> and <c>handler</c>.
        /// </summary>
        /// <param name=""builder"">The <see cref=""IRouteBuilder""/></param>.
        /// <param name=""verb"">The HTTP verb allowed by the route.</param>
        /// <param name=""template"">The route template.</param>
        /// <param name=""handler"">The route handler.</param>
{TypeParams}
        /// <returns>The <see cref=""IRouteBuilder""/>.</returns>";

        public const string DocCommentsTypeParam = @"        /// <typeparam name=""T{n}"">A service object type to be resolved.</typeparam>";
    }
}