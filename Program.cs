var builder = WebApplication.CreateBuilder(args);

// Agregar servicios de controladores
builder.Services.AddControllers();

// Configurar Kestrel para que solo escuche en HTTP
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5000); // Cambia a otro puerto si es necesario
});

var app = builder.Build();

app.UseRouting();
app.MapControllers();

app.Run();