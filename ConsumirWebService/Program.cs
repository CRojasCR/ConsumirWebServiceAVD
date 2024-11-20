using ConsumirWebService.Clases;
using ConsumirWebService.Servicios;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Establece el protocolo de seguridad TLS 1.2
ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
builder.Services.AddSingleton<cClienteAVD>();
builder.Services.AddScoped(provider =>
{
    var factory = provider.GetRequiredService<cClienteAVD>();
    return factory.crearCliente();
});
builder.Services.AddScoped<IServicio, Servicios>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();