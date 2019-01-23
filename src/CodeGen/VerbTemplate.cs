namespace CodeGen
{
    static class VerbTemplate
    {
        public const string MethodStart =
            @"        public static IRouteBuilder MapVerb<{TypeParams}>(this IRouteBuilder builder, string verb, string template, Func<HttpRequest, HttpResponse, RouteData, {TypeParams}, Task> handler)
        {
            return builder.MapVerb(verb, template, (request, response, routeData) =>
            {";

        public const string MethodEnd =
            @"                return handler(request, response, routeData, {Dependencies});
            });
        }";

        public const string GetRequiredService = "                var d{Number} = request.HttpContext.RequestServices.GetRequiredService<T{Number}>();";

        public const string FileStart = @"using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

// ReSharper disable once CheckNamespace
namespace Microsoft.AspNetCore.Routing
{
    public static class RouteBuilderMapVerbExtensions
    {";

        public const string FileEnd = @"    }
}";
    }
}