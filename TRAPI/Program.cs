


using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TRAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<Context>(options =>
       options.UseSqlServer(@"Data Source=DESKTOP-5OJID68\GODSHOT;Initial Catalog=TrainingDB;User ID=test;Password=123"));
builder.Services.AddControllers().AddNewtonsoftJson(
    options => options.SerializerSettings.ReferenceLoopHandling =
        ReferenceLoopHandling.Ignore
);
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
