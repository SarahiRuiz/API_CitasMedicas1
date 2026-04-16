    
using API_Citas.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();
builder.Services.AddDbContext<UsuarioContext>(options =>
{
    //options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.UseSqlite("Data Source=usuarios.db");
});
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
/*if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}*/

//app.UseHttpsRedirection();

//app.UseAuthorization();



builder.Services.AddCors();

app.UseCors(opt =>
{
    opt.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:3000");
});

app.MapControllers();

DbInitializer.InitDb(app);

app.Run();
