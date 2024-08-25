using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using ProvaModulo4.CleanArch.Domain.Repository;
using ProvaModulo4.CleanArch.Data.Repository;
using Microsoft.EntityFrameworkCore;
using ProvaModulo4.CleanArch.Data;

namespace ProvaModulo4.CleanArch.IoC;

public class IoC
{
    public static void AddProjectsIocConfig(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IAlunoRepository, AlunoRepository>();
        services.AddScoped<IProfessorRepository,ProfessorRepository>();
        services.AddScoped<ICursoRepository, CursoRepository>();
        services.AddScoped<IMatriculaRepository, MatriculaRepository>();

        services.AddDbContext<Context>(options =>
           options.UseSqlServer(configuration.GetConnectionString("MinhaConexao")));

    }
}
