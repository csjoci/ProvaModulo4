using ProvaModulo4.CleanArch.Domain.Repository;
using ProvaModulo4.CleanArch.Data.Repository;
using ProvaModulo4.CleanArch.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//IConfiguration configuration = builder.Configuration;
//IoC.AddProjectsIocConfig(builder.Services, configuration);

builder.Services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddScoped<IProfessorRepository, ProfessorRepository>();
builder.Services.AddScoped<ICursoRepository, CursoRepository>();
builder.Services.AddScoped<IMatriculaRepository, MatriculaRepository>();

builder.Services.AddDbContext<Context>(options =>
           options.UseSqlServer(builder.Configuration.GetConnectionString("MinhaConexao")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
