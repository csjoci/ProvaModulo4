namespace ProvaModulo4.CleanArch.Domain.Model;

public class Professor : IEntity
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public bool Ativo { get; set; }
    public List<Curso> Cursos { get; set; }

}
