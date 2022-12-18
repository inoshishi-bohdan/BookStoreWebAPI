using BookStoreAPI.Configurations;
using BookStoreAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connection_string = builder.Configuration.GetConnectionString("BookStoreDBConnection");
builder.Services.AddDbContext<BookStoreDbContext>(options => options.UseSqlServer(connection_string));
builder.Services.AddAutoMapper(typeof(MapperConfig));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => options.AddPolicy("AllowAll",b => b.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAll");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
