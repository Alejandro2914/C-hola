using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Mostrar el "Hola Mundo" en la consola.
Console.WriteLine("Hola Mundo");

app.Run();