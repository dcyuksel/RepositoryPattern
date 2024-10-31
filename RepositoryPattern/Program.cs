using RepositoryPattern;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<RepositoryPatternDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:RepositoryPattern"], options => { options.CommandTimeout(30); });
});

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.UseAuthorization();

app.Run();