

using Microsoft.EntityFrameworkCore;
using PersonAPITest.Model.Context;
using PersonAPITest.Services;
using PersonAPITest.Services.Implementations;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddScoped<IPersonService, PersonServiceImplementation>();
builder.Services.AddControllers();
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<PgContext>(options =>
                    options.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=aspnet_api;User Id=developer;Password=root;"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
