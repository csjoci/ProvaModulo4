using Microsoft.EntityFrameworkCore;
using ProvaModulo4.CleanArch.Domain.Model;

namespace ProvaModulo4.CleanArch.Data;

public class Context : DbContext
{
    public DbSet<Aluno> Aluno { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Matricula> Matriculas { get; set; }
    public DbSet<Professor> Professores { get; set; }
    public Context(DbContextOptions<Context> options):base(options)
    {
        
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer("Server=SABRL9XPLD33; Database=MinhaBaseDados; " +
    //            "Trusted_Connection=True; TrustServerCertificate=True")
    //            .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);

    //    base.OnConfiguring(optionsBuilder);
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>()
            .HasMany(a => a.Matriculas)
            .WithOne(m => m.Aluno)
            .HasForeignKey(m => m.AlunoId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Curso>()
            .HasMany(c => c.Matriculas)
            .WithOne(m => m.Curso)
            .HasForeignKey(m => m.CursoId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Professor>()
            .HasMany(p => p.Cursos)
            .WithOne(c => c.Professor)
            .HasForeignKey(c => c.ProfessorId)
            .OnDelete(DeleteBehavior.Restrict);

        base.OnModelCreating(modelBuilder);

    }
}
