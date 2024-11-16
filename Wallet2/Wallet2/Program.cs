using Microsoft.EntityFrameworkCore;
using Wallet2.Services;
using Wallet2;
using Wallet2.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Добавляем сервисы и зависимости
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IMyEntityService, MyEntityService>();
builder.Services.AddScoped<IRepository<MyEntity>, MyEntityRepository>();

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
