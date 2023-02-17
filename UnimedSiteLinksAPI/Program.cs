using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using UnimedSiteLinksAPI.ContratosRepository;
using UnimedSiteLinksAPI.Data;
using UnimedSiteLinksAPI.InterfaceRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


/// ///////////////////////////////////////////////////////////////////////////////

builder.Services.AddCors();

builder.Services.AddEntityFrameworkSqlServer().AddDbContext<BancoContext>
(
options => options.UseSqlServer(builder.Configuration.GetConnectionString("Database"))
);

builder.Services.AddScoped<InterfaceUnimedLinks, UnimedLinksRepository>();
/// ///////////////////////////////////////////////////////////////////////////////







var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(policy =>
  policy.WithOrigins("https://localhost:7234", "https://localhost:7234")
  .AllowAnyMethod()
  .AllowAnyHeader()
  .WithHeaders(HeaderNames.ContentType)
);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
