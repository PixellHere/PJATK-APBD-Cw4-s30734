using Microsoft.EntityFrameworkCore;
using PJATK_APBD_Cw4_s30734.Infrastructre;
using PJATK_APBD_Cw4_s30734.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<DatabaseContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddScoped<IPCsService, PCsService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(opt => opt.SwaggerEndpoint("/openapi/v1.json", "Zadanie 4"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();