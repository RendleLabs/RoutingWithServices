namespace CodeGen
{
    static class ConvenienceTemplate
    {
        public const string Method =
            @"        {DocComments}
        public static IRouteBuilder Map{Method}<{TypeParams}>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, {TypeParams}, Task> handler)
            => builder.MapVerb(""{Verb}"", template, handler);
";

        public const string FileStart = @"using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace RendleLabs.AspNetCore.RoutingWithServices
{
    public static class RouteBuilderMap{Method}Extensions
    {";

        public const string FileEnd = @"    }
}";

        public const string DocComments =
            @"/// <summary>
        /// Adds a route to the <see cref=""IRouteBuilder""/> that only matches HTTP PATCH requests for the given <c>template</c> and <c>handler</c>.
        /// </summary>
        /// <param name=""builder"">The <see cref=""IRouteBuilder""/></param>.
        /// <param name=""template"">The route template.</param>
        /// <param name=""handler"">The route handler.</param>
{TypeParams}
        /// <returns>The <see cref=""IRouteBuilder""/>.</returns>";

        public const string DocCommentsTypeParam = @"        /// <typeparam name=""T{n}"">A service object type to be resolved.</typeparam>";
    }
}