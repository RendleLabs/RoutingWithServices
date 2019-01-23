namespace CodeGen
{
    static class ConvenienceTemplate
    {
        public const string Method =
            @"        public static IRouteBuilder Map{Method}<{TypeParams}>(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, {TypeParams}, Task> handler)
            => builder.MapVerb<{TypeParams}>(""{Verb}"", template, handler);";

        public const string FileStart = @"using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

// ReSharper disable once CheckNamespace
namespace Microsoft.AspNetCore.Routing
{
    public static class RouteBuilderMap{Method}Extensions
    {";

        public const string FileEnd = @"    }
}";
    }
}