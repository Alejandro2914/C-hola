using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Ignorar solicitudes de favicon.ico para evitar el error 502
app.Use(async (context, next) =>
{
    if (context.Request.Path == "/favicon.ico")
    {
        context.Response.StatusCode = 204; // No Content
        return;
    }
    await next();
});

// Configura el puerto para Railway (8080)
app.Urls.Add("http://0.0.0.0:8080");

// Configura la ruta principal para mostrar "Hola Mundo"
app.MapGet("/", () => Results.Content("<html><body><h1>Hola Mundo</h1></body></html>", "text/html"));

// Inicia la aplicación
app.Run();
