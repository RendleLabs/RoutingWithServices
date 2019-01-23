# RoutingWithServices
Extension methods for Dependency Injection in UseRouter

# Usage

These extensions let you provide overloaded `Func` delegates to the `Map*` and `MapVerb` extension methods on
[IRouteBuilder](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.routing.iroutebuilder).

Example:

```csharp
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    app.UseRouter(builder =>
    {
        builder.MapGet<IThings>("/{id}", async (request, response, routeData, things) =>
        {
            var id = routeData.Values["id"].ToString();
            var text = await things.GetThingJsonAsync(id);
            if (text == null)
            {
                response.StatusCode = 404;
                return;
            }
            response.StatusCode = 200;
            response.ContentType = "application/json";
            response.ContentLength = Encoding.UTF8.GetByteCount(text);
            await response.WriteAsync(text);
        });
    });
}
```

There are overloads up to eight type parameters for `MapGet`, `MapPost`, `MapPut`, `MapDelete` and `MapVerb`.
