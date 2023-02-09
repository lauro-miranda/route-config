using LM.RouteConfig.Api.Domain.Services;
using LM.RouteConfig.Api.Domain.Services.Contracts;
using LM.RouteConfig.Api.Infra.Services;
using LM.RouteConfig.Api.Infra.Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IInfoService, InfoService>();
builder.Services.AddScoped<IBrand, Brand>();

builder.Services.AddHttpContextAccessor();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();