namespace CodeGen
{
    static class ConvenienceTemplate
    {
        public const string Method =
            @"        public static IRouteBuilder Map{Method}<{TypeParams}>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, {TypeParams}, Task> handler)
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
    }
}