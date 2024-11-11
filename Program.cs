using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Configura el puerto para Railway (opcional si despliegas en Railway)
app.Urls.Add("http://0.0.0.0:8080");

// Ruta principal que muestra "Hola Mundo" en una página web
app.MapGet("/", () => Results.Content("<html><body><h1>Hola Mundo</h1></body></html>", "text/html"));

// Inicia la aplicación
app.Run();
