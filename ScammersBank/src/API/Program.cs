using API.Middlewares;
using Application;
using DbUp;
using Infrastructure;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//string connection = builder.Configuration.GetConnectionString("PostgreConnection") ?? throw new ArgumentNullException("PostgreConnection");
//EnsureDatabase.For.PostgresqlDatabase(connection);

//var upgrader = DeployChanges.To
//    .PostgresqlDatabase(connection)
//    .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
//    .Build();

//var result = upgrader.PerformUpgrade();

builder.Services.AddApplication();
builder.Services.AddInfrastructure();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseExceptionHandlingMiddleware();

app.MapControllers();

app.Run();
