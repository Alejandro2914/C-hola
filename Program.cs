using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Configura el puerto para Railway (escuchar en el puerto 8080)
app.Urls.Add("http://0.0.0.0:8080");

// Muestra "Hola Mundo" en la ruta raíz
app.MapGet("/", () => "Hola Mundo");

// Inicia la aplicación
app.Run();